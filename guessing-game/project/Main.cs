public class Program
{
        private static void Main(String[] args)
        {
                State st = State.GameEnded;
                Player P = new Player("Neo");

                Game Pt = new Game(P, 0, 9999, DateTime.Now, st);

                Console.WriteLine($"{P.Nome}, bem vindo ao jogo da adivinhação!");

                Console.WriteLine($"log da partida: {Pt}");
        }
}
