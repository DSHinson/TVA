using TVA.DAL.Commands.Interface;

namespace TVA.DAL.Commands.Implementation
{
    public class SqlQueryCommands : IQueryCommands
    {
        /// <inheritdoc cref="IQueryCommands.GetPersonsWithPagination"/>
        public string GetPersonsWithPagination => @"DECLARE @Predicate NVARCHAR(150) = @SearchTerm

                                                                                SELECT 
                                                                                   p.[code]
                                                                                 , p.[name]
                                                                                 , p.[surname]
                                                                                 , p.[id_number]
                                                                                 , a.account_number
                                                                                FROM [dbo].[Persons] AS p
                                                                                LEFT JOIN [dbo].[Accounts] AS a ON p.code = a.person_code 
                                                                                WHERE (p.surname = ISNULL(@Predicate,p.surname)) OR (p.id_number = ISNUll(@Predicate,p.id_number)) OR (a.account_number = ISNUll(@Predicate,a.account_number))
      
                                                                                ORDER BY Code
                                                                                OFFSET     (@Page* @PageSize) ROWS
                                                                                FETCH NEXT @PageSize ROWS ONLY;  ";
    }
}
