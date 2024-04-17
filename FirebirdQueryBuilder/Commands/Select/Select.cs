using System.Collections.Generic;

namespace FirebirdQueryBuilder.Commands.Select
{
    public class Select
    {
        public static Builder New = new Builder();

        public string Table;
        public string Alias;
        public List<string> Columns;

        public class Builder : SelectColumnBuilder<Builder>
        {
            internal Builder() { }
        }
    }

    public abstract class SelectBuilder
    {
        protected Select Select;

        public SelectBuilder()
        {
            Select = new Select();
            Select.Columns = new List<string>();
        }

        public static implicit operator Select(SelectBuilder sb)
            => sb.Select;
    }

    public class SelectTableBuilder<T> : SelectBuilder
        where T : SelectTableBuilder<T>
    {
        public T Table(string table)
        {
            Select.Table = table;

            return (T)this;
        }
    }

    public class SelectAliasBuilder<T> : SelectTableBuilder<T>
        where T : SelectAliasBuilder<T>
    {
        public T Alias(string alias)
        {
            Select.Alias = alias;

            return (T)this;
        }
    }

    public class SelectColumnBuilder<T> : SelectAliasBuilder<T>
        where T : SelectColumnBuilder<T>
    {
        public T Column(string column)
        {
            Select.Columns.Add(column);

            return (T)this;
        }
    }
}
