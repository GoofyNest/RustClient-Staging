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

	// RVA: 0xEDA4A0 Offset: 0xED8AA0 VA: 0x180EDA4A0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Type get_PropertyType();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo[] GetAccessors(bool nonPublic);

	// RVA: 0x18D3FC0 Offset: 0x18D25C0 VA: 0x1818D3FC0 Slot: 22
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: 0x18D41A0 Offset: 0x18D27A0 VA: 0x1818D41A0 Slot: 25
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D0D50 Offset: 0x18CF350 VA: 0x1818D0D50 Slot: 27
	public virtual object GetValue(object obj, object[] index) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D41C0 Offset: 0x18D27C0 VA: 0x1818D41C0
	public object GetValue(object obj) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D4200 Offset: 0x18D2800 VA: 0x1818D4200 Slot: 29
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x18D3FE0 Offset: 0x18D25E0 VA: 0x1818D3FE0 Slot: 31
	public virtual Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18D4140 Offset: 0x18D2740 VA: 0x1818D4140 Slot: 32
	public virtual Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18D3F30 Offset: 0x18D2530 VA: 0x1818D3F30
	private static NotImplementedException CreateNIE() { }

	// RVA: 0x18D3F80 Offset: 0x18D2580 VA: 0x1818D3F80 Slot: 33
	public virtual object GetConstantValue() { }

	// RVA: 0x18D4100 Offset: 0x18D2700 VA: 0x1818D4100 Slot: 34
	public virtual object GetRawConstantValue() { }

	// RVA: 0x12922A0 Offset: 0x12908A0 VA: 0x1812922A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C5D30 Offset: 0x18C4330 VA: 0x1818C5D30
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18C5D80 Offset: 0x18C4380 VA: 0x1818C5D80
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18D4240 Offset: 0x18D2840 VA: 0x1818D4240
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x18D4040 Offset: 0x18D2640 VA: 0x1818D4040
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

}

