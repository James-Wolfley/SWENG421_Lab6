using System.ComponentModel;

namespace SWENG421_Lab6.UI;

partial class UpdateEdgeDialog 
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        lblEdgeId = new System.Windows.Forms.Label();
        nudEdgeId = new System.Windows.Forms.NumericUpDown();
        lblFrom = new System.Windows.Forms.Label();
        nudFrom = new System.Windows.Forms.NumericUpDown();
        lblTo = new System.Windows.Forms.Label();
        nudTo = new System.Windows.Forms.NumericUpDown();
        btnOk = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)nudEdgeId).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudFrom).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTo).BeginInit();
        SuspendLayout();
        // 
        // lblEdgeId
        // 
        lblEdgeId.Dock = System.Windows.Forms.DockStyle.Top;
        lblEdgeId.Location = new System.Drawing.Point(0, 0);
        lblEdgeId.Name = "lblEdgeId";
        lblEdgeId.Size = new System.Drawing.Size(184, 16);
        lblEdgeId.TabIndex = 7;
        lblEdgeId.Text = "Edge ID:";
        // 
        // nudEdgeId
        // 
        nudEdgeId.Dock = System.Windows.Forms.DockStyle.Top;
        nudEdgeId.Location = new System.Drawing.Point(0, 16);
        nudEdgeId.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudEdgeId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudEdgeId.Name = "nudEdgeId";
        nudEdgeId.Size = new System.Drawing.Size(184, 23);
        nudEdgeId.TabIndex = 6;
        nudEdgeId.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblFrom
        // 
        lblFrom.Dock = System.Windows.Forms.DockStyle.Top;
        lblFrom.Location = new System.Drawing.Point(0, 39);
        lblFrom.Name = "lblFrom";
        lblFrom.Size = new System.Drawing.Size(184, 16);
        lblFrom.TabIndex = 5;
        lblFrom.Text = "From Vertex ID:";
        // 
        // nudFrom
        // 
        nudFrom.Dock = System.Windows.Forms.DockStyle.Top;
        nudFrom.Location = new System.Drawing.Point(0, 55);
        nudFrom.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudFrom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudFrom.Name = "nudFrom";
        nudFrom.Size = new System.Drawing.Size(184, 23);
        nudFrom.TabIndex = 4;
        nudFrom.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblTo
        // 
        lblTo.Dock = System.Windows.Forms.DockStyle.Top;
        lblTo.Location = new System.Drawing.Point(0, 78);
        lblTo.Name = "lblTo";
        lblTo.Size = new System.Drawing.Size(184, 16);
        lblTo.TabIndex = 3;
        lblTo.Text = "To Vertex ID:";
        // 
        // nudTo
        // 
        nudTo.Dock = System.Windows.Forms.DockStyle.Top;
        nudTo.Location = new System.Drawing.Point(0, 94);
        nudTo.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudTo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudTo.Name = "nudTo";
        nudTo.Size = new System.Drawing.Size(184, 23);
        nudTo.TabIndex = 2;
        nudTo.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnOk
        // 
        btnOk.Dock = System.Windows.Forms.DockStyle.Top;
        btnOk.Location = new System.Drawing.Point(0, 117);
        btnOk.Name = "btnOk";
        btnOk.Size = new System.Drawing.Size(184, 28);
        btnOk.TabIndex = 1;
        btnOk.Text = "OK";
        btnOk.UseVisualStyleBackColor = true;
        btnOk.Click += btnOk_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
        btnCancel.Location = new System.Drawing.Point(0, 145);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(184, 28);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        //UpdateEdgeDialog 
        // 
        AcceptButton = btnOk;
        CancelButton = btnCancel;
        ClientSize = new System.Drawing.Size(184, 165);
        Controls.Add(btnCancel);
        Controls.Add(btnOk);
        Controls.Add(nudTo);
        Controls.Add(lblTo);
        Controls.Add(nudFrom);
        Controls.Add(lblFrom);
        Controls.Add(nudEdgeId);
        Controls.Add(lblEdgeId);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Add Edge";
        ((System.ComponentModel.ISupportInitialize)nudEdgeId).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudFrom).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTo).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label         lblEdgeId;
    private System.Windows.Forms.NumericUpDown nudEdgeId;
    private System.Windows.Forms.Label         lblFrom;
    private System.Windows.Forms.NumericUpDown nudFrom;
    private System.Windows.Forms.Label         lblTo;
    private System.Windows.Forms.NumericUpDown nudTo;
    private System.Windows.Forms.Button        btnOk;
    private System.Windows.Forms.Button        btnCancel;
}