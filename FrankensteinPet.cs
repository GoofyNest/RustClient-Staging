public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	// Fields
	[HeaderAttribute] // RVA: 0xAB4D0 Offset: 0xAA8D0 VA: 0x1800AB4D0
	[ServerVar] // RVA: 0xAB4D0 Offset: 0xAA8D0 VA: 0x1800AB4D0
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public SoundDefinition AttackVocalSFX; // 0x858

	// Methods

	// RVA: 0x752110 Offset: 0x750710 VA: 0x180752110 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x752060 Offset: 0x750660 VA: 0x180752060
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	// RVA: 0x752610 Offset: 0x750C10 VA: 0x180752610
	public void .ctor() { }

	// RVA: 0x7525D0 Offset: 0x750BD0 VA: 0x1807525D0
	private static void .cctor() { }

}

