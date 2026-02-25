namespace SWENG421_Lab6.Models;

public sealed class GraphManager
{
    // Singleton pattern
    private static readonly Lazy<GraphManager> _instance =
        new(() => new GraphManager(), isThreadSafe: true);

    public static GraphManager Instance => _instance.Value;

    private GraphManager() { }

    // State
    private readonly Dictionary<int, Graph> _graphs = new();
    private int _nextGraphId = 1;

    public Graph CreateGraph()
    {
        int id = _nextGraphId++;
        var graph = new Graph(id);
        _graphs[id] = graph;
        return graph;
    }

    public Graph? GetGraph(int graphId) =>
        _graphs.TryGetValue(graphId, out var g) ? g : null;

    public IReadOnlyList<Graph> GetAllGraphs() =>
        _graphs.Values.OrderBy(g => g.GraphId).ToList().AsReadOnly();

    public Graph CopyGraph(int sourceGraphId)
    {
        var source = GetGraph(sourceGraphId)
            ?? throw new KeyNotFoundException($"Graph {sourceGraphId} not found.");
        int newId = _nextGraphId++;
        var copy = source.DeepCopy(newId);
        _graphs[newId] = copy;
        return copy;
    }

    public void AddVertex(int graphId, Vertex vertex)
    {
        var graph = GetGraph(graphId)
            ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.AddVertex(vertex);
    }

    public void AddEdge(int graphId, Edge edge)
    {
        var graph = GetGraph(graphId)
            ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.AddEdge(edge);
    }

    public void UpdateVertex(int graphId, int vertexId, int newX, int newY)
    {
        var graph = GetGraph(graphId)
            ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.UpdateVertex(vertexId, newX, newY);
    }

    public void UpdateEdge(int graphId, int edgeId, int newFromId, int newToId)
    {
        var graph = GetGraph(graphId)
            ?? throw new KeyNotFoundException($"Graph {graphId} not found.");
        graph.UpdateEdge(edgeId, newFromId, newToId);
    }
}