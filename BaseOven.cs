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

	// RVA: 0xA51570 Offset: 0xA4FB70 VA: 0x180A51570 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA51CF0 Offset: 0xA502F0 VA: 0x180A51CF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA51AE0 Offset: 0xA500E0 VA: 0x180A51AE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA51AC0 Offset: 0xA500C0 VA: 0x180A51AC0 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	[BaseEntity.Menu] // RVA: 0xB9DE0 Offset: 0xB91E0 VA: 0x1800B9DE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9DE0 Offset: 0xB91E0 VA: 0x1800B9DE0
	// RVA: 0xA51CA0 Offset: 0xA502A0 VA: 0x180A51CA0
	public void SwitchOn(BasePlayer player) { }

	// RVA: 0xA51C60 Offset: 0xA50260 VA: 0x180A51C60 Slot: 155
	protected virtual bool SwitchOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB9F30 Offset: 0xB9330 VA: 0x1800B9F30
	[BaseEntity.Menu.ShowIf] // RVA: 0xB9F30 Offset: 0xB9330 VA: 0x1800B9F30
	// RVA: 0xA51C10 Offset: 0xA50210 VA: 0x180A51C10
	public void SwitchOff(BasePlayer player) { }

	// RVA: 0xA51BD0 Offset: 0xA501D0 VA: 0x180A51BD0 Slot: 156
	protected virtual bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA3BA00 Offset: 0xA3A000 VA: 0x180A3BA00
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

