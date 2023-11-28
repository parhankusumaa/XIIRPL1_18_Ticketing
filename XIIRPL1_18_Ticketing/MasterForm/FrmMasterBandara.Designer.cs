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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtJumlahTerminal = new NumericUpDown();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            txtAlamat = new TextBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            txtNegara = new ComboBox();
            label1 = new Label();
            id = new TextBox();
            btn_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(362, 21);
            label2.TabIndex = 1;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 164);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 277);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 4;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 310);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 5;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 355);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 6;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 398);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 7;
            label6.Text = "Negara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(450, 277);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 8;
            label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(450, 323);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 9;
            label8.Text = "Alamat";
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(573, 277);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(199, 23);
            txtJumlahTerminal.TabIndex = 13;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(135, 271);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(199, 23);
            txtNama.TabIndex = 14;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(135, 309);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(199, 23);
            txtKodeIATA.TabIndex = 15;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(135, 354);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(199, 23);
            txtKota.TabIndex = 16;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(573, 322);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(199, 65);
            txtAlamat.TabIndex = 18;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(573, 403);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 19;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(697, 403);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 20;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(135, 397);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(199, 23);
            txtNegara.TabIndex = 21;
            txtNegara.SelectedIndexChanged += txtNegara_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 22;
            label1.Text = "Master Bandara";
            // 
            // id
            // 
            id.Location = new Point(548, 23);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 23;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(463, 403);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 24;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += button1_Click;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_edit);
            Controls.Add(id);
            Controls.Add(label1);
            Controls.Add(txtNegara);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtAlamat);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMaster_bandara_load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown txtJumlahTerminal;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private TextBox txtAlamat;
        private Button btnBatal;
        private Button btnSimpan;
        private ComboBox txtNegara;
        private Label label1;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btn_edit;
    }
}