public class FuelGenerator : ContainerIOEntity // TypeDefIndex: 8394
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x378
	private Option __menuOption_Menu_TurnOn; // 0x3D0
	public int outputEnergy; // 0x428
	public float fuelPerSec; // 0x42C

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7559E0 Offset: 0x753FE0 VA: 0x1807559E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7560C0 Offset: 0x7546C0 VA: 0x1807560C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x755FB0 Offset: 0x7545B0 VA: 0x180755FB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x755F00 Offset: 0x754500 VA: 0x180755F00 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 150
	public override int ConsumptionAmount() { }

	[BaseEntity.Menu] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	[BaseEntity.Menu.Description] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	[BaseEntity.Menu.Icon] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE06C0 Offset: 0xDFAC0 VA: 0x1800E06C0
	// RVA: 0x755F60 Offset: 0x754560 VA: 0x180755F60
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x6FDD30 Offset: 0x6FC330 VA: 0x1806FDD30
	public bool Menu_GeneratorOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	[BaseEntity.Menu.Description] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	[BaseEntity.Menu.Icon] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	[BaseEntity.Menu.ShowIf] // RVA: 0xE0B00 Offset: 0xDFF00 VA: 0x1800E0B00
	// RVA: 0x755F10 Offset: 0x754510 VA: 0x180755F10
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x5B0430 Offset: 0x5AEA30 VA: 0x1805B0430
	public bool Menu_GeneratorOff_ShowIf(BasePlayer player) { }

	// RVA: 0x7560A0 Offset: 0x7546A0 VA: 0x1807560A0
	public void .ctor() { }

}

