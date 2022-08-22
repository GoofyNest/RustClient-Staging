public class ZiplineMountable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6435
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5CDD0 Offset: 0x1E5B3D0 VA: 0x181E5CDD0
	public static void ResetToPool(ZiplineMountable instance) { }

	// RVA: 0x1E5CCF0 Offset: 0x1E5B2F0 VA: 0x181E5CCF0
	public void ResetToPool() { }

	// RVA: 0x1E5CB60 Offset: 0x1E5B160 VA: 0x181E5CB60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5BDF0 Offset: 0x1E5A3F0 VA: 0x181E5BDF0
	public void CopyTo(ZiplineMountable instance) { }

	// RVA: 0x1E5BF50 Offset: 0x1E5A550 VA: 0x181E5BF50
	public ZiplineMountable Copy() { }

	// RVA: 0x1E5C930 Offset: 0x1E5AF30 VA: 0x181E5C930
	public static ZiplineMountable Deserialize(Stream stream) { }

	// RVA: 0x1E5C110 Offset: 0x1E5A710 VA: 0x181E5C110
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5C680 Offset: 0x1E5AC80 VA: 0x181E5C680
	public static ZiplineMountable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5C710 Offset: 0x1E5AD10 VA: 0x181E5C710
	public static ZiplineMountable Deserialize(byte[] buffer) { }

	// RVA: 0x1E5CCB0 Offset: 0x1E5B2B0 VA: 0x181E5CCB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5D590 Offset: 0x1E5BB90 VA: 0x181E5D590 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5D5B0 Offset: 0x1E5BBB0 VA: 0x181E5D5B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineMountable previous) { }

	// RVA: 0x1E5CCD0 Offset: 0x1E5B2D0 VA: 0x181E5CCD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5C830 Offset: 0x1E5AE30 VA: 0x181E5C830
	public static ZiplineMountable Deserialize(byte[] buffer, ZiplineMountable instance, bool isDelta = False) { }

	// RVA: 0x1E5C9B0 Offset: 0x1E5AFB0 VA: 0x181E5C9B0
	public static ZiplineMountable Deserialize(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5C190 Offset: 0x1E5A790 VA: 0x181E5C190
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5C410 Offset: 0x1E5AA10 VA: 0x181E5C410
	public static ZiplineMountable DeserializeLength(Stream stream, int length, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5CEB0 Offset: 0x1E5B4B0 VA: 0x181E5CEB0
	public static void SerializeDelta(Stream stream, ZiplineMountable instance, ZiplineMountable previous) { }

	// RVA: 0x1E5D330 Offset: 0x1E5B930 VA: 0x181E5D330
	public static void Serialize(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x1E5D580 Offset: 0x1E5BB80 VA: 0x181E5D580
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5D590 Offset: 0x1E5BB90 VA: 0x181E5D590
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5D220 Offset: 0x1E5B820 VA: 0x181E5D220
	public static byte[] SerializeToBytes(ZiplineMountable instance) { }

	// RVA: 0x1E5D130 Offset: 0x1E5B730 VA: 0x181E5D130
	public static void SerializeLengthDelimited(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ZiplineMountable : BaseMountable // TypeDefIndex: 8671
{	// Fields
	public float MoveSpeed; // 0x320
	public float ForwardAdditive; // 0x324
	public CapsuleCollider ZipCollider; // 0x328
	public Transform ZiplineGrabRoot; // 0x330
	public Transform LeftHandIkPoint; // 0x338
	public Transform RightHandIkPoint; // 0x340
	public float SpeedUpTime; // 0x348
	public bool EditorHoldInPlace; // 0x34C
	private List<Vector3> linePoints; // 0x350
	private const BaseEntity.Flags PushForward = 128;
	public AnimationCurve MountPositionCurve; // 0x358
	public AnimationCurve MountRotationCurve; // 0x360
	public float MountEaseInTime; // 0x368
	private const BaseEntity.Flags ShowHandle = 256;
	private float forwardSpeedAnim; // 0x36C

	// Properties
	public override bool DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes { get; }
	public override float FirstPersonWithArmsEyesLerp { get; }
	public static bool HasPushedForward { get; set; }

	// Methods

	// RVA: 0x1A8F320 Offset: 0x1A8D920 VA: 0x181A8F320
	private Vector3 ProcessBezierMovement(float distanceToTravel) { }

	// RVA: 0x1A8EB20 Offset: 0x1A8D120 VA: 0x181A8EB20
	private Vector3 GetLineEndPoint() { }

	// RVA: 0x1A8EBD0 Offset: 0x1A8D1D0 VA: 0x181A8EBD0
	private Vector3 GetNextLinePoint(Transform forTransform) { }

	// RVA: 0x1A8F690 Offset: 0x1A8DC90 VA: 0x181A8F690 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x1A8EFC0 Offset: 0x1A8D5C0 VA: 0x181A8EFC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A8E9B0 Offset: 0x1A8CFB0 VA: 0x181A8E9B0 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 165
	public override bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 166
	public override float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0x1A8FC20 Offset: 0x1A8E220 VA: 0x181A8FC20
	public static bool get_HasPushedForward() { }

	// RVA: 0x1A8FC60 Offset: 0x1A8E260 VA: 0x181A8FC60
	public static void set_HasPushedForward(bool value) { }

	// RVA: 0x1A8F660 Offset: 0x1A8DC60 VA: 0x181A8F660 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A8F1C0 Offset: 0x1A8D7C0 VA: 0x181A8F1C0 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x1A8F1E0 Offset: 0x1A8D7E0 VA: 0x181A8F1E0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x1A8FB30 Offset: 0x1A8E130 VA: 0x181A8FB30
	public void .ctor() { }

}

