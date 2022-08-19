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

	// RVA: 0xE8BBE0 Offset: 0xE8A1E0 VA: 0x180E8BBE0
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE8BC10 Offset: 0xE8A210 VA: 0x180E8BC10
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE89A70 Offset: 0xE88070 VA: 0x180E89A70
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xE8BD60 Offset: 0xE8A360 VA: 0x180E8BD60
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE89230 Offset: 0xE87830 VA: 0x180E89230
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xE8C0E0 Offset: 0xE8A6E0 VA: 0x180E8C0E0
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	internal int get_ObjectID() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xE8C100 Offset: 0xE8A700 VA: 0x180E8C100
	public IFilter get_RowFilter() { }

	// RVA: 0xE89F70 Offset: 0xE88570 VA: 0x180E89F70
	public int GetRecord(int recordIndex) { }

	// RVA: 0xE8C090 Offset: 0xE8A690 VA: 0x180E8C090
	public bool get_HasDuplicates() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_RecordCount() { }

	// RVA: 0xE8C0F0 Offset: 0xE8A6F0 VA: 0x180E8C0F0
	public bool get_IsSharable() { }

	// RVA: 0xE886C0 Offset: 0xE86CC0 VA: 0x180E886C0
	private bool AcceptRecord(int record) { }

	// RVA: 0xE886F0 Offset: 0xE86CF0 VA: 0x180E886F0
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xE8AC30 Offset: 0xE89230 VA: 0x180E8AC30
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xE8AC90 Offset: 0xE89290 VA: 0x180E8AC90
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_RefCount() { }

	// RVA: 0xE88830 Offset: 0xE86E30 VA: 0x180E88830
	public void AddRef() { }

	// RVA: 0xE8B7F0 Offset: 0xE89DF0 VA: 0x180E8B7F0
	public int RemoveRef() { }

	// RVA: 0xE889B0 Offset: 0xE86FB0 VA: 0x180E889B0
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xE88A80 Offset: 0xE87080 VA: 0x180E88A80
	public bool CheckUnique() { }

	// RVA: 0xE88EB0 Offset: 0xE874B0 VA: 0x180E88EB0
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xE88AD0 Offset: 0xE870D0 VA: 0x180E88AD0
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xE88B90 Offset: 0xE87190 VA: 0x180E88B90
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xE88D90 Offset: 0xE87390 VA: 0x180E88D90
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xE89110 Offset: 0xE87710 VA: 0x180E89110
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xE89220 Offset: 0xE87820 VA: 0x180E89220
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xE89120 Offset: 0xE87720 VA: 0x180E89120
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xE89B90 Offset: 0xE88190 VA: 0x180E89B90
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0xE89D80 Offset: 0xE88380 VA: 0x180E89D80
	public int GetIndex(int record) { }

	// RVA: 0xE89C00 Offset: 0xE88200 VA: 0x180E89C00
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xE8A480 Offset: 0xE88A80 VA: 0x180E8A480
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xE893A0 Offset: 0xE879A0 VA: 0x180E893A0
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xE89590 Offset: 0xE87B90 VA: 0x180E89590
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xE892E0 Offset: 0xE878E0 VA: 0x180E892E0
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xE89DE0 Offset: 0xE883E0 VA: 0x180E89DE0
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xE89900 Offset: 0xE87F00 VA: 0x180E89900
	public Range FindRecords(object key) { }

	// RVA: 0xE898B0 Offset: 0xE87EB0 VA: 0x180E898B0
	public Range FindRecords(object[] key) { }

	// RVA: 0xE89950 Offset: 0xE87F50 VA: 0x180E89950
	internal void FireResetEvent() { }

	// RVA: 0xE89B70 Offset: 0xE88170 VA: 0x180E89B70
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE89FD0 Offset: 0xE885D0 VA: 0x180E89FD0
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xE89FF0 Offset: 0xE885F0 VA: 0x180E89FF0
	public DataRow GetRow(int i) { }

	// RVA: 0xE8A090 Offset: 0xE88690 VA: 0x180E8A090
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xE8A0E0 Offset: 0xE886E0 VA: 0x180E8A0E0
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xE8A5C0 Offset: 0xE88BC0 VA: 0x180E8A5C0
	private void InitRecords(IFilter filter) { }

	// RVA: 0xE8A8D0 Offset: 0xE88ED0 VA: 0x180E8A8D0
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xE8A930 Offset: 0xE88F30 VA: 0x180E8A930
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xE8AB50 Offset: 0xE89150 VA: 0x180E8AB50
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xE8AB30 Offset: 0xE89130 VA: 0x180E8AB30
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xE8AB70 Offset: 0xE89170 VA: 0x180E8AB70
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xE8C020 Offset: 0xE8A620 VA: 0x180E8C020
	private bool get_DoListChanged() { }

	// RVA: 0xE8AE10 Offset: 0xE89410 VA: 0x180E8AE10
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xE8AF00 Offset: 0xE89500 VA: 0x180E8AF00
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xE8AFD0 Offset: 0xE895D0 VA: 0x180E8AFD0
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE8ACF0 Offset: 0xE892F0 VA: 0x180E8ACF0
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xE8B990 Offset: 0xE89F90 VA: 0x180E8B990
	public void Reset() { }

	// RVA: 0xE8B270 Offset: 0xE89870 VA: 0x180E8B270
	public void RecordChanged(int record) { }

	// RVA: 0xE8B140 Offset: 0xE89740 VA: 0x180E8B140
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xE8B3A0 Offset: 0xE899A0 VA: 0x180E8B3A0
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xE8B4A0 Offset: 0xE89AA0 VA: 0x180E8B4A0
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal DataTable get_Table() { }

	// RVA: 0xE8A2C0 Offset: 0xE888C0 VA: 0x180E8A2C0
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4900 Offset: 0xED2F00 VA: 0x180ED4900
	|-Index.IndexOfReference<object>
	*/

}

private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 4301
{	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xE88660 Offset: 0xE86C60 VA: 0x180E88660
	internal void .ctor(Index index) { }

	// RVA: 0xE88620 Offset: 0xE86C20 VA: 0x180E88620 Slot: 5
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xE88640 Offset: 0xE86C40 VA: 0x180E88640 Slot: 6
	protected override int CompareSateliteTreeNode(int record1, int record2) { }

}

private sealed class Index.<>c // TypeDefIndex: 4302
{	// Fields
	public static readonly Index.<>c <>9; // 0x0
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0; // 0x8
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0; // 0x10

	// Methods

	// RVA: 0xEA8D90 Offset: 0xEA7390 VA: 0x180EA8D90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF510 Offset: 0xDEDB10 VA: 0x180DEF510
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xEA8D20 Offset: 0xEA7320 VA: 0x180EA8D20
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 4303
{	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xEA8D50 Offset: 0xEA7350 VA: 0x180EA8D50
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

}

