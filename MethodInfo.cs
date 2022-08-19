public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 542
{	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CCF70 Offset: 0x18CB570 VA: 0x1818CCF70
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CD060 Offset: 0x18CB660 VA: 0x1818CD060
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x18CB940 Offset: 0x18C9F40 VA: 0x1818CB940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x8C0CF0 Offset: 0x8BF2F0 VA: 0x1808C0CF0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18CCF20 Offset: 0x18CB520 VA: 0x1818CCF20 Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract MethodInfo GetBaseDefinition();

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x18CCDD0 Offset: 0x18CB3D0 VA: 0x1818CCDD0 Slot: 24
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x18CCE40 Offset: 0x18CB440 VA: 0x1818CCE40 Slot: 42
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18CCEB0 Offset: 0x18CB4B0 VA: 0x1818CCEB0 Slot: 43
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: 0x18CCD60 Offset: 0x18CB360 VA: 0x1818CCD60 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 45
	internal virtual MethodInfo GetBaseMethod() { }

}

