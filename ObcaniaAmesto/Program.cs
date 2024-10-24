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

            Lekar LekarZblatislavy = new Lekar("Matko", 129);
            Programator ProgramatorZBlatislavy = new Programator("Kim Ling Tchin", 31);
            Ucitel UcitelZBlatislavy = new Ucitel("目標", 69);

            Lekar LekarZKosic = new Lekar("Imejl Imro", 24);
            Programator ProgramatorZKosic = new Programator("Peter Kentos", 16);
            Ucitel UcitelZKosic = new Ucitel("Duri Nakata", 15);

           
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