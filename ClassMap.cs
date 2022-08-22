internal class ClassMap : ObjectMap // TypeDefIndex: 2128
{	// Fields
	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private Nullable<bool> _isOrderDependentMap; // 0x7A

	// Properties
	public bool IsOrderDependentMap { get; }
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember { get; }
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember { get; }
	public XmlTypeMapMemberNamespaces NamespaceDeclarations { get; }
	public ICollection AttributeMembers { get; }
	public ICollection ElementMembers { get; }
	public ArrayList AllMembers { get; }
	public ArrayList FlatLists { get; }
	public ArrayList ListMembers { get; }
	public XmlTypeMapMember XmlTextCollector { get; }
	public XmlTypeMapMember ReturnMember { get; }
	public XmlQualifiedName SimpleContentBaseType { get; }
	public bool HasSimpleContent { get; }

	// Methods

	// RVA: 0x10FEB30 Offset: 0x10FD130 VA: 0x1810FEB30
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x10FFDC0 Offset: 0x10FE3C0 VA: 0x1810FFDC0
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x10FF820 Offset: 0x10FDE20 VA: 0x1810FF820
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x10FFB40 Offset: 0x10FE140 VA: 0x1810FFB40
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x10FF930 Offset: 0x10FDF30 VA: 0x1810FF930
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x10FF770 Offset: 0x10FDD70 VA: 0x1810FF770
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x1100270 Offset: 0x10FE870 VA: 0x181100270
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x10FFF20 Offset: 0x10FE520 VA: 0x1810FFF20
	public ICollection get_AttributeMembers() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ICollection get_ElementMembers() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public ArrayList get_AllMembers() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public ArrayList get_FlatLists() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public ArrayList get_ListMembers() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x11004D0 Offset: 0x10FEAD0 VA: 0x1811004D0
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x10FFE80 Offset: 0x10FE480 VA: 0x1810FFE80
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x1100200 Offset: 0x10FE800 VA: 0x181100200
	public bool get_HasSimpleContent() { }

	// RVA: 0x10FFE90 Offset: 0x10FE490 VA: 0x1810FFE90
	public void .ctor() { }

}

