using System;
using FizzBuzz.Service.Validation.Rules.Interface;

namespace FizzBuzz.Service.Validation.Rules
{
    public class IsFizzBuzz<TSource,TDestination> : IRule<TSource,TDestination>
    {
        public TDestination Result { set; get; }
        public bool IsSuccess { get; set; }

        public IsFizzBuzz(TSource source, TDestination destination)
        {
            
        }
    }
}
