using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
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
            section.PageSetup.TopMargin = "-0.1cm"; // Diminuir a margem do topo da página
            section.PageSetup.BottomMargin = "-0.5cm";
            //Inserir Tabela
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
            Column column = table.AddColumn(Unit.FromCentimeter(1));//Primeira coluna
            //column.Format.Alignment = ParagraphAlignment.Center;
            table.AddColumn(Unit.FromCentimeter(1));//Segunda coluna
            table.AddColumn(Unit.FromCentimeter(1));//Terceira coluna
            table.AddColumn(Unit.FromCentimeter(1));//Quarta coluna
            table.AddColumn(Unit.FromCentimeter(1));//Quinta coluna
            table.AddColumn(Unit.FromCentimeter(1));//Sexta coluna
            table.AddColumn(Unit.FromCentimeter(1));//Sétima coluna
            table.AddColumn(Unit.FromCentimeter(1));//Oitava coluna
            table.AddColumn(Unit.FromCentimeter(1));//Nona coluna
            //table.AddColumn(Unit.FromCentimeter(2));//Decima coluna

            //Arrastar tabela
            table.Rows.LeftIndent = "-2.5cm";
            table.Rows.HeightRule = RowHeightRule.Exactly;
            table.Rows.Height = "0.4cm";

            //Arrumar formatação

            table.Format.Font.Size = 10;
            table.Format.Font.Color = Colors.White;
            table.Format.Font.Bold = true;
            table.Borders.Color = Colors.White;
            table.Format.Alignment = ParagraphAlignment.Center;
            table.Rows.VerticalAlignment = VerticalAlignment.Center;

            table.Format.SpaceBefore = "-0.04cm"; //Levantar um pouco as letras na celula
            //Colocar uma border branca e usar row vermelha para completar a linha

            //Adicionar 31 linhas
            for (int i = 0; i < 31; i++) {
                table.AddRow();
            }
            table.Columns[7].LeftPadding = -1; //Corrigir espaçamento, tabela dentro de P

            //listaString[25] = "xxxxxxxxxxxWW";

            //Preencher células
            table.Rows[8][0].AddParagraph(listaString[0]);//A
            table.Rows[8][0].Shading.Color = Colors.Black;//A
            table.Rows[8][0].MergeRight = 1;//A

            table.Rows[4][1].AddParagraph(listaString[1]);//B
            table.Rows[4][1].Shading.Color = Colors.DarkBlue;//B
            table.Rows[4][1].MergeRight = 1;//B

            table.Rows[12][1].AddParagraph(listaString[2]);//C
            table.Rows[12][1].Shading.Color = Colors.DarkRed;//C
            table.Rows[12][1].MergeRight = 1;//C

            table.Rows[2][3].AddParagraph(listaString[3]);//D
            table.Rows[2][3].Shading.Color = Colors.DarkBlue;//D
            table.Rows[2][3].MergeRight = 1;//D

            table.Rows[6][3].AddParagraph(listaString[4]);//E
            table.Rows[6][3].Shading.Color = Colors.DarkRed;//E
            table.Rows[6][3].MergeRight = 1;//E

            table.Rows[10][3].AddParagraph(listaString[5]);//F
            table.Rows[10][3].Shading.Color = Colors.DarkBlue;//F
            table.Rows[10][3].MergeRight = 1;//F

            table.Rows[14][3].AddParagraph(listaString[6]);//G
            table.Rows[14][3].Shading.Color = Colors.DarkRed;//G
            table.Rows[14][3].MergeRight = 1;//G

            table.Rows[1][5].AddParagraph(listaString[7]);//H
            table.Rows[1][5].Shading.Color = Colors.DarkBlue;//H
            table.Rows[1][5].MergeRight = 1;//H

            table.Rows[3][5].AddParagraph(listaString[8]);//I
            table.Rows[3][5].Shading.Color = Colors.DarkRed;//I
            table.Rows[3][5].MergeRight = 1;//I

            table.Rows[5][5].AddParagraph(listaString[9]);//J
            table.Rows[5][5].Shading.Color = Colors.DarkBlue;//J
            table.Rows[5][5].MergeRight = 1;//J

            table.Rows[7][5].AddParagraph(listaString[10]);//K
            table.Rows[7][5].Shading.Color = Colors.DarkRed;//K
            table.Rows[7][5].MergeRight = 1;//K

            table.Rows[9][5].AddParagraph(listaString[11]);//L
            table.Rows[9][5].Shading.Color = Colors.DarkBlue;//L
            table.Rows[9][5].MergeRight = 1;//L

            table.Rows[11][5].AddParagraph(listaString[12]);//M
            table.Rows[11][5].Shading.Color = Colors.DarkRed;//M
            table.Rows[11][5].MergeRight = 1;//M

            table.Rows[13][5].AddParagraph(listaString[13]);//N
            table.Rows[13][5].Shading.Color = Colors.DarkBlue;//N
            table.Rows[13][5].MergeRight = 1;//N

            table.Rows[15][5].AddParagraph(listaString[14]);//O
            table.Rows[15][5].Shading.Color = Colors.DarkRed;//O
            table.Rows[15][5].MergeRight = 1;//O

            table.Rows[0][7].MergeRight = 1;//P
            table.Rows[0][7].MergeDown = 30;//P
            table.Rows[0][7].VerticalAlignment = VerticalAlignment.Top;//P
            table.Rows[0][7].AddTextFrame().Height = "0.2cm";//P
            table.Rows[0][7].Elements.Add(SegundaTabela());//P

            List<Cell> celulas = new List<Cell> {
                table.Rows[8][0],//A
                table.Rows[4][1],//B
                table.Rows[12][1],//C
                table.Rows[2][3],//D
                table.Rows[6][3],//E
                table.Rows[10][3],//F
                table.Rows[14][3],//G
                table.Rows[1][5],//H
                table.Rows[3][5],//I
                table.Rows[5][5],//J
                table.Rows[7][5],//K
                table.Rows[9][5],//L
                table.Rows[11][5],//M
                table.Rows[13][5],//N
                table.Rows[15][5],//O
                table.Rows[0][7]//P
            };

            for (int i = 0; i < celulas.Count; i++) {
                celulas[i].Format.Font.Size = 10;
                var tamanho = TamanhoTexto(listaString[i], celulas[i].Format.Font.Size.Value);
                while (tamanho > 55) {
                    celulas[i].Format.Font.Size = celulas[i].Format.Font.Size - 0.5;
                    tamanho = TamanhoTexto(listaString[i], celulas[i].Format.Font.Size);
                }
            }

            /*
             celulas[i].Format.Font.Size = 10;
                var tamanho = TamanhoTexto(listaString[i], celulas[i].Format.Font.Size.Value);
                while (tamanho > 55) {
                    celulas[i].Format.Font.Size = celulas[i].Format.Font.Size - 0.25;
                    tamanho = TamanhoTexto(listaString[i], celulas[i].Format.Font.Size);
                }
             */

            /*31 Linhas RowHeight=10 /4 Colunas 2cm
            table.Rows[15][0].AddParagraph(listaString[0]);//A
            table.Rows[15][0].Shading.Color = Colors.Black;//A

            table.Rows[7][1].AddParagraph(listaString[1]);//B
            table.Rows[7][1].Shading.Color = Colors.DarkBlue;//B

            table.Rows[23][1].AddParagraph(listaString[2]);//C
            table.Rows[23][1].Shading.Color = Colors.DarkRed;//C

            table.Rows[3][2].AddParagraph(listaString[3]);//D
            table.Rows[3][2].Shading.Color = Colors.DarkBlue;//D

            table.Rows[11][2].AddParagraph(listaString[4]);//E
            table.Rows[11][2].Shading.Color = Colors.DarkRed;//E

            table.Rows[19][2].AddParagraph(listaString[5]);//F
            table.Rows[19][2].Shading.Color = Colors.DarkBlue;//F

            table.Rows[27][2].AddParagraph(listaString[6]);//G
            table.Rows[27][2].Shading.Color = Colors.DarkRed;//G

            table.Rows[1][3].AddParagraph(listaString[7]);//H
            table.Rows[1][3].Shading.Color = Colors.DarkBlue;//H

            table.Rows[5][3].AddParagraph(listaString[8]);//I
            table.Rows[5][3].Shading.Color = Colors.DarkRed;//I

            table.Rows[9][3].AddParagraph(listaString[9]);//J
            table.Rows[9][3].Shading.Color = Colors.DarkBlue;//J

            table.Rows[13][3].AddParagraph(listaString[10]);//K
            table.Rows[13][3].Shading.Color = Colors.DarkRed;//K

            table.Rows[17][3].AddParagraph(listaString[11]);//L
            table.Rows[17][3].Shading.Color = Colors.DarkBlue;//L

            table.Rows[21][3].AddParagraph(listaString[12]);//M
            table.Rows[21][3].Shading.Color = Colors.DarkRed;//M

            table.Rows[25][3].AddParagraph(listaString[13]);//N
            table.Rows[25][3].Shading.Color = Colors.DarkBlue;//N

            table.Rows[29][3].AddParagraph(listaString[14]);//O
            table.Rows[29][3].Shading.Color = Colors.DarkRed;//O

            table.Rows[0][4].AddParagraph(listaString[15]);//P
            table.Rows[0][4].Shading.Color = Colors.DarkBlue;//P

            table.Rows[2][4].AddParagraph(listaString[16]);//Q
            table.Rows[2][4].Shading.Color = Colors.DarkRed;//Q

            table.Rows[4][4].AddParagraph(listaString[17]);//R
            table.Rows[4][4].Shading.Color = Colors.DarkBlue;//R

            table.Rows[6][4].AddParagraph(listaString[18]);//S
            table.Rows[6][4].Shading.Color = Colors.DarkRed;//S

            table.Rows[8][4].AddParagraph(listaString[19]);//T
            table.Rows[8][4].Shading.Color = Colors.DarkBlue;//T

            table.Rows[10][4].AddParagraph(listaString[20]);//U
            table.Rows[10][4].Shading.Color = Colors.DarkRed;//U

            table.Rows[12][4].AddParagraph(listaString[21]);//W
            table.Rows[12][4].Shading.Color = Colors.DarkBlue;//W

            table.Rows[14][4].AddParagraph(listaString[22]);//X
            table.Rows[14][4].Shading.Color = Colors.DarkRed;//X

            table.Rows[16][4].AddParagraph(listaString[23]);//Y
            table.Rows[16][4].Shading.Color = Colors.DarkBlue;//Y

            table.Rows[18][4].AddParagraph(listaString[24]);//Z
            table.Rows[18][4].Shading.Color = Colors.DarkRed;//Z

            table.Rows[20][4].AddParagraph(listaString[25]);//A1
            table.Rows[20][4].Shading.Color = Colors.DarkBlue;//A1

            table.Rows[22][4].AddParagraph(listaString[26]);//B1
            table.Rows[22][4].Shading.Color = Colors.DarkRed;//B1

            table.Rows[24][4].AddParagraph(listaString[27]);//C1
            table.Rows[24][4].Shading.Color = Colors.DarkBlue;//C1

            table.Rows[26][4].AddParagraph(listaString[28]);//D1
            table.Rows[26][4].Shading.Color = Colors.DarkRed;//D1

            table.Rows[28][4].AddParagraph(listaString[29]);//E1
            table.Rows[28][4].Shading.Color = Colors.DarkBlue;//E1

            table.Rows[30][4].AddParagraph(listaString[30]);//F1
            table.Rows[30][4].Shading.Color = Colors.DarkRed;//F1
             */

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

        private static Table SegundaTabela() {
            Table table = new Table();
            table.Borders.Width = 0.75;

            //table.Borders.Color = Colors.DarkRed;
            Column column = table.AddColumn(Unit.FromCentimeter(1.87));//Primeira coluna

            //Arrastar tabela
            //table.Rows.LeftIndent = "-10.5cm";
            table.Rows.HeightRule = RowHeightRule.Exactly;
            table.Rows.Height = "0.4cm";
            //Arrumar formatação
            table.Format.Font.Size = 10;
            table.Format.Font.Color = Colors.White;
            table.Format.Font.Bold = true;
            table.Borders.Color = Colors.White;
            table.Format.Alignment = ParagraphAlignment.Center;
            //table.Rows.VerticalAlignment = VerticalAlignment.Center;

            //Adicionar 31 linhas
            for (int i = 0; i < 16; i++) {
                if (i % 2 == 0)
                    table.AddRow().Shading.Color = Colors.DarkBlue;
                else
                    table.AddRow().Shading.Color = Colors.DarkRed;

            }
            table.Rows[0][0].AddParagraph(listaString[15]);//P

            table.Rows[1][0].AddParagraph(listaString[16]);//Q

            table.Rows[2][0].AddParagraph(listaString[17]);//R

            table.Rows[3][0].AddParagraph(listaString[18]);//S

            table.Rows[4][0].AddParagraph(listaString[19]);//T

            table.Rows[5][0].AddParagraph(listaString[20]);//U

            table.Rows[6][0].AddParagraph(listaString[21]);//V

            table.Rows[7][0].AddParagraph(listaString[22]);//W

            table.Rows[8][0].AddParagraph(listaString[23]);//X

            table.Rows[9][0].AddParagraph(listaString[24]);//Y

            table.Rows[10][0].AddParagraph(listaString[25]);//Z

            table.Rows[11][0].AddParagraph(listaString[26]);//A1

            table.Rows[12][0].AddParagraph(listaString[27]);//B1

            table.Rows[13][0].AddParagraph(listaString[28]);//C1

            table.Rows[14][0].AddParagraph(listaString[29]);//D1

            table.Rows[15][0].AddParagraph(listaString[30]);//E1

            List<Cell> celulas = new List<Cell> {
                table.Rows[0][0],//P
                table.Rows[1][0],//Q
                table.Rows[2][0],//R
                table.Rows[3][0],//S
                table.Rows[4][0],//T
                table.Rows[5][0],//U
                table.Rows[6][0],//V
                table.Rows[7][0],//W
                table.Rows[8][0],//X
                table.Rows[9][0],//Y
                table.Rows[10][0],//Z
                table.Rows[11][0],//A1
                table.Rows[12][0],//B1
                table.Rows[13][0],//C1
                table.Rows[14][0],//D1
                table.Rows[15][0]//E1
        };
            for (int i = 0; i < celulas.Count; i++) {
                celulas[i].Format.Font.Size = 10;
                var tamanho = TamanhoTexto(listaString[i + 15], celulas[i].Format.Font.Size.Value);
                while (tamanho > 51) {
                    celulas[i].Format.Font.Size = celulas[i].Format.Font.Size - 0.5;
                    tamanho = TamanhoTexto(listaString[i + 15], celulas[i].Format.Font.Size);
                }
            }

            return table;
        }

        private static double TamanhoTexto(string nome, double fontSize) {
            var pdfDoc = new PdfSharp.Pdf.PdfDocument();
            var pdfPage = pdfDoc.AddPage();
            var pdfGfx = PdfSharp.Drawing.XGraphics.FromPdfPage(pdfPage);
            var pdfFont = new PdfSharp.Drawing.XFont("Times New Roman", fontSize);
            var tamanho = pdfGfx.MeasureString(nome, pdfFont).Width;
            return tamanho;

            //pdfGfx.DrawString("Hello World!", pdfFont, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(100, 100));
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