using FizzBuzz.Service.Validation.Rules.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FizzBuzz.Service.Validation.Operation.Interface
{
    public interface IValidateCondition<TSource, TDestination>
    {
        void AddRule(IRule<TSource,TDestination> rule, TDestination result);
        void AddRule(TSource model, Expression<Func<TSource, bool>> action, TDestination result);
        List<IRule<TSource,TDestination>> GetRules();
        TDestination Validate();
    }
}
