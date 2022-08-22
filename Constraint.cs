public abstract class Constraint // TypeDefIndex: 4174
{	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Properties
	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	protected virtual DataSet _DataSet { get; }

	// Methods

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x1229F30 Offset: 0x1228530 VA: 0x181229F30 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x1229EF0 Offset: 0x12284F0 VA: 0x181229EF0
	internal string get_SchemaName() { }

	// RVA: 0x122A1B0 Offset: 0x12287B0 VA: 0x18122A1B0
	internal void set_SchemaName(string value) { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0 Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x122A150 Offset: 0x1228750 VA: 0x18122A150 Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x1229E80 Offset: 0x1228480 VA: 0x181229E80
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x1229C70 Offset: 0x1228270 VA: 0x181229C70
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x1229CE0 Offset: 0x12282E0 VA: 0x181229CE0
	protected void CheckStateForProperty() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1229E10 Offset: 0x1228410 VA: 0x181229E10
	protected void .ctor() { }

}

