namespace xroot
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.calc = new System.Windows.Forms.Button();
            this.rootfield = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.TextBox();
            this.nfield = new System.Windows.Forms.TextBox();
            this.expfield = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc.ForeColor = System.Drawing.Color.Black;
            this.calc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calc.Location = new System.Drawing.Point(31, 376);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(323, 37);
            this.calc.TabIndex = 0;
            this.calc.Text = "Calc";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // rootfield
            // 
            this.rootfield.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rootfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootfield.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rootfield.Location = new System.Drawing.Point(215, 197);
            this.rootfield.Name = "rootfield";
            this.rootfield.Size = new System.Drawing.Size(51, 28);
            this.rootfield.TabIndex = 1;
            this.rootfield.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.Control;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pic.Enabled = false;
            this.pic.Font = new System.Drawing.Font("Anurati", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pic.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pic.Location = new System.Drawing.Point(145, 136);
            this.pic.Name = "pic";
            this.pic.ReadOnly = true;
            this.pic.Size = new System.Drawing.Size(64, 116);
            this.pic.TabIndex = 2;
            this.pic.Text = "√";
            this.pic.TextChanged += new System.EventHandler(this.pic_TextChanged);
            // 
            // nfield
            // 
            this.nfield.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nfield.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nfield.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nfield.Location = new System.Drawing.Point(136, 167);
            this.nfield.Name = "nfield";
            this.nfield.Size = new System.Drawing.Size(31, 18);
            this.nfield.TabIndex = 3;
            // 
            // expfield
            // 
            this.expfield.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.expfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expfield.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expfield.Location = new System.Drawing.Point(260, 179);
            this.expfield.Name = "expfield";
            this.expfield.Size = new System.Drawing.Size(36, 22);
            this.expfield.TabIndex = 0;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlDark;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(98, 34);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(207, 22);
            this.output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.expfield);
            this.Controls.Add(this.nfield);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.rootfield);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calc;
        private TextBox rootfield;
        private TextBox nfield;
        private TextBox pic;
        private TextBox expfield;
        private TextBox output;
    }
}