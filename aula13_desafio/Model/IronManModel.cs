namespace aula13_desafio.Model {
    public class IronManModel {
        public bool Armadura { get; set; }

        public bool Cor { get; set; }

        public IronManModel (bool armadura, bool cor) {

            this.Armadura = armadura;
            this.Cor = cor;
        }
    }
}