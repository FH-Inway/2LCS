using System.ComponentModel;

namespace LCS.Model
{
    public enum LcsGeoType
    {
        [Description("Global Cloud")]
        GlobalCloud,
        [Description("Local Cloud")]
        LocalCloud,
        [Description("Sovereign Cloud")]
        SovereignCloud
    }

    public class LcsGeo
    {
        public LcsGeoType Type { get; set; }
        public string Name { get; set; }
        public Uri LcsUrl { get; set; }
        public Uri LcsDiagUrl { get; set; }
        public Uri LcsUpdateUrl { get; set; }
        public Uri LcsFixUrl { get; set; }
    }

}
