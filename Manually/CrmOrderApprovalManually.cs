using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FenixSoapWebService.Manually
{
	/// <summary>
	/// Hardcoded vytvoření odsouhlasení CrmOrder CrmOrderApproval message C2
	/// </summary>
	public class CrmOrderApprovalManually
	{
		/// <summary>
		/// Vrací hardcoded XML string pro C2 
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		public static string GetCrmOrderApproval(int approvalId)
		{
			string xmlString = String.Empty;

			switch (approvalId)
			{
				case 1:
					xmlString = approvalId1();
					break;
				case 2:
					xmlString = approvalId2();
					break;
				default:
					throw new Exception("Neznámé číslo CrmOrder Approval - C2");
			}

			return xmlString;
		}

		/// <summary>
		/// Vlastní vytvoření hardcoded XML stringu C2
		/// </summary>
		/// <returns></returns>
		private static string approvalId1()
		{
			return		
			@"<NewDataSet>
				<CommunicationMessagesCrmOrderApproval>
					<ID>1</ID>
					<MessageID>3728</MessageID>
					<MessageTypeID>19</MessageTypeID>
					<MessageTypeDescription>CrmOrderApproval</MessageTypeDescription>
					<MessageDateOfShipment>2017-05-09</MessageDateOfShipment>
					<CrmOrderID>1</CrmOrderID>
					<X_SHIPMENT_REAL>2017-05-31</X_SHIPMENT_REAL>
					<X_PARCEL_NUMBER>987654321</X_PARCEL_NUMBER>
					<X_PARCEL_WEIGHT>5.40</X_PARCEL_WEIGHT>
					<X_DELIVERY>true</X_DELIVERY>
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
								<ItemSN SN1=""00570650993"" SN2=""014167221259"" />
								<ItemSN SN1=""00570651260"" SN2=""014167221260"" />
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
				</CommunicationMessagesCrmOrderApproval>
			</NewDataSet>";
		}

		/// <summary>
		/// Vlastní vytvoření hardcoded XML stringu C2
		/// </summary>
		/// <returns></returns>
		private static string approvalId2()
		{
			return
					@"<NewDataSet>
							<CommunicationMessagesCrmOrderApproval>
								<ID>13729</ID>
								<MessageID>3729</MessageID>
								<MessageTypeID>19</MessageTypeID>
								<MessageTypeDescription>CrmOrderApproval</MessageTypeDescription>
								<MessageDateOfShipment>2017-05-09</MessageDateOfShipment>
								<CrmOrderID>2</CrmOrderID>
								<X_SHIPMENT_REAL>2017-05-31</X_SHIPMENT_REAL>
								<X_PARCEL_NUMBER>987654321</X_PARCEL_NUMBER>
								<X_PARCEL_WEIGHT>5.40</X_PARCEL_WEIGHT>
								<X_DELIVERY>true</X_DELIVERY>
								<X_RECONCILIATION>0</X_RECONCILIATION>
								<itemsOrKits>
									<itemOrKit>
											<L_ITEM_VER_KIT>false</L_ITEM_VER_KIT>
											<L_ITEM_OR_KIT_ID>590370110</L_ITEM_OR_KIT_ID>
											<L_ITEM_OR_KIT_DESCRIPTION>Krabicka  UW1</L_ITEM_OR_KIT_DESCRIPTION>
											<L_ITEM_OR_KIT_QUANTITY>5</L_ITEM_OR_KIT_QUANTITY>
											<L_ITEM_OR_KIT_QUALITY_ID>1</L_ITEM_OR_KIT_QUALITY_ID>
											<L_ITEM_OR_KIT_QUALITY>NEW</L_ITEM_OR_KIT_QUALITY>
											<L_ITEM_OR_KIT_MEASURE_ID>1</L_ITEM_OR_KIT_MEASURE_ID>
											<L_ITEM_OR_KIT_MEASURE>KS</L_ITEM_OR_KIT_MEASURE>
									</itemOrKit>
									<ItemOrKitSNs />
								</itemsOrKits>
							</CommunicationMessagesCrmOrderApproval>
					</NewDataSet>";
		}
	}
}