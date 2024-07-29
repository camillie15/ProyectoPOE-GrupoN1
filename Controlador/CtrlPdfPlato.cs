using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlPdfPlato
    {
        public void GenerarPDF(DataGridView dgv)
        {
            FileStream stream = null;
            Document document = null;

            try
            {
                stream = new FileStream("resultados.pdf", FileMode.Create);
                document = new Document(PageSize.A4, 5, 5, 7, 7);
                PdfWriter pdf = PdfWriter.GetInstance(document, stream);
                document.Open();

                iTextSharp.text.Font Miletra = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.RED);
                iTextSharp.text.Font letra = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.BLUE);

                document.Add(new Paragraph("Consulta de Platos Registrados"));
                document.Add(Chunk.NEWLINE);

                PdfPTable table = new PdfPTable(dgv.ColumnCount);
                table.WidthPercentage = 100;

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, Miletra));
                    cell.BorderWidth = 0;
                    cell.BorderWidthBottom = 0.25f;
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new PdfPCell(new Phrase(cell.Value?.ToString(), letra)));
                        }
                    }
                }

                document.Add(table);
                document.Close();
                pdf.Close();

                MessageBox.Show("Documento PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                stream?.Close();
            }
        }

        public void AbrirPDF()
        {
            if (File.Exists("resultados.pdf"))
            {
                System.Diagnostics.Process.Start("resultados.pdf");
            }
            else
            {
                MessageBox.Show("El archivo PDF no existe. Primero genera el PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
