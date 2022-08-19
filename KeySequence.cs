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

	// RVA: 0xB10EF0 Offset: 0xB0F4F0 VA: 0x180B10EF0
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_PosLine() { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_PosCol() { }

	// RVA: 0x9EB5E0 Offset: 0x9E9BE0 VA: 0x1809EB5E0
	public object get_Item(int index) { }

	// RVA: 0xB10F80 Offset: 0xB0F580 VA: 0x180B10F80
	public void set_Item(int index, object value) { }

	// RVA: 0xB10D40 Offset: 0xB0F340 VA: 0x180B10D40
	internal bool IsQualified() { }

	// RVA: 0xB10870 Offset: 0xB0EE70 VA: 0x180B10870 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xB10740 Offset: 0xB0ED40 VA: 0x180B10740 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xB10DA0 Offset: 0xB0F3A0 VA: 0x180B10DA0 Slot: 3
	public override string ToString() { }

}

