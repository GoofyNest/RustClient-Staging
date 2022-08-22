internal sealed class Merger // TypeDefIndex: 4277
{	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0xE91450 Offset: 0xE8FA50 VA: 0x180E91450
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xE913E0 Offset: 0xE8F9E0 VA: 0x180E913E0
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xE8E950 Offset: 0xE8CF50 VA: 0x180E8E950
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xE90C70 Offset: 0xE8F270 VA: 0x180E90C70
	internal void MergeTable(DataTable src) { }

	// RVA: 0xE90ED0 Offset: 0xE8F4D0 VA: 0x180E90ED0
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xE90260 Offset: 0xE8E860 VA: 0x180E90260
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xE90BB0 Offset: 0xE8F1B0 VA: 0x180E90BB0
	private void MergeTableData(DataTable src) { }

	// RVA: 0xE8E8C0 Offset: 0xE8CEC0 VA: 0x180E8E8C0
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xE8E620 Offset: 0xE8CC20 VA: 0x180E8E620
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xE8F7E0 Offset: 0xE8DDE0 VA: 0x180E8F7E0
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xE8F640 Offset: 0xE8DC40 VA: 0x180E8F640
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xE8E490 Offset: 0xE8CA90 VA: 0x180E8E490
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

}

