namespace Ex047.Entities
{
    internal class Course
    {
        public string Name { get; set; }
        public HashSet<int> Students { get; set; }

        public Course(string name)
        {
            Name = name;
            Students = new HashSet<int>();  // try without this statement
        }
    }
}
