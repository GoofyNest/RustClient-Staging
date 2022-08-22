public class ComputerStation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string bookmarks; // 0x18

	// Methods

	// RVA: 0x20B1DC0 Offset: 0x20B03C0 VA: 0x1820B1DC0
	public static void ResetToPool(ComputerStation instance) { }

	// RVA: 0x20B1E50 Offset: 0x20B0450 VA: 0x1820B1E50
	public void ResetToPool() { }

	// RVA: 0x20B1C70 Offset: 0x20B0270 VA: 0x1820B1C70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68640 Offset: 0x1D66C40 VA: 0x181D68640
	public void CopyTo(ComputerStation instance) { }

	// RVA: 0x20B12D0 Offset: 0x20AF8D0 VA: 0x1820B12D0
	public ComputerStation Copy() { }

	// RVA: 0x20B1880 Offset: 0x20AFE80 VA: 0x1820B1880
	public static ComputerStation Deserialize(Stream stream) { }

	// RVA: 0x20B1350 Offset: 0x20AF950 VA: 0x1820B1350
	public static ComputerStation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B15F0 Offset: 0x20AFBF0 VA: 0x1820B15F0
	public static ComputerStation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B1A00 Offset: 0x20B0000 VA: 0x1820B1A00
	public static ComputerStation Deserialize(byte[] buffer) { }

	// RVA: 0x20B1D80 Offset: 0x20B0380 VA: 0x1820B1D80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B22C0 Offset: 0x20B08C0 VA: 0x1820B22C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B22E0 Offset: 0x20B08E0 VA: 0x1820B22E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ComputerStation previous) { }

	// RVA: 0x20B1DA0 Offset: 0x20B03A0 VA: 0x1820B1DA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B1900 Offset: 0x20AFF00 VA: 0x1820B1900
	public static ComputerStation Deserialize(byte[] buffer, ComputerStation instance, bool isDelta = False) { }

	// RVA: 0x20B1B20 Offset: 0x20B0120 VA: 0x1820B1B20
	public static ComputerStation Deserialize(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B13D0 Offset: 0x20AF9D0 VA: 0x1820B13D0
	public static ComputerStation DeserializeLengthDelimited(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B1680 Offset: 0x20AFC80 VA: 0x1820B1680
	public static ComputerStation DeserializeLength(Stream stream, int length, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B1EE0 Offset: 0x20B04E0 VA: 0x1820B1EE0
	public static void SerializeDelta(Stream stream, ComputerStation instance, ComputerStation previous) { }

	// RVA: 0x20B21C0 Offset: 0x20B07C0 VA: 0x1820B21C0
	public static void Serialize(Stream stream, ComputerStation instance) { }

	// RVA: 0x20B22B0 Offset: 0x20B08B0 VA: 0x1820B22B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B22C0 Offset: 0x20B08C0 VA: 0x1820B22C0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B20B0 Offset: 0x20B06B0 VA: 0x1820B20B0
	public static byte[] SerializeToBytes(ComputerStation instance) { }

	// RVA: 0x20B2000 Offset: 0x20B0600 VA: 0x1820B2000
	public static void SerializeLengthDelimited(Stream stream, ComputerStation instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ComputerStation : BaseMountable // TypeDefIndex: 8562
{	// Fields
	[HeaderAttribute] // RVA: 0xAAB20 Offset: 0xA9F20 VA: 0x1800AAB20
	public GameObjectRef menuPrefab; // 0x320
	public ComputerMenu computerMenu; // 0x328
	public EntityRef currentlyControllingEnt; // 0x330
	public Dictionary<string, uint> controlBookmarks; // 0x340
	public Transform leftHandIKPosition; // 0x348
	public Transform rightHandIKPosition; // 0x350
	public SoundDefinition turnOnSoundDef; // 0x358
	public SoundDefinition turnOffSoundDef; // 0x360
	public SoundDefinition onLoopSoundDef; // 0x368
	public bool isStatic; // 0x370
	public float autoGatherRadius; // 0x374
	private Sound onLoopSound; // 0x378

	// Methods

	// RVA: 0x6D3A00 Offset: 0x6D2000 VA: 0x1806D3A00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D3680 Offset: 0x6D1C80 VA: 0x1806D3680
	public static bool IsValidIdentifier(string str) { }

	// RVA: 0x6D3240 Offset: 0x6D1840 VA: 0x1806D3240 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6D3700 Offset: 0x6D1D00 VA: 0x1806D3700 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6D3540 Offset: 0x6D1B40 VA: 0x1806D3540 Slot: 175
	public override Quaternion GetMountedRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6D43E0 Offset: 0x6D29E0 VA: 0x1806D43E0
	public void ReceiveBookmarks(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6D3FD0 Offset: 0x6D25D0 VA: 0x1806D3FD0 Slot: 177
	public override void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D34A0 Offset: 0x6D1AA0 VA: 0x1806D34A0 Slot: 146
	public override BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x6D3940 Offset: 0x6D1F40 VA: 0x1806D3940
	public void MenuShutdown() { }

	// RVA: 0x6D4140 Offset: 0x6D2740 VA: 0x1806D4140 Slot: 176
	public override void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D3460 Offset: 0x6D1A60 VA: 0x1806D3460 Slot: 149
	public override Quaternion GetMountedBodyAngles() { }

	// RVA: 0x6D3250 Offset: 0x6D1850 VA: 0x1806D3250 Slot: 154
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0x6D3960 Offset: 0x6D1F60 VA: 0x1806D3960 Slot: 150
	public override bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D33A0 Offset: 0x6D19A0 VA: 0x1806D33A0 Slot: 148
	public override Transform GetEyeOverride() { }

	// RVA: 0x6D3640 Offset: 0x6D1C40 VA: 0x1806D3640 Slot: 151
	public override Vector2 GetPitchClamp() { }

	// RVA: 0x6D3660 Offset: 0x6D1C60 VA: 0x1806D3660 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x6D4620 Offset: 0x6D2C20 VA: 0x1806D4620 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x6D4740 Offset: 0x6D2D40 VA: 0x1806D4740
	public void .ctor() { }

}

