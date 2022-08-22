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

	// RVA: 0x7934F0 Offset: 0x791AF0 VA: 0x1807934F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 146
	public override bool get_IsGravitySource() { }

	// RVA: 0x793650 Offset: 0x791C50 VA: 0x180793650 Slot: 157
	protected override bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x7932F0 Offset: 0x7918F0 VA: 0x1807932F0 Slot: 158
	public override bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x793370 Offset: 0x791970 VA: 0x180793370 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x793630 Offset: 0x791C30 VA: 0x180793630
	public void .ctor() { }

	// RVA: 0x7935C0 Offset: 0x791BC0 VA: 0x1807935C0
	private static void .cctor() { }

}

