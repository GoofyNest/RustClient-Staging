public class TreeManager : BaseEntity // TypeDefIndex: 8658
{	// Fields
	public static TreeManager client; // 0x0
	private static Dictionary<uint, ImpostorInstanceData> trees; // 0x8

	// Methods

	// RVA: 0xA1DD70 Offset: 0xA1C370 VA: 0x180A1DD70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1E950 Offset: 0xA1CF50 VA: 0x180A1E950
	public static Vector3 ProtoHalf3ToVec3(Half3 half3) { }

	// RVA: 0xA1EC40 Offset: 0xA1D240 VA: 0x180A1EC40
	public static Half3 Vec3ToProtoHalf3(Vector3 vec3) { }

	// RVA: 0xA1D9D0 Offset: 0xA1BFD0 VA: 0x180A1D9D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1DA50 Offset: 0xA1C050 VA: 0x180A1DA50 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA1EB10 Offset: 0xA1D110 VA: 0x180A1EB10
	public static void Reset() { }

	// RVA: 0xA1CFF0 Offset: 0xA1B5F0 VA: 0x180A1CFF0
	public static void AddBillboard(uint id, ImpostorInstanceData data) { }

	// RVA: 0xA1EA00 Offset: 0xA1D000 VA: 0x180A1EA00
	public static void RemoveBillboard(uint id) { }

	// RVA: 0xA1DCB0 Offset: 0xA1C2B0 VA: 0x180A1DCB0
	public static void HideBillboard(uint id) { }

	// RVA: 0xA1EB80 Offset: 0xA1D180 VA: 0x180A1EB80
	public static void ShowBillboard(uint id) { }

	// RVA: 0xA1DAA0 Offset: 0xA1C0A0 VA: 0x180A1DAA0
	private static ImpostorInstanceData CreateImpostorInstanceData(BaseEntity entity, Vector3 position, Vector3 scale) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1D150 Offset: 0xA1B750 VA: 0x180A1D150
	private void CLIENT_ReceiveTrees(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1D520 Offset: 0xA1BB20 VA: 0x180A1D520
	private void CLIENT_TreeDestroyed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1D6A0 Offset: 0xA1BCA0 VA: 0x180A1D6A0
	private void CLIENT_TreeSpawned(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1ED60 Offset: 0xA1D360 VA: 0x180A1ED60
	public void .ctor() { }

	// RVA: 0xA1ECF0 Offset: 0xA1D2F0 VA: 0x180A1ECF0
	private static void .cctor() { }

}

