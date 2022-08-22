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

	// RVA: 0x1730000 Offset: 0x172E600 VA: 0x181730000
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x172BCC0 Offset: 0x172A2C0 VA: 0x18172BCC0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x172BBA0 Offset: 0x172A1A0 VA: 0x18172BBA0
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x172BE90 Offset: 0x172A490 VA: 0x18172BE90
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x172BEC0 Offset: 0x172A4C0 VA: 0x18172BEC0 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x172C080 Offset: 0x172A680 VA: 0x18172C080
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x172C0C0 Offset: 0x172A6C0 VA: 0x18172C0C0
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x172C120 Offset: 0x172A720 VA: 0x18172C120
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x172C180 Offset: 0x172A780 VA: 0x18172C180
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x172C6D0 Offset: 0x172ACD0 VA: 0x18172C6D0 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x172C960 Offset: 0x172AF60 VA: 0x18172C960
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x172C650 Offset: 0x172AC50 VA: 0x18172C650
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x172D190 Offset: 0x172B790 VA: 0x18172D190
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x172D1C0 Offset: 0x172B7C0 VA: 0x18172D1C0
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x172D230 Offset: 0x172B830 VA: 0x18172D230
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x172D4F0 Offset: 0x172BAF0 VA: 0x18172D4F0
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x172D600 Offset: 0x172BC00 VA: 0x18172D600
	internal bool IsPopulated(Type type) { }

	// RVA: 0x172D650 Offset: 0x172BC50 VA: 0x18172D650
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x172DB40 Offset: 0x172C140 VA: 0x18172DB40
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x172E030 Offset: 0x172C630 VA: 0x18172E030
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x172ED10 Offset: 0x172D310 VA: 0x18172ED10
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x172F3A0 Offset: 0x172D9A0 VA: 0x18172F3A0
	internal void Refresh(Type type) { }

	// RVA: 0x172F430 Offset: 0x172DA30 VA: 0x18172F430
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x172FC40 Offset: 0x172E240 VA: 0x18172FC40
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

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(Type type) { }

	// RVA: 0x1731730 Offset: 0x172FD30 VA: 0x181731730
	internal bool get_IsPopulated() { }

	// RVA: 0x1730710 Offset: 0x172ED10 VA: 0x181730710
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x1730CB0 Offset: 0x172F2B0 VA: 0x181730CB0
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x1731220 Offset: 0x172F820 VA: 0x181731220
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x17314D0 Offset: 0x172FAD0 VA: 0x1817314D0
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x17316B0 Offset: 0x172FCB0 VA: 0x1817316B0
	internal void Refresh() { }

}

