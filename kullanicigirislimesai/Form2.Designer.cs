namespace kullanicigirislimesai
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            lblSonuc = new Label();
            dtbas = new DateTimePicker();
            dtsbas = new DateTimePicker();
            dtbit = new DateTimePicker();
            dtsbit = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnKaydet = new Button();
            btnSil = new Button();
            txtmuhendis = new TextBox();
            txtis = new TextBox();
            txtad = new TextBox();
            txttip = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 58);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "İş Başlama Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 98);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "İş Bitiş Tarihi";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.BackColor = Color.Transparent;
            lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSonuc.Location = new Point(534, 151);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(70, 28);
            lblSonuc.TabIndex = 2;
            lblSonuc.Text = "Sonuç:";
            // 
            // dtbas
            // 
            dtbas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtbas.Location = new Point(249, 55);
            dtbas.Name = "dtbas";
            dtbas.Size = new Size(268, 34);
            dtbas.TabIndex = 5;
            // 
            // dtsbas
            // 
            dtsbas.CustomFormat = "HH:mm";
            dtsbas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtsbas.Format = DateTimePickerFormat.Custom;
            dtsbas.Location = new Point(534, 55);
            dtsbas.Name = "dtsbas";
            dtsbas.Size = new Size(79, 34);
            dtsbas.TabIndex = 6;
            // 
            // dtbit
            // 
            dtbit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtbit.Location = new Point(249, 95);
            dtbit.Name = "dtbit";
            dtbit.Size = new Size(268, 34);
            dtbit.TabIndex = 7;
            // 
            // dtsbit
            // 
            dtsbit.CustomFormat = "HH:mm";
            dtsbit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtsbit.Format = DateTimePickerFormat.Custom;
            dtsbit.Location = new Point(534, 95);
            dtsbit.Name = "dtsbit";
            dtsbit.Size = new Size(79, 34);
            dtsbit.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Location = new Point(249, 145);
            button1.Name = "button1";
            button1.Size = new Size(120, 47);
            button1.TabIndex = 9;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1185, 348);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Azure;
            btnKaydet.Location = new Point(375, 145);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 47);
            btnKaydet.TabIndex = 20;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Azure;
            btnSil.Location = new Point(1222, 416);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(105, 43);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtmuhendis
            // 
            txtmuhendis.Location = new Point(42, 291);
            txtmuhendis.Name = "txtmuhendis";
            txtmuhendis.Size = new Size(125, 27);
            txtmuhendis.TabIndex = 14;
            // 
            // txtis
            // 
            txtis.Location = new Point(173, 291);
            txtis.Name = "txtis";
            txtis.Size = new Size(125, 27);
            txtis.TabIndex = 15;
            // 
            // txtad
            // 
            txtad.Location = new Point(304, 291);
            txtad.Name = "txtad";
            txtad.Size = new Size(125, 27);
            txtad.TabIndex = 16;
            // 
            // txttip
            // 
            txttip.Location = new Point(435, 291);
            txttip.Name = "txttip";
            txttip.Size = new Size(125, 27);
            txttip.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(566, 291);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(697, 291);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(42, 268);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 20;
            label6.Text = "Mühendis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(173, 268);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 21;
            label7.Text = "Yapılan İş";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(304, 268);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 22;
            label8.Text = "Kule Adı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(435, 268);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 23;
            label9.Text = "Kule Tipi";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(566, 268);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 24;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(697, 268);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 25;
            label11.Text = "label11";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ControlDarkDark;
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(12, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 24);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "Tümünü Seç";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1300, 12);
            button2.Name = "button2";
            button2.Size = new Size(36, 31);
            button2.TabIndex = 27;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Azure;
            btnGuncelle.Location = new Point(1222, 363);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(105, 43);
            btnGuncelle.TabIndex = 28;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 721);
            Controls.Add(btnGuncelle);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(txttip);
            Controls.Add(txtad);
            Controls.Add(txtis);
            Controls.Add(txtmuhendis);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(dtsbit);
            Controls.Add(dtbit);
            Controls.Add(dtsbas);
            Controls.Add(dtbas);
            Controls.Add(lblSonuc);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSonuc;
        private Label label4;
        private Label label5;
        private DateTimePicker dtbas;
        private DateTimePicker dtsbas;
        private DateTimePicker dtbit;
        private DateTimePicker dtsbit;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnKaydet;
        private Button btnSil;
        private Label label3;
        private TextBox txtmuhendis;
        private TextBox txtis;
        private TextBox txtad;
        private TextBox txttip;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox checkBox1;
        private Button button2;
        private Button btnGuncelle;
    }
}