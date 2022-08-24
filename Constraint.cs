public abstract class Constraint // TypeDefIndex: 4174
{	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	[DefaultValueAttribute] // RVA: 0x91BC0 Offset: 0x90FC0 VA: 0x180091BC0
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[BrowsableAttribute] // RVA: 0x9AA30 Offset: 0x99E30 VA: 0x18009AA30
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliantAttribute] // RVA: 0x6F4E0 Offset: 0x6E8E0 VA: 0x18006F4E0
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

