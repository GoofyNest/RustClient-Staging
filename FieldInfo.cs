public abstract class FieldInfo : MemberInfo, _FieldInfo // TypeDefIndex: 568
{	// Properties
	public abstract FieldAttributes Attributes { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }
	public abstract Type FieldType { get; }
	public override MemberTypes MemberType { get; }
	public bool IsLiteral { get; }
	public bool IsStatic { get; }
	public bool IsInitOnly { get; }
	public bool IsPublic { get; }
	public bool IsPrivate { get; }
	public bool IsNotSerialized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Type get_FieldType();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object GetValue(object obj);

	// RVA: 0xE38BC0 Offset: 0xE371C0 VA: 0x180E38BC0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x18C9170 Offset: 0x18C7770 VA: 0x1818C9170 Slot: 21
	public bool get_IsLiteral() { }

	// RVA: 0x18C9200 Offset: 0x18C7800 VA: 0x1818C9200 Slot: 22
	public bool get_IsStatic() { }

	// RVA: 0x18C9150 Offset: 0x18C7750 VA: 0x1818C9150 Slot: 23
	public bool get_IsInitOnly() { }

	// RVA: 0x18C91D0 Offset: 0x18C77D0 VA: 0x1818C91D0 Slot: 24
	public bool get_IsPublic() { }

	// RVA: 0x18C91B0 Offset: 0x18C77B0 VA: 0x1818C91B0 Slot: 25
	public bool get_IsPrivate() { }

	// RVA: 0x18C9190 Offset: 0x18C7790 VA: 0x1818C9190 Slot: 26
	public bool get_IsNotSerialized() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18C9120 Offset: 0x18C7720 VA: 0x1818C9120 Slot: 28
	public void SetValue(object obj, object value) { }

	// RVA: 0x18C9220 Offset: 0x18C7820 VA: 0x1818C9220
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x18C8C10 Offset: 0x18C7210 VA: 0x1818C8C10
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x18C8C90 Offset: 0x18C7290 VA: 0x1818C8C90
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x18C8D50 Offset: 0x18C7350 VA: 0x1818C8D50 Slot: 29
	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x18C90B0 Offset: 0x18C76B0 VA: 0x1818C90B0 Slot: 30
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x17C7AA0 Offset: 0x17C60A0 VA: 0x1817C7AA0
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x18C8DB0 Offset: 0x18C73B0 VA: 0x1818C8DB0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18C9050 Offset: 0x18C7650 VA: 0x1818C9050 Slot: 31
	public virtual object GetRawConstantValue() { }

	// RVA: 0x12922A0 Offset: 0x12908A0 VA: 0x1812922A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C5D30 Offset: 0x18C4330 VA: 0x1818C5D30
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x18C5D80 Offset: 0x18C4380 VA: 0x1818C5D80
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

}

