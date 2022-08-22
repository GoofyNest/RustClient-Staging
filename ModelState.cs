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

	// RVA: 0x201FD90 Offset: 0x201E390 VA: 0x18201FD90
	public void .ctor() { }

	// RVA: 0x201F270 Offset: 0x201D870 VA: 0x18201F270
	public bool HasFlag(ModelState.Flag f) { }

	// RVA: 0x201FD20 Offset: 0x201E320 VA: 0x18201FD20
	public void SetFlag(ModelState.Flag f, bool b) { }

	// RVA: 0x201FDE0 Offset: 0x201E3E0 VA: 0x18201FDE0
	public bool get_ducked() { }

	// RVA: 0x201FEE0 Offset: 0x201E4E0 VA: 0x18201FEE0
	public void set_ducked(bool value) { }

	// RVA: 0x201FE10 Offset: 0x201E410 VA: 0x18201FE10
	public bool get_jumped() { }

	// RVA: 0x201FF40 Offset: 0x201E540 VA: 0x18201FF40
	public void set_jumped(bool value) { }

	// RVA: 0x201FE50 Offset: 0x201E450 VA: 0x18201FE50
	public bool get_onground() { }

	// RVA: 0x201FFC0 Offset: 0x201E5C0 VA: 0x18201FFC0
	public void set_onground(bool value) { }

	// RVA: 0x201FE80 Offset: 0x201E480 VA: 0x18201FE80
	public bool get_sleeping() { }

	// RVA: 0x2020020 Offset: 0x201E620 VA: 0x182020020
	public void set_sleeping(bool value) { }

	// RVA: 0x201FE90 Offset: 0x201E490 VA: 0x18201FE90
	public bool get_sprinting() { }

	// RVA: 0x2020040 Offset: 0x201E640 VA: 0x182020040
	public void set_sprinting(bool value) { }

	// RVA: 0x201FE30 Offset: 0x201E430 VA: 0x18201FE30
	public bool get_onLadder() { }

	// RVA: 0x201FF80 Offset: 0x201E580 VA: 0x18201FF80
	public void set_onLadder(bool value) { }

	// RVA: 0x201FDF0 Offset: 0x201E3F0 VA: 0x18201FDF0
	public bool get_flying() { }

	// RVA: 0x201FF00 Offset: 0x201E500 VA: 0x18201FF00
	public void set_flying(bool value) { }

	// RVA: 0x201FDC0 Offset: 0x201E3C0 VA: 0x18201FDC0
	public bool get_aiming() { }

	// RVA: 0x201FEA0 Offset: 0x201E4A0 VA: 0x18201FEA0
	public void set_aiming(bool value) { }

	// RVA: 0x201FE60 Offset: 0x201E460 VA: 0x18201FE60
	public bool get_prone() { }

	// RVA: 0x201FFE0 Offset: 0x201E5E0 VA: 0x18201FFE0
	public void set_prone(bool value) { }

	// RVA: 0x201FE20 Offset: 0x201E420 VA: 0x18201FE20
	public bool get_mounted() { }

	// RVA: 0x201FF60 Offset: 0x201E560 VA: 0x18201FF60
	public void set_mounted(bool value) { }

	// RVA: 0x201FE70 Offset: 0x201E470 VA: 0x18201FE70
	public bool get_relaxed() { }

	// RVA: 0x2020000 Offset: 0x201E600 VA: 0x182020000
	public void set_relaxed(bool value) { }

	// RVA: 0x201FDD0 Offset: 0x201E3D0 VA: 0x18201FDD0
	public bool get_crawling() { }

	// RVA: 0x201FEC0 Offset: 0x201E4C0 VA: 0x18201FEC0
	public void set_crawling(bool value) { }

	// RVA: 0x201FE40 Offset: 0x201E440 VA: 0x18201FE40
	public bool get_onPhone() { }

	// RVA: 0x201FFA0 Offset: 0x201E5A0 VA: 0x18201FFA0
	public void set_onPhone(bool value) { }

	// RVA: 0x201FE00 Offset: 0x201E400 VA: 0x18201FE00
	public bool get_headLook() { }

	// RVA: 0x201FF20 Offset: 0x201E520 VA: 0x18201FF20
	public void set_headLook(bool value) { }

	// RVA: 0x201EF10 Offset: 0x201D510 VA: 0x18201EF10
	public static bool Equal(ModelState a, ModelState b) { }

	// RVA: 0x201F350 Offset: 0x201D950 VA: 0x18201F350
	public static void ResetToPool(ModelState instance) { }

	// RVA: 0x201F2A0 Offset: 0x201D8A0 VA: 0x18201F2A0
	public void ResetToPool() { }

	// RVA: 0x201EE90 Offset: 0x201D490 VA: 0x18201EE90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201DB70 Offset: 0x201C170 VA: 0x18201DB70
	public void CopyTo(ModelState instance) { }

	// RVA: 0x201DBC0 Offset: 0x201C1C0 VA: 0x18201DBC0
	public ModelState Copy() { }

	// RVA: 0x201EC10 Offset: 0x201D210 VA: 0x18201EC10
	public static ModelState Deserialize(Stream stream) { }

	// RVA: 0x201DC60 Offset: 0x201C260 VA: 0x18201DC60
	public static ModelState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201E2F0 Offset: 0x201C8F0 VA: 0x18201E2F0
	public static ModelState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201E8E0 Offset: 0x201CEE0 VA: 0x18201E8E0
	public static ModelState Deserialize(byte[] buffer) { }

	// RVA: 0x201F020 Offset: 0x201D620 VA: 0x18201F020
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201FD50 Offset: 0x201E350 VA: 0x18201FD50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201FD70 Offset: 0x201E370 VA: 0x18201FD70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModelState previous) { }

	// RVA: 0x201F280 Offset: 0x201D880 VA: 0x18201F280 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201E380 Offset: 0x201C980 VA: 0x18201E380
	public static ModelState Deserialize(byte[] buffer, ModelState instance, bool isDelta = False) { }

	// RVA: 0x201E690 Offset: 0x201CC90 VA: 0x18201E690
	public static ModelState Deserialize(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201DCE0 Offset: 0x201C2E0 VA: 0x18201DCE0
	public static ModelState DeserializeLengthDelimited(Stream stream, ModelState instance, bool isDelta) { }

	// RVA: 0x201E000 Offset: 0x201C600 VA: 0x18201E000
	public static ModelState DeserializeLength(Stream stream, int length, ModelState instance, bool isDelta) { }

	// RVA: 0x201F400 Offset: 0x201DA00 VA: 0x18201F400
	public static void SerializeDelta(Stream stream, ModelState instance, ModelState previous) { }

	// RVA: 0x201FA60 Offset: 0x201E060 VA: 0x18201FA60
	public static void Serialize(Stream stream, ModelState instance) { }

	// RVA: 0x201FD40 Offset: 0x201E340 VA: 0x18201FD40
	public byte[] ToProtoBytes() { }

	// RVA: 0x201FD50 Offset: 0x201E350 VA: 0x18201FD50
	public void ToProto(Stream stream) { }

	// RVA: 0x201F950 Offset: 0x201DF50 VA: 0x18201F950
	public static byte[] SerializeToBytes(ModelState instance) { }

	// RVA: 0x201F8A0 Offset: 0x201DEA0 VA: 0x18201F8A0
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

