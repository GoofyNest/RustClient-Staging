public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	[HeaderAttribute] // RVA: 0xAB5E0 Offset: 0xAA9E0 VA: 0x1800AB5E0
	[ServerVar] // RVA: 0xAB5E0 Offset: 0xAA9E0 VA: 0x1800AB5E0
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x72120 Offset: 0x71520 VA: 0x180072120
	public SoundDefinition AttackVocalSFX; // 0x858


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

