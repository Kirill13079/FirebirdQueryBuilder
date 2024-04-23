using System;
using FirebirdQueryBuilder.Commands.Select;
using FirebirdQueryBuilder.Commands.Select.Table;
using FirebirdQueryBuilder.Identifiers;

namespace FirebirdQueryBuilder.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table("users");

            SelectBuilder sb = new SelectBuilder()
                .FromTable(table)
                .As("u")
                .Columns(
                (column) => {
                    column.Use("login");
                }, 
                (column) => {
                    column.Use("pass");
                });

            var textSql = sb.Build();

            Console.WriteLine(textSql);
        }
    }
}
