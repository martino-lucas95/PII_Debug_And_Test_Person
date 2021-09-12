using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            this.person = new Person("John Doe", "1.234.567-8");
        }

        [Test]
        public void NameNotNullOrEmpty()
        {
            //Not Null
            Assert.IsNotNull(person.Name);
            //Not Empty   
            person.Name= "";
            Assert.IsNotEmpty(person.Name);         
        }

        [Test]
        public void ChangeName() 
        {
            person.Name = "Lucas";
            Assert.AreEqual("Lucas", person.Name);
        }

        [Test]
        public void IDNotEmpty() 
        {
            person.ID = "";
            Assert.IsNotEmpty(person.ID);
        }

        [Test]
        public void CorrectLastIDDigit()
        {   
            person.ID = "46587618";
            Assert.IsTrue(IdUtils.IdIsValid(person.ID));
            
        }

    }
}