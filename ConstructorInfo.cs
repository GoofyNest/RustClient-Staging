public abstract class ConstructorInfo : MethodBase, _ConstructorInfo // TypeDefIndex: 559
{	[ComVisibleAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public static readonly string ConstructorName; // 0x0
	[ComVisibleAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public static readonly string TypeConstructorName; // 0x8

	[ComVisibleAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public override MemberTypes MemberType { get; }


	protected void .ctor() { }

	public override MemberTypes get_MemberType() { }

	[DebuggerStepThroughAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	[DebuggerHiddenAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	public object Invoke(object[] parameters) { }

	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	private static void .cctor() { }

}

