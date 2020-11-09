using Strategy.Normalizer;

namespace Strategy
{

    public class ProcessorClass
    {
        private string _stringToProcess;
        private INormalizerStrategy _normalizer; // ProcessorClass HAS A nomalizer

        public ProcessorClass(string s) => _stringToProcess = s;

        public void SetNormalizer(INormalizerStrategy normalizer) => _normalizer = normalizer;

        public string ReturnNormalizeString()
        {
            if(_normalizer == null)
                return string.Empty;                
            return _normalizer.Normalize(_stringToProcess);
        }
    }
}