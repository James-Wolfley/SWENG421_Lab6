namespace SWENG421_Lab6.Models;

public class Graph {
    public int GraphId { get; set; }
    private List<Vertex> _vertices = new();
    private List<Edge> _edges = new();

    public IReadOnlyList<Vertex> Vertices => _vertices.AsReadOnly();
    public IReadOnlyList<Edge> Edges => _edges.AsReadOnly();

    public Graph(int graphId) {
        GraphId = graphId;
    }

    public void AddVertex(Vertex v) {
        if (_vertices.Any(x => x.VertexId == v.VertexId))
            throw new InvalidOperationException($"Vertex ID {v.VertexId} already exists.");
        _vertices.Add(v);
    }

    public Vertex? GetVertex(int vertexId) =>
        _vertices.FirstOrDefault(v => v.VertexId == vertexId);

    public void UpdateVertex(int vertexId, int newX, int newY) {
        var v = GetVertex(vertexId)
                ?? throw new KeyNotFoundException($"Vertex {vertexId} not found.");
        v.X = newX;
        v.Y = newY;
    }

    public void AddEdge(Edge e) {
        if (_edges.Any(x => x.EdgeId == e.EdgeId))
            throw new InvalidOperationException($"Edge ID {e.EdgeId} already exists.");
        _edges.Add(e);
    }

    public Edge? GetEdge(int edgeId) =>
        _edges.FirstOrDefault(e => e.EdgeId == edgeId);

    public void UpdateEdge(int edgeId, int newFromId, int newToId) {
        var edge = GetEdge(edgeId)
                   ?? throw new KeyNotFoundException($"Edge {edgeId} not found.");
        edge.FromVertex = GetVertex(newFromId)
                          ?? throw new KeyNotFoundException($"Vertex {newFromId} not found.");
        edge.ToVertex = GetVertex(newToId)
                        ?? throw new KeyNotFoundException($"Vertex {newToId} not found.");
    }

    public Graph DeepCopy(int newGraphId) {
        var copy = new Graph(newGraphId);

        var vertexMap = new Dictionary<int, Vertex>();
        foreach (var v in _vertices) {
            var vCopy = new Vertex(v);
            copy._vertices.Add(vCopy);
            vertexMap[v.VertexId] = vCopy;
        }

        foreach (var e in _edges) {
            var eCopy = new Edge(e, vertexMap[e.FromVertex.VertexId], vertexMap[e.ToVertex.VertexId]);
            copy._edges.Add(eCopy);
        }

        return copy;
    }

    public void Display(Graphics g) {
        foreach (var edge in _edges)
            edge.Drawing(g);
        foreach (var vertex in _vertices)
            vertex.Drawing(g);
    }

    public override string ToString() =>
        $"Graph {GraphId} [{_vertices.Count} vertices, {_edges.Count} edges]";
}