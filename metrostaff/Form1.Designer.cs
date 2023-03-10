namespace metrostaff
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetInstance = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblXAxis = new System.Windows.Forms.Label();
            this.lblYAxis = new System.Windows.Forms.Label();
            this.lblZAxis = new System.Windows.Forms.Label();
            this.txtXAxis = new System.Windows.Forms.TextBox();
            this.txtYAxis = new System.Windows.Forms.TextBox();
            this.txtZAxis = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.machineSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetInstance
            // 
            this.btnGetInstance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetInstance.Location = new System.Drawing.Point(427, 162);
            this.btnGetInstance.Name = "btnGetInstance";
            this.btnGetInstance.Size = new System.Drawing.Size(94, 29);
            this.btnGetInstance.TabIndex = 0;
            this.btnGetInstance.Text = "Get Instant";
            this.btnGetInstance.UseVisualStyleBackColor = false;
            this.btnGetInstance.Click += new System.EventHandler(this.btnGetInstance_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetData.Location = new System.Drawing.Point(427, 127);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(94, 29);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblXAxis
            // 
            this.lblXAxis.AutoSize = true;
            this.lblXAxis.Location = new System.Drawing.Point(240, 118);
            this.lblXAxis.Name = "lblXAxis";
            this.lblXAxis.Size = new System.Drawing.Size(51, 20);
            this.lblXAxis.TabIndex = 2;
            this.lblXAxis.Text = "X-Axis";
            // 
            // lblYAxis
            // 
            this.lblYAxis.AutoSize = true;
            this.lblYAxis.Location = new System.Drawing.Point(240, 151);
            this.lblYAxis.Name = "lblYAxis";
            this.lblYAxis.Size = new System.Drawing.Size(50, 20);
            this.lblYAxis.TabIndex = 3;
            this.lblYAxis.Text = "Y-Axis";
            // 
            // lblZAxis
            // 
            this.lblZAxis.AutoSize = true;
            this.lblZAxis.Location = new System.Drawing.Point(240, 184);
            this.lblZAxis.Name = "lblZAxis";
            this.lblZAxis.Size = new System.Drawing.Size(51, 20);
            this.lblZAxis.TabIndex = 4;
            this.lblZAxis.Text = "Z-Axis";
            // 
            // txtXAxis
            // 
            this.txtXAxis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtXAxis.Location = new System.Drawing.Point(296, 111);
            this.txtXAxis.Name = "txtXAxis";
            this.txtXAxis.Size = new System.Drawing.Size(125, 27);
            this.txtXAxis.TabIndex = 5;
            // 
            // txtYAxis
            // 
            this.txtYAxis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtYAxis.Location = new System.Drawing.Point(296, 144);
            this.txtYAxis.Name = "txtYAxis";
            this.txtYAxis.Size = new System.Drawing.Size(125, 27);
            this.txtYAxis.TabIndex = 6;
            // 
            // txtZAxis
            // 
            this.txtZAxis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtZAxis.Location = new System.Drawing.Point(296, 177);
            this.txtZAxis.Name = "txtZAxis";
            this.txtZAxis.Size = new System.Drawing.Size(125, 27);
            this.txtZAxis.TabIndex = 7;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(240, 69);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(233, 20);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Machine System Assignment MAC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineSystemToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // machineSystemToolStripMenuItem
            // 
            this.machineSystemToolStripMenuItem.Name = "machineSystemToolStripMenuItem";
            this.machineSystemToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.machineSystemToolStripMenuItem.Text = "Machine System";
            this.machineSystemToolStripMenuItem.Click += new System.EventHandler(this.machineSystemToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(797, 431);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtZAxis);
            this.Controls.Add(this.txtYAxis);
            this.Controls.Add(this.txtXAxis);
            this.Controls.Add(this.lblZAxis);
            this.Controls.Add(this.lblYAxis);
            this.Controls.Add(this.lblXAxis);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnGetInstance);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MetroStaff";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetInstance;
        private Button btnGetData;
        private Label lblXAxis;
        private Label lblYAxis;
        private Label lblZAxis;
        private TextBox txtXAxis;
        private TextBox txtYAxis;
        private TextBox txtZAxis;
        private Label lblHeader;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem machineSystemToolStripMenuItem;
        private ToolStripMenuItem calculatorToolStripMenuItem;
    }
}