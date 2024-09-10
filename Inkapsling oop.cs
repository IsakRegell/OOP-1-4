namespace Lektion_1_vecka_3
{
    public class Program
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
       private string nameRonaldo = "ronaldo "; //Atribute
       private static int ageRonaldo = 40;
       private string nameMessi = "messi";
       private static int ageMessi = 39;
       private int totalage = ageMessi + ageRonaldo;



        //Metod där isak skriver
        public void screan()
        {
            Console.WriteLine("Isak skriver " + nameMessi +" "+ ageMessi + " " + totalage);
        }
        
         //metoder för att få åtkomst till private
    public string GetNameRonaldo()
{
    return nameRonaldo;  
}

public int GetAgeRonaldo()
{
    return ageRonaldo;  
}

public string GetNameMessi()
{
    return nameMessi;  
}

public int GetAgeMessi()
{
    return ageMessi;  
}

public int GetTotalAge()
{
    return totalage;  
}

    }

   


