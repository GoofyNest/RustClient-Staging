internal sealed class Select // TypeDefIndex: 4297
{	// Fields
	private readonly DataTable _table; // 0x10
	private readonly IndexField[] _indexFields; // 0x18
	private DataViewRowState _recordStates; // 0x20
	private DataExpression _rowFilter; // 0x28
	private ExpressionNode _expression; // 0x30
	private Index _index; // 0x38
	private int[] _records; // 0x40
	private int _recordCount; // 0x48
	private ExpressionNode _linearExpression; // 0x50
	private bool _candidatesForBinarySearch; // 0x58
	private Select.ColumnInfo[] _candidateColumns; // 0x60
	private int _nCandidates; // 0x68
	private int _matchedCandidates; // 0x6C

	// Methods

	// RVA: 0xE9A9E0 Offset: 0xE98FE0 VA: 0x180E9A9E0
	public void .ctor(DataTable table, string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xE9A1D0 Offset: 0xE987D0 VA: 0x180E9A1D0
	private bool IsSupportedOperator(int op) { }

	// RVA: 0xE97110 Offset: 0xE95710 VA: 0x180E97110
	private void AnalyzeExpression(BinaryNode expr) { }

	// RVA: 0xE97CE0 Offset: 0xE962E0 VA: 0x180E97CE0
	private bool CompareSortIndexDesc(IndexField[] fields) { }

	// RVA: 0xE99510 Offset: 0xE97B10 VA: 0x180E99510
	private bool FindSortIndex() { }

	// RVA: 0xE979D0 Offset: 0xE95FD0 VA: 0x180E979D0
	private int CompareClosestCandidateIndexDesc(IndexField[] fields) { }

	// RVA: 0xE990F0 Offset: 0xE976F0 VA: 0x180E990F0
	private bool FindClosestCandidateIndex() { }

	// RVA: 0xE99FA0 Offset: 0xE985A0 VA: 0x180E99FA0
	private void InitCandidateColumns() { }

	// RVA: 0xE97E30 Offset: 0xE96430 VA: 0x180E97E30
	private void CreateIndex() { }

	// RVA: 0xE9A110 Offset: 0xE98710 VA: 0x180E9A110
	private bool IsOperatorIn(ExpressionNode enode) { }

	// RVA: 0xE97800 Offset: 0xE95E00 VA: 0x180E97800
	private void BuildLinearExpression() { }

	// RVA: 0xE9A1F0 Offset: 0xE987F0 VA: 0x180E9A1F0
	public DataRow[] SelectRows() { }

	// RVA: 0xE99E60 Offset: 0xE98460 VA: 0x180E99E60
	public DataRow[] GetRows() { }

	// RVA: 0xE96F40 Offset: 0xE95540 VA: 0x180E96F40
	private bool AcceptRecord(int record) { }

	// RVA: 0xE986F0 Offset: 0xE96CF0 VA: 0x180E986F0
	private int Eval(BinaryNode expr, DataRow row, DataRowVersion version) { }

	// RVA: 0xE98F60 Offset: 0xE97560 VA: 0x180E98F60
	private int Evaluate(int record) { }

	// RVA: 0xE99370 Offset: 0xE97970 VA: 0x180E99370
	private int FindFirstMatchingRecord() { }

	// RVA: 0xE99440 Offset: 0xE97A40 VA: 0x180E99440
	private int FindLastMatchingRecord(int lo) { }

	// RVA: 0xE99720 Offset: 0xE97D20 VA: 0x180E99720
	private Range GetBinaryFilteredRecords() { }

	// RVA: 0xE99980 Offset: 0xE97F80 VA: 0x180E99980
	private int[] GetLinearFilteredRecords(Range range) { }

	// RVA: 0xE99C40 Offset: 0xE98240 VA: 0x180E99C40
	private DataRow[] GetLinearFilteredRows(Range range) { }

	// RVA: 0xE97A80 Offset: 0xE96080 VA: 0x180E97A80
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xE9A820 Offset: 0xE98E20 VA: 0x180E9A820
	private void Sort(int left, int right) { }

}

private sealed class Select.ColumnInfo // TypeDefIndex: 4298
{	// Fields
	public bool flag; // 0x10
	public bool equalsOperator; // 0x11
	public BinaryNode expr; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

