using System;

namespace Fenix.WebService.Manually
{
	/// <summary>
	/// Pomocná třída pro testování - ruční vytvoření K1 (Kitting Confirmation)
	/// (obsah K1 je hardcoded)
	/// </summary>
	public class KittingConfirmationManually
	{
		/// <summary>
		/// Vrací XML string pro K1 (potvrzení kittingu ze strany ND)
		/// </summary>
		/// <param name="confirmationId"></param>
		/// <returns></returns>
		public static string GetKittingConfirmation(int confirmationId)
		{
			string xmlString = String.Empty;

			switch (confirmationId)
			{
				case 2:
					xmlString = ConfirmationId2();
					break;
				case 3:
					xmlString = ConfirmationId3();
					break;
				case 4:
					xmlString = ConfirmationId4();
					break;
				default:
					throw new Exception("Neznámé číslo Kitting Confirmation - K1");
			}

			return xmlString;
		}

		private static string ConfirmationId4()
		{
			return
            @"<?xml version=""1.0"" encoding=""utf-8""?>
            <NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
              <CommunicationMessagesKittingConfirmation>
                <ID>1400000584</ID>
                <MessageID>464</MessageID>
                <MessageTypeID>4</MessageTypeID>
                <MessageTypeDescription>KittingConfirmation</MessageTypeDescription>
                <MessageDateOfReceipt>2014-12-08</MessageDateOfReceipt>
                <KitOrderID>18</KitOrderID>
                <HeliosOrderID>-4000282</HeliosOrderID>
                <KitID>1500000052</KitID>
                <KitDescription>REZ02</KitDescription>
                <KitQuantity>10</KitQuantity>
                <KitUnitOfMeasureID>1</KitUnitOfMeasureID>
                <KitUnitOfMeasure>KS</KitUnitOfMeasure>
                <KitQualityID>1</KitQualityID>
                <KitQuality>NEW</KitQuality>        
                <ItemSNs>
                    <ItemSN SN1=""00627033563"" SN2=""014165629032""></ItemSN>
                    <ItemSN SN1=""00627033562"" SN2=""014162226576""></ItemSN>
                    <ItemSN SN1=""00627033561"" SN2=""014162962543""></ItemSN>
                    <ItemSN SN1=""00627033560"" SN2=""014161012191""></ItemSN>
                    <ItemSN SN1=""00627033559"" SN2=""014165607038""></ItemSN>
                    <ItemSN SN1=""00637033563"" SN2=""024165629032""></ItemSN>
                    <ItemSN SN1=""00637033562"" SN2=""024162226576""></ItemSN>
                    <ItemSN SN1=""00637033561"" SN2=""024162962543""></ItemSN>
                    <ItemSN SN1=""00637033560"" SN2=""024161012191""></ItemSN>
                    <ItemSN SN1=""00637033559"" SN2=""024165607038""></ItemSN>
                </ItemSNs>
              </CommunicationMessagesKittingConfirmation>
            </NewDataSet>";
		}

		private static string ConfirmationId3()
		{
			return
            @"<?xml version=""1.0"" encoding=""utf-8""?>
            <NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
              <CommunicationMessagesKittingConfirmation>
                <ID>77</ID>
                <MessageID>01000000077</MessageID>
                <MessageTypeID>4</MessageTypeID>
                <MessageTypeDescription>KittingConfirmation</MessageTypeDescription>
                <MessageDateOfReceipt>2014-08-19</MessageDateOfReceipt>
                <KitOrderID>7</KitOrderID>
                <HeliosOrderID>0</HeliosOrderID>
                <kits>
                  <kit>
                    <HeliosOrderRecordID>0</HeliosOrderRecordID>
                    <KitID>9</KitID>
                    <KitDescription>CA1</KitDescription>
                    <KitQuantity>10</KitQuantity>
                    <KitUnitOfMeasureID>1</KitUnitOfMeasureID>
                    <KitUnitOfMeasure>KS</KitUnitOfMeasure>
                    <KitQualityID>1</KitQualityID>
                    <KitQuality>NEW</KitQuality>
                    <ItemSNs>
                      <ItemSN SN1=""00627033563"" SN2=""014165629032""></ItemSN>
                      <ItemSN SN1=""00627033562"" SN2=""014162226576""></ItemSN>
                      <ItemSN SN1=""00627033561"" SN2=""014162962543""></ItemSN>
                      <ItemSN SN1=""00627033560"" SN2=""014161012191""></ItemSN>
                      <ItemSN SN1=""00627033559"" SN2=""014165607038""></ItemSN>
                      <ItemSN SN1=""00627033558"" SN2=""014163692925""></ItemSN>
                      <ItemSN SN1=""00627033557"" SN2=""014161597571""></ItemSN>
                      <ItemSN SN1=""00627033556"" SN2=""014162740618""></ItemSN>
                      <ItemSN SN1=""00627033555"" SN2=""014161325437""></ItemSN>
                      <ItemSN SN1=""00627033554"" SN2=""014161030474""></ItemSN>
                    </ItemSNs>
                  </kit>
                </kits>
              </CommunicationMessagesKittingConfirmation>
            </NewDataSet>";
		}

		private static string ConfirmationId2()
		{
			return
            @"<?xml version=""1.0"" encoding=""utf-8""?>
            <NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
	            <CommunicationMessagesKittingConfirmation>
		            <ID>1</ID>
		            <MessageID>01000000028</MessageID>
		            <MessageTypeID>4</MessageTypeID>
		            <MessageTypeDescription>KittingConfirmation</MessageTypeDescription>
		            <MessageDateOfReceipt>2014-08-14</MessageDateOfReceipt>
		            <KitOrderID>1</KitOrderID>
		            <HeliosOrderID>0</HeliosOrderID>
		            <kits>
			            <kit>
				            <HeliosOrderRecordID>0</HeliosOrderRecordID>
				            <KitID>7</KitID>
				            <KitDescription>Modem Scientific Atlanta EPC2100</KitDescription>
				            <KitQuantity>2</KitQuantity>
				            <KitUnitOfMeasureID>1</KitUnitOfMeasureID>
				            <KitUnitOfMeasure>KS</KitUnitOfMeasure>
				            <KitQualityID>1</KitQualityID>
				            <KitQuality>NEW</KitQuality>
				            <ItemSNs>
				              <ItemSN SN1=""ED40060376"" SN2=""ED400603711""></ItemSN>
				              <ItemSN SN1=""ED40060385"" SN2=""ED400603811""></ItemSN>
				              <ItemSN SN1=""ED40060388"" SN2=""ED400603811""></ItemSN>
				              <ItemSN SN1=""ED40060392"" SN2=""ED400603911""></ItemSN>
				              <ItemSN SN1=""ED40060394"" SN2=""ED400603911""></ItemSN>
				              <ItemSN SN1=""ED40061159"" SN2=""ED400611511""></ItemSN>
				              <ItemSN SN1=""ED40061394"" SN2=""ED400613911""></ItemSN>
				              <ItemSN SN1=""ED40061500"" SN2=""ED400615011""></ItemSN>
				              <ItemSN SN1=""ED40061503"" SN2=""ED400615011""></ItemSN>
				              <ItemSN SN1=""ED40061533"" SN2=""ED400615311""></ItemSN>
				            </ItemSNs>
			            </kit>
			            <kit>
				            <HeliosOrderRecordID>0</HeliosOrderRecordID>
				            <KitID>6</KitID>
				            <KitDescription>STB Kaon</KitDescription>
				            <KitQuantity>1</KitQuantity>
				            <KitUnitOfMeasureID>1</KitUnitOfMeasureID>
				            <KitUnitOfMeasure>KS</KitUnitOfMeasure>
				            <KitQualityID>1</KitQualityID>
				            <KitQuality>NEW</KitQuality>
				            <ItemSNs>
				              <ItemSN SN1=""ED40061503"" SN2=""ED400615011""></ItemSN>
				              <ItemSN SN1=""ED40061533"" SN2=""ED400615311""></ItemSN>
				              <ItemSN SN1=""ED40060375"" SN2=""ED400603712""></ItemSN>
				              <ItemSN SN1=""ED40060385"" SN2=""ED400603812""></ItemSN>
				              <ItemSN SN1=""ED40060385"" SN2=""ED400603812""></ItemSN>
				              <ItemSN SN1=""ED40061505"" SN2=""ED400615012""></ItemSN>
				              <ItemSN SN1=""ED40061535"" SN2=""ED400615312""></ItemSN>
				            </ItemSNs>
			            </kit>
		            </kits>
	            </CommunicationMessagesKittingConfirmation>
            </NewDataSet>";
		}
		
	}
}