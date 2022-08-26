namespace OOP003
{
    internal class Person
    {
        //Private felter, der indeholder data/værdier

        private string? name;
        private DateTime? dob;
        private string? email;
        private string? password;

        //Offentlige egenskaber, der henter (returfelt) og sætter (fra værdi) dataværdierne for vores private felter.
        public string? Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Prøv igen...");
                    name = null;
                }
                else name = value;
            }
        }
        public DateTime? DoB
        {
            get { return dob; }
            set
            {
                if (value < DateTime.Now) dob = value;
                else
                {
                    Console.WriteLine("Fødselsdatoen er ikke godkendt, skal være før i dag.");
                    dob = null;
                }
            }
        }
        public string? Email
        {
            get { return email; }
            set
            {
                if (value != null && value.Contains("@") && value.Contains(".")) email = value;
                else Console.WriteLine("Email skal indeholde @ og et .");
            }
        }
        public string? Password
        {
            get { return password; }
            set
            {
                if (value != null && value.Length > 6 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsDigit) && !value.Contains(" ")) password = value;
                else Console.WriteLine("Password skal være længere end 6 karakterer, indeholde både store og små bogstaver samt tal");
            }
        }
        public int Age
        {
            get
            {
                if (DoB != null)
                {
                    DateTime today = DateTime.Today;
                    int age = today.Year - ((DateTime)DoB).Year;
                    if (today < new DateTime(today.Year, ((DateTime)DoB).Month, ((DateTime)DoB).Day)) age--;
                    return age;
                }
                else return 0;

            }
        }


    }
}
