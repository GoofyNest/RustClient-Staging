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

	// RVA: 0x173EF80 Offset: 0x173D580 VA: 0x18173EF80
	public static Type get_ComObjectType() { }

	// RVA: 0x173EFE0 Offset: 0x173D5E0 VA: 0x18173EFE0
	public static Type get_InterfaceType() { }

	// RVA: 0x173F040 Offset: 0x173D640 VA: 0x18173F040
	internal static int get_MetadataVersion() { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1738470 Offset: 0x1736A70 VA: 0x181738470
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1738710 Offset: 0x1736D10 VA: 0x181738710
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x1738DD0 Offset: 0x17373D0 VA: 0x181738DD0
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1739030 Offset: 0x1737630 VA: 0x181739030
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1739250 Offset: 0x1737850 VA: 0x181739250
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x1739730 Offset: 0x1737D30 VA: 0x181739730
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x17396D0 Offset: 0x1737CD0 VA: 0x1817396D0
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x1739800 Offset: 0x1737E00 VA: 0x181739800
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1739B10 Offset: 0x1738110 VA: 0x181739B10
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x1739BD0 Offset: 0x17381D0 VA: 0x181739BD0
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1739C50 Offset: 0x1738250 VA: 0x181739C50
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x1739D80 Offset: 0x1738380 VA: 0x181739D80
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1739FE0 Offset: 0x17385E0 VA: 0x181739FE0
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x173A0D0 Offset: 0x17386D0 VA: 0x18173A0D0
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x173A340 Offset: 0x1738940 VA: 0x18173A340
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x173AA10 Offset: 0x1739010 VA: 0x18173AA10
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x173A9A0 Offset: 0x1738FA0 VA: 0x18173A9A0
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x173A4C0 Offset: 0x1738AC0 VA: 0x18173A4C0
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x173AAC0 Offset: 0x17390C0 VA: 0x18173AAC0
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x173AB20 Offset: 0x1739120 VA: 0x18173AB20
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x173B290 Offset: 0x1739890 VA: 0x18173B290
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x173AC40 Offset: 0x1739240 VA: 0x18173AC40
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x173B230 Offset: 0x1739830 VA: 0x18173B230
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x173B2F0 Offset: 0x17398F0 VA: 0x18173B2F0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x173B520 Offset: 0x1739B20 VA: 0x18173B520
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x173B960 Offset: 0x1739F60 VA: 0x18173B960
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x173CD00 Offset: 0x173B300 VA: 0x18173CD00
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x173D0E0 Offset: 0x173B6E0 VA: 0x18173D0E0
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x173D9E0 Offset: 0x173BFE0 VA: 0x18173D9E0
	private static void RaiseRefresh(object component) { }

	// RVA: 0x173DB00 Offset: 0x173C100 VA: 0x18173DB00
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x173E120 Offset: 0x173C720 VA: 0x18173E120
	public static void Refresh(object component) { }

	// RVA: 0x173E180 Offset: 0x173C780 VA: 0x18173E180
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x173DBF0 Offset: 0x173C1F0 VA: 0x18173DBF0
	public static void Refresh(Type type) { }

	// RVA: 0x173E8A0 Offset: 0x173CEA0 VA: 0x18173E8A0
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x173E960 Offset: 0x173CF60 VA: 0x18173E960
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x173EA40 Offset: 0x173D040 VA: 0x18173EA40
	private static void .cctor() { }

}

private sealed class TypeDescriptor.AttributeFilterCacheItem // TypeDefIndex: 2759
{	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x17259E0 Offset: 0x1723FE0 VA: 0x1817259E0
	internal bool IsValid(Attribute[] filter) { }

}

private sealed class TypeDescriptor.FilterCacheItem // TypeDefIndex: 2760
{	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0xE37A30 Offset: 0xE36030 VA: 0x180E37A30
	internal bool IsValid(ITypeDescriptorFilterService filterService) { }

}

private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
{
// Namespace: 
private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 2762
	// Fields
	public static readonly TypeDescriptor.MemberDescriptorComparer Instance; // 0x14240

	// Methods

	// RVA: 0x1729DE0 Offset: 0x17283E0 VA: 0x181729DE0 Slot: 4
	public int Compare(object left, object right) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1729FB0 Offset: 0x17285B0 VA: 0x181729FB0
	private static void .cctor() { }

}

private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2763
{	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x172A010 Offset: 0x1728610 VA: 0x18172A010 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x172A080 Offset: 0x1728680 VA: 0x18172A080 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x172A0F0 Offset: 0x17286F0 VA: 0x18172A0F0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x172A160 Offset: 0x1728760 VA: 0x18172A160 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x172A1E0 Offset: 0x17287E0 VA: 0x18172A1E0 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 2764
{	// Fields
	internal TypeDescriptor.TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x1737F20 Offset: 0x1736520 VA: 0x181737F20
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x1737980 Offset: 0x1735F80 VA: 0x181737980 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1737B00 Offset: 0x1736100 VA: 0x181737B00 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1737B90 Offset: 0x1736190 VA: 0x181737B90 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1737C50 Offset: 0x1736250 VA: 0x181737C50 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1737CE0 Offset: 0x17362E0 VA: 0x181737CE0 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1737DB0 Offset: 0x17363B0 VA: 0x181737DB0 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2765
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private object _instance; // 0x8

	// Methods

	// RVA: 0xF5DB0 Offset: 0xF51B0 VA: 0x1800F5DB0
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, object instance) { }

	// RVA: 0x207610 Offset: 0x206A10 VA: 0x180207610 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x207620 Offset: 0x206A20 VA: 0x180207620 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x207640 Offset: 0x206A40 VA: 0x180207640 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x207630 Offset: 0x206A30 VA: 0x180207630 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x207650 Offset: 0x206A50 VA: 0x180207650 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private struct TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2766
{	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private Type _objectType; // 0x8
	private object _instance; // 0x10

	// Methods

	// RVA: 0xF5FD0 Offset: 0xF53D0 VA: 0x1800F5FD0
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x207680 Offset: 0x206A80 VA: 0x180207680 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x207690 Offset: 0x206A90 VA: 0x180207690 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x2076B0 Offset: 0x206AB0 VA: 0x1802076B0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x2076A0 Offset: 0x206AA0 VA: 0x1802076A0 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x2076C0 Offset: 0x206AC0 VA: 0x1802076C0 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

