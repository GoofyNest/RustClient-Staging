public class ForeignKeyConstraint : Constraint // TypeDefIndex: 4268
{	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnlyAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual DataColumn[] Columns { get; }
	[ReadOnlyAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public override DataTable Table { get; }
	[DefaultValueAttribute] // RVA: 0xA59C0 Offset: 0xA4DC0 VA: 0x1800A59C0
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValueAttribute] // RVA: 0xA5B30 Offset: 0xA4F30 VA: 0x1800A5B30
	public virtual Rule DeleteRule { get; set; }
	[ReadOnlyAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnlyAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual DataTable RelatedTable { get; }
	[DefaultValueAttribute] // RVA: 0xA5D70 Offset: 0xA5170 VA: 0x1800A5D70
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x13E8D10 Offset: 0x13E7310 VA: 0x1813E8D10
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E8D70 Offset: 0x13E7370 VA: 0x1813E8D70
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E8E00 Offset: 0x13E7400 VA: 0x1813E8E00
	internal DataKey get_ChildKey() { }

	// RVA: 0x13E8E20 Offset: 0x13E7420 VA: 0x1813E8E20 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x13E8EC0 Offset: 0x13E74C0 VA: 0x1813E8EC0 Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x13E6CC0 Offset: 0x13E52C0 VA: 0x1813E6CC0 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x13E8970 Offset: 0x13E6F70 VA: 0x1813E8970
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x13E8610 Offset: 0x13E6C10 VA: 0x1813E8610 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x13E5B40 Offset: 0x13E4140 VA: 0x1813E5B40 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x13E5D40 Offset: 0x13E4340 VA: 0x1813E5D40
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x13E5ED0 Offset: 0x13E44D0 VA: 0x1813E5ED0
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x13E64C0 Offset: 0x13E4AC0 VA: 0x1813E64C0
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x13E6700 Offset: 0x13E4D00 VA: 0x1813E6700
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x13E6E30 Offset: 0x13E5430 VA: 0x1813E6E30
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x13E6F50 Offset: 0x13E5550 VA: 0x1813E6F50
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x13E7020 Offset: 0x13E5620 VA: 0x1813E7020
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x13E72D0 Offset: 0x13E58D0 VA: 0x1813E72D0 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x13E8A30 Offset: 0x13E7030 VA: 0x1813E8A30
	private void NonVirtualCheckState() { }

	// RVA: 0x13E75F0 Offset: 0x13E5BF0 VA: 0x1813E75F0 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x13E8DE0 Offset: 0x13E73E0 VA: 0x1813E8DE0 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x13E8F00 Offset: 0x13E7500 VA: 0x1813E8F00 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x13E8180 Offset: 0x13E6780 VA: 0x1813E8180 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCCDD00 Offset: 0xCCC300 VA: 0x180CCDD00 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x13E7600 Offset: 0x13E5C00 VA: 0x1813E7600 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x13E7C70 Offset: 0x13E6270 VA: 0x1813E7C70
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x13E81D0 Offset: 0x13E67D0 VA: 0x1813E81D0
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E8E40 Offset: 0x13E7440 VA: 0x1813E8E40 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x13E8F80 Offset: 0x13E7580 VA: 0x1813E8F80 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x13E83F0 Offset: 0x13E69F0 VA: 0x1813E83F0 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13E8E80 Offset: 0x13E7480 VA: 0x1813E8E80 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x13E8E60 Offset: 0x13E7460 VA: 0x1813E8E60
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x13E8E60 Offset: 0x13E7460 VA: 0x1813E8E60
	internal DataKey get_ParentKey() { }

	// RVA: 0x13E8530 Offset: 0x13E6B30 VA: 0x1813E8530
	internal DataRelation FindParentRelation() { }

	// RVA: 0x13E8EA0 Offset: 0x13E74A0 VA: 0x1813E8EA0 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x13E8EE0 Offset: 0x13E74E0 VA: 0x1813E8EE0 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x13E9000 Offset: 0x13E7600 VA: 0x1813E9000 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }

}

