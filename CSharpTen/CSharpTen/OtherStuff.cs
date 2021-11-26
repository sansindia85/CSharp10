

using System.Linq.Expressions;

namespace CSharpTen
{
    internal class Lambdas
    {
        //Lamdas improvements
        public Lambdas()
        {
            //smart but not extra smart
            var parse = (string s) => int.Parse(s);

            //Delegate parse = (string s) => int.Parse(s);
            //object  parse = (string s) => int.Parse(s);
            //Expression parse = (string s) => int.Parse(s);
            LambdaExpression parseType = (string s) => int.Parse(s);

            //Delegate type cannot be interfered            
            //var choose = (bool b) => b ? 1 : "two"
            //Func<bool, object> choose = (bool b) => b ? 1 : "two";

            //Type inference for lambdas and method groups
            var choose = object (bool b) => b ? 1 : "two";
        }
    }
}
