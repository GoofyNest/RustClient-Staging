public class Toolgun : Hammer // TypeDefIndex: 8655
{	// Fields
	public GameObjectRef attackEffect; // 0x2E0
	public GameObjectRef beamEffect; // 0x2E8
	public GameObjectRef beamImpactEffect; // 0x2F0
	public GameObjectRef errorEffect; // 0x2F8
	public GameObjectRef beamEffectClassic; // 0x300
	public GameObjectRef beamImpactEffectClassic; // 0x308
	public Transform muzzlePoint; // 0x310
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool classiceffects; // 0x0

	// Methods

	// RVA: 0x872340 Offset: 0x870940 VA: 0x180872340 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x871C70 Offset: 0x870270 VA: 0x180871C70 Slot: 138
	public override void OnInput() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 166
	public override void DoViewmodelImpact(HitTest test) { }

	// RVA: 0x871440 Offset: 0x86FA40 VA: 0x180871440
	public void DoTGEffect(Vector3 endPos, Vector3 endNormal) { }

	// RVA: 0x8711C0 Offset: 0x86F7C0 VA: 0x1808711C0
	public void DoAttackEffect(Vector3 endPos, Vector3 normal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871910 Offset: 0x86FF10 VA: 0x180871910
	public void EffectSpawn(BaseEntity.RPCMessage msg) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 163
	public override void ClientAttack() { }

	// RVA: 0x871280 Offset: 0x86F880 VA: 0x180871280 Slot: 160
	public override void DoAttackShared(HitInfo info) { }

	// RVA: 0x872790 Offset: 0x870D90 VA: 0x180872790
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

