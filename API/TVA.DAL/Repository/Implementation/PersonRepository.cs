using Dapper;
using System.Data;
using TVA.DAL.Commands.Interface;
using TVA.DAL.Model.dto;
using TVA.DAL.Repository.Interface;

namespace TVA.DAL.Repository.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDbConnection _dbConnection;
        private readonly IQueryCommands _query;
        private readonly IPersistCommands _persist;

        public PersonRepository(IDbConnection dbConnection, IPersistCommands persist,IQueryCommands query)
        {
            _dbConnection = dbConnection ?? throw new ArgumentException(nameof(dbConnection));
            _persist = persist ?? throw new ArgumentNullException(nameof(persist));
            _query = query ?? throw new ArgumentNullException(nameof(query));
        }
        public List<PersonGridViewdto> GetPersonWithPagination(int page, int pageSize, string? search = null)
        {
           return _dbConnection.Query<PersonGridViewdto>(_query.GetPersonsWithPagination, new {
               Page = page,
               PageSize = pageSize,
               SearchTerm = search
           }).ToList();
        }

        public void MarkPersonAsDeleted(int personCode)
        {
            _dbConnection.Execute(_persist.UpdateMarkAPersonAsDeleted, new { code = personCode });
        }
    }
}
