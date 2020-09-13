using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Util
{
    public class UtilScale
    {
        public static float Ascale(float value)
        {
            return Constants.MIN_SIZE_SPHERE + (value * (Constants.MAX_SIZE_SPHERE - Constants.MIN_SIZE_SPHERE)) / Constants.MAX_VALUE_POPULATION;
        }

        public static float Xscale(float value)
        {
            return (value * Constants.MAX_SIZE_AXE_X) / Constants.MAX_VALUE_LIFE_EXPECTANCE;
        }

        public static float Yscale(float value)
        {
            return (value * Constants.MAX_SIZE_AXE_Y) / Constants.MAX_VALUE_INFANT_MORTALITY_RATE;
        }
    }

}
