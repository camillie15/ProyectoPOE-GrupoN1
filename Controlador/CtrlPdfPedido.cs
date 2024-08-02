using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlPdfPedido
    {
        public void GenerarPdf(DataGridView dgvPedidos, string campo)
        {
            FileStream fileStream = null;
            Document document = null;
            try
            {
                fileStream = new FileStream("pedidos.pdf", FileMode.Create);
                document = new Document(PageSize.A4);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, fileStream);

                document.Open();

                Font columnHead = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, BaseColor.BLACK);

                Paragraph tit = new Paragraph("Reporte de Pedidos");
                tit.Alignment = Element.ALIGN_CENTER;
                document.Add(tit);

                document.Add(new Paragraph($"Pedidos por: {campo}"));
                document.Add(Chunk.NEWLINE);

                PdfPTable tablePedidos = new PdfPTable(dgvPedidos.ColumnCount);
                tablePedidos.WidthPercentage = 100;

                PdfPCell cellHeader;
                foreach (DataGridViewColumn dgvColumn in dgvPedidos.Columns)
                {
                    cellHeader = new PdfPCell(new Phrase(dgvColumn.HeaderText, columnHead))
                    {
                        Border = PdfPCell.NO_BORDER,
                        BackgroundColor = new BaseColor(231, 230, 229),
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        PaddingBottom = 10,
                        PaddingRight = 10,
                    };
                    tablePedidos.AddCell(cellHeader);
                }

                PdfPCell cellContent;
                Font contenido = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.DARK_GRAY);

                if (dgvPedidos.RowCount > 0)
                {
                    foreach (DataGridViewRow dgvRow in dgvPedidos.Rows)
                    {
                        foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                        {
                            if (dgvCell.Value != null)
                            {
                                cellContent = new PdfPCell(new Phrase(dgvCell.Value.ToString(), contenido))
                                {
                                    Border = PdfPCell.NO_BORDER,
                                    BorderColorBottom = new BaseColor(231, 230, 229),
                                    BorderWidthBottom = 1,
                                    PaddingBottom = 10,
                                    PaddingRight = 10,
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    VerticalAlignment = Element.ALIGN_MIDDLE,

                                };
                                tablePedidos.AddCell(cellContent);
                            }
                        }
                    }
                }
                document.Add(tablePedidos);
                document.Close();

                System.Diagnostics.Process.Start("pedidos.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream?.Close();
            }
        }
    }
}
