public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 542
{	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CCF30 Offset: 0x18CB530 VA: 0x1818CCF30
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CD020 Offset: 0x18CB620 VA: 0x1818CD020
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CB900 Offset: 0x18C9F00 VA: 0x1818CB900 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18CCEE0 Offset: 0x18CB4E0 VA: 0x1818CCEE0 Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract MethodInfo GetBaseDefinition();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CCD90 Offset: 0x18CB390 VA: 0x1818CCD90 Slot: 24
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CCE00 Offset: 0x18CB400 VA: 0x1818CCE00 Slot: 42
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18CCE70 Offset: 0x18CB470 VA: 0x1818CCE70 Slot: 43
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: 0x18CCD20 Offset: 0x18CB320 VA: 0x1818CCD20 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 45
	internal virtual MethodInfo GetBaseMethod() { }

}

