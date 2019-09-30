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
                new String[] { "Soja com legumes", "Seguro pra vegetarianos", "Larissa", "R$45,00" },
                new String[] {"Arroz com ovo","Feito na hora","Larissa","R$9,90"}
            };

            //adiciona as células na tabela
            tabela.ResetCells (dados.Length + 1, cabecalho.Length);

            //linha na posição[0] para o cabeçalho
            TableRow Linha1 = tabela.Rows[0];
            Linha1.IsHeader = true;

            //formatação das colunas da tabela, percorre uma a uma
            for(int i = 0; i < cabecalho.Length; i++){
                Paragraph p = Linha1.Cells[i].AddParagraph();

                //deixou centralizado tanto na horizontal como na vertical
                Linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //formatação da fonte dos textos da tabela, fonte segoe e tamanho 14
                TextRange TR = p.AppendText(cabecalho[i]);
                TR.CharacterFormat.FontName = "Segoe";
                TR.CharacterFormat.FontSize = 14;
            }

            //agora formatação das linhas do corpo da tebela
            for(int r = 0; r < dados.Length; r++){

                //percorre todas as linhas da tabela, exceto a primeira do cabeçalho
                TableRow LinhaDados = tabela.Rows[r + 1];

                //percorre as colunas
                for (int c = 0; c < dados[r].Length; c++)
                {
                    //verticalmente centralizado
                    LinhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    //preenche com os dados nas linhas
                    Paragraph p2 = LinhaDados.Cells[c].AddParagraph();

                    TextRange TR2 = p2.AppendText(dados[r][c]);

                    //formatação dos dados
                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    
                }
            }

            #endregion

            #region 
            #endregion
        }
    }
}