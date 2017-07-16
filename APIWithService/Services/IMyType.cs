using System;
namespace APIWithService.Services
{
    public interface IMyType
    {
        string Value { get; set; }


    }

    public class MyType : IMyType
    {
        private string _value = String.Empty;

        public string Value { get => _value; set => _value = value; }
    }
}
