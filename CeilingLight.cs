public class CeilingLight : IOEntity // TypeDefIndex: 8548
{	public float pushScale; // 0x288


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override int ConsumptionAmount() { }

	public override void OnAttacked(HitInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void ClientPhysPush(BaseEntity.RPCMessage msg) { }

	public void PhysPush(Vector3 attackNormal, Vector3 hitPositionWorld) { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

}

