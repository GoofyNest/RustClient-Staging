public abstract class Constraint // TypeDefIndex: 4174
{	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	[DefaultValueAttribute] // RVA: 0x91B10 Offset: 0x90F10 VA: 0x180091B10
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	protected virtual DataSet _DataSet { get; }


	public virtual string get_ConstraintName() { }

	public virtual void set_ConstraintName(string value) { }

	internal string get_SchemaName() { }

	internal void set_SchemaName(string value) { }

	internal virtual bool get_InCollection() { }

	internal virtual void set_InCollection(bool value) { }

	public abstract DataTable get_Table();

	public PropertyCollection get_ExtendedProperties() { }

	internal abstract bool ContainsColumn(DataColumn column);

	internal abstract bool CanEnableConstraint();

	internal abstract Constraint Clone(DataSet destination);

	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	internal void CheckConstraint() { }

	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	internal abstract void CheckState();

	protected void CheckStateForProperty() { }

	protected virtual DataSet get__DataSet() { }

	internal abstract bool IsConstraintViolated();

	public override string ToString() { }

	protected void .ctor() { }

}

