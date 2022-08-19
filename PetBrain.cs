public class PetBrain : BaseAIBrain<BasePet> // TypeDefIndex: 8614
{	// Fields
	[HeaderAttribute] // RVA: 0x72010 Offset: 0x71410 VA: 0x180072010
	public SoundDefinition CommandGivenVocalSFX; // 0xF8
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool DrownInDeepWater; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool IdleWhenOwnerOfflineOrDead; // 0x1
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool IdleWhenOwnerMounted; // 0x2
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float DrownTimer; // 0x4
	[ReplicatedVar] // RVA: 0xA99C0 Offset: 0xA8DC0 VA: 0x1800A99C0
	public static float ControlDistance; // 0x8

	// Methods

	// RVA: 0x86EBA0 Offset: 0x86D1A0 VA: 0x18086EBA0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x86EAF0 Offset: 0x86D0F0 VA: 0x18086EAF0
	private void OnCommandGiven(BaseEntity.RPCMessage msg) { }

	// RVA: 0x86F0F0 Offset: 0x86D6F0 VA: 0x18086F0F0
	public void .ctor() { }

	// RVA: 0x86F060 Offset: 0x86D660 VA: 0x18086F060
	private static void .cctor() { }

}

