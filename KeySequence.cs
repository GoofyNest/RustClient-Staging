internal class KeySequence // TypeDefIndex: 2151
{	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0xB111B0 Offset: 0xB0F7B0 VA: 0x180B111B0
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_PosLine() { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_PosCol() { }

	// RVA: 0x9EB8A0 Offset: 0x9E9EA0 VA: 0x1809EB8A0
	public object get_Item(int index) { }

	// RVA: 0xB11240 Offset: 0xB0F840 VA: 0x180B11240
	public void set_Item(int index, object value) { }

	// RVA: 0xB11000 Offset: 0xB0F600 VA: 0x180B11000
	internal bool IsQualified() { }

	// RVA: 0xB10B30 Offset: 0xB0F130 VA: 0x180B10B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xB10A00 Offset: 0xB0F000 VA: 0x180B10A00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xB11060 Offset: 0xB0F660 VA: 0x180B11060 Slot: 3
	public override string ToString() { }

}

