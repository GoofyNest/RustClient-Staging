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

	// RVA: 0x13E7E10 Offset: 0x13E6410 VA: 0x1813E7E10
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E7E70 Offset: 0x13E6470 VA: 0x1813E7E70
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E7F00 Offset: 0x13E6500 VA: 0x1813E7F00
	internal DataKey get_ChildKey() { }

	// RVA: 0x13E7F20 Offset: 0x13E6520 VA: 0x1813E7F20 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x13E7FC0 Offset: 0x13E65C0 VA: 0x1813E7FC0 Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x13E5DC0 Offset: 0x13E43C0 VA: 0x1813E5DC0 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x13E7A70 Offset: 0x13E6070 VA: 0x1813E7A70
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x13E7710 Offset: 0x13E5D10 VA: 0x1813E7710 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x13E4C40 Offset: 0x13E3240 VA: 0x1813E4C40 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x13E4E40 Offset: 0x13E3440 VA: 0x1813E4E40
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x13E4FD0 Offset: 0x13E35D0 VA: 0x1813E4FD0
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x13E55C0 Offset: 0x13E3BC0 VA: 0x1813E55C0
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x13E5800 Offset: 0x13E3E00 VA: 0x1813E5800
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x13E5F30 Offset: 0x13E4530 VA: 0x1813E5F30
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x13E6050 Offset: 0x13E4650 VA: 0x1813E6050
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x13E6120 Offset: 0x13E4720 VA: 0x1813E6120
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x13E63D0 Offset: 0x13E49D0 VA: 0x1813E63D0 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x13E7B30 Offset: 0x13E6130 VA: 0x1813E7B30
	private void NonVirtualCheckState() { }

	// RVA: 0x13E66F0 Offset: 0x13E4CF0 VA: 0x1813E66F0 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x13E7EE0 Offset: 0x13E64E0 VA: 0x1813E7EE0 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x13E8000 Offset: 0x13E6600 VA: 0x1813E8000 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x13E7280 Offset: 0x13E5880 VA: 0x1813E7280 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCCE1A0 Offset: 0xCCC7A0 VA: 0x180CCE1A0 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x13E6700 Offset: 0x13E4D00 VA: 0x1813E6700 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x13E6D70 Offset: 0x13E5370 VA: 0x1813E6D70
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x13E72D0 Offset: 0x13E58D0 VA: 0x1813E72D0
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E7F40 Offset: 0x13E6540 VA: 0x1813E7F40 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x13E8080 Offset: 0x13E6680 VA: 0x1813E8080 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x13E74F0 Offset: 0x13E5AF0 VA: 0x1813E74F0 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13E7F80 Offset: 0x13E6580 VA: 0x1813E7F80 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x13E7F60 Offset: 0x13E6560 VA: 0x1813E7F60
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x13E7F60 Offset: 0x13E6560 VA: 0x1813E7F60
	internal DataKey get_ParentKey() { }

	// RVA: 0x13E7630 Offset: 0x13E5C30 VA: 0x1813E7630
	internal DataRelation FindParentRelation() { }

	// RVA: 0x13E7FA0 Offset: 0x13E65A0 VA: 0x1813E7FA0 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x13E7FE0 Offset: 0x13E65E0 VA: 0x1813E7FE0 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x13E8100 Offset: 0x13E6700 VA: 0x1813E8100 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }

}

