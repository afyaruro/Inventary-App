using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entidades;
using System.IO;

namespace Infraestructur
{
    public class DocumentoPdf
    {
        public void GuadarPdf (List<Cliente> clientes, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document documento = new Document(iTextSharp.text.PageSize.LETTER,40,40,40,40);
            PdfWriter writer = PdfWriter.GetInstance(documento, stream);
            documento.AddAuthor("Aplicacion Inventary_App");
            documento.Open();
            documento.Add(new Paragraph("INFORME DE CLIENTES REGISTRADOS"));
            documento.Add(new Paragraph("\n"));
            documento.Add(LLenarTabla(clientes));
            documento.Close();

        }

        private PdfPTable LLenarTabla(List<Cliente> clientes)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Cedula"));
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Apellido"));
            tabla.AddCell(new Paragraph("Celular"));
            tabla.AddCell(new Paragraph("Email"));

            foreach (var item in clientes)
            { 
                tabla.AddCell(new Paragraph(item.CedulaCliente));
                tabla.AddCell(new Paragraph(item.NombreCliente));
                tabla.AddCell(new Paragraph(item.ApellidoCliente));
                tabla.AddCell(new Paragraph(item.CelularCliente));
                tabla.AddCell(new Paragraph(item.Email));

            }

            return tabla;

        }

    }
}
