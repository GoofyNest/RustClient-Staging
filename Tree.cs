public class Tree : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6496
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint netId; // 0x14
	public uint prefabId; // 0x18
	public Half3 position; // 0x1C
	public float scale; // 0x28

	// Methods

	// RVA: 0x1EF5500 Offset: 0x1EF3B00 VA: 0x181EF5500
	public static void ResetToPool(Tree instance) { }

	// RVA: 0x1EF55A0 Offset: 0x1EF3BA0 VA: 0x181EF55A0
	public void ResetToPool() { }

	// RVA: 0x1EF5240 Offset: 0x1EF3840 VA: 0x181EF5240 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF40A0 Offset: 0x1EF26A0 VA: 0x181EF40A0
	public void CopyTo(Tree instance) { }

	// RVA: 0x1EF40E0 Offset: 0x1EF26E0 VA: 0x181EF40E0
	public Tree Copy() { }

	// RVA: 0x1EF4FF0 Offset: 0x1EF35F0 VA: 0x181EF4FF0
	public static Tree Deserialize(Stream stream) { }

	// RVA: 0x1EF4450 Offset: 0x1EF2A50 VA: 0x181EF4450
	public static Tree DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF44D0 Offset: 0x1EF2AD0 VA: 0x181EF44D0
	public static Tree DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF4D00 Offset: 0x1EF3300 VA: 0x181EF4D00
	public static Tree Deserialize(byte[] buffer) { }

	// RVA: 0x1EF52C0 Offset: 0x1EF38C0 VA: 0x181EF52C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF5CD0 Offset: 0x1EF42D0 VA: 0x181EF5CD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF5CF0 Offset: 0x1EF42F0 VA: 0x181EF5CF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Tree previous) { }

	// RVA: 0x1EF54E0 Offset: 0x1EF3AE0 VA: 0x181EF54E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF4810 Offset: 0x1EF2E10 VA: 0x181EF4810
	public static Tree Deserialize(byte[] buffer, Tree instance, bool isDelta = False) { }

	// RVA: 0x1EF4AE0 Offset: 0x1EF30E0 VA: 0x181EF4AE0
	public static Tree Deserialize(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF4170 Offset: 0x1EF2770 VA: 0x181EF4170
	public static Tree DeserializeLengthDelimited(Stream stream, Tree instance, bool isDelta) { }

	// RVA: 0x1EF4560 Offset: 0x1EF2B60 VA: 0x181EF4560
	public static Tree DeserializeLength(Stream stream, int length, Tree instance, bool isDelta) { }

	// RVA: 0x1EF5640 Offset: 0x1EF3C40 VA: 0x181EF5640
	public static void SerializeDelta(Stream stream, Tree instance, Tree previous) { }

	// RVA: 0x1EF5AD0 Offset: 0x1EF40D0 VA: 0x181EF5AD0
	public static void Serialize(Stream stream, Tree instance) { }

	// RVA: 0x1EF5CC0 Offset: 0x1EF42C0 VA: 0x181EF5CC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF5CD0 Offset: 0x1EF42D0 VA: 0x181EF5CD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF59C0 Offset: 0x1EF3FC0 VA: 0x181EF59C0
	public static byte[] SerializeToBytes(Tree instance) { }

	// RVA: 0x1EF5910 Offset: 0x1EF3F10 VA: 0x181EF5910
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

	// RVA: 0x21D5110 Offset: 0x21D3710 VA: 0x1821D5110
	internal static int DistanceCode(int dist) { }

	// RVA: 0x21D5B90 Offset: 0x21D4190 VA: 0x1821D5B90
	internal void gen_bitlen(DeflateManager s) { }

	// RVA: 0x21D54C0 Offset: 0x21D3AC0 VA: 0x1821D54C0
	internal void build_tree(DeflateManager s) { }

	// RVA: 0x21D60A0 Offset: 0x21D46A0 VA: 0x1821D60A0
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	// RVA: 0x21D5490 Offset: 0x21D3A90 VA: 0x1821D5490
	internal static int bi_reverse(int code, int len) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21D5200 Offset: 0x21D3800 VA: 0x1821D5200
	private static void .cctor() { }

}

public class Tree : ConsoleSystem // TypeDefIndex: 11970
{	// Fields
	private static float m_quality; // 0x0
	private static int m_meshes; // 0x4

	// Properties
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
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

