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

	// RVA: 0x13E8A50 Offset: 0x13E7050 VA: 0x1813E8A50
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E8AB0 Offset: 0x13E70B0 VA: 0x1813E8AB0
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E8B40 Offset: 0x13E7140 VA: 0x1813E8B40
	internal DataKey get_ChildKey() { }

	// RVA: 0x13E8B60 Offset: 0x13E7160 VA: 0x1813E8B60 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x13E8C00 Offset: 0x13E7200 VA: 0x1813E8C00 Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x13E6A00 Offset: 0x13E5000 VA: 0x1813E6A00 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x13E86B0 Offset: 0x13E6CB0 VA: 0x1813E86B0
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x13E8350 Offset: 0x13E6950 VA: 0x1813E8350 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x13E5880 Offset: 0x13E3E80 VA: 0x1813E5880 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x13E5A80 Offset: 0x13E4080 VA: 0x1813E5A80
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x13E5C10 Offset: 0x13E4210 VA: 0x1813E5C10
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x13E6200 Offset: 0x13E4800 VA: 0x1813E6200
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x13E6440 Offset: 0x13E4A40 VA: 0x1813E6440
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x13E6B70 Offset: 0x13E5170 VA: 0x1813E6B70
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x13E6C90 Offset: 0x13E5290 VA: 0x1813E6C90
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x13E6D60 Offset: 0x13E5360 VA: 0x1813E6D60
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x13E7010 Offset: 0x13E5610 VA: 0x1813E7010 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x13E8770 Offset: 0x13E6D70 VA: 0x1813E8770
	private void NonVirtualCheckState() { }

	// RVA: 0x13E7330 Offset: 0x13E5930 VA: 0x1813E7330 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x13E8B20 Offset: 0x13E7120 VA: 0x1813E8B20 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x13E8C40 Offset: 0x13E7240 VA: 0x1813E8C40 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x13E7EC0 Offset: 0x13E64C0 VA: 0x1813E7EC0 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xCCDA40 Offset: 0xCCC040 VA: 0x180CCDA40 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x13E7340 Offset: 0x13E5940 VA: 0x1813E7340 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x13E79B0 Offset: 0x13E5FB0 VA: 0x1813E79B0
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x13E7F10 Offset: 0x13E6510 VA: 0x1813E7F10
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x13E8B80 Offset: 0x13E7180 VA: 0x1813E8B80 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x13E8CC0 Offset: 0x13E72C0 VA: 0x1813E8CC0 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x13E8130 Offset: 0x13E6730 VA: 0x1813E8130 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13E8BC0 Offset: 0x13E71C0 VA: 0x1813E8BC0 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x13E8BA0 Offset: 0x13E71A0 VA: 0x1813E8BA0
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x13E8BA0 Offset: 0x13E71A0 VA: 0x1813E8BA0
	internal DataKey get_ParentKey() { }

	// RVA: 0x13E8270 Offset: 0x13E6870 VA: 0x1813E8270
	internal DataRelation FindParentRelation() { }

	// RVA: 0x13E8BE0 Offset: 0x13E71E0 VA: 0x1813E8BE0 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x13E8C20 Offset: 0x13E7220 VA: 0x1813E8C20 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x13E8D40 Offset: 0x13E7340 VA: 0x1813E8D40 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }

}

