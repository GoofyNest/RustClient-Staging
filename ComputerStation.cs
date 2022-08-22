public class ComputerStation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string bookmarks; // 0x18

	// Methods

	// RVA: 0x20B15A0 Offset: 0x20AFBA0 VA: 0x1820B15A0
	public static void ResetToPool(ComputerStation instance) { }

	// RVA: 0x20B1630 Offset: 0x20AFC30 VA: 0x1820B1630
	public void ResetToPool() { }

	// RVA: 0x20B1450 Offset: 0x20AFA50 VA: 0x1820B1450 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67E50 Offset: 0x1D66450 VA: 0x181D67E50
	public void CopyTo(ComputerStation instance) { }

	// RVA: 0x20B0AB0 Offset: 0x20AF0B0 VA: 0x1820B0AB0
	public ComputerStation Copy() { }

	// RVA: 0x20B1060 Offset: 0x20AF660 VA: 0x1820B1060
	public static ComputerStation Deserialize(Stream stream) { }

	// RVA: 0x20B0B30 Offset: 0x20AF130 VA: 0x1820B0B30
	public static ComputerStation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B0DD0 Offset: 0x20AF3D0 VA: 0x1820B0DD0
	public static ComputerStation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B11E0 Offset: 0x20AF7E0 VA: 0x1820B11E0
	public static ComputerStation Deserialize(byte[] buffer) { }

	// RVA: 0x20B1560 Offset: 0x20AFB60 VA: 0x1820B1560
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B1AA0 Offset: 0x20B00A0 VA: 0x1820B1AA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B1AC0 Offset: 0x20B00C0 VA: 0x1820B1AC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ComputerStation previous) { }

	// RVA: 0x20B1580 Offset: 0x20AFB80 VA: 0x1820B1580 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B10E0 Offset: 0x20AF6E0 VA: 0x1820B10E0
	public static ComputerStation Deserialize(byte[] buffer, ComputerStation instance, bool isDelta = False) { }

	// RVA: 0x20B1300 Offset: 0x20AF900 VA: 0x1820B1300
	public static ComputerStation Deserialize(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B0BB0 Offset: 0x20AF1B0 VA: 0x1820B0BB0
	public static ComputerStation DeserializeLengthDelimited(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B0E60 Offset: 0x20AF460 VA: 0x1820B0E60
	public static ComputerStation DeserializeLength(Stream stream, int length, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B16C0 Offset: 0x20AFCC0 VA: 0x1820B16C0
	public static void SerializeDelta(Stream stream, ComputerStation instance, ComputerStation previous) { }

	// RVA: 0x20B19A0 Offset: 0x20AFFA0 VA: 0x1820B19A0
	public static void Serialize(Stream stream, ComputerStation instance) { }

	// RVA: 0x20B1A90 Offset: 0x20B0090 VA: 0x1820B1A90
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B1AA0 Offset: 0x20B00A0 VA: 0x1820B1AA0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B1890 Offset: 0x20AFE90 VA: 0x1820B1890
	public static byte[] SerializeToBytes(ComputerStation instance) { }

	// RVA: 0x20B17E0 Offset: 0x20AFDE0 VA: 0x1820B17E0
	public static void SerializeLengthDelimited(Stream stream, ComputerStation instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x6D3A70 Offset: 0x6D2070 VA: 0x1806D3A70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D36F0 Offset: 0x6D1CF0 VA: 0x1806D36F0
	public static bool IsValidIdentifier(string str) { }

	// RVA: 0x6D32B0 Offset: 0x6D18B0 VA: 0x1806D32B0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6D3770 Offset: 0x6D1D70 VA: 0x1806D3770 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6D35B0 Offset: 0x6D1BB0 VA: 0x1806D35B0 Slot: 175
	public override Quaternion GetMountedRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6D4450 Offset: 0x6D2A50 VA: 0x1806D4450
	public void ReceiveBookmarks(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6D4040 Offset: 0x6D2640 VA: 0x1806D4040 Slot: 177
	public override void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D3510 Offset: 0x6D1B10 VA: 0x1806D3510 Slot: 146
	public override BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x6D39B0 Offset: 0x6D1FB0 VA: 0x1806D39B0
	public void MenuShutdown() { }

	// RVA: 0x6D41B0 Offset: 0x6D27B0 VA: 0x1806D41B0 Slot: 176
	public override void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D34D0 Offset: 0x6D1AD0 VA: 0x1806D34D0 Slot: 149
	public override Quaternion GetMountedBodyAngles() { }

	// RVA: 0x6D32C0 Offset: 0x6D18C0 VA: 0x1806D32C0 Slot: 154
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0x6D39D0 Offset: 0x6D1FD0 VA: 0x1806D39D0 Slot: 150
	public override bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D3410 Offset: 0x6D1A10 VA: 0x1806D3410 Slot: 148
	public override Transform GetEyeOverride() { }

	// RVA: 0x6D36B0 Offset: 0x6D1CB0 VA: 0x1806D36B0 Slot: 151
	public override Vector2 GetPitchClamp() { }

	// RVA: 0x6D36D0 Offset: 0x6D1CD0 VA: 0x1806D36D0 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x6D4690 Offset: 0x6D2C90 VA: 0x1806D4690 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x6D47B0 Offset: 0x6D2DB0 VA: 0x1806D47B0
	public void .ctor() { }

}

