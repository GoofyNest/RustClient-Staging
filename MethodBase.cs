public abstract class MethodBase : MemberInfo, _MethodBase // TypeDefIndex: 539
{	// Properties
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsSecurityCritical { get; }
	public bool IsPublic { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsAbstract { get; }
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public bool IsConstructor { get; }

	// Methods

	// RVA: 0x18CBC80 Offset: 0x18CA280 VA: 0x1818CBC80
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CC1D0 Offset: 0x18CA7D0 VA: 0x1818CC1D0
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CC420 Offset: 0x18CAA20 VA: 0x1818CC420
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CB2E0 Offset: 0x18C98E0 VA: 0x1818CB2E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10B8AA0 Offset: 0x10B70A0 VA: 0x1810B8AA0 Slot: 17
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 23
	public virtual CallingConventions get_CallingConvention() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CBB40 Offset: 0x18CA140 VA: 0x1818CBB40 Slot: 24
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 26
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 27
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x18CC140 Offset: 0x18CA740 VA: 0x1818CC140 Slot: 28
	public virtual bool get_IsSecurityCritical() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CBFF0 Offset: 0x18CA5F0 VA: 0x1818CBFF0 Slot: 29
	public object Invoke(object obj, object[] parameters) { }

	// RVA: 0x18CC110 Offset: 0x18CA710 VA: 0x1818CC110 Slot: 30
	public bool get_IsPublic() { }

	// RVA: 0x18CC190 Offset: 0x18CA790 VA: 0x1818CC190 Slot: 31
	public bool get_IsStatic() { }

	// RVA: 0x18CC1B0 Offset: 0x18CA7B0 VA: 0x1818CC1B0 Slot: 32
	public bool get_IsVirtual() { }

	// RVA: 0x18CC030 Offset: 0x18CA630 VA: 0x1818CC030 Slot: 33
	public bool get_IsAbstract() { }

	// RVA: 0x18CC060 Offset: 0x18CA660 VA: 0x1818CC060 Slot: 34
	public bool get_IsConstructor() { }

	// RVA: 0x18CBBC0 Offset: 0x18CA1C0 VA: 0x1818CBBC0 Slot: 35
	public virtual MethodBody GetMethodBody() { }

	// RVA: 0x18CB860 Offset: 0x18C9E60 VA: 0x1818CB860
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x18CBA30 Offset: 0x18CA030 VA: 0x1818CBA30 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18CBE90 Offset: 0x18CA490 VA: 0x1818CBE90 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x10B8AA0 Offset: 0x10B70A0 VA: 0x1810B8AA0 Slot: 38
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CBFC0 Offset: 0x18CA5C0 VA: 0x1818CBFC0 Slot: 39
	internal virtual int GetParametersCount() { }

	// RVA: 0x18CBC40 Offset: 0x18CA240 VA: 0x1818CBC40
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x18CBC30 Offset: 0x18CA230 VA: 0x1818CBC30
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x18CBBB0 Offset: 0x18CA1B0 VA: 0x1818CBBB0
	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	// RVA: 0x18CBBB0 Offset: 0x18CA1B0 VA: 0x1818CBBB0
	internal static MethodBody GetMethodBody(IntPtr handle) { }

	// RVA: 0x18CBC10 Offset: 0x18CA210 VA: 0x1818CBC10
	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x18CBC20 Offset: 0x18CA220 VA: 0x1818CBC20
	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

}

