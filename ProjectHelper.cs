using System;
using System.Runtime.InteropServices;
using Fenix.WebService.Service_References.FenixAppService;

namespace Fenix.WebService
{
	/// <summary>
	/// Pomocná třída projektu
	/// </summary>
	public class ProjectHelper
	{
		/// <summary>
		/// pomocná interní třída
		/// </summary>
		internal class OS
		{
			/// <summary>
			/// zjištění, zda aplikace běží na serveru
			/// </summary>
			/// <returns></returns>
			internal static bool IsWindowsServer()
			{
				return OS.IsOS(OS.OS_ANYSERVER);
			}

			private const int OS_ANYSERVER = 29;

			[DllImport("shlwapi.dll", SetLastError = true, EntryPoint = "#437")]
			private static extern bool IsOS(int os);
		}

		/// <summary>
		/// Zápis do logovací tabulky AppLogNew
		/// </summary>
		/// <param name="authToken"></param>
		/// <param name="type"></param>
		/// <param name="message"></param>
		/// <param name="xmlMessage"></param>
		/// <param name="zicyzUserID"></param>
		/// <param name="sourceName"></param>
		/// <returns></returns>
		public static SubmitDataToProcessingResult AppLogWrite(AuthToken authToken, string type, string message, string xmlDeclaration, string xmlMessage, int zicyzUserID, string sourceName)								
		{
			SubmitDataToProcessingResult result = new SubmitDataToProcessingResult();
			
			try
			{
				if (authToken != null)
				{
					FenixAppSvcClient appClient = new FenixAppSvcClient();
					appClient.AuthToken = new Fenix.WebService.Service_References.FenixAppService.AuthToken() { Value = authToken.Value };										
					ProcResult procResult = appClient.AppLogWriteNew(type, message, xmlDeclaration, xmlMessage, zicyzUserID, sourceName);
					appClient.Close();

					if (procResult.ReturnValue == (int)BC.OK)
					{
						CreateOKResult(ref result);
					}
					else
					{
						CreateErrorResult(ApplicationLog.GetMethodName(), ref result, "90", procResult.ReturnMessage);
					}
				}
			}
			catch (Exception ex)
			{
				CreateErrorResult(ApplicationLog.GetMethodName(), ref result, "100", ex);
			}

			return result;
		}

		/// <summary>
		/// Vytvoří message pro zápis do tabulky AppLog
		/// </summary>
		/// <param name="processingName"></param>
		/// <param name="partnerCode"></param>
		/// <param name="messageType"></param>
		/// <param name="description"></param>
		/// <returns></returns>
		public static string CreateAppLogMessage(string partnerCode, string messageType, string description)
		{			
			return String.Format("PartnerCode = [{0}] MessageType = [{1}]  {2}", partnerCode, messageType, description);
		}

		/// <summary>
		/// Vytvoří result pro OK
		/// </summary>
		/// <param name="result"></param>
		public static void CreateOKResult(ref SubmitDataToProcessingResult result)
		{
			result.MessageNumber = BC.OK;
			result.MessageDescription = "OK";
			result.Errors.Add(new Errors { ErrorCode = "0", ErrorMessage = "Success" });
		}

		/// <summary>
		/// Vytvoří chybový result
		/// </summary>
		/// <param name="result"></param>
		/// <param name="errorCode">kód chyby</param>
		/// <param name="ex">vyjímka</param>
		public static void CreateErrorResult(string methodName, ref SubmitDataToProcessingResult result, string errorCode, Exception ex)
		{
			removeOKResult(ref result);

			result.MessageNumber = BC.NOT_OK;
			result.MessageDescription = String.Format("ERROR in {0}", methodName);
			result.Errors.Add(new Errors { ErrorCode = errorCode, ErrorMessage = ex.Message });

			Exception innerExeption = ex.InnerException;
			while (innerExeption != null)
			{
				result.Errors.Add(new Errors { ErrorCode = errorCode, ErrorMessage = ex.InnerException.Message });
				innerExeption = innerExeption.InnerException;
			}

			//if (ex.InnerException != null)
			//	result.Errors.Add(new Errors { ErrorCode = errorCode, ErrorMessage = ex.InnerException.Message });
		}

		/// <summary>
		/// Vytvoří chybový result
		/// </summary>
		/// <param name="result"></param>
		/// <param name="errorCode">kód chyby</param>
		/// <param name="errorMessage">text chyby</param>
		public static void CreateErrorResult(string methodName, ref SubmitDataToProcessingResult result, string errorCode, string errorMessage)
		{
			removeOKResult(ref result);

			result.MessageNumber = BC.NOT_OK;
			result.MessageDescription = String.Format("ERROR in {0}", methodName);
			result.Errors.Add(new Errors { ErrorCode = errorCode, ErrorMessage = errorMessage });
		}

		/*
		 
		internal static ProcResult CreateErrorResult(string methodName, Exception ex)
		{
			ProcResult result = new ProcResult();

			result.ReturnValue = BC.NOT_OK;
			result.ReturnMessage = String.Format("{0}{1}{2}", methodName, Environment.NewLine, ex.Message);

			Exception innerExeption = ex.InnerException;
			while (innerExeption != null)
			{
				result.ReturnMessage += result.ReturnMessage + Environment.NewLine + ex.InnerException.Message;
				innerExeption = innerExeption.InnerException;
			}

			return result;
		}
		 
		 
		 */

		/// <summary>
		/// Odstraní OK result (pokud existuje)
		/// </summary>
		/// <param name="result">odtud se odstraní OK result</param>
		private static void removeOKResult(ref SubmitDataToProcessingResult result)
		{
			if (result.MessageNumber == BC.OK && result.Errors.Count >= 1)
			{
				result.Errors.Clear();
			}
		}
	}
}