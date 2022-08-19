public class ElectricBattery : IOEntity, IInstanceDataReceiver // TypeDefIndex: 8700
{	// Fields
	public int maxOutput; // 0x288
	public float maxCapactiySeconds; // 0x28C
	public float rustWattSeconds; // 0x290
	private int activeDrain; // 0x294
	public bool rechargable; // 0x298
	[TooltipAttribute] // RVA: 0xBC260 Offset: 0xBB660 VA: 0x1800BC260
	public float maximumInboundEnergyRatio; // 0x29C
	public float chargeRatio; // 0x2A0
	private const float tickRateSeconds = 1;
	public const BaseEntity.Flags Flag_HalfFull = 2048;
	public const BaseEntity.Flags Flag_VeryFull = 16384;

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xABFF00 Offset: 0xABE500 VA: 0x180ABFF00 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0xABFE70 Offset: 0xABE470 VA: 0x180ABFE70
	public int GetActiveDrain() { }

	// RVA: 0xABFF10 Offset: 0xABE510 VA: 0x180ABFF10 Slot: 155
	public override void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 159
	public void ReceiveInstanceData(Item.InstanceData data) { }

	// RVA: 0xABFEA0 Offset: 0xABE4A0 VA: 0x180ABFEA0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xABFF70 Offset: 0xABE570 VA: 0x180ABFF70
	public void .ctor() { }

}

