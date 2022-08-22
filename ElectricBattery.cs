public class ElectricBattery : IOEntity, IInstanceDataReceiver // TypeDefIndex: 8700
{	// Fields
	public int maxOutput; // 0x288
	public float maxCapactiySeconds; // 0x28C
	public float rustWattSeconds; // 0x290
	private int activeDrain; // 0x294
	public bool rechargable; // 0x298
	[TooltipAttribute] // RVA: 0xBC360 Offset: 0xBB760 VA: 0x1800BC360
	public float maximumInboundEnergyRatio; // 0x29C
	public float chargeRatio; // 0x2A0
	private const float tickRateSeconds = 1;
	public const BaseEntity.Flags Flag_HalfFull = 2048;
	public const BaseEntity.Flags Flag_VeryFull = 16384;

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xAC0690 Offset: 0xABEC90 VA: 0x180AC0690 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0xAC0600 Offset: 0xABEC00 VA: 0x180AC0600
	public int GetActiveDrain() { }

	// RVA: 0xAC06A0 Offset: 0xABECA0 VA: 0x180AC06A0 Slot: 155
	public override void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 159
	public void ReceiveInstanceData(Item.InstanceData data) { }

	// RVA: 0xAC0630 Offset: 0xABEC30 VA: 0x180AC0630 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC0700 Offset: 0xABED00 VA: 0x180AC0700
	public void .ctor() { }

}

