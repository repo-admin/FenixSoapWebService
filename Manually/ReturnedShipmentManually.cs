using System;

namespace Fenix.WebService.Manually
{
	/// <summary>
	/// Hardcoded vytvoření vratky ze strany ND - message VR3
	/// </summary>
	public class ReturnedShipmentManually
	{
		/// <summary>
		/// Vrací XML string pro VR3 (vratka - odvoz na repasi)
		/// tohle message generuje ND samo o sobe = nepredchazi zadana message od nas
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		public static string GetReturnedShipment(int returnedId)
		{			
			string xmlString = String.Empty;

			switch (returnedId)
			{
				case 2:
					xmlString = returnFromND2();	
					break;
				default:
					throw new Exception("Neznámé číslo vratky itemů");
			}

			return xmlString;
		}

		private static string returnFromND2()
		{
			return
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
  <CommunicationMessagesReturnedShipment>
    <ID>0100000001</ID>
    <MessageID>0100000002</MessageID>
    <MessageTypeID>11</MessageTypeID>
    <MessageTypeDescription>ReturnedShipment</MessageTypeDescription>
    <CustomerID>1</CustomerID>
    <CustomerName>A03 UPC PRAHA</CustomerName>
    <CustomerAddress1>Závišova</CustomerAddress1>
    <CustomerAddress2>5</CustomerAddress2>
    <CustomerAddress3 />
    <CustomerCity>Praha 4</CustomerCity>
    <CustomerZipCode>14000</CustomerZipCode>
    <CustomerCountryISO>CZE</CustomerCountryISO>
    <ContactID>1</ContactID>
    <ContactTitle>1</ContactTitle>
    <ContactFirstName>Daniel</ContactFirstName>
    <ContactLastName>Vávra</ContactLastName>
    <ContactPhoneNumber1>733141634</ContactPhoneNumber1>
    <ContactPhoneNumber2 />
    <ContactFaxNumber />
    <ContactEmail>muj@email.cz</ContactEmail>
    <items>
       <item>
          <ItemQualityID>2</ItemQualityID>
          <ItemQuality>TRR</ItemQuality>
          <IncotermID>2</IncotermID>
          <IncotermDescription>DAP</IncotermDescription>
          <ItemSNs>
             <ItemSN SN1=""ED40060376"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED40060377"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED40060378"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED40060379"" SN2=""ED50060376"" />
          </ItemSNs>
       </item>
       <item>
          <ItemQualityID>2</ItemQualityID>
          <ItemQuality>TRR</ItemQuality>
          <IncotermID>2</IncotermID>
          <IncotermDescription>DAP</IncotermDescription>
          <ItemSNs>
             <ItemSN SN1=""ED40060376A"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED40060377A"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED40060378A"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED40060379A"" SN2=""ED50060376"" />
          </ItemSNs>
       </item>
    </items>
  </CommunicationMessagesReturnedShipment>
</NewDataSet>";
		}
	}
}