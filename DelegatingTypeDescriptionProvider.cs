internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2688
{	// Fields
	private Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x15C0090 Offset: 0x15BE690 VA: 0x1815C0090
	internal void .ctor(Type type) { }

	// RVA: 0x15C00C0 Offset: 0x15BE6C0 VA: 0x1815C00C0
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x15BFCF0 Offset: 0x15BE2F0 VA: 0x1815BFCF0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x15BFDA0 Offset: 0x15BE3A0 VA: 0x1815BFDA0 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x15BFE30 Offset: 0x15BE430 VA: 0x1815BFE30 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x15BFEC0 Offset: 0x15BE4C0 VA: 0x1815BFEC0 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x15BFF50 Offset: 0x15BE550 VA: 0x1815BFF50 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x15BFFF0 Offset: 0x15BE5F0 VA: 0x1815BFFF0 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

