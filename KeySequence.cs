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

	// RVA: 0xB11680 Offset: 0xB0FC80 VA: 0x180B11680
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_PosLine() { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_PosCol() { }

	// RVA: 0x9EBD90 Offset: 0x9EA390 VA: 0x1809EBD90
	public object get_Item(int index) { }

	// RVA: 0xB11710 Offset: 0xB0FD10 VA: 0x180B11710
	public void set_Item(int index, object value) { }

	// RVA: 0xB114D0 Offset: 0xB0FAD0 VA: 0x180B114D0
	internal bool IsQualified() { }

	// RVA: 0xB11000 Offset: 0xB0F600 VA: 0x180B11000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xB10ED0 Offset: 0xB0F4D0 VA: 0x180B10ED0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xB11530 Offset: 0xB0FB30 VA: 0x180B11530 Slot: 3
	public override string ToString() { }

}

