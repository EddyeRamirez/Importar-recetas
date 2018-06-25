using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;

namespace Importar_recetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void examinarSimpleButton_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(MessageBoxIcon.Asterisk.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            XtraMessageBox.Show(MessageBoxIcon.Error.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            XtraMessageBox.Show(MessageBoxIcon.Exclamation.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            XtraMessageBox.Show(MessageBoxIcon.Hand.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            XtraMessageBox.Show(MessageBoxIcon.Information.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XtraMessageBox.Show(MessageBoxIcon.None.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
            XtraMessageBox.Show(MessageBoxIcon.Question.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            XtraMessageBox.Show(MessageBoxIcon.Stop.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            XtraMessageBox.Show(MessageBoxIcon.Warning.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            openFileDialog1.Filter = "Ficheros Excel |*.xls*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ficheroTextEdit.Text = openFileDialog1.FileName;
                    spreadsheetControl1.LoadDocument(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void importarSimpleButton_Click(object sender, EventArgs e)
        {
            int fila = 2;
            bool finDatos = false;
            string perfil, aleacion;
            ImportarRecetas.Datos dal = new ImportarRecetas.Datos();

            IWorkbook libro = spreadsheetControl1.Document;
            Worksheet hoja3 = libro.Worksheets["Hoja 1"];
            Cell celda = hoja3.Cells["B" + fila.ToString()];

            hoja3.ScrollTo(0, 0);
            finDatos = celda.Value.IsEmpty;
            while (!finDatos)
            {
                if (!celda.Value.IsEmpty && !hoja3.Cells["I" + fila.ToString()].Value.IsEmpty)
                {
                    perfil = celda.Value.TextValue;
                    aleacion = hoja3.Cells["D" + fila.ToString()].Value.TextValue;
                    memoEdit1.Text += fila.ToString() + " - " + perfil + " - " + aleacion + " - " 
                        + hoja3.Cells["I" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["J" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["K" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["L" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["M" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["N" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["O" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["P" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["Q" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["S" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["T" + fila.ToString()].Value.ToString() + " - "
                        + hoja3.Cells["U" + fila.ToString()].Value.ToString() 
                        + "\r\n";
                    dal.InsertarLinea(perfil, aleacion, hoja3.Cells["I" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["J" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["K" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["L" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["M" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["N" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["O" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["P" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["Q" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["S" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["T" + fila.ToString()].Value.ToString(),
                        hoja3.Cells["U" + fila.ToString()].Value.ToString());                    
                }

                fila++;
                celda = hoja3.Cells["B" + fila.ToString()];
                finDatos = celda.Value.IsEmpty;
            }

            XtraMessageBox.Show("Proceso terminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
