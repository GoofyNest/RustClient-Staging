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

	// RVA: 0x18CC560 Offset: 0x18CAB60 VA: 0x1818CC560
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CCAB0 Offset: 0x18CB0B0 VA: 0x1818CCAB0
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CCD00 Offset: 0x18CB300 VA: 0x1818CCD00
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x18CBBC0 Offset: 0x18CA1C0 VA: 0x1818CBBC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10B8030 Offset: 0x10B6630 VA: 0x1810B8030 Slot: 17
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

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 23
	public virtual CallingConventions get_CallingConvention() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18CC420 Offset: 0x18CAA20 VA: 0x1818CC420 Slot: 24
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 25
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 26
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 27
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x18CCA20 Offset: 0x18CB020 VA: 0x1818CCA20 Slot: 28
	public virtual bool get_IsSecurityCritical() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CC8D0 Offset: 0x18CAED0 VA: 0x1818CC8D0 Slot: 29
	public object Invoke(object obj, object[] parameters) { }

	// RVA: 0x18CC9F0 Offset: 0x18CAFF0 VA: 0x1818CC9F0 Slot: 30
	public bool get_IsPublic() { }

	// RVA: 0x18CCA70 Offset: 0x18CB070 VA: 0x1818CCA70 Slot: 31
	public bool get_IsStatic() { }

	// RVA: 0x18CCA90 Offset: 0x18CB090 VA: 0x1818CCA90 Slot: 32
	public bool get_IsVirtual() { }

	// RVA: 0x18CC910 Offset: 0x18CAF10 VA: 0x1818CC910 Slot: 33
	public bool get_IsAbstract() { }

	// RVA: 0x18CC940 Offset: 0x18CAF40 VA: 0x1818CC940 Slot: 34
	public bool get_IsConstructor() { }

	// RVA: 0x18CC4A0 Offset: 0x18CAAA0 VA: 0x1818CC4A0 Slot: 35
	public virtual MethodBody GetMethodBody() { }

	// RVA: 0x18CC140 Offset: 0x18CA740 VA: 0x1818CC140
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x18CC310 Offset: 0x18CA910 VA: 0x1818CC310 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18CC770 Offset: 0x18CAD70 VA: 0x1818CC770 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x10B8030 Offset: 0x10B6630 VA: 0x1810B8030 Slot: 38
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CC8A0 Offset: 0x18CAEA0 VA: 0x1818CC8A0 Slot: 39
	internal virtual int GetParametersCount() { }

	// RVA: 0x18CC520 Offset: 0x18CAB20 VA: 0x1818CC520
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x18CC510 Offset: 0x18CAB10 VA: 0x1818CC510
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x18CC490 Offset: 0x18CAA90 VA: 0x1818CC490
	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	// RVA: 0x18CC490 Offset: 0x18CAA90 VA: 0x1818CC490
	internal static MethodBody GetMethodBody(IntPtr handle) { }

	// RVA: 0x18CC4F0 Offset: 0x18CAAF0 VA: 0x1818CC4F0
	private static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x18CC500 Offset: 0x18CAB00 VA: 0x1818CC500
	internal static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

}

