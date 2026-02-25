namespace SWENG421_Lab6.UI;

public partial class AddEdgeDialog : Form
{
    public int EdgeId { get; private set; }
    public int FromId { get; private set; }
    public int ToId   { get; private set; }

    public AddEdgeDialog()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        EdgeId = (int)nudEdgeId.Value;
        FromId = (int)nudFrom.Value;
        ToId   = (int)nudTo.Value;
        DialogResult = DialogResult.OK;
    }
}