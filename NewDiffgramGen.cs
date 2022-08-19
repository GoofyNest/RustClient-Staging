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

	// RVA: 0xE93120 Offset: 0xE91720 VA: 0x180E93120
	internal void .ctor(DataSet ds) { }

	// RVA: 0xE93270 Offset: 0xE91870 VA: 0x180E93270
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xE90F50 Offset: 0xE8F550 VA: 0x180E90F50
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xE91210 Offset: 0xE8F810 VA: 0x180E91210
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xE91510 Offset: 0xE8FB10 VA: 0x180E91510
	private bool EmptyData() { }

	// RVA: 0xE93110 Offset: 0xE91710 VA: 0x180E93110
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xE92BE0 Offset: 0xE911E0 VA: 0x180E92BE0
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xE92AF0 Offset: 0xE910F0 VA: 0x180E92AF0
	private void GenerateTable(DataTable table) { }

	// RVA: 0xE92520 Offset: 0xE90B20 VA: 0x180E92520
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xE91F40 Offset: 0xE90540 VA: 0x180E91F40
	private void GenerateRow(DataRow row) { }

	// RVA: 0xE91680 Offset: 0xE8FC80 VA: 0x180E91680
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xE92B80 Offset: 0xE91180 VA: 0x180E92B80
	internal static string QualifiedName(string prefix, string name) { }

}

