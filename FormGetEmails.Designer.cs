namespace GetEmail
{
    partial class FormGetEmails
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dlgFile = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSheets = new System.Windows.Forms.ComboBox();
            this.lblSheets = new System.Windows.Forms.Label();
            this.lblColumnFrom = new System.Windows.Forms.Label();
            this.cmbColumnFrom = new System.Windows.Forms.ComboBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblUrlsFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(14, 165);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(352, 23);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Visible = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dlgFile
            // 
            this.dlgFile.Filter = "Excel|*.xlsx";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(104, 35);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(181, 20);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "EXCEL FILE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(291, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "The Excel file must be closed";
            // 
            // cmbSheets
            // 
            this.cmbSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSheets.FormattingEnabled = true;
            this.cmbSheets.Location = new System.Drawing.Point(104, 67);
            this.cmbSheets.Name = "cmbSheets";
            this.cmbSheets.Size = new System.Drawing.Size(181, 24);
            this.cmbSheets.TabIndex = 5;
            this.cmbSheets.Visible = false;
            this.cmbSheets.SelectedIndexChanged += new System.EventHandler(this.cmbSheets_SelectedIndexChanged);
            // 
            // lblSheets
            // 
            this.lblSheets.ForeColor = System.Drawing.Color.White;
            this.lblSheets.Location = new System.Drawing.Point(11, 70);
            this.lblSheets.Name = "lblSheets";
            this.lblSheets.Size = new System.Drawing.Size(87, 13);
            this.lblSheets.TabIndex = 7;
            this.lblSheets.Text = "SHEET:";
            this.lblSheets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSheets.Visible = false;
            // 
            // lblColumnFrom
            // 
            this.lblColumnFrom.ForeColor = System.Drawing.Color.White;
            this.lblColumnFrom.Location = new System.Drawing.Point(11, 100);
            this.lblColumnFrom.Name = "lblColumnFrom";
            this.lblColumnFrom.Size = new System.Drawing.Size(87, 13);
            this.lblColumnFrom.TabIndex = 9;
            this.lblColumnFrom.Text = "URL COLUMN :";
            this.lblColumnFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblColumnFrom.Visible = false;
            // 
            // cmbColumnFrom
            // 
            this.cmbColumnFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColumnFrom.FormattingEnabled = true;
            this.cmbColumnFrom.Location = new System.Drawing.Point(104, 97);
            this.cmbColumnFrom.Name = "cmbColumnFrom";
            this.cmbColumnFrom.Size = new System.Drawing.Size(43, 24);
            this.cmbColumnFrom.TabIndex = 8;
            this.cmbColumnFrom.Visible = false;
            this.cmbColumnFrom.SelectedIndexChanged += new System.EventHandler(this.cmbColumnFrom_SelectedIndexChanged);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(11, 243);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(90, 16);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comentarios :";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblComment.Visible = false;
            // 
            // lblUrlsFound
            // 
            this.lblUrlsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlsFound.ForeColor = System.Drawing.Color.White;
            this.lblUrlsFound.Location = new System.Drawing.Point(11, 137);
            this.lblUrlsFound.Name = "lblUrlsFound";
            this.lblUrlsFound.Size = new System.Drawing.Size(355, 16);
            this.lblUrlsFound.TabIndex = 11;
            this.lblUrlsFound.Text = "Founds urls :";
            this.lblUrlsFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUrlsFound.Visible = false;
            // 
            // FormGetEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(380, 346);
            this.Controls.Add(this.lblUrlsFound);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblColumnFrom);
            this.Controls.Add(this.cmbColumnFrom);
            this.Controls.Add(this.lblSheets);
            this.Controls.Add(this.cmbSheets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnProcesar);
            this.Name = "FormGetEmails";
            this.Text = "Get Emails";
            this.Load += new System.EventHandler(this.FormGetEmails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.OpenFileDialog dlgFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSheets;
        private System.Windows.Forms.Label lblSheets;
        private System.Windows.Forms.Label lblColumnFrom;
        private System.Windows.Forms.ComboBox cmbColumnFrom;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblUrlsFound;
    }
}

