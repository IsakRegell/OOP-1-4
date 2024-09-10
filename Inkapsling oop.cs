namespace Lektion_1_vecka_3
{
    privet class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Man!");
            Fotbollsspelare Fotbollsspelareobj = new Fotbollsspelare();
            Fotbollsspelareobj.screan();
        }
    }


    public class Fotbollsspelare
    {
        string nameRonaldo = "ronaldo "; //Atribute
        static int ageRonaldo = 40;
        string nameMessi = "messi";
        static int ageMessi = 39;
        int totalage = ageMessi + ageRonaldo;



        //Metod där isak skriver
        public void screan()
        {
            Console.WriteLine("Isak skriver " + nameMessi +" "+ ageMessi + " " + totalage);
        }


    }
}
