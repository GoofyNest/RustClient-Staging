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

	// RVA: 0x15C9920 Offset: 0x15C7F20 VA: 0x1815C9920
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x15C9A60 Offset: 0x15C8060 VA: 0x1815C9A60
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x15C9E40 Offset: 0x15C8440 VA: 0x1815C9E40 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x15CA0E0 Offset: 0x15C86E0 VA: 0x1815CA0E0 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x15C9E70 Offset: 0x15C8470 VA: 0x1815C9E70 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x15CA0A0 Offset: 0x15C86A0 VA: 0x1815CA0A0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x15C9F70 Offset: 0x15C8570 VA: 0x1815C9F70 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x15C8C40 Offset: 0x15C7240 VA: 0x1815C8C40
	private void CheckAttributesValid() { }

	// RVA: 0x15C8D20 Offset: 0x15C7320 VA: 0x1815C8D20 Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x15C8D90 Offset: 0x15C7390 VA: 0x1815C8D90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9030 Offset: 0x15C7630 VA: 0x1815C9030 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x15C9160 Offset: 0x15C7760 VA: 0x1815C9160
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x15C9640 Offset: 0x15C7C40 VA: 0x1815C9640
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x15C96C0 Offset: 0x15C7CC0 VA: 0x1815C96C0
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C9770 Offset: 0x15C7D70 VA: 0x1815C9770 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15C9870 Offset: 0x15C7E70 VA: 0x1815C9870
	protected static ISite GetSite(object component) { }

}

