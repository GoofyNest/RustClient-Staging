public class PetBrain : BaseAIBrain<BasePet> // TypeDefIndex: 8614
{	// Fields
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public SoundDefinition CommandGivenVocalSFX; // 0xF8
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool DrownInDeepWater; // 0x0
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool IdleWhenOwnerOfflineOrDead; // 0x1
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool IdleWhenOwnerMounted; // 0x2
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static float DrownTimer; // 0x4
	[ReplicatedVar] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	public static float ControlDistance; // 0x8

	// Methods

	// RVA: 0x86EBA0 Offset: 0x86D1A0 VA: 0x18086EBA0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x86EAF0 Offset: 0x86D0F0 VA: 0x18086EAF0
	private void OnCommandGiven(BaseEntity.RPCMessage msg) { }

	// RVA: 0x86F0F0 Offset: 0x86D6F0 VA: 0x18086F0F0
	public void .ctor() { }

	// RVA: 0x86F060 Offset: 0x86D660 VA: 0x18086F060
	private static void .cctor() { }

}

