public class ModelState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6274
{
// Namespace: 
public class ModelState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6274
	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float waterLevel; // 0x14
	public Vector3 lookDir; // 0x18
	public int flags; // 0x24
	public int poseType; // 0x28
	public Vector3 inheritedVelocity; // 0x2C

	// Properties
	public bool ducked { get; set; }
	public bool jumped { get; set; }
	public bool onground { get; set; }
	public bool sleeping { get; set; }
	public bool sprinting { get; set; }
	public bool onLadder { get; set; }
	public bool flying { get; set; }
	public bool aiming { get; set; }
	public bool prone { get; set; }
	public bool mounted { get; set; }
	public bool relaxed { get; set; }
	public bool crawling { get; set; }
	public bool onPhone { get; set; }
	public bool headLook { get; set; }

	// Methods

	// RVA: 0x201F2B0 Offset: 0x201D8B0 VA: 0x18201F2B0
	public void .ctor() { }

	// RVA: 0x201E790 Offset: 0x201CD90 VA: 0x18201E790
	public bool HasFlag(ModelState.Flag f) { }

	// RVA: 0x201F240 Offset: 0x201D840 VA: 0x18201F240
	public void SetFlag(ModelState.Flag f, bool b) { }

	// RVA: 0x201F300 Offset: 0x201D900 VA: 0x18201F300
	public bool get_ducked() { }

	// RVA: 0x201F400 Offset: 0x201DA00 VA: 0x18201F400
	public void set_ducked(bool value) { }

	// RVA: 0x201F330 Offset: 0x201D930 VA: 0x18201F330
	public bool get_jumped() { }

	// RVA: 0x201F460 Offset: 0x201DA60 VA: 0x18201F460
	public void set_jumped(bool value) { }

	// RVA: 0x201F370 Offset: 0x201D970 VA: 0x18201F370
	public bool get_onground() { }

	// RVA: 0x201F4E0 Offset: 0x201DAE0 VA: 0x18201F4E0
	public void set_onground(bool value) { }

	// RVA: 0x201F3A0 Offset: 0x201D9A0 VA: 0x18201F3A0
	public bool get_sleeping() { }

	// RVA: 0x201F540 Offset: 0x201DB40 VA: 0x18201F540
	public void set_sleeping(bool value) { }

	// RVA: 0x201F3B0 Offset: 0x201D9B0 VA: 0x18201F3B0
	public bool get_sprinting() { }

	// RVA: 0x201F560 Offset: 0x201DB60 VA: 0x18201F560
	public void set_sprinting(bool value) { }

	// RVA: 0x201F350 Offset: 0x201D950 VA: 0x18201F350
	public bool get_onLadder() { }

	// RVA: 0x201F4A0 Offset: 0x201DAA0 VA: 0x18201F4A0
	public void set_onLadder(bool value) { }

	// RVA: 0x201F310 Offset: 0x201D910 VA: 0x18201F310
	public bool get_flying() { }

	// RVA: 0x201F420 Offset: 0x201DA20 VA: 0x18201F420
	public void set_flying(bool value) { }

	// RVA: 0x201F2E0 Offset: 0x201D8E0 VA: 0x18201F2E0
	public bool get_aiming() { }

	// RVA: 0x201F3C0 Offset: 0x201D9C0 VA: 0x18201F3C0
	public void set_aiming(bool value) { }

	// RVA: 0x201F380 Offset: 0x201D980 VA: 0x18201F380
	public bool get_prone() { }

	// RVA: 0x201F500 Offset: 0x201DB00 VA: 0x18201F500
	public void set_prone(bool value) { }

	// RVA: 0x201F340 Offset: 0x201D940 VA: 0x18201F340
	public bool get_mounted() { }

	// RVA: 0x201F480 Offset: 0x201DA80 VA: 0x18201F480
	public void set_mounted(bool value) { }

	// RVA: 0x201F390 Offset: 0x201D990 VA: 0x18201F390
	public bool get_relaxed() { }

	// RVA: 0x201F520 Offset: 0x201DB20 VA: 0x18201F520
	public void set_relaxed(bool value) { }

	// RVA: 0x201F2F0 Offset: 0x201D8F0 VA: 0x18201F2F0
	public bool get_crawling() { }

	// RVA: 0x201F3E0 Offset: 0x201D9E0 VA: 0x18201F3E0
	public void set_crawling(bool value) { }

	// RVA: 0x201F360 Offset: 0x201D960 VA: 0x18201F360
	public bool get_onPhone() { }

	// RVA: 0x201F4C0 Offset: 0x201DAC0 VA: 0x18201F4C0
	public void set_onPhone(bool value) { }

	// RVA: 0x201F320 Offset: 0x201D920 VA: 0x18201F320
	public bool get_headLook() { }

	// RVA: 0x201F440 Offset: 0x201DA40 VA: 0x18201F440
	public void set_headLook(bool value) { }

	// RVA: 0x201E430 Offset: 0x201CA30 VA: 0x18201E430
	public static bool Equal(ModelState a, ModelState b) { }

	// RVA: 0x201E870 Offset: 0x201CE70 VA: 0x18201E870
	public static void ResetToPool(ModelState instance) { }

	// RVA: 0x201E7C0 Offset: 0x201CDC0 VA: 0x18201E7C0
	public void ResetToPool() { }

	// RVA: 0x201E3B0 Offset: 0x201C9B0 VA: 0x18201E3B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201D090 Offset: 0x201B690 VA: 0x18201D090
	public void CopyTo(ModelState instance) { }

	// RVA: 0x201D0E0 Offset: 0x201B6E0 VA: 0x18201D0E0
	public ModelState Copy() { }

	// RVA: 0x201E130 Offset: 0x201C730 VA: 0x18201E130
	public static ModelState Deserialize(Stream stream) { }

	// RVA: 0x201D180 Offset: 0x201B780 VA: 0x18201D180
	public static ModelState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201D810 Offset: 0x201BE10 VA: 0x18201D810
	public static ModelState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201DE00 Offset: 0x201C400 VA: 0x18201DE00
	public static ModelState Deserialize(byte[] buffer) { }

	// RVA: 0x201E540 Offset: 0x201CB40 VA: 0x18201E540
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201F270 Offset: 0x201D870 VA: 0x18201F270 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201F290 Offset: 0x201D890 VA: 0x18201F290 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModelState previous) { }

	// RVA: 0x201E7A0 Offset: 0x201CDA0 VA: 0x18201E7A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201D8A0 Offset: 0x201BEA0 VA: 0x18201D8A0
	public static ModelState Deserialize(byte[] buffer, ModelState instance, bool isDelta = False) { }

	// RVA: 0x201DBB0 Offset: 0x201C1B0 VA: 0x18201DBB0
	public static ModelState Deserialize(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201D200 Offset: 0x201B800 VA: 0x18201D200
	public static ModelState DeserializeLengthDelimited(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201D520 Offset: 0x201BB20 VA: 0x18201D520
	public static ModelState DeserializeLength(Stream stream, int length, ModelState instance, bool isDelta) { }

	// RVA: 0x201E920 Offset: 0x201CF20 VA: 0x18201E920
	public static void SerializeDelta(Stream stream, ModelState instance, ModelState previous) { }

	// RVA: 0x201EF80 Offset: 0x201D580 VA: 0x18201EF80
	public static void Serialize(Stream stream, ModelState instance) { }

	// RVA: 0x201F260 Offset: 0x201D860 VA: 0x18201F260
	public byte[] ToProtoBytes() { }

	// RVA: 0x201F270 Offset: 0x201D870 VA: 0x18201F270
	public void ToProto(Stream stream) { }

	// RVA: 0x201EE70 Offset: 0x201D470 VA: 0x18201EE70
	public static byte[] SerializeToBytes(ModelState instance) { }

	// RVA: 0x201EDC0 Offset: 0x201D3C0 VA: 0x18201EDC0
	public static void SerializeLengthDelimited(Stream stream, ModelState instance) { }

}

public enum ModelState.Flag // TypeDefIndex: 6275
{	// Fields
	public int value__; // 0x0
	public const ModelState.Flag Ducked = 1;
	public const ModelState.Flag Jumped = 2;
	public const ModelState.Flag OnGround = 4;
	public const ModelState.Flag Sleeping = 8;
	public const ModelState.Flag Sprinting = 16;
	public const ModelState.Flag OnLadder = 32;
	public const ModelState.Flag Flying = 64;
	public const ModelState.Flag Aiming = 128;
	public const ModelState.Flag Prone = 256;
	public const ModelState.Flag Mounted = 512;
	public const ModelState.Flag Relaxed = 1024;
	public const ModelState.Flag OnPhone = 2048;
	public const ModelState.Flag Crawling = 4096;
	public const ModelState.Flag HeadLook = 16384;

}

