public class ComputerStation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string bookmarks; // 0x18

	// Methods

	// RVA: 0x20B12E0 Offset: 0x20AF8E0 VA: 0x1820B12E0
	public static void ResetToPool(ComputerStation instance) { }

	// RVA: 0x20B1370 Offset: 0x20AF970 VA: 0x1820B1370
	public void ResetToPool() { }

	// RVA: 0x20B1190 Offset: 0x20AF790 VA: 0x1820B1190 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67B90 Offset: 0x1D66190 VA: 0x181D67B90
	public void CopyTo(ComputerStation instance) { }

	// RVA: 0x20B07F0 Offset: 0x20AEDF0 VA: 0x1820B07F0
	public ComputerStation Copy() { }

	// RVA: 0x20B0DA0 Offset: 0x20AF3A0 VA: 0x1820B0DA0
	public static ComputerStation Deserialize(Stream stream) { }

	// RVA: 0x20B0870 Offset: 0x20AEE70 VA: 0x1820B0870
	public static ComputerStation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B0B10 Offset: 0x20AF110 VA: 0x1820B0B10
	public static ComputerStation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B0F20 Offset: 0x20AF520 VA: 0x1820B0F20
	public static ComputerStation Deserialize(byte[] buffer) { }

	// RVA: 0x20B12A0 Offset: 0x20AF8A0 VA: 0x1820B12A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B17E0 Offset: 0x20AFDE0 VA: 0x1820B17E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B1800 Offset: 0x20AFE00 VA: 0x1820B1800 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ComputerStation previous) { }

	// RVA: 0x20B12C0 Offset: 0x20AF8C0 VA: 0x1820B12C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B0E20 Offset: 0x20AF420 VA: 0x1820B0E20
	public static ComputerStation Deserialize(byte[] buffer, ComputerStation instance, bool isDelta = False) { }

	// RVA: 0x20B1040 Offset: 0x20AF640 VA: 0x1820B1040
	public static ComputerStation Deserialize(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B08F0 Offset: 0x20AEEF0 VA: 0x1820B08F0
	public static ComputerStation DeserializeLengthDelimited(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B0BA0 Offset: 0x20AF1A0 VA: 0x1820B0BA0
	public static ComputerStation DeserializeLength(Stream stream, int length, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B1400 Offset: 0x20AFA00 VA: 0x1820B1400
	public static void SerializeDelta(Stream stream, ComputerStation instance, ComputerStation previous) { }

	// RVA: 0x20B16E0 Offset: 0x20AFCE0 VA: 0x1820B16E0
	public static void Serialize(Stream stream, ComputerStation instance) { }

	// RVA: 0x20B17D0 Offset: 0x20AFDD0 VA: 0x1820B17D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B17E0 Offset: 0x20AFDE0 VA: 0x1820B17E0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B15D0 Offset: 0x20AFBD0 VA: 0x1820B15D0
	public static byte[] SerializeToBytes(ComputerStation instance) { }

	// RVA: 0x20B1520 Offset: 0x20AFB20 VA: 0x1820B1520
	public static void SerializeLengthDelimited(Stream stream, ComputerStation instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x6D3960 Offset: 0x6D1F60 VA: 0x1806D3960 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D35E0 Offset: 0x6D1BE0 VA: 0x1806D35E0
	public static bool IsValidIdentifier(string str) { }

	// RVA: 0x6D31A0 Offset: 0x6D17A0 VA: 0x1806D31A0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6D3660 Offset: 0x6D1C60 VA: 0x1806D3660 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6D34A0 Offset: 0x6D1AA0 VA: 0x1806D34A0 Slot: 175
	public override Quaternion GetMountedRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6D4340 Offset: 0x6D2940 VA: 0x1806D4340
	public void ReceiveBookmarks(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6D3F30 Offset: 0x6D2530 VA: 0x1806D3F30 Slot: 177
	public override void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D3400 Offset: 0x6D1A00 VA: 0x1806D3400 Slot: 146
	public override BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x6D38A0 Offset: 0x6D1EA0 VA: 0x1806D38A0
	public void MenuShutdown() { }

	// RVA: 0x6D40A0 Offset: 0x6D26A0 VA: 0x1806D40A0 Slot: 176
	public override void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D33C0 Offset: 0x6D19C0 VA: 0x1806D33C0 Slot: 149
	public override Quaternion GetMountedBodyAngles() { }

	// RVA: 0x6D31B0 Offset: 0x6D17B0 VA: 0x1806D31B0 Slot: 154
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0x6D38C0 Offset: 0x6D1EC0 VA: 0x1806D38C0 Slot: 150
	public override bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D3300 Offset: 0x6D1900 VA: 0x1806D3300 Slot: 148
	public override Transform GetEyeOverride() { }

	// RVA: 0x6D35A0 Offset: 0x6D1BA0 VA: 0x1806D35A0 Slot: 151
	public override Vector2 GetPitchClamp() { }

	// RVA: 0x6D35C0 Offset: 0x6D1BC0 VA: 0x1806D35C0 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x6D4580 Offset: 0x6D2B80 VA: 0x1806D4580 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x6D46A0 Offset: 0x6D2CA0 VA: 0x1806D46A0
	public void .ctor() { }

}

