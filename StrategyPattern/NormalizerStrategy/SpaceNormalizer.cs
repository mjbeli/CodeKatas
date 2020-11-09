namespace Strategy.Normalizer
{
    public class SpaceNormalizer : INormalizerStrategy
    {
        public string Normalize(string s) => s.Replace(" ", string.Empty);        
    }
}