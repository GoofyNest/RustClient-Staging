public class ZiplineMountable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6435
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5D090 Offset: 0x1E5B690 VA: 0x181E5D090
	public static void ResetToPool(ZiplineMountable instance) { }

	// RVA: 0x1E5CFB0 Offset: 0x1E5B5B0 VA: 0x181E5CFB0
	public void ResetToPool() { }

	// RVA: 0x1E5CE20 Offset: 0x1E5B420 VA: 0x181E5CE20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5C0B0 Offset: 0x1E5A6B0 VA: 0x181E5C0B0
	public void CopyTo(ZiplineMountable instance) { }

	// RVA: 0x1E5C210 Offset: 0x1E5A810 VA: 0x181E5C210
	public ZiplineMountable Copy() { }

	// RVA: 0x1E5CBF0 Offset: 0x1E5B1F0 VA: 0x181E5CBF0
	public static ZiplineMountable Deserialize(Stream stream) { }

	// RVA: 0x1E5C3D0 Offset: 0x1E5A9D0 VA: 0x181E5C3D0
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5C940 Offset: 0x1E5AF40 VA: 0x181E5C940
	public static ZiplineMountable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5C9D0 Offset: 0x1E5AFD0 VA: 0x181E5C9D0
	public static ZiplineMountable Deserialize(byte[] buffer) { }

	// RVA: 0x1E5CF70 Offset: 0x1E5B570 VA: 0x181E5CF70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5D850 Offset: 0x1E5BE50 VA: 0x181E5D850 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5D870 Offset: 0x1E5BE70 VA: 0x181E5D870 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineMountable previous) { }

	// RVA: 0x1E5CF90 Offset: 0x1E5B590 VA: 0x181E5CF90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5CAF0 Offset: 0x1E5B0F0 VA: 0x181E5CAF0
	public static ZiplineMountable Deserialize(byte[] buffer, ZiplineMountable instance, bool isDelta = False) { }

	// RVA: 0x1E5CC70 Offset: 0x1E5B270 VA: 0x181E5CC70
	public static ZiplineMountable Deserialize(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5C450 Offset: 0x1E5AA50 VA: 0x181E5C450
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5C6D0 Offset: 0x1E5ACD0 VA: 0x181E5C6D0
	public static ZiplineMountable DeserializeLength(Stream stream, int length, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5D170 Offset: 0x1E5B770 VA: 0x181E5D170
	public static void SerializeDelta(Stream stream, ZiplineMountable instance, ZiplineMountable previous) { }

	// RVA: 0x1E5D5F0 Offset: 0x1E5BBF0 VA: 0x181E5D5F0
	public static void Serialize(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x1E5D840 Offset: 0x1E5BE40 VA: 0x181E5D840
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5D850 Offset: 0x1E5BE50 VA: 0x181E5D850
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5D4E0 Offset: 0x1E5BAE0 VA: 0x181E5D4E0
	public static byte[] SerializeToBytes(ZiplineMountable instance) { }

	// RVA: 0x1E5D3F0 Offset: 0x1E5B9F0 VA: 0x181E5D3F0
	public static void SerializeLengthDelimited(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1A8F5E0 Offset: 0x1A8DBE0 VA: 0x181A8F5E0
	private Vector3 ProcessBezierMovement(float distanceToTravel) { }

	// RVA: 0x1A8EDE0 Offset: 0x1A8D3E0 VA: 0x181A8EDE0
	private Vector3 GetLineEndPoint() { }

	// RVA: 0x1A8EE90 Offset: 0x1A8D490 VA: 0x181A8EE90
	private Vector3 GetNextLinePoint(Transform forTransform) { }

	// RVA: 0x1A8F950 Offset: 0x1A8DF50 VA: 0x181A8F950 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x1A8F280 Offset: 0x1A8D880 VA: 0x181A8F280 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A8EC70 Offset: 0x1A8D270 VA: 0x181A8EC70 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 165
	public override bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 166
	public override float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0x1A8FEE0 Offset: 0x1A8E4E0 VA: 0x181A8FEE0
	public static bool get_HasPushedForward() { }

	// RVA: 0x1A8FF20 Offset: 0x1A8E520 VA: 0x181A8FF20
	public static void set_HasPushedForward(bool value) { }

	// RVA: 0x1A8F920 Offset: 0x1A8DF20 VA: 0x181A8F920 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A8F480 Offset: 0x1A8DA80 VA: 0x181A8F480 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x1A8F4A0 Offset: 0x1A8DAA0 VA: 0x181A8F4A0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x1A8FDF0 Offset: 0x1A8E3F0 VA: 0x181A8FDF0
	public void .ctor() { }

}

