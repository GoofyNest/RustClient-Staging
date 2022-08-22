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

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18C60A0 Offset: 0x18C46A0 VA: 0x1818C60A0
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x12922A0 Offset: 0x12908A0 VA: 0x1812922A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C5D30 Offset: 0x18C4330 VA: 0x1818C5D30
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x18C5D80 Offset: 0x18C4380 VA: 0x1818C5D80
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x18C6150 Offset: 0x18C4750 VA: 0x1818C6150
	private static void .cctor() { }

}

