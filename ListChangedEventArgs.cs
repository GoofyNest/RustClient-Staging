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

	// RVA: 0x15C8B10 Offset: 0x15C7110 VA: 0x1815C8B10
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x15C8A70 Offset: 0x15C7070 VA: 0x1815C8A70
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x15C89F0 Offset: 0x15C6FF0 VA: 0x1815C89F0
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x15C8970 Offset: 0x15C6F70 VA: 0x1815C8970
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_NewIndex() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_OldIndex() { }

}

