using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_18_Ticketing.MasterForm
{
    public partial class FrmMasterBandara : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterBandara()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl1_18.tbl_bandara " + "(id,nama,kode_iata,kota,negara,jumlah_terminal,alamat) " +
                    "VALUES " +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtKodeIATA.Text + "'," +
                    "'" + txtKota.Text + "'," +
                    "'" + txtNegara.Text + "'," +
                    "'" + txtJumlahTerminal.Value + "'," +
                    "'" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                view_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.conn.Close();
        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl1_18.tbl_bandara", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl1_18.tbl_bandara");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void FrmMaster_bandara_load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }
        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl1_18.tbl_bandara where id in(select max(id) FROM db_ticket_xii_rpl1_18.tbl_bandara) order by id desc";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            koneksi.conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl1_18.tbl_bandara WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int results = cmd.ExecuteNonQuery();
                    if (results > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nama"].Value);
                txtKodeIATA.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kode_iata"].Value);
                txtKota.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kota"].Value);
                txtNegara.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["negara"].Value);
                txtJumlahTerminal.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["jumlah_terminal"].Value);
                txtAlamat.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["alamat"].Value);
                btnSimpan.Enabled = false;
                btn_edit.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "UPDATE tbl_bandara SET " +
                    "nama = '" + txtNama.Text + "'," +
                    "kode_iata" + txtKodeIATA.Text + "'," +
                    "kota" + txtKota.Text + "'," +
                    "negara" + txtNegara.Text + "'," +
                    "jumlah_terminal" + txtJumlahTerminal.Text + "'," +
                    "alamat" + txtAlamat.Text + "'," +
                    "WHERE id='" + id + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                view_data();
            }
        }

        private void txtNegara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
