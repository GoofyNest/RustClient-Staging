public class BigWheelBettingTerminal : StorageContainer // TypeDefIndex: 8534
{	// Fields
	public BigWheelGame bigWheel; // 0x3D0
	public Vector3 seatedPlayerOffset; // 0x3D8
	public float offsetCheckRadius; // 0x3E4
	public SoundDefinition winSound; // 0x3E8
	public SoundDefinition loseSound; // 0x3F0
	public float nextSpinTime; // 0x3F8

	// Methods

	// RVA: 0x510960 Offset: 0x50EF60 VA: 0x180510960 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5108B0 Offset: 0x50EEB0 VA: 0x1805108B0
	public void OnDrawGizmos() { }

	// RVA: 0x5106D0 Offset: 0x50ECD0 VA: 0x1805106D0
	public bool IsPlayerValid(BasePlayer player) { }

	// RVA: 0x511210 Offset: 0x50F810 VA: 0x180511210 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x511410 Offset: 0x50FA10 VA: 0x180511410
	private Vector3 SoundPosition() { }

	// RVA: 0x5115E0 Offset: 0x50FBE0 VA: 0x1805115E0
	public void WinSound() { }

	// RVA: 0x510840 Offset: 0x50EE40 VA: 0x180510840
	public void LoseSound() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5111B0 Offset: 0x50F7B0 VA: 0x1805111B0
	public void SetTimeUntilNextSpin(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x511520 Offset: 0x50FB20 VA: 0x180511520
	public void WinOrLoseSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x511650 Offset: 0x50FC50 VA: 0x180511650
	public void .ctor() { }

}

