public abstract class TypeDescriptionProvider // TypeDefIndex: 2755
{	// Fields
	private TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x173A230 Offset: 0x1738830 VA: 0x18173A230 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x173A330 Offset: 0x1738930 VA: 0x18173A330 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x173A350 Offset: 0x1738950 VA: 0x18173A350 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x173A3F0 Offset: 0x17389F0 VA: 0x18173A3F0 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x161CFA0 Offset: 0x161B5A0 VA: 0x18161CFA0
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x173A490 Offset: 0x1738A90 VA: 0x18173A490 Slot: 8
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0xFEDCE0 Offset: 0xFEC2E0 VA: 0x180FEDCE0
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x173A4B0 Offset: 0x1738AB0 VA: 0x18173A4B0
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x173A540 Offset: 0x1738B40 VA: 0x18173A540 Slot: 9
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private sealed class TypeDescriptionProvider.EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 2756
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

