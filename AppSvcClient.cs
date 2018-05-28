using Fenix.WebService.Service_References.FenixAppService;
using WCFExtrasPlus.Soap;
// ReSharper disable CheckNamespace


namespace Fenix.WebService.Service_References.FenixAppService
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
