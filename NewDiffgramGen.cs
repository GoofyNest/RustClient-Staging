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

	// RVA: 0xE933E0 Offset: 0xE919E0 VA: 0x180E933E0
	internal void .ctor(DataSet ds) { }

	// RVA: 0xE93530 Offset: 0xE91B30 VA: 0x180E93530
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xE91210 Offset: 0xE8F810 VA: 0x180E91210
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xE914D0 Offset: 0xE8FAD0 VA: 0x180E914D0
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xE917D0 Offset: 0xE8FDD0 VA: 0x180E917D0
	private bool EmptyData() { }

	// RVA: 0xE933D0 Offset: 0xE919D0 VA: 0x180E933D0
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xE92EA0 Offset: 0xE914A0 VA: 0x180E92EA0
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xE92DB0 Offset: 0xE913B0 VA: 0x180E92DB0
	private void GenerateTable(DataTable table) { }

	// RVA: 0xE927E0 Offset: 0xE90DE0 VA: 0x180E927E0
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xE92200 Offset: 0xE90800 VA: 0x180E92200
	private void GenerateRow(DataRow row) { }

	// RVA: 0xE91940 Offset: 0xE8FF40 VA: 0x180E91940
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xE92E40 Offset: 0xE91440 VA: 0x180E92E40
	internal static string QualifiedName(string prefix, string name) { }

}

