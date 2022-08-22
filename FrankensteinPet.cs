public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	[HeaderAttribute] // RVA: 0xAB4D0 Offset: 0xAA8D0 VA: 0x1800AB4D0
	[ServerVar] // RVA: 0xAB4D0 Offset: 0xAA8D0 VA: 0x1800AB4D0
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x720C0 Offset: 0x714C0 VA: 0x1800720C0
	public SoundDefinition AttackVocalSFX; // 0x858


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

