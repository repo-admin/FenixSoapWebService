using System;

namespace Fenix.WebService.Manually
{
	/// <summary>
	/// Hardcoded vytvoření vratky itemů ze strany ND - message VR2 (Returned Item)
	/// </summary>
	public class ReturnedItemManually
	{
		/// <summary>
		/// Vrací XML string pro VR2 (vratka - vrácené itemy)
		/// tohle message generuje ND samo o sobe = nepredchazi zadana message od nas
		/// </summary>
		/// <param name="confirmationId"></param>
		/// <returns></returns>
		public static string GetReturnedItem(int confirmationId)
		{			
			string xmlString = String.Empty;

			switch (confirmationId)
			{
				case 3:					
					xmlString = returnFromND3();	// OK
					break;
				case 4:					
					xmlString = returnFromNDWithError();	// chyba (pro vývoj)
					break;
				default:
					throw new Exception("Neznámé číslo vratky itemů");					
			}

			return xmlString;
		}
				
		/// <summary>
		/// Vrací XML string pro VR2 (vratka - vrácené itemy)                             !!! s chybou !!!		
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		private static string returnFromNDWithError()
		{
			return
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
  <CommunicationMessagesReturnedItem>
    <ID>100000504</ID>
    <MessageID>110000504</MessageID>
    <MessageTypeID>10</MessageTypeID>
    <MessageTypeDescription>ReturnedItem</MessageTypeDescription>
    <MessageDateOfReceipt>2014-10-17</MessageDateOfReceipt>
    <items>
      <item>	   
        <ItemID>910330014</ItemID>
        <ItemDescription>Philips CD1801B/53 - S18</ItemDescription>
        <ItemQuantity>4</ItemQuantity>
        <ItemUnitOfMeasureID>1</ItemUnitOfMeasureID>
        <ItemUnitOfMeasure>KS</ItemUnitOfMeasure>
      </item>      
      <item>      
    </items>
  </CommunicationMessagesReturnedItem>
</NewDataSet>";			
		}

		/// <summary>
		/// Vrací XML string pro VR2 (vratka - vrácené itemy)                             
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		private static string returnFromND3()
		{
			return
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
  <CommunicationMessagesReturnedItem>
    <ID>1400000335</ID>
    <MessageID>1410000335</MessageID>
    <MessageTypeID>10</MessageTypeID>
    <MessageTypeDescription>ReturnedItem</MessageTypeDescription>
    <items>
      <item>
        <ItemID>110319186</ItemID>
        <ItemDescription>Linksys SRW 208</ItemDescription>
        <ItemQuantity>5</ItemQuantity>
        <ItemQualityID>1</ItemQualityID>
        <ItemQuality>New</ItemQuality>
        <ReturnedFrom>POST</ReturnedFrom>
        <ItemSNs>
          <ItemSN SN=""PD40060376"" />
          <ItemSN SN=""PD40060377"" />
          <ItemSN SN=""PD40060378"" />
          <ItemSN SN=""PD40060379"" />
          <ItemSN SN=""PD40060380"" />
        </ItemSNs>
      </item>
      <item>
        <ItemID>591370078</ItemID>
        <ItemDescription>Dawn Gateway w/o HDD - DFW (E3</ItemDescription>
        <ItemQuantity>7</ItemQuantity>
        <ItemQualityID>1</ItemQualityID>
        <ItemQuality>New</ItemQuality>
        <ReturnedFrom>UPC</ReturnedFrom>
        <ItemSNs>
          <ItemSN SN=""DGH40010776"" />
          <ItemSN SN=""DGH40010777"" />
          <ItemSN SN=""DGH40010778"" />
          <ItemSN SN=""DGH40010779"" />
          <ItemSN SN=""DGH40010780"" />
          <ItemSN SN=""DGH40010781"" />
          <ItemSN SN=""DGH40010782"" />
        </ItemSNs>
      </item>
    </items>
  </CommunicationMessagesReturnedItem>
</NewDataSet>
";
		}	
	}
}