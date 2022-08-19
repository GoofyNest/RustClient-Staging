public class TreeManager : BaseEntity // TypeDefIndex: 8658
{	// Fields
	public static TreeManager client; // 0x0
	private static Dictionary<uint, ImpostorInstanceData> trees; // 0x8

	// Methods

	// RVA: 0xA1D5C0 Offset: 0xA1BBC0 VA: 0x180A1D5C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1E1A0 Offset: 0xA1C7A0 VA: 0x180A1E1A0
	public static Vector3 ProtoHalf3ToVec3(Half3 half3) { }

	// RVA: 0xA1E490 Offset: 0xA1CA90 VA: 0x180A1E490
	public static Half3 Vec3ToProtoHalf3(Vector3 vec3) { }

	// RVA: 0xA1D220 Offset: 0xA1B820 VA: 0x180A1D220 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1D2A0 Offset: 0xA1B8A0 VA: 0x180A1D2A0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA1E360 Offset: 0xA1C960 VA: 0x180A1E360
	public static void Reset() { }

	// RVA: 0xA1C840 Offset: 0xA1AE40 VA: 0x180A1C840
	public static void AddBillboard(uint id, ImpostorInstanceData data) { }

	// RVA: 0xA1E250 Offset: 0xA1C850 VA: 0x180A1E250
	public static void RemoveBillboard(uint id) { }

	// RVA: 0xA1D500 Offset: 0xA1BB00 VA: 0x180A1D500
	public static void HideBillboard(uint id) { }

	// RVA: 0xA1E3D0 Offset: 0xA1C9D0 VA: 0x180A1E3D0
	public static void ShowBillboard(uint id) { }

	// RVA: 0xA1D2F0 Offset: 0xA1B8F0 VA: 0x180A1D2F0
	private static ImpostorInstanceData CreateImpostorInstanceData(BaseEntity entity, Vector3 position, Vector3 scale) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA1C9A0 Offset: 0xA1AFA0 VA: 0x180A1C9A0
	private void CLIENT_ReceiveTrees(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA1CD70 Offset: 0xA1B370 VA: 0x180A1CD70
	private void CLIENT_TreeDestroyed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA1CEF0 Offset: 0xA1B4F0 VA: 0x180A1CEF0
	private void CLIENT_TreeSpawned(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1E5B0 Offset: 0xA1CBB0 VA: 0x180A1E5B0
	public void .ctor() { }

	// RVA: 0xA1E540 Offset: 0xA1CB40 VA: 0x180A1E540
	private static void .cctor() { }

}

