public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	// Fields
	[HeaderAttribute] // RVA: 0xAB430 Offset: 0xAA830 VA: 0x1800AB430
	[ServerVar] // RVA: 0xAB430 Offset: 0xAA830 VA: 0x1800AB430
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x72010 Offset: 0x71410 VA: 0x180072010
	public SoundDefinition AttackVocalSFX; // 0x858

	// Methods

	// RVA: 0x7520B0 Offset: 0x7506B0 VA: 0x1807520B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x752000 Offset: 0x750600 VA: 0x180752000
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7525B0 Offset: 0x750BB0 VA: 0x1807525B0
	public void .ctor() { }

	// RVA: 0x752570 Offset: 0x750B70 VA: 0x180752570
	private static void .cctor() { }

}
