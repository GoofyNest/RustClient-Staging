internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 7
{	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x1F68A0 Offset: 0x1F5CA0 VA: 0x1801F68A0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F6A80 Offset: 0x1F5E80 VA: 0x1801F6A80
	internal Type[] get_Constraints() { }

	// RVA: 0x1F6A60 Offset: 0x1F5E60 VA: 0x1801F6A60
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x1F6A50 Offset: 0x1F5E50 VA: 0x1801F6A50
	private Type[] GetConstraints() { }

	// RVA: 0x1F6A10 Offset: 0x1F5E10 VA: 0x1801F6A10
	private int GetConstraintsCount() { }

}

