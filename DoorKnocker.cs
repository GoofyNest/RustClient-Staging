public class DoorKnocker : BaseCombatEntity // TypeDefIndex: 8566
{	public Animator knocker1; // 0x240
	public Animator knocker2; // 0x248


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void ClientKnock(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

