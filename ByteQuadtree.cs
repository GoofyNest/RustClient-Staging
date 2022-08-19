public sealed class ByteQuadtree // TypeDefIndex: 10279
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int levels; // 0x14
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ByteMap[] values; // 0x18

	// Properties
	public int Size { get; }
	public ByteQuadtree.Element Root { get; }

	// Methods

	// RVA: 0x6F3020 Offset: 0x6F1620 VA: 0x1806F3020
	public void UpdateValues(byte[] baseValues) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x6F3400 Offset: 0x6F1A00 VA: 0x1806F3400
	public ByteQuadtree.Element get_Root() { }

	// RVA: 0x6F2F50 Offset: 0x6F1550 VA: 0x1806F2F50
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

	// RVA: 0xF48A0 Offset: 0xF3CA0 VA: 0x1800F48A0
	public void .ctor(ByteQuadtree source, int x, int y, int level) { }

	// RVA: 0xF49D0 Offset: 0xF3DD0 VA: 0x1800F49D0
	public bool get_IsLeaf() { }

	// RVA: 0xF49E0 Offset: 0xF3DE0 VA: 0x1800F49E0
	public bool get_IsRoot() { }

	// RVA: 0xF3F30 Offset: 0xF3330 VA: 0x1800F3F30
	public int get_ByteMap() { }

	// RVA: 0xF4B20 Offset: 0xF3F20 VA: 0x1800F4B20
	public uint get_Value() { }

	// RVA: 0xF4970 Offset: 0xF3D70 VA: 0x1800F4970
	public Vector2 get_Coords() { }

	// RVA: 0xF49B0 Offset: 0xF3DB0 VA: 0x1800F49B0
	public int get_Depth() { }

	// RVA: 0xF4A30 Offset: 0xF3E30 VA: 0x1800F4A30
	public ByteQuadtree.Element get_Parent() { }

	// RVA: 0xF48F0 Offset: 0xF3CF0 VA: 0x1800F48F0
	public ByteQuadtree.Element get_Child1() { }

	// RVA: 0xF4910 Offset: 0xF3D10 VA: 0x1800F4910
	public ByteQuadtree.Element get_Child2() { }

	// RVA: 0xF4930 Offset: 0xF3D30 VA: 0x1800F4930
	public ByteQuadtree.Element get_Child3() { }

	// RVA: 0xF4950 Offset: 0xF3D50 VA: 0x1800F4950
	public ByteQuadtree.Element get_Child4() { }

	// RVA: 0xF4A10 Offset: 0xF3E10 VA: 0x1800F4A10
	public ByteQuadtree.Element get_MaxChild() { }

	// RVA: 0xF4B00 Offset: 0xF3F00 VA: 0x1800F4B00
	public ByteQuadtree.Element get_RandChild() { }

}

