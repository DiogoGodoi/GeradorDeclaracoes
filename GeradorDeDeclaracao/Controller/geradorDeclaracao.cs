using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using Model;
using System.Data;

namespace Controller
{
    public class geradorDeclaracao
    {
        private static string logo = @"C:\Program Files\gerador de declarações\img\logo.png";
        private static DateTime dt =  DateTime.Now;
        private static string dataFormat = String.Format("{0:dd/MM/yyyy}", dt);
        public static void declaracaoPonto(List<mdlFuncionario> listMdlFuncionario, string caminho, string momento, string dia, string horario)
        {
            Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 80);
            document.AddCreationDate();
            PdfWriter escrever = PdfWriter.GetInstance(document, new FileStream(caminho, FileMode.Create));
            Font fonte = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
            document.Open();

            foreach (var idx in listMdlFuncionario)
            {
                Paragraph marginTop = new Paragraph();
                marginTop.Add(new Paragraph(" "));
                document.Add(marginTop);

                Image img = Image.GetInstance(logo);
                img.Alignment = Element.ALIGN_CENTER;
                img.ScaleToFit(150f, 150f);
                document.Add(img);

                Paragraph cabecalho = new Paragraph("", fonte);
                cabecalho.Alignment = Element.ALIGN_CENTER;
                cabecalho.Add("JUSTIFICATIVA DE NÃO REGISTRO DE PONTO");

                Paragraph marginContent = new Paragraph();
                marginContent.Add(new Paragraph(" "));
                document.Add(marginContent);

                Paragraph conteudoFuncionario = new Paragraph("", fonte);
                conteudoFuncionario.Alignment = Element.ALIGN_CENTER;
                conteudoFuncionario.Add($"NOME: {idx.getNome()}\r\nMATRICULA: {idx.getCracha()}\r\n");

                PdfPTable tabela = new PdfPTable(1);
                PdfPCell celCabecalho = new PdfPCell();
                celCabecalho.AddElement(cabecalho);
                tabela.AddCell(celCabecalho);
                document.Add(tabela);

                Paragraph espacamento = new Paragraph();
                espacamento.Add(new Paragraph(" "));
                document.Add(espacamento);

                PdfPTable tabela2 = new PdfPTable(1);
                PdfPCell celFuncionario = new PdfPCell();
                celFuncionario.AddElement(conteudoFuncionario);
                tabela2.AddCell(celFuncionario);
                document.Add(tabela2);

                Paragraph espacamento3 = new Paragraph("");
                espacamento3.Add(new Paragraph(" "));
                document.Add(espacamento3);

                Paragraph conteudo = new Paragraph("", fonte);
                conteudo.Alignment = Element.ALIGN_CENTER;
                conteudo.Add($"NÃO REGISTROU O PONTO {momento} DIA {dia}. \r\nHORÁRIO INFORMADO {horario} PARA REGISTRO MANUAL.");
                document.Add(conteudo);

                Paragraph espacamento4 = new Paragraph("");
                espacamento4.Add(new Paragraph(" "));
                document.Add(espacamento4);

                Paragraph conteudo2 = new Paragraph("", fonte);
                conteudo2.Alignment = Element.ALIGN_CENTER;
                conteudo2.Add($"EU, {idx.getNome()} DECLARO VERACIDADE DAS INFORMAÇÕES ACIMA DESCRITAS");
                document.Add(conteudo2);

                Paragraph marginContent2 = new Paragraph();
                marginContent2.Add(new Paragraph(" "));
                document.Add(marginContent2);

                Paragraph linha = new Paragraph("", fonte);
                linha.Alignment = Element.ALIGN_CENTER;
                linha.Add("__________________________      __________________________\r\nAssinatura do Solicitante                " +
                    "        Assinatura do RH");
                document.Add(linha);

                Paragraph marginBottom = new Paragraph();
                marginBottom.Add(new Paragraph(" "));
                document.Add(marginBottom);

                Paragraph rodape = new Paragraph($"Data de emissão: {dataFormat}", fonte);
                rodape.Alignment = Element.ALIGN_CENTER;
                document.Add(rodape);
            }
                document.Close();

        }
        public static void declaracaoPontoTudo(List<mdlFuncionario> tabela, string caminho, string momento, string dia, string horario)
        {
            Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 80);
            document.AddCreationDate();
            PdfWriter escrever = PdfWriter.GetInstance(document, new FileStream(caminho, FileMode.Create));
            Font fonte = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
                        
            document.Open();

            foreach (var item in tabela) {

                Paragraph marginTop = new Paragraph("");
                document.Add(marginTop);

                string nome = item.getNome();
                string cracha = item.getCracha().ToString();

                Image img = Image.GetInstance(logo);
                img.Alignment = Element.ALIGN_CENTER;
                img.ScaleToFit(150f, 150f);
                document.Add(img);

                Paragraph marginbottom = new Paragraph();
                marginbottom.Add(new Paragraph(" "));
                document.Add(marginbottom);

                Paragraph cabecalho = new Paragraph("", fonte);
                cabecalho.Alignment = Element.ALIGN_CENTER;
                cabecalho.Add("JUSTIFICATIVA DE NÃO REGISTRO DE PONTO");

                Paragraph conteudoFuncionario = new Paragraph("", fonte);
                conteudoFuncionario.Alignment = Element.ALIGN_CENTER;
                conteudoFuncionario.Add($"NOME: {nome}\r\nMATRICULA: {cracha}\r\n");

                PdfPTable tab = new PdfPTable(1);
                PdfPCell celCabecalho = new PdfPCell();
                celCabecalho.AddElement(cabecalho);
                tab.AddCell(celCabecalho);
                document.Add(tab);

                Paragraph espacamento = new Paragraph();
                espacamento.Add(new Paragraph(" "));
                document.Add(espacamento);

                PdfPTable tab2 = new PdfPTable(1);
                PdfPCell celFuncionario = new PdfPCell();
                celFuncionario.AddElement(conteudoFuncionario);
                tab2.AddCell(celFuncionario);
                document.Add(tab2);

                Paragraph espacamento3 = new Paragraph("");
                espacamento3.Add(new Paragraph(" "));
                document.Add(espacamento3);

                Paragraph conteudo = new Paragraph("", fonte);
                conteudo.Alignment = Element.ALIGN_CENTER;
                conteudo.Add($"NÃO REGISTROU O PONTO {momento} DIA {dia}. \r\nHORÁRIO INFORMADO {horario} PARA REGISTRO MANUAL.");
                document.Add(conteudo);

                Paragraph espacamento4 = new Paragraph("");
                espacamento4.Add(new Paragraph(" "));
                document.Add(espacamento4);

                Paragraph conteudo2 = new Paragraph("", fonte);
                conteudo2.Alignment = Element.ALIGN_CENTER;
                conteudo2.Add($"EU, {nome} DECLARO VERACIDADE DAS INFORMAÇÕES ACIMA DESCRITAS");
                document.Add(conteudo2);

                Paragraph linha = new Paragraph("", fonte);
                linha.Alignment = Element.ALIGN_CENTER;
                linha.Add("__________________________      __________________________\r\nAssinatura do Solicitante                " +
                    "        Assinatura do RH");
                document.Add(linha);

                Paragraph marginBottom = new Paragraph();
                marginBottom.Add(new Paragraph(" "));
                document.Add(marginBottom);

                Paragraph rodape = new Paragraph($"Data de emissão: {dataFormat}", fonte);
                rodape.Alignment = Element.ALIGN_CENTER;
                document.Add(rodape);
            }
            document.Close();

        }      
        public static void declaracaoAntecipada(List<mdlFuncionario> listMdlFuncionario, string caminho, string titulo, string momento, string dia, string horario)
        {
            Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 80);
            document.AddCreationDate();
            PdfWriter escrever = PdfWriter.GetInstance(document, new FileStream(caminho, FileMode.Create));
            Font fonte = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
            
            document.Open();

            foreach (var idx in listMdlFuncionario)
            {
                Paragraph marginTop = new Paragraph();
                marginTop.Add(new Paragraph(" "));
                document.Add(marginTop);

                Image img = Image.GetInstance(logo);
                img.Alignment = Element.ALIGN_CENTER;
                img.ScaleToFit(150f, 150f);
                document.Add(img);

                Paragraph cabecalho = new Paragraph("", fonte);
                cabecalho.Alignment = Element.ALIGN_CENTER;
                cabecalho.Add(titulo);

                Paragraph marginContent = new Paragraph();
                marginContent.Add(new Paragraph(" "));
                document.Add(marginContent);

                Paragraph conteudoFuncionario = new Paragraph("", fonte);
                conteudoFuncionario.Alignment = Element.ALIGN_CENTER;
                conteudoFuncionario.Add($"NOME: {idx.getNome()}\r\nMATRICULA: {idx.getCracha()}\r\n");

                PdfPTable tabela = new PdfPTable(1);
                PdfPCell celCabecalho = new PdfPCell();
                celCabecalho.AddElement(cabecalho);
                tabela.AddCell(celCabecalho);
                document.Add(tabela);

                Paragraph espacamento = new Paragraph();
                espacamento.Add(new Paragraph(" "));
                document.Add(espacamento);

                PdfPTable tabela2 = new PdfPTable(1);
                PdfPCell celFuncionario = new PdfPCell();
                celFuncionario.AddElement(conteudoFuncionario);
                tabela2.AddCell(celFuncionario);
                document.Add(tabela2);

                Paragraph espacamento3 = new Paragraph("");
                espacamento3.Add(new Paragraph(" "));
                document.Add(espacamento3);

                Paragraph conteudo = new Paragraph("", fonte);
                conteudo.Alignment = Element.ALIGN_CENTER;
                conteudo.Add($"{momento} DIA {dia} às {horario}.");
                document.Add(conteudo);

                Paragraph espacamento4 = new Paragraph("");
                espacamento4.Add(new Paragraph(" "));
                document.Add(espacamento4);

                Paragraph conteudo2 = new Paragraph("", fonte);
                conteudo2.Alignment = Element.ALIGN_CENTER;
                conteudo2.Add($"EU, {idx.getNome()} DECLARO VERACIDADE DAS INFORMAÇÕES ACIMA DESCRITAS");
                document.Add(conteudo2);

                Paragraph linha = new Paragraph("", fonte);
                linha.Alignment = Element.ALIGN_CENTER;
                linha.Add("__________________________      __________________________\r\nAssinatura do Solicitante                " +
                    "        Assinatura do RH");
                document.Add(linha);

                Paragraph marginBottom = new Paragraph();
                marginBottom.Add(new Paragraph(" "));
                document.Add(marginBottom);

                Paragraph rodape = new Paragraph($"Data de emissão: {dataFormat}", fonte);
                rodape.Alignment = Element.ALIGN_CENTER;
                document.Add(rodape);
            }
            document.Close();

        }
        public static void declaracaoAntecipadaTudo(List<mdlFuncionario> mdlListaFuncionarios, string caminho, string titulo, string momento, string dia, string horario)
        {
            Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 80);
            document.AddCreationDate();
            PdfWriter escrever = PdfWriter.GetInstance(document, new FileStream(caminho, FileMode.Create));
            Font fonte = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);

            document.Open();

            foreach (var item in mdlListaFuncionarios)
            {

                Paragraph marginTop = new Paragraph();
                marginTop.Add(new Paragraph(" "));
                document.Add(marginTop);

                string nome = item.getNome();
                string cracha = item.getCracha().ToString();

                Image img = Image.GetInstance(logo);
                img.Alignment = Element.ALIGN_CENTER;
                img.ScaleToFit(130f, 130f);
                document.Add(img);

                Paragraph marginbottom = new Paragraph();
                marginbottom.Add(new Paragraph(" "));
                document.Add(marginbottom);

                Paragraph cabecalho = new Paragraph("", fonte);
                cabecalho.Alignment = Element.ALIGN_CENTER;
                cabecalho.Add(titulo);

                Paragraph conteudoFuncionario = new Paragraph("", fonte);
                conteudoFuncionario.Alignment = Element.ALIGN_CENTER;
                conteudoFuncionario.Add($"NOME: {nome}\r\nMATRICULA: {cracha}\r\n");

                PdfPTable tab = new PdfPTable(1);
                PdfPCell celCabecalho = new PdfPCell();
                celCabecalho.AddElement(cabecalho);
                tab.AddCell(celCabecalho);
                document.Add(tab);

                Paragraph espacamento = new Paragraph();
                espacamento.Add(new Paragraph(" "));
                document.Add(espacamento);

                PdfPTable tab2 = new PdfPTable(1);
                PdfPCell celFuncionario = new PdfPCell();
                celFuncionario.AddElement(conteudoFuncionario);
                tab2.AddCell(celFuncionario);
                document.Add(tab2);

                Paragraph espacamento3 = new Paragraph("");
                espacamento3.Add(new Paragraph(" "));
                document.Add(espacamento3);

                Paragraph conteudo = new Paragraph("", fonte);
                conteudo.Alignment = Element.ALIGN_CENTER;
                conteudo.Add($"{momento} DIA {dia} às {horario}.");
                document.Add(conteudo);

                Paragraph espacamento4 = new Paragraph("");
                espacamento4.Add(new Paragraph(" "));
                document.Add(espacamento4);

                Paragraph conteudo2 = new Paragraph("", fonte);
                conteudo2.Alignment = Element.ALIGN_CENTER;
                conteudo2.Add($"EU, {nome} DECLARO VERACIDADE DAS INFORMAÇÕES ACIMA DESCRITAS");
                document.Add(conteudo2);

                Paragraph linha = new Paragraph("", fonte);
                linha.Alignment = Element.ALIGN_CENTER;
                linha.Add("__________________________      __________________________\r\nAssinatura do Solicitante                " +
                    "        Assinatura do RH");
                document.Add(linha);

                Paragraph marginBottom = new Paragraph();
                marginBottom.Add(new Paragraph(" "));
                document.Add(marginBottom);

                Paragraph rodape = new Paragraph($"Data de emissão: {dataFormat}", fonte);
                rodape.Alignment = Element.ALIGN_CENTER;
                document.Add(rodape);


            }
            document.Close();
            
        }

    }
}
