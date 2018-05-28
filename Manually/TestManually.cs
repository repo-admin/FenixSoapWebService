using System;

namespace Fenix.WebService.Manually
{
	/// <summary>
	/// Pomocná třída pro testování - ruční vytvoření testovací XML zprávy
	/// (testovací XML zpráva je hardcoded)
	/// </summary>
	public class TestManually
	{
		#region Public Methods

		public static string GetTest()
		{
			return testXML();
		}

		#endregion

		#region Private Methods

		private static string testXML()
		{
			string inputXML = String.Format(@"<TestXML>
									             <obsah>Nazdar {0}</obsah>
								              </TestXML>", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));

			return inputXML;
		}

		#endregion
	}
}