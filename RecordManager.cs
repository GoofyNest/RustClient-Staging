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

	// RVA: 0xE95880 Offset: 0xE93E80 VA: 0x180E95880
	internal void .ctor(DataTable table) { }

	// RVA: 0xE95510 Offset: 0xE93B10 VA: 0x180E95510
	private void GrowRecordCapacity() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_LastFreeRecord() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	internal int get_MinimumCapacity() { }

	// RVA: 0xE95A00 Offset: 0xE94000 VA: 0x180E95A00
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_RecordCapacity() { }

	// RVA: 0xE95A60 Offset: 0xE94060 VA: 0x180E95A60
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xE95720 Offset: 0xE93D20 VA: 0x180E95720
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xE95800 Offset: 0xE93E00 VA: 0x180E95800
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xE95740 Offset: 0xE93D40 VA: 0x180E95740
	internal int NewRecordBase() { }

	// RVA: 0xE953D0 Offset: 0xE939D0 VA: 0x180E953D0
	internal void FreeRecord(ref int record) { }

	// RVA: 0xE94F20 Offset: 0xE93520 VA: 0x180E94F20
	internal void Clear(bool clearAll) { }

	// RVA: 0xE95930 Offset: 0xE93F30 VA: 0x180E95930
	internal DataRow get_Item(int record) { }

	// RVA: 0xE95970 Offset: 0xE93F70 VA: 0x180E95970
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xE95700 Offset: 0xE93D00 VA: 0x180E95700
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xE95120 Offset: 0xE93720 VA: 0x180E95120
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xE95840 Offset: 0xE93E40 VA: 0x180E95840
	internal void SetRowCache(DataRow[] newRows) { }

}

