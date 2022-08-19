public class ComputerStation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string bookmarks; // 0x18

	// Methods

	// RVA: 0x20B14A0 Offset: 0x20AFAA0 VA: 0x1820B14A0
	public static void ResetToPool(ComputerStation instance) { }

	// RVA: 0x20B1530 Offset: 0x20AFB30 VA: 0x1820B1530
	public void ResetToPool() { }

	// RVA: 0x20B1350 Offset: 0x20AF950 VA: 0x1820B1350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67D50 Offset: 0x1D66350 VA: 0x181D67D50
	public void CopyTo(ComputerStation instance) { }

	// RVA: 0x20B09B0 Offset: 0x20AEFB0 VA: 0x1820B09B0
	public ComputerStation Copy() { }

	// RVA: 0x20B0F60 Offset: 0x20AF560 VA: 0x1820B0F60
	public static ComputerStation Deserialize(Stream stream) { }

	// RVA: 0x20B0A30 Offset: 0x20AF030 VA: 0x1820B0A30
	public static ComputerStation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B0CD0 Offset: 0x20AF2D0 VA: 0x1820B0CD0
	public static ComputerStation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B10E0 Offset: 0x20AF6E0 VA: 0x1820B10E0
	public static ComputerStation Deserialize(byte[] buffer) { }

	// RVA: 0x20B1460 Offset: 0x20AFA60 VA: 0x1820B1460
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B19A0 Offset: 0x20AFFA0 VA: 0x1820B19A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B19C0 Offset: 0x20AFFC0 VA: 0x1820B19C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ComputerStation previous) { }

	// RVA: 0x20B1480 Offset: 0x20AFA80 VA: 0x1820B1480 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B0FE0 Offset: 0x20AF5E0 VA: 0x1820B0FE0
	public static ComputerStation Deserialize(byte[] buffer, ComputerStation instance, bool isDelta = False) { }

	// RVA: 0x20B1200 Offset: 0x20AF800 VA: 0x1820B1200
	public static ComputerStation Deserialize(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B0AB0 Offset: 0x20AF0B0 VA: 0x1820B0AB0
	public static ComputerStation DeserializeLengthDelimited(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B0D60 Offset: 0x20AF360 VA: 0x1820B0D60
	public static ComputerStation DeserializeLength(Stream stream, int length, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20B15C0 Offset: 0x20AFBC0 VA: 0x1820B15C0
	public static void SerializeDelta(Stream stream, ComputerStation instance, ComputerStation previous) { }

	// RVA: 0x20B18A0 Offset: 0x20AFEA0 VA: 0x1820B18A0
	public static void Serialize(Stream stream, ComputerStation instance) { }

	// RVA: 0x20B1990 Offset: 0x20AFF90 VA: 0x1820B1990
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B19A0 Offset: 0x20AFFA0 VA: 0x1820B19A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B1790 Offset: 0x20AFD90 VA: 0x1820B1790
	public static byte[] SerializeToBytes(ComputerStation instance) { }

	// RVA: 0x20B16E0 Offset: 0x20AFCE0 VA: 0x1820B16E0
	public static void SerializeLengthDelimited(Stream stream, ComputerStation instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ComputerStation : BaseMountable // TypeDefIndex: 8562
{	// Fields
	[HeaderAttribute] // RVA: 0xAAA80 Offset: 0xA9E80 VA: 0x1800AAA80
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

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

