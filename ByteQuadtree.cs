public sealed class ByteQuadtree // TypeDefIndex: 10279
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int levels; // 0x14
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ByteMap[] values; // 0x18

	// Properties
	public int Size { get; }
	public ByteQuadtree.Element Root { get; }

	// Methods

	// RVA: 0x6F30C0 Offset: 0x6F16C0 VA: 0x1806F30C0
	public void UpdateValues(byte[] baseValues) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x6F34A0 Offset: 0x6F1AA0 VA: 0x1806F34A0
	public ByteQuadtree.Element get_Root() { }

	// RVA: 0x6F2FF0 Offset: 0x6F15F0 VA: 0x1806F2FF0
	private ByteMap CreateLevel(int level) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct ByteQuadtree.Element // TypeDefIndex: 10280
{	// Fields
	private ByteQuadtree source; // 0x0
	private int x; // 0x8
	private int y; // 0xC
	private int level; // 0x10

	// Properties
	public bool IsLeaf { get; }
	public bool IsRoot { get; }
	public int ByteMap { get; }
	public uint Value { get; }
	public Vector2 Coords { get; }
	public int Depth { get; }
	public ByteQuadtree.Element Parent { get; }
	public ByteQuadtree.Element Child1 { get; }
	public ByteQuadtree.Element Child2 { get; }
	public ByteQuadtree.Element Child3 { get; }
	public ByteQuadtree.Element Child4 { get; }
	public ByteQuadtree.Element MaxChild { get; }
	public ByteQuadtree.Element RandChild { get; }

	// Methods

	// RVA: 0xF4820 Offset: 0xF3C20 VA: 0x1800F4820
	public void .ctor(ByteQuadtree source, int x, int y, int level) { }

	// RVA: 0xF4950 Offset: 0xF3D50 VA: 0x1800F4950
	public bool get_IsLeaf() { }

	// RVA: 0xF4960 Offset: 0xF3D60 VA: 0x1800F4960
	public bool get_IsRoot() { }

	// RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	public int get_ByteMap() { }

	// RVA: 0xF4AA0 Offset: 0xF3EA0 VA: 0x1800F4AA0
	public uint get_Value() { }

	// RVA: 0xF48F0 Offset: 0xF3CF0 VA: 0x1800F48F0
	public Vector2 get_Coords() { }

	// RVA: 0xF4930 Offset: 0xF3D30 VA: 0x1800F4930
	public int get_Depth() { }

	// RVA: 0xF49B0 Offset: 0xF3DB0 VA: 0x1800F49B0
	public ByteQuadtree.Element get_Parent() { }

	// RVA: 0xF4870 Offset: 0xF3C70 VA: 0x1800F4870
	public ByteQuadtree.Element get_Child1() { }

	// RVA: 0xF4890 Offset: 0xF3C90 VA: 0x1800F4890
	public ByteQuadtree.Element get_Child2() { }

	// RVA: 0xF48B0 Offset: 0xF3CB0 VA: 0x1800F48B0
	public ByteQuadtree.Element get_Child3() { }

	// RVA: 0xF48D0 Offset: 0xF3CD0 VA: 0x1800F48D0
	public ByteQuadtree.Element get_Child4() { }

	// RVA: 0xF4990 Offset: 0xF3D90 VA: 0x1800F4990
	public ByteQuadtree.Element get_MaxChild() { }

	// RVA: 0xF4A80 Offset: 0xF3E80 VA: 0x1800F4A80
	public ByteQuadtree.Element get_RandChild() { }

}

