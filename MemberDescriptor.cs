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

	// RVA: 0x15CA850 Offset: 0x15C8E50 VA: 0x1815CA850
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x15CA990 Offset: 0x15C8F90 VA: 0x1815CA990
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x15CAD70 Offset: 0x15C9370 VA: 0x1815CAD70 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x15CB010 Offset: 0x15C9610 VA: 0x1815CB010 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x15CADA0 Offset: 0x15C93A0 VA: 0x1815CADA0 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x15CAFD0 Offset: 0x15C95D0 VA: 0x1815CAFD0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x15CAEA0 Offset: 0x15C94A0 VA: 0x1815CAEA0 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x15C9B70 Offset: 0x15C8170 VA: 0x1815C9B70
	private void CheckAttributesValid() { }

	// RVA: 0x15C9C50 Offset: 0x15C8250 VA: 0x1815C9C50 Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x15C9CC0 Offset: 0x15C82C0 VA: 0x1815C9CC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9F60 Offset: 0x15C8560 VA: 0x1815C9F60 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x15CA090 Offset: 0x15C8690 VA: 0x1815CA090
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x15CA570 Offset: 0x15C8B70 VA: 0x1815CA570
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x15CA5F0 Offset: 0x15C8BF0 VA: 0x1815CA5F0
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15CA6A0 Offset: 0x15C8CA0 VA: 0x1815CA6A0 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15CA7A0 Offset: 0x15C8DA0 VA: 0x1815CA7A0
	protected static ISite GetSite(object component) { }

}

