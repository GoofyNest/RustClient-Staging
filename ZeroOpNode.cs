internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 4272
{
	internal readonly int _op;


	internal void .ctor(int op) { }

	internal override void Bind(DataTable table, List<DataColumn> list) { }

	internal override object Eval() { }

	internal override object Eval(DataRow row, DataRowVersion version) { }

	internal override object Eval(int[] recordNos) { }

	internal override bool IsConstant() { }

	internal override bool IsTableConstant() { }

	internal override bool HasLocalAggregate() { }

	internal override bool HasRemoteAggregate() { }

	internal override ExpressionNode Optimize() { }

}

