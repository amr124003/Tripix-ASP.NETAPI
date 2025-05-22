using OpenQA.Selenium.BiDi.Modules.Input;

namespace Tripix.Abstractions
{
    public record Error(string code , string Description , int? StatusCode)
    {
        public static readonly Error None = new(string.Empty,string.Empty,default);
    }
}
