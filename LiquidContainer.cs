public class LiquidContainer : ContainerIOEntity // TypeDefIndex: 8404
{	// Fields
	private Option __menuOption_MenuDrink; // 0x378
	public ItemDefinition defaultLiquid; // 0x3D0
	public int startingAmount; // 0x3D8
	public bool autofillOutputs; // 0x3DC
	public float autofillTickRate; // 0x3E0
	public int autofillTickAmount; // 0x3E4
	public int maxOutputFlow; // 0x3E8
	public ItemDefinition[] ValidItems; // 0x3F0

	// Properties
	public override bool HasMenuOptions { get; }
	public override bool IsGravitySource { get; }
	protected override bool DisregardGravityRestrictionsOnLiquid { get; }

	// Methods

	// RVA: 0x4F3870 Offset: 0x4F1E70 VA: 0x1804F3870 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4F3DB0 Offset: 0x4F23B0 VA: 0x1804F3DB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x4F3C50 Offset: 0x4F2250 VA: 0x1804F3C50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 146
	public override bool get_IsGravitySource() { }

	// RVA: 0x4F3D70 Offset: 0x4F2370 VA: 0x1804F3D70 Slot: 157
	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	[BaseEntity.Menu] // RVA: 0xEA3E0 Offset: 0xE97E0 VA: 0x1800EA3E0
	[BaseEntity.Menu.Description] // RVA: 0xEA3E0 Offset: 0xE97E0 VA: 0x1800EA3E0
	[BaseEntity.Menu.Icon] // RVA: 0xEA3E0 Offset: 0xE97E0 VA: 0x1800EA3E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xEA3E0 Offset: 0xE97E0 VA: 0x1800EA3E0
	// RVA: 0x4F3C10 Offset: 0x4F2210 VA: 0x1804F3C10
	public void MenuDrink(BasePlayer player) { }

	// RVA: 0x4F3B90 Offset: 0x4F2190 VA: 0x1804F3B90 Slot: 167
	public virtual bool MenuDrink_ShowIf(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 168
	public virtual bool DrinkEligable(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 169
	public virtual bool CanDrainIntoVessel(BasePlayer player) { }

	// RVA: 0x4F3D40 Offset: 0x4F2340 VA: 0x1804F3D40
	public void .ctor() { }

}

