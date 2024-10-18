namespace kullanicigirislimesai
{
    partial class Kaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(366, 270);
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
            label2.Location = new Point(366, 403);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(508, 540);
            button1.Name = "button1";
            button1.Size = new Size(138, 62);
            button1.TabIndex = 2;
            button1.Text = "Kaydol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(564, 267);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 41);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(564, 403);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 41);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Geri Dön";
            label3.Click += label3_Click;
            // 
            // Kaydol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1352, 725);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kaydol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kaydol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}