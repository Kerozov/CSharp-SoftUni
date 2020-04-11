using System;
using ExtendedDatabase;
using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase database;
        private  Person[] persons;
        [SetUp]
        public void Setup()
        {

            Person person = new Person(23, "Pesho");
            Person person2 = new Person(33, "Gosho");
            persons = new Person[] { person, person2 };
            database = new ExtendedDatabase.ExtendedDatabase(persons);
        }
        
        [Test]
        public void PersonConstructorWorkCorrectly()
        {
            string name = "Pesho";
            long id = 1233223;
            var person = new Person(id,name);
            Assert.AreEqual(person.Id,id);
            Assert.AreEqual(person.UserName,name);
        }

        [Test]
        public void DatbaseConstructorWorkCorrectly()
        {
             Person  person = new Person(23,"Pesho");
             Person  person2 = new Person(33,"Gosho");

            persons = new Person[]{person,person2};
            database = new ExtendedDatabase.ExtendedDatabase(persons);
            int  expectedCount = 2;
           int actualCount = database.Count;
            Assert.AreEqual(expectedCount,actualCount);
        }

      
        [Test]
        public void AddRangeMethodThrowException()
        {
            persons = new Person[17];
            Assert.That(() =>
            {
                database = new ExtendedDatabase.ExtendedDatabase(persons);
            },Throws.ArgumentException);
        }
        [Test]
        public void Test_Add_Range_Exception()
        {
            Person[] people = new Person[17];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Name{i}");
            }

            Assert.Throws<ArgumentException>(() =>
                this.database = new ExtendedDatabase.ExtendedDatabase(people));
        }
        [Test]
        public void AddMethodThrowException()
        {
            persons = new Person[15];
            for (int i = 1; i < persons.Length; i++)
            {
                persons[i] = new Person(i+1,$"{i+1}nqkywSITam");
                database.Add(persons[i]);
            }
            Assert.That(() =>
            {
                database.Add(new Person(1,"Wert"));
            }, Throws.InvalidOperationException);
        }

        [Test]
        public void AddMethodWorkCorrectly()
        {
            database.Add(new Person(44,"awds"));
            int expectedCount = 3;
            Assert.AreEqual(expectedCount,database.Count);
        }

        [Test]
        public void Test_Add_Person_With_Existing_Username()
        {
            Person person = new Person(104, "Pesho");

            Assert.Throws<InvalidOperationException>(() => this.database.Add(person));
        }
        [Test]
        public void AddMethodThrowExceptionWithUser()
        {
            Assert.That(() =>
            {
                database.Add(new Person(33,"Pesho"));
            },Throws.InvalidOperationException);
        }
        [Test]
        public void Test_Add_Null_People()
        {
            Person[] people = new Person[5];

            Assert.Throws<NullReferenceException>(() =>
                this.database = new ExtendedDatabase.ExtendedDatabase(people));
        }
        [Test]
        public void AddMethodThrowExceptionWithId()
        {
            Assert.That(() =>
            {
                database.Add(new Person(23, "Nqkyw"));
            }, Throws.InvalidOperationException);
        }

        [Test]
        public void RemoveMethodIsWorkTrue()
        {
            var expectedCount = 1;
            database.Remove();
            var actualCount = database.Count;
            Assert.AreEqual(expectedCount,actualCount);
        }

        [Test]
        public void RemoveMethodThrowExeptionIfCountIsZero()
        {
            database.Remove();
            database.Remove();

            Assert.That(() =>
            {
                database.Remove();
            }, Throws.InvalidOperationException);
        }

        [Test]
        public void FindByUsernameIsWorkCorrectly()
        {
            string nameForSearch = "Pesho";
            Person founfPerson = database.FindByUsername(nameForSearch);
            Assert.AreEqual(nameForSearch,founfPerson.UserName);
        }

        [Test]
        public void FindByUsernameThrowExeptionWithNullReference()
        {
            string nameForSearch = null;
            Assert.That(() =>
            { 
                database.FindByUsername(nameForSearch);
            },Throws.ArgumentNullException);
        }

        [Test]
        public void FindByUsernameThrowExeptionWhenNameIsNotFound()
        {
            string nameForSearch = "sdvkso";
            Assert.That(() =>
            {
                database.FindByUsername(nameForSearch);
            }, Throws.InvalidOperationException);
        }

        [Test]
        public void FindByIdMethodWorkCorrectly()
        {
            int idForSearch = 23;
            Person founfPerson = database.FindById(idForSearch);
            Assert.AreEqual(idForSearch, founfPerson.Id);
        }
        [Test]
        public void FindByIdThrowExeptionWithNullReference()
        {
            int idForSearch = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                database.FindById(idForSearch);
            });
        }

        [Test]
        public void FindByIdThrowExeptionWhenIdIsNotFound()
        {
            int idForSearch = 44;
            Assert.That(() =>
            {
                database.FindById(idForSearch);
            }, Throws.InvalidOperationException);
        }
    }
}