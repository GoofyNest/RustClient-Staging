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

	// RVA: 0x13ECBB0 Offset: 0x13EB1B0 VA: 0x1813ECBB0
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x13E8180 Offset: 0x13E6780 VA: 0x1813E8180
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x13E83A0 Offset: 0x13E69A0 VA: 0x1813E83A0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCDC40 Offset: 0xCCC240 VA: 0x180CCDC40 Slot: 6
	internal override object Eval() { }

	// RVA: 0x13EAB00 Offset: 0x13E9100 VA: 0x1813EAB00 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x13EAAB0 Offset: 0x13E90B0 VA: 0x1813EAAB0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x13EBB90 Offset: 0x13EA190 VA: 0x1813EBB90 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x13EBC10 Offset: 0x13EA210 VA: 0x1813EBC10 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x13EBA90 Offset: 0x13EA090 VA: 0x1813EBA90 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x13EBB10 Offset: 0x13EA110 VA: 0x1813EBB10 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x13E89B0 Offset: 0x13E6FB0 VA: 0x1813E89B0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x13EBC90 Offset: 0x13EA290 VA: 0x1813EBC90 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x13EB7F0 Offset: 0x13E9DF0 VA: 0x1813EB7F0
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x13E8A40 Offset: 0x13E7040 VA: 0x1813E8A40
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x13ECD20 Offset: 0x13EB320 VA: 0x1813ECD20
	internal FunctionId get_Aggregate() { }

	// RVA: 0x13ECDD0 Offset: 0x13EB3D0 VA: 0x1813ECDD0
	internal bool get_IsAggregate() { }

	// RVA: 0x13E8700 Offset: 0x13E6D00 VA: 0x1813E8700
	internal void Check() { }

	// RVA: 0x13EBE90 Offset: 0x13EA490 VA: 0x1813EBE90
	private static void .cctor() { }

}

