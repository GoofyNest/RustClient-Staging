public class ThrownWeapon : AttackEntity // TypeDefIndex: 8654
{	// Fields
	[HeaderAttribute] // RVA: 0xB6EE0 Offset: 0xB62E0 VA: 0x1800B6EE0
	public GameObjectRef prefabToThrow; // 0x280
	public float maxThrowVelocity; // 0x288
	public float tumbleVelocity; // 0x28C
	public Vector3 overrideAngle; // 0x290
	public bool canStick; // 0x29C

	// Methods

	// RVA: 0x889890 Offset: 0x887E90 VA: 0x180889890 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8894C0 Offset: 0x887AC0 VA: 0x1808894C0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x889510 Offset: 0x887B10 VA: 0x180889510 Slot: 138
	public override void OnInput() { }

	// RVA: 0x889980 Offset: 0x887F80 VA: 0x180889980 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x889990 Offset: 0x887F90 VA: 0x180889990
	public void .ctor() { }

}

