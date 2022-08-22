public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 542
{	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CC910 Offset: 0x18CAF10 VA: 0x1818CC910
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CCA00 Offset: 0x18CB000 VA: 0x1818CCA00
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CB2E0 Offset: 0x18C98E0 VA: 0x1818CB2E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8C1310 Offset: 0x8BF910 VA: 0x1808C1310 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18CC8C0 Offset: 0x18CAEC0 VA: 0x1818CC8C0 Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract MethodInfo GetBaseDefinition();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CC770 Offset: 0x18CAD70 VA: 0x1818CC770 Slot: 24
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CC7E0 Offset: 0x18CADE0 VA: 0x1818CC7E0 Slot: 42
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18CC850 Offset: 0x18CAE50 VA: 0x1818CC850 Slot: 43
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: 0x18CC700 Offset: 0x18CAD00 VA: 0x1818CC700 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 45
	internal virtual MethodInfo GetBaseMethod() { }

}

