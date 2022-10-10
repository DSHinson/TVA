using System.Data;
using System.Data.Common;
using Dapper;
using Moq;
using Moq.Dapper;
using TVA.DAL.Commands.Implementation;
using TVA.DAL.Model.dbo;
using TVA.DAL.Repository.Implementation;
using TVA.DAL.Repository.Interface;

namespace TVA.test
{
    [TestClass]
    public class PersonRepositoryTest
    {
        private readonly IPersonRepository _personRepository;
        public PersonRepositoryTest()
        {
          var  moqConnection =new Mock<DbConnection>();

            Person testPer = new Person();
            var expected = new List<Person>
            {
                testPer
            };

            moqConnection.SetupDapperAsync(c => c.QueryAsync<Person>(It.IsAny<string>(), null, null, null, null))
                .ReturnsAsync(expected);
            _personRepository =
                new PersonRepository(moqConnection.Object, new SqlPersistCommands(), new SqlQueryCommands());
        }

        [TestMethod]
        public void GetPersonsTest()
        {
            var testOutput = _personRepository.GetPersonWithPagination(1,10).ToList();
            Assert.IsTrue( testOutput.Count > 0);
        }
    }
}