internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2688
{	// Fields
	private Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x15C0FC0 Offset: 0x15BF5C0 VA: 0x1815C0FC0
	internal void .ctor(Type type) { }

	// RVA: 0x15C0FF0 Offset: 0x15BF5F0 VA: 0x1815C0FF0
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x15C0C20 Offset: 0x15BF220 VA: 0x1815C0C20 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x15C0CD0 Offset: 0x15BF2D0 VA: 0x1815C0CD0 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x15C0D60 Offset: 0x15BF360 VA: 0x1815C0D60 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x15C0DF0 Offset: 0x15BF3F0 VA: 0x1815C0DF0 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x15C0E80 Offset: 0x15BF480 VA: 0x1815C0E80 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x15C0F20 Offset: 0x15BF520 VA: 0x1815C0F20 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

