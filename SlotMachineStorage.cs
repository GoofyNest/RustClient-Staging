public class SlotMachineStorage : StorageContainer // TypeDefIndex: 8640
{	// Fields
	public int Amount; // 0x3D0

	// Methods

	// RVA: 0x5AC060 Offset: 0x5AA660 VA: 0x1805AC060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5ABFB0 Offset: 0x5AA5B0 VA: 0x1805ABFB0
	public bool IsPlayerValid(BasePlayer player) { }

	// RVA: 0x5AC4F0 Offset: 0x5AAAF0 VA: 0x1805AC4F0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5AC4B0 Offset: 0x5AAAB0 VA: 0x1805AC4B0
	private void RPC_UpdateAmount(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5AC640 Offset: 0x5AAC40 VA: 0x1805AC640
	public void .ctor() { }

}

