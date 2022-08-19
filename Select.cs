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

	// RVA: 0xE99C70 Offset: 0xE98270 VA: 0x180E99C70
	public void .ctor(DataTable table, string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xE99460 Offset: 0xE97A60 VA: 0x180E99460
	private bool IsSupportedOperator(int op) { }

	// RVA: 0xE963A0 Offset: 0xE949A0 VA: 0x180E963A0
	private void AnalyzeExpression(BinaryNode expr) { }

	// RVA: 0xE96F70 Offset: 0xE95570 VA: 0x180E96F70
	private bool CompareSortIndexDesc(IndexField[] fields) { }

	// RVA: 0xE987A0 Offset: 0xE96DA0 VA: 0x180E987A0
	private bool FindSortIndex() { }

	// RVA: 0xE96C60 Offset: 0xE95260 VA: 0x180E96C60
	private int CompareClosestCandidateIndexDesc(IndexField[] fields) { }

	// RVA: 0xE98380 Offset: 0xE96980 VA: 0x180E98380
	private bool FindClosestCandidateIndex() { }

	// RVA: 0xE99230 Offset: 0xE97830 VA: 0x180E99230
	private void InitCandidateColumns() { }

	// RVA: 0xE970C0 Offset: 0xE956C0 VA: 0x180E970C0
	private void CreateIndex() { }

	// RVA: 0xE993A0 Offset: 0xE979A0 VA: 0x180E993A0
	private bool IsOperatorIn(ExpressionNode enode) { }

	// RVA: 0xE96A90 Offset: 0xE95090 VA: 0x180E96A90
	private void BuildLinearExpression() { }

	// RVA: 0xE99480 Offset: 0xE97A80 VA: 0x180E99480
	public DataRow[] SelectRows() { }

	// RVA: 0xE990F0 Offset: 0xE976F0 VA: 0x180E990F0
	public DataRow[] GetRows() { }

	// RVA: 0xE961D0 Offset: 0xE947D0 VA: 0x180E961D0
	private bool AcceptRecord(int record) { }

	// RVA: 0xE97980 Offset: 0xE95F80 VA: 0x180E97980
	private int Eval(BinaryNode expr, DataRow row, DataRowVersion version) { }

	// RVA: 0xE981F0 Offset: 0xE967F0 VA: 0x180E981F0
	private int Evaluate(int record) { }

	// RVA: 0xE98600 Offset: 0xE96C00 VA: 0x180E98600
	private int FindFirstMatchingRecord() { }

	// RVA: 0xE986D0 Offset: 0xE96CD0 VA: 0x180E986D0
	private int FindLastMatchingRecord(int lo) { }

	// RVA: 0xE989B0 Offset: 0xE96FB0 VA: 0x180E989B0
	private Range GetBinaryFilteredRecords() { }

	// RVA: 0xE98C10 Offset: 0xE97210 VA: 0x180E98C10
	private int[] GetLinearFilteredRecords(Range range) { }

	// RVA: 0xE98ED0 Offset: 0xE974D0 VA: 0x180E98ED0
	private DataRow[] GetLinearFilteredRows(Range range) { }

	// RVA: 0xE96D10 Offset: 0xE95310 VA: 0x180E96D10
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xE99AB0 Offset: 0xE980B0 VA: 0x180E99AB0
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

