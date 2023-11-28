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
    public partial class FrmMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterKodePromo()
        {
            InitializeComponent();
        }

        private void FrmMasterKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl1_18.tbl_kode_promo " + "(id,kode,persentase_diskon,maksimum_diskon,berlaku_sampai,deskripsi) " +
                    "VALUES " +
                    "('" + id.Text + "'," +
                    "'" + txtKodePromo.Text + "'," +
                    "'" + PersentaseDiskon.Text + "'," +
                    "'" + MaksimumDiskon.Text + "'," +
                    "'" + dateTimeBerlaku.Value + "'," +
                    "'" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menyimpan Data Kode Promo");
                koneksi.conn.Close();
                view_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                koneksi.conn.Close();
            }
        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl1_18.tbl_kode_promo", koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl1_18.tbl_kode_promo");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl1_18.tbl_kode_promo where id in(select max(id) FROM db_ticket_xii_rpl1_18.tbl_kode_promo) order by id desc";
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

        private void FrmMasterMaskapai_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }
    }
}
