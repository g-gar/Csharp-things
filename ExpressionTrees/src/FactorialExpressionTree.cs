using System;
using System.Linq;
using System.Linq.Expressions;

namespace ExpressionTrees{
    public class FactorialExpressionTree{

        private readonly ParameterExpression _parameter;
        private readonly BlockExpression _expression;

        public FactorialExpressionTree()
        {
            ParameterExpression result;
            LabelTarget label = Expression.Label(typeof(int));
            _parameter = Expression.Parameter(typeof(int), "parameter");
            result = Expression.Parameter(typeof(int), "result");
            _expression = Expression.Block(
                new[] {result},
                Expression.Assign(result ,Expression.Constant(1)),
                Expression.Loop(Expression.IfThenElse(
                    Expression.GreaterThan(_parameter ,Expression.Constant(1)),
                    Expression.MultiplyAssign(result, Expression.PostDecrementAssign(_parameter)),
                    Expression.Break(label, result)
                ), label)
            );
        }

        public int execute(int n)
        {
            return Expression.Lambda<Func<int, int>>(_expression, _parameter).Compile()(n);
        }
    }
}