namespace Cvicenie_OOP_grapocitacowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Bača Jano", 150, 200, 40000);
            Player player2 = new Player("Zemepán Nikolaj Palfi", 10, 1950, 60);

            while (player2.HP >= 0 && player1.HP >= 0)
            {
                Console.WriteLine("Player2 HP: " + player2.HP);
                player1.DamagePlayer(player2);
                Console.WriteLine("Player2 HP after Fight: " + player2.HP);
                Thread.Sleep(0100);

                Console.WriteLine("Player1 HP: " + player1.HP);
                player2.DamagePlayer(player1);
                Console.WriteLine("Player1 HP after Fight: " + player1.HP);
                Thread.Sleep(0100);
            }

            if (player1.HP > player2.HP)
            {
                Console.WriteLine("Player1 is winner!");
            }
            else
            {
                Console.WriteLine("Player2 is winner!");
            }
            
        }
    }
}