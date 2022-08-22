internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 7
{	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x1F6820 Offset: 0x1F5C20 VA: 0x1801F6820
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F6A00 Offset: 0x1F5E00 VA: 0x1801F6A00
	internal Type[] get_Constraints() { }

	// RVA: 0x1F69E0 Offset: 0x1F5DE0 VA: 0x1801F69E0
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x1F69D0 Offset: 0x1F5DD0 VA: 0x1801F69D0
	private Type[] GetConstraints() { }

	// RVA: 0x1F6990 Offset: 0x1F5D90 VA: 0x1801F6990
	private int GetConstraintsCount() { }

}

