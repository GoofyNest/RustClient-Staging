public class TreeMarker : BaseEntity // TypeDefIndex: 8269
{	// Fields
	public GameObjectRef hitEffect; // 0x168
	public SoundDefinition hitEffectSound; // 0x170
	public GameObjectRef spawnEffect; // 0x178
	private Vector3 initialPosition; // 0x180
	public bool SpherecastOnInit; // 0x18C
	private const float markerDistSq = 900;

	// Methods

	// RVA: 0xA1EA10 Offset: 0xA1D010 VA: 0x180A1EA10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1F180 Offset: 0xA1D780 VA: 0x180A1F180 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1EA70 Offset: 0xA1D070 VA: 0x180A1EA70
	public void MarkerHit(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1F2C0 Offset: 0xA1D8C0 VA: 0x180A1F2C0
	public void UpdatePositioning() { }

	// RVA: 0xA1ED30 Offset: 0xA1D330 VA: 0x180A1ED30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1F630 Offset: 0xA1DC30 VA: 0x180A1F630
	public void .ctor() { }

}

