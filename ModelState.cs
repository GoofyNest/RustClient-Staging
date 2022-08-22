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

	// RVA: 0x201F570 Offset: 0x201DB70 VA: 0x18201F570
	public void .ctor() { }

	// RVA: 0x201EA50 Offset: 0x201D050 VA: 0x18201EA50
	public bool HasFlag(ModelState.Flag f) { }

	// RVA: 0x201F500 Offset: 0x201DB00 VA: 0x18201F500
	public void SetFlag(ModelState.Flag f, bool b) { }

	// RVA: 0x201F5C0 Offset: 0x201DBC0 VA: 0x18201F5C0
	public bool get_ducked() { }

	// RVA: 0x201F6C0 Offset: 0x201DCC0 VA: 0x18201F6C0
	public void set_ducked(bool value) { }

	// RVA: 0x201F5F0 Offset: 0x201DBF0 VA: 0x18201F5F0
	public bool get_jumped() { }

	// RVA: 0x201F720 Offset: 0x201DD20 VA: 0x18201F720
	public void set_jumped(bool value) { }

	// RVA: 0x201F630 Offset: 0x201DC30 VA: 0x18201F630
	public bool get_onground() { }

	// RVA: 0x201F7A0 Offset: 0x201DDA0 VA: 0x18201F7A0
	public void set_onground(bool value) { }

	// RVA: 0x201F660 Offset: 0x201DC60 VA: 0x18201F660
	public bool get_sleeping() { }

	// RVA: 0x201F800 Offset: 0x201DE00 VA: 0x18201F800
	public void set_sleeping(bool value) { }

	// RVA: 0x201F670 Offset: 0x201DC70 VA: 0x18201F670
	public bool get_sprinting() { }

	// RVA: 0x201F820 Offset: 0x201DE20 VA: 0x18201F820
	public void set_sprinting(bool value) { }

	// RVA: 0x201F610 Offset: 0x201DC10 VA: 0x18201F610
	public bool get_onLadder() { }

	// RVA: 0x201F760 Offset: 0x201DD60 VA: 0x18201F760
	public void set_onLadder(bool value) { }

	// RVA: 0x201F5D0 Offset: 0x201DBD0 VA: 0x18201F5D0
	public bool get_flying() { }

	// RVA: 0x201F6E0 Offset: 0x201DCE0 VA: 0x18201F6E0
	public void set_flying(bool value) { }

	// RVA: 0x201F5A0 Offset: 0x201DBA0 VA: 0x18201F5A0
	public bool get_aiming() { }

	// RVA: 0x201F680 Offset: 0x201DC80 VA: 0x18201F680
	public void set_aiming(bool value) { }

	// RVA: 0x201F640 Offset: 0x201DC40 VA: 0x18201F640
	public bool get_prone() { }

	// RVA: 0x201F7C0 Offset: 0x201DDC0 VA: 0x18201F7C0
	public void set_prone(bool value) { }

	// RVA: 0x201F600 Offset: 0x201DC00 VA: 0x18201F600
	public bool get_mounted() { }

	// RVA: 0x201F740 Offset: 0x201DD40 VA: 0x18201F740
	public void set_mounted(bool value) { }

	// RVA: 0x201F650 Offset: 0x201DC50 VA: 0x18201F650
	public bool get_relaxed() { }

	// RVA: 0x201F7E0 Offset: 0x201DDE0 VA: 0x18201F7E0
	public void set_relaxed(bool value) { }

	// RVA: 0x201F5B0 Offset: 0x201DBB0 VA: 0x18201F5B0
	public bool get_crawling() { }

	// RVA: 0x201F6A0 Offset: 0x201DCA0 VA: 0x18201F6A0
	public void set_crawling(bool value) { }

	// RVA: 0x201F620 Offset: 0x201DC20 VA: 0x18201F620
	public bool get_onPhone() { }

	// RVA: 0x201F780 Offset: 0x201DD80 VA: 0x18201F780
	public void set_onPhone(bool value) { }

	// RVA: 0x201F5E0 Offset: 0x201DBE0 VA: 0x18201F5E0
	public bool get_headLook() { }

	// RVA: 0x201F700 Offset: 0x201DD00 VA: 0x18201F700
	public void set_headLook(bool value) { }

	// RVA: 0x201E6F0 Offset: 0x201CCF0 VA: 0x18201E6F0
	public static bool Equal(ModelState a, ModelState b) { }

	// RVA: 0x201EB30 Offset: 0x201D130 VA: 0x18201EB30
	public static void ResetToPool(ModelState instance) { }

	// RVA: 0x201EA80 Offset: 0x201D080 VA: 0x18201EA80
	public void ResetToPool() { }

	// RVA: 0x201E670 Offset: 0x201CC70 VA: 0x18201E670 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201D350 Offset: 0x201B950 VA: 0x18201D350
	public void CopyTo(ModelState instance) { }

	// RVA: 0x201D3A0 Offset: 0x201B9A0 VA: 0x18201D3A0
	public ModelState Copy() { }

	// RVA: 0x201E3F0 Offset: 0x201C9F0 VA: 0x18201E3F0
	public static ModelState Deserialize(Stream stream) { }

	// RVA: 0x201D440 Offset: 0x201BA40 VA: 0x18201D440
	public static ModelState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201DAD0 Offset: 0x201C0D0 VA: 0x18201DAD0
	public static ModelState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201E0C0 Offset: 0x201C6C0 VA: 0x18201E0C0
	public static ModelState Deserialize(byte[] buffer) { }

	// RVA: 0x201E800 Offset: 0x201CE00 VA: 0x18201E800
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201F530 Offset: 0x201DB30 VA: 0x18201F530 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201F550 Offset: 0x201DB50 VA: 0x18201F550 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModelState previous) { }

	// RVA: 0x201EA60 Offset: 0x201D060 VA: 0x18201EA60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201DB60 Offset: 0x201C160 VA: 0x18201DB60
	public static ModelState Deserialize(byte[] buffer, ModelState instance, bool isDelta = False) { }

	// RVA: 0x201DE70 Offset: 0x201C470 VA: 0x18201DE70
	public static ModelState Deserialize(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201D4C0 Offset: 0x201BAC0 VA: 0x18201D4C0
	public static ModelState DeserializeLengthDelimited(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201D7E0 Offset: 0x201BDE0 VA: 0x18201D7E0
	public static ModelState DeserializeLength(Stream stream, int length, ModelState instance, bool isDelta) { }

	// RVA: 0x201EBE0 Offset: 0x201D1E0 VA: 0x18201EBE0
	public static void SerializeDelta(Stream stream, ModelState instance, ModelState previous) { }

	// RVA: 0x201F240 Offset: 0x201D840 VA: 0x18201F240
	public static void Serialize(Stream stream, ModelState instance) { }

	// RVA: 0x201F520 Offset: 0x201DB20 VA: 0x18201F520
	public byte[] ToProtoBytes() { }

	// RVA: 0x201F530 Offset: 0x201DB30 VA: 0x18201F530
	public void ToProto(Stream stream) { }

	// RVA: 0x201F130 Offset: 0x201D730 VA: 0x18201F130
	public static byte[] SerializeToBytes(ModelState instance) { }

	// RVA: 0x201F080 Offset: 0x201D680 VA: 0x18201F080
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

