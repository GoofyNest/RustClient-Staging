public class JunkPile : BaseEntity // TypeDefIndex: 8592
{	// Fields
	public GameObjectRef sinkEffect; // 0x168
	public SpawnGroup[] spawngroups; // 0x170
	public NPCSpawner NPCSpawn; // 0x178
	private const float lifetimeMinutes = 30;
	private float sunkAmount; // 0x180

	// Methods

	// RVA: 0x67D250 Offset: 0x67B850 VA: 0x18067D250 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x67D0F0 Offset: 0x67B6F0 VA: 0x18067D0F0
	public void CLIENT_StartSink(BaseEntity.RPCMessage msg) { }

	// RVA: 0x67D7C0 Offset: 0x67BDC0 VA: 0x18067D7C0
	public void SinkThink() { }

	// RVA: 0x67D090 Offset: 0x67B690 VA: 0x18067D090
	public void .ctor() { }

}

