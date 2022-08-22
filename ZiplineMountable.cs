public class ZiplineMountable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6435
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E5D8B0 Offset: 0x1E5BEB0 VA: 0x181E5D8B0
	public static void ResetToPool(ZiplineMountable instance) { }

	// RVA: 0x1E5D7D0 Offset: 0x1E5BDD0 VA: 0x181E5D7D0
	public void ResetToPool() { }

	// RVA: 0x1E5D640 Offset: 0x1E5BC40 VA: 0x181E5D640 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5C8D0 Offset: 0x1E5AED0 VA: 0x181E5C8D0
	public void CopyTo(ZiplineMountable instance) { }

	// RVA: 0x1E5CA30 Offset: 0x1E5B030 VA: 0x181E5CA30
	public ZiplineMountable Copy() { }

	// RVA: 0x1E5D410 Offset: 0x1E5BA10 VA: 0x181E5D410
	public static ZiplineMountable Deserialize(Stream stream) { }

	// RVA: 0x1E5CBF0 Offset: 0x1E5B1F0 VA: 0x181E5CBF0
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5D160 Offset: 0x1E5B760 VA: 0x181E5D160
	public static ZiplineMountable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5D1F0 Offset: 0x1E5B7F0 VA: 0x181E5D1F0
	public static ZiplineMountable Deserialize(byte[] buffer) { }

	// RVA: 0x1E5D790 Offset: 0x1E5BD90 VA: 0x181E5D790
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5E070 Offset: 0x1E5C670 VA: 0x181E5E070 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5E090 Offset: 0x1E5C690 VA: 0x181E5E090 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineMountable previous) { }

	// RVA: 0x1E5D7B0 Offset: 0x1E5BDB0 VA: 0x181E5D7B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5D310 Offset: 0x1E5B910 VA: 0x181E5D310
	public static ZiplineMountable Deserialize(byte[] buffer, ZiplineMountable instance, bool isDelta = False) { }

	// RVA: 0x1E5D490 Offset: 0x1E5BA90 VA: 0x181E5D490
	public static ZiplineMountable Deserialize(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5CC70 Offset: 0x1E5B270 VA: 0x181E5CC70
	public static ZiplineMountable DeserializeLengthDelimited(Stream stream, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5CEF0 Offset: 0x1E5B4F0 VA: 0x181E5CEF0
	public static ZiplineMountable DeserializeLength(Stream stream, int length, ZiplineMountable instance, bool isDelta) { }

	// RVA: 0x1E5D990 Offset: 0x1E5BF90 VA: 0x181E5D990
	public static void SerializeDelta(Stream stream, ZiplineMountable instance, ZiplineMountable previous) { }

	// RVA: 0x1E5DE10 Offset: 0x1E5C410 VA: 0x181E5DE10
	public static void Serialize(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x1E5E060 Offset: 0x1E5C660 VA: 0x181E5E060
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5E070 Offset: 0x1E5C670 VA: 0x181E5E070
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5DD00 Offset: 0x1E5C300 VA: 0x181E5DD00
	public static byte[] SerializeToBytes(ZiplineMountable instance) { }

	// RVA: 0x1E5DC10 Offset: 0x1E5C210 VA: 0x181E5DC10
	public static void SerializeLengthDelimited(Stream stream, ZiplineMountable instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1A7BDF0 Offset: 0x1A7A3F0 VA: 0x181A7BDF0
	private Vector3 ProcessBezierMovement(float distanceToTravel) { }

	// RVA: 0x1A7B5F0 Offset: 0x1A79BF0 VA: 0x181A7B5F0
	private Vector3 GetLineEndPoint() { }

	// RVA: 0x1A7B6A0 Offset: 0x1A79CA0 VA: 0x181A7B6A0
	private Vector3 GetNextLinePoint(Transform forTransform) { }

	// RVA: 0x1A7C160 Offset: 0x1A7A760 VA: 0x181A7C160 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x1A7BA90 Offset: 0x1A7A090 VA: 0x181A7BA90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A7B480 Offset: 0x1A79A80 VA: 0x181A7B480 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 165
	public override bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 166
	public override float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0x1A7C6F0 Offset: 0x1A7ACF0 VA: 0x181A7C6F0
	public static bool get_HasPushedForward() { }

	// RVA: 0x1A7C730 Offset: 0x1A7AD30 VA: 0x181A7C730
	public static void set_HasPushedForward(bool value) { }

	// RVA: 0x1A7C130 Offset: 0x1A7A730 VA: 0x181A7C130 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A7BC90 Offset: 0x1A7A290 VA: 0x181A7BC90 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x1A7BCB0 Offset: 0x1A7A2B0 VA: 0x181A7BCB0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x1A7C600 Offset: 0x1A7AC00 VA: 0x181A7C600
	public void .ctor() { }

}

