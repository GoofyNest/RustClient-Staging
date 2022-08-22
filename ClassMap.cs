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

	// RVA: 0x10FE0C0 Offset: 0x10FC6C0 VA: 0x1810FE0C0
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x10FF350 Offset: 0x10FD950 VA: 0x1810FF350
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x10FEDB0 Offset: 0x10FD3B0 VA: 0x1810FEDB0
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x10FF0D0 Offset: 0x10FD6D0 VA: 0x1810FF0D0
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x10FEEC0 Offset: 0x10FD4C0 VA: 0x1810FEEC0
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x10FED00 Offset: 0x10FD300 VA: 0x1810FED00
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x10FF800 Offset: 0x10FDE00 VA: 0x1810FF800
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x10FF4B0 Offset: 0x10FDAB0 VA: 0x1810FF4B0
	public ICollection get_AttributeMembers() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ICollection get_ElementMembers() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public ArrayList get_AllMembers() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ArrayList get_FlatLists() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public ArrayList get_ListMembers() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x10FFA60 Offset: 0x10FE060 VA: 0x1810FFA60
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x10FF410 Offset: 0x10FDA10 VA: 0x1810FF410
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x10FF790 Offset: 0x10FDD90 VA: 0x1810FF790
	public bool get_HasSimpleContent() { }

	// RVA: 0x10FF420 Offset: 0x10FDA20 VA: 0x1810FF420
	public void .ctor() { }

}

