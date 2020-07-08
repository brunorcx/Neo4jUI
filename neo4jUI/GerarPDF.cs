using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neo4jUI {

    internal class GerarPDF {
        private static List<string> listaString;

        public GerarPDF(List<string> listaString) {
            GerarPDF.listaString = listaString;
        }

        private static Document CreateDocument() {
            // Create a new MigraDoc document
            Document document = new Document();

            //Definir styles
            DefineStyles(document);

            // Add a section to the document
            Section section = document.AddSection();
            section.PageSetup.TopMargin = "0.5cm"; // Diminuir a margem do topo da página
            section.PageSetup.BottomMargin = "-0.5cm";
            //Inserir tabela
            SimpleTable(document);
            // Add a paragraph to the section
            Paragraph paragraph = section.AddParagraph();

            paragraph.Format.Font.Color = MigraDoc.DocumentObjectModel.Color.FromCmyk(100, 30, 20, 50);

            // Add some text to the paragraph
            //paragraph.AddFormattedText("Hello, World!", TextFormat.Bold);

            return document;
        }

        private static void DefineStyles(Document document) {
            // Get the predefined style Normal.
            Style style = document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Times New Roman";

            // Heading1 to Heading9 are predefined styles with an outline level. An outline level
            // other than OutlineLevel.BodyText automatically creates the outline (or bookmarks)
            // in PDF.
            style = document.Styles["Heading1"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 14;
            style.Font.Bold = true;
            style.Font.Color = Colors.DarkBlue;
            style.ParagraphFormat.PageBreakBefore = true;
            //style.ParagraphFormat.SpaceAfter = 6;
        }

        private static void SimpleTable(Document document) {
            //document.LastSection.AddParagraph("Simple Tables", "Heading2");

            Table table = new Table();
            table.Borders.Width = 0.75;
            //table.Borders.Color = Colors.DarkRed;
            Column column = table.AddColumn(Unit.FromCentimeter(3));//Primeira coluna
            //column.Format.Alignment = ParagraphAlignment.Center;
            table.AddColumn(Unit.FromCentimeter(3));//Segunda coluna
            table.AddColumn(Unit.FromCentimeter(3));//Terceira coluna
            table.AddColumn(Unit.FromCentimeter(3));//Quarta coluna
            //table.AddColumn(Unit.FromCentimeter(2));//Quinta coluna
            //table.AddColumn(Unit.FromCentimeter(2));//Sexta coluna
            //table.AddColumn(Unit.FromCentimeter(2));//Sétima coluna
            //table.AddColumn(Unit.FromCentimeter(2));//Oitava coluna
            //table.AddColumn(Unit.FromCentimeter(2));//Nona coluna
            //table.AddColumn(Unit.FromCentimeter(2));//Decima coluna

            //Arrastar tabela
            table.Rows.LeftIndent = "-2cm";
            table.Rows.Height = 22;
            table.Format.Font.Size = 14;
            //table.Format.Font.Color = Colors.DarkRed;
            table.Borders.Color = Colors.White;

            //Arrumar tamanho
            if (listaString.Count < 15)
                for (int i = listaString.Count - 1; i < 15; i++) {
                    listaString.Add("xxxxxxxxx");
                }
            //table.Format.SpaceBefore = "-4cm";
            //Colocar uma border branca e usar row vermelha para completar a linha

            //Linha 0

            Row row = table.AddRow();
            row.Height = 20;

            Cell cell = row.Cells[0];
            cell = row.Cells[2];
            cell.Borders.Right.Color = Colors.White;
            cell = row.Cells[3];
            cell.AddParagraph(listaString[7]);
            //cell.AddImage("../../Resources/imagens/CabecalhoForbras.png");
            //cell.AddParagraph("ENTRADA: " + "\t\tENTREGA: "); //113 caracteres
            //cell.VerticalAlignment = VerticalAlignment.Bottom;
            //cell = row.Cells[1];
            cell.Borders.Right.Color = Colors.White;
            cell.Borders.Top.Color = Colors.White;
            cell.Borders.Color = Colors.DarkBlue;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell.VerticalAlignment = VerticalAlignment.Center;
            //cell.AddParagraph("PEDIDO");
            //cell.AddParagraph("\n000100");
            //row.Cells[0].MergeRight = 1;

            //Linha 1
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[2];

            cell.AddParagraph(listaString[3]);
            cell.Borders.Color = Colors.DarkBlue;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell = row.Cells[3];
            cell.Borders.Right.Color = Colors.DarkBlue;
            //Linha 2
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[1];
            cell.Borders.Right.Color = Colors.DarkBlue;
            cell = row.Cells[2];
            cell.Borders.Right.Color = Colors.DarkRed;
            cell = row.Cells[3];
            cell.AddParagraph(listaString[8]);
            cell.Borders.Color = Colors.DarkRed;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            //Linha 3
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[1];//Coluna 1

            cell.AddParagraph(listaString[1]);
            cell.Borders.Color = Colors.DarkBlue;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell = row.Cells[3];//Coluna 3
            cell.AddParagraph(listaString[9]);
            cell.Borders.Color = Colors.DarkBlue;
            cell.Borders.Right.Color = Colors.White;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            //Linha 4
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[1];
            cell.Borders.Right.Color = Colors.DarkRed;
            cell = row.Cells[2];
            cell.AddParagraph(listaString[4]);
            cell.Borders.Color = Colors.DarkRed;
            cell.Borders.Right.Color = Colors.DarkBlue;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell = row.Cells[3];
            cell.Borders.Right.Color = Colors.DarkBlue;
            //Linha 5
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell.Borders.Bottom.Color = Colors.Black;
            cell = row.Cells[2];
            cell.Borders.Right.Color = Colors.DarkRed;
            cell = row.Cells[3];
            cell.AddParagraph(listaString[10]);
            cell.Borders.Color = Colors.DarkRed;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            //Linha 6
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell.AddParagraph(listaString[0]);
            cell.Borders.Color = Colors.Black;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell = row.Cells[3];
            cell.AddParagraph(listaString[11]);
            cell.Borders.Color = Colors.DarkBlue;
            cell.Borders.Right.Color = Colors.White;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            //Linha 7
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[2];
            cell.AddParagraph(listaString[5]);
            cell.Borders.Color = Colors.DarkBlue;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell = row.Cells[3];
            cell.Borders.Right.Color = Colors.DarkBlue;
            //Linha 8
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[1];
            cell.Borders.Right.Color = Colors.DarkBlue;
            cell = row.Cells[2];
            cell.Borders.Right.Color = Colors.DarkRed;
            cell = row.Cells[3];
            cell.AddParagraph(listaString[12]);
            cell.Borders.Color = Colors.DarkRed;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            //Linha 9
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[1];//Coluna
            cell.AddParagraph(listaString[2]);
            cell.Borders.Color = Colors.DarkRed;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell = row.Cells[3];
            cell.AddParagraph(listaString[13]);
            cell.Borders.Color = Colors.DarkBlue;
            cell.Borders.Right.Color = Colors.White;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            //Linha 10
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[1];
            cell.Borders.Right.Color = Colors.DarkRed;
            cell = row.Cells[2];
            cell.AddParagraph(listaString[6]);
            cell.Borders.Color = Colors.DarkRed;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            cell = row.Cells[3];
            cell.Borders.Right.Color = Colors.DarkBlue;
            //Linha 11
            row = table.AddRow();
            row.Height = 20;

            cell = row.Cells[0];
            cell = row.Cells[2];
            cell.Borders.Right.Color = Colors.DarkRed;
            cell = row.Cells[3];
            cell.AddParagraph(listaString[14]);
            cell.Borders.Color = Colors.DarkRed;
            cell.VerticalAlignment = VerticalAlignment.Center;
            cell.Format.Alignment = ParagraphAlignment.Center;
            //Linha 12
            row = table.AddRow();
            row.Height = 20;
            cell = row.Cells[0];

            /*
            row = table.AddRow();
            row.Height = 60;

            //row.Borders.Color = Colors.White;
            cell = row.Cells[0];
            cell.AddParagraph("CLIENTE: " + listaString[2]).Format.SpaceAfter = 5;
            cell.Format.Borders.Bottom.Width = 0.75;
            //cell.Format.Borders.Width = 4;
            cell.Format.Borders.DistanceFromLeft = -60.0;
            cell.Format.Borders.DistanceFromRight = 4;
            //cell.Format.Borders.DistanceFromRight = -515.0;
            cell.Format.Borders.Bottom.Color = Colors.DarkRed;
            cell.AddParagraph("CNPJ: " + listaString[3] + "\t\tFONE: " + listaString[4]).Format.Borders.Bottom.Color = Colors.White;
            cell.VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[0].MergeRight = 9;
            */
            //Linha 2

            //Adicionar tabela ao documento
            document.LastSection.Add(table);

        }

        public void salvarPDF(string nomeArquivo) {
            // Create a MigraDoc document
            Document document = CreateDocument();
            document.UseCmykColor = true;

            // ===== Unicode encoding and font program embedding in MigraDoc is demonstrated here =====

            // A flag indicating whether to create a Unicode PDF or a WinAnsi PDF file.
            // This setting applies to all fonts used in the PDF document.
            // This setting has no effect on the RTF renderer.
            const bool unicode = false;

            // An enum indicating whether to embed fonts or not.
            // This setting applies to all font programs used in the document.
            // This setting has no effect on the RTF renderer.
            // (The term 'font program' is used by Adobe for a file containing a font. Technically a 'font file'
            // is a collection of small programs and each program renders the glyph of a character when executed.
            // Using a font in PDFsharp may lead to the embedding of one or more font programms, because each outline
            // (regular, bold, italic, bold+italic, ...) has its own fontprogram)
            const PdfFontEmbedding embedding = PdfFontEmbedding.Always;

            // ========================================================================================

            // Create a renderer for the MigraDoc document.
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode, embedding);

            // Associate the MigraDoc document with a renderer
            pdfRenderer.Document = document;

            // Layout and render document to PDF
            pdfRenderer.RenderDocument();

            // Save the document...

            pdfRenderer.PdfDocument.Save(nomeArquivo);
            // ...and start a viewer.
            Process.Start(nomeArquivo);
        }

    }
}