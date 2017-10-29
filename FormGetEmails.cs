using GetEmails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetEmail
{
    public partial class FormGetEmails : Form
    {
        readonly RequestEmailsFromUrl getEmails = new RequestEmailsFromUrl();
        readonly ExcelHelper excel = new ExcelHelper();
        readonly string ERROR_EXCEL = "Fallo al intentar abrir el archivo, asegurese que esta cerrado";
        List<UrlDTO> urls;

        public FormGetEmails()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            foreach (var urlDTO in urls)
            {
                var emails = getEmails.Request(urlDTO.url);
                if (emails != null)
                {
                    urlDTO.emails.AddRange(emails);
                }
            }
        }

        private void FormGetEmails_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            cmbSheets.Visible = lblSheets.Visible = cmbColumnFrom.Visible = lblColumnFrom.Visible = btnProcesar.Visible = lblComment.Visible = lblUrlsFound.Visible = false;
            var result = dlgFile.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtPath.Text = dlgFile.FileName;
                var sheets = excel.getSheets(txtPath.Text);
                if (sheets != null)
                {
                    cmbSheets.Visible = lblSheets.Visible = true;
                    cmbSheets.DataSource = sheets;
                }
                else
                {
                    lblComment.Text = ERROR_EXCEL;
                    lblComment.Visible = true;
                }
            }
        }

        private void cmbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColumnFrom.Visible = lblColumnFrom.Visible = btnProcesar.Visible = lblComment.Visible = lblUrlsFound.Visible = false;
            var idxSheet = cmbSheets.SelectedIndex + 1;
            var columns = excel.getColumns(txtPath.Text, idxSheet);
            if (columns != null)
            {
                cmbColumnFrom.Visible = lblColumnFrom.Visible = true;
                cmbColumnFrom.DataSource = columns;
            }
            else
            {
                lblComment.Text = ERROR_EXCEL + " - Columns not founds";
                lblComment.Visible = true;
            }
        }

        private void cmbColumnFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnProcesar.Visible = lblComment.Visible = lblUrlsFound.Visible = false;
            var idxSheet = cmbSheets.SelectedIndex + 1;
            var idxColumn = cmbColumnFrom.SelectedIndex + 1;
            urls = excel.getUrls(txtPath.Text, idxSheet, idxColumn);
            if (urls != null)
            {
                lblUrlsFound.Text = String.Format("{0} Founds urls", urls.Count());
                btnProcesar.Visible = lblUrlsFound.Visible = true;
            }
            else
            {
                lblComment.Text = ERROR_EXCEL + " - Urls error";
                lblComment.Visible = true;
            }
        }
    }
}
