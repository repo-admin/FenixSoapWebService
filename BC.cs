using System.Diagnostics.CodeAnalysis;

namespace Fenix.WebService
{
    /// <summary>
    /// Aplikační konstanty
    /// </summary>
	[SuppressMessage("ReSharper", "InconsistentNaming")]
    internal class BC
	{
		internal const string APP_NAMESPACE = "https://fenix.upc.cz";

		/// <summary>
		/// Zicyz ID
		/// <value>99999</value>
		/// </summary>
		internal const int ZICYZ_USER_ID = 99999;

		/// <summary>
		/// OK
		/// <value>0</value>
		/// </summary>
		internal const long OK = 0L;

		/// <summary>
		/// Not OK
		/// <value>1</value>
		/// </summary>
		internal const long NOT_OK = OK + 1;

	}
}