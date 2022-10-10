using TVA.DAL.Model.dto;

namespace TVA.DAL.Repository.Interface
{
    public interface IPersonRepository
    {
        public List<PersonGridViewdto> GetPersonWithPagination(int page, int pageSize, string? search = null);

        public void MarkPersonAsDeleted(int personCode);
    }
}
