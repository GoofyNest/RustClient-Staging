public class OreResourceEntity : StagedResourceEntity // TypeDefIndex: 8610
{	// Fields
	public GameObjectRef bonusPrefab; // 0x1A0
	public GameObjectRef finishEffect; // 0x1A8
	public GameObjectRef bonusFailEffect; // 0x1B0
	public OreHotSpot _hotSpot; // 0x1B8
	public SoundPlayer bonusSound; // 0x1C0

	// Methods

	// RVA: 0x9E7C80 Offset: 0x9E6280 VA: 0x1809E7C80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9E7C70 Offset: 0x9E6270 VA: 0x1809E7C70 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9E8210 Offset: 0x9E6810 VA: 0x1809E8210
	public void PlayBonusLevelSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9E8390 Offset: 0x9E6990 VA: 0x1809E8390
	public Vector3 RandomCircle(float distance = 1, bool allowInside = False) { }

	// RVA: 0x9E8570 Offset: 0x9E6B70 VA: 0x1809E8570
	public Vector3 RandomHemisphereDirection(Vector3 input, float degreesOffset, bool allowInside = True, bool changeHeight = True) { }

	// RVA: 0x9E79E0 Offset: 0x9E5FE0 VA: 0x1809E79E0
	public Vector3 ClampToHemisphere(Vector3 hemiInput, float degreesOffset, Vector3 inputVec) { }

	// RVA: 0x9E8400 Offset: 0x9E6A00 VA: 0x1809E8400
	public static Vector3 RandomCylinderPointAroundVector(Vector3 input, float distance, float minHeight = 0, float maxHeight = 0, bool allowInside = False) { }

	// RVA: 0x9E7970 Offset: 0x9E5F70 VA: 0x1809E7970
	public Vector3 ClampToCylinder(Vector3 localPos, Vector3 cylinderAxis, float cylinderDistance, float minHeight = 0, float maxHeight = 0) { }

	// RVA: 0x9E8740 Offset: 0x9E6D40 VA: 0x1809E8740
	public void .ctor() { }

}

