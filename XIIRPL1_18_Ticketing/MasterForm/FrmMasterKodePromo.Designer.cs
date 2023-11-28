namespace XIIRPL1_18_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            btnSimpan = new Button();
            button1 = new Button();
            txtDeskripsi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtKodePromo = new TextBox();
            MaksimumDiskon = new NumericUpDown();
            PersentaseDiskon = new NumericUpDown();
            dateTimeBerlaku = new DateTimePicker();
            id = new TextBox();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersentaseDiskon).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(697, 417);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 25;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(564, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(564, 306);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(208, 101);
            txtDeskripsi.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(484, 307);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 19;
            label6.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 350);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 18;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 398);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 17;
            label4.Text = "Maksimum Diskon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 308);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 16;
            label3.Text = "Berlaku Sampai";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 171);
            dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(387, 21);
            label2.TabIndex = 14;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 11);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 13;
            label1.Text = "Master Kode Promo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(50, 265);
            label7.Name = "label7";
            label7.Size = new Size(82, 17);
            label7.TabIndex = 26;
            label7.Text = "Kode Promo";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(170, 265);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(194, 23);
            txtKodePromo.TabIndex = 27;
            // 
            // MaksimumDiskon
            // 
            MaksimumDiskon.Location = new Point(170, 398);
            MaksimumDiskon.Name = "MaksimumDiskon";
            MaksimumDiskon.Size = new Size(199, 23);
            MaksimumDiskon.TabIndex = 28;
            // 
            // PersentaseDiskon
            // 
            PersentaseDiskon.Location = new Point(170, 350);
            PersentaseDiskon.Name = "PersentaseDiskon";
            PersentaseDiskon.Size = new Size(199, 23);
            PersentaseDiskon.TabIndex = 29;
            // 
            // dateTimeBerlaku
            // 
            dateTimeBerlaku.Location = new Point(170, 308);
            dateTimeBerlaku.Name = "dateTimeBerlaku";
            dateTimeBerlaku.Size = new Size(192, 23);
            dateTimeBerlaku.TabIndex = 44;
            // 
            // id
            // 
            id.Location = new Point(434, 398);
            id.Name = "id";
            id.Size = new Size(82, 23);
            id.TabIndex = 45;
            id.Visible = false;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(dateTimeBerlaku);
            Controls.Add(PersentaseDiskon);
            Controls.Add(MaksimumDiskon);
            Controls.Add(txtKodePromo);
            Controls.Add(label7);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersentaseDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeskripsi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtKodePromo;
        private NumericUpDown MaksimumDiskon;
        private NumericUpDown PersentaseDiskon;
        private DateTimePicker dateTimeBerlaku;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}