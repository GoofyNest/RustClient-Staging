public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 356
{	// Fields
	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private MethodInfo method_info; // 0x48
	private MethodInfo original_method_info; // 0x50
	private DelegateData data; // 0x58
	private bool method_is_virtual; // 0x60

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x82BCA0 Offset: 0x82A2A0 VA: 0x18082BCA0
	public MethodInfo get_Method() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public object get_Target() { }

	// RVA: 0xD714A0 Offset: 0xD6FAA0 VA: 0x180D714A0
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0xD73040 Offset: 0xD71640 VA: 0x180D73040
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0xD731F0 Offset: 0xD717F0 VA: 0x180D731F0
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0xD733B0 Offset: 0xD719B0 VA: 0x180D733B0
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0xD714B0 Offset: 0xD6FAB0 VA: 0x180D714B0
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD715D0 Offset: 0xD6FBD0 VA: 0x180D715D0
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0xD714D0 Offset: 0xD6FAD0 VA: 0x180D714D0
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD72280 Offset: 0xD70880 VA: 0x180D72280
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0xD72250 Offset: 0xD70850 VA: 0x180D72250
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0xD714F0 Offset: 0xD6FAF0 VA: 0x180D714F0
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0xD72590 Offset: 0xD70B90 VA: 0x180D72590
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD722B0 Offset: 0xD708B0 VA: 0x180D722B0
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD72150 Offset: 0xD70750 VA: 0x180D72150
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0xD72050 Offset: 0xD70650 VA: 0x180D72050
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0xD71F60 Offset: 0xD70560 VA: 0x180D71F60
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 6
	public virtual object Clone() { }

	// RVA: 0xD723D0 Offset: 0xD709D0 VA: 0x180D723D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xD729D0 Offset: 0xD70FD0 VA: 0x180D729D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xD72B10 Offset: 0xD71110 VA: 0x180D72B10 Slot: 7
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0xD72C00 Offset: 0xD71200 VA: 0x180D72C00 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD72A60 Offset: 0xD71060 VA: 0x180D72A60 Slot: 9
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0xD712C0 Offset: 0xD6F8C0 VA: 0x180D712C0
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0xD710A0 Offset: 0xD6F6A0 VA: 0x180D710A0
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0xD71030 Offset: 0xD6F630 VA: 0x180D71030 Slot: 10
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0xD72E70 Offset: 0xD71470 VA: 0x180D72E70
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0xD72E40 Offset: 0xD71440 VA: 0x180D72E40 Slot: 11
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0xD73380 Offset: 0xD71980 VA: 0x180D73380
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0xD71490 Offset: 0xD6FA90 VA: 0x180D71490
	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	// RVA: 0xD71010 Offset: 0xD6F610 VA: 0x180D71010
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

}

