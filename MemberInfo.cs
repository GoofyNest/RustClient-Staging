public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo // TypeDefIndex: 535
{	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual int MetadataToken { get; }
	public virtual Module Module { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_ReflectedType();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: 0x18CB910 Offset: 0x18C9F10 VA: 0x1818CB910 Slot: 14
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x18CB960 Offset: 0x18C9F60 VA: 0x1818CB960 Slot: 15
	public virtual int get_MetadataToken() { }

	// RVA: 0x18CB970 Offset: 0x18C9F70 VA: 0x1818CB970 Slot: 16
	public virtual Module get_Module() { }

	// RVA: 0x18CBAA0 Offset: 0x18CA0A0 VA: 0x1818CBAA0
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x18CBE60 Offset: 0x18CA460 VA: 0x1818CBE60
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x18CB900 Offset: 0x18C9F00 VA: 0x1818CB900 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

}

