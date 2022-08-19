public class UniqueConstraint : Constraint // TypeDefIndex: 4311
{	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48

	// Properties
	internal Index ConstraintIndex { get; }
	[ReadOnlyAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnlyAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	public override DataTable Table { get; }

	// Methods

	// RVA: 0xCCE870 Offset: 0xCCCE70 VA: 0x180CCE870
	public void .ctor(DataColumn column) { }

	// RVA: 0xCCE830 Offset: 0xCCCE30 VA: 0x180CCE830
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xCCE940 Offset: 0xCCCF40 VA: 0x180CCE940
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xCCE980 Offset: 0xCCCF80 VA: 0x180CCE980
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal Index get_ConstraintIndex() { }

	// RVA: 0xCCE280 Offset: 0xCCC880 VA: 0x180CCE280
	internal void ConstraintIndexClear() { }

	// RVA: 0xCCE2C0 Offset: 0xCCC8C0 VA: 0x180CCE2C0
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xCCDA30 Offset: 0xCCC030 VA: 0x180CCDA30 Slot: 16
	internal override void CheckState() { }

	// RVA: 0xCCDA30 Offset: 0xCCC030 VA: 0x180CCDA30
	private void NonVirtualCheckState() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xCCD730 Offset: 0xCCBD30 VA: 0x180CCD730 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xCCD8C0 Offset: 0xCCBEC0 VA: 0x180CCD8C0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0xCCE570 Offset: 0xCCCB70 VA: 0x180CCE570 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0xCCD910 Offset: 0xCCBF10 VA: 0x180CCD910 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xCCE310 Offset: 0xCCC910 VA: 0x180CCE310 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCCDA40 Offset: 0xCCC040 VA: 0x180CCDA40 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xCCDA60 Offset: 0xCCC060 VA: 0x180CCDA60 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xCCDED0 Offset: 0xCCC4D0 VA: 0x180CCDED0
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xCCE9D0 Offset: 0xCCCFD0 VA: 0x180CCE9D0 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xCCE9E0 Offset: 0xCCCFE0 VA: 0x180CCE9E0
	public bool get_IsPrimaryKey() { }

	// RVA: 0xCCE320 Offset: 0xCCC920 VA: 0x180CCE320
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xCCE440 Offset: 0xCCCA40 VA: 0x180CCE440 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xCCEA70 Offset: 0xCCD070 VA: 0x180CCEA70 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal DataKey get_Key() { }

	// RVA: 0xCCEA40 Offset: 0xCCD040 VA: 0x180CCEA40 Slot: 8
	public override DataTable get_Table() { }

}

