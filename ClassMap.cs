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

	// RVA: 0x10FDE00 Offset: 0x10FC400 VA: 0x1810FDE00
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x10FF090 Offset: 0x10FD690 VA: 0x1810FF090
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x10FEAF0 Offset: 0x10FD0F0 VA: 0x1810FEAF0
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x10FEE10 Offset: 0x10FD410 VA: 0x1810FEE10
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x10FEC00 Offset: 0x10FD200 VA: 0x1810FEC00
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x10FEA40 Offset: 0x10FD040 VA: 0x1810FEA40
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x10FF540 Offset: 0x10FDB40 VA: 0x1810FF540
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x10FF1F0 Offset: 0x10FD7F0 VA: 0x1810FF1F0
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

	// RVA: 0x10FF7A0 Offset: 0x10FDDA0 VA: 0x1810FF7A0
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x10FF150 Offset: 0x10FD750 VA: 0x1810FF150
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x10FF4D0 Offset: 0x10FDAD0 VA: 0x1810FF4D0
	public bool get_HasSimpleContent() { }

	// RVA: 0x10FF160 Offset: 0x10FD760 VA: 0x1810FF160
	public void .ctor() { }

}

