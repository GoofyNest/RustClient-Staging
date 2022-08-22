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

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	internal int get_TableDim() { }

	// RVA: 0x15012F0 Offset: 0x14FF8F0 VA: 0x1815012F0
	internal void .ctor(CompiledIdentityConstraint constraint) { }

}

