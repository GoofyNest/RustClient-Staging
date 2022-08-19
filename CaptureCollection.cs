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

	// RVA: 0x14BF090 Offset: 0x14BD690 VA: 0x1814BF090
	internal void .ctor(Group group) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 5
	public int get_Count() { }

	// RVA: 0x14BF120 Offset: 0x14BD720 VA: 0x1814BF120
	public Capture get_Item(int i) { }

	// RVA: 0x14BED10 Offset: 0x14BD310 VA: 0x1814BED10 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14BF020 Offset: 0x14BD620 VA: 0x1814BF020 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14BEDD0 Offset: 0x14BD3D0 VA: 0x1814BEDD0
	internal Capture GetCapture(int i) { }

	// RVA: 0x14BF0F0 Offset: 0x14BD6F0 VA: 0x1814BF0F0
	internal void .ctor() { }

}

