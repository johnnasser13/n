
namespace WindowsFormsApp1
{
    partial class GaussElimination
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_00 = new System.Windows.Forms.TextBox();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.txt_03 = new System.Windows.Forms.TextBox();
            this.txt_10 = new System.Windows.Forms.TextBox();
            this.txt_11 = new System.Windows.Forms.TextBox();
            this.txt_12 = new System.Windows.Forms.TextBox();
            this.txt_13 = new System.Windows.Forms.TextBox();
            this.txt_20 = new System.Windows.Forms.TextBox();
            this.txt_21 = new System.Windows.Forms.TextBox();
            this.txt_22 = new System.Windows.Forms.TextBox();
            this.txt_23 = new System.Windows.Forms.TextBox();
            this.txt_r23 = new System.Windows.Forms.TextBox();
            this.txt_r22 = new System.Windows.Forms.TextBox();
            this.txt_r21 = new System.Windows.Forms.TextBox();
            this.txt_r20 = new System.Windows.Forms.TextBox();
            this.txt_r13 = new System.Windows.Forms.TextBox();
            this.txt_r12 = new System.Windows.Forms.TextBox();
            this.txt_r11 = new System.Windows.Forms.TextBox();
            this.txt_r10 = new System.Windows.Forms.TextBox();
            this.txt_r03 = new System.Windows.Forms.TextBox();
            this.txt_r02 = new System.Windows.Forms.TextBox();
            this.txt_r01 = new System.Windows.Forms.TextBox();
            this.txt_r00 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.txt_m32 = new System.Windows.Forms.TextBox();
            this.txt_x3 = new System.Windows.Forms.TextBox();
            this.txt_m31 = new System.Windows.Forms.TextBox();
            this.txt_m21 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1237, 54);
            this.panel6.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gauss Elimination";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(38)))), ((int)(((byte)(71)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 22);
            this.panel1.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button5.Location = new System.Drawing.Point(396, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 86);
            this.button5.TabIndex = 26;
            this.button5.Text = "Calculate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_00
            // 
            this.txt_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_00.Location = new System.Drawing.Point(181, 104);
            this.txt_00.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_00.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_00.Name = "txt_00";
            this.txt_00.Size = new System.Drawing.Size(100, 27);
            this.txt_00.TabIndex = 27;
            // 
            // txt_01
            // 
            this.txt_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_01.Location = new System.Drawing.Point(332, 104);
            this.txt_01.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_01.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(100, 27);
            this.txt_01.TabIndex = 28;
            // 
            // txt_02
            // 
            this.txt_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_02.Location = new System.Drawing.Point(485, 104);
            this.txt_02.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_02.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(100, 27);
            this.txt_02.TabIndex = 29;
            // 
            // txt_03
            // 
            this.txt_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_03.Location = new System.Drawing.Point(638, 104);
            this.txt_03.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_03.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_03.Name = "txt_03";
            this.txt_03.Size = new System.Drawing.Size(100, 27);
            this.txt_03.TabIndex = 30;
            // 
            // txt_10
            // 
            this.txt_10.Location = new System.Drawing.Point(181, 152);
            this.txt_10.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_10.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_10.Name = "txt_10";
            this.txt_10.Size = new System.Drawing.Size(100, 22);
            this.txt_10.TabIndex = 31;
            // 
            // txt_11
            // 
            this.txt_11.Location = new System.Drawing.Point(332, 152);
            this.txt_11.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_11.Name = "txt_11";
            this.txt_11.Size = new System.Drawing.Size(100, 22);
            this.txt_11.TabIndex = 32;
            // 
            // txt_12
            // 
            this.txt_12.Location = new System.Drawing.Point(485, 152);
            this.txt_12.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_12.Name = "txt_12";
            this.txt_12.Size = new System.Drawing.Size(100, 22);
            this.txt_12.TabIndex = 33;
            // 
            // txt_13
            // 
            this.txt_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_13.Location = new System.Drawing.Point(638, 152);
            this.txt_13.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_13.Name = "txt_13";
            this.txt_13.Size = new System.Drawing.Size(100, 27);
            this.txt_13.TabIndex = 34;
            // 
            // txt_20
            // 
            this.txt_20.Location = new System.Drawing.Point(181, 205);
            this.txt_20.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_20.Name = "txt_20";
            this.txt_20.Size = new System.Drawing.Size(100, 22);
            this.txt_20.TabIndex = 35;
            // 
            // txt_21
            // 
            this.txt_21.Location = new System.Drawing.Point(332, 205);
            this.txt_21.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_21.Name = "txt_21";
            this.txt_21.Size = new System.Drawing.Size(100, 22);
            this.txt_21.TabIndex = 36;
            // 
            // txt_22
            // 
            this.txt_22.Location = new System.Drawing.Point(485, 205);
            this.txt_22.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_22.Name = "txt_22";
            this.txt_22.Size = new System.Drawing.Size(100, 22);
            this.txt_22.TabIndex = 37;
            // 
            // txt_23
            // 
            this.txt_23.Location = new System.Drawing.Point(638, 205);
            this.txt_23.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_23.Name = "txt_23";
            this.txt_23.Size = new System.Drawing.Size(100, 22);
            this.txt_23.TabIndex = 38;
            // 
            // txt_r23
            // 
            this.txt_r23.Location = new System.Drawing.Point(638, 522);
            this.txt_r23.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r23.Name = "txt_r23";
            this.txt_r23.Size = new System.Drawing.Size(100, 22);
            this.txt_r23.TabIndex = 50;
            // 
            // txt_r22
            // 
            this.txt_r22.Location = new System.Drawing.Point(485, 522);
            this.txt_r22.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r22.Name = "txt_r22";
            this.txt_r22.ReadOnly = true;
            this.txt_r22.Size = new System.Drawing.Size(100, 22);
            this.txt_r22.TabIndex = 49;
            // 
            // txt_r21
            // 
            this.txt_r21.Location = new System.Drawing.Point(332, 522);
            this.txt_r21.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r21.Name = "txt_r21";
            this.txt_r21.ReadOnly = true;
            this.txt_r21.Size = new System.Drawing.Size(100, 22);
            this.txt_r21.TabIndex = 48;
            // 
            // txt_r20
            // 
            this.txt_r20.Location = new System.Drawing.Point(181, 522);
            this.txt_r20.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r20.Name = "txt_r20";
            this.txt_r20.ReadOnly = true;
            this.txt_r20.Size = new System.Drawing.Size(100, 22);
            this.txt_r20.TabIndex = 47;
            // 
            // txt_r13
            // 
            this.txt_r13.Location = new System.Drawing.Point(638, 469);
            this.txt_r13.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r13.Name = "txt_r13";
            this.txt_r13.ReadOnly = true;
            this.txt_r13.Size = new System.Drawing.Size(100, 22);
            this.txt_r13.TabIndex = 46;
            // 
            // txt_r12
            // 
            this.txt_r12.Location = new System.Drawing.Point(485, 469);
            this.txt_r12.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r12.Name = "txt_r12";
            this.txt_r12.ReadOnly = true;
            this.txt_r12.Size = new System.Drawing.Size(100, 22);
            this.txt_r12.TabIndex = 45;
            // 
            // txt_r11
            // 
            this.txt_r11.Location = new System.Drawing.Point(332, 469);
            this.txt_r11.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r11.Name = "txt_r11";
            this.txt_r11.ReadOnly = true;
            this.txt_r11.Size = new System.Drawing.Size(100, 22);
            this.txt_r11.TabIndex = 44;
            // 
            // txt_r10
            // 
            this.txt_r10.Location = new System.Drawing.Point(181, 469);
            this.txt_r10.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r10.Name = "txt_r10";
            this.txt_r10.ReadOnly = true;
            this.txt_r10.Size = new System.Drawing.Size(100, 22);
            this.txt_r10.TabIndex = 43;
            // 
            // txt_r03
            // 
            this.txt_r03.Location = new System.Drawing.Point(638, 421);
            this.txt_r03.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r03.Name = "txt_r03";
            this.txt_r03.ReadOnly = true;
            this.txt_r03.Size = new System.Drawing.Size(100, 22);
            this.txt_r03.TabIndex = 42;
            // 
            // txt_r02
            // 
            this.txt_r02.Location = new System.Drawing.Point(485, 421);
            this.txt_r02.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r02.Name = "txt_r02";
            this.txt_r02.ReadOnly = true;
            this.txt_r02.Size = new System.Drawing.Size(100, 22);
            this.txt_r02.TabIndex = 41;
            // 
            // txt_r01
            // 
            this.txt_r01.Location = new System.Drawing.Point(332, 421);
            this.txt_r01.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r01.Name = "txt_r01";
            this.txt_r01.ReadOnly = true;
            this.txt_r01.Size = new System.Drawing.Size(100, 22);
            this.txt_r01.TabIndex = 40;
            // 
            // txt_r00
            // 
            this.txt_r00.Location = new System.Drawing.Point(181, 421);
            this.txt_r00.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_r00.Name = "txt_r00";
            this.txt_r00.ReadOnly = true;
            this.txt_r00.Size = new System.Drawing.Size(100, 22);
            this.txt_r00.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 59);
            this.label4.TabIndex = 51;
            this.label4.Text = "A/B=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(955, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 43);
            this.label2.TabIndex = 52;
            this.label2.Text = "m21=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(955, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 43);
            this.label3.TabIndex = 53;
            this.label3.Text = "m32=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(955, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 43);
            this.label5.TabIndex = 54;
            this.label5.Text = "m31=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(1051, 386);
            this.txt_x1.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_x1.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.ReadOnly = true;
            this.txt_x1.Size = new System.Drawing.Size(100, 22);
            this.txt_x1.TabIndex = 55;
            // 
            // txt_x2
            // 
            this.txt_x2.Location = new System.Drawing.Point(1051, 438);
            this.txt_x2.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_x2.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.ReadOnly = true;
            this.txt_x2.Size = new System.Drawing.Size(100, 22);
            this.txt_x2.TabIndex = 56;
            // 
            // txt_m32
            // 
            this.txt_m32.Location = new System.Drawing.Point(1051, 277);
            this.txt_m32.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_m32.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_m32.Name = "txt_m32";
            this.txt_m32.ReadOnly = true;
            this.txt_m32.Size = new System.Drawing.Size(100, 22);
            this.txt_m32.TabIndex = 57;
            // 
            // txt_x3
            // 
            this.txt_x3.Location = new System.Drawing.Point(1051, 486);
            this.txt_x3.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_x3.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_x3.Name = "txt_x3";
            this.txt_x3.ReadOnly = true;
            this.txt_x3.Size = new System.Drawing.Size(100, 22);
            this.txt_x3.TabIndex = 60;
            this.txt_x3.TextChanged += new System.EventHandler(this.txt_x3_TextChanged);
            // 
            // txt_m31
            // 
            this.txt_m31.Location = new System.Drawing.Point(1051, 227);
            this.txt_m31.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_m31.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_m31.Name = "txt_m31";
            this.txt_m31.ReadOnly = true;
            this.txt_m31.Size = new System.Drawing.Size(100, 22);
            this.txt_m31.TabIndex = 59;
            // 
            // txt_m21
            // 
            this.txt_m21.Location = new System.Drawing.Point(1051, 179);
            this.txt_m21.MaximumSize = new System.Drawing.Size(100, 30);
            this.txt_m21.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_m21.Name = "txt_m21";
            this.txt_m21.ReadOnly = true;
            this.txt_m21.Size = new System.Drawing.Size(100, 22);
            this.txt_m21.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(955, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 43);
            this.label6.TabIndex = 63;
            this.label6.Text = "X2=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(955, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 43);
            this.label7.TabIndex = 62;
            this.label7.Text = "X3=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(955, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 43);
            this.label8.TabIndex = 61;
            this.label8.Text = "X1=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GaussElimination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1237, 589);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_x3);
            this.Controls.Add(this.txt_m31);
            this.Controls.Add(this.txt_m21);
            this.Controls.Add(this.txt_m32);
            this.Controls.Add(this.txt_x2);
            this.Controls.Add(this.txt_x1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_r23);
            this.Controls.Add(this.txt_r22);
            this.Controls.Add(this.txt_r21);
            this.Controls.Add(this.txt_r20);
            this.Controls.Add(this.txt_r13);
            this.Controls.Add(this.txt_r12);
            this.Controls.Add(this.txt_r11);
            this.Controls.Add(this.txt_r10);
            this.Controls.Add(this.txt_r03);
            this.Controls.Add(this.txt_r02);
            this.Controls.Add(this.txt_r01);
            this.Controls.Add(this.txt_r00);
            this.Controls.Add(this.txt_23);
            this.Controls.Add(this.txt_22);
            this.Controls.Add(this.txt_21);
            this.Controls.Add(this.txt_20);
            this.Controls.Add(this.txt_13);
            this.Controls.Add(this.txt_12);
            this.Controls.Add(this.txt_11);
            this.Controls.Add(this.txt_10);
            this.Controls.Add(this.txt_03);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.txt_00);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GaussElimination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GaussElimination";
            this.Load += new System.EventHandler(this.GaussElimination_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_00;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.TextBox txt_03;
        private System.Windows.Forms.TextBox txt_10;
        private System.Windows.Forms.TextBox txt_11;
        private System.Windows.Forms.TextBox txt_12;
        private System.Windows.Forms.TextBox txt_13;
        private System.Windows.Forms.TextBox txt_20;
        private System.Windows.Forms.TextBox txt_21;
        private System.Windows.Forms.TextBox txt_22;
        private System.Windows.Forms.TextBox txt_23;
        private System.Windows.Forms.TextBox txt_r23;
        private System.Windows.Forms.TextBox txt_r22;
        private System.Windows.Forms.TextBox txt_r21;
        private System.Windows.Forms.TextBox txt_r20;
        private System.Windows.Forms.TextBox txt_r13;
        private System.Windows.Forms.TextBox txt_r12;
        private System.Windows.Forms.TextBox txt_r11;
        private System.Windows.Forms.TextBox txt_r10;
        private System.Windows.Forms.TextBox txt_r03;
        private System.Windows.Forms.TextBox txt_r02;
        private System.Windows.Forms.TextBox txt_r01;
        private System.Windows.Forms.TextBox txt_r00;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.TextBox txt_m32;
        private System.Windows.Forms.TextBox txt_x3;
        private System.Windows.Forms.TextBox txt_m31;
        private System.Windows.Forms.TextBox txt_m21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
    }
}