namespace ClassLib
{
    public abstract class Werknemer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Type { get; set; }


        protected Werknemer(string firstName, string lastName, char type)
        {
            this.FirstName = firstName;
            this.LastName = lastName;   
            this.Type = type;   
        }

        public abstract decimal Salary();
      

        public abstract string Info();

       
       
    }
}
