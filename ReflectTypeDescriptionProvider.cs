internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2742
{	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _intrinsicTypeConverters; // 0x8
	private static object _intrinsicReferenceKey; // 0x10
	private static object _intrinsicNullableKey; // 0x18
	private static object _dictionaryKey; // 0x20
	private static Hashtable _propertyCache; // 0x28
	private static Hashtable _attributeCache; // 0x30
	private static Hashtable _extendedPropertyCache; // 0x38
	private static readonly Guid _extenderProviderKey; // 0x40
	private static readonly Guid _extenderPropertiesKey; // 0x50
	private static readonly Guid _extenderProviderPropertiesKey; // 0x60
	private static readonly Type[] _skipInterfaceAttributeList; // 0x70
	private static object _internalSyncObject; // 0x78

	// Properties
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x1732180 Offset: 0x1730780 VA: 0x181732180
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x172DE40 Offset: 0x172C440 VA: 0x18172DE40 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x172DD20 Offset: 0x172C320 VA: 0x18172DD20
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x172E010 Offset: 0x172C610 VA: 0x18172E010
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x172E040 Offset: 0x172C640 VA: 0x18172E040 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x172E200 Offset: 0x172C800 VA: 0x18172E200
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x172E240 Offset: 0x172C840 VA: 0x18172E240
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x172E2A0 Offset: 0x172C8A0 VA: 0x18172E2A0
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x172E300 Offset: 0x172C900 VA: 0x18172E300
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x172E850 Offset: 0x172CE50 VA: 0x18172E850 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x172EAE0 Offset: 0x172D0E0 VA: 0x18172EAE0
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x172E7D0 Offset: 0x172CDD0 VA: 0x18172E7D0
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x172F310 Offset: 0x172D910 VA: 0x18172F310
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x172F340 Offset: 0x172D940 VA: 0x18172F340
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x172F3B0 Offset: 0x172D9B0 VA: 0x18172F3B0
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x172F670 Offset: 0x172DC70 VA: 0x18172F670
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x172F780 Offset: 0x172DD80 VA: 0x18172F780
	internal bool IsPopulated(Type type) { }

	// RVA: 0x172F7D0 Offset: 0x172DDD0 VA: 0x18172F7D0
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x172FCC0 Offset: 0x172E2C0 VA: 0x18172FCC0
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x17301B0 Offset: 0x172E7B0 VA: 0x1817301B0
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x1730E90 Offset: 0x172F490 VA: 0x181730E90
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x1731520 Offset: 0x172FB20 VA: 0x181731520
	internal void Refresh(Type type) { }

	// RVA: 0x17315B0 Offset: 0x172FBB0 VA: 0x1817315B0
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x1731DC0 Offset: 0x17303C0 VA: 0x181731DC0
	private static void .cctor() { }

}

private class ReflectTypeDescriptionProvider.ReflectedTypeData // TypeDefIndex: 2743
{	// Fields
	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private int _editorCount; // 0x48

	// Properties
	internal bool IsPopulated { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(Type type) { }

	// RVA: 0x17338B0 Offset: 0x1731EB0 VA: 0x1817338B0
	internal bool get_IsPopulated() { }

	// RVA: 0x1732890 Offset: 0x1730E90 VA: 0x181732890
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x1732E30 Offset: 0x1731430 VA: 0x181732E30
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x17333A0 Offset: 0x17319A0 VA: 0x1817333A0
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x1733650 Offset: 0x1731C50 VA: 0x181733650
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x1733830 Offset: 0x1731E30 VA: 0x181733830
	internal void Refresh() { }

}

