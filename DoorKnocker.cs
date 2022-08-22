public class DoorKnocker : BaseCombatEntity // TypeDefIndex: 8566
{	// Fields
	public Animator knocker1; // 0x240
	public Animator knocker2; // 0x248

	// Methods

	// RVA: 0xAAD530 Offset: 0xAABB30 VA: 0x180AAD530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAAD390 Offset: 0xAAB990 VA: 0x180AAD390
	public void ClientKnock(BaseEntity.RPCMessage msg) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

