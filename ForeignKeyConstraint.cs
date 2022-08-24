public class ForeignKeyConstraint : Constraint // TypeDefIndex: 4268
{	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50

	internal DataKey ChildKey { get; }
	[ReadOnlyAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public virtual DataColumn[] Columns { get; }
	[ReadOnlyAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public override DataTable Table { get; }
	[DefaultValueAttribute] // RVA: 0xA5AB0 Offset: 0xA4EB0 VA: 0x1800A5AB0
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValueAttribute] // RVA: 0xA5C20 Offset: 0xA5020 VA: 0x1800A5C20
	public virtual Rule DeleteRule { get; set; }
	[ReadOnlyAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnlyAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public virtual DataTable RelatedTable { get; }
	[DefaultValueAttribute] // RVA: 0xA5E90 Offset: 0xA5290 VA: 0x1800A5E90
	public virtual Rule UpdateRule { get; set; }


	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	internal DataKey get_ChildKey() { }

	public virtual DataColumn[] get_Columns() { }

	public override DataTable get_Table() { }

	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	internal bool IsKeyNull(object[] values) { }

	internal override bool IsConstraintViolated() { }

	internal override bool CanEnableConstraint() { }

	internal void CascadeCommit(DataRow row) { }

	internal void CascadeDelete(DataRow row) { }

	internal void CascadeRollback(DataRow row) { }

	internal void CascadeUpdate(DataRow row) { }

	internal void CheckCanClearParentTable(DataTable table) { }

	internal void CheckCanRemoveParentRow(DataRow row) { }

	internal void CheckCascade(DataRow row, DataRowAction action) { }

	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	private void NonVirtualCheckState() { }

	internal override void CheckState() { }

	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	internal override bool ContainsColumn(DataColumn column) { }

	internal override Constraint Clone(DataSet destination) { }

	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	internal ForeignKeyConstraint Clone(DataTable destination) { }

	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	public virtual Rule get_DeleteRule() { }

	public virtual void set_DeleteRule(Rule value) { }

	public override bool Equals(object key) { }

	public override int GetHashCode() { }

	public virtual DataColumn[] get_RelatedColumns() { }

	internal DataColumn[] get_RelatedColumnsReference() { }

	internal DataKey get_ParentKey() { }

	internal DataRelation FindParentRelation() { }

	public virtual DataTable get_RelatedTable() { }

	public virtual Rule get_UpdateRule() { }

	public virtual void set_UpdateRule(Rule value) { }

}

