namespace ObcaniaAmesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BL
            Citizen Majo = new Citizen("Majo", 34);
            Citizen Fifo = new Citizen("Fifo", 14);
            Citizen Kubo = new Citizen("Kubo", 20);

            //KE
            Citizen Tono = new Citizen("Tono", 49);
            Citizen CiernyJozo = new Citizen("Cierny Jozo", 27);
            Citizen Roman = new Citizen("Roman", 58);

            City Bratislava = new City("Bratislava");

            Bratislava.PridajObcanov(Majo);
            Bratislava.PridajObcanov(Fifo);
            Bratislava.PridajObcanov(Kubo);


            City Kosice = new City("Kosice");

            Kosice.PridajObcanov(Tono);
            Kosice.PridajObcanov(CiernyJozo);
            Kosice.PridajObcanov(Roman);

            Bratislava.VypisObcanov();    
            Kosice.VypisObcanov();
            
        }
    }
}