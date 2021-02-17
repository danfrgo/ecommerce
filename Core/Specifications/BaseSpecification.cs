using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
            
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria {get;}

        // vai dar uma lista dos includes necessarios
        public List<Expression<Func<T, object>>> Includes {get;} = new List<Expression<Func<T, object>>>();

        // metodo para add include statements à lista de cima
        protected void  AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }




    }
}