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

	// RVA: 0x791C20 Offset: 0x790220 VA: 0x180791C20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x791910 Offset: 0x78FF10 VA: 0x180791910
	public void FlashFrom(Vector3 pos, float amount) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7918A0 Offset: 0x78FEA0 VA: 0x1807918A0
	public void Client_DoFlash(BaseEntity.RPCMessage msg) { }

	// RVA: 0x792090 Offset: 0x790690 VA: 0x180792090
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

