namespace XIIRPL1_18_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            txtNomorTlp = new TextBox();
            txtTglLahir = new TextBox();
            txtNama = new TextBox();
            btnDaftar = new Button();
            label8 = new Label();
            txtLinkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(166, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 23);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(326, 26);
            label1.Name = "label1";
            label1.Size = new Size(184, 33);
            label1.TabIndex = 2;
            label1.Text = "Daftar Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(222, 70);
            label2.Name = "label2";
            label2.Size = new Size(374, 27);
            label2.TabIndex = 3;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 123);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 166);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 5;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 293);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 248);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 7;
            label6.Text = "Nomor Telepon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 204);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 8;
            label7.Text = "Tanggal Lahir";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(165, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 9;
            // 
            // txtNomorTlp
            // 
            txtNomorTlp.Location = new Point(164, 245);
            txtNomorTlp.Name = "txtNomorTlp";
            txtNomorTlp.Size = new Size(192, 23);
            txtNomorTlp.TabIndex = 10;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Location = new Point(166, 201);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.Size = new Size(192, 23);
            txtTglLahir.TabIndex = 11;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(166, 163);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(192, 23);
            txtNama.TabIndex = 12;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(258, 336);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(98, 27);
            btnDaftar.TabIndex = 13;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(32, 399);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 14;
            label8.Text = "Sudah punya akun?";
            // 
            // txtLinkLabel1
            // 
            txtLinkLabel1.AutoSize = true;
            txtLinkLabel1.Location = new Point(163, 403);
            txtLinkLabel1.Name = "txtLinkLabel1";
            txtLinkLabel1.Size = new Size(37, 15);
            txtLinkLabel1.TabIndex = 15;
            txtLinkLabel1.TabStop = true;
            txtLinkLabel1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 281);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 23);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(txtLinkLabel1);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(txtNama);
            Controls.Add(txtTglLahir);
            Controls.Add(txtNomorTlp);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "FrmRegister";
            Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPassword;
        private TextBox txtNomorTlp;
        private TextBox txtTglLahir;
        private TextBox txtNama;
        private Button btnDaftar;
        private Label label8;
        private LinkLabel txtLinkLabel1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
    }
}