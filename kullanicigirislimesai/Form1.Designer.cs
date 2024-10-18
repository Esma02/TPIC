namespace kullanicigirislimesai
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 275);
            label1.Name = "label1";
            label1.Size = new Size(156, 35);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(288, 365);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Location = new Point(505, 515);
            button1.Name = "button1";
            button1.Size = new Size(179, 68);
            button1.TabIndex = 5;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(590, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 41);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(590, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 41);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Aqua;
            linkLabel1.Location = new Point(820, 469);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 28);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kaydol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Aqua;
            linkLabel2.Location = new Point(1187, 27);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(144, 23);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Uygulamadan Çık";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1352, 725);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
