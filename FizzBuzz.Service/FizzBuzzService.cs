using FizzBuzz.Service.Validation.Operation;

namespace FizzBuzz.Service
{
    public class FizzBuzzService
    {
        public string GetFizzBuzzResult(int number)
        {
            var validateCondition = new ValidateCondition<int, string>();
            validateCondition.AddRule(number, x => x % 4 == 0, "Fizz Buzz");
            validateCondition.AddRule(number, x => x % 5 == 0, "Buzz");
            validateCondition.AddRule(number, x => x % 3 == 0, "Fizz");
            validateCondition.AddRule(number, x => x == number, number.ToString());
            return validateCondition.Validate();
        }
    }
}
