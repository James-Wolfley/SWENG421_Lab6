namespace SWENG421_Lab6.UI;

public partial class UpdateEdgeDialog : Form
{
    public int EdgeId    { get; private set; }
    public int NewFromId { get; private set; }
    public int NewToId   { get; private set; }

    public UpdateEdgeDialog()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        EdgeId    = (int)nudEdgeId.Value;
        NewFromId = (int)nudFrom.Value;
        NewToId   = (int)nudTo.Value;
        DialogResult = DialogResult.OK;
    }
}