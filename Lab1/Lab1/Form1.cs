using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        private TextBox text_InputName;
        private GroupBox grb_Color;
        private GroupBox grb_Font;
        private TextBox text_OutputName;
        private Label lb_OutputName;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private CheckBox ckbUnderlined;
        private CheckBox ckbItalic;
        private CheckBox ckbBold;
        private Button bt_Cancel;
        private Label lb_InputName;

        public Lab1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lb_InputName = new System.Windows.Forms.Label();
            this.text_InputName = new System.Windows.Forms.TextBox();
            this.grb_Color = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grb_Font = new System.Windows.Forms.GroupBox();
            this.ckbUnderlined = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.text_OutputName = new System.Windows.Forms.TextBox();
            this.lb_OutputName = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.grb_Color.SuspendLayout();
            this.grb_Font.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_InputName
            // 
            this.lb_InputName.AutoSize = true;
            this.lb_InputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputName.Location = new System.Drawing.Point(12, 34);
            this.lb_InputName.Name = "lb_InputName";
            this.lb_InputName.Size = new System.Drawing.Size(105, 22);
            this.lb_InputName.TabIndex = 0;
            this.lb_InputName.Text = "Nhập Tên : ";
            // 
            // text_InputName
            // 
            this.text_InputName.Location = new System.Drawing.Point(143, 33);
            this.text_InputName.Name = "text_InputName";
            this.text_InputName.Size = new System.Drawing.Size(480, 26);
            this.text_InputName.TabIndex = 1;
            this.text_InputName.TextChanged += new System.EventHandler(this.textInputName_Changed);
            // 
            // grb_Color
            // 
            this.grb_Color.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_Color.Controls.Add(this.radBlack);
            this.grb_Color.Controls.Add(this.radBlue);
            this.grb_Color.Controls.Add(this.radGreen);
            this.grb_Color.Controls.Add(this.radRed);
            this.grb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Color.Location = new System.Drawing.Point(42, 121);
            this.grb_Color.Name = "grb_Color";
            this.grb_Color.Size = new System.Drawing.Size(227, 227);
            this.grb_Color.TabIndex = 2;
            this.grb_Color.TabStop = false;
            this.grb_Color.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(21, 185);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(85, 29);
            this.radBlack.TabIndex = 10;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.grbColor_Changed);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(21, 132);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(76, 29);
            this.radBlue.TabIndex = 9;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.grbColor_Changed);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radGreen.Location = new System.Drawing.Point(21, 83);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(91, 29);
            this.radGreen.TabIndex = 8;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.grbColor_Changed);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Checked = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(21, 39);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(72, 29);
            this.radRed.TabIndex = 7;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.grbColor_Changed);
            // 
            // grb_Font
            // 
            this.grb_Font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grb_Font.Controls.Add(this.ckbUnderlined);
            this.grb_Font.Controls.Add(this.ckbItalic);
            this.grb_Font.Controls.Add(this.ckbBold);
            this.grb_Font.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Font.Location = new System.Drawing.Point(396, 121);
            this.grb_Font.Name = "grb_Font";
            this.grb_Font.Size = new System.Drawing.Size(227, 227);
            this.grb_Font.TabIndex = 3;
            this.grb_Font.TabStop = false;
            this.grb_Font.Text = "Font";
            // 
            // ckbUnderlined
            // 
            this.ckbUnderlined.AutoSize = true;
            this.ckbUnderlined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUnderlined.Location = new System.Drawing.Point(25, 133);
            this.ckbUnderlined.Name = "ckbUnderlined";
            this.ckbUnderlined.Size = new System.Drawing.Size(143, 29);
            this.ckbUnderlined.TabIndex = 2;
            this.ckbUnderlined.Text = "Gạch Chân ";
            this.ckbUnderlined.UseVisualStyleBackColor = true;
            this.ckbUnderlined.CheckStateChanged += new System.EventHandler(this.grbFont_Changed);
            // 
            // ckbItalic
            // 
            this.ckbItalic.AutoSize = true;
            this.ckbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(25, 84);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(155, 29);
            this.ckbItalic.TabIndex = 1;
            this.ckbItalic.Text = "Nghiêng Italic";
            this.ckbItalic.UseVisualStyleBackColor = true;
            this.ckbItalic.CheckStateChanged += new System.EventHandler(this.grbFont_Changed);
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(25, 39);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(131, 29);
            this.ckbBold.TabIndex = 0;
            this.ckbBold.Text = "Đậm Bold";
            this.ckbBold.UseVisualStyleBackColor = true;
            this.ckbBold.CheckStateChanged += new System.EventHandler(this.grbFont_Changed);
            // 
            // text_OutputName
            // 
            this.text_OutputName.ForeColor = System.Drawing.Color.Black;
            this.text_OutputName.Location = new System.Drawing.Point(143, 391);
            this.text_OutputName.Name = "text_OutputName";
            this.text_OutputName.Size = new System.Drawing.Size(259, 26);
            this.text_OutputName.TabIndex = 4;
            // 
            // lb_OutputName
            // 
            this.lb_OutputName.AutoSize = true;
            this.lb_OutputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OutputName.Location = new System.Drawing.Point(12, 391);
            this.lb_OutputName.Name = "lb_OutputName";
            this.lb_OutputName.Size = new System.Drawing.Size(119, 22);
            this.lb_OutputName.TabIndex = 5;
            this.lb_OutputName.Text = "Lập trình bởi :";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(500, 367);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(123, 72);
            this.bt_Cancel.TabIndex = 6;
            this.bt_Cancel.Text = "Thoát";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Event);
            // 
            // Lab1
            // 
            this.ClientSize = new System.Drawing.Size(644, 483);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.lb_OutputName);
            this.Controls.Add(this.text_OutputName);
            this.Controls.Add(this.grb_Font);
            this.Controls.Add(this.grb_Color);
            this.Controls.Add(this.text_InputName);
            this.Controls.Add(this.lb_InputName);
            this.Name = "Lab1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định Dạng (Formater)";
            this.grb_Color.ResumeLayout(false);
            this.grb_Color.PerformLayout();
            this.grb_Font.ResumeLayout(false);
            this.grb_Font.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textInputName_Changed(object sender, EventArgs e)
        {
            string text = this.text_InputName.Text;
            grbColor_Changed(sender, e);
            grbColor_Changed(sender, e);
            this.text_OutputName.Text = text;
        }

        private void grbColor_Changed(object sender, EventArgs e)
        {

            if (radRed.Checked == true)
            {
                this.text_OutputName.ForeColor = System.Drawing.Color.Red;
            }
            if (radBlue.Checked == true)
            {
                this.text_OutputName.ForeColor = System.Drawing.Color.Blue;
            }
            if (radGreen.Checked == true)
            {
                this.text_OutputName.ForeColor = System.Drawing.Color.Green;
            }
            if (radBlack.Checked == true)
            {
                this.text_OutputName.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void grbFont_Changed(object sender, EventArgs e)
        {
            Font SelectedText_Font = this.text_OutputName.Font;
            if (ckbBold.CheckState == CheckState.Checked)
            {
                this.text_OutputName.Font = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);

            }

            if (ckbItalic.CheckState == CheckState.Checked)
            {
                this.text_OutputName.Font = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
            }

            if (ckbUnderlined.CheckState == CheckState.Checked)
            {
                this.text_OutputName.Font = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
            }
        }

        private void bt_Cancel_Event(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình ?", "Cảnh báo !", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (rs == DialogResult.No)
            {
                // cancel
            }
        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }
    }

}


