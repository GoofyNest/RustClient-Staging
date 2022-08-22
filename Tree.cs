public class Tree : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6496
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint netId; // 0x14
	public uint prefabId; // 0x18
	public Half3 position; // 0x1C
	public float scale; // 0x28

	// Methods

	// RVA: 0x1EF5600 Offset: 0x1EF3C00 VA: 0x181EF5600
	public static void ResetToPool(Tree instance) { }

	// RVA: 0x1EF56A0 Offset: 0x1EF3CA0 VA: 0x181EF56A0
	public void ResetToPool() { }

	// RVA: 0x1EF5340 Offset: 0x1EF3940 VA: 0x181EF5340 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF41A0 Offset: 0x1EF27A0 VA: 0x181EF41A0
	public void CopyTo(Tree instance) { }

	// RVA: 0x1EF41E0 Offset: 0x1EF27E0 VA: 0x181EF41E0
	public Tree Copy() { }

	// RVA: 0x1EF50F0 Offset: 0x1EF36F0 VA: 0x181EF50F0
	public static Tree Deserialize(Stream stream) { }

	// RVA: 0x1EF4550 Offset: 0x1EF2B50 VA: 0x181EF4550
	public static Tree DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF45D0 Offset: 0x1EF2BD0 VA: 0x181EF45D0
	public static Tree DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF4E00 Offset: 0x1EF3400 VA: 0x181EF4E00
	public static Tree Deserialize(byte[] buffer) { }

	// RVA: 0x1EF53C0 Offset: 0x1EF39C0 VA: 0x181EF53C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF5DD0 Offset: 0x1EF43D0 VA: 0x181EF5DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF5DF0 Offset: 0x1EF43F0 VA: 0x181EF5DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Tree previous) { }

	// RVA: 0x1EF55E0 Offset: 0x1EF3BE0 VA: 0x181EF55E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF4910 Offset: 0x1EF2F10 VA: 0x181EF4910
	public static Tree Deserialize(byte[] buffer, Tree instance, bool isDelta = False) { }

	// RVA: 0x1EF4BE0 Offset: 0x1EF31E0 VA: 0x181EF4BE0
	public static Tree Deserialize(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF4270 Offset: 0x1EF2870 VA: 0x181EF4270
	public static Tree DeserializeLengthDelimited(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF4660 Offset: 0x1EF2C60 VA: 0x181EF4660
	public static Tree DeserializeLength(Stream stream, int length, Tree instance, bool isDelta) { }

	// RVA: 0x1EF5740 Offset: 0x1EF3D40 VA: 0x181EF5740
	public static void SerializeDelta(Stream stream, Tree instance, Tree previous) { }

	// RVA: 0x1EF5BD0 Offset: 0x1EF41D0 VA: 0x181EF5BD0
	public static void Serialize(Stream stream, Tree instance) { }

	// RVA: 0x1EF5DC0 Offset: 0x1EF43C0 VA: 0x181EF5DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF5DD0 Offset: 0x1EF43D0 VA: 0x181EF5DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF5AC0 Offset: 0x1EF40C0 VA: 0x181EF5AC0
	public static byte[] SerializeToBytes(Tree instance) { }

	// RVA: 0x1EF5A10 Offset: 0x1EF4010 VA: 0x181EF5A10
	public static void SerializeLengthDelimited(Stream stream, Tree instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x21D5210 Offset: 0x21D3810 VA: 0x1821D5210
	internal static int DistanceCode(int dist) { }

	// RVA: 0x21D5C90 Offset: 0x21D4290 VA: 0x1821D5C90
	internal void gen_bitlen(DeflateManager s) { }

	// RVA: 0x21D55C0 Offset: 0x21D3BC0 VA: 0x1821D55C0
	internal void build_tree(DeflateManager s) { }

	// RVA: 0x21D61A0 Offset: 0x21D47A0 VA: 0x1821D61A0
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	// RVA: 0x21D5590 Offset: 0x21D3B90 VA: 0x1821D5590
	internal static int bi_reverse(int code, int len) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21D5300 Offset: 0x21D3900 VA: 0x1821D5300
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

