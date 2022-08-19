internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 4259
{	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x13ED7F0 Offset: 0x13EBDF0 VA: 0x1813ED7F0
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x13E8DC0 Offset: 0x13E73C0 VA: 0x1813E8DC0
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x13E8FE0 Offset: 0x13E75E0 VA: 0x1813E8FE0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCD4E0 Offset: 0xCCBAE0 VA: 0x180CCD4E0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x13EB740 Offset: 0x13E9D40 VA: 0x1813EB740 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x13EB6F0 Offset: 0x13E9CF0 VA: 0x1813EB6F0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x13EC7D0 Offset: 0x13EADD0 VA: 0x1813EC7D0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x13EC850 Offset: 0x13EAE50 VA: 0x1813EC850 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x13EC6D0 Offset: 0x13EACD0 VA: 0x1813EC6D0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x13EC750 Offset: 0x13EAD50 VA: 0x1813EC750 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x13E95F0 Offset: 0x13E7BF0 VA: 0x1813E95F0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x13EC8D0 Offset: 0x13EAED0 VA: 0x1813EC8D0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x13EC430 Offset: 0x13EAA30 VA: 0x1813EC430
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x13E9680 Offset: 0x13E7C80 VA: 0x1813E9680
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x13ED960 Offset: 0x13EBF60 VA: 0x1813ED960
	internal FunctionId get_Aggregate() { }

	// RVA: 0x13EDA10 Offset: 0x13EC010 VA: 0x1813EDA10
	internal bool get_IsAggregate() { }

	// RVA: 0x13E9340 Offset: 0x13E7940 VA: 0x1813E9340
	internal void Check() { }

	// RVA: 0x13ECAD0 Offset: 0x13EB0D0 VA: 0x1813ECAD0
	private static void .cctor() { }

}

