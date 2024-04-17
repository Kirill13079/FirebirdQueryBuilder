using System;
using FirebirdQueryBuilder.Commands.Select;

namespace FirebirdQueryBuilder.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Select select1 = Select.New
                .Table("users")
                .Alias("a")
                .Column("login")
                .Column("password");

            Console.WriteLine(select1.ToString());
        }
    }
}
