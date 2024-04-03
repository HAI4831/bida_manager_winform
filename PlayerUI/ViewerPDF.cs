using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QuanLyBanBida
{
    public partial class ViewerPDF : Form
    {
        private string filePath;
        public ViewerPDF(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private void ViewerPDF_Load(object sender, EventArgs e)
        {
            //OpenFileDialog opf = new OpenFileDialog();
            //opf.Filter = "Pdf File|*.pdf";
            //if(opf.ShowDialog() == DialogResult.OK)
            //{
            //    if(File.Exists(opf.FileName))
            //    {
            //        this.pdfViewer1.LoadFromFile(opf.FileName);
            //    }
            //}
            if (File.Exists(filePath))
            {
                this.pdfViewer1.LoadFromFile(filePath);
            }
        }
    }
}
