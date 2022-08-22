public class ListChangedEventArgs : EventArgs // TypeDefIndex: 2725
{	// Fields
	private ListChangedType listChangedType; // 0x10
	private int newIndex; // 0x14
	private int oldIndex; // 0x18
	private PropertyDescriptor propDesc; // 0x20

	// Properties
	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }

	// Methods

	// RVA: 0x15C7BE0 Offset: 0x15C61E0 VA: 0x1815C7BE0
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x15C7B40 Offset: 0x15C6140 VA: 0x1815C7B40
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x15C7AC0 Offset: 0x15C60C0 VA: 0x1815C7AC0
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x15C7A40 Offset: 0x15C6040 VA: 0x1815C7A40
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public int get_NewIndex() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_OldIndex() { }

}

