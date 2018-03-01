using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using AuthService;
using FenixHelper;
using FenixSoapWebService.FenixAppService;

namespace FenixSoapWebService.Processing
{
	public class Process
	{
		/// <summary>
		/// Vlastní zpracování přijaté zprávy dle jejího typu
		/// </summary>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <param name="partnerCode"></param>
		/// <param name="messageType"></param>
		/// <param name="data"></param>
		/// <param name="encoding"></param>
		/// <param name="result"></param>
		/// <param name="authToken"></param>
		/// <returns></returns>
		public SubmitDataToProcessingResult DoProcessing(string login, string password, string partnerCode, string messageType, byte[] data, string encoding, SubmitDataToProcessingResult result, AuthService.AuthToken authToken)
		{
			string messageTypeNormalized = messageType.ToUpper().Trim();
			if (messageTypeNormalized.Contains("TEST"))
				messageTypeNormalized = "TEST";

			switch (messageTypeNormalized)
			{
				case "TEST":
					result = TestProcessing.Process(authToken, login, password, partnerCode, messageType, data, encoding);
					break;
				case "RECEPTIONCONFIRMATION":
				case "KITTINGCONFIRMATION":
				case "SHIPMENTCONFIRMATION":
					result = ConfirmationProcessing.Process(authToken, login, password, partnerCode, messageType, data, encoding);
					break;
				default:
					ProjectHelper.CreateErrorResult(ref result, "100", String.Format("Unknown messageType = [{0}]", messageType));
					break;
			}

			return result;
		}
	}
}