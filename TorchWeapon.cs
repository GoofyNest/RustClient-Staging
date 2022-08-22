public class TorchWeapon : BaseMelee // TypeDefIndex: 8656
{	// Fields
	public float fuelTickAmount; // 0x2E0
	[HeaderAttribute] // RVA: 0xB7120 Offset: 0xB6520 VA: 0x1800B7120
	public AnimatorOverrideController LitHoldAnimationOverride; // 0x2E8
	private bool specVmWasOn; // 0x2F0
	private TimeUntil blockVmUpdates; // 0x2F4

	// Methods

	// RVA: 0xA0AAA0 Offset: 0xA090A0 VA: 0x180A0AAA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA0A820 Offset: 0xA08E20 VA: 0x180A0A820 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0xA0A8C0 Offset: 0xA08EC0 VA: 0x180A0A8C0 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA0AD90 Offset: 0xA09390 VA: 0x180A0AD90
	private void ToggleOn() { }

	// RVA: 0xA0AB90 Offset: 0xA09190 VA: 0x180A0AB90 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xA0A890 Offset: 0xA08E90 VA: 0x180A0A890 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0xA0AC50 Offset: 0xA09250 VA: 0x180A0AC50 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA0AE30 Offset: 0xA09430 VA: 0x180A0AE30
	public void .ctor() { }

}

