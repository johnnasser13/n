
namespace WindowsFormsApp1
{
    partial class Fixed
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorText3 = new System.Windows.Forms.TextBox();
            this.funcText3 = new System.Windows.Forms.TextBox();
            this.xlText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rootText3 = new System.Windows.Forms.TextBox();
            this.outputText3 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(38)))), ((int)(((byte)(71)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 22);
            this.panel1.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1079, 54);
            this.panel6.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMPLE FIXED POINT METHOD";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button5.Location = new System.Drawing.Point(99, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 86);
            this.button5.TabIndex = 46;
            this.button5.Text = "Calculate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 40);
            this.label5.TabIndex = 45;
            this.label5.Text = "Xi=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 40);
            this.label2.TabIndex = 43;
            this.label2.Text = "ℰa=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 40);
            this.label4.TabIndex = 42;
            this.label4.Text = "f(x)=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorText3
            // 
            this.errorText3.Location = new System.Drawing.Point(126, 258);
            this.errorText3.Name = "errorText3";
            this.errorText3.Size = new System.Drawing.Size(93, 22);
            this.errorText3.TabIndex = 41;
            this.errorText3.TextChanged += new System.EventHandler(this.errorText3_TextChanged);
            // 
            // funcText3
            // 
            this.funcText3.Location = new System.Drawing.Point(126, 153);
            this.funcText3.Name = "funcText3";
            this.funcText3.Size = new System.Drawing.Size(229, 22);
            this.funcText3.TabIndex = 40;
            this.funcText3.TextChanged += new System.EventHandler(this.funcText3_TextChanged);
            // 
            // xlText
            // 
            this.xlText.Location = new System.Drawing.Point(126, 206);
            this.xlText.Name = "xlText";
            this.xlText.Size = new System.Drawing.Size(93, 22);
            this.xlText.TabIndex = 39;
            this.xlText.TextChanged += new System.EventHandler(this.xlText_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(590, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 40);
            this.label6.TabIndex = 48;
            this.label6.Text = "root=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rootText3
            // 
            this.rootText3.Location = new System.Drawing.Point(713, 567);
            this.rootText3.Name = "rootText3";
            this.rootText3.Size = new System.Drawing.Size(93, 22);
            this.rootText3.TabIndex = 47;
            // 
            // outputText3
            // 
            this.outputText3.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.outputText3.AutoSize = true;
            this.outputText3.BackColor = System.Drawing.Color.Azure;
            this.outputText3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.outputText3.Location = new System.Drawing.Point(467, 197);
            this.outputText3.MaximumSize = new System.Drawing.Size(500, 300);
            this.outputText3.MinimumSize = new System.Drawing.Size(500, 300);
            this.outputText3.Name = "outputText3";
            this.outputText3.Size = new System.Drawing.Size(500, 300);
            this.outputText3.TabIndex = 49;
            // 
            // Fixed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1079, 636);
            this.Controls.Add(this.rootText3);
            this.Controls.Add(this.outputText3);
            this.Controls.Add(this.errorText3);
            this.Controls.Add(this.funcText3);
            this.Controls.Add(this.xlText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Fixed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixed";
            this.Load += new System.EventHandler(this.Fixed_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox errorText3;
        private System.Windows.Forms.TextBox funcText3;
        private System.Windows.Forms.TextBox xlText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rootText3;
        private System.Windows.Forms.Label outputText3;
    }
}