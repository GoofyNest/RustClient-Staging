internal sealed class NewDiffgramGen // TypeDefIndex: 4331
{	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0xE93E90 Offset: 0xE92490 VA: 0x180E93E90
	internal void .ctor(DataSet ds) { }

	// RVA: 0xE93FE0 Offset: 0xE925E0 VA: 0x180E93FE0
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xE91CC0 Offset: 0xE902C0 VA: 0x180E91CC0
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xE91F80 Offset: 0xE90580 VA: 0x180E91F80
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xE92280 Offset: 0xE90880 VA: 0x180E92280
	private bool EmptyData() { }

	// RVA: 0xE93E80 Offset: 0xE92480 VA: 0x180E93E80
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xE93950 Offset: 0xE91F50 VA: 0x180E93950
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xE93860 Offset: 0xE91E60 VA: 0x180E93860
	private void GenerateTable(DataTable table) { }

	// RVA: 0xE93290 Offset: 0xE91890 VA: 0x180E93290
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xE92CB0 Offset: 0xE912B0 VA: 0x180E92CB0
	private void GenerateRow(DataRow row) { }

	// RVA: 0xE923F0 Offset: 0xE909F0 VA: 0x180E923F0
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xE938F0 Offset: 0xE91EF0 VA: 0x180E938F0
	internal static string QualifiedName(string prefix, string name) { }

}

