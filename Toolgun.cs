public class Toolgun : Hammer // TypeDefIndex: 8655
{	public GameObjectRef attackEffect; // 0x2E0
	public GameObjectRef beamEffect; // 0x2E8
	public GameObjectRef beamImpactEffect; // 0x2F0
	public GameObjectRef errorEffect; // 0x2F8
	public GameObjectRef beamEffectClassic; // 0x300
	public GameObjectRef beamImpactEffectClassic; // 0x308
	public Transform muzzlePoint; // 0x310
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool classiceffects; // 0x0


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnInput() { }

	public override void DoViewmodelImpact(HitTest test) { }

	public void DoTGEffect(Vector3 endPos, Vector3 endNormal) { }

	public void DoAttackEffect(Vector3 endPos, Vector3 normal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void EffectSpawn(BaseEntity.RPCMessage msg) { }

	public override void ClientAttack() { }

	public override void DoAttackShared(HitInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

