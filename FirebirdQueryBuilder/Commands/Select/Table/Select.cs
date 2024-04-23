using FirebirdQueryBuilder.Identifiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdQueryBuilder.Commands.Select.Table
{
    public class Table
    {
        public string Name { get; set; } = "RDB$DATABASE";

        public string Alias { get; set; } = "DB";

        public Table(string name)
        {
            Name = name;
        }

        public override string ToString()
            => $"{Name} {Alias}";
    }

    public class Column
    {
        public Table Table { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; } = "";

        public Function Function { get; set; }

        public override string ToString()
        {
            StringBuilder @string = new StringBuilder();

            if (Function != null)
            {
                @string.Append($"{Function.ToString().Replace(Name, $"{Table.Alias}.{Name}")}");
            }
            else
            {
                @string.Append($"{Table.Alias}.{Name}");
            }

            if (Alias != "")
                @string.Append($" as {Alias}");

            return @string.ToString();
        }
    }

    public class Select
    {
        public Table Table { get; set; }

        public List<Column> Columns { get; set; } = new List<Column>();

        public override string ToString()
        {
            StringBuilder sqlText = new StringBuilder();

            sqlText.Append("SELECT ");

            if (Columns.Count == 0)
            {
                sqlText.Append($"{Table.Alias}.* ");
            }
            else
            {
                for (int columnIndex = 0; columnIndex < Columns.Count; columnIndex++)
                {
                    if (columnIndex < Columns.Count - 1)
                        sqlText.Append($"{Columns[columnIndex]}, ");
                    else
                        sqlText.AppendLine($"{Columns[columnIndex]}");
                }
            }

            sqlText.Append($"FROM {Table}");

            return sqlText.ToString();
        }
    }

    public sealed class ColumnBuilder
    {
        private readonly Column _column;

        public ColumnBuilder(Column column)
        {
            _column = column;
        }

        public ColumnBuilder Use(string name)
        {
            _column.Name = name;

            return this;
        }

        public ColumnBuilder Func(Function function)
        {
            if (!function.Name.Contains(_column.Name))
                throw new ArgumentException();

            _column.Function = function;

            return this;
        }

        public ColumnBuilder As(string alias = "")
        {
            _column.Alias = alias;

            return this;
        }
    }

    public sealed class SelectBuilder : Builder<Select, SelectBuilder>
    {
        public SelectBuilder FromTable(Table table) => Do(s => s.Table = table);

        public SelectBuilder As(string alias) => Do(s => s.Table.Alias = alias);

        public SelectBuilder Columns(params Action<ColumnBuilder>[] columnBuilder)
        {
            foreach (var test in columnBuilder)
            {
                Column column = new Column();

                test(new ColumnBuilder(column));

                Do(s =>
                {
                    column.Table = s.Table;
                    s.Columns.Add(column);
                });
            }

            return this;
        }
    }
}
