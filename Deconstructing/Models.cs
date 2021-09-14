using System;
using System.Linq;

namespace Deconstructing
{
    public class ResultAsClass<T>
    {
        private bool IsSuccess { get; }
        private int Status { get; }
        private T Model { get; }

        public ResultAsClass(bool isSuccess, T model, int status)
        {
            IsSuccess = isSuccess;
            Model = model;
            Status = status;
        }

        public ResultAsClass() { }

        public void Deconstruct(out bool success, out T model, out int status)
        {
            success = IsSuccess;
            model = Model;
            status = Status;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public record Human(int Id, string Name);

    public record ResultAsRecord<T>(bool Success, T Model, int Status);

    public class SomeClass
    {
        public SomeClass() { }

        public void Deconstruct(out bool ticksIsEven, out DateTimeOffset at)
        {
            var  utcNow = DateTimeOffset.UtcNow;

            ticksIsEven = utcNow.Ticks % 2 == 0;
            at = utcNow;
        }

        public void Deconstruct(out int min, out int max, out int[] readings)
        {
            var random = new Random((int)DateTimeOffset.UtcNow.Ticks);

            readings = Enumerable.Range(1, 100).Select(x => random.Next(-100, 100)).ToArray();
            min = readings.Min();
            max = readings.Max();
        }
    }
}
