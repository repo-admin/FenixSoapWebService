using System;
using Fenix.WebService.Service_References.FenixAppService;

namespace Fenix.WebService.Processing
{
	/// <summary>
	/// Třída pro požadavku na zjištění 'zdraví služeb'
	/// </summary>
	public class ServicesStatusesProcessing
	{
	    /// <summary>
	    /// Volání SP pro ověření 'zdraví služeb'
	    /// </summary>
	    /// <param name="authToken"></param>
	    /// <param name="login"></param>
	    /// <param name="password"></param>
	    /// <param name="partnerCode"></param>
	    /// <param name="messageType"></param>
	    /// <returns>result.MessageDescription by měla obsahovat string 'Automat Rows : 1  |   DateTime : yyyy-mm-dd hh:mi:ss.mmm'</returns>
	    public static SubmitDataToProcessingResult Process(AuthToken authToken, string login, string password, string partnerCode, string messageType)
		{
			SubmitDataToProcessingResult result = new SubmitDataToProcessingResult();

			try
			{
				if (authToken != null)
				{
					FenixAppSvcClient appClient = new FenixAppSvcClient();
					appClient.AuthToken = new Fenix.WebService.Service_References.FenixAppService.AuthToken() { Value = authToken.Value };
					ProcResult procResult = appClient.GetServicesStatuses(BC.ZICYZ_USER_ID);						
					appClient.Close();
										
					if (procResult.ReturnValue == (int)BC.OK)
					{
						result.MessageDescription = procResult.ReturnMessage;							
					}
					else
					{
						ProjectHelper.CreateErrorResult(ApplicationLog.GetMethodName(), ref result, "90", procResult.ReturnMessage);
					}					
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