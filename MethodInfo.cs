public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 542
{	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CD1F0 Offset: 0x18CB7F0 VA: 0x1818CD1F0
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CD2E0 Offset: 0x18CB8E0 VA: 0x1818CD2E0
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CBBC0 Offset: 0x18CA1C0 VA: 0x1818CBBC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8C0E00 Offset: 0x8BF400 VA: 0x1808C0E00 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18CD1A0 Offset: 0x18CB7A0 VA: 0x1818CD1A0 Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract MethodInfo GetBaseDefinition();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CD050 Offset: 0x18CB650 VA: 0x1818CD050 Slot: 24
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CD0C0 Offset: 0x18CB6C0 VA: 0x1818CD0C0 Slot: 42
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18CD130 Offset: 0x18CB730 VA: 0x1818CD130 Slot: 43
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: 0x18CCFE0 Offset: 0x18CB5E0 VA: 0x1818CCFE0 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 45
	internal virtual MethodInfo GetBaseMethod() { }

}

