public class TreeManager : BaseEntity // TypeDefIndex: 8658
{	// Fields
	public static TreeManager client; // 0x0
	private static Dictionary<uint, ImpostorInstanceData> trees; // 0x8

	// Methods

	// RVA: 0xA1D880 Offset: 0xA1BE80 VA: 0x180A1D880 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1E460 Offset: 0xA1CA60 VA: 0x180A1E460
	public static Vector3 ProtoHalf3ToVec3(Half3 half3) { }

	// RVA: 0xA1E750 Offset: 0xA1CD50 VA: 0x180A1E750
	public static Half3 Vec3ToProtoHalf3(Vector3 vec3) { }

	// RVA: 0xA1D4E0 Offset: 0xA1BAE0 VA: 0x180A1D4E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1D560 Offset: 0xA1BB60 VA: 0x180A1D560 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA1E620 Offset: 0xA1CC20 VA: 0x180A1E620
	public static void Reset() { }

	// RVA: 0xA1CB00 Offset: 0xA1B100 VA: 0x180A1CB00
	public static void AddBillboard(uint id, ImpostorInstanceData data) { }

	// RVA: 0xA1E510 Offset: 0xA1CB10 VA: 0x180A1E510
	public static void RemoveBillboard(uint id) { }

	// RVA: 0xA1D7C0 Offset: 0xA1BDC0 VA: 0x180A1D7C0
	public static void HideBillboard(uint id) { }

	// RVA: 0xA1E690 Offset: 0xA1CC90 VA: 0x180A1E690
	public static void ShowBillboard(uint id) { }

	// RVA: 0xA1D5B0 Offset: 0xA1BBB0 VA: 0x180A1D5B0
	private static ImpostorInstanceData CreateImpostorInstanceData(BaseEntity entity, Vector3 position, Vector3 scale) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1CC60 Offset: 0xA1B260 VA: 0x180A1CC60
	private void CLIENT_ReceiveTrees(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1D030 Offset: 0xA1B630 VA: 0x180A1D030
	private void CLIENT_TreeDestroyed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1D1B0 Offset: 0xA1B7B0 VA: 0x180A1D1B0
	private void CLIENT_TreeSpawned(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1E870 Offset: 0xA1CE70 VA: 0x180A1E870
	public void .ctor() { }

	// RVA: 0xA1E800 Offset: 0xA1CE00 VA: 0x180A1E800
	private static void .cctor() { }

}

