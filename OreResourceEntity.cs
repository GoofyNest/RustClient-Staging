public class OreResourceEntity : StagedResourceEntity // TypeDefIndex: 8610
{	// Fields
	public GameObjectRef bonusPrefab; // 0x1A0
	public GameObjectRef finishEffect; // 0x1A8
	public GameObjectRef bonusFailEffect; // 0x1B0
	public OreHotSpot _hotSpot; // 0x1B8
	public SoundPlayer bonusSound; // 0x1C0

	// Methods

	// RVA: 0x9E7F40 Offset: 0x9E6540 VA: 0x1809E7F40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9E7F30 Offset: 0x9E6530 VA: 0x1809E7F30 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9E84D0 Offset: 0x9E6AD0 VA: 0x1809E84D0
	public void PlayBonusLevelSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9E8650 Offset: 0x9E6C50 VA: 0x1809E8650
	public Vector3 RandomCircle(float distance = 1, bool allowInside = False) { }

	// RVA: 0x9E8830 Offset: 0x9E6E30 VA: 0x1809E8830
	public Vector3 RandomHemisphereDirection(Vector3 input, float degreesOffset, bool allowInside = True, bool changeHeight = True) { }

	// RVA: 0x9E7CA0 Offset: 0x9E62A0 VA: 0x1809E7CA0
	public Vector3 ClampToHemisphere(Vector3 hemiInput, float degreesOffset, Vector3 inputVec) { }

	// RVA: 0x9E86C0 Offset: 0x9E6CC0 VA: 0x1809E86C0
	public static Vector3 RandomCylinderPointAroundVector(Vector3 input, float distance, float minHeight = 0, float maxHeight = 0, bool allowInside = False) { }

	// RVA: 0x9E7C30 Offset: 0x9E6230 VA: 0x1809E7C30
	public Vector3 ClampToCylinder(Vector3 localPos, Vector3 cylinderAxis, float cylinderDistance, float minHeight = 0, float maxHeight = 0) { }

	// RVA: 0x9E8A00 Offset: 0x9E7000 VA: 0x1809E8A00
	public void .ctor() { }

}

