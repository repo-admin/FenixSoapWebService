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
using FenixSoapWebService.Manually;
using FenixSoapWebService.Processing;

namespace FenixSoapWebService
{
	public class SubmitDataToProcessingResult
	{
		public SubmitDataToProcessingResult()
		{
			this.Errors = new List<Errors>();
		}

		public List<Errors> Errors { get; set; }
		public long MessageNumber { get; set; }
		public string MessageDescription { get; set; }
	}

	public class Errors
	{
		public string ErrorCode { get; set; }
		public string ErrorMessage { get; set; }
	}

	public class SimpleResult
	{
		public int Number { get; set; }
		public string Message { get; set; }
	}

	/// <summary>
	/// Webová služba starého (ne WCF) typu
	/// </summary>
	[WebService(Namespace = "http://www.upc.cz/fenixSoapWS")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	public class FenixSoapWebSvc : System.Web.Services.WebService
	{
		/// <summary>		
		/// Pomocná metoda pro debug	, urceno predevsim pro Teleplan	
		/// Vraci datum cas na serveru
		/// </summary>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		[WebMethod]
		public SimpleResult NowIs(string login, string password)
		{
			SimpleResult result = new SimpleResult();

			if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
			{
				result.Number = 2;
				result.Message = "Login or password is empty";				
				return result;
			}
			
			try
			{
				AuthService.AuthResult authRes;
				AuthService.AuthSvcClient authProxy = new AuthService.AuthSvcClient();
				AuthService.AuthToken authToken = authProxy.Login(login, password, "", out authRes);
				authProxy.Close();

				if (authToken != null)
				{					
					result.Number = 0;
					result.Message = string.Format("Now is {0}", DateTime.Now);
				}
				else
				{
					result.Number = 1;
					result.Message = "Invalid login";
				}
			}
			catch (Exception ex)
			{
				result.Number = 1;
				result.Message = ex.Message;
			}

			return result;
		}

		/// <summary>
		/// Pomocná metoda pro debug		
		/// </summary>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		[WebMethod]
		public SimpleResult TSubmitDataToProcessing(string login, string password)
		{
			SimpleResult result = new SimpleResult();
			
			try
			{
				if (ProjectHelper.OS.IsWindowsServer() || System.Web.Configuration.WebConfigurationManager.AppSettings["DebugMode"] != "1")				
				{
					throw new Exception("TSubmitDataToProcessing Exception");
				}

				// {TEST; ReceptionConfirmation; KittingConfirmation; ShipmentConfirmation; RefurbishedConfirmation; 
				//  ReturnedEquipment; ReturnedItem; ReturnedShipment; GetServicesStatuses}

				//string type = "Test";
				//string inputString = TestManually.GetTest();

				//string type = "ReceptionConfirmation";
				//string inputString = ReceptionConfirmationManually.GetReceptionConfirmation(10);		

				//string type = "KittingConfirmation";
				//string inputString = KittingConfirmationManually.GetKittingConfirmation(4);		

				//string type = "ShipmentConfirmation";
				//string inputString = ShipmentOrderManually.GetShipmentConfirmation(42);		

				//string type = "ReturnedEquipment";
				//string inputString = ReturnedEquipmentManually.GetReturnedEquipment(3);

				//string type = "ReturnedItem";
				//string inputString = ReturnedItemManually.GetReturnedItem(3);	

				//string type = "ReturnedShipment";
				//string inputString = ReturnedShipmentManually.GetReturnedShipment(2);

				//string type = "RefurbishedConfirmation";
				//string inputString = RefurbishedConfirmationManually.GetRefurbishedConfirmation(3);

				//string type = "GetServicesStatuses";
				//string inputString = "V tomto případě se nepoužívá - existuje jen pro zachování signatury metody SubmitDataToProcessing";

				//string type = "CrmOrderConfirmation";
				//string inputString = CrmOrderConfirmationManually.GetCrmOrderConfirmation(1);

				string type = "CrmOrderApproval";
				string inputString = CrmOrderApprovalManually.GetCrmOrderApproval(2);

				byte[] byteU8 = Encoding.UTF8.GetBytes(inputString);

				SubmitDataToProcessingResult processingResult = SubmitDataToProcessing(login, password, Environment.MachineName, type, byteU8, "UTF-8");

				result.Number = (int)processingResult.MessageNumber;
				result.Message = result.Number == (int)BC.OK ? "OK" : processingResult.Errors[0].ErrorMessage;
			}
			catch (Exception ex)
			{
				result.Number = 1;
				result.Message = ex.Message;
			}

			return result;
		}

		#region Public Methods
				
		/// <summary>
		/// Základní metoda zpracování (příjem zpráv z ND)
		/// </summary>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <param name="partnerCode"></param>
		/// <param name="messageType"></param>
		/// <param name="data"></param>
		/// <param name="encoding"></param>
		/// <returns></returns>
		[WebMethod]
		public SubmitDataToProcessingResult SubmitDataToProcessing(string login, string password, string partnerCode, string messageType, byte[] data, string encoding)
		{
			SubmitDataToProcessingResult result = new SubmitDataToProcessingResult();
			
			if (!baseValidation(partnerCode, messageType, data, encoding, result))
			{
				return result;
			}

			try
			{
				AuthService.AuthResult authRes;
				AuthService.AuthSvcClient authProxy = new AuthService.AuthSvcClient();
				AuthService.AuthToken authToken = authProxy.Login(login, password, "", out authRes);
				authProxy.Close();

				if (authToken != null)
				{
					result = doProcessing(login, password, partnerCode, messageType, data, encoding, result, authToken);
				}
				else
				{
					ProjectHelper.CreateErrorResult(FenixHelper.AppLog.GetMethodName(), ref result, "1", "Invalid login");
				}
			}
			catch (Exception ex)
			{
				ProjectHelper.CreateErrorResult(FenixHelper.AppLog.GetMethodName(), ref result, "100", ex);
			}

			return result;
		}

        /// <summary>
        /// Basic method for TLP
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="messageType"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <param name="customerId"></param>
        /// <param name="customerDescription"></param>
        /// <returns></returns>
        [WebMethod]
        public SubmitDataToProcessingResult SubmitRepaseData(string login, string password, string messageType, byte[] data, string encoding, int customerId = 0, string customerDescription = null, DateTime? dateOfDelivery = null)
        {
            SubmitDataToProcessingResult result = new SubmitDataToProcessingResult();

            // basic validations
            if (String.IsNullOrEmpty(messageType)) { result.Errors.Add(new Errors { ErrorCode = "-100", ErrorMessage = "Parameter messageType is required!" }); }
            if (data == null) { result.Errors.Add(new Errors { ErrorCode = "-101", ErrorMessage = "Parameter data is required!" }); }
            if (String.IsNullOrEmpty(encoding)) { result.Errors.Add(new Errors { ErrorCode = "-102", ErrorMessage = "Parameter encoding is required!" }); }
            if (messageType.Contains("TR") || messageType.Contains("TS"))
            {
                if (customerId == 0) { result.Errors.Add(new Errors { ErrorCode = "-103", ErrorMessage = "If using TR/TS MSG types, customerId is required!" }); }
                if (String.IsNullOrEmpty(customerDescription)) { result.Errors.Add(new Errors { ErrorCode = "-104", ErrorMessage = "If using TR/TS MSG types, customerDescription is required!" }); }
                if (dateOfDelivery == null) { result.Errors.Add(new Errors { ErrorCode = "-105", ErrorMessage = "If using TR/TS MSG types, dateOfDelivery is required!" }); }
            }
            
            // authentication
            AuthService.AuthResult authRes;
            AuthService.AuthSvcClient authProxy = new AuthService.AuthSvcClient();
            AuthService.AuthToken authToken = authProxy.Login(login, password, "", out authRes);
            authProxy.Close();

            if (authToken != null && result.Errors.Count == 0)
            {
                // test processing
                result = TestProcessing.Process(authToken, login, password, "", messageType, data, encoding);
            }
            else
            {
                ProjectHelper.CreateErrorResult(FenixHelper.AppLog.GetMethodName(), ref result, "1", "Invalid login");
            }
            
            return result;
        }
        
		#endregion

		#region Private Methods

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
		private static SubmitDataToProcessingResult doProcessing(string login, string password, string partnerCode, string messageType, byte[] data, string encoding, SubmitDataToProcessingResult result, AuthService.AuthToken authToken)
		{
			string messageTypeNormalized = messageType.ToUpper().Trim();
			if (messageTypeNormalized.Contains("TEST"))
				messageTypeNormalized = "TEST";

			switch (messageTypeNormalized)
			{
				case "TEST":
					result = TestProcessing.Process(authToken, login, password, partnerCode, messageType, data, encoding);
					break;

				case "GETSERVICESSTATUSES":
					result = ServicesStatusesProcessing.Process(authToken, login, password, partnerCode, messageType);					
					break;

				case "RECEPTIONCONFIRMATION":
				case "KITTINGCONFIRMATION":
				case "SHIPMENTCONFIRMATION":
				case "RETURNED":
				case "RETURNEDEQUIPMENT":
				case "RETURNEDITEM":
				case "RETURNEDSHIPMENT":
				case "REFURBISHEDCONFIRMATION":
				case "DELETEMESSAGECONFIRMATION":
				case "CRMORDERCONFIRMATION":
				case "CRMORDERAPPROVAL":
					result = MessageProcessing.Process(authToken, login, password, partnerCode, messageType, data, encoding);
					break;

				default:
					ProjectHelper.CreateErrorResult(FenixHelper.AppLog.GetMethodName(), ref result, "100", String.Format("Unknown messageType = [{0}]", messageType));
					break;
			}

			return result;
		}

		/// <summary>
		/// Základní validace (vyplnění parametrů)
		/// </summary>
		/// <param name="partnerCode"></param>
		/// <param name="messageType"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		private bool baseValidation(string partnerCode, string messageType, byte[] data, string encoding, SubmitDataToProcessingResult result)
		{
			if (String.IsNullOrEmpty(partnerCode) || String.IsNullOrEmpty(messageType) || data == null || String.IsNullOrEmpty(encoding))
			{
				ProjectHelper.CreateErrorResult(FenixHelper.AppLog.GetMethodName(), ref result, "10", "Invalid input parameter");
				return false;
			}
			
			return true;
		}

		#endregion
	}
}
