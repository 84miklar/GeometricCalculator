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

        /// <summary>
        /// Help method to set expected to actual if they are within 0.0001 of each other.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="actual"></param>
        /// <returns>MathAbs(expected-actual) less then 0.0001</returns>
        public static bool NearlyEqual(float actual, float expected)
        {
            return Math.Abs(actual - expected) < 0.0001;
            // Källa: https://csharp.2000things.com/2011/09/21/416-use-an-epsilon-to-compare-two-floating-point-numbers/
        }
    }
}
