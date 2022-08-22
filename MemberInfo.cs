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

	// RVA: 0x18CB2F0 Offset: 0x18C98F0 VA: 0x1818CB2F0 Slot: 14
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x18CB340 Offset: 0x18C9940 VA: 0x1818CB340 Slot: 15
	public virtual int get_MetadataToken() { }

	// RVA: 0x18CB350 Offset: 0x18C9950 VA: 0x1818CB350 Slot: 16
	public virtual Module get_Module() { }

	// RVA: 0x18CB480 Offset: 0x18C9A80 VA: 0x1818CB480
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x18CB840 Offset: 0x18C9E40 VA: 0x1818CB840
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x18CB2E0 Offset: 0x18C98E0 VA: 0x1818CB2E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

}

