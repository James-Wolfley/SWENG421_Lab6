namespace SWENG421_Lab6.Models;

public class Edge {
    public int EdgeId { get; set; }
    public Vertex FromVertex { get; set; }
    public Vertex ToVertex { get; set; }

    public Edge(int edgeId, Vertex from, Vertex to) {
        EdgeId = edgeId;
        FromVertex = from;
        ToVertex = to;
    }

    public Edge(Edge other, Vertex from, Vertex to) {
        EdgeId = other.EdgeId;
        FromVertex = from;
        ToVertex = to;
    }

    public void Drawing(Graphics g) {
        int x1 = FromVertex.X, y1 = FromVertex.Y;
        int x2 = ToVertex.X, y2 = ToVertex.Y;

        g.DrawLine(new Pen(Color.DarkRed), x1, y1, x2, y2);

        double angle = Math.Atan2(y2 - y1, x2 - x1);
        double arrowLen = 15;
        double arrowAngle = Math.PI / 6;

        int ax1 = (int)(x2 - arrowLen * Math.Cos(angle - arrowAngle));
        int ay1 = (int)(y2 - arrowLen * Math.Sin(angle - arrowAngle));
        int ax2 = (int)(x2 - arrowLen * Math.Cos(angle + arrowAngle));
        int ay2 = (int)(y2 - arrowLen * Math.Sin(angle + arrowAngle));

        g.DrawLine(Pens.DarkRed, x2, y2, ax1, ay1);
        g.DrawLine(Pens.DarkRed, x2, y2, ax2, ay2);

        g.DrawString($"E{EdgeId}",
            new Font("Arial", 8),
            Brushes.DarkGreen,
            (x1 + x2) / 2, (y1 + y2) / 2);
    }

    public override string ToString() => $"E{EdgeId}: V{FromVertex.VertexId} -> V{ToVertex.VertexId}";
}