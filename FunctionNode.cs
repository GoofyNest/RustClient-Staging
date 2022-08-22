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

	// RVA: 0x13EDAB0 Offset: 0x13EC0B0 VA: 0x1813EDAB0
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x13E9080 Offset: 0x13E7680 VA: 0x1813E9080
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x13E92A0 Offset: 0x13E78A0 VA: 0x1813E92A0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCD7A0 Offset: 0xCCBDA0 VA: 0x180CCD7A0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x13EBA00 Offset: 0x13EA000 VA: 0x1813EBA00 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x13EB9B0 Offset: 0x13E9FB0 VA: 0x1813EB9B0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x13ECA90 Offset: 0x13EB090 VA: 0x1813ECA90 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x13ECB10 Offset: 0x13EB110 VA: 0x1813ECB10 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x13EC990 Offset: 0x13EAF90 VA: 0x1813EC990 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x13ECA10 Offset: 0x13EB010 VA: 0x1813ECA10 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x13E98B0 Offset: 0x13E7EB0 VA: 0x1813E98B0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x13ECB90 Offset: 0x13EB190 VA: 0x1813ECB90 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x13EC6F0 Offset: 0x13EACF0 VA: 0x1813EC6F0
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x13E9940 Offset: 0x13E7F40 VA: 0x1813E9940
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x13EDC20 Offset: 0x13EC220 VA: 0x1813EDC20
	internal FunctionId get_Aggregate() { }

	// RVA: 0x13EDCD0 Offset: 0x13EC2D0 VA: 0x1813EDCD0
	internal bool get_IsAggregate() { }

	// RVA: 0x13E9600 Offset: 0x13E7C00 VA: 0x1813E9600
	internal void Check() { }

	// RVA: 0x13ECD90 Offset: 0x13EB390 VA: 0x1813ECD90
	private static void .cctor() { }

}

