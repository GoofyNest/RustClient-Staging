public sealed class ConstraintCollection : InternalDataCollectionBase // TypeDefIndex: 4175
{	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private CollectionChangeEventHandler _onCollectionChanged; // 0x28
	private Constraint[] _delayLoadingConstraints; // 0x30
	private bool _fLoadForeignKeyConstraintsOnly; // 0x38

	// Properties
	protected override ArrayList List { get; }
	public Constraint Item { get; }
	internal DataTable Table { get; }
	public Constraint Item { get; }

	// Methods

	// RVA: 0x1228F30 Offset: 0x1227530 VA: 0x181228F30
	internal void .ctor(DataTable table) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x12290F0 Offset: 0x12276F0 VA: 0x1812290F0
	public Constraint get_Item(int index) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal DataTable get_Table() { }

	// RVA: 0x1228FE0 Offset: 0x12275E0 VA: 0x181228FE0
	public Constraint get_Item(string name) { }

	// RVA: 0x1226820 Offset: 0x1224E20 VA: 0x181226820
	public void Add(Constraint constraint) { }

	// RVA: 0x12268E0 Offset: 0x1224EE0 VA: 0x1812268E0
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0x1226830 Offset: 0x1224E30 VA: 0x181226830
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0x1226720 Offset: 0x1224D20 VA: 0x181226720
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0x1226690 Offset: 0x1224C90 VA: 0x181226690
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0x1227290 Offset: 0x1225890 VA: 0x181227290
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0x12271F0 Offset: 0x12257F0 VA: 0x1812271F0
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0x1227230 Offset: 0x1225830 VA: 0x181227230
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0x1227270 Offset: 0x1225870 VA: 0x181227270
	internal string AssignName() { }

	// RVA: 0x1227360 Offset: 0x1225960 VA: 0x181227360
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0x1227450 Offset: 0x1225A50 VA: 0x181227450
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0x12276A0 Offset: 0x1225CA0 VA: 0x1812276A0
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0x1227A20 Offset: 0x1226020 VA: 0x181227A20
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0x1227A50 Offset: 0x1226050 VA: 0x181227A50
	public void Clear() { }

	// RVA: 0x1228000 Offset: 0x1226600 VA: 0x181228000
	public bool Contains(string name) { }

	// RVA: 0x1228020 Offset: 0x1226620 VA: 0x181228020
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1228190 Offset: 0x1226790 VA: 0x181228190
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0x1228510 Offset: 0x1226B10 VA: 0x181228510
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0x1228650 Offset: 0x1226C50 VA: 0x181228650
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0x12283B0 Offset: 0x12269B0 VA: 0x1812283B0
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1227F50 Offset: 0x1226550 VA: 0x181227F50
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0x1228780 Offset: 0x1226D80 VA: 0x181228780
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0x1228920 Offset: 0x1226F20 VA: 0x181228920
	private string MakeName(int index) { }

	// RVA: 0xE68170 Offset: 0xE66770 VA: 0x180E68170
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x12289B0 Offset: 0x1226FB0 VA: 0x1812289B0
	internal void RegisterName(string name) { }

	// RVA: 0x1228C30 Offset: 0x1227230 VA: 0x181228C30
	public void Remove(Constraint constraint) { }

	// RVA: 0x1228E20 Offset: 0x1227420 VA: 0x181228E20
	internal void UnregisterName(string name) { }

}

