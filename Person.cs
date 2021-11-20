using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;

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

        public Person(string name, string surname, string vacancy, int age)
        {
            this.name = name;
            this.surname = surname;
            this.vacancy = vacancy;
            this.age = age;
        }

        public Person(string name, string surname, int age, int driverCard)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.driverCard = driverCard;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        public string surname { get; set; }
        [BsonIgnoreIfNull]
        public string vacancy { get; set; }
        public int age { get; set; }
        [BsonIgnoreIfDefault]
        public int driverCard { get; set; }

        public double balance { get; set; }

        public static double taxRate { get; set; }

        public void ShowDeposit(int mouth)
        {

        }

        public void Deposit(double summ)
        {

        }

        public void Widthraw(double summ)
        {

        }
        public static void AddToDataBase(Person person)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ITPark");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(person);
        }

        public static void GetFromDataBase(string searchName, string searchSurname)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ITPark");
            var collection = database.GetCollection<Person>("Persons");
            Person persons = collection.Find(filter => filter.name == searchName && filter.surname == searchSurname).FirstOrDefault();
            if (persons == null)
                System.Console.WriteLine("no");
            else
                System.Console.WriteLine($"{persons.name} {persons.surname} {persons.vacancy} {persons.age}");

        }

        public static void ReplaceDocument(Person replaceDoc, string name)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ITPark");
            var collection = database.GetCollection<Person>("Persons");
            collection.ReplaceOne(filter => filter.name == name, replaceDoc);

        }
    }
}
