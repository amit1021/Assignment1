namespace Assignment
{
    class Address
    {
        public Address(string s, string c)
        {
            Street = s;
            City = c;
        }
        public string Street { get; set; }
        public string City { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Custom comparison based on Name and Age
            Address other = (Address)obj;
            if (other != null)
            {
                return Street.Equals(other.Street) && City.Equals(other.City);
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Street.GetHashCode();
            hash = hash * 23 + City.GetHashCode();
            return hash;

        }
    }
}
