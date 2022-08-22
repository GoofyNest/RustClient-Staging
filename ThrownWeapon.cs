public class ThrownWeapon : AttackEntity // TypeDefIndex: 8654
{	// Fields
	[HeaderAttribute] // RVA: 0xB6EE0 Offset: 0xB62E0 VA: 0x1800B6EE0
	public GameObjectRef prefabToThrow; // 0x280
	public float maxThrowVelocity; // 0x288
	public float tumbleVelocity; // 0x28C
	public Vector3 overrideAngle; // 0x290
	public bool canStick; // 0x29C

	// Methods

	// RVA: 0x86CCE0 Offset: 0x86B2E0 VA: 0x18086CCE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x86C910 Offset: 0x86AF10 VA: 0x18086C910 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x86C960 Offset: 0x86AF60 VA: 0x18086C960 Slot: 138
	public override void OnInput() { }

	// RVA: 0x86CDD0 Offset: 0x86B3D0 VA: 0x18086CDD0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x86CDE0 Offset: 0x86B3E0 VA: 0x18086CDE0
	public void .ctor() { }

}

