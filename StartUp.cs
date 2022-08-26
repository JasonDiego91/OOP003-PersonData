namespace OOP003
{
    internal class StartUp
    {
        public List<Person> People = new();
        public StartUp()
        {
            while (true)
            {
                //CreatePerson-metoden opretter et nyt Person-objekt, fylder det med data og returnerer det til p
                Person p = CreatePerson();
                //p is added to our people list
                People.Add(p);
                //og vi viser navnet på alle personer på listen
                foreach (Person person in People)
                {
                    Console.WriteLine($"Name: {person.Name}");
                }
            }
        }

        private Person CreatePerson()
        {
            //Opretter en ny instance af et Person-objekt.
            Person person = new();
            //Vi får input via vores metoder, der tilføjer værdier til vores Persons private felter, gennem Persons egenskaber.
            GetName(person);
            Console.WriteLine("Hi " + person.Name);
            GetDoB(person);
            Console.WriteLine($"Du er født: {person.DoB} og er {person.Age} år gammel.");
            GetEmail(person);
            Console.WriteLine("Din email er: " + person.Email);
            GetPassword(person);
            Console.WriteLine("Dit password er: " + person.Password);
            return person;
        }

        private void GetName(Person person)
        {
            do
            {
                Console.Write("Indtast navn: ");
                person.Name = Console.ReadLine();
            }
            while (person.Name == null);
        }
        private void GetDoB(Person person)
        {
            do
            {
                Console.Write("Indtast fødselsdato (dd/mm/åååå: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                else person.DoB = null;
            }
            while (person.DoB == null);
        }
        private void GetEmail(Person person)
        {
            do
            {
                Console.Write("Indtast email: ");
                person.Email = Console.ReadLine();
            }
            while (person.Email == null);
        }
        private void GetPassword(Person person)
        {
            do
            {
                Console.Write("Indtast password: ");
                person.Password = Console.ReadLine();
            }
            while (person.Password == null);
        }
    }
}
