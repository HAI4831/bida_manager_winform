using DevExpress.Utils.Extensions;
using QuanLyBanBida.DAO;
using QuanLyBanBida.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanBida
{
    public partial class TableManager1 : Form
    {
        public TableManager1()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList)
            {
                Button btn = new Button { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = table.Name;
                btn.Tag = table;
                switch (table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    case "Có Người":
                        btn.BackColor = Color.DarkRed;
                        break;
                    case "Đặt bàn":
                        btn.BackColor = Color.GreenYellow;
                        break;
                }
                flpTable.Controls.Add(btn);
                btn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
