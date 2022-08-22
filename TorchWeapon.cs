public class TorchWeapon : BaseMelee // TypeDefIndex: 8656
{	// Fields
	public float fuelTickAmount; // 0x2E0
	[HeaderAttribute] // RVA: 0xB7120 Offset: 0xB6520 VA: 0x1800B7120
	public AnimatorOverrideController LitHoldAnimationOverride; // 0x2E8
	private bool specVmWasOn; // 0x2F0
	private TimeUntil blockVmUpdates; // 0x2F4

	// Methods

	// RVA: 0xA0AD60 Offset: 0xA09360 VA: 0x180A0AD60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA0AAE0 Offset: 0xA090E0 VA: 0x180A0AAE0 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0xA0AB80 Offset: 0xA09180 VA: 0x180A0AB80 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA0B050 Offset: 0xA09650 VA: 0x180A0B050
	private void ToggleOn() { }

	// RVA: 0xA0AE50 Offset: 0xA09450 VA: 0x180A0AE50 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xA0AB50 Offset: 0xA09150 VA: 0x180A0AB50 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0xA0AF10 Offset: 0xA09510 VA: 0x180A0AF10 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA0B0F0 Offset: 0xA096F0 VA: 0x180A0B0F0
	public void .ctor() { }

}

