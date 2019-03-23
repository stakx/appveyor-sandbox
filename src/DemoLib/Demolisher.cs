using System;

namespace DemoLib
{
    /// <summary>
    ///   Provides a useful extension method for demolishing stringss.
    /// </summary>
    public static class Demolisher
    {
        /// <summary>
        ///   Demolishes this string.
        /// </summary>
        /// <param name="str">The string that should be demolished.</param>
        /// <returns>A demolished version of this string.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="str"/> is <see langword="null"/>.</exception>
        public static string Demolish(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Length > 0 ? str.Substring(0, str.Length - 1)
                                  : str;
        }
    }
}
