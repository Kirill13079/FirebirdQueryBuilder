using System.Reflection;

namespace FirebirdQueryBuilder.Identifiers
{
    public class Function
    {
        public string Name { get; set; }

        public class StringBuilder 
            : FunctionStringBuilder<StringBuilder>
        {
            internal StringBuilder()
            { }
        }

        public class MathematicalBuilder 
            : FunctionMathematicalBuilder<MathematicalBuilder>
        {
            internal MathematicalBuilder()
            { }
        }

        public static StringBuilder String = new StringBuilder();

        public static MathematicalBuilder Mathematical = new MathematicalBuilder();

        public override string ToString()
            => $"{Name}";
    }

    public abstract class FunctionBuilder
    {
        protected Function Function = new Function();

        public static implicit operator Function(FunctionBuilder fb) 
            => fb.Function;
    }

    public class FunctionStringBuilder<T> : FunctionBuilder
        where T : FunctionStringBuilder<T>
    {
        public T ASCII_CHAR(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }
    }

    public class FunctionMathematicalBuilder<T> : FunctionBuilder
        where T : FunctionMathematicalBuilder<T>
    {
        public T ABS(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T ABS(Function function)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({function.Name})";

            return (T)this;
        }

        public T ACOS(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T ACOS(Function function)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({function.Name})";

            return (T)this;
        }

        public T ACOSH(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T ACOSH(Function function)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({function.Name})";

            return (T)this;
        }

        public T ASIN(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T ASIN(Function function)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({function.Name})";

            return (T)this;
        }

        public T ASINH(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T ASINH(Function function)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({function.Name})";

            return (T)this;
        }

        public T ATAN(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T ATAN(Function function)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({function.Name})";

            return (T)this;
        }


        public T ATAN2(string column1, string column2)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column1}, {column2})";

            return (T)this;
        }

        public T ATAN2(Function function)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({function.Name})";

            return (T)this;
        }

        public T CEIL(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T CEILING(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T COS(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T COSH(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T COT(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T EXP(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T FLOOR(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T LN(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T LOG(string column1, string column2)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column1}, {column2})";

            return (T)this;
        }

        public T LOG10(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T MOD(string column1, string column2)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column1}, {column2})";

            return (T)this;
        }

        public T PI(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T POWER(string column1, string column2)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column1}, {column2})";

            return (T)this;
        }

        public T RAND()
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}()";

            return (T)this;
        }

        public T ROUND(string column, int scale)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column}, {scale})";

            return (T)this;
        }

        public T SIGN(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T SIN(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T SINH(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T SQRT(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T TAN(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T TANH(string column)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column})";

            return (T)this;
        }

        public T TRUNC(string column, int scale)
        {
            Function.Name = $"{MethodBase.GetCurrentMethod().Name}({column}, {scale})";

            return (T)this;
        }
    }
}
