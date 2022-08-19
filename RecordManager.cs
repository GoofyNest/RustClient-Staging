internal sealed class RecordManager // TypeDefIndex: 4292
{	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0xE955C0 Offset: 0xE93BC0 VA: 0x180E955C0
	internal void .ctor(DataTable table) { }

	// RVA: 0xE95250 Offset: 0xE93850 VA: 0x180E95250
	private void GrowRecordCapacity() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_LastFreeRecord() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	internal int get_MinimumCapacity() { }

	// RVA: 0xE95740 Offset: 0xE93D40 VA: 0x180E95740
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_RecordCapacity() { }

	// RVA: 0xE957A0 Offset: 0xE93DA0 VA: 0x180E957A0
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xE95460 Offset: 0xE93A60 VA: 0x180E95460
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xE95540 Offset: 0xE93B40 VA: 0x180E95540
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xE95480 Offset: 0xE93A80 VA: 0x180E95480
	internal int NewRecordBase() { }

	// RVA: 0xE95110 Offset: 0xE93710 VA: 0x180E95110
	internal void FreeRecord(ref int record) { }

	// RVA: 0xE94C60 Offset: 0xE93260 VA: 0x180E94C60
	internal void Clear(bool clearAll) { }

	// RVA: 0xE95670 Offset: 0xE93C70 VA: 0x180E95670
	internal DataRow get_Item(int record) { }

	// RVA: 0xE956B0 Offset: 0xE93CB0 VA: 0x180E956B0
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xE95440 Offset: 0xE93A40 VA: 0x180E95440
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xE94E60 Offset: 0xE93460 VA: 0x180E94E60
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xE95580 Offset: 0xE93B80 VA: 0x180E95580
	internal void SetRowCache(DataRow[] newRows) { }

}

