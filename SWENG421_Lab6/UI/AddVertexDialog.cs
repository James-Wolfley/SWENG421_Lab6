namespace SWENG421_Lab6.UI;

public partial class AddVertexDialog : Form
{
    public int VertexId { get; private set; }
    public int X        { get; private set; }
    public int Y        { get; private set; }

    public AddVertexDialog()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        VertexId = (int)nudId.Value;
        X        = (int)nudX.Value;
        Y        = (int)nudY.Value;
        DialogResult = DialogResult.OK;
    }
}