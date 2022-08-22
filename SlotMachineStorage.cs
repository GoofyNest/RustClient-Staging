public class SlotMachineStorage : StorageContainer // TypeDefIndex: 8640
{	// Fields
	public int Amount; // 0x3D0

	// Methods

	// RVA: 0x5ABFF0 Offset: 0x5AA5F0 VA: 0x1805ABFF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5ABF40 Offset: 0x5AA540 VA: 0x1805ABF40
	public bool IsPlayerValid(BasePlayer player) { }

	// RVA: 0x5AC480 Offset: 0x5AAA80 VA: 0x1805AC480 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AC440 Offset: 0x5AAA40 VA: 0x1805AC440
	private void RPC_UpdateAmount(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5AC5D0 Offset: 0x5AABD0 VA: 0x1805AC5D0
	public void .ctor() { }

}

