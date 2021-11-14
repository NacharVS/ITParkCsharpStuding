using MongoDB.Driver;

namespace ITParkStuding
{
    class MongoExamples
    {
        public MongoExamples(string name, string surname, string vacancy, int age, int driverCard)
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

        public static void AddToDataBase(MongoExamples person)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ITPark");
            var collection = database.GetCollection<MongoExamples>("Persons");
            collection.InsertOne(person);

        }
    }
}
