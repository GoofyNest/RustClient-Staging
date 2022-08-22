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

	// RVA: 0xE99F30 Offset: 0xE98530 VA: 0x180E99F30
	public void .ctor(DataTable table, string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xE99720 Offset: 0xE97D20 VA: 0x180E99720
	private bool IsSupportedOperator(int op) { }

	// RVA: 0xE96660 Offset: 0xE94C60 VA: 0x180E96660
	private void AnalyzeExpression(BinaryNode expr) { }

	// RVA: 0xE97230 Offset: 0xE95830 VA: 0x180E97230
	private bool CompareSortIndexDesc(IndexField[] fields) { }

	// RVA: 0xE98A60 Offset: 0xE97060 VA: 0x180E98A60
	private bool FindSortIndex() { }

	// RVA: 0xE96F20 Offset: 0xE95520 VA: 0x180E96F20
	private int CompareClosestCandidateIndexDesc(IndexField[] fields) { }

	// RVA: 0xE98640 Offset: 0xE96C40 VA: 0x180E98640
	private bool FindClosestCandidateIndex() { }

	// RVA: 0xE994F0 Offset: 0xE97AF0 VA: 0x180E994F0
	private void InitCandidateColumns() { }

	// RVA: 0xE97380 Offset: 0xE95980 VA: 0x180E97380
	private void CreateIndex() { }

	// RVA: 0xE99660 Offset: 0xE97C60 VA: 0x180E99660
	private bool IsOperatorIn(ExpressionNode enode) { }

	// RVA: 0xE96D50 Offset: 0xE95350 VA: 0x180E96D50
	private void BuildLinearExpression() { }

	// RVA: 0xE99740 Offset: 0xE97D40 VA: 0x180E99740
	public DataRow[] SelectRows() { }

	// RVA: 0xE993B0 Offset: 0xE979B0 VA: 0x180E993B0
	public DataRow[] GetRows() { }

	// RVA: 0xE96490 Offset: 0xE94A90 VA: 0x180E96490
	private bool AcceptRecord(int record) { }

	// RVA: 0xE97C40 Offset: 0xE96240 VA: 0x180E97C40
	private int Eval(BinaryNode expr, DataRow row, DataRowVersion version) { }

	// RVA: 0xE984B0 Offset: 0xE96AB0 VA: 0x180E984B0
	private int Evaluate(int record) { }

	// RVA: 0xE988C0 Offset: 0xE96EC0 VA: 0x180E988C0
	private int FindFirstMatchingRecord() { }

	// RVA: 0xE98990 Offset: 0xE96F90 VA: 0x180E98990
	private int FindLastMatchingRecord(int lo) { }

	// RVA: 0xE98C70 Offset: 0xE97270 VA: 0x180E98C70
	private Range GetBinaryFilteredRecords() { }

	// RVA: 0xE98ED0 Offset: 0xE974D0 VA: 0x180E98ED0
	private int[] GetLinearFilteredRecords(Range range) { }

	// RVA: 0xE99190 Offset: 0xE97790 VA: 0x180E99190
	private DataRow[] GetLinearFilteredRows(Range range) { }

	// RVA: 0xE96FD0 Offset: 0xE955D0 VA: 0x180E96FD0
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xE99D70 Offset: 0xE98370 VA: 0x180E99D70
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

