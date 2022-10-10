using TVA.DAL.Commands.Interface;

namespace TVA.DAL.Commands.Implementation
{
    public class OracleQueryCommands : IQueryCommands
    {
        //Bad practice to leave this here but it shows how we can use Liskov substitution principle to support different implementations of an interfaces
        public string GetPersonsWithPagination => throw new NotImplementedException();
    }
}
