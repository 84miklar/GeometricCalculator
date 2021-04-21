namespace TDDInlamning1_MLarsson
{
    using System;
    /// <summary>
    /// Class to hold help methods like NiceRound and NearlyEqual.
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Shortens the amount of decimals to 4.
        /// </summary>
        /// <param name="thing"></param>
        /// <param name="number"></param>
        /// <returns>Rounded float value.</returns>
        public static float NiceRound(this GeometricThing thing, float number)
        {
            return MathF.Round(number, 4);
        }

      
    }
}
