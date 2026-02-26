namespace SWENG421_Lab6.UI;

partial class UserForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        pnlToolbar = new System.Windows.Forms.Panel();
        btnUpdateEdge = new System.Windows.Forms.Button();
        btnUpdateVertex = new System.Windows.Forms.Button();
        btnAddEdge = new System.Windows.Forms.Button();
        btnAddVertex = new System.Windows.Forms.Button();
        btnDisplay = new System.Windows.Forms.Button();
        btnCopy = new System.Windows.Forms.Button();
        btnCreate = new System.Windows.Forms.Button();
        pnlLeft = new System.Windows.Forms.Panel();
        lstGraphs = new System.Windows.Forms.ListBox();
        btnRefresh = new System.Windows.Forms.Button();
        lblGraphs = new System.Windows.Forms.Label();
        lblStatus = new System.Windows.Forms.Label();
        pnlCanvas = new System.Windows.Forms.Panel();
        pnlToolbar.SuspendLayout();
        pnlLeft.SuspendLayout();
        SuspendLayout();
        // 
        // pnlToolbar
        // 
        pnlToolbar.Controls.Add(btnUpdateEdge);
        pnlToolbar.Controls.Add(btnUpdateVertex);
        pnlToolbar.Controls.Add(btnAddEdge);
        pnlToolbar.Controls.Add(btnAddVertex);
        pnlToolbar.Controls.Add(btnDisplay);
        pnlToolbar.Controls.Add(btnCopy);
        pnlToolbar.Controls.Add(btnCreate);
        pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
        pnlToolbar.Location = new System.Drawing.Point(0, 0);
        pnlToolbar.Name = "pnlToolbar";
        pnlToolbar.Size = new System.Drawing.Size(884, 45);
        pnlToolbar.TabIndex = 0;
        // 
        // btnUpdateEdge
        // 
        btnUpdateEdge.Location = new System.Drawing.Point(639, 3);
        btnUpdateEdge.Name = "btnUpdateEdge";
        btnUpdateEdge.Size = new System.Drawing.Size(100, 39);
        btnUpdateEdge.TabIndex = 6;
        btnUpdateEdge.Text = "Update Edge";
        btnUpdateEdge.UseVisualStyleBackColor = true;
        btnUpdateEdge.Click += btnUpdateEdge_Click;
        // 
        // btnUpdateVertex
        // 
        btnUpdateVertex.Location = new System.Drawing.Point(533, 3);
        btnUpdateVertex.Name = "btnUpdateVertex";
        btnUpdateVertex.Size = new System.Drawing.Size(100, 39);
        btnUpdateVertex.TabIndex = 5;
        btnUpdateVertex.Text = "Update Vertex";
        btnUpdateVertex.UseVisualStyleBackColor = true;
        btnUpdateVertex.Click += btnUpdateVertex_Click;
        // 
        // btnAddEdge
        // 
        btnAddEdge.Location = new System.Drawing.Point(427, 3);
        btnAddEdge.Name = "btnAddEdge";
        btnAddEdge.Size = new System.Drawing.Size(100, 39);
        btnAddEdge.TabIndex = 4;
        btnAddEdge.Text = "Add Edge";
        btnAddEdge.UseVisualStyleBackColor = true;
        btnAddEdge.Click += btnAddEdge_Click;
        // 
        // btnAddVertex
        // 
        btnAddVertex.Location = new System.Drawing.Point(321, 3);
        btnAddVertex.Name = "btnAddVertex";
        btnAddVertex.Size = new System.Drawing.Size(100, 39);
        btnAddVertex.TabIndex = 3;
        btnAddVertex.Text = "Add Vertex";
        btnAddVertex.UseVisualStyleBackColor = true;
        btnAddVertex.Click += btnAddVertex_Click;
        // 
        // btnDisplay
        // 
        btnDisplay.Location = new System.Drawing.Point(215, 3);
        btnDisplay.Name = "btnDisplay";
        btnDisplay.Size = new System.Drawing.Size(100, 39);
        btnDisplay.TabIndex = 2;
        btnDisplay.Text = "Display Graph";
        btnDisplay.UseVisualStyleBackColor = true;
        btnDisplay.Click += btnDisplay_Click;
        // 
        // btnCopy
        // 
        btnCopy.Location = new System.Drawing.Point(109, 3);
        btnCopy.Name = "btnCopy";
        btnCopy.Size = new System.Drawing.Size(100, 39);
        btnCopy.TabIndex = 1;
        btnCopy.Text = "Copy Graph";
        btnCopy.UseVisualStyleBackColor = true;
        btnCopy.Click += btnCopy_Click;
        // 
        // btnCreate
        // 
        btnCreate.Location = new System.Drawing.Point(3, 3);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new System.Drawing.Size(100, 39);
        btnCreate.TabIndex = 0;
        btnCreate.Text = "Create Graph";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreate_Click;
        // 
        // pnlLeft
        // 
        pnlLeft.Controls.Add(lstGraphs);
        pnlLeft.Controls.Add(btnRefresh);
        pnlLeft.Controls.Add(lblGraphs);
        pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
        pnlLeft.Location = new System.Drawing.Point(0, 45);
        pnlLeft.Name = "pnlLeft";
        pnlLeft.Size = new System.Drawing.Size(200, 516);
        pnlLeft.TabIndex = 1;
        // 
        // lstGraphs
        // 
        lstGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
        lstGraphs.FormattingEnabled = true;
        lstGraphs.Location = new System.Drawing.Point(0, 23);
        lstGraphs.Name = "lstGraphs";
        lstGraphs.Size = new System.Drawing.Size(200, 459);
        lstGraphs.TabIndex = 3;
        // 
        // btnRefresh
        // 
        btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
        btnRefresh.Location = new System.Drawing.Point(0, 482);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new System.Drawing.Size(200, 34);
        btnRefresh.TabIndex = 2;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // lblGraphs
        // 
        lblGraphs.Dock = System.Windows.Forms.DockStyle.Top;
        lblGraphs.Location = new System.Drawing.Point(0, 0);
        lblGraphs.Name = "lblGraphs";
        lblGraphs.Size = new System.Drawing.Size(200, 23);
        lblGraphs.TabIndex = 0;
        lblGraphs.Text = "Graphs:";
        // 
        // lblStatus
        // 
        lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblStatus.Location = new System.Drawing.Point(200, 527);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(684, 34);
        lblStatus.TabIndex = 2;
        lblStatus.Text = "Ready.";
        lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pnlCanvas
        // 
        pnlCanvas.BackColor = System.Drawing.Color.White;
        pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlCanvas.Location = new System.Drawing.Point(200, 45);
        pnlCanvas.Name = "pnlCanvas";
        pnlCanvas.Size = new System.Drawing.Size(684, 482);
        pnlCanvas.TabIndex = 3;
        pnlCanvas.Paint += pnlCanvas_Paint;
        // 
        // UserForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(884, 561);
        Controls.Add(pnlCanvas);
        Controls.Add(lblStatus);
        Controls.Add(pnlLeft);
        Controls.Add(pnlToolbar);
        Text = "Form1";
        pnlToolbar.ResumeLayout(false);
        pnlLeft.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnUpdateVertex;
    private System.Windows.Forms.Button btnUpdateEdge;

    private System.Windows.Forms.Panel pnlCanvas;

    private System.Windows.Forms.Label lblStatus;

    private System.Windows.Forms.Button btnRefresh;

    private System.Windows.Forms.Label lblGraphs;
    private System.Windows.Forms.ListBox lstGraphs;

    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.Button btnDisplay;
    private System.Windows.Forms.Button btnAddVertex;
    private System.Windows.Forms.Button btnAddEdge;
    private System.Windows.Forms.Panel pnlLeft;

    private System.Windows.Forms.Panel pnlToolbar;

    #endregion
}