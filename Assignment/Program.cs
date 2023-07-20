
namespace Assignment
{
    static class  Program
    {
        public static Graph graph { get; set; } = new Graph();
         static void init(Person[] people)
        {
            foreach (Person person in people)
            {
                // add new person
                graph.AddVertex(person);
               
                //add connection
                for (int i = 0; i < graph.Neighbors.Count; i++)
                {
                    if (people[i] == person) continue;

                    if(people[i].Address.Equals(person.Address))
                    {
                        graph.AddEdge(people[i], person);
                    }
                    if (people[i].FullName.Equals(person.FullName))
                    {
                        graph.AddEdge(people[i], person);
                    }

                }
            }


        }

       static int FindMinRelationLevel(Person personA, Person personB)
        {
            return graph.BFS(personA, personB);
        }

        public static void Main(string[] args)
        {
        }

    }
}