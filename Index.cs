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

	// RVA: 0xE8BEA0 Offset: 0xE8A4A0 VA: 0x180E8BEA0
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE8BED0 Offset: 0xE8A4D0 VA: 0x180E8BED0
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE89D30 Offset: 0xE88330 VA: 0x180E89D30
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xE8C020 Offset: 0xE8A620 VA: 0x180E8C020
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE894F0 Offset: 0xE87AF0 VA: 0x180E894F0
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE8C3A0 Offset: 0xE8A9A0 VA: 0x180E8C3A0
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	internal int get_ObjectID() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xE8C3C0 Offset: 0xE8A9C0 VA: 0x180E8C3C0
	public IFilter get_RowFilter() { }

	// RVA: 0xE8A230 Offset: 0xE88830 VA: 0x180E8A230
	public int GetRecord(int recordIndex) { }

	// RVA: 0xE8C350 Offset: 0xE8A950 VA: 0x180E8C350
	public bool get_HasDuplicates() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_RecordCount() { }

	// RVA: 0xE8C3B0 Offset: 0xE8A9B0 VA: 0x180E8C3B0
	public bool get_IsSharable() { }

	// RVA: 0xE88980 Offset: 0xE86F80 VA: 0x180E88980
	private bool AcceptRecord(int record) { }

	// RVA: 0xE889B0 Offset: 0xE86FB0 VA: 0x180E889B0
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xE8AEF0 Offset: 0xE894F0 VA: 0x180E8AEF0
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xE8AF50 Offset: 0xE89550 VA: 0x180E8AF50
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_RefCount() { }

	// RVA: 0xE88AF0 Offset: 0xE870F0 VA: 0x180E88AF0
	public void AddRef() { }

	// RVA: 0xE8BAB0 Offset: 0xE8A0B0 VA: 0x180E8BAB0
	public int RemoveRef() { }

	// RVA: 0xE88C70 Offset: 0xE87270 VA: 0x180E88C70
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xE88D40 Offset: 0xE87340 VA: 0x180E88D40
	public bool CheckUnique() { }

	// RVA: 0xE89170 Offset: 0xE87770 VA: 0x180E89170
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xE88D90 Offset: 0xE87390 VA: 0x180E88D90
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xE88E50 Offset: 0xE87450 VA: 0x180E88E50
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xE89050 Offset: 0xE87650 VA: 0x180E89050
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xE893D0 Offset: 0xE879D0 VA: 0x180E893D0
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xE894E0 Offset: 0xE87AE0 VA: 0x180E894E0
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xE893E0 Offset: 0xE879E0 VA: 0x180E893E0
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xE89E50 Offset: 0xE88450 VA: 0x180E89E50
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0xE8A040 Offset: 0xE88640 VA: 0x180E8A040
	public int GetIndex(int record) { }

	// RVA: 0xE89EC0 Offset: 0xE884C0 VA: 0x180E89EC0
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xE8A740 Offset: 0xE88D40 VA: 0x180E8A740
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xE89660 Offset: 0xE87C60 VA: 0x180E89660
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xE89850 Offset: 0xE87E50 VA: 0x180E89850
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xE895A0 Offset: 0xE87BA0 VA: 0x180E895A0
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xE8A0A0 Offset: 0xE886A0 VA: 0x180E8A0A0
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xE89BC0 Offset: 0xE881C0 VA: 0x180E89BC0
	public Range FindRecords(object key) { }

	// RVA: 0xE89B70 Offset: 0xE88170 VA: 0x180E89B70
	public Range FindRecords(object[] key) { }

	// RVA: 0xE89C10 Offset: 0xE88210 VA: 0x180E89C10
	internal void FireResetEvent() { }

	// RVA: 0xE89E30 Offset: 0xE88430 VA: 0x180E89E30
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE8A290 Offset: 0xE88890 VA: 0x180E8A290
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xE8A2B0 Offset: 0xE888B0 VA: 0x180E8A2B0
	public DataRow GetRow(int i) { }

	// RVA: 0xE8A350 Offset: 0xE88950 VA: 0x180E8A350
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xE8A3A0 Offset: 0xE889A0 VA: 0x180E8A3A0
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xE8A880 Offset: 0xE88E80 VA: 0x180E8A880
	private void InitRecords(IFilter filter) { }

	// RVA: 0xE8AB90 Offset: 0xE89190 VA: 0x180E8AB90
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xE8ABF0 Offset: 0xE891F0 VA: 0x180E8ABF0
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xE8AE10 Offset: 0xE89410 VA: 0x180E8AE10
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xE8ADF0 Offset: 0xE893F0 VA: 0x180E8ADF0
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xE8AE30 Offset: 0xE89430 VA: 0x180E8AE30
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xE8C2E0 Offset: 0xE8A8E0 VA: 0x180E8C2E0
	private bool get_DoListChanged() { }

	// RVA: 0xE8B0D0 Offset: 0xE896D0 VA: 0x180E8B0D0
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xE8B1C0 Offset: 0xE897C0 VA: 0x180E8B1C0
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xE8B290 Offset: 0xE89890 VA: 0x180E8B290
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE8AFB0 Offset: 0xE895B0 VA: 0x180E8AFB0
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xE8BC50 Offset: 0xE8A250 VA: 0x180E8BC50
	public void Reset() { }

	// RVA: 0xE8B530 Offset: 0xE89B30 VA: 0x180E8B530
	public void RecordChanged(int record) { }

	// RVA: 0xE8B400 Offset: 0xE89A00 VA: 0x180E8B400
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xE8B660 Offset: 0xE89C60 VA: 0x180E8B660
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE8B760 Offset: 0xE89D60 VA: 0x180E8B760
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal DataTable get_Table() { }

	// RVA: 0xE8A580 Offset: 0xE88B80 VA: 0x180E8A580
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4BC0 Offset: 0xED31C0 VA: 0x180ED4BC0
	|-Index.IndexOfReference<object>
	*/

}

private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 4301
{	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xE88920 Offset: 0xE86F20 VA: 0x180E88920
	internal void .ctor(Index index) { }

	// RVA: 0xE888E0 Offset: 0xE86EE0 VA: 0x180E888E0 Slot: 5
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xE88900 Offset: 0xE86F00 VA: 0x180E88900 Slot: 6
	protected override int CompareSateliteTreeNode(int record1, int record2) { }

}

private sealed class Index.<>c // TypeDefIndex: 4302
{	// Fields
	public static readonly Index.<>c <>9; // 0x0
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0; // 0x8
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0; // 0x10

	// Methods

	// RVA: 0xEA9050 Offset: 0xEA7650 VA: 0x180EA9050
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF7D0 Offset: 0xDEDDD0 VA: 0x180DEF7D0
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xEA8FE0 Offset: 0xEA75E0 VA: 0x180EA8FE0
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 4303
{	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xEA9010 Offset: 0xEA7610 VA: 0x180EA9010
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

}

