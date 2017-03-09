namespace FizzBuzz.Service.Validation.Rules.Interface
{
    public interface IRule<TSource,TDestination>
    {
        TDestination Result { set; get; }
        bool IsSuccess { get; set; }
    }
}
