using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Product;
namespace GUI_Product
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        BUS_de2 bus = new BUS_de2();

        private void loadcb()
        {
            cbChungloai.DataSource = bus.showcb();
            cbChungloai.DisplayMember = "Tenchungloai";
            cbChungloai.ValueMember = "Machungloai";
        }
        private void loaddgv()
        {
            dataGridView1.DataSource = bus.showdgv();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadcb();
            loaddgv();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtmahang.Text == "" || txtNSX.Text == "" || txtSLcon.Text == "" || txttenhang.Text == "")
                MessageBox.Show("Nhập Thiếu !!", "Cảnh Báo");
            else
            {
                if(bus.checkhang(txtmahang.Text))
                {
                    int sl;
                    string tb = "";
                    if (int.TryParse(txtSLcon.Text, out sl) == false)
                        tb += "Nhập Sai Số Lượng! ";
                    if(tb != "")
                    {
                        MessageBox.Show(tb, "Cảnh Báo");
                    } 
                    else
                    {
                        bus.InsertSql(txtmahang.Text, txttenhang.Text,txtNSX.Text, dtNhap.Value.ToString(), txtSLcon.Text, cbChungloai.SelectedValue.ToString());
                        loaddgv();
                    }    
                } 
                else
                    MessageBox.Show("Mã :"+txtmahang.Text+" đã Tồn tại", "Cảnh Báo");
            }    
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtmahang.Text == "" )
                MessageBox.Show("Chưa Nhập MÃ Cần xóa!!", "Cảnh Báo");
            else
            {
                if (bus.checkhang(txtmahang.Text)==false)
                {

                    bus.DeleteSql(txtmahang.Text);
                    loaddgv();
                }
                else
                    MessageBox.Show("Mã :" + txtmahang.Text + " Không Tồn tại", "Cảnh Báo");
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn Có Muốn Thoát!", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tl == DialogResult.Yes)
                Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmahang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenhang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNSX.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtNhap.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSLcon.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbChungloai.Text = bus.ten(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch
            {

            }
        }
    }
}
