public abstract class TypeDescriptionProvider // TypeDefIndex: 2755
{	// Fields
	private TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x17380B0 Offset: 0x17366B0 VA: 0x1817380B0 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x17381B0 Offset: 0x17367B0 VA: 0x1817381B0 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x17381D0 Offset: 0x17367D0 VA: 0x1817381D0 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1738270 Offset: 0x1736870 VA: 0x181738270 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x160A580 Offset: 0x1608B80 VA: 0x18160A580
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x1738310 Offset: 0x1736910 VA: 0x181738310 Slot: 8
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0xFEEA40 Offset: 0xFED040 VA: 0x180FEEA40
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x1738330 Offset: 0x1736930 VA: 0x181738330
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x17383C0 Offset: 0x17369C0 VA: 0x1817383C0 Slot: 9
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private sealed class TypeDescriptionProvider.EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 2756
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

