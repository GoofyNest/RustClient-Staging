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

	// RVA: 0x201F470 Offset: 0x201DA70 VA: 0x18201F470
	public void .ctor() { }

	// RVA: 0x201E950 Offset: 0x201CF50 VA: 0x18201E950
	public bool HasFlag(ModelState.Flag f) { }

	// RVA: 0x201F400 Offset: 0x201DA00 VA: 0x18201F400
	public void SetFlag(ModelState.Flag f, bool b) { }

	// RVA: 0x201F4C0 Offset: 0x201DAC0 VA: 0x18201F4C0
	public bool get_ducked() { }

	// RVA: 0x201F5C0 Offset: 0x201DBC0 VA: 0x18201F5C0
	public void set_ducked(bool value) { }

	// RVA: 0x201F4F0 Offset: 0x201DAF0 VA: 0x18201F4F0
	public bool get_jumped() { }

	// RVA: 0x201F620 Offset: 0x201DC20 VA: 0x18201F620
	public void set_jumped(bool value) { }

	// RVA: 0x201F530 Offset: 0x201DB30 VA: 0x18201F530
	public bool get_onground() { }

	// RVA: 0x201F6A0 Offset: 0x201DCA0 VA: 0x18201F6A0
	public void set_onground(bool value) { }

	// RVA: 0x201F560 Offset: 0x201DB60 VA: 0x18201F560
	public bool get_sleeping() { }

	// RVA: 0x201F700 Offset: 0x201DD00 VA: 0x18201F700
	public void set_sleeping(bool value) { }

	// RVA: 0x201F570 Offset: 0x201DB70 VA: 0x18201F570
	public bool get_sprinting() { }

	// RVA: 0x201F720 Offset: 0x201DD20 VA: 0x18201F720
	public void set_sprinting(bool value) { }

	// RVA: 0x201F510 Offset: 0x201DB10 VA: 0x18201F510
	public bool get_onLadder() { }

	// RVA: 0x201F660 Offset: 0x201DC60 VA: 0x18201F660
	public void set_onLadder(bool value) { }

	// RVA: 0x201F4D0 Offset: 0x201DAD0 VA: 0x18201F4D0
	public bool get_flying() { }

	// RVA: 0x201F5E0 Offset: 0x201DBE0 VA: 0x18201F5E0
	public void set_flying(bool value) { }

	// RVA: 0x201F4A0 Offset: 0x201DAA0 VA: 0x18201F4A0
	public bool get_aiming() { }

	// RVA: 0x201F580 Offset: 0x201DB80 VA: 0x18201F580
	public void set_aiming(bool value) { }

	// RVA: 0x201F540 Offset: 0x201DB40 VA: 0x18201F540
	public bool get_prone() { }

	// RVA: 0x201F6C0 Offset: 0x201DCC0 VA: 0x18201F6C0
	public void set_prone(bool value) { }

	// RVA: 0x201F500 Offset: 0x201DB00 VA: 0x18201F500
	public bool get_mounted() { }

	// RVA: 0x201F640 Offset: 0x201DC40 VA: 0x18201F640
	public void set_mounted(bool value) { }

	// RVA: 0x201F550 Offset: 0x201DB50 VA: 0x18201F550
	public bool get_relaxed() { }

	// RVA: 0x201F6E0 Offset: 0x201DCE0 VA: 0x18201F6E0
	public void set_relaxed(bool value) { }

	// RVA: 0x201F4B0 Offset: 0x201DAB0 VA: 0x18201F4B0
	public bool get_crawling() { }

	// RVA: 0x201F5A0 Offset: 0x201DBA0 VA: 0x18201F5A0
	public void set_crawling(bool value) { }

	// RVA: 0x201F520 Offset: 0x201DB20 VA: 0x18201F520
	public bool get_onPhone() { }

	// RVA: 0x201F680 Offset: 0x201DC80 VA: 0x18201F680
	public void set_onPhone(bool value) { }

	// RVA: 0x201F4E0 Offset: 0x201DAE0 VA: 0x18201F4E0
	public bool get_headLook() { }

	// RVA: 0x201F600 Offset: 0x201DC00 VA: 0x18201F600
	public void set_headLook(bool value) { }

	// RVA: 0x201E5F0 Offset: 0x201CBF0 VA: 0x18201E5F0
	public static bool Equal(ModelState a, ModelState b) { }

	// RVA: 0x201EA30 Offset: 0x201D030 VA: 0x18201EA30
	public static void ResetToPool(ModelState instance) { }

	// RVA: 0x201E980 Offset: 0x201CF80 VA: 0x18201E980
	public void ResetToPool() { }

	// RVA: 0x201E570 Offset: 0x201CB70 VA: 0x18201E570 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201D250 Offset: 0x201B850 VA: 0x18201D250
	public void CopyTo(ModelState instance) { }

	// RVA: 0x201D2A0 Offset: 0x201B8A0 VA: 0x18201D2A0
	public ModelState Copy() { }

	// RVA: 0x201E2F0 Offset: 0x201C8F0 VA: 0x18201E2F0
	public static ModelState Deserialize(Stream stream) { }

	// RVA: 0x201D340 Offset: 0x201B940 VA: 0x18201D340
	public static ModelState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201D9D0 Offset: 0x201BFD0 VA: 0x18201D9D0
	public static ModelState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201DFC0 Offset: 0x201C5C0 VA: 0x18201DFC0
	public static ModelState Deserialize(byte[] buffer) { }

	// RVA: 0x201E700 Offset: 0x201CD00 VA: 0x18201E700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201F430 Offset: 0x201DA30 VA: 0x18201F430 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201F450 Offset: 0x201DA50 VA: 0x18201F450 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModelState previous) { }

	// RVA: 0x201E960 Offset: 0x201CF60 VA: 0x18201E960 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201DA60 Offset: 0x201C060 VA: 0x18201DA60
	public static ModelState Deserialize(byte[] buffer, ModelState instance, bool isDelta = False) { }

	// RVA: 0x201DD70 Offset: 0x201C370 VA: 0x18201DD70
	public static ModelState Deserialize(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201D3C0 Offset: 0x201B9C0 VA: 0x18201D3C0
	public static ModelState DeserializeLengthDelimited(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201D6E0 Offset: 0x201BCE0 VA: 0x18201D6E0
	public static ModelState DeserializeLength(Stream stream, int length, ModelState instance, bool isDelta) { }

	// RVA: 0x201EAE0 Offset: 0x201D0E0 VA: 0x18201EAE0
	public static void SerializeDelta(Stream stream, ModelState instance, ModelState previous) { }

	// RVA: 0x201F140 Offset: 0x201D740 VA: 0x18201F140
	public static void Serialize(Stream stream, ModelState instance) { }

	// RVA: 0x201F420 Offset: 0x201DA20 VA: 0x18201F420
	public byte[] ToProtoBytes() { }

	// RVA: 0x201F430 Offset: 0x201DA30 VA: 0x18201F430
	public void ToProto(Stream stream) { }

	// RVA: 0x201F030 Offset: 0x201D630 VA: 0x18201F030
	public static byte[] SerializeToBytes(ModelState instance) { }

	// RVA: 0x201EF80 Offset: 0x201D580 VA: 0x18201EF80
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

