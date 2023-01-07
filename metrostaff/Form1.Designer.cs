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
            this.Name = "Form1";
            this.Text = "MetroStaff";
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
    }
}