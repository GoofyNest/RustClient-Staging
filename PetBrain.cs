public class PetBrain : BaseAIBrain // TypeDefIndex: 8614
{	[HeaderAttribute] // RVA: 0x72260 Offset: 0x71660 VA: 0x180072260
	public SoundDefinition CommandGivenVocalSFX; // 0xF8
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static bool DrownInDeepWater; // 0x0
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static bool IdleWhenOwnerOfflineOrDead; // 0x1
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static bool IdleWhenOwnerMounted; // 0x2
	[ServerVar] // RVA: 0x81700 Offset: 0x80B00 VA: 0x180081700
	public static float DrownTimer; // 0x4
	[ReplicatedVar] // RVA: 0xA9C00 Offset: 0xA9000 VA: 0x1800A9C00
	public static float ControlDistance; // 0x8


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnCommandGiven(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

