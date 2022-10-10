namespace TVA.DAL.Commands.Interface
{
    public interface IQueryCommands
    {
        /// <summary>
        /// Gets records from the persons table, pass in the page(0 based index) and page size
        /// </summary>
        public string GetPersonsWithPagination { get; }
    }
}
