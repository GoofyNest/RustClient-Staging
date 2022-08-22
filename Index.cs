internal sealed class Index // TypeDefIndex: 4300
{	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public bool IsSharable { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0xE8C950 Offset: 0xE8AF50 VA: 0x180E8C950
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE8C980 Offset: 0xE8AF80 VA: 0x180E8C980
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE8A7E0 Offset: 0xE88DE0 VA: 0x180E8A7E0
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xE8CAD0 Offset: 0xE8B0D0 VA: 0x180E8CAD0
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE89FA0 Offset: 0xE885A0 VA: 0x180E89FA0
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE8CE50 Offset: 0xE8B450 VA: 0x180E8CE50
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	internal int get_ObjectID() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xE8CE70 Offset: 0xE8B470 VA: 0x180E8CE70
	public IFilter get_RowFilter() { }

	// RVA: 0xE8ACE0 Offset: 0xE892E0 VA: 0x180E8ACE0
	public int GetRecord(int recordIndex) { }

	// RVA: 0xE8CE00 Offset: 0xE8B400 VA: 0x180E8CE00
	public bool get_HasDuplicates() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public int get_RecordCount() { }

	// RVA: 0xE8CE60 Offset: 0xE8B460 VA: 0x180E8CE60
	public bool get_IsSharable() { }

	// RVA: 0xE89430 Offset: 0xE87A30 VA: 0x180E89430
	private bool AcceptRecord(int record) { }

	// RVA: 0xE89460 Offset: 0xE87A60 VA: 0x180E89460
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xE8B9A0 Offset: 0xE89FA0 VA: 0x180E8B9A0
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xE8BA00 Offset: 0xE8A000 VA: 0x180E8BA00
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public int get_RefCount() { }

	// RVA: 0xE895A0 Offset: 0xE87BA0 VA: 0x180E895A0
	public void AddRef() { }

	// RVA: 0xE8C560 Offset: 0xE8AB60 VA: 0x180E8C560
	public int RemoveRef() { }

	// RVA: 0xE89720 Offset: 0xE87D20 VA: 0x180E89720
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xE897F0 Offset: 0xE87DF0 VA: 0x180E897F0
	public bool CheckUnique() { }

	// RVA: 0xE89C20 Offset: 0xE88220 VA: 0x180E89C20
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xE89840 Offset: 0xE87E40 VA: 0x180E89840
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xE89900 Offset: 0xE87F00 VA: 0x180E89900
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xE89B00 Offset: 0xE88100 VA: 0x180E89B00
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xE89E80 Offset: 0xE88480 VA: 0x180E89E80
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xE89F90 Offset: 0xE88590 VA: 0x180E89F90
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xE89E90 Offset: 0xE88490 VA: 0x180E89E90
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xE8A900 Offset: 0xE88F00 VA: 0x180E8A900
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0xE8AAF0 Offset: 0xE890F0 VA: 0x180E8AAF0
	public int GetIndex(int record) { }

	// RVA: 0xE8A970 Offset: 0xE88F70 VA: 0x180E8A970
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xE8B1F0 Offset: 0xE897F0 VA: 0x180E8B1F0
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xE8A110 Offset: 0xE88710 VA: 0x180E8A110
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xE8A300 Offset: 0xE88900 VA: 0x180E8A300
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xE8A050 Offset: 0xE88650 VA: 0x180E8A050
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xE8AB50 Offset: 0xE89150 VA: 0x180E8AB50
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xE8A670 Offset: 0xE88C70 VA: 0x180E8A670
	public Range FindRecords(object key) { }

	// RVA: 0xE8A620 Offset: 0xE88C20 VA: 0x180E8A620
	public Range FindRecords(object[] key) { }

	// RVA: 0xE8A6C0 Offset: 0xE88CC0 VA: 0x180E8A6C0
	internal void FireResetEvent() { }

	// RVA: 0xE8A8E0 Offset: 0xE88EE0 VA: 0x180E8A8E0
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE8AD40 Offset: 0xE89340 VA: 0x180E8AD40
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xE8AD60 Offset: 0xE89360 VA: 0x180E8AD60
	public DataRow GetRow(int i) { }

	// RVA: 0xE8AE00 Offset: 0xE89400 VA: 0x180E8AE00
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xE8AE50 Offset: 0xE89450 VA: 0x180E8AE50
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xE8B330 Offset: 0xE89930 VA: 0x180E8B330
	private void InitRecords(IFilter filter) { }

	// RVA: 0xE8B640 Offset: 0xE89C40 VA: 0x180E8B640
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xE8B6A0 Offset: 0xE89CA0 VA: 0x180E8B6A0
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xE8B8C0 Offset: 0xE89EC0 VA: 0x180E8B8C0
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xE8B8A0 Offset: 0xE89EA0 VA: 0x180E8B8A0
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xE8B8E0 Offset: 0xE89EE0 VA: 0x180E8B8E0
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xE8CD90 Offset: 0xE8B390 VA: 0x180E8CD90
	private bool get_DoListChanged() { }

	// RVA: 0xE8BB80 Offset: 0xE8A180 VA: 0x180E8BB80
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xE8BC70 Offset: 0xE8A270 VA: 0x180E8BC70
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xE8BD40 Offset: 0xE8A340 VA: 0x180E8BD40
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE8BA60 Offset: 0xE8A060 VA: 0x180E8BA60
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xE8C700 Offset: 0xE8AD00 VA: 0x180E8C700
	public void Reset() { }

	// RVA: 0xE8BFE0 Offset: 0xE8A5E0 VA: 0x180E8BFE0
	public void RecordChanged(int record) { }

	// RVA: 0xE8BEB0 Offset: 0xE8A4B0 VA: 0x180E8BEB0
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xE8C110 Offset: 0xE8A710 VA: 0x180E8C110
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE8C210 Offset: 0xE8A810 VA: 0x180E8C210
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal DataTable get_Table() { }

	// RVA: 0xE8B030 Offset: 0xE89630 VA: 0x180E8B030
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED5670 Offset: 0xED3C70 VA: 0x180ED5670
	|-Index.IndexOfReference<object>
	*/

}

private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 4301
{	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xE893D0 Offset: 0xE879D0 VA: 0x180E893D0
	internal void .ctor(Index index) { }

	// RVA: 0xE89390 Offset: 0xE87990 VA: 0x180E89390 Slot: 5
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xE893B0 Offset: 0xE879B0 VA: 0x180E893B0 Slot: 6
	protected override int CompareSateliteTreeNode(int record1, int record2) { }

}

private sealed class Index.<>c // TypeDefIndex: 4302
{	// Fields
	public static readonly Index.<>c <>9; // 0x0
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0; // 0x8
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0; // 0x10

	// Methods

	// RVA: 0xEA9B00 Offset: 0xEA8100 VA: 0x180EA9B00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0280 Offset: 0xDEE880 VA: 0x180DF0280
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xEA9A90 Offset: 0xEA8090 VA: 0x180EA9A90
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 4303
{	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xEA9AC0 Offset: 0xEA80C0 VA: 0x180EA9AC0
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

}

