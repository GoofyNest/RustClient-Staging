public class Flashbang : TimedExplosive // TypeDefIndex: 8570
{	// Fields
	public SoundDefinition deafLoopDef; // 0x1B8
	public float flashReductionPerSecond; // 0x1C0
	public float flashToAdd; // 0x1C4
	public float flashMinRange; // 0x1C8
	public float flashMaxRange; // 0x1CC
	public static float localFlashAmount; // 0x0
	private Sound deafLoop; // 0x1D0
	private SoundModulation.Modulator deafGain; // 0x1D8

	// Methods

	// RVA: 0x791D30 Offset: 0x790330 VA: 0x180791D30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x791A20 Offset: 0x790020 VA: 0x180791A20
	public void FlashFrom(Vector3 pos, float amount) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7919B0 Offset: 0x78FFB0 VA: 0x1807919B0
	public void Client_DoFlash(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7921A0 Offset: 0x7907A0 VA: 0x1807921A0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

