namespace aula13_2.Model
{
    public class ProdutoModel
    {
        public string NomeProduto {get; set;}
        public bool Reservado { get; set; }

        public ProdutoModel (string nomeproduto, bool reservado){
            
            this.NomeProduto = nomeproduto;
            this.Reservado = reservado;
        }
    }
}