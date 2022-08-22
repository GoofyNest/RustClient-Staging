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

	// RVA: 0xA51830 Offset: 0xA4FE30 VA: 0x180A51830 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA51FB0 Offset: 0xA505B0 VA: 0x180A51FB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA51DA0 Offset: 0xA503A0 VA: 0x180A51DA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA51D80 Offset: 0xA50380 VA: 0x180A51D80 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	[BaseEntity.Menu] // RVA: 0xB9E80 Offset: 0xB9280 VA: 0x1800B9E80
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9E80 Offset: 0xB9280 VA: 0x1800B9E80
	// RVA: 0xA51F60 Offset: 0xA50560 VA: 0x180A51F60
	public void SwitchOn(BasePlayer player) { }

	// RVA: 0xA51F20 Offset: 0xA50520 VA: 0x180A51F20 Slot: 155
	protected virtual bool SwitchOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB9F90 Offset: 0xB9390 VA: 0x1800B9F90
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9F90 Offset: 0xB9390 VA: 0x1800B9F90
	// RVA: 0xA51ED0 Offset: 0xA504D0 VA: 0x180A51ED0
	public void SwitchOff(BasePlayer player) { }

	// RVA: 0xA51E90 Offset: 0xA50490 VA: 0x180A51E90 Slot: 156
	protected virtual bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA3BCC0 Offset: 0xA3A2C0 VA: 0x180A3BCC0
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

