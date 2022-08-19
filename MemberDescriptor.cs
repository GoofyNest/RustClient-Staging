public abstract class MemberDescriptor // TypeDefIndex: 2729
{	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual string DisplayName { get; }

	// Methods

	// RVA: 0x15CA590 Offset: 0x15C8B90 VA: 0x1815CA590
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x15CA6D0 Offset: 0x15C8CD0 VA: 0x1815CA6D0
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x15CAAB0 Offset: 0x15C90B0 VA: 0x1815CAAB0 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x15CAD50 Offset: 0x15C9350 VA: 0x1815CAD50 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x15CAAE0 Offset: 0x15C90E0 VA: 0x1815CAAE0 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x15CAD10 Offset: 0x15C9310 VA: 0x1815CAD10 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x15CABE0 Offset: 0x15C91E0 VA: 0x1815CABE0 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x15C98B0 Offset: 0x15C7EB0 VA: 0x1815C98B0
	private void CheckAttributesValid() { }

	// RVA: 0x15C9990 Offset: 0x15C7F90 VA: 0x1815C9990 Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x15C9A00 Offset: 0x15C8000 VA: 0x1815C9A00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9CA0 Offset: 0x15C82A0 VA: 0x1815C9CA0 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x15C9DD0 Offset: 0x15C83D0 VA: 0x1815C9DD0
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x15CA2B0 Offset: 0x15C88B0 VA: 0x1815CA2B0
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x15CA330 Offset: 0x15C8930 VA: 0x1815CA330
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15CA3E0 Offset: 0x15C89E0 VA: 0x1815CA3E0 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15CA4E0 Offset: 0x15C8AE0 VA: 0x1815CA4E0
	protected static ISite GetSite(object component) { }

}

