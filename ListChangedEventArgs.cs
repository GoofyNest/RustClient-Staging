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

	// RVA: 0x15C8850 Offset: 0x15C6E50 VA: 0x1815C8850
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x15C87B0 Offset: 0x15C6DB0 VA: 0x1815C87B0
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x15C8730 Offset: 0x15C6D30 VA: 0x1815C8730
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x15C86B0 Offset: 0x15C6CB0 VA: 0x1815C86B0
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_NewIndex() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_OldIndex() { }

}

