public class BigWheelBettingTerminal : StorageContainer // TypeDefIndex: 8534
{	// Fields
	public BigWheelGame bigWheel; // 0x3D0
	public Vector3 seatedPlayerOffset; // 0x3D8
	public float offsetCheckRadius; // 0x3E4
	public SoundDefinition winSound; // 0x3E8
	public SoundDefinition loseSound; // 0x3F0
	public float nextSpinTime; // 0x3F8

	// Methods

	// RVA: 0x5109D0 Offset: 0x50EFD0 VA: 0x1805109D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x510920 Offset: 0x50EF20 VA: 0x180510920
	public void OnDrawGizmos() { }

	// RVA: 0x510740 Offset: 0x50ED40 VA: 0x180510740
	public bool IsPlayerValid(BasePlayer player) { }

	// RVA: 0x511280 Offset: 0x50F880 VA: 0x180511280 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x511480 Offset: 0x50FA80 VA: 0x180511480
	private Vector3 SoundPosition() { }

	// RVA: 0x511650 Offset: 0x50FC50 VA: 0x180511650
	public void WinSound() { }

	// RVA: 0x5108B0 Offset: 0x50EEB0 VA: 0x1805108B0
	public void LoseSound() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x511220 Offset: 0x50F820 VA: 0x180511220
	public void SetTimeUntilNextSpin(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x511590 Offset: 0x50FB90 VA: 0x180511590
	public void WinOrLoseSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5116C0 Offset: 0x50FCC0 VA: 0x1805116C0
	public void .ctor() { }

}

