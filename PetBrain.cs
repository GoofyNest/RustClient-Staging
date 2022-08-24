public class PetBrain : BaseAIBrain // TypeDefIndex: 8614
{	[HeaderAttribute] // RVA: 0x72120 Offset: 0x71520 VA: 0x180072120
	public SoundDefinition CommandGivenVocalSFX; // 0xF8
	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static bool DrownInDeepWater; // 0x0
	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static bool IdleWhenOwnerOfflineOrDead; // 0x1
	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static bool IdleWhenOwnerMounted; // 0x2
	[ServerVar] // RVA: 0x81D90 Offset: 0x81190 VA: 0x180081D90
	public static float DrownTimer; // 0x4
	[ReplicatedVar] // RVA: 0xA9AF0 Offset: 0xA8EF0 VA: 0x1800A9AF0
	public static float ControlDistance; // 0x8


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnCommandGiven(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

