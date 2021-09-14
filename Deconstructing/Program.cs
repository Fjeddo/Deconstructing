namespace Deconstructing
{
    class Program
    {
        static void Main(string[] args)
        {
            DeconstructTuples();

            DeconstructResultAsClassesWithClassModel();

            DeconstructResultAsClassesWithRecordModel();

            DeconstructResultAsRecordWithClassModel();

            DeconstructResultAsRecordWithRecordModel();

            DeconstructingSomewhatOdd();
        }

        static void DeconstructTuples()
        {
            var successTuple = (true, new Person(), 0);
            var (isSuccess1, successModel, successStatus) = successTuple;

            var failTuple = (false, default(Person), 123);
            var (isSuccess2, failModel, failStatus) = failTuple;

            // Ignore/discard things
            var (success1, model, _) = (true, new Person(), 0);
            var (success2, _, status) = (false, default(Person), 123);
        }

        static void DeconstructResultAsClassesWithClassModel()
        {
            var successClass = new ResultAsClass<Person>(true, new Person(), 0);
            var (isSuccess1, successModel, successStatuts) = successClass;

            var failClass = new ResultAsClass<Person>(false, default, 123);
            var (isSuccess2, failModel, failStatus) = failClass;

            // Ignore/discard things
            var (success1, model, _) = new ResultAsClass<Person>(true, new Person(), 0);
            var (success2, _, status) = new ResultAsClass<Person>(false, default, 123);
        }

        static void DeconstructResultAsClassesWithRecordModel()
        {
            var successClass = new ResultAsClass<Human>(true, new Human(1, "Test"), 0);
            var (isSuccess1, successModel, successStatuts) = successClass;

            var failClass = new ResultAsClass<Human>(false, default, 123);
            var (isSuccess2, failModel, failStatus) = failClass;

            // Ignore/discard things
            var (success1, model, _) = new ResultAsClass<Human>(true, new Human(1, "Test"), 0);
            var (success2, _, status) = new ResultAsClass<Human>(false, default, 123);
        }

        static void DeconstructResultAsRecordWithClassModel()
        {
            var successRecord = new ResultAsRecord<Person>(true, new(), 0);
            var (isSuccess1, successModel, successStatuts) = successRecord;

            var failRecord = new ResultAsRecord<Person>(false, default, 123);
            var (isSuccess2, failModel, failStatus) = failRecord;

            // Ignore/discard things
            var (success1, model, _) = new ResultAsRecord<Person>(true, new(), 0);
            var (success2, _, status) = new ResultAsRecord<Person>(false, default, 123);
        }

        static void DeconstructResultAsRecordWithRecordModel()
        {
            var successRecord = new ResultAsRecord<Human>(true, new(1, "Test"), 0);
            var (isSuccess1, successModel, successStatuts) = successRecord;

            var failRecord = new ResultAsRecord<Human>(false, default, 123);
            var (isSuccess2, failModel, failStatus) = failRecord;

            // Ignore/discard things
            var (success1, model, _) = new ResultAsRecord<Human>(true, new(1, "Test"), 0);
            var (success2, _, status) = new ResultAsRecord<Human>(false, default, 123);
        }

        static void DeconstructingSomewhatOdd()
        {
            // Deconstructing with DateTimeOffset
            var (isSuccess, at) = new SomeClass();

            // Deconstructing odd use case
            var (min, max, readings) = new SomeClass();
        }
    }
}
