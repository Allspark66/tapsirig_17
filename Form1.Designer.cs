namespace Tapsiriq17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            expire = new Label();
            eye = new PictureBox();
            number = new Label();
            cvv = new Label();
            name = new Label();
            pictureBox1 = new PictureBox();
            textboxnumber = new TextBox();
            textboxname = new TextBox();
            dtExpire = new DateTimePicker();
            textboxcvv = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Fuchsia;
            panel1.Controls.Add(expire);
            panel1.Controls.Add(eye);
            panel1.Controls.Add(number);
            panel1.Controls.Add(cvv);
            panel1.Controls.Add(name);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 299);
            panel1.TabIndex = 0;
            // 
            // expire
            // 
            expire.AutoSize = true;
            expire.Font = new Font("Segoe UI", 12F);
            expire.ForeColor = Color.White;
            expire.Location = new Point(365, 255);
            expire.Name = "expire";
            expire.Size = new Size(52, 28);
            expire.TabIndex = 5;
            expire.Text = "**/**";
            // 
            // eye
            // 
            eye.Image = (Image)resources.GetObject("eye.Image");
            eye.Location = new Point(274, 22);
            eye.Name = "eye";
            eye.Size = new Size(76, 37);
            eye.SizeMode = PictureBoxSizeMode.Zoom;
            eye.TabIndex = 4;
            eye.TabStop = false;
            eye.Click += eye_Click;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Font = new Font("Segoe UI", 17F);
            number.ForeColor = Color.White;
            number.Location = new Point(62, 137);
            number.Name = "number";
            number.Size = new Size(297, 40);
            number.TabIndex = 3;
            number.Text = "1234 5678 9999 0000";
            // 
            // cvv
            // 
            cvv.AutoSize = true;
            cvv.Font = new Font("Segoe UI", 12F);
            cvv.ForeColor = Color.White;
            cvv.Location = new Point(365, 22);
            cvv.Name = "cvv";
            cvv.Size = new Size(48, 28);
            cvv.TabIndex = 2;
            cvv.Text = "CVV";
            cvv.Click += cvv_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F);
            name.ForeColor = Color.White;
            name.Location = new Point(19, 255);
            name.Name = "name";
            name.Size = new Size(106, 28);
            name.TabIndex = 1;
            name.Text = "AD SOYAD";
            name.Click += name_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textboxnumber
            // 
            textboxnumber.Location = new Point(462, 12);
            textboxnumber.Name = "textboxnumber";
            textboxnumber.Size = new Size(376, 27);
            textboxnumber.TabIndex = 1;
            textboxnumber.TextChanged += textboxnumber_TextChanged;
            // 
            // textboxname
            // 
            textboxname.Location = new Point(462, 81);
            textboxname.Name = "textboxname";
            textboxname.Size = new Size(376, 27);
            textboxname.TabIndex = 2;
            textboxname.Text = "Ad Soyad";
            textboxname.TextChanged += textboxname_TextChanged;
            // 
            // dtExpire
            // 
            dtExpire.Checked = false;
            dtExpire.CustomFormat = "dddd, dd MMMM yyyy";
            dtExpire.Location = new Point(462, 155);
            dtExpire.Name = "dtExpire";
            dtExpire.Size = new Size(372, 27);
            dtExpire.TabIndex = 3;
            dtExpire.Value = new DateTime(2025, 6, 7, 0, 0, 0, 0);
            dtExpire.ValueChanged += dtExpire_ValueChanged;
            // 
            // textboxcvv
            // 
            textboxcvv.Location = new Point(462, 218);
            textboxcvv.Name = "textboxcvv";
            textboxcvv.Size = new Size(376, 27);
            textboxcvv.TabIndex = 4;
            textboxcvv.TextChanged += textboxcvv_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(460, 272);
            button1.Name = "button1";
            button1.Size = new Size(374, 29);
            button1.TabIndex = 5;
            button1.Text = "Card Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 313);
            Controls.Add(button1);
            Controls.Add(textboxcvv);
            Controls.Add(dtExpire);
            Controls.Add(textboxname);
            Controls.Add(textboxnumber);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label name;
        private Label cvv;
        private Label number;
        private PictureBox eye;
        private TextBox textboxnumber;
        private TextBox textboxname;
        private DateTimePicker dtExpire;
        private Label expire;
        private TextBox textboxcvv;
        protected internal Button button1;
    }
}
