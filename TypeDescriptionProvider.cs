public abstract class TypeDescriptionProvider // TypeDefIndex: 2755
{	// Fields
	private TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x173A4F0 Offset: 0x1738AF0 VA: 0x18173A4F0 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x173A5F0 Offset: 0x1738BF0 VA: 0x18173A5F0 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x173A610 Offset: 0x1738C10 VA: 0x18173A610 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x173A6B0 Offset: 0x1738CB0 VA: 0x18173A6B0 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x161D260 Offset: 0x161B860 VA: 0x18161D260
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x173A750 Offset: 0x1738D50 VA: 0x18173A750 Slot: 8
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0xFEDFA0 Offset: 0xFEC5A0 VA: 0x180FEDFA0
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x173A770 Offset: 0x1738D70 VA: 0x18173A770
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x173A800 Offset: 0x1738E00 VA: 0x18173A800 Slot: 9
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private sealed class TypeDescriptionProvider.EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 2756
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

