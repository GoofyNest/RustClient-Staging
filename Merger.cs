internal sealed class Merger // TypeDefIndex: 4277
{	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0xE909A0 Offset: 0xE8EFA0 VA: 0x180E909A0
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xE90930 Offset: 0xE8EF30 VA: 0x180E90930
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xE8DEA0 Offset: 0xE8C4A0 VA: 0x180E8DEA0
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xE901C0 Offset: 0xE8E7C0 VA: 0x180E901C0
	internal void MergeTable(DataTable src) { }

	// RVA: 0xE90420 Offset: 0xE8EA20 VA: 0x180E90420
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xE8F7B0 Offset: 0xE8DDB0 VA: 0x180E8F7B0
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xE90100 Offset: 0xE8E700 VA: 0x180E90100
	private void MergeTableData(DataTable src) { }

	// RVA: 0xE8DE10 Offset: 0xE8C410 VA: 0x180E8DE10
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xE8DB70 Offset: 0xE8C170 VA: 0x180E8DB70
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xE8ED30 Offset: 0xE8D330 VA: 0x180E8ED30
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xE8EB90 Offset: 0xE8D190 VA: 0x180E8EB90
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xE8D9E0 Offset: 0xE8BFE0 VA: 0x180E8D9E0
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

}

