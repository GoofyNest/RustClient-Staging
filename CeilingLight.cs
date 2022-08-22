public class CeilingLight : IOEntity // TypeDefIndex: 8548
{	// Fields
	public float pushScale; // 0x288

	// Methods

	// RVA: 0x531C00 Offset: 0x530200 VA: 0x180531C00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x531A90 Offset: 0x530090 VA: 0x180531A90 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x531AA0 Offset: 0x5300A0 VA: 0x180531AA0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x531840 Offset: 0x52FE40 VA: 0x180531840
	public void ClientPhysPush(BaseEntity.RPCMessage msg) { }

	// RVA: 0x532050 Offset: 0x530650 VA: 0x180532050
	public void PhysPush(Vector3 attackNormal, Vector3 hitPositionWorld) { }

	// RVA: 0x531790 Offset: 0x52FD90 VA: 0x180531790 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5321C0 Offset: 0x5307C0 VA: 0x1805321C0
	public void .ctor() { }

}

