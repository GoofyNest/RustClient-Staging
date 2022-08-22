public class ThrownWeapon : AttackEntity // TypeDefIndex: 8654
{	// Fields
	[HeaderAttribute] // RVA: 0xB6EE0 Offset: 0xB62E0 VA: 0x1800B6EE0
	public GameObjectRef prefabToThrow; // 0x280
	public float maxThrowVelocity; // 0x288
	public float tumbleVelocity; // 0x28C
	public Vector3 overrideAngle; // 0x290
	public bool canStick; // 0x29C

	// Methods

	// RVA: 0x8899A0 Offset: 0x887FA0 VA: 0x1808899A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8895D0 Offset: 0x887BD0 VA: 0x1808895D0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x889620 Offset: 0x887C20 VA: 0x180889620 Slot: 138
	public override void OnInput() { }

	// RVA: 0x889A90 Offset: 0x888090 VA: 0x180889A90 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x889AA0 Offset: 0x8880A0 VA: 0x180889AA0
	public void .ctor() { }

}

