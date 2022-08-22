internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 7
{	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x1F5670 Offset: 0x1F4A70 VA: 0x1801F5670
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F5850 Offset: 0x1F4C50 VA: 0x1801F5850
	internal Type[] get_Constraints() { }

	// RVA: 0x1F5830 Offset: 0x1F4C30 VA: 0x1801F5830
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x1F5820 Offset: 0x1F4C20 VA: 0x1801F5820
	private Type[] GetConstraints() { }

	// RVA: 0x1F57E0 Offset: 0x1F4BE0 VA: 0x1801F57E0
	private int GetConstraintsCount() { }

}

