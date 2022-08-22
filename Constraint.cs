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

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x12295D0 Offset: 0x1227BD0 VA: 0x1812295D0 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x1229590 Offset: 0x1227B90 VA: 0x181229590
	internal string get_SchemaName() { }

	// RVA: 0x1229850 Offset: 0x1227E50 VA: 0x181229850
	internal void set_SchemaName(string value) { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0 Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x12297F0 Offset: 0x1227DF0 VA: 0x1812297F0 Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x1229520 Offset: 0x1227B20 VA: 0x181229520
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x1229310 Offset: 0x1227910 VA: 0x181229310
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x1229380 Offset: 0x1227980 VA: 0x181229380
	protected void CheckStateForProperty() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x12294B0 Offset: 0x1227AB0 VA: 0x1812294B0
	protected void .ctor() { }

}

