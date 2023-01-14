namespace metrostaff
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnAtan = new System.Windows.Forms.Button();
            this.btnAcos = new System.Windows.Forms.Button();
            this.btnAsin = new System.Windows.Forms.Button();
            this.btnfib = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(183, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 26);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(183, 256);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(47, 26);
            this.btnSub.TabIndex = 10;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(236, 256);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(47, 26);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(183, 118);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(157, 27);
            this.txtBox.TabIndex = 12;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(289, 206);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(51, 37);
            this.btnSqrt.TabIndex = 14;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(236, 217);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(47, 26);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(289, 151);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(51, 49);
            this.btnPow.TabIndex = 16;
            this.btnPow.Text = "Pow Of";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(205, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Personal Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 19;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(289, 249);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(51, 33);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(297, 288);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(51, 37);
            this.btnTan.TabIndex = 21;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(240, 288);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(51, 37);
            this.btnCos.TabIndex = 22;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(183, 288);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(51, 37);
            this.btnSin.TabIndex = 23;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnAtan
            // 
            this.btnAtan.Location = new System.Drawing.Point(346, 237);
            this.btnAtan.Name = "btnAtan";
            this.btnAtan.Size = new System.Drawing.Size(51, 37);
            this.btnAtan.TabIndex = 24;
            this.btnAtan.Text = "Atan";
            this.btnAtan.UseVisualStyleBackColor = true;
            this.btnAtan.Click += new System.EventHandler(this.btnAtan_Click);
            // 
            // btnAcos
            // 
            this.btnAcos.Location = new System.Drawing.Point(346, 194);
            this.btnAcos.Name = "btnAcos";
            this.btnAcos.Size = new System.Drawing.Size(51, 37);
            this.btnAcos.TabIndex = 25;
            this.btnAcos.Text = "Acos";
            this.btnAcos.UseVisualStyleBackColor = true;
            this.btnAcos.Click += new System.EventHandler(this.btnAcos_Click);
            // 
            // btnAsin
            // 
            this.btnAsin.Location = new System.Drawing.Point(346, 151);
            this.btnAsin.Name = "btnAsin";
            this.btnAsin.Size = new System.Drawing.Size(51, 37);
            this.btnAsin.TabIndex = 26;
            this.btnAsin.Text = "Asin";
            this.btnAsin.UseVisualStyleBackColor = true;
            this.btnAsin.Click += new System.EventHandler(this.btnAsin_Click);
            // 
            // btnfib
            // 
            this.btnfib.Location = new System.Drawing.Point(346, 276);
            this.btnfib.Name = "btnfib";
            this.btnfib.Size = new System.Drawing.Size(51, 49);
            this.btnfib.TabIndex = 27;
            this.btnfib.Text = "Fibonacci";
            this.btnfib.UseVisualStyleBackColor = true;
            this.btnfib.Click += new System.EventHandler(this.btnfib_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(346, 118);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(51, 27);
            this.btnCls.TabIndex = 28;
            this.btnCls.Text = "CLS";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnfib);
            this.Controls.Add(this.btnAsin);
            this.Controls.Add(this.btnAcos);
            this.Controls.Add(this.btnAtan);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private TextBox txtBox;
        private Button btnSqrt;
        private Button btnDiv;
        private Button btnPow;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnEqual;
        private Button btnTan;
        private Button btnCos;
        private Button btnSin;
        private Button btnAtan;
        private Button btnAcos;
        private Button btnAsin;
        private Button btnfib;
        private Button btnCls;
    }
}