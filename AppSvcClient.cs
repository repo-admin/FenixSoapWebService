using WCFExtrasPlus.Soap;

namespace FenixSoapWebService.FenixAppService
{
	public partial class FenixAppSvcClient
	{
		public AuthToken AuthToken
		{
			get { return InnerChannel.GetHeader<AuthToken>("AuthToken"); }
			set { InnerChannel.SetHeader("AuthToken", value); }
		}
	}
}
