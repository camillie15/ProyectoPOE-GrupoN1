using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Controlador
{
    public class CtrlPdfCliente
    {
        public void AbrirPdf()
        {
            if (File.Exists("Clientes.pdf"))
            {
                // Abrir el archivo PDF con el visor de PDF predeterminado del sistema
                System.Diagnostics.Process.Start("Clientes.pdf");
            }
            else
            {
                MessageBox.Show("El archivo PDF no existe. Primero genera el PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarPdf(DataGridView dgv)
        {
            FileStream stream = null;
            Document document = null;

            try
            {
                stream = new FileStream("Clientes.pdf", FileMode.Create);
                document = new Document(PageSize.A4, 7, 7, 7, 7);

                PdfWriter pdf = PdfWriter.GetInstance(document, stream);

                document.Open();

                string verdanaFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "verdana.ttf");
                BaseFont verdanaBaseFont = BaseFont.CreateFont(verdanaFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                Font h1 = new Font(verdanaBaseFont, 12, Font.NORMAL, new BaseColor(53, 0, 0));
                Font h2 = new Font(verdanaBaseFont, 12, Font.NORMAL, new BaseColor(112, 0, 0));
                Font p = new Font(verdanaBaseFont, 9, Font.NORMAL, BaseColor.BLACK);
                Font p2 = new Font(verdanaBaseFont, 7, Font.NORMAL, BaseColor.BLACK);

                Paragraph tittle = new Paragraph("Clientes de Not Delicius", h1);
                tittle.Alignment = Element.ALIGN_CENTER;
                document.Add(tittle);

                string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                Paragraph fechaActual = new Paragraph($"Fecha de informe emitido: {fecha}", p);
                document.Add(Chunk.NEWLINE);
                document.Add(fechaActual);
                document.Add(Chunk.NEWLINE);

                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;


                PdfPCell clCedula = new PdfPCell(new Phrase("Ci", h2));
                clCedula.HorizontalAlignment = Element.ALIGN_CENTER;
                clCedula.BorderWidth = 0;
                clCedula.BorderWidthBottom = 0.18f;
                clCedula.PaddingBottom = 10f;

                PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", h2));
                clNombre.HorizontalAlignment = Element.ALIGN_CENTER;
                clNombre.BorderWidth = 0;
                clNombre.BorderWidthBottom = 0.18f;

                PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", h2));
                clApellido.HorizontalAlignment = Element.ALIGN_CENTER;
                clApellido.BorderWidth = 0;
                clApellido.BorderWidthBottom = 0.18f;

                PdfPCell clCorreo = new PdfPCell(new Phrase("Correo", h2));
                clCorreo.HorizontalAlignment = Element.ALIGN_CENTER;
                clCorreo.BorderWidth = 0;
                clCorreo.BorderWidthBottom = 0.18f;

                PdfPCell clDireccion = new PdfPCell(new Phrase("Direccion", h2));
                clDireccion.HorizontalAlignment = Element.ALIGN_CENTER;
                clDireccion.BorderWidth = 0;
                clDireccion.BorderWidthBottom = 0.18f;


                table.AddCell(clCedula);
                table.AddCell(clNombre);
                table.AddCell(clApellido);
                table.AddCell(clCorreo);
                table.AddCell(clDireccion);

                for (int i = 0; i < dgv.RowCount; i++)
                {
                    clCedula = new PdfPCell(new Phrase(dgv.Rows[i].Cells[3].Value.ToString(), p));
                    clCedula.HorizontalAlignment = Element.ALIGN_CENTER;
                    clCedula.BorderColor = new BaseColor(214, 214, 214);
                    clCedula.PaddingBottom = 5f;

                    clNombre = new PdfPCell(new Phrase(dgv.Rows[i].Cells[1].Value.ToString(), p));
                    clNombre.HorizontalAlignment = Element.ALIGN_CENTER;
                    clNombre.BorderColor = new BaseColor(214, 214, 214);

                    clApellido = new PdfPCell(new Phrase(dgv.Rows[i].Cells[2].Value.ToString(), p));
                    clApellido.HorizontalAlignment = Element.ALIGN_CENTER;
                    clApellido.BorderColor = new BaseColor(214, 214, 214);

                    clCorreo = new PdfPCell(new Phrase(dgv.Rows[i].Cells[5].Value.ToString(), p2));
                    clCorreo.HorizontalAlignment = Element.ALIGN_CENTER;
                    clCorreo.BorderColor = new BaseColor(214, 214, 214);

                    clDireccion = new PdfPCell(new Phrase(dgv.Rows[i].Cells[6].Value.ToString(), p2));
                    clDireccion.HorizontalAlignment = Element.ALIGN_CENTER;
                    clDireccion.BorderColor = new BaseColor(214, 214, 214);

                    table.AddCell(clCedula);
                    table.AddCell(clNombre);
                    table.AddCell(clApellido);
                    table.AddCell(clCorreo);
                    table.AddCell(clDireccion);
                }

                document.Add(table);
                document.Close();
                pdf.Close();

            }
            catch (Exception) { MessageBox.Show($"Error al generar informe de Clientes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { stream?.Close(); }
        }
    }
}
