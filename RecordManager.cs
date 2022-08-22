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

	// RVA: 0xE96330 Offset: 0xE94930 VA: 0x180E96330
	internal void .ctor(DataTable table) { }

	// RVA: 0xE95FC0 Offset: 0xE945C0 VA: 0x180E95FC0
	private void GrowRecordCapacity() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	internal int get_LastFreeRecord() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	internal int get_MinimumCapacity() { }

	// RVA: 0xE964B0 Offset: 0xE94AB0 VA: 0x180E964B0
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal int get_RecordCapacity() { }

	// RVA: 0xE96510 Offset: 0xE94B10 VA: 0x180E96510
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xE961D0 Offset: 0xE947D0 VA: 0x180E961D0
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xE962B0 Offset: 0xE948B0 VA: 0x180E962B0
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xE961F0 Offset: 0xE947F0 VA: 0x180E961F0
	internal int NewRecordBase() { }

	// RVA: 0xE95E80 Offset: 0xE94480 VA: 0x180E95E80
	internal void FreeRecord(ref int record) { }

	// RVA: 0xE959D0 Offset: 0xE93FD0 VA: 0x180E959D0
	internal void Clear(bool clearAll) { }

	// RVA: 0xE963E0 Offset: 0xE949E0 VA: 0x180E963E0
	internal DataRow get_Item(int record) { }

	// RVA: 0xE96420 Offset: 0xE94A20 VA: 0x180E96420
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xE961B0 Offset: 0xE947B0 VA: 0x180E961B0
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xE95BD0 Offset: 0xE941D0 VA: 0x180E95BD0
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xE962F0 Offset: 0xE948F0 VA: 0x180E962F0
	internal void SetRowCache(DataRow[] newRows) { }

}

