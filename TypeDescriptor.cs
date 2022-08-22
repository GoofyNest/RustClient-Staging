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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public static Type ComObjectType { get; }
	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x17413C0 Offset: 0x173F9C0 VA: 0x1817413C0
	public static Type get_ComObjectType() { }

	// RVA: 0x1741420 Offset: 0x173FA20 VA: 0x181741420
	public static Type get_InterfaceType() { }

	// RVA: 0x1741480 Offset: 0x173FA80 VA: 0x181741480
	internal static int get_MetadataVersion() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x173A8B0 Offset: 0x1738EB0 VA: 0x18173A8B0
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x173AB50 Offset: 0x1739150 VA: 0x18173AB50
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x173B210 Offset: 0x1739810 VA: 0x18173B210
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x173B470 Offset: 0x1739A70 VA: 0x18173B470
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x173B690 Offset: 0x1739C90 VA: 0x18173B690
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x173BB70 Offset: 0x173A170 VA: 0x18173BB70
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x173BB10 Offset: 0x173A110 VA: 0x18173BB10
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x173BC40 Offset: 0x173A240 VA: 0x18173BC40
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x173BF50 Offset: 0x173A550 VA: 0x18173BF50
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x173C010 Offset: 0x173A610 VA: 0x18173C010
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x173C090 Offset: 0x173A690 VA: 0x18173C090
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x173C1C0 Offset: 0x173A7C0 VA: 0x18173C1C0
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x173C420 Offset: 0x173AA20 VA: 0x18173C420
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x173C510 Offset: 0x173AB10 VA: 0x18173C510
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x173C780 Offset: 0x173AD80 VA: 0x18173C780
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x173CE50 Offset: 0x173B450 VA: 0x18173CE50
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x173CDE0 Offset: 0x173B3E0 VA: 0x18173CDE0
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x173C900 Offset: 0x173AF00 VA: 0x18173C900
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x173CF00 Offset: 0x173B500 VA: 0x18173CF00
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x173CF60 Offset: 0x173B560 VA: 0x18173CF60
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x173D6D0 Offset: 0x173BCD0 VA: 0x18173D6D0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x173D080 Offset: 0x173B680 VA: 0x18173D080
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x173D670 Offset: 0x173BC70 VA: 0x18173D670
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x173D730 Offset: 0x173BD30 VA: 0x18173D730
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x173D960 Offset: 0x173BF60 VA: 0x18173D960
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x173DDA0 Offset: 0x173C3A0 VA: 0x18173DDA0
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x173F140 Offset: 0x173D740 VA: 0x18173F140
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x173F520 Offset: 0x173DB20 VA: 0x18173F520
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x173FE20 Offset: 0x173E420 VA: 0x18173FE20
	private static void RaiseRefresh(object component) { }

	// RVA: 0x173FF40 Offset: 0x173E540 VA: 0x18173FF40
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x1740560 Offset: 0x173EB60 VA: 0x181740560
	public static void Refresh(object component) { }

	// RVA: 0x17405C0 Offset: 0x173EBC0 VA: 0x1817405C0
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x1740030 Offset: 0x173E630 VA: 0x181740030
	public static void Refresh(Type type) { }

	// RVA: 0x1740CE0 Offset: 0x173F2E0 VA: 0x181740CE0
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x1740DA0 Offset: 0x173F3A0 VA: 0x181740DA0
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x1740E80 Offset: 0x173F480 VA: 0x181740E80
	private static void .cctor() { }

}

private sealed class TypeDescriptor.AttributeFilterCacheItem // TypeDefIndex: 2759
{	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x1727E20 Offset: 0x1726420 VA: 0x181727E20
	internal bool IsValid(Attribute[] filter) { }

}

private sealed class TypeDescriptor.FilterCacheItem // TypeDefIndex: 2760
{	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0xE36F80 Offset: 0xE35580 VA: 0x180E36F80
	internal bool IsValid(ITypeDescriptorFilterService filterService) { }

}

private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
{
// Namespace: 
private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
	// Fields
	public static readonly TypeDescriptor.MemberDescriptorComparer Instance; // 0x144DE

	// Methods

	// RVA: 0x172C220 Offset: 0x172A820 VA: 0x18172C220 Slot: 4
	public int Compare(object left, object right) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x172C3F0 Offset: 0x172A9F0 VA: 0x18172C3F0
	private static void .cctor() { }

}

private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2763
{	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x172C450 Offset: 0x172AA50 VA: 0x18172C450 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x172C4C0 Offset: 0x172AAC0 VA: 0x18172C4C0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x172C530 Offset: 0x172AB30 VA: 0x18172C530 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x172C5A0 Offset: 0x172ABA0 VA: 0x18172C5A0 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x172C620 Offset: 0x172AC20 VA: 0x18172C620 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 2764
{	// Fields
	internal TypeDescriptor.TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x173A360 Offset: 0x1738960 VA: 0x18173A360
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x1739DC0 Offset: 0x17383C0 VA: 0x181739DC0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1739F40 Offset: 0x1738540 VA: 0x181739F40 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1739FD0 Offset: 0x17385D0 VA: 0x181739FD0 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x173A090 Offset: 0x1738690 VA: 0x18173A090 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x173A120 Offset: 0x1738720 VA: 0x18173A120 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x173A1F0 Offset: 0x17387F0 VA: 0x18173A1F0 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2765
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private object _instance; // 0x8

	// Methods

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, object instance) { }

	// RVA: 0x2079E0 Offset: 0x206DE0 VA: 0x1802079E0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x2079F0 Offset: 0x206DF0 VA: 0x1802079F0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x207A10 Offset: 0x206E10 VA: 0x180207A10 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x207A00 Offset: 0x206E00 VA: 0x180207A00 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x207A20 Offset: 0x206E20 VA: 0x180207A20 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2766
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private Type _objectType; // 0x8
	private object _instance; // 0x10

	// Methods

	// RVA: 0xF5C70 Offset: 0xF5070 VA: 0x1800F5C70
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x207A50 Offset: 0x206E50 VA: 0x180207A50 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x207A60 Offset: 0x206E60 VA: 0x180207A60 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x207A80 Offset: 0x206E80 VA: 0x180207A80 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x207A70 Offset: 0x206E70 VA: 0x180207A70 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x207A90 Offset: 0x206E90 VA: 0x180207A90 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

