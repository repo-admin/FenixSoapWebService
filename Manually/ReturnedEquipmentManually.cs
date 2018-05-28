using System;
using System.Diagnostics.CodeAnalysis;

namespace Fenix.WebService.Manually
{
	/// <summary>
	/// Hardcoded vytvoření vratky ze strany ND - message VR1
	/// </summary>
	[SuppressMessage("ReSharper", "RedundantAssignment")]
	public class ReturnedEquipmentManually
	{
	    /// <summary>
	    /// Vrací XML string pro VR1 (vratka - vrácené zařízení)
	    /// tohle message generuje ND samo o sobe = nepredchazi zadana message od nas
	    /// logistiku zajímají POUZE sériová čísla !!!
	    /// </summary>
	    /// <param name="confirmationId"></param>
	    /// <returns></returns>
	    public static string GetReturnedEquipment(int confirmationId)
		{			
			string xmlString = String.Empty;

			switch (confirmationId)
			{
				case 3:
					xmlString = ReturnedId3();
					break;
				default:
					throw new Exception("Neznámé číslo Returned Equipment - VR1");
			}

			return xmlString;			
		}

		/// <summary>
		/// Toto je reálná zpráva VR1 (od ND)
		/// </summary>
		/// <returns></returns>
		private static string ReturnedId3()
		{
			return
			    @"
			    <NewDataSet>
			      <CommunicationMessagesReturnedEquipment>
				    <ID>000000000003439</ID>
				    <MessageID>3439</MessageID>
				    <MessageTypeID>14</MessageTypeID>
				    <MessageTypeDescription>ReturnedEquipment</MessageTypeDescription>
				    <itemsOrKits>
				      <itemOrKit>
					    <ItemOrKitQualityID>2</ItemOrKitQualityID>
					    <ItemOrKitQuality>TRR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""AL000002903"" SN2="""" />
					      <ItemSN SN1=""AL000004657"" SN2="""" />
					      <ItemSN SN1=""AL000002499"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>5</ItemOrKitQualityID>
					    <ItemOrKitQuality>SCR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""AS140018531"" SN2="""" />
					      <ItemSN SN1=""AS140019767"" SN2="""" />
					      <ItemSN SN1=""AS140034450"" SN2="""" />
					      <ItemSN SN1=""AS140018487"" SN2="""" />
					      <ItemSN SN1=""AS140024819"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>2</ItemOrKitQualityID>
					    <ItemOrKitQuality>TRR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""SIEMENS4051"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>2</ItemOrKitQualityID>
					    <ItemOrKitQuality>TRR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""GIGA0003583"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>5</ItemOrKitQualityID>
					    <ItemOrKitQuality>SCR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""AL140000033"" SN2="""" />
					      <ItemSN SN1=""AL140001911"" SN2="""" />
					      <ItemSN SN1=""AL140002721"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>2</ItemOrKitQualityID>
					    <ItemOrKitQuality>TRR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""GD021130639708"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>5</ItemOrKitQualityID>
					    <ItemOrKitQuality>SCR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""KX-TSC11CXW"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>2</ItemOrKitQualityID>
					    <ItemOrKitQuality>TRR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""%0CBQF043252"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				      <itemOrKit>
					    <ItemOrKitQualityID>5</ItemOrKitQualityID>
					    <ItemOrKitQuality>SCR</ItemOrKitQuality>
					    <ReturnedFrom>INSTALLER</ReturnedFrom>
					    <ItemSNs>
					      <ItemSN SN1=""%8ICQA082484"" SN2="""" />
					      <ItemSN SN1=""%8HAQA036565"" SN2="""" />
					      <ItemSN SN1=""TG700015686"" SN2="""" />
					      <ItemSN SN1=""%8GAQA031288"" SN2="""" />
					      <ItemSN SN1=""%8HCQA062465"" SN2="""" />
					      <ItemSN SN1=""%8ICQA079365"" SN2="""" />
					      <ItemSN SN1=""%8HAQA037161"" SN2="""" />
					      <ItemSN SN1=""%8HAQA036419"" SN2="""" />
					      <ItemSN SN1=""%8IAQA067641"" SN2="""" />
					      <ItemSN SN1=""TG700014119"" SN2="""" />
					      <ItemSN SN1=""%8GAQA032759"" SN2="""" />
					      <ItemSN SN1=""%8HCQA056848"" SN2="""" />
					      <ItemSN SN1=""TG700011145"" SN2="""" />
					      <ItemSN SN1=""%8HAQA047366"" SN2="""" />
					      <ItemSN SN1=""%8HCQA058137"" SN2="""" />
					      <ItemSN SN1=""%8HAQA044738"" SN2="""" />
					      <ItemSN SN1=""%8HCQA055384"" SN2="""" />
					      <ItemSN SN1=""%8HCQA061696"" SN2="""" />
					      <ItemSN SN1=""TG700011682"" SN2="""" />
					      <ItemSN SN1=""%8HAQA037462"" SN2="""" />
					      <ItemSN SN1=""%8HCQA064450"" SN2="""" />
					      <ItemSN SN1=""%8HAQA037461"" SN2="""" />
					      <ItemSN SN1=""%8ICQA079106"" SN2="""" />
					      <ItemSN SN1=""TG700004414"" SN2="""" />
					      <ItemSN SN1=""TG700004529"" SN2="""" />
					      <ItemSN SN1=""TG700003659"" SN2="""" />
					      <ItemSN SN1=""TG700008352"" SN2="""" />
					      <ItemSN SN1=""TG700000453"" SN2="""" />
					      <ItemSN SN1=""TG700004873"" SN2="""" />
					      <ItemSN SN1=""TG700018235"" SN2="""" />
					    </ItemSNs>
				      </itemOrKit>
				    </itemsOrKits>
			      </CommunicationMessagesReturnedEquipment>
			    </NewDataSet>";
		}
		
	}
}