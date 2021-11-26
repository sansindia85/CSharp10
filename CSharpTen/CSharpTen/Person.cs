// See https://aka.ms/new-console-template for more information

namespace Model
{
    struct Person
    {
        //public Person()
        //{
        //    FirstName = "Sundar";
        //    LastName = "Pichai";
        //}


        //Field and property analyzers
        public string FirstName { get; set; } = "Sundar";
        public string LastName { get; set; } = "Pichai";

        public void WriteToFile(string filePath)
            => File.WriteAllText(filePath, ToString());
    }
}