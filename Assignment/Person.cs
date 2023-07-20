
namespace Assignment
{
    class Person
    {
        public Person(Name name, Address address)
        {
            FullName = name;
            Address = address;
        }
        public Name FullName { get; set; }
        public Address Address { get; set; }

    }
}
