using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;
using Spire.Doc.Fields;

namespace aula7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criação do documento
                Document Empresa = new Document();
            #endregion


            #region Criação da seção 1
                Section secao1 = Empresa.AddSection();
            #endregion


            #region Criação do parágrafo título e adição de conteúdo
                Paragraph titulo = secao1.AddParagraph();
                titulo.AppendText("Título");
            #endregion


            #region Formatação do parágrafo
                titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;
            #endregion


            #region Criação do estilo do texto
                ParagraphStyle estilo = new ParagraphStyle();

                estilo.Name = "Estilo do texto";

                estilo.CharacterFormat.TextColor = Color.Blue;

                estilo.CharacterFormat.BackColor = Color.pink;

                Empresa.Styles.Add(estilo);

            #endregion


            #region 
            #endregion

            #region 
            #endregion
        }
    }
}
