public class TorchWeapon : BaseMelee // TypeDefIndex: 8656
{	// Fields
	public float fuelTickAmount; // 0x2E0
	[HeaderAttribute] // RVA: 0xB7120 Offset: 0xB6520 VA: 0x1800B7120
	public AnimatorOverrideController LitHoldAnimationOverride; // 0x2E8
	private bool specVmWasOn; // 0x2F0
	private TimeUntil blockVmUpdates; // 0x2F4

	// Methods

	// RVA: 0xA0B250 Offset: 0xA09850 VA: 0x180A0B250 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA0AFD0 Offset: 0xA095D0 VA: 0x180A0AFD0 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0xA0B070 Offset: 0xA09670 VA: 0x180A0B070 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA0B540 Offset: 0xA09B40 VA: 0x180A0B540
	private void ToggleOn() { }

	// RVA: 0xA0B340 Offset: 0xA09940 VA: 0x180A0B340 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xA0B040 Offset: 0xA09640 VA: 0x180A0B040 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0xA0B400 Offset: 0xA09A00 VA: 0x180A0B400 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA0B5E0 Offset: 0xA09BE0 VA: 0x180A0B5E0
	public void .ctor() { }

}

