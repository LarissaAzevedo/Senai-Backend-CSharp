using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;
using Spire.Doc.Fields;

namespace exemplo {
    class Program {
        static void Main (string[] args) {

            #region criacao de documento
                //criação de um documento com nome exemplodoc
                Document exemploDoc = new Document ();
            #endregion

            //adicionada uma seção com o nome secaocapa ao documento
            //cada secao pode ser entendida como uma página do documento
            #region 
                Section secaoCapa = exemploDoc.AddSection ();
            #endregion

            #region criar um parágrafo
                Paragraph titulo = secaoCapa.AddParagraph ();
            #endregion

            #region 
                titulo.AppendText ("Exemplo de título\n\n");
            #endregion

            #region Formatar parágrafo

                //define o alinhamento com uma propriedade
                titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //criação de um novo estilo de formatação e adição ao documento correspondente
                ParagraphStyle estilo01 = new ParagraphStyle(exemploDoc);

                //adiciona nome ao estilo01
                estilo01.Name = "Cor do titulo";

                //Adiciona cor ao texto
                estilo01.CharacterFormat.TextColor = Color.Cyan;

                //define que o texto estará em negrito
                estilo01.CharacterFormat.Bold = true;

                //adiciona o estilo no documento exemploDoc
                exemploDoc.Styles.Add(estilo01);

                //aplica o estilo01 ao parágrafo do título
                titulo.ApplyStyle(estilo01.Name);

            #endregion

            #region trabalhar com tabulação
                //adiciona um parágrafo textoCapa á seção textoCapa
                Paragraph textoCapa = secaoCapa.AddParagraph();

                //Escreve o que aparece no parágrafo, usa tabulação (\t)
                textoCapa.AppendText("\tEste é um exemplo de texto com tabulação");

                //adiciona outro parágrafo na mesma seção
                Paragraph textoCapa2 = secaoCapa.AddParagraph();

                //escreve mais um parágrafo
                textoCapa.AppendText("\tUma seção representa uma página do documento e os parágrafos dentro de uma mesma seção aparecem dentro da mesma página");

            #endregion

            #region Inserir imagem
                //adiciona o parágrafo na secaoCapa
                Paragraph imagemCapa = secaoCapa.AddParagraph();

                //adiciona o texto ao paragrafo imagemCapa
                imagemCapa.AppendText("\n\nAgora vamos inserir uma imagem ao documento\n\n");

                //centraliza horizontalmente o parágrafo imagemCapa
                imagemCapa.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //adiciona uma imagem com nome imagemExemplo 
                DocPicture imagemExemplo = imagemCapa.AppendPicture(Image.FromFile(@"saida\img\logo_csharp.png"));

                //ddefine largura e altura para a imagem
                imagemExemplo.Width = 300;
                imagemExemplo.Height = 300;
            #endregion

            #region Adiciona uma nova seção

                //adiciona uma nova seção
                Section secaoCorpo = exemploDoc.AddSection();

                //adiciona um paragrafo á seçãoCorpo
                Paragraph paragrafoCorpo1 = secaoCorpo.AddParagraph();

                //adiciona um texto ao paragrafo paragrafoCorpo1
                paragrafoCorpo1.AppendText("\tExemplo de paragrafo criado em uma nova seção. aparece em uma nova página já que foi criado em outra seção");

            #endregion

            #region Adicionar tabela

                //adiciona uma tabela a secaoCorpo
                Table tabela = secaoCorpo.AddTable(true);

                //cria o cabeçalho da tabela
                String[] cabecalho = {"Item","Descrição","Qtde.","Preço Unit.","Preço"};

                //definidos os dados da tabela
                String[][] dados = {
                    new String[]{"Cenoura","Vegetal muito nutritivo","1","R$4,00","R$4,00"},
                    new String[]{"Batata","Vegetal muito consumido","2","R$5,00","R$10,00"},
                    new String[]{"Alface","Vegetal usado desde 500 a.C.","1","R$1,50","R$1,50"},
                    new String[]{"Tomate","Tomate é fruta","2","R$6,00","R$12,00"}
                };

                //Adiciona as células na tabela
                tabela.ResetCells(dados.Length + 1, cabecalho.Length);

                //adiciona uma linha na posição [0] no vetor de linhas e define que essa linha é o cabeçalho
                TableRow Linha1 = tabela.Rows[0];
                Linha1.IsHeader = true;

                //define a altura da linha
                Linha1.Height = 23;

                //formatação do cabeçalho
                Linha1.RowFormat.BackColor = Color.AliceBlue;
                
                //percorre as linhas do cabeçalho
                for (int i = 0; i < cabecalho.Length; i++)
                {
                    //adiciona um parágrafo chamado p, formata o conteúdo da célula para o centro, e alinha o texto para o centro
                    Paragraph p = Linha1.Cells[i].AddParagraph();
                    Linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    //formatação dos dados do cabeçalho
                    TextRange TR = p.AppendText(cabecalho[i]);
                    TR.CharacterFormat.FontName = "Calibri";
                    TR.CharacterFormat.FontSize = 14;
                    TR.CharacterFormat.TextColor = Color.Teal;
                    TR.CharacterFormat.Bold = true;
                }

                //adiciona as linhas do corpo da tabela
                for (int r = 0; r < dados.Length; r++)
                {
                    //percorre todos os dados, menos a primeira, que é a do cabeçalho
                    TableRow LinhaDados = tabela.Rows[r + 1];

                    //define a altura da linha
                    LinhaDados.Height = 20;

                    //percorre as colunas
                    for (int c = 0; c < dados[r].Length; c++)
                    {
                        //alinha as células
                        LinhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                        //preenche os dados nas linhas
                        Paragraph p2 = LinhaDados.Cells[c].AddParagraph();

                        TextRange TR2 = p2.AppendText(dados[r][c]);

                        //formatação do paragrafo p2
                        p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                        TR2.CharacterFormat.FontName = "Calibri";
                        TR2.CharacterFormat.FontSize = 12;
                        TR2.CharacterFormat.TextColor = Color.Brown;
                    }
                }

            #endregion

            #region Salvar arquivo

                //salva o arquivo em docx
                exemploDoc.SaveToFile(@"saida\exemplo_arquivo_word.docx", FileFormat.Docx);
            #endregion


        }
    }
}