namespace aula13_desafio.Model {
    public class CapitaoModel {
        public bool Escudo { get; set; }

        public bool Cor { get; set; }

        public CapitaoModel(bool escudo, bool cor){
         
            this.Escudo = escudo;
            this.Cor = cor;
        }
    }
}