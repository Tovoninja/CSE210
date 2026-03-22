
class Program
{
    public static void ProcessPerson(Person person)
    {
        if (person is Police police)
        {
            Console.WriteLine(police.GetPoliceINformation());
        }
        else if (person is Police doctor)
        {
            
        }
    }
     public static void Main(string[] args)
    {
        Person person = new Person("Bob", "Ross", 50, 195);
        
        Doctor myDoctor = new Doctor("Ax", "Bob","budge", 75,67);
        Console.WriteLine(myDoctor.GetDoctot);
    }

    string person = "joemama";

   
}
