using NUnit.Framework;
using Database;
namespace Tests
{
    public class DatabaseTests
    {
        private Database.Database database;
        private  int[] data  =new []{1,2,3};

        
        [Test]
        public void TesrIfConstructorsWorksCorrectly()
        {
            data = new[] { 1, 2, 3 };
            database = new Database.Database(data);
            int expectedCount = 3;
            int count = database.Count;
            Assert.That(count,Is.EqualTo(expectedCount));
        }

        [Test]
        public void ConstructorThrowExcptionWithBiggerCollection()
        {
            this.data = new int[] { 1, 2, 3 ,4,5,6,7,8,9,11,12,13,14,15,16,17,18};
            Assert.That(() =>
            {
                database = new Database.Database(data);
            }, Throws.InvalidOperationException);
        }

        [Test]
        public void AddMethodThrowExceptionWithFullCollection()
        {
            database = new Database.Database(data);
            for (int i = 3; i <= 15; i++)
            {
                database.Add(i);
            }
            Assert.That(() =>
            {
                database.Add(16);
            },Throws.InvalidOperationException);
        }

        [Test]
        public void RemoveCorrectly()
        {
            data = new int[]{1,2,3,4,5,6,7,8,9};
            database = new Database.Database(this.data);
            database.Remove();
            int expectedCount = 8;
            int actualCount = database.Count;
            Assert.AreEqual(expectedCount,actualCount);
        }

        [Test]
        public void RemoveMethodThrowExceprion()
        {
            data = new int[0];
            database = new Database.Database(this.data);
            Assert.That(() =>
            {
                database.Remove();
            }, Throws.InvalidOperationException);
        }

        [Test]
        public void FetchMethodWorkCorrectly()
        {
            data = new int[]{1,2,3};
            database = new Database.Database(data);
            int[] copiedArray = database.Fetch();
            CollectionAssert.AreEqual(copiedArray, data);
        }
    }
}