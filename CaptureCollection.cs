public class CaptureCollection : ICollection, IEnumerable // TypeDefIndex: 2606
{	// Fields
	internal Group _group; // 0x10
	internal int _capcount; // 0x18
	internal Capture[] _captures; // 0x20

	// Properties
	public object SyncRoot { get; }
	public int Count { get; }
	public Capture Item { get; }

	// Methods

	// RVA: 0x14BE420 Offset: 0x14BCA20 VA: 0x1814BE420
	internal void .ctor(Group group) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 5
	public int get_Count() { }

	// RVA: 0x14BE4B0 Offset: 0x14BCAB0 VA: 0x1814BE4B0
	public Capture get_Item(int i) { }

	// RVA: 0x14BE0A0 Offset: 0x14BC6A0 VA: 0x1814BE0A0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14BE3B0 Offset: 0x14BC9B0 VA: 0x1814BE3B0 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14BE160 Offset: 0x14BC760 VA: 0x1814BE160
	internal Capture GetCapture(int i) { }

	// RVA: 0x14BE480 Offset: 0x14BCA80 VA: 0x1814BE480
	internal void .ctor() { }

}

