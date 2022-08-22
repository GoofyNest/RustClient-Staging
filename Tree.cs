public class Tree : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6496
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint netId; // 0x14
	public uint prefabId; // 0x18
	public Half3 position; // 0x1C
	public float scale; // 0x28

	// Methods

	// RVA: 0x1EF5340 Offset: 0x1EF3940 VA: 0x181EF5340
	public static void ResetToPool(Tree instance) { }

	// RVA: 0x1EF53E0 Offset: 0x1EF39E0 VA: 0x181EF53E0
	public void ResetToPool() { }

	// RVA: 0x1EF5080 Offset: 0x1EF3680 VA: 0x181EF5080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF3EE0 Offset: 0x1EF24E0 VA: 0x181EF3EE0
	public void CopyTo(Tree instance) { }

	// RVA: 0x1EF3F20 Offset: 0x1EF2520 VA: 0x181EF3F20
	public Tree Copy() { }

	// RVA: 0x1EF4E30 Offset: 0x1EF3430 VA: 0x181EF4E30
	public static Tree Deserialize(Stream stream) { }

	// RVA: 0x1EF4290 Offset: 0x1EF2890 VA: 0x181EF4290
	public static Tree DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF4310 Offset: 0x1EF2910 VA: 0x181EF4310
	public static Tree DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF4B40 Offset: 0x1EF3140 VA: 0x181EF4B40
	public static Tree Deserialize(byte[] buffer) { }

	// RVA: 0x1EF5100 Offset: 0x1EF3700 VA: 0x181EF5100
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF5B10 Offset: 0x1EF4110 VA: 0x181EF5B10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF5B30 Offset: 0x1EF4130 VA: 0x181EF5B30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Tree previous) { }

	// RVA: 0x1EF5320 Offset: 0x1EF3920 VA: 0x181EF5320 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF4650 Offset: 0x1EF2C50 VA: 0x181EF4650
	public static Tree Deserialize(byte[] buffer, Tree instance, bool isDelta = False) { }

	// RVA: 0x1EF4920 Offset: 0x1EF2F20 VA: 0x181EF4920
	public static Tree Deserialize(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF3FB0 Offset: 0x1EF25B0 VA: 0x181EF3FB0
	public static Tree DeserializeLengthDelimited(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF43A0 Offset: 0x1EF29A0 VA: 0x181EF43A0
	public static Tree DeserializeLength(Stream stream, int length, Tree instance, bool isDelta) { }

	// RVA: 0x1EF5480 Offset: 0x1EF3A80 VA: 0x181EF5480
	public static void SerializeDelta(Stream stream, Tree instance, Tree previous) { }

	// RVA: 0x1EF5910 Offset: 0x1EF3F10 VA: 0x181EF5910
	public static void Serialize(Stream stream, Tree instance) { }

	// RVA: 0x1EF5B00 Offset: 0x1EF4100 VA: 0x181EF5B00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF5B10 Offset: 0x1EF4110 VA: 0x181EF5B10
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF5800 Offset: 0x1EF3E00 VA: 0x181EF5800
	public static byte[] SerializeToBytes(Tree instance) { }

	// RVA: 0x1EF5750 Offset: 0x1EF3D50 VA: 0x181EF5750
	public static void SerializeLengthDelimited(Stream stream, Tree instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

internal sealed class Tree // TypeDefIndex: 6953
{	// Fields
	private static readonly int HEAP_SIZE; // 0x0
	internal static readonly int[] ExtraLengthBits; // 0x8
	internal static readonly int[] ExtraDistanceBits; // 0x10
	internal static readonly int[] extra_blbits; // 0x18
	internal static readonly sbyte[] bl_order; // 0x20
	private static readonly sbyte[] _dist_code; // 0x28
	internal static readonly sbyte[] LengthCode; // 0x30
	internal static readonly int[] LengthBase; // 0x38
	internal static readonly int[] DistanceBase; // 0x40
	internal short[] dyn_tree; // 0x10
	internal int max_code; // 0x18
	internal StaticTree staticTree; // 0x20

	// Methods

	// RVA: 0x21D4F50 Offset: 0x21D3550 VA: 0x1821D4F50
	internal static int DistanceCode(int dist) { }

	// RVA: 0x21D59D0 Offset: 0x21D3FD0 VA: 0x1821D59D0
	internal void gen_bitlen(DeflateManager s) { }

	// RVA: 0x21D5300 Offset: 0x21D3900 VA: 0x1821D5300
	internal void build_tree(DeflateManager s) { }

	// RVA: 0x21D5EE0 Offset: 0x21D44E0 VA: 0x1821D5EE0
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	// RVA: 0x21D52D0 Offset: 0x21D38D0 VA: 0x1821D52D0
	internal static int bi_reverse(int code, int len) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21D5040 Offset: 0x21D3640 VA: 0x1821D5040
	private static void .cctor() { }

}

public class Tree : ConsoleSystem // TypeDefIndex: 11970
{	// Fields
	private static float m_quality; // 0x0
	private static int m_meshes; // 0x4

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static int meshes { get; set; }

	// Methods

	// RVA: 0x36C330 Offset: 0x36A930 VA: 0x18036C330
	public static float get_quality() { }

	// RVA: 0x36C500 Offset: 0x36AB00 VA: 0x18036C500
	public static void set_quality(float value) { }

	// RVA: 0x36C220 Offset: 0x36A820 VA: 0x18036C220
	public static float get_lod() { }

	// RVA: 0x36C140 Offset: 0x36A740 VA: 0x18036C140
	public static float get_cull() { }

	// RVA: 0x36C2D0 Offset: 0x36A8D0 VA: 0x18036C2D0
	public static int get_meshes() { }

	// RVA: 0x36C390 Offset: 0x36A990 VA: 0x18036C390
	public static void set_meshes(int value) { }

	// RVA: 0x36C0E0 Offset: 0x36A6E0 VA: 0x18036C0E0
	public void .ctor() { }

	// RVA: 0x36C090 Offset: 0x36A690 VA: 0x18036C090
	private static void .cctor() { }

}

