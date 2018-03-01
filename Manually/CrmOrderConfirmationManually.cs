using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FenixSoapWebService.Manually
{
	/// <summary>
	/// Hardcoded vytvoření potvrzení CrmOrder CrmOrderConfirmation message C1
	/// </summary>
	public class CrmOrderConfirmationManually
	{
		/// <summary>
		/// Vrací hardcoded XML string pro C1 
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		public static string GetCrmOrderConfirmation(int confirmationId)
		{
			string xmlString = String.Empty;

			switch (confirmationId)
			{
				case 1:
					xmlString = confirmationId1();
					break;
				default:
					throw new Exception("Neznámé číslo CrmOrder Confirmation - C1");
			}

			return xmlString;
		}

		private static string confirmationId1()
		{
			return
		@"<NewDataSet>
							<CommunicationMessagesCrmOrderConfirmation>
								<ID>1</ID>
								<MessageID>3728</MessageID>
								<MessageTypeID>18</MessageTypeID>
								<MessageTypeDescription>CrmOrderConfirmation</MessageTypeDescription>
								<MessageDateOfShipment>2017-04-28</MessageDateOfShipment>
								<CrmOrderID>1</CrmOrderID>
								<X_SHIPMENT_REAL>2017-05-30</X_SHIPMENT_REAL>
								<X_PARCEL_NUMBER>987654321</X_PARCEL_NUMBER>
								<X_RECONCILIATION>0</X_RECONCILIATION>
								<itemsOrKits>
									<itemOrKit>
										<L_ITEM_VER_KIT>false</L_ITEM_VER_KIT>
										<L_ITEM_OR_KIT_ID>500140256</L_ITEM_OR_KIT_ID>
										<L_ITEM_OR_KIT_DESCRIPTION>T59TSFx77-U WHITE (SPECIAL) / DBS</L_ITEM_OR_KIT_DESCRIPTION>
										<L_ITEM_OR_KIT_QUANTITY>10.000</L_ITEM_OR_KIT_QUANTITY>
										<L_ITEM_OR_KIT_QUALITY_ID>1</L_ITEM_OR_KIT_QUALITY_ID>
										<L_ITEM_OR_KIT_QUALITY>NEW</L_ITEM_OR_KIT_QUALITY>
										<L_ITEM_OR_KIT_MEASURE_ID>3</L_ITEM_OR_KIT_MEASURE_ID>
										<L_ITEM_OR_KIT_MEASURE>m</L_ITEM_OR_KIT_MEASURE>
										<ItemOrKitSNs>
											<ItemSN />
										</ItemOrKitSNs>				
									</itemOrKit>			
									<itemOrKit>
										<L_ITEM_VER_KIT>true</L_ITEM_VER_KIT>
										<L_ITEM_OR_KIT_ID>1500000005</L_ITEM_OR_KIT_ID>
										<L_ITEM_OR_KIT_DESCRIPTION>Z-CA1-SMIT CAM CI+ NEW</L_ITEM_OR_KIT_DESCRIPTION>
										<L_ITEM_OR_KIT_QUANTITY>20.000</L_ITEM_OR_KIT_QUANTITY>
										<L_ITEM_OR_KIT_QUALITY_ID>1</L_ITEM_OR_KIT_QUALITY_ID>
										<L_ITEM_OR_KIT_QUALITY>NEW</L_ITEM_OR_KIT_QUALITY>
										<L_ITEM_OR_KIT_MEASURE_ID>1</L_ITEM_OR_KIT_MEASURE_ID>
										<L_ITEM_OR_KIT_MEASURE>KS</L_ITEM_OR_KIT_MEASURE>
										<ItemOrKitSNs>
											<ItemSN SN1=""00570650993"" SN2=""014167221259""/>
											<ItemSN SN1=""00570651260"" SN2=""014167221260""/>
											<ItemSN SN1=""00570651261"" SN2=""014167221261"" />
											<ItemSN SN1=""00570651262"" SN2=""014167221262"" />
											<ItemSN SN1=""00570651263"" SN2=""014167221263"" />
											<ItemSN SN1=""00570651264"" SN2=""014167221264"" />
											<ItemSN SN1=""00570651265"" SN2=""014167221265"" />
											<ItemSN SN1=""00570651266"" SN2=""014167221266"" />
											<ItemSN SN1=""00570651269"" SN2=""014167221269"" />
											<ItemSN SN1=""00570651270"" SN2=""014167221270"" />
											<ItemSN SN1=""00570651271"" SN2=""014167221271"" />
											<ItemSN SN1=""00570651272"" SN2=""014167221272"" />
											<ItemSN SN1=""00570651273"" SN2=""014167221273"" />
											<ItemSN SN1=""00570651274"" SN2=""014167221274"" />
											<ItemSN SN1=""00570651275"" SN2=""014167221275"" />
											<ItemSN SN1=""00570651276"" SN2=""014167221276"" />
											<ItemSN SN1=""00570651277"" SN2=""014167221277"" />
											<ItemSN SN1=""00570651278"" SN2=""014167221278"" />
											<ItemSN SN1=""00570651279"" SN2=""014167221279"" />
											<ItemSN SN1=""00570651280"" SN2=""014167221280"" />
										</ItemOrKitSNs>				
									</itemOrKit>
								</itemsOrKits>
							</CommunicationMessagesCrmOrderConfirmation>
							</NewDataSet>";
		}

	}
}