using aula12.Model;

namespace aula12.Controller
{
    public class CarroEletricoController : CarroController
    {
        CarroEletricoModel carroEletrico = new CarroEletricoModel();

        MotorModel motor = new MotorModel();

        public void CarregarBateria (float carga){
            if (carroEletrico.Bateria < 100)
            {
                carroEletrico.Bateria += carga;
            } else{
                System.Console.WriteLine("A bateria está completa, pode viajar.");
            }
        }

        public float StatusBateria(){
            return carroEletrico.Bateria;
        }
    }
}