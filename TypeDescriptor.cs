public sealed class TypeDescriptor // TypeDefIndex: 2758
{	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public static Type ComObjectType { get; }
	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x1741100 Offset: 0x173F700 VA: 0x181741100
	public static Type get_ComObjectType() { }

	// RVA: 0x1741160 Offset: 0x173F760 VA: 0x181741160
	public static Type get_InterfaceType() { }

	// RVA: 0x17411C0 Offset: 0x173F7C0 VA: 0x1817411C0
	internal static int get_MetadataVersion() { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x173A5F0 Offset: 0x1738BF0 VA: 0x18173A5F0
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x173A890 Offset: 0x1738E90 VA: 0x18173A890
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x173AF50 Offset: 0x1739550 VA: 0x18173AF50
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x173B1B0 Offset: 0x17397B0 VA: 0x18173B1B0
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x173B3D0 Offset: 0x17399D0 VA: 0x18173B3D0
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x173B8B0 Offset: 0x1739EB0 VA: 0x18173B8B0
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x173B850 Offset: 0x1739E50 VA: 0x18173B850
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x173B980 Offset: 0x1739F80 VA: 0x18173B980
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x173BC90 Offset: 0x173A290 VA: 0x18173BC90
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x173BD50 Offset: 0x173A350 VA: 0x18173BD50
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x173BDD0 Offset: 0x173A3D0 VA: 0x18173BDD0
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x173BF00 Offset: 0x173A500 VA: 0x18173BF00
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x173C160 Offset: 0x173A760 VA: 0x18173C160
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x173C250 Offset: 0x173A850 VA: 0x18173C250
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x173C4C0 Offset: 0x173AAC0 VA: 0x18173C4C0
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x173CB90 Offset: 0x173B190 VA: 0x18173CB90
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x173CB20 Offset: 0x173B120 VA: 0x18173CB20
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x173C640 Offset: 0x173AC40 VA: 0x18173C640
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x173CC40 Offset: 0x173B240 VA: 0x18173CC40
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsableAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	// RVA: 0x173CCA0 Offset: 0x173B2A0 VA: 0x18173CCA0
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x173D410 Offset: 0x173BA10 VA: 0x18173D410
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x173CDC0 Offset: 0x173B3C0 VA: 0x18173CDC0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x173D3B0 Offset: 0x173B9B0 VA: 0x18173D3B0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x173D470 Offset: 0x173BA70 VA: 0x18173D470
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x173D6A0 Offset: 0x173BCA0 VA: 0x18173D6A0
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x173DAE0 Offset: 0x173C0E0 VA: 0x18173DAE0
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x173EE80 Offset: 0x173D480 VA: 0x18173EE80
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x173F260 Offset: 0x173D860 VA: 0x18173F260
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x173FB60 Offset: 0x173E160 VA: 0x18173FB60
	private static void RaiseRefresh(object component) { }

	// RVA: 0x173FC80 Offset: 0x173E280 VA: 0x18173FC80
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x17402A0 Offset: 0x173E8A0 VA: 0x1817402A0
	public static void Refresh(object component) { }

	// RVA: 0x1740300 Offset: 0x173E900 VA: 0x181740300
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x173FD70 Offset: 0x173E370 VA: 0x18173FD70
	public static void Refresh(Type type) { }

	// RVA: 0x1740A20 Offset: 0x173F020 VA: 0x181740A20
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x1740AE0 Offset: 0x173F0E0 VA: 0x181740AE0
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x1740BC0 Offset: 0x173F1C0 VA: 0x181740BC0
	private static void .cctor() { }

}

private sealed class TypeDescriptor.AttributeFilterCacheItem // TypeDefIndex: 2759
{	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x1727B60 Offset: 0x1726160 VA: 0x181727B60
	internal bool IsValid(Attribute[] filter) { }

}

private sealed class TypeDescriptor.FilterCacheItem // TypeDefIndex: 2760
{	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0xE36CC0 Offset: 0xE352C0 VA: 0x180E36CC0
	internal bool IsValid(ITypeDescriptorFilterService filterService) { }

}

private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
{
// Namespace: 
private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
	// Fields
	public static readonly TypeDescriptor.MemberDescriptorComparer Instance; // 0x144DE

	// Methods

	// RVA: 0x172BF60 Offset: 0x172A560 VA: 0x18172BF60 Slot: 4
	public int Compare(object left, object right) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x172C130 Offset: 0x172A730 VA: 0x18172C130
	private static void .cctor() { }

}

private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2763
{	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x172C190 Offset: 0x172A790 VA: 0x18172C190 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x172C200 Offset: 0x172A800 VA: 0x18172C200 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x172C270 Offset: 0x172A870 VA: 0x18172C270 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x172C2E0 Offset: 0x172A8E0 VA: 0x18172C2E0 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x172C360 Offset: 0x172A960 VA: 0x18172C360 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 2764
{	// Fields
	internal TypeDescriptor.TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x173A0A0 Offset: 0x17386A0 VA: 0x18173A0A0
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x1739B00 Offset: 0x1738100 VA: 0x181739B00 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1739C80 Offset: 0x1738280 VA: 0x181739C80 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1739D10 Offset: 0x1738310 VA: 0x181739D10 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1739DD0 Offset: 0x17383D0 VA: 0x181739DD0 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1739E60 Offset: 0x1738460 VA: 0x181739E60 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1739F30 Offset: 0x1738530 VA: 0x181739F30 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2765
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private object _instance; // 0x8

	// Methods

	// RVA: 0xF5AD0 Offset: 0xF4ED0 VA: 0x1800F5AD0
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, object instance) { }

	// RVA: 0x207A60 Offset: 0x206E60 VA: 0x180207A60 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x207A70 Offset: 0x206E70 VA: 0x180207A70 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x207A90 Offset: 0x206E90 VA: 0x180207A90 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x207A80 Offset: 0x206E80 VA: 0x180207A80 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x207AA0 Offset: 0x206EA0 VA: 0x180207AA0 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2766
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private Type _objectType; // 0x8
	private object _instance; // 0x10

	// Methods

	// RVA: 0xF5CF0 Offset: 0xF50F0 VA: 0x1800F5CF0
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x207AD0 Offset: 0x206ED0 VA: 0x180207AD0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x207AE0 Offset: 0x206EE0 VA: 0x180207AE0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x207B00 Offset: 0x206F00 VA: 0x180207B00 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x207AF0 Offset: 0x206EF0 VA: 0x180207AF0 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x207B10 Offset: 0x206F10 VA: 0x180207B10 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

