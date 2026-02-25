using System.ComponentModel;

namespace SWENG421_Lab6.UI;

partial class AddVertexDialog{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        lblId = new System.Windows.Forms.Label();
        nudId = new System.Windows.Forms.NumericUpDown();
        lblX = new System.Windows.Forms.Label();
        nudX = new System.Windows.Forms.NumericUpDown();
        lblY = new System.Windows.Forms.Label();
        nudY = new System.Windows.Forms.NumericUpDown();
        btnOk = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
        SuspendLayout();
        // 
        // lblId
        // 
        lblId.Dock = System.Windows.Forms.DockStyle.Top;
        lblId.Location = new System.Drawing.Point(0, 0);
        lblId.Name = "lblId";
        lblId.Size = new System.Drawing.Size(184, 16);
        lblId.TabIndex = 0;
        lblId.Text = "Vertex ID:";
        // 
        // nudId
        // 
        nudId.Dock = System.Windows.Forms.DockStyle.Top;
        nudId.Location = new System.Drawing.Point(0, 16);
        nudId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudId.Name = "nudId";
        nudId.Size = new System.Drawing.Size(184, 23);
        nudId.TabIndex = 1;
        nudId.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblX
        // 
        lblX.Dock = System.Windows.Forms.DockStyle.Top;
        lblX.Location = new System.Drawing.Point(0, 39);
        lblX.Name = "lblX";
        lblX.Size = new System.Drawing.Size(184, 16);
        lblX.TabIndex = 2;
        lblX.Text = "X:";
        // 
        // nudX
        // 
        nudX.Dock = System.Windows.Forms.DockStyle.Top;
        nudX.Location = new System.Drawing.Point(0, 55);
        nudX.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
        nudX.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudX.Name = "nudX";
        nudX.Size = new System.Drawing.Size(184, 23);
        nudX.TabIndex = 3;
        nudX.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblY
        // 
        lblY.Dock = System.Windows.Forms.DockStyle.Top;
        lblY.Location = new System.Drawing.Point(0, 78);
        lblY.Name = "lblY";
        lblY.Size = new System.Drawing.Size(184, 16);
        lblY.TabIndex = 4;
        lblY.Text = "Y:";
        // 
        // nudY
        // 
        nudY.Dock = System.Windows.Forms.DockStyle.Top;
        nudY.Location = new System.Drawing.Point(0, 94);
        nudY.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
        nudY.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudY.Name = "nudY";
        nudY.Size = new System.Drawing.Size(184, 23);
        nudY.TabIndex = 5;
        nudY.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnOk
        // 
        btnOk.Dock = System.Windows.Forms.DockStyle.Top;
        btnOk.Location = new System.Drawing.Point(0, 117);
        btnOk.Name = "btnOk";
        btnOk.Size = new System.Drawing.Size(184, 24);
        btnOk.TabIndex = 6;
        btnOk.Text = "Ok";
        btnOk.UseVisualStyleBackColor = true;
        btnOk.Click += btnOk_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
        btnCancel.Location = new System.Drawing.Point(0, 141);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(184, 24);
        btnCancel.TabIndex = 7;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // AddVertexDialog
        // 
        AcceptButton = btnOk;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new System.Drawing.Size(184, 165);
        Controls.Add(btnCancel);
        Controls.Add(btnOk);
        Controls.Add(nudY);
        Controls.Add(lblY);
        Controls.Add(nudX);
        Controls.Add(lblX);
        Controls.Add(nudId);
        Controls.Add(lblId);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "AddVertexDialog";
        ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnCancel;

    private System.Windows.Forms.Button btnOk;

    private System.Windows.Forms.NumericUpDown nudY;

    private System.Windows.Forms.Label lblY;

    private System.Windows.Forms.NumericUpDown nudX;

    private System.Windows.Forms.Label lblX;

    private System.Windows.Forms.NumericUpDown nudId;

    private System.Windows.Forms.Label lblId;

    #endregion
}