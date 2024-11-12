using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemX.Domain
{
    public enum MappingType
    {
        Float, Clamp, Mirror, Wrap
    }
}

namespace Kairos.Runtime
{
   
    public enum TrackItemType
    {
        ConstantValue, LiveValue, Layer
    }

}

namespace LayerX.PresetEditor
{
    public enum FallbackOption
    {
        Background, Latest
    }
}

