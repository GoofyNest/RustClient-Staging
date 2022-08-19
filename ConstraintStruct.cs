internal sealed class ConstraintStruct // TypeDefIndex: 2145
{	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	internal int get_TableDim() { }

	// RVA: 0x1501F60 Offset: 0x1500560 VA: 0x181501F60
	internal void .ctor(CompiledIdentityConstraint constraint) { }

}

