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

	// RVA: 0x7933E0 Offset: 0x7919E0 VA: 0x1807933E0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 146
	public override bool get_IsGravitySource() { }

	// RVA: 0x793540 Offset: 0x791B40 VA: 0x180793540 Slot: 157
	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x7931E0 Offset: 0x7917E0 VA: 0x1807931E0 Slot: 158
	public override bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x793260 Offset: 0x791860 VA: 0x180793260 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x793520 Offset: 0x791B20 VA: 0x180793520
	public void .ctor() { }

	// RVA: 0x7934B0 Offset: 0x791AB0 VA: 0x1807934B0
	private static void .cctor() { }

}

