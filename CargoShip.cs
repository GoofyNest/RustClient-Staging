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

	// RVA: 0x52BEF0 Offset: 0x52A4F0 VA: 0x18052BEF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x52C440 Offset: 0x52AA40 VA: 0x18052C440
	public void RefreshActiveLayout() { }

	// RVA: 0x52C4D0 Offset: 0x52AAD0 VA: 0x18052C4D0
	public void Update() { }

	// RVA: 0x52BD40 Offset: 0x52A340 VA: 0x18052BD40 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x52C3B0 Offset: 0x52A9B0 VA: 0x18052C3B0 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x52BEB0 Offset: 0x52A4B0 VA: 0x18052BEB0
	public void DoHornSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x52BF50 Offset: 0x52A550 VA: 0x18052BF50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x52C670 Offset: 0x52AC70 VA: 0x18052C670
	public void .ctor() { }

}

