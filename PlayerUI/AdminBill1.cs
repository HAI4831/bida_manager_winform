using QuanLyBanBida.DAO;
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
    public partial class AdminBill1 : Form
    {
        public AdminBill1()
        {
            InitializeComponent();
            LoadDate();
        }
        private void LoadDate()
        {
            LoadDateTimeSpicker();
            LoadListByDate(dtpk_FromDate.Value, dtpk_ToDate.Value);
        }
        private void LoadDateTimeSpicker()
        {
            dtpk_FromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,1);
            dtpk_ToDate.Value = dtpk_FromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btn_ViewBill_Click(object sender, EventArgs e)
        {
            LoadListByDate(dtpk_FromDate.Value,dtpk_ToDate.Value);
        }
        private void LoadListByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgv_Bill.DataSource= BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
    }
}
