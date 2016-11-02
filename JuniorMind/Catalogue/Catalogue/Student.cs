namespace Catalogue
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearOfStudy { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}, Year: {2}", FirstName, LastName, YearOfStudy.ToString());
        }
    }
}