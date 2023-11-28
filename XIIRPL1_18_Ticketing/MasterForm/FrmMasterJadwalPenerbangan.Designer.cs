namespace XIIRPL1_18_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            id = new TextBox();
            tanggal = new DateTimePicker();
            txtKodePenerbangan = new TextBox();
            label7 = new Label();
            Simpan = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDari = new ComboBox();
            txtMaskapai = new ComboBox();
            txtKe = new ComboBox();
            txtDurasiPenerbangan = new TextBox();
            txtHargaPerTiket = new NumericUpDown();
            txtWaktuKeberangkatan = new DateTimePicker();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // id
            // 
            id.Location = new Point(638, 44);
            id.Name = "id";
            id.Size = new Size(82, 23);
            id.TabIndex = 61;
            id.Visible = false;
            // 
            // tanggal
            // 
            tanggal.Location = new Point(581, 263);
            tanggal.Name = "tanggal";
            tanggal.Size = new Size(192, 23);
            tanggal.TabIndex = 60;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(171, 263);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(194, 23);
            txtKodePenerbangan.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(45, 267);
            label7.Name = "label7";
            label7.Size = new Size(120, 17);
            label7.TabIndex = 56;
            label7.Text = "Kode Penerbangan";
            // 
            // Simpan
            // 
            Simpan.Location = new Point(701, 415);
            Simpan.Name = "Simpan";
            Simpan.Size = new Size(75, 23);
            Simpan.TabIndex = 55;
            Simpan.Text = "Simpan";
            Simpan.UseVisualStyleBackColor = true;
            Simpan.Click += Simpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(581, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 54;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(435, 267);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 52;
            label6.Text = "Tanggal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 348);
            label5.Name = "label5";
            label5.Size = new Size(23, 17);
            label5.TabIndex = 51;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 386);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 50;
            label4.Text = "Maskapai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 306);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 49;
            label3.Text = "Dari";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(13, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 171);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(244, 21);
            label2.TabIndex = 47;
            label2.Text = "Semua jadwal akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(379, 37);
            label1.TabIndex = 46;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(435, 381);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 62;
            label8.Text = "Harga Per Tiket";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(435, 348);
            label9.Name = "label9";
            label9.Size = new Size(126, 17);
            label9.TabIndex = 63;
            label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(435, 306);
            label10.Name = "label10";
            label10.Size = new Size(135, 17);
            label10.TabIndex = 64;
            label10.Text = "Waktu Keberangkatan";
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(171, 300);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(194, 23);
            txtDari.TabIndex = 65;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(171, 380);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(194, 23);
            txtMaskapai.TabIndex = 66;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(171, 342);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(194, 23);
            txtKe.TabIndex = 67;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(581, 342);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(194, 23);
            txtDurasiPenerbangan.TabIndex = 68;
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(581, 374);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(194, 23);
            txtHargaPerTiket.TabIndex = 70;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.Location = new Point(581, 300);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.Size = new Size(195, 23);
            txtWaktuKeberangkatan.TabIndex = 71;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(txtKe);
            Controls.Add(txtMaskapai);
            Controls.Add(txtDari);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(id);
            Controls.Add(tanggal);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label7);
            Controls.Add(Simpan);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "MasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private DateTimePicker tanggal;
        private TextBox txtKodePenerbangan;
        private Label label7;
        private Button Simpan;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox txtDari;
        private ComboBox txtMaskapai;
        private ComboBox txtKe;
        private TextBox txtDurasiPenerbangan;
        private NumericUpDown txtHargaPerTiket;
        private DateTimePicker txtWaktuKeberangkatan;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}