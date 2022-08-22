public abstract class PropertyInfo : MemberInfo, _PropertyInfo // TypeDefIndex: 597
{	// Properties
	public abstract PropertyAttributes Attributes { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract PropertyAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_CanWrite();

	// RVA: 0xED9730 Offset: 0xED7D30 VA: 0x180ED9730 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Type get_PropertyType();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo[] GetAccessors(bool nonPublic);

	// RVA: 0x18D45E0 Offset: 0x18D2BE0 VA: 0x1818D45E0 Slot: 22
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: 0x18D47C0 Offset: 0x18D2DC0 VA: 0x1818D47C0 Slot: 25
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D1370 Offset: 0x18CF970 VA: 0x1818D1370 Slot: 27
	public virtual object GetValue(object obj, object[] index) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D47E0 Offset: 0x18D2DE0 VA: 0x1818D47E0
	public object GetValue(object obj) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D4820 Offset: 0x18D2E20 VA: 0x1818D4820 Slot: 29
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x18D4600 Offset: 0x18D2C00 VA: 0x1818D4600 Slot: 31
	public virtual Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18D4760 Offset: 0x18D2D60 VA: 0x1818D4760 Slot: 32
	public virtual Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18D4550 Offset: 0x18D2B50 VA: 0x1818D4550
	private static NotImplementedException CreateNIE() { }

	// RVA: 0x18D45A0 Offset: 0x18D2BA0 VA: 0x1818D45A0 Slot: 33
	public virtual object GetConstantValue() { }

	// RVA: 0x18D4720 Offset: 0x18D2D20 VA: 0x1818D4720 Slot: 34
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6350 Offset: 0x18C4950 VA: 0x1818C6350
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18C63A0 Offset: 0x18C49A0 VA: 0x1818C63A0
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18D4860 Offset: 0x18D2E60 VA: 0x1818D4860
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x18D4660 Offset: 0x18D2C60 VA: 0x1818D4660
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

}

