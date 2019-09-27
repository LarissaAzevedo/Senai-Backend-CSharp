using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace aula7._2 {
    class Program {
        static void Main (string[] args) {
            #region Criação do documento
            Document Empresa = new Document ();
            #endregion

            #region Criação da seção 1
            Section secao1 = Empresa.AddSection ();
            #endregion

            #region Criação do parágrafo título e adição de conteúdo
            Paragraph titulo = secao1.AddParagraph ();
            titulo.AppendText ("Título");
            #endregion

            #region Formatação do parágrafo
            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;
            #endregion

            #region Criação do estilo do texto
            ParagraphStyle estilo = new ParagraphStyle ();

            estilo.Name = "Estilo do texto";

            estilo.CharacterFormat.TextColor = Color.Blue;

            estilo.CharacterFormat.BackColor = Color.pink;

            Empresa.Styles.Add (estilo);

            #endregion

            #region criação da tabela
            Table tabela = secao1.AddTable (true);

            //cabeçalho da tabela
            String[] cabecalho = { "Nome", "Descrição", "Vendedor", "Preço" };

            //Dados da tabela
            String[][] dados = {
                new String[] { "Sopa fria", "Sopa cozida só que fria", "Larissa", "R$25,00" },
                new String[] { "Quiche napolitana", "Achei na net", "Larissa", "R$30,00" },
                new String[] { "Soja com legumes", "Seguro pra vegetarianos", "Larissa", "R$45,00" }
            };

            //adiciona as células na tabela
            tabela.ResetCells (dados.Length + 1, cabecalho.Length);

            //linha na posição[0] para o cabeçalho
            TableRow Linha1 = tabela.Rows[0];
            Linha1.IsHeader = true;

            #endregion

            #region 
            #endregion
        }
    }
}