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

	// RVA: 0x1732440 Offset: 0x1730A40 VA: 0x181732440
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x172E100 Offset: 0x172C700 VA: 0x18172E100 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x172DFE0 Offset: 0x172C5E0 VA: 0x18172DFE0
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x172E2D0 Offset: 0x172C8D0 VA: 0x18172E2D0
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x172E300 Offset: 0x172C900 VA: 0x18172E300 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x172E4C0 Offset: 0x172CAC0 VA: 0x18172E4C0
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x172E500 Offset: 0x172CB00 VA: 0x18172E500
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x172E560 Offset: 0x172CB60 VA: 0x18172E560
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x172E5C0 Offset: 0x172CBC0 VA: 0x18172E5C0
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x172EB10 Offset: 0x172D110 VA: 0x18172EB10 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x172EDA0 Offset: 0x172D3A0 VA: 0x18172EDA0
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x172EA90 Offset: 0x172D090 VA: 0x18172EA90
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x172F5D0 Offset: 0x172DBD0 VA: 0x18172F5D0
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x172F600 Offset: 0x172DC00 VA: 0x18172F600
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x172F670 Offset: 0x172DC70 VA: 0x18172F670
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x172F930 Offset: 0x172DF30 VA: 0x18172F930
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x172FA40 Offset: 0x172E040 VA: 0x18172FA40
	internal bool IsPopulated(Type type) { }

	// RVA: 0x172FA90 Offset: 0x172E090 VA: 0x18172FA90
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x172FF80 Offset: 0x172E580 VA: 0x18172FF80
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x1730470 Offset: 0x172EA70 VA: 0x181730470
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x1731150 Offset: 0x172F750 VA: 0x181731150
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x17317E0 Offset: 0x172FDE0 VA: 0x1817317E0
	internal void Refresh(Type type) { }

	// RVA: 0x1731870 Offset: 0x172FE70 VA: 0x181731870
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x1732080 Offset: 0x1730680 VA: 0x181732080
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

	// RVA: 0x1733B70 Offset: 0x1732170 VA: 0x181733B70
	internal bool get_IsPopulated() { }

	// RVA: 0x1732B50 Offset: 0x1731150 VA: 0x181732B50
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x17330F0 Offset: 0x17316F0 VA: 0x1817330F0
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x1733660 Offset: 0x1731C60 VA: 0x181733660
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x1733910 Offset: 0x1731F10 VA: 0x181733910
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x1733AF0 Offset: 0x17320F0 VA: 0x181733AF0
	internal void Refresh() { }

}

