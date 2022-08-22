public class JunkPile : BaseEntity // TypeDefIndex: 8592
{	// Fields
	public GameObjectRef sinkEffect; // 0x168
	public SpawnGroup[] spawngroups; // 0x170
	public NPCSpawner NPCSpawn; // 0x178
	private const float lifetimeMinutes = 30;
	private float sunkAmount; // 0x180

	// Methods

	// RVA: 0x67D2C0 Offset: 0x67B8C0 VA: 0x18067D2C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x67D160 Offset: 0x67B760 VA: 0x18067D160
	public void CLIENT_StartSink(BaseEntity.RPCMessage msg) { }

	// RVA: 0x67D830 Offset: 0x67BE30 VA: 0x18067D830
	public void SinkThink() { }

	// RVA: 0x67D100 Offset: 0x67B700 VA: 0x18067D100
	public void .ctor() { }

}

