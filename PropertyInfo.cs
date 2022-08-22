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

	// RVA: 0xED99F0 Offset: 0xED7FF0 VA: 0x180ED99F0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Type get_PropertyType();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo[] GetAccessors(bool nonPublic);

	// RVA: 0x18D48A0 Offset: 0x18D2EA0 VA: 0x1818D48A0 Slot: 22
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: 0x18D4A80 Offset: 0x18D3080 VA: 0x1818D4A80 Slot: 25
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D1630 Offset: 0x18CFC30 VA: 0x1818D1630 Slot: 27
	public virtual object GetValue(object obj, object[] index) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D4AA0 Offset: 0x18D30A0 VA: 0x1818D4AA0
	public object GetValue(object obj) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18D4AE0 Offset: 0x18D30E0 VA: 0x1818D4AE0 Slot: 29
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x18D48C0 Offset: 0x18D2EC0 VA: 0x1818D48C0 Slot: 31
	public virtual Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18D4A20 Offset: 0x18D3020 VA: 0x1818D4A20 Slot: 32
	public virtual Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18D4810 Offset: 0x18D2E10 VA: 0x1818D4810
	private static NotImplementedException CreateNIE() { }

	// RVA: 0x18D4860 Offset: 0x18D2E60 VA: 0x1818D4860 Slot: 33
	public virtual object GetConstantValue() { }

	// RVA: 0x18D49E0 Offset: 0x18D2FE0 VA: 0x1818D49E0 Slot: 34
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1291C00 Offset: 0x1290200 VA: 0x181291C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6610 Offset: 0x18C4C10 VA: 0x1818C6610
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18C6660 Offset: 0x18C4C60 VA: 0x1818C6660
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x18D4B20 Offset: 0x18D3120 VA: 0x1818D4B20
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x18D4920 Offset: 0x18D2F20 VA: 0x1818D4920
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

}

