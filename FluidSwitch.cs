public class FluidSwitch : ElectricSwitch // TypeDefIndex: 9801
{	// Fields
	private BaseEntity.Flags Flag_PumpPowered; // 0x398
	public Animator PumpAnimator; // 0x3A0
	private static int SwitchOnParam; // 0x0
	private static int PowerParam; // 0x4

	// Properties
	public override bool IsGravitySource { get; }
	protected override bool DisregardGravityRestrictionsOnLiquid { get; }

	// Methods

	// RVA: 0x793400 Offset: 0x791A00 VA: 0x180793400 Slot: 27
	public override void ResetState() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 146
	public override bool get_IsGravitySource() { }

	// RVA: 0x793560 Offset: 0x791B60 VA: 0x180793560 Slot: 157
	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x793200 Offset: 0x791800 VA: 0x180793200 Slot: 158
	public override bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x793280 Offset: 0x791880 VA: 0x180793280 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x793540 Offset: 0x791B40 VA: 0x180793540
	public void .ctor() { }

	// RVA: 0x7934D0 Offset: 0x791AD0 VA: 0x1807934D0
	private static void .cctor() { }

}

