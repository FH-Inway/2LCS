using LCS.Model;

namespace LCS
{
    public static class LcsContext
    {
        public static Dictionary<string, LcsGeo> LcsGeos { get; set; }
        public static LcsGeo CurrentLcsGeo { get; set; }
    }
}
