public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	[HeaderAttribute] // RVA: 0xAB520 Offset: 0xAA920 VA: 0x1800AB520
	[ServerVar] // RVA: 0xAB520 Offset: 0xAA920 VA: 0x1800AB520
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x72260 Offset: 0x71660 VA: 0x180072260
	public SoundDefinition AttackVocalSFX; // 0x858


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

