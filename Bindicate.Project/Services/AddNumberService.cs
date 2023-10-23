using Bindicate.Attributes;

namespace Bindicate.Project.Services;

[AddTransient(typeof(IAddNumberService))]
public class AddNumberService : IAddNumberService
{
    public int AddNumber(int number1, int number2) => number1 + number2;
}

public interface IAddNumberService
{
    int AddNumber(int number1, int number2);
}
