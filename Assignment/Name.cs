
namespace Assignment
{
    class Name
    {
        public Name(string f, string l)
        {
            FirstName = f;
            LastName = l;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Name other = (Name)obj;
            if (other != null)
            {
                return FirstName.Equals(other.FirstName) && LastName.Equals(other.LastName);
            }
            return false;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + FirstName.GetHashCode();
            hash = hash * 23 + LastName.GetHashCode();
            return hash;

        }
    }
}
