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

	// RVA: 0xCCEFD0 Offset: 0xCCD5D0 VA: 0x180CCEFD0
	public void .ctor(DataColumn column) { }

	// RVA: 0xCCEF90 Offset: 0xCCD590 VA: 0x180CCEF90
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xCCF0A0 Offset: 0xCCD6A0 VA: 0x180CCF0A0
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xCCF0E0 Offset: 0xCCD6E0 VA: 0x180CCF0E0
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal Index get_ConstraintIndex() { }

	// RVA: 0xCCE9E0 Offset: 0xCCCFE0 VA: 0x180CCE9E0
	internal void ConstraintIndexClear() { }

	// RVA: 0xCCEA20 Offset: 0xCCD020 VA: 0x180CCEA20
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xCCE190 Offset: 0xCCC790 VA: 0x180CCE190 Slot: 16
	internal override void CheckState() { }

	// RVA: 0xCCE190 Offset: 0xCCC790 VA: 0x180CCE190
	private void NonVirtualCheckState() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xCCDE90 Offset: 0xCCC490 VA: 0x180CCDE90 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xCCE020 Offset: 0xCCC620 VA: 0x180CCE020 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0xCCECD0 Offset: 0xCCD2D0 VA: 0x180CCECD0 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0xCCE070 Offset: 0xCCC670 VA: 0x180CCE070 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xCCEA70 Offset: 0xCCD070 VA: 0x180CCEA70 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCCE1A0 Offset: 0xCCC7A0 VA: 0x180CCE1A0 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xCCE1C0 Offset: 0xCCC7C0 VA: 0x180CCE1C0 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xCCE630 Offset: 0xCCCC30 VA: 0x180CCE630
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xCCF130 Offset: 0xCCD730 VA: 0x180CCF130 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xCCF140 Offset: 0xCCD740 VA: 0x180CCF140
	public bool get_IsPrimaryKey() { }

	// RVA: 0xCCEA80 Offset: 0xCCD080 VA: 0x180CCEA80
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xCCEBA0 Offset: 0xCCD1A0 VA: 0x180CCEBA0 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xCCF1D0 Offset: 0xCCD7D0 VA: 0x180CCF1D0 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal DataKey get_Key() { }

	// RVA: 0xCCF1A0 Offset: 0xCCD7A0 VA: 0x180CCF1A0 Slot: 8
	public override DataTable get_Table() { }

}

