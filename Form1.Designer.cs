namespace Importar_recetas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ficheroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.importarSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.examinarSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ficheroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.memoEdit1);
            this.panelControl1.Controls.Add(this.examinarSimpleButton);
            this.panelControl1.Controls.Add(this.importarSimpleButton);
            this.panelControl1.Controls.Add(this.ficheroTextEdit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(995, 205);
            this.panelControl1.TabIndex = 0;
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 205);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
            this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
            this.spreadsheetControl1.Size = new System.Drawing.Size(995, 387);
            this.spreadsheetControl1.TabIndex = 1;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fichero:";
            // 
            // ficheroTextEdit
            // 
            this.ficheroTextEdit.Location = new System.Drawing.Point(57, 18);
            this.ficheroTextEdit.Name = "ficheroTextEdit";
            this.ficheroTextEdit.Size = new System.Drawing.Size(527, 20);
            this.ficheroTextEdit.TabIndex = 0;
            // 
            // importarSimpleButton
            // 
            this.importarSimpleButton.Location = new System.Drawing.Point(671, 16);
            this.importarSimpleButton.Name = "importarSimpleButton";
            this.importarSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.importarSimpleButton.TabIndex = 3;
            this.importarSimpleButton.Text = "Importar";
            this.importarSimpleButton.Click += new System.EventHandler(this.importarSimpleButton_Click);
            // 
            // examinarSimpleButton
            // 
            this.examinarSimpleButton.Location = new System.Drawing.Point(590, 16);
            this.examinarSimpleButton.Name = "examinarSimpleButton";
            this.examinarSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.examinarSimpleButton.TabIndex = 1;
            this.examinarSimpleButton.Text = "Examinar";
            this.examinarSimpleButton.Click += new System.EventHandler(this.examinarSimpleButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(57, 44);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(926, 155);
            this.memoEdit1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 592);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Importar Excel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ficheroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.SimpleButton examinarSimpleButton;
        private DevExpress.XtraEditors.SimpleButton importarSimpleButton;
        private DevExpress.XtraEditors.TextEdit ficheroTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}

