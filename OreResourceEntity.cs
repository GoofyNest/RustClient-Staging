public class OreResourceEntity : StagedResourceEntity // TypeDefIndex: 8610
{	// Fields
	public GameObjectRef bonusPrefab; // 0x1A0
	public GameObjectRef finishEffect; // 0x1A8
	public GameObjectRef bonusFailEffect; // 0x1B0
	public OreHotSpot _hotSpot; // 0x1B8
	public SoundPlayer bonusSound; // 0x1C0

	// Methods

	// RVA: 0x9E8430 Offset: 0x9E6A30 VA: 0x1809E8430 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9E8420 Offset: 0x9E6A20 VA: 0x1809E8420 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9E89C0 Offset: 0x9E6FC0 VA: 0x1809E89C0
	public void PlayBonusLevelSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9E8B40 Offset: 0x9E7140 VA: 0x1809E8B40
	public Vector3 RandomCircle(float distance = 1, bool allowInside = False) { }

	// RVA: 0x9E8D20 Offset: 0x9E7320 VA: 0x1809E8D20
	public Vector3 RandomHemisphereDirection(Vector3 input, float degreesOffset, bool allowInside = True, bool changeHeight = True) { }

	// RVA: 0x9E8190 Offset: 0x9E6790 VA: 0x1809E8190
	public Vector3 ClampToHemisphere(Vector3 hemiInput, float degreesOffset, Vector3 inputVec) { }

	// RVA: 0x9E8BB0 Offset: 0x9E71B0 VA: 0x1809E8BB0
	public static Vector3 RandomCylinderPointAroundVector(Vector3 input, float distance, float minHeight = 0, float maxHeight = 0, bool allowInside = False) { }

	// RVA: 0x9E8120 Offset: 0x9E6720 VA: 0x1809E8120
	public Vector3 ClampToCylinder(Vector3 localPos, Vector3 cylinderAxis, float cylinderDistance, float minHeight = 0, float maxHeight = 0) { }

	// RVA: 0x9E8EF0 Offset: 0x9E74F0 VA: 0x1809E8EF0
	public void .ctor() { }

}

