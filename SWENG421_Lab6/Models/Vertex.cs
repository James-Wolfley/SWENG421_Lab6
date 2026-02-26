namespace SWENG421_Lab6.Models;

public class Vertex {
    public int VertexId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Vertex(int vertexId, int x, int y) {
        VertexId = vertexId;
        X = x;
        Y = y;
    }

    public Vertex(Vertex v) {
        VertexId = v.VertexId;
        X = v.X;
        Y = v.Y;
    }

    public void Drawing(Graphics g) {
        int radius = 20;
        Rectangle rect = new Rectangle(X - radius, Y - radius, radius * 2, radius * 2);
        g.FillEllipse(Brushes.LightBlue, rect);
        g.DrawEllipse(Pens.DarkBlue, rect);
        g.DrawString(VertexId.ToString(),
            new Font("Arial", 9, FontStyle.Bold),
            Brushes.Black, X - 7, Y - 7);
    }

    public override string ToString() => $"V{VertexId} ({X},{Y})";
}