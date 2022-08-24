public class UniqueConstraint : Constraint // TypeDefIndex: 4311
{	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48

	internal Index ConstraintIndex { get; }
	[ReadOnlyAttribute] // RVA: 0x760B0 Offset: 0x754B0 VA: 0x1800760B0
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnlyAttribute] // RVA: 0x760B0 Offset: 0x754B0 VA: 0x1800760B0
	public override DataTable Table { get; }


	public void .ctor(DataColumn column) { }

	public void .ctor(string name, DataColumn[] columns) { }

	public void .ctor(DataColumn[] columns) { }

	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	internal Index get_ConstraintIndex() { }

	internal void ConstraintIndexClear() { }

	internal void ConstraintIndexInitialize() { }

	internal override void CheckState() { }

	private void NonVirtualCheckState() { }

	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	internal override bool CanEnableConstraint() { }

	internal override bool IsConstraintViolated() { }

	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	internal override bool ContainsColumn(DataColumn column) { }

	internal override Constraint Clone(DataSet destination) { }

	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	internal UniqueConstraint Clone(DataTable table) { }

	public virtual DataColumn[] get_Columns() { }

	internal DataColumn[] get_ColumnsReference() { }

	public bool get_IsPrimaryKey() { }

	private void Create(string constraintName, DataColumn[] columns) { }

	public override bool Equals(object key2) { }

	public override int GetHashCode() { }

	internal override void set_InCollection(bool value) { }

	internal DataKey get_Key() { }

	public override DataTable get_Table() { }

}

