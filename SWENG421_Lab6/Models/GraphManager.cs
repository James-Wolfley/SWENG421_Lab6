namespace SWENG421_Lab6.Models;

public sealed class GraphManager {
    private static readonly Lazy<GraphManager> _instance =
        new(() => new GraphManager(), isThreadSafe: true);

    public static GraphManager Instance => _instance.Value;

    private GraphManager() { }

    public event EventHandler? GraphsChanged;
    private void OnGraphsChanged() => GraphsChanged?.Invoke(this, EventArgs.Empty);
    public event EventHandler<int>? GraphUpdated;
    private void OnGraphUpdated(int graphId) => GraphUpdated?.Invoke(this, graphId);

    private readonly Dictionary<int, Graph> _graphs = new();
    private int _nextGraphId = 1;

    public Graph CreateGraph() {
        int id = _nextGraphId++;
        var graph = new Graph(id);
        _graphs[id] = graph;
        OnGraphsChanged();
        return graph;
    }

    public Graph? GetGraph(int graphId) =>
        _graphs.TryGetValue(graphId, out var g) ? g : null;

    public IReadOnlyList<Graph> GetAllGraphs() =>
        _graphs.Values.OrderBy(g => g.GraphId).ToList().AsReadOnly();

    public Graph CopyGraph(int sourceGraphId) {
        var source = GetGraph(sourceGraphId)
                     ?? throw new KeyNotFoundException($"Graph {sourceGraphId} not found.");
        int newId = _nextGraphId++;
        var copy = source.DeepCopy(newId);
        _graphs[newId] = copy;
        OnGraphsChanged();
        return copy;
    }

    public void AddVertex(int graphId, Vertex vertex) {
        var graph = GetGraph(graphId)
                    ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.AddVertex(vertex);
        OnGraphsChanged();
    }

    public void AddEdge(int graphId, Edge edge) {
        var graph = GetGraph(graphId)
                    ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.AddEdge(edge);
        OnGraphsChanged();
    }

    public void UpdateVertex(int graphId, int vertexId, int newX, int newY) {
        var graph = GetGraph(graphId)
                    ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.UpdateVertex(vertexId, newX, newY);
        OnGraphUpdated(graphId);
        OnGraphsChanged();
    }

    public void UpdateEdge(int graphId, int edgeId, int newFromId, int newToId) {
        var graph = GetGraph(graphId)
                    ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.UpdateEdge(edgeId, newFromId, newToId);
        OnGraphUpdated(graphId);
        OnGraphsChanged();
    }
}