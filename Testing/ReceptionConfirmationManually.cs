using System;

namespace Fenix.WebService.Testing
{
	/// <summary>
	/// Pomocná třída pro testování - ruční vytvoření R1 (Reception Confirmation)
	/// (obsah R1 je hardcoded)
	/// </summary>
	public class ReceptionConfirmationManually
	{
		/// <summary>
		/// Vrací XML string pro R1 (potvrzení recepce ze strany ND)
		/// </summary>
		/// <param name="confirmationId"></param>
		/// <returns></returns>
		public static string GetReceptionConfirmation(int confirmationId)
		{
			string xmlString = String.Empty;

			switch (confirmationId)
			{
				case 10:
					xmlString = ConfirmationId10();
					break;
				case 12:
					xmlString = ConfirmationId12();
					break;
				case 13:
					xmlString = ConfirmationId13();
					break;
				case 14:
					xmlString = ConfirmationId14();
					break;
				default:
					throw new Exception("Neznámé číslo Reception Confirmation - R1");
			}

			return xmlString;
		}

		private static string ConfirmationId10()
		{
			return 
			    @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
                  <CommunicationMessagesReceptionConfirmation>
                    <ID>200000044</ID>
                    <MessageID>210000044</MessageID>
                    <MessageTypeID>2</MessageTypeID>
                    <MessageTypeDescription>ReceptionConfirmation</MessageTypeDescription>
                    <MessageDateOfReceipt>2014-11-26</MessageDateOfReceipt>
                    <ReceptionOrderID>11</ReceptionOrderID>
                    <HeliosOrderID>33598774</HeliosOrderID>
                    <ItemSupplierID>6063</ItemSupplierID>
                    <ItemSupplierDescription>AboutNet s.r.o.</ItemSupplierDescription>
                    <items>
                      <item>
                        <HeliosOrderRecordID>0</HeliosOrderRecordID>
                        <ItemID>910319398</ItemID>
                        <ItemDescription>UTP RJ45-RJ45 CAT 5e 2m</ItemDescription>
                        <ItemQuantity>100</ItemQuantity>
                        <ItemUnitOfMeasureID>1</ItemUnitOfMeasureID>
                        <ItemUnitOfMeasure>KS</ItemUnitOfMeasure>
                        <ItemQualityID>1</ItemQualityID>
                        <ItemQuality>New</ItemQuality>
                      </item>
                    </items>
                  </CommunicationMessagesReceptionConfirmation>
                </NewDataSet>";
		}

		private static string ConfirmationId12()
		{
			return 
			    @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
                  <CommunicationMessagesReceptionConfirmation>
                    <ID>4957</ID>
                    <MessageID>02000000032</MessageID>
                    <MessageTypeID>2</MessageTypeID>
                    <MessageTypeDescription>ReceptionConfirmation</MessageTypeDescription>
                    <MessageDateOfReceipt>2014-08-13</MessageDateOfReceipt>
                    <ReceptionOrderID>12</ReceptionOrderID>
                    <HeliosOrderID>5</HeliosOrderID>
                    <ItemSupplierID>22</ItemSupplierID>
                    <ItemSupplierDescription>Dámec Jan</ItemSupplierDescription>
                    <items>
                      <item>
                        <HeliosOrderRecordID>0</HeliosOrderRecordID>
                        <ItemID>4570</ItemID>
                        <ItemDescription>Manuál KZ1 (590-370037)</ItemDescription>
                        <ItemQuantity>10000</ItemQuantity>
                        <ItemUnitOfMeasureID>1</ItemUnitOfMeasureID>
                        <ItemUnitOfMeasure>KS</ItemUnitOfMeasure>
                        <ItemQualityID>1</ItemQualityID>
                        <ItemQuality>New</ItemQuality>
                      </item>
                      <item>
                        <HeliosOrderRecordID>0</HeliosOrderRecordID>
                        <ItemID>4577</ItemID>
                        <ItemDescription>Manuál A11 (590-370071)</ItemDescription>
                        <ItemQuantity>5000</ItemQuantity>
                        <ItemUnitOfMeasureID>1</ItemUnitOfMeasureID>
                        <ItemUnitOfMeasure>KS</ItemUnitOfMeasure>
                        <ItemQualityID>1</ItemQualityID>
                        <ItemQuality>New</ItemQuality>
                      </item>	  
                    </items>
                  </CommunicationMessagesReceptionConfirmation>
                </NewDataSet>";
		}

		private static string ConfirmationId13()
		{
			return 
			    @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
                  <CommunicationMessagesReceptionConfirmation>
                    <ID>4959</ID>
                    <MessageID>02000000033</MessageID>
                    <MessageTypeID>2</MessageTypeID>
                    <MessageTypeDescription>ReceptionConfirmation</MessageTypeDescription>
                    <MessageDateOfReceipt>2014-08-13</MessageDateOfReceipt>
                    <ReceptionOrderID>13</ReceptionOrderID>
                    <HeliosOrderID>6</HeliosOrderID>
                    <ItemSupplierID>23</ItemSupplierID>
                    <ItemSupplierDescription>ASTRON studio CZ, a.s.</ItemSupplierDescription>
                    <items>
                      <item>
                        <HeliosOrderRecordID>0</HeliosOrderRecordID>
                        <ItemID>4577</ItemID>
                        <ItemDescription>Manuál A11 (590-370071)</ItemDescription>
                        <ItemQuantity>5001</ItemQuantity>
                        <ItemUnitOfMeasureID>1</ItemUnitOfMeasureID>
                        <ItemUnitOfMeasure>KS</ItemUnitOfMeasure>
                        <ItemQualityID>1</ItemQualityID>
                        <ItemQuality>New</ItemQuality>
                      </item>
                    </items>
                  </CommunicationMessagesReceptionConfirmation>
                </NewDataSet>";
		}

		private static string ConfirmationId14()
		{
			return 
			    @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
                  <CommunicationMessagesReceptionConfirmation>
                    <ID>4960</ID>
                    <MessageID>02000000035</MessageID>
                    <MessageTypeID>2</MessageTypeID>
                    <MessageTypeDescription>ReceptionConfirmation</MessageTypeDescription>
                    <MessageDateOfReceipt>2014-08-13</MessageDateOfReceipt>
                    <ReceptionOrderID>14</ReceptionOrderID>
                    <HeliosOrderID>7</HeliosOrderID>
                    <ItemSupplierID>21</ItemSupplierID>
                    <ItemSupplierDescription>Kaon Media Co., Ltd.</ItemSupplierDescription>
                    <items>
                      <item>
                        <HeliosOrderRecordID>0</HeliosOrderRecordID>
                        <ItemID>3436</ItemID>
                        <ItemDescription>KAON KCF-SA700PCO PVR Ready (590-370036)</ItemDescription>
                        <ItemQuantity>10</ItemQuantity>
                        <ItemUnitOfMeasureID>1</ItemUnitOfMeasureID>
                        <ItemUnitOfMeasure>KS</ItemUnitOfMeasure>
                        <ItemQualityID>1</ItemQualityID>
                        <ItemQuality>New</ItemQuality>
                        <ItemSNs>		
                          <ItemSN SN=""B71865865""> </ItemSN>
                          <ItemSN SN=""B71865966""> </ItemSN>
                          <ItemSN SN=""B71866067""> </ItemSN>
                          <ItemSN SN=""B71871422""> </ItemSN>
                          <ItemSN SN=""B71871523""> </ItemSN>
                          <ItemSN SN=""B71877987""> </ItemSN>
                          <ItemSN SN=""B71879503""> </ItemSN>
                          <ItemSN SN=""B71884453""> </ItemSN>
                          <ItemSN SN=""B71888594""> </ItemSN>
                          <ItemSN SN=""B71890010""> </ItemSN>          
                        </ItemSNs>
                      </item>
                    </items>
                  </CommunicationMessagesReceptionConfirmation>
                </NewDataSet>";
		}
	}
}