using System;
using FizzBuzz.Service.Validation.Rules.Interface;

namespace FizzBuzz.Service.Validation.Rules
{
    public class IsExpressionRule<TSource,TDestination> : IRule<TSource,TDestination>
    {
        public TDestination Result { set; get; }
        public bool IsSuccess { get; set; }

        public IsExpressionRule(bool isSuccess, TDestination result)
        {
            Result = result;
            IsSuccess = isSuccess;
        }
    }
}
