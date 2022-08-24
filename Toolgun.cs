public class Toolgun : Hammer // TypeDefIndex: 8655
{	public GameObjectRef attackEffect; // 0x2E0
	public GameObjectRef beamEffect; // 0x2E8
	public GameObjectRef beamImpactEffect; // 0x2F0
	public GameObjectRef errorEffect; // 0x2F8
	public GameObjectRef beamEffectClassic; // 0x300
	public GameObjectRef beamImpactEffectClassic; // 0x308
	public Transform muzzlePoint; // 0x310
	[ClientVar] // RVA: 0x813E0 Offset: 0x807E0 VA: 0x1800813E0
	public static bool classiceffects; // 0x0


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnInput() { }

	public override void DoViewmodelImpact(HitTest test) { }

	public void DoTGEffect(Vector3 endPos, Vector3 endNormal) { }

	public void DoAttackEffect(Vector3 endPos, Vector3 normal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void EffectSpawn(BaseEntity.RPCMessage msg) { }

	public override void ClientAttack() { }

	public override void DoAttackShared(HitInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

