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

        public FormGetEmails()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            var url = @"http://www.royalsystel.com.ar/";
            var emails = getEmails.Request(url);
        }
    }
}
