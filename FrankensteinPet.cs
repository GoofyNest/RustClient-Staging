public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	// Fields
	[HeaderAttribute] // RVA: 0xAB4D0 Offset: 0xAA8D0 VA: 0x1800AB4D0
	[ServerVar] // RVA: 0xAB4D0 Offset: 0xAA8D0 VA: 0x1800AB4D0
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public SoundDefinition AttackVocalSFX; // 0x858

	// Methods

	// RVA: 0x7521C0 Offset: 0x7507C0 VA: 0x1807521C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x752110 Offset: 0x750710 VA: 0x180752110
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7526C0 Offset: 0x750CC0 VA: 0x1807526C0
	public void .ctor() { }

	// RVA: 0x752680 Offset: 0x750C80 VA: 0x180752680
	private static void .cctor() { }

}

