internal sealed class Merger // TypeDefIndex: 4277
{	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0xE906E0 Offset: 0xE8ECE0 VA: 0x180E906E0
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xE90670 Offset: 0xE8EC70 VA: 0x180E90670
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xE8DBE0 Offset: 0xE8C1E0 VA: 0x180E8DBE0
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xE8FF00 Offset: 0xE8E500 VA: 0x180E8FF00
	internal void MergeTable(DataTable src) { }

	// RVA: 0xE90160 Offset: 0xE8E760 VA: 0x180E90160
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xE8F4F0 Offset: 0xE8DAF0 VA: 0x180E8F4F0
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xE8FE40 Offset: 0xE8E440 VA: 0x180E8FE40
	private void MergeTableData(DataTable src) { }

	// RVA: 0xE8DB50 Offset: 0xE8C150 VA: 0x180E8DB50
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xE8D8B0 Offset: 0xE8BEB0 VA: 0x180E8D8B0
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xE8EA70 Offset: 0xE8D070 VA: 0x180E8EA70
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xE8E8D0 Offset: 0xE8CED0 VA: 0x180E8E8D0
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xE8D720 Offset: 0xE8BD20 VA: 0x180E8D720
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

}

