public class UniqueConstraint : Constraint // TypeDefIndex: 4311
{	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48

	// Properties
	internal Index ConstraintIndex { get; }
	[ReadOnlyAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnlyAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public override DataTable Table { get; }

	// Methods

	// RVA: 0xCCEB30 Offset: 0xCCD130 VA: 0x180CCEB30
	public void .ctor(DataColumn column) { }

	// RVA: 0xCCEAF0 Offset: 0xCCD0F0 VA: 0x180CCEAF0
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xCCEC00 Offset: 0xCCD200 VA: 0x180CCEC00
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xCCEC40 Offset: 0xCCD240 VA: 0x180CCEC40
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Index get_ConstraintIndex() { }

	// RVA: 0xCCE540 Offset: 0xCCCB40 VA: 0x180CCE540
	internal void ConstraintIndexClear() { }

	// RVA: 0xCCE580 Offset: 0xCCCB80 VA: 0x180CCE580
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xCCDCF0 Offset: 0xCCC2F0 VA: 0x180CCDCF0 Slot: 16
	internal override void CheckState() { }

	// RVA: 0xCCDCF0 Offset: 0xCCC2F0 VA: 0x180CCDCF0
	private void NonVirtualCheckState() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xCCD9F0 Offset: 0xCCBFF0 VA: 0x180CCD9F0 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xCCDB80 Offset: 0xCCC180 VA: 0x180CCDB80 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0xCCE830 Offset: 0xCCCE30 VA: 0x180CCE830 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0xCCDBD0 Offset: 0xCCC1D0 VA: 0x180CCDBD0 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xCCE5D0 Offset: 0xCCCBD0 VA: 0x180CCE5D0 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCCDD00 Offset: 0xCCC300 VA: 0x180CCDD00 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xCCDD20 Offset: 0xCCC320 VA: 0x180CCDD20 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xCCE190 Offset: 0xCCC790 VA: 0x180CCE190
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xCCEC90 Offset: 0xCCD290 VA: 0x180CCEC90 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xCCECA0 Offset: 0xCCD2A0 VA: 0x180CCECA0
	public bool get_IsPrimaryKey() { }

	// RVA: 0xCCE5E0 Offset: 0xCCCBE0 VA: 0x180CCE5E0
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xCCE700 Offset: 0xCCCD00 VA: 0x180CCE700 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xCCED30 Offset: 0xCCD330 VA: 0x180CCED30 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal DataKey get_Key() { }

	// RVA: 0xCCED00 Offset: 0xCCD300 VA: 0x180CCED00 Slot: 8
	public override DataTable get_Table() { }

}

