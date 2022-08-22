public class CargoShip : BaseEntity // TypeDefIndex: 8287
{	// Fields
	public int targetNodeIndex; // 0x168
	public GameObject wakeParent; // 0x170
	public GameObjectRef scientistTurretPrefab; // 0x178
	public Transform[] scientistSpawnPoints; // 0x180
	public List<Transform> crateSpawns; // 0x188
	public GameObjectRef lockedCratePrefab; // 0x190
	public GameObjectRef militaryCratePrefab; // 0x198
	public GameObjectRef eliteCratePrefab; // 0x1A0
	public GameObjectRef junkCratePrefab; // 0x1A8
	public Transform waterLine; // 0x1B0
	public Transform rudder; // 0x1B8
	public Transform propeller; // 0x1C0
	public GameObjectRef escapeBoatPrefab; // 0x1C8
	public Transform escapeBoatPoint; // 0x1D0
	public GameObjectRef microphonePrefab; // 0x1D8
	public Transform microphonePoint; // 0x1E0
	public GameObjectRef speakerPrefab; // 0x1E8
	public Transform[] speakerPoints; // 0x1F0
	public GameObject radiation; // 0x1F8
	public GameObjectRef mapMarkerEntityPrefab; // 0x200
	public GameObject hornOrigin; // 0x208
	public SoundDefinition hornDef; // 0x210
	public CargoShipSounds cargoShipSounds; // 0x218
	public GameObject[] layouts; // 0x220
	public GameObjectRef playerTest; // 0x228
	private uint layoutChoice; // 0x230
	private TimeSince timeSinceUpdatedSounds; // 0x234
	private const float updateRateDistSq = 10000;

	// Methods

	// RVA: 0x52BE80 Offset: 0x52A480 VA: 0x18052BE80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x52C3D0 Offset: 0x52A9D0 VA: 0x18052C3D0
	public void RefreshActiveLayout() { }

	// RVA: 0x52C460 Offset: 0x52AA60 VA: 0x18052C460
	public void Update() { }

	// RVA: 0x52BCD0 Offset: 0x52A2D0 VA: 0x18052BCD0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x52C340 Offset: 0x52A940 VA: 0x18052C340 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52BE40 Offset: 0x52A440 VA: 0x18052BE40
	public void DoHornSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x52BEE0 Offset: 0x52A4E0 VA: 0x18052BEE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x52C600 Offset: 0x52AC00 VA: 0x18052C600
	public void .ctor() { }

}

