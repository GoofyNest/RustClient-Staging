internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2688
{	// Fields
	private Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x15C0D00 Offset: 0x15BF300 VA: 0x1815C0D00
	internal void .ctor(Type type) { }

	// RVA: 0x15C0D30 Offset: 0x15BF330 VA: 0x1815C0D30
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x15C0960 Offset: 0x15BEF60 VA: 0x1815C0960 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x15C0A10 Offset: 0x15BF010 VA: 0x1815C0A10 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x15C0AA0 Offset: 0x15BF0A0 VA: 0x1815C0AA0 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x15C0B30 Offset: 0x15BF130 VA: 0x1815C0B30 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x15C0BC0 Offset: 0x15BF1C0 VA: 0x1815C0BC0 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x15C0C60 Offset: 0x15BF260 VA: 0x1815C0C60 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

