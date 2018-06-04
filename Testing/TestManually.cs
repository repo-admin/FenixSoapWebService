using System;

namespace Fenix.WebService.Testing
{
    /// <summary>
    ///     Pomocná třída pro testování - ruční vytvoření testovací XML zprávy
    ///     (testovací XML zpráva je hardcoded)
    /// </summary>
    public class TestManually
    {
        /// <summary>
        /// Vrací testovaci xml řetězec
        /// </summary>
        /// <returns></returns>
        public static string GetTest()
        {
            return $@"<TestXML><obsah>Nazdar {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}</obsah></TestXML>";
        }
    }
}