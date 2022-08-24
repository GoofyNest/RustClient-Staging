public class SlotMachinePayoutSettings : ScriptableObject // TypeDefIndex: 8750
{
	public ItemAmount SpinCost; 
	public SlotMachinePayoutSettings.PayoutInfo[] Payouts; 
	public int[] VirtualFaces; 
	public SlotMachinePayoutSettings.IndividualPayouts[] FacePayouts; 
	public int TotalStops; 
	public GameObjectRef DefaultWinEffect; 


	public void .ctor() { }

}

public struct SlotMachinePayoutSettings.PayoutInfo // TypeDefIndex: 8751
{
	public ItemAmount Item; 
	[RangeAttribute] 
	public int Result1; 
	[RangeAttribute] 
	public int Result2; 
	[RangeAttribute] 
	public int Result3; 
	public GameObjectRef OverrideWinEffect; 

}

public struct SlotMachinePayoutSettings.IndividualPayouts // TypeDefIndex: 8752
{
	public ItemAmount Item; 
	[RangeAttribute] 
	public int Result; 

}

