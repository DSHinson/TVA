namespace TVA.DAL.Commands.Interface
{
    public interface IPersistCommands
    {
        /// <summary>
        /// Pass in the  ID of the user to be Deleted
        /// </summary>
        public string UpdateMarkAPersonAsDeleted { get; }
    }
}
