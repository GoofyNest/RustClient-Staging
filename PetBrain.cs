public class PetBrain : BaseAIBrain // TypeDefIndex: 8614
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

	// RVA: 0x88A410 Offset: 0x888A10 VA: 0x18088A410 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88A360 Offset: 0x888960 VA: 0x18088A360
	private void OnCommandGiven(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4A0A50 Offset: 0x49F050 VA: 0x1804A0A50
	public void .ctor() { }

	// RVA: 0x88A8D0 Offset: 0x888ED0 VA: 0x18088A8D0
	private static void .cctor() { }

}

