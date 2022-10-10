using TVA.DAL.Commands.Interface;

namespace TVA.DAL.Commands.Implementation
{
    public class SqlPersistCommands:IPersistCommands
    {
        /// <inheritdoc cref="IPersistCommands.UpdateMarkAPersonAsDeleted"/>
        public string UpdateMarkAPersonAsDeleted => @" UPDATE [dbo].[Persons]
                                                        SET [DeletedDate] = GETDATE()
                                                        WHERE [code] = @code";
    }
}
