public abstract class ConstructorInfo : MethodBase, _ConstructorInfo // TypeDefIndex: 559
{	// Fields
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static readonly string ConstructorName; // 0x0
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18C66C0 Offset: 0x18C4CC0 VA: 0x1818C66C0
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6350 Offset: 0x18C4950 VA: 0x1818C6350
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x18C63A0 Offset: 0x18C49A0 VA: 0x1818C63A0
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x18C6770 Offset: 0x18C4D70 VA: 0x1818C6770
	private static void .cctor() { }

}

