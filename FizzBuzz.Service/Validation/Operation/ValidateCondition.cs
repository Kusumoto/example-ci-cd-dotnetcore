using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FizzBuzz.Service.Validation.Rules.Interface;
using FizzBuzz.Service.Validation.Rules;
using System.Linq;
using FizzBuzz.Service.Validation.Operation.Interface;

namespace FizzBuzz.Service.Validation.Operation
{
    class ValidateCondition<TSource, TDestination> : IValidateCondition<TSource, TDestination>
    {
        private List<IRule<TSource,TDestination>> _rules;

        public ValidateCondition()
        {
            _rules = new List<IRule<TSource,TDestination>>();
        }

        public void AddRule(IRule<TSource,TDestination> rule, TDestination result)
        {
            rule.Result = result;
            _rules.Add(rule);
        }

        public void AddRule(TSource model, Expression<Func<TSource, bool>> action, TDestination result)
        {
            var actionComplie = action.Compile();
            _rules.Add(new IsExpressionRule<TSource,TDestination>(actionComplie(model), result));
        }

        public List<IRule<TSource,TDestination>> GetRules()
        {
            return _rules;
        }

        public TDestination Validate()
        {
            return _rules.FirstOrDefault(x => x.IsSuccess == true).Result;
        }
    }
}
