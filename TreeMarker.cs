public class TreeMarker : BaseEntity // TypeDefIndex: 8269
{	// Fields
	public GameObjectRef hitEffect; // 0x168
	public SoundDefinition hitEffectSound; // 0x170
	public GameObjectRef spawnEffect; // 0x178
	private Vector3 initialPosition; // 0x180
	public bool SpherecastOnInit; // 0x18C
	private const float markerDistSq = 900;

	// Methods

	// RVA: 0xA1E750 Offset: 0xA1CD50 VA: 0x180A1E750 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1EEC0 Offset: 0xA1D4C0 VA: 0x180A1EEC0 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA1E7B0 Offset: 0xA1CDB0 VA: 0x180A1E7B0
	public void MarkerHit(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1F000 Offset: 0xA1D600 VA: 0x180A1F000
	public void UpdatePositioning() { }

	// RVA: 0xA1EA70 Offset: 0xA1D070 VA: 0x180A1EA70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1F370 Offset: 0xA1D970 VA: 0x180A1F370
	public void .ctor() { }

}

