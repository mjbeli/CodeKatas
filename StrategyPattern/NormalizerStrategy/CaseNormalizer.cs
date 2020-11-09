namespace Strategy.Normalizer
{
    public class CaseNormalizer : INormalizerStrategy
    {
        public string Normalize(string s) => s.ToUpper();        
    }
}