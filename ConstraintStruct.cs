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

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	internal int get_TableDim() { }

	// RVA: 0x1502220 Offset: 0x1500820 VA: 0x181502220
	internal void .ctor(CompiledIdentityConstraint constraint) { }

}

