public class ZiplineMountable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6435
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5CF90 Offset: 0x1E5B590 VA: 0x181E5CF90
	public static void ResetToPool(ZiplineMountable instance) { }

	// RVA: 0x1E5CEB0 Offset: 0x1E5B4B0 VA: 0x181E5CEB0
	public void ResetToPool() { }

	// RVA: 0x1E5CD20 Offset: 0x1E5B320 VA: 0x181E5CD20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5BFB0 Offset: 0x1E5A5B0 VA: 0x181E5BFB0
	public void CopyTo(ZiplineMountable instance) { }

	// RVA: 0x1E5C110 Offset: 0x1E5A710 VA: 0x181E5C110
	public ZiplineMountable Copy() { }

	// RVA: 0x1E5CAF0 Offset: 0x1E5B0F0 VA: 0x181E5CAF0
	public static ZiplineMountable Deserialize(Stream stream) { }

	// RVA: 0x1E5C2D0 Offset: 0x1E5A8D0 VA: 0x181E5C2D0
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5C840 Offset: 0x1E5AE40 VA: 0x181E5C840
	public static ZiplineMountable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5C8D0 Offset: 0x1E5AED0 VA: 0x181E5C8D0
	public static ZiplineMountable Deserialize(byte[] buffer) { }

	// RVA: 0x1E5CE70 Offset: 0x1E5B470 VA: 0x181E5CE70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5D750 Offset: 0x1E5BD50 VA: 0x181E5D750 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5D770 Offset: 0x1E5BD70 VA: 0x181E5D770 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineMountable previous) { }

	// RVA: 0x1E5CE90 Offset: 0x1E5B490 VA: 0x181E5CE90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5C9F0 Offset: 0x1E5AFF0 VA: 0x181E5C9F0
	public static ZiplineMountable Deserialize(byte[] buffer, ZiplineMountable instance, bool isDelta = False) { }

	// RVA: 0x1E5CB70 Offset: 0x1E5B170 VA: 0x181E5CB70
	public static ZiplineMountable Deserialize(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5C350 Offset: 0x1E5A950 VA: 0x181E5C350
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5C5D0 Offset: 0x1E5ABD0 VA: 0x181E5C5D0
	public static ZiplineMountable DeserializeLength(Stream stream, int length, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5D070 Offset: 0x1E5B670 VA: 0x181E5D070
	public static void SerializeDelta(Stream stream, ZiplineMountable instance, ZiplineMountable previous) { }

	// RVA: 0x1E5D4F0 Offset: 0x1E5BAF0 VA: 0x181E5D4F0
	public static void Serialize(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x1E5D740 Offset: 0x1E5BD40 VA: 0x181E5D740
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5D750 Offset: 0x1E5BD50 VA: 0x181E5D750
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5D3E0 Offset: 0x1E5B9E0 VA: 0x181E5D3E0
	public static byte[] SerializeToBytes(ZiplineMountable instance) { }

	// RVA: 0x1E5D2F0 Offset: 0x1E5B8F0 VA: 0x181E5D2F0
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

	// RVA: 0x1AA56B0 Offset: 0x1AA3CB0 VA: 0x181AA56B0
	private Vector3 ProcessBezierMovement(float distanceToTravel) { }

	// RVA: 0x1AA4EB0 Offset: 0x1AA34B0 VA: 0x181AA4EB0
	private Vector3 GetLineEndPoint() { }

	// RVA: 0x1AA4F60 Offset: 0x1AA3560 VA: 0x181AA4F60
	private Vector3 GetNextLinePoint(Transform forTransform) { }

	// RVA: 0x1AA5A20 Offset: 0x1AA4020 VA: 0x181AA5A20 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x1AA5350 Offset: 0x1AA3950 VA: 0x181AA5350 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1AA4D40 Offset: 0x1AA3340 VA: 0x181AA4D40 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 165
	public override bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 166
	public override float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0x1AA5FB0 Offset: 0x1AA45B0 VA: 0x181AA5FB0
	public static bool get_HasPushedForward() { }

	// RVA: 0x1AA5FF0 Offset: 0x1AA45F0 VA: 0x181AA5FF0
	public static void set_HasPushedForward(bool value) { }

	// RVA: 0x1AA59F0 Offset: 0x1AA3FF0 VA: 0x181AA59F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1AA5550 Offset: 0x1AA3B50 VA: 0x181AA5550 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x1AA5570 Offset: 0x1AA3B70 VA: 0x181AA5570 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x1AA5EC0 Offset: 0x1AA44C0 VA: 0x181AA5EC0
	public void .ctor() { }

}

