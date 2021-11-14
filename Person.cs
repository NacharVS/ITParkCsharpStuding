using MongoDB.Driver;

namespace ITParkStuding
{
    class Person
    {
        public Person(string name, string surname, string vacancy, int age, int driverCard)
        {
            this.name = name;
            this.surname = surname;
            this.vacancy = vacancy;
            this.age = age;
            this.driverCard = driverCard;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public string vacancy { get; set; }
        public int age { get; set; }
        public int driverCard { get; set; }

        public static void AddToDataBase(Person person)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ITPark");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(person);

        }
    }
}
