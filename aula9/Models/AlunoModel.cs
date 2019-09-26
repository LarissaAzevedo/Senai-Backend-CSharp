namespace aula9.Models {
    public class AlunoModel {

        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome { get; set; }

        /// <summary>
        /// Nome do curso
        /// </summary>
        /// <value>string</value>
        public string Curso { get; set; }

        /// <summary>
        /// RA do aluno
        /// </summary>
        /// <value>string</value>
        public String RA { get; set; }

        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        public int Idade { get; set; }

        /// <summary>
        /// Começar a estudar
        /// </summary>
        public void Estudar(){
            Console.WriteLine("Estou estudando!");
        }

        /// <summary>
        /// Pedir intervalo
        /// </summary>
        public void PedirIntervalo(){
            Console.WriteLine("Pode fazer intervalo ae");
            Console.WriteLine("Quero cafééé");
        }

        /// <summary>
        /// Pedir ajuda para o professor
        /// </summary>
        public void PedirAjuda(){
            Console.WriteLine("Ô Pauloo, ajuda aqui!");
        }
    }
}