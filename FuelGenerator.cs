public class FuelGenerator : ContainerIOEntity // TypeDefIndex: 8394
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x378
	private Option __menuOption_Menu_TurnOn; // 0x3D0
	public int outputEnergy; // 0x428
	public float fuelPerSec; // 0x42C

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x755930 Offset: 0x753F30 VA: 0x180755930 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x756010 Offset: 0x754610 VA: 0x180756010 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x755F00 Offset: 0x754500 VA: 0x180755F00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x755E50 Offset: 0x754450 VA: 0x180755E50 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 150
	public override int ConsumptionAmount() { }

	[BaseEntity.Menu] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	[BaseEntity.Menu.Description] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	[BaseEntity.Menu.Icon] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	// RVA: 0x755EB0 Offset: 0x7544B0 VA: 0x180755EB0
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x6FDC80 Offset: 0x6FC280 VA: 0x1806FDC80
	public bool Menu_GeneratorOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	[BaseEntity.Menu.Description] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	[BaseEntity.Menu.Icon] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	[BaseEntity.Menu.ShowIf] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	// RVA: 0x755E60 Offset: 0x754460 VA: 0x180755E60
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x5B03C0 Offset: 0x5AE9C0 VA: 0x1805B03C0
	public bool Menu_GeneratorOff_ShowIf(BasePlayer player) { }

	// RVA: 0x755FF0 Offset: 0x7545F0 VA: 0x180755FF0
	public void .ctor() { }

}

