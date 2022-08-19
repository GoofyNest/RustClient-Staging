public class Toolgun : Hammer // TypeDefIndex: 8655
{	// Fields
	public GameObjectRef attackEffect; // 0x2E0
	public GameObjectRef beamEffect; // 0x2E8
	public GameObjectRef beamImpactEffect; // 0x2F0
	public GameObjectRef errorEffect; // 0x2F8
	public GameObjectRef beamEffectClassic; // 0x300
	public GameObjectRef beamImpactEffectClassic; // 0x308
	public Transform muzzlePoint; // 0x310
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool classiceffects; // 0x0

	// Methods

	// RVA: 0x88EEF0 Offset: 0x88D4F0 VA: 0x18088EEF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x88E820 Offset: 0x88CE20 VA: 0x18088E820 Slot: 138
	public override void OnInput() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 166
	public override void DoViewmodelImpact(HitTest test) { }

	// RVA: 0x88DFF0 Offset: 0x88C5F0 VA: 0x18088DFF0
	public void DoTGEffect(Vector3 endPos, Vector3 endNormal) { }

	// RVA: 0x88DD70 Offset: 0x88C370 VA: 0x18088DD70
	public void DoAttackEffect(Vector3 endPos, Vector3 normal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x88E4C0 Offset: 0x88CAC0 VA: 0x18088E4C0
	public void EffectSpawn(BaseEntity.RPCMessage msg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 163
	public override void ClientAttack() { }

	// RVA: 0x88DE30 Offset: 0x88C430 VA: 0x18088DE30 Slot: 160
	public override void DoAttackShared(HitInfo info) { }

	// RVA: 0x88F340 Offset: 0x88D940 VA: 0x18088F340
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

