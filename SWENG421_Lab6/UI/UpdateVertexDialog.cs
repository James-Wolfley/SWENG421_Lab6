namespace SWENG421_Lab6.UI;

public partial class UpdateVertexDialog : Form
{
    public int VertexId { get; private set; }
    public int NewX     { get; private set; }
    public int NewY     { get; private set; }

    public UpdateVertexDialog()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        VertexId = (int)nudId.Value;
        NewX     = (int)nudX.Value;
        NewY     = (int)nudY.Value;
        DialogResult = DialogResult.OK;
    }
}