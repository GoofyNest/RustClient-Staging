public class BaseOven : StorageContainer, ISplashable // TypeDefIndex: 8333
{	// Fields
	private Option __menuOption_SwitchOff; // 0x3D0
	private Option __menuOption_SwitchOn; // 0x428
	public BaseOven.TemperatureType temperature; // 0x480
	public BaseEntity.Menu.Option switchOnMenu; // 0x488
	public BaseEntity.Menu.Option switchOffMenu; // 0x4A8
	public ItemAmount[] startupContents; // 0x4C8
	public bool allowByproductCreation; // 0x4D0
	public ItemDefinition fuelType; // 0x4D8
	public bool canModFire; // 0x4E0
	public bool disabledBySplash; // 0x4E1

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA51D00 Offset: 0xA50300 VA: 0x180A51D00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA52480 Offset: 0xA50A80 VA: 0x180A52480 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA52270 Offset: 0xA50870 VA: 0x180A52270 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA52250 Offset: 0xA50850 VA: 0x180A52250 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	[BaseEntity.Menu] // RVA: 0xB9E80 Offset: 0xB9280 VA: 0x1800B9E80
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9E80 Offset: 0xB9280 VA: 0x1800B9E80
	// RVA: 0xA52430 Offset: 0xA50A30 VA: 0x180A52430
	public void SwitchOn(BasePlayer player) { }

	// RVA: 0xA523F0 Offset: 0xA509F0 VA: 0x180A523F0 Slot: 155
	protected virtual bool SwitchOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB9F90 Offset: 0xB9390 VA: 0x1800B9F90
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9F90 Offset: 0xB9390 VA: 0x1800B9F90
	// RVA: 0xA523A0 Offset: 0xA509A0 VA: 0x180A523A0
	public void SwitchOff(BasePlayer player) { }

	// RVA: 0xA52360 Offset: 0xA50960 VA: 0x180A52360 Slot: 156
	protected virtual bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA3C1B0 Offset: 0xA3A7B0 VA: 0x180A3C1B0
	public void .ctor() { }

}

public enum BaseOven.TemperatureType // TypeDefIndex: 8334
{	// Fields
	public int value__; // 0x0
	public const BaseOven.TemperatureType Normal = 0;
	public const BaseOven.TemperatureType Warming = 1;
	public const BaseOven.TemperatureType Cooking = 2;
	public const BaseOven.TemperatureType Smelting = 3;
	public const BaseOven.TemperatureType Fractioning = 4;

}

