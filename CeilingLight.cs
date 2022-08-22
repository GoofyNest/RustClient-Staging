public class CeilingLight : IOEntity // TypeDefIndex: 8548
{	// Fields
	public float pushScale; // 0x288

	// Methods

	// RVA: 0x531B90 Offset: 0x530190 VA: 0x180531B90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x531A20 Offset: 0x530020 VA: 0x180531A20 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x531A30 Offset: 0x530030 VA: 0x180531A30 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5317D0 Offset: 0x52FDD0 VA: 0x1805317D0
	public void ClientPhysPush(BaseEntity.RPCMessage msg) { }

	// RVA: 0x531FE0 Offset: 0x5305E0 VA: 0x180531FE0
	public void PhysPush(Vector3 attackNormal, Vector3 hitPositionWorld) { }

	// RVA: 0x531720 Offset: 0x52FD20 VA: 0x180531720 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x532150 Offset: 0x530750 VA: 0x180532150
	public void .ctor() { }

}

