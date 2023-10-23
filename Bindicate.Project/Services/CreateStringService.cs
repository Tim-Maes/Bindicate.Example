using Bindicate.Attributes;

namespace Bindicate.Project.Services;

[AddScoped(typeof(ICreateStringService))]
public class CreateStringService : ICreateStringService
{
    public string CombineStrings(string string1, string string2) => $"{string1}-{string2}";
}

public interface ICreateStringService
{
    string CombineStrings(string string1, string string2);
}
