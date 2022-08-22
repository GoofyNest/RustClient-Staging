public class TreeMarker : BaseEntity // TypeDefIndex: 8269
{	// Fields
	public GameObjectRef hitEffect; // 0x168
	public SoundDefinition hitEffectSound; // 0x170
	public GameObjectRef spawnEffect; // 0x178
	private Vector3 initialPosition; // 0x180
	public bool SpherecastOnInit; // 0x18C
	private const float markerDistSq = 900;

	// Methods

	// RVA: 0xA1EF00 Offset: 0xA1D500 VA: 0x180A1EF00 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1F670 Offset: 0xA1DC70 VA: 0x180A1F670 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1EF60 Offset: 0xA1D560 VA: 0x180A1EF60
	public void MarkerHit(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1F7B0 Offset: 0xA1DDB0 VA: 0x180A1F7B0
	public void UpdatePositioning() { }

	// RVA: 0xA1F220 Offset: 0xA1D820 VA: 0x180A1F220 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1FB20 Offset: 0xA1E120 VA: 0x180A1FB20
	public void .ctor() { }

}

