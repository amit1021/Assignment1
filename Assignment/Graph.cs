
namespace Assignment
{
    class Graph
    {
        public Dictionary<Person, List<Person>> Neighbors { get; set; }

        public Graph()
        {
            Neighbors = new Dictionary<Person, List<Person>>();
        }

        public void AddVertex(Person vertex)
        {
            if (!Neighbors.ContainsKey(vertex))
            {
                Neighbors[vertex] = new List<Person>();
            }
        }

        public void AddEdge(Person source, Person destination)
        {
            if (!Neighbors.ContainsKey(source))
            {
                AddVertex(source);
            }

            if (!Neighbors.ContainsKey(destination))
            {
                AddVertex(destination);
            }

            Neighbors[source].Add(destination);
            Neighbors[destination].Add(source);

        }

        public int BFS(Person source, Person dest)
        {
            Queue<Person> queue = new Queue<Person>();
            HashSet<Person> visited = new HashSet<Person>();
            Dictionary<Person, Person> previousPerson = new Dictionary<Person, Person>();

            var level = 0;

            queue.Enqueue(source);
            visited.Add(source);

            while (queue.Count > 0)
            {
                var currentPerson = queue.Dequeue();

                if (currentPerson.Equals(dest))
                {
                    break;
                }

                foreach (var neighbor in Neighbors[currentPerson])
                {
                    if (!visited.Contains(neighbor))
                    {

                        previousPerson[neighbor] = currentPerson;
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

      

            List<Person> shortestPath = new List<Person>();
            Person current = dest;

            while (!current.Equals(source))
            {               
                shortestPath.Insert(0, current);
                current = previousPerson[current];
            }
            shortestPath.Insert(0, source);

            if (shortestPath.Count == 0)
                return -1;

            return shortestPath.Count -1;
        }
    }
}
