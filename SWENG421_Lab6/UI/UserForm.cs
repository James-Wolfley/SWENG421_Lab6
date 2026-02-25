using SWENG421_Lab6.Models;

namespace SWENG421_Lab6.UI;

public partial class UserForm : Form
{
    private readonly string _userName;
    private readonly GraphManager _manager = GraphManager.Instance;
    private Graph? _displayedGraph;

    public UserForm(string userName)
    {
        InitializeComponent();
        _userName = userName;
        Text = $"Graph Manager — {userName}";
        RefreshGraphList();
    }

    private void RefreshGraphList()
    {
        int? selectedId = SelectedGraphId();
        lstGraphs.Items.Clear();
        foreach (var g in _manager.GetAllGraphs())
            lstGraphs.Items.Add(g.ToString());

        if (!selectedId.HasValue) return;
        for (int i = 0; i < lstGraphs.Items.Count; i++) {
            if (!lstGraphs.Items[i].ToString()!.StartsWith($"Graph {selectedId}")) continue;
            lstGraphs.SelectedIndex = i;
            break;
        }
    }

    private int? SelectedGraphId()
    {
        if (lstGraphs.SelectedItem is string s && s.StartsWith("Graph "))
        {
            var part = s.Split(' ')[1];
            if (int.TryParse(part, out int id)) return id;
        }
        return null;
    }

    private Graph? SelectedGraph()
    {
        var id = SelectedGraphId();
        return id.HasValue ? _manager.GetGraph(id.Value) : null;
    }

    private void SetStatus(string msg) => lblStatus.Text = $"[{_userName}] {msg}";

    private void btnCreate_Click(object sender, EventArgs e)
    {
        var g = _manager.CreateGraph();
        SetStatus($"Created {g}");
        RefreshGraphList();
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        var g = SelectedGraph();
        if (g == null) { MessageBox.Show("Select a graph to copy.", "No selection"); return; }
        var copy = _manager.CopyGraph(g.GraphId);
        SetStatus($"Copied Graph {g.GraphId} → {copy}");
        RefreshGraphList();
    }

    private void btnDisplay_Click(object sender, EventArgs e)
    {
        var g = SelectedGraph();
        if (g == null) { MessageBox.Show("Select a graph to display.", "No selection"); return; }
        _displayedGraph = g;
        pnlCanvas.Invalidate();
        SetStatus($"Displaying {g}");
    }

    private void btnAddVertex_Click(object sender, EventArgs e)
    {
        var g = SelectedGraph();
        if (g == null) { MessageBox.Show("Select a graph first.", "No selection"); return; }

        using var dlg = new AddVertexDialog();
        if (dlg.ShowDialog() != DialogResult.OK) return;

        try
        {
            var v = new Vertex(dlg.VertexId, dlg.X, dlg.Y);
            _manager.AddVertex(g.GraphId, v);
            SetStatus($"Added {v} to Graph {g.GraphId}");
            RefreshGraphList();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
    }

    private void btnAddEdge_Click(object sender, EventArgs e)
    {
        var g = SelectedGraph();
        if (g == null) { MessageBox.Show("Select a graph first.", "No selection"); return; }

        using var dlg = new AddEdgeDialog();
        if (dlg.ShowDialog() != DialogResult.OK) return;

        try
        {
            var from = g.GetVertex(dlg.FromId) ?? throw new KeyNotFoundException($"Vertex {dlg.FromId} not found.");
            var to   = g.GetVertex(dlg.ToId)   ?? throw new KeyNotFoundException($"Vertex {dlg.ToId} not found.");
            var edge = new Edge(dlg.EdgeId, from, to);
            _manager.AddEdge(g.GraphId, edge);
            SetStatus($"Added {edge} to Graph {g.GraphId}");
            RefreshGraphList();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshGraphList();
        SetStatus("List refreshed.");
    }

    private void pnlCanvas_Paint(object sender, PaintEventArgs e)
    {
        if (_displayedGraph == null) return;
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        _displayedGraph.Display(e.Graphics);
    }
}