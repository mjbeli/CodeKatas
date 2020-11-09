using Xunit;
using Strategy.Normalizer;

namespace Strategy
{
    public class StrategyTest
    {
        private ProcessorClass _processor;

        public StrategyTest() => _processor = new ProcessorClass("hello world!");

        [Fact]
        public void NormalizeWithAllCapital()
        {
            _processor.SetNormalizer(new CaseNormalizer());
            Assert.Equal("HELLO WORLD!", _processor.ReturnNormalizeString());
        }

        [Fact]
        public void NormalizeRemoveSpaces()
        {
            _processor.SetNormalizer(new SpaceNormalizer());
            Assert.Equal("helloworld!", _processor.ReturnNormalizeString());
        }
    }
}
