using System;

namespace Fenix.WebService.Testing
{
	public class ShipmentOrderManually
	{
		/// <summary>
		/// Vrací XML string pro S1 (potvrzení zavozu ze strany ND)
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		public static string GetShipmentConfirmation(int orderId)
		{
			string xmlString = String.Empty;

			switch (orderId)
			{
				case 34:
					xmlString = ConfirmationId34();
					break;
				case 36:
					xmlString = ConfirmationId36();
					break;
				case 38:
					xmlString = ConfirmationId38();
					break;
				case 40:
					xmlString = ConfirmationId40();
					break;
				case 42:
					xmlString = ConfirmationId42();
					break;
				default:
					throw new Exception("Neznámé číslo Shipment Confirmation - S1");
			}

			return xmlString;		
		}

		private static string ConfirmationId42()
		{
			return
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
  <CommunicationMessagesShipmentConfirmation>
    <ID>1400000184</ID>
    <MessageID>1410000184</MessageID>
    <MessageTypeID>7</MessageTypeID>
    <MessageTypeDescription>ShipmentConfirmation</MessageTypeDescription>
    <MessageDateOfShipment>2014-11-26</MessageDateOfShipment>
    <RequiredDateOfReceipt>2014-12-24</RequiredDateOfReceipt>
    <ShipmentOrderID>11</ShipmentOrderID>
    <HeliosOrderID>-4000009</HeliosOrderID>
    <CustomerID>21</CustomerID>
    <CustomerName>A40 - INF TEPLICE</CustomerName>
    <CustomerAddress1>Doubravská</CustomerAddress1>
    <CustomerAddress2>1615</CustomerAddress2>
    <CustomerAddress3 />
    <CustomerCity>Teplice</CustomerCity>
    <CustomerZipCode>41501</CustomerZipCode>
    <CustomerCountryISO>CZE</CustomerCountryISO>
    <ContactID>21</ContactID>
    <ContactTitle>2</ContactTitle>
    <ContactFirstName>Poláčková Soňa</ContactFirstName>
    <ContactLastName>Poláčková Soňa</ContactLastName>
    <ContactPhoneNumber1>739243825</ContactPhoneNumber1>
    <ContactPhoneNumber2 />
    <ContactFaxNumber />
    <ContactEmail>ADM_Teplice@infotel.cz</ContactEmail>
    <itemsOrKits>
      <itemOrKit>
        <SingleOrMaster>0</SingleOrMaster>
        <HeliosOrderRecordID>0</HeliosOrderRecordID>
        <ItemOrKitID>800136031</ItemOrKitID>
        <ItemOrKitDescription>Dat.zásuvka DB85F+víčko</ItemOrKitDescription>
        <ItemOrKitQuantity>7</ItemOrKitQuantity>
        <ItemOrKitUnitOfMeasureID>1</ItemOrKitUnitOfMeasureID>
        <ItemOrKitUnitOfMeasure>KS</ItemOrKitUnitOfMeasure>
        <ItemOrKitQualityID>1</ItemOrKitQualityID>
        <ItemOrKitQuality>NEW</ItemOrKitQuality>
        <ItemVerKit>0</ItemVerKit>
        <IncotermID>2</IncotermID>
        <IncotermDescription>DAP</IncotermDescription>
        <RealDateOfDelivery>2014-11-26</RealDateOfDelivery>
        <RealItemOrKitQuantity>3</RealItemOrKitQuantity>
        <RealItemOrKitQualityID>1</RealItemOrKitQualityID>
        <RealItemOrKitQuality>NEW</RealItemOrKitQuality>
        <Status>1</Status>
        <ItemOrKitSNs />
      </itemOrKit>
    </itemsOrKits>
  </CommunicationMessagesShipmentConfirmation>
</NewDataSet>";
		}

		private static string ConfirmationId40()
		{
			return
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
  <CommunicationMessagesShipmentConfirmation>
    <ID>1400000153</ID>
    <MessageID>1410000153</MessageID>
    <MessageTypeID>7</MessageTypeID>
    <MessageTypeDescription>ShipmentConfirmation</MessageTypeDescription>
    <MessageDateOfShipment>2014-11-24</MessageDateOfShipment>
    <RequiredDateOfReceipt>2014-12-24</RequiredDateOfReceipt>
    <ShipmentOrderID>9</ShipmentOrderID>
    <HeliosOrderID>-4000006</HeliosOrderID>
    <CustomerID>7</CustomerID>
    <CustomerName>A24 - PROMSAT STŘED</CustomerName>
    <CustomerAddress1>Ohradní</CustomerAddress1>
    <CustomerAddress2>1159/65</CustomerAddress2>
    <CustomerAddress3 />
    <CustomerCity>Praha 4</CustomerCity>
    <CustomerZipCode>14000</CustomerZipCode>
    <CustomerCountryISO>CZE</CustomerCountryISO>
    <ContactID>7</ContactID>
    <ContactTitle>1</ContactTitle>
    <ContactFirstName>Jan</ContactFirstName>
    <ContactLastName>Bejbl</ContactLastName>
    <ContactPhoneNumber1>603471959</ContactPhoneNumber1>
    <ContactPhoneNumber2 />
    <ContactFaxNumber />
    <ContactEmail>logistik-stred@promsat.cz</ContactEmail>
    <itemsOrKits>
      <itemOrKit>
        <SingleOrMaster>0</SingleOrMaster>
        <HeliosOrderRecordID>0</HeliosOrderRecordID>
        <ItemOrKitID>700151130</ItemOrKitID>
        <ItemOrKitDescription>F-59-CX3 3.9</ItemOrKitDescription>
        <ItemOrKitQuantity>5</ItemOrKitQuantity>
        <ItemOrKitUnitOfMeasureID>1</ItemOrKitUnitOfMeasureID>
        <ItemOrKitUnitOfMeasure>KS</ItemOrKitUnitOfMeasure>
        <ItemOrKitQualityID>1</ItemOrKitQualityID>
        <ItemOrKitQuality>NEW</ItemOrKitQuality>
        <ItemVerKit>0</ItemVerKit>
        <IncotermID>2</IncotermID>
        <IncotermDescription>DAP</IncotermDescription>
        <RealDateOfDelivery>2014-11-24</RealDateOfDelivery>
        <RealItemOrKitQuantity>3</RealItemOrKitQuantity>
        <RealItemOrKitQualityID>1</RealItemOrKitQualityID>
        <RealItemOrKitQuality>NEW</RealItemOrKitQuality>
        <Status>1</Status>
        <ItemOrKitSNs />
      </itemOrKit>
    </itemsOrKits>
  </CommunicationMessagesShipmentConfirmation>
</NewDataSet>";
		}

		private static string ConfirmationId38()
		{
			return
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
  <CommunicationMessagesShipmentConfirmation>
    <ID>1400000146</ID>
    <MessageID>2959</MessageID>
    <MessageTypeID>7</MessageTypeID>
    <MessageTypeDescription>ShipmentConfirmation</MessageTypeDescription>
    <MessageDateOfShipment>2014-11-13</MessageDateOfShipment>
    <RequiredDateOfReceipt>2014-11-13</RequiredDateOfReceipt>
    <ShipmentOrderID>256</ShipmentOrderID>
    <HeliosOrderID>-4000133</HeliosOrderID>
    <CustomerID>51</CustomerID>
    <CustomerName>Lica Servis  s.r.o. Nymburk</CustomerName>
    <CustomerAddress1>Kostomlátecká</CustomerAddress1>
    <CustomerAddress2>20/39</CustomerAddress2>
    <CustomerAddress3 />
    <CustomerCity>Nymburk</CustomerCity>
    <CustomerZipCode>28802</CustomerZipCode>
    <CustomerCountryISO>CZE</CustomerCountryISO>
    <ContactID>64</ContactID>
    <ContactTitle>2</ContactTitle>
    <ContactFirstName>.</ContactFirstName>
    <ContactLastName>Valentová Alena</ContactLastName>
    <ContactPhoneNumber1>724890955</ContactPhoneNumber1>
    <ContactPhoneNumber2 />
    <ContactFaxNumber />
    <ContactEmail>alena.valentova@lica.cz</ContactEmail>
    <itemsOrKits>
      <itemOrKit>
        <SingleOrMaster>1</SingleOrMaster>
        <HeliosOrderRecordID>0</HeliosOrderRecordID>
        <ItemOrKitID>590370038</ItemOrKitID>
        <ItemOrKitDescription>Krabička CA1</ItemOrKitDescription>
        <ItemOrKitQuantity>1800</ItemOrKitQuantity>
        <ItemOrKitUnitOfMeasureID>1</ItemOrKitUnitOfMeasureID>
        <ItemOrKitUnitOfMeasure>KS</ItemOrKitUnitOfMeasure>
        <ItemOrKitQualityID>1</ItemOrKitQualityID>
        <ItemOrKitQuality>NEW</ItemOrKitQuality>
        <ItemVerKit>0</ItemVerKit>
        <IncotermID>2</IncotermID>
        <IncotermDescription>DAP</IncotermDescription>
        <RealDateOfDelivery>2014-11-13</RealDateOfDelivery>
        <RealItemOrKitQuantity>1800</RealItemOrKitQuantity>
        <RealItemOrKitQualityID>1</RealItemOrKitQualityID>
        <RealItemOrKitQuality>NEW</RealItemOrKitQuality>
        <Status>1</Status>
        <ItemOrKitSNs />
      </itemOrKit>
    </itemsOrKits>
  </CommunicationMessagesShipmentConfirmation>
</NewDataSet>";
		}


		private static string ConfirmationId36()
		{
			return
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewDataSet xmlns=""http://www.w3.org/2001/XMLSchema"">
  <CommunicationMessagesShipmentConfirmation>
    <ID>01000000060</ID>
    <MessageID>9787</MessageID>
    <MessageTypeID>7</MessageTypeID>
    <MessageTypeDescription>ShipmentConfirmation</MessageTypeDescription>
    <MessageDateOfShipment>2014-09-11</MessageDateOfShipment>
    <RequiredDateOfReceipt>2014-09-30</RequiredDateOfReceipt>
    <ShipmentOrderID>1</ShipmentOrderID>
    <HeliosOrderID>-4000001</HeliosOrderID>
    <CustomerID>1</CustomerID>
    <CustomerName>A03 UPC PRAHA</CustomerName>
    <CustomerAddress1>Závišova</CustomerAddress1>
    <CustomerAddress2>5</CustomerAddress2>
    <CustomerAddress3></CustomerAddress3>
    <CustomerCity>Praha 4</CustomerCity>
    <CustomerZipCode>11150</CustomerZipCode>
    <CustomerCountryISO>CZE</CustomerCountryISO>
    <ContactID>1</ContactID>
    <ContactTitle>1</ContactTitle>
    <ContactFirstName>Daniel</ContactFirstName>
    <ContactLastName>Vávra</ContactLastName>
    <ContactPhoneNumber1>724608009</ContactPhoneNumber1>
    <ContactPhoneNumber2></ContactPhoneNumber2>
    <ContactFaxNumber></ContactFaxNumber>
    <ContactEmail>daniel.vavra@upc.cz</ContactEmail>
    <itemsOrKits>
      <itemOrKit>
        <SingleOrMaster>0</SingleOrMaster>
        <HeliosOrderRecordID>0</HeliosOrderRecordID>
        <ItemOrKitID>6000002</ItemOrKitID>
        <ItemOrKitDescription>KZ2=KZ1</ItemOrKitDescription>
        <ItemOrKitQuantity>3</ItemOrKitQuantity>
        <ItemOrKitUnitOfMeasureID>1</ItemOrKitUnitOfMeasureID>
        <ItemOrKitUnitOfMeasure>KS</ItemOrKitUnitOfMeasure>
        <ItemOrKitQualityID>1</ItemOrKitQualityID>
        <ItemOrKitQuality>New</ItemOrKitQuality>
        <ItemVerKit>1</ItemVerKit>
        <IncotermID>2</IncotermID>
        <IncotermDescription>DAP</IncotermDescription>
        <RealDateOfDelivery>2014-09-15</RealDateOfDelivery>
        <RealItemOrKitQuantity>3</RealItemOrKitQuantity>
        <RealItemOrKitQualityID>1</RealItemOrKitQualityID>
        <RealItemOrKitQuality>New</RealItemOrKitQuality>
        <Status>1</Status>
        <ItemOrKitSNs>
          <ItemSN SN1=""T56300001"" SN2=""""/>
          <ItemSN SN1=""T56300002"" SN2=""""/>
          <ItemSN SN1=""T56300003"" SN2=""""/>
        </ItemOrKitSNs>
      </itemOrKit>
    </itemsOrKits>
  </CommunicationMessagesShipmentConfirmation>
</NewDataSet>
";
		}


		private static string ConfirmationId34()
		{
			return 
@"<NewDataSet>
  <CommunicationMessagesShipmentConfirmation>
    <ID>01000000040</ID>
    <MessageID>5191</MessageID>
    <MessageTypeID>7</MessageTypeID>
    <MessageTypeDescription>ShipmentConfirmation</MessageTypeDescription>
    <MessageDateOfShipment>2014-08-29</MessageDateOfShipment>
    <RequiredDateOfReceipt>2014-09-29</RequiredDateOfReceipt>
    <ShipmentOrderID>1</ShipmentOrderID>
    <HeliosOrderID>1</HeliosOrderID>
    <CustomerID>1</CustomerID>
    <CustomerName>A03 UPC PRAHA</CustomerName>
    <CustomerAddress1>Česká</CustomerAddress1>
    <CustomerAddress2>648</CustomerAddress2>
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
    <itemsOrKits>
       <itemOrKit>
          <SingleOrMaster>0</SingleOrMaster>
          <HeliosOrderRecordID>1</HeliosOrderRecordID>
          <ItemOrKitID>3265</ItemOrKitID>
          <ItemOrKitDescription>Krabice  (a)</ItemOrKitDescription>
          <ItemOrKitQuantity>7</ItemOrKitQuantity>
          <ItemOrKitUnitOfMeasureID>1</ItemOrKitUnitOfMeasureID>
          <ItemOrKitUnitOfMeasure>KS</ItemOrKitUnitOfMeasure>
          <ItemOrKitQualityID>1</ItemOrKitQualityID>
          <ItemOrKitQuality>New</ItemOrKitQuality>
          <ItemVerKit>0</ItemVerKit>
          <IncotermID>2</IncotermID>
          <IncotermDescription>DAP</IncotermDescription>
          <RealDateOfDelivery>2014-08-29</RealDateOfDelivery>
          <RealItemOrKitQuantity>7</RealItemOrKitQuantity>
          <RealItemOrKitQualityID>1</RealItemOrKitQualityID>
          <RealItemOrKitQuality>New</RealItemOrKitQuality>
          <Status>1</Status>
       </itemOrKit>
       <itemOrKit>
          <SingleOrMaster>1</SingleOrMaster>
          <HeliosOrderRecordID>2</HeliosOrderRecordID>
          <ItemOrKitID>11</ItemOrKitID>
          <ItemOrKitDescription>Technicolor</ItemOrKitDescription>
          <ItemOrKitQuantity>7</ItemOrKitQuantity>
          <ItemOrKitUnitOfMeasureID>1</ItemOrKitUnitOfMeasureID>
          <ItemOrKitUnitOfMeasure>KS</ItemOrKitUnitOfMeasure>
          <ItemOrKitQualityID>1</ItemOrKitQualityID>
          <ItemOrKitQuality>New</ItemOrKitQuality>
          <ItemVerKit>1</ItemVerKit>
          <IncotermID>2</IncotermID>
          <IncotermDescription>DAP</IncotermDescription>
          <RealDateOfDelivery>2014-08-29</RealDateOfDelivery>
          <RealItemOrKitQuantity>7</RealItemOrKitQuantity>
          <RealItemOrKitQualityID>1</RealItemOrKitQualityID>
          <RealItemOrKitQuality>New</RealItemOrKitQuality>
          <Status>1</Status>
          <ItemOrKitSNs>
             <ItemSN SN1=""ED4006037A"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED4006038B"" SN2=""ED50060377"" />
             <ItemSN SN1=""ED4006038C"" SN2=""ED50060378"" />
             <ItemSN SN1=""ED4006039D"" SN2=""ED50060379"" />
             <ItemSN SN1=""ED4006037A"" SN2=""ED50060376"" />
             <ItemSN SN1=""ED4006038B"" SN2=""ED50060377"" />
             <ItemSN SN1=""ED4006038C"" SN2=""ED50060378"" />
           </ItemOrKitSNs>
       </itemOrKit>
     </itemsOrKits>
  </CommunicationMessagesShipmentConfirmation>
</NewDataSet>";
		}


	}
}