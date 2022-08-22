public class Tree : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6496
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint netId; // 0x14
	public uint prefabId; // 0x18
	public Half3 position; // 0x1C
	public float scale; // 0x28

	// Methods

	// RVA: 0x1EF5E20 Offset: 0x1EF4420 VA: 0x181EF5E20
	public static void ResetToPool(Tree instance) { }

	// RVA: 0x1EF5EC0 Offset: 0x1EF44C0 VA: 0x181EF5EC0
	public void ResetToPool() { }

	// RVA: 0x1EF5B60 Offset: 0x1EF4160 VA: 0x181EF5B60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF49C0 Offset: 0x1EF2FC0 VA: 0x181EF49C0
	public void CopyTo(Tree instance) { }

	// RVA: 0x1EF4A00 Offset: 0x1EF3000 VA: 0x181EF4A00
	public Tree Copy() { }

	// RVA: 0x1EF5910 Offset: 0x1EF3F10 VA: 0x181EF5910
	public static Tree Deserialize(Stream stream) { }

	// RVA: 0x1EF4D70 Offset: 0x1EF3370 VA: 0x181EF4D70
	public static Tree DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF4DF0 Offset: 0x1EF33F0 VA: 0x181EF4DF0
	public static Tree DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF5620 Offset: 0x1EF3C20 VA: 0x181EF5620
	public static Tree Deserialize(byte[] buffer) { }

	// RVA: 0x1EF5BE0 Offset: 0x1EF41E0 VA: 0x181EF5BE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF65F0 Offset: 0x1EF4BF0 VA: 0x181EF65F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF6610 Offset: 0x1EF4C10 VA: 0x181EF6610 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Tree previous) { }

	// RVA: 0x1EF5E00 Offset: 0x1EF4400 VA: 0x181EF5E00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF5130 Offset: 0x1EF3730 VA: 0x181EF5130
	public static Tree Deserialize(byte[] buffer, Tree instance, bool isDelta = False) { }

	// RVA: 0x1EF5400 Offset: 0x1EF3A00 VA: 0x181EF5400
	public static Tree Deserialize(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF4A90 Offset: 0x1EF3090 VA: 0x181EF4A90
	public static Tree DeserializeLengthDelimited(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF4E80 Offset: 0x1EF3480 VA: 0x181EF4E80
	public static Tree DeserializeLength(Stream stream, int length, Tree instance, bool isDelta) { }

	// RVA: 0x1EF5F60 Offset: 0x1EF4560 VA: 0x181EF5F60
	public static void SerializeDelta(Stream stream, Tree instance, Tree previous) { }

	// RVA: 0x1EF63F0 Offset: 0x1EF49F0 VA: 0x181EF63F0
	public static void Serialize(Stream stream, Tree instance) { }

	// RVA: 0x1EF65E0 Offset: 0x1EF4BE0 VA: 0x181EF65E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF65F0 Offset: 0x1EF4BF0 VA: 0x181EF65F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF62E0 Offset: 0x1EF48E0 VA: 0x181EF62E0
	public static byte[] SerializeToBytes(Tree instance) { }

	// RVA: 0x1EF6230 Offset: 0x1EF4830 VA: 0x181EF6230
	public static void SerializeLengthDelimited(Stream stream, Tree instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x21D5A30 Offset: 0x21D4030 VA: 0x1821D5A30
	internal static int DistanceCode(int dist) { }

	// RVA: 0x21D64B0 Offset: 0x21D4AB0 VA: 0x1821D64B0
	internal void gen_bitlen(DeflateManager s) { }

	// RVA: 0x21D5DE0 Offset: 0x21D43E0 VA: 0x1821D5DE0
	internal void build_tree(DeflateManager s) { }

	// RVA: 0x21D69C0 Offset: 0x21D4FC0 VA: 0x1821D69C0
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	// RVA: 0x21D5DB0 Offset: 0x21D43B0 VA: 0x1821D5DB0
	internal static int bi_reverse(int code, int len) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21D5B20 Offset: 0x21D4120 VA: 0x1821D5B20
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

