
namespace Classes
{
    class User
    {
        public User(string f, string l)
        {
            FirstName = f;
            LastName = l;
        }

        // using properties to get and set
        public string FirstName { get; set; } 
        public string LastName { get; set; }

        // overridden from object
        public override bool Equals(object obj) => this == (User)obj;
        public override int GetHashCode() => FirstName.GetHashCode() ^ LastName.GetHashCode() % 31;
        public override string ToString() => FirstName + " " + LastName;

        //operator overloading
        public static bool operator ==(User a, User b) => a.FirstName.Equals(b.FirstName) && a.LastName.Equals(b.LastName); 
        public static bool operator !=(User a, User b) => !(a.FirstName.Equals(b.FirstName) && a.LastName.Equals(b.LastName));

    }
}
