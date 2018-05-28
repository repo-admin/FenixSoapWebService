using System;
using System.Text;
using Fenix.Extensions;
using Fenix.Xml;

namespace Fenix.WebService.Processing
{
	/// <summary>
	/// Třída pro zpracování testu  
	/// </summary>
	public class TestProcessing
	{
		/// <summary>
		/// Zpracování testu (zápis do tabulky AppLogNew)
		/// </summary>
		/// <param name="authToken"></param>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <param name="partnerCode"></param>
		/// <param name="messageType"></param>
		/// <param name="data"></param>
		/// <param name="encoding"></param>
		/// <returns></returns>
		public static SubmitDataToProcessingResult Process(AuthToken authToken, string login, string password, string partnerCode, string messageType, byte[] data, string encoding)
		{
			SubmitDataToProcessingResult result = new SubmitDataToProcessingResult();

			try
			{
				string xmlStringFromData = data.ToString(Encoding.GetEncoding(encoding), Encoding.Unicode);
				string modifiedXmlString = XmlCreator.CreateXMLRootNode(xmlStringFromData);

				if (authToken != null)
				{
					return ProjectHelper.AppLogWrite(authToken, "XML",
													 ProjectHelper.CreateAppLogMessage(partnerCode, messageType, "modified XML"), "", 
													 modifiedXmlString, BC.ZICYZ_USER_ID, ApplicationLog.GetMethodName());
				}
			}
			catch (Exception ex)
			{
				ProjectHelper.CreateErrorResult(ApplicationLog.GetMethodName(), ref result, "100", ex);
			}

			return result;
		}
	}
}