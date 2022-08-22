internal struct MonoAssemblyName // TypeDefIndex: 19
{	// Fields
	internal IntPtr name; // 0x0
	internal IntPtr culture; // 0x8
	internal IntPtr hash_value; // 0x10
	internal IntPtr public_key; // 0x18
	[FixedBufferAttribute] // RVA: 0xE6F10 Offset: 0xE6310 VA: 0x1800E6F10
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; // 0x20
	internal uint hash_alg; // 0x34
	internal uint hash_len; // 0x38
	internal uint flags; // 0x3C
	internal ushort major; // 0x40
	internal ushort minor; // 0x42
	internal ushort build; // 0x44
	internal ushort revision; // 0x46
	internal ushort arch; // 0x48

}

public struct MonoAssemblyName.<public_key_token>e__FixedBuffer // TypeDefIndex: 20
{	// Fields
	public byte FixedElementField; // 0x0

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 139
{	// Fields
	private string comment; // 0x10

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string comment) { }

}

internal class MonoLimitationAttribute : MonoTODOAttribute // TypeDefIndex: 140
{	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string comment) { }

}

internal class MonoTypeInfo // TypeDefIndex: 344
{	// Fields
	public string full_name; // 0x10
	public MonoCMethod default_ctor; // 0x18

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

}

internal class MonoAsyncCall // TypeDefIndex: 372
{	// Fields
	private object msg; // 0x10
	private IntPtr cb_method; // 0x18
	private object cb_target; // 0x20
	private object state; // 0x28
	private object res; // 0x30
	private object out_args; // 0x38

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

}

internal static class MonoCustomAttrs // TypeDefIndex: 373
{	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x1678650 Offset: 0x1676C50 VA: 0x181678650
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x16770D0 Offset: 0x16756D0 VA: 0x1816770D0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x1677D00 Offset: 0x1676300 VA: 0x181677D00
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x16781D0 Offset: 0x16767D0 VA: 0x1816781D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x1676E40 Offset: 0x1675440 VA: 0x181676E40
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x16770E0 Offset: 0x16756E0 VA: 0x1816770E0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1677B90 Offset: 0x1676190 VA: 0x181677B90
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x1677020 Offset: 0x1675620 VA: 0x181677020
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x1677030 Offset: 0x1675630 VA: 0x181677030
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x1678380 Offset: 0x1676980 VA: 0x181678380
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1678370 Offset: 0x1676970 VA: 0x181678370
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x1676810 Offset: 0x1674E10 VA: 0x181676810
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x1676640 Offset: 0x1674C40 VA: 0x181676640
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x1676B20 Offset: 0x1675120 VA: 0x181676B20
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x1678890 Offset: 0x1676E90 VA: 0x181678890
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x1678B00 Offset: 0x1677100 VA: 0x181678B00
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x1678C70 Offset: 0x1677270 VA: 0x181678C70
	private static void .cctor() { }

}

private class MonoCustomAttrs.AttributeInfo // TypeDefIndex: 374
{	// Fields
	private AttributeUsageAttribute _usage; // 0x10
	private int _inheritanceLevel; // 0x18

	// Properties
	public AttributeUsageAttribute Usage { get; }
	public int InheritanceLevel { get; }

	// Methods

	// RVA: 0x1670E70 Offset: 0x166F470 VA: 0x181670E70
	public void .ctor(AttributeUsageAttribute usage, int inheritanceLevel) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public AttributeUsageAttribute get_Usage() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_InheritanceLevel() { }

}

internal sealed class MonoListItem // TypeDefIndex: 375
{	// Fields
	private MonoListItem next; // 0x10
	private object data; // 0x18

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

}

internal class MonoAssembly : RuntimeAssembly // TypeDefIndex: 573
{	// Methods

	// RVA: 0x18CD9F0 Offset: 0x18CBFF0 VA: 0x1818CD9F0 Slot: 27
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18CD780 Offset: 0x18CBD80 VA: 0x1818CD780 Slot: 28
	public override Module GetModule(string name) { }

	// RVA: 0x18CD9E0 Offset: 0x18CBFE0 VA: 0x1818CD9E0 Slot: 29
	public override AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18CD8D0 Offset: 0x18CBED0 VA: 0x1818CD8D0 Slot: 30
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C6250 Offset: 0x18C4850 VA: 0x1818C6250
	public void .ctor() { }

}

internal struct MonoEventInfo // TypeDefIndex: 574
{	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38

	// Methods

	// RVA: 0x18CE3F0 Offset: 0x18CC9F0 VA: 0x1818CE3F0
	private static void get_event_info(MonoEvent ev, out MonoEventInfo info) { }

	// RVA: 0x18CE3B0 Offset: 0x18CC9B0 VA: 0x1818CE3B0
	internal static MonoEventInfo GetEventInfo(MonoEvent ev) { }

}

internal sealed class MonoEvent : RuntimeEventInfo // TypeDefIndex: 576
{	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x18CE400 Offset: 0x18CCA00 VA: 0x1818CE400 Slot: 18
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x18CE580 Offset: 0x18CCB80 VA: 0x1818CE580 Slot: 19
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x18CE610 Offset: 0x18CCC10 VA: 0x1818CE610 Slot: 20
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x18CE7A0 Offset: 0x18CCDA0 VA: 0x1818CE7A0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CE800 Offset: 0x18CCE00 VA: 0x1818CE800 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CE7D0 Offset: 0x18CCDD0 VA: 0x1818CE7D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CE720 Offset: 0x18CCD20 VA: 0x1818CE720 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CE6A0 Offset: 0x18CCCA0 VA: 0x1818CE6A0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CE510 Offset: 0x18CCB10 VA: 0x1818CE510 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CE490 Offset: 0x18CCA90 VA: 0x1818CE490 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C6DD0 Offset: 0x18C53D0 VA: 0x1818C6DD0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class MonoField : RtFieldInfo // TypeDefIndex: 579
{	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	private Type ResolveType() { }

	// RVA: 0x18CEF70 Offset: 0x18CD570 VA: 0x1818CEF70 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18CE9D0 Offset: 0x18CCFD0 VA: 0x1818CE9D0
	private Type GetParentType(bool declaring) { }

	// RVA: 0x18CF000 Offset: 0x18CD600 VA: 0x1818CF000 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CEF60 Offset: 0x18CD560 VA: 0x1818CEF60 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CEB90 Offset: 0x18CD190 VA: 0x1818CEB90 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CE950 Offset: 0x18CCF50 VA: 0x1818CE950 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CE8D0 Offset: 0x18CCED0 VA: 0x1818CE8D0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CE9C0 Offset: 0x18CCFC0 VA: 0x1818CE9C0 Slot: 29
	internal override int GetFieldOffset() { }

	// RVA: 0x18CE9F0 Offset: 0x18CCFF0 VA: 0x1818CE9F0
	private object GetValueInternal(object obj) { }

	// RVA: 0x18CEA00 Offset: 0x18CD000 VA: 0x1818CEA00 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18CEF00 Offset: 0x18CD500 VA: 0x1818CEF00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1298DC0 Offset: 0x12973C0 VA: 0x181298DC0
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x18CEC10 Offset: 0x18CD210 VA: 0x1818CEC10 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x18CE9E0 Offset: 0x18CCFE0 VA: 0x1818CE9E0 Slot: 31
	public override object GetRawConstantValue() { }

	// RVA: 0x18C6DD0 Offset: 0x18C53D0 VA: 0x1818C6DD0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x18CE830 Offset: 0x18CCE30 VA: 0x1818CE830
	private void CheckGeneric() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal struct MonoMethodInfo // TypeDefIndex: 580
{	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x18CF120 Offset: 0x18CD720 VA: 0x1818CF120
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x18CF010 Offset: 0x18CD610 VA: 0x1818CF010
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x18CF0B0 Offset: 0x18CD6B0 VA: 0x1818CF0B0
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x18CF050 Offset: 0x18CD650 VA: 0x1818CF050
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x18CF0F0 Offset: 0x18CD6F0 VA: 0x1818CF0F0
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x18CF010 Offset: 0x18CD610 VA: 0x1818CF010
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x18CF020 Offset: 0x18CD620 VA: 0x1818CF020
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x18CF080 Offset: 0x18CD680 VA: 0x1818CF080
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x18CF0E0 Offset: 0x18CD6E0 VA: 0x1818CF0E0
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x18CF0E0 Offset: 0x18CD6E0 VA: 0x1818CF0E0
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

}

internal class MonoMethod : RuntimeMethodInfo // TypeDefIndex: 582
{	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Type ReturnType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x18CFF40 Offset: 0x18CE540 VA: 0x1818CFF40
	internal static string get_name(MethodBase method) { }

	// RVA: 0x18CFF30 Offset: 0x18CE530 VA: 0x1818CFF30
	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	// RVA: 0x18CF460 Offset: 0x18CDA60 VA: 0x1818CF460 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CF470 Offset: 0x18CDA70 VA: 0x1818CF470 Slot: 45
	internal override MethodInfo GetBaseMethod() { }

	// RVA: 0x18CFF00 Offset: 0x18CE500 VA: 0x1818CFF00 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x18CDDA0 Offset: 0x18CC3A0 VA: 0x1818CDDA0 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CF660 Offset: 0x18CDC60 VA: 0x1818CF660 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CDE00 Offset: 0x18CC400 VA: 0x1818CDE00 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CF630 Offset: 0x18CDC30 VA: 0x1818CF630 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18CF8B0 Offset: 0x18CDEB0 VA: 0x1818CF8B0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CF8C0 Offset: 0x18CDEC0 VA: 0x1818CF8C0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CF130 Offset: 0x18CD730 VA: 0x1818CF130
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CE2F0 Offset: 0x18CC8F0 VA: 0x1818CE2F0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CE300 Offset: 0x18CC900 VA: 0x1818CE300 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CE370 Offset: 0x18CC970 VA: 0x1818CE370 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CE3A0 Offset: 0x18CC9A0 VA: 0x1818CE3A0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CFA50 Offset: 0x18CE050 VA: 0x1818CFA50 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CF480 Offset: 0x18CDA80 VA: 0x1818CF480 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CF4F0 Offset: 0x18CDAF0 VA: 0x1818CF4F0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CF620 Offset: 0x18CDC20 VA: 0x1818CF620
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x18CF700 Offset: 0x18CDD00 VA: 0x1818CF700
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18CFAE0 Offset: 0x18CE0E0 VA: 0x1818CFAE0 Slot: 43
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x18CFAD0 Offset: 0x18CE0D0 VA: 0x1818CFAD0
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x18CF570 Offset: 0x18CDB70 VA: 0x1818CF570 Slot: 24
	public override Type[] GetGenericArguments() { }

	// RVA: 0x18CF580 Offset: 0x18CDB80 VA: 0x1818CF580
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x18CF590 Offset: 0x18CDB90 VA: 0x1818CF590 Slot: 42
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18CFEE0 Offset: 0x18CE4E0 VA: 0x1818CFEE0 Slot: 25
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x18CFEF0 Offset: 0x18CE4F0 VA: 0x1818CFEF0 Slot: 27
	public override bool get_IsGenericMethod() { }

	// RVA: 0x18CFE00 Offset: 0x18CE400 VA: 0x1818CFE00 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x18CDD90 Offset: 0x18CC390 VA: 0x1818CDD90 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18C6DD0 Offset: 0x18C53D0 VA: 0x1818C6DD0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	private static int get_core_clr_security_level() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 28
	public override bool get_IsSecurityCritical() { }

}

internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 584
{	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x18CDDA0 Offset: 0x18CC3A0 VA: 0x1818CDDA0 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CDE00 Offset: 0x18CC400 VA: 0x1818CDE00 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CDE00 Offset: 0x18CC400 VA: 0x1818CDE00 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CDDD0 Offset: 0x18CC3D0 VA: 0x1818CDDD0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18CDE10 Offset: 0x18CC410 VA: 0x1818CDE10
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CDF20 Offset: 0x18CC520 VA: 0x1818CDF20 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CDAD0 Offset: 0x18CC0D0 VA: 0x1818CDAD0
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CDE20 Offset: 0x18CC420 VA: 0x1818CDE20
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CDEF0 Offset: 0x18CC4F0 VA: 0x1818CDEF0 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CE2F0 Offset: 0x18CC8F0 VA: 0x1818CE2F0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CE300 Offset: 0x18CC900 VA: 0x1818CE300 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x18CE330 Offset: 0x18CC930 VA: 0x1818CE330 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CE370 Offset: 0x18CC970 VA: 0x1818CE370 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CE3A0 Offset: 0x18CC9A0 VA: 0x1818CE3A0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CE050 Offset: 0x18CC650 VA: 0x1818CE050 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CDD20 Offset: 0x18CC320 VA: 0x1818CDD20 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CDCA0 Offset: 0x18CC2A0 VA: 0x1818CDCA0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CDD90 Offset: 0x18CC390 VA: 0x1818CDD90 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18CE0D0 Offset: 0x18CC6D0 VA: 0x1818CE0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C6DD0 Offset: 0x18C53D0 VA: 0x1818C6DD0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	private static int get_core_clr_security_level() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 28
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x18CE290 Offset: 0x18CC890 VA: 0x1818CE290
	public void .ctor() { }

}

internal class MonoModule : RuntimeModule // TypeDefIndex: 586
{	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 10
	public override Assembly get_Assembly() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 11
	public override string get_ScopeName() { }

	// RVA: 0x18D02C0 Offset: 0x18CE8C0 VA: 0x1818D02C0 Slot: 12
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x8C1040 Offset: 0x8BF640 VA: 0x1808C1040 Slot: 13
	public override bool IsResource() { }

	// RVA: 0x18CFFD0 Offset: 0x18CE5D0 VA: 0x1818CFFD0 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CFF50 Offset: 0x18CE550 VA: 0x1818CFF50 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D01E0 Offset: 0x18CE7E0 VA: 0x1818D01E0 Slot: 16
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D0040 Offset: 0x18CE640 VA: 0x1818D0040 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D0160 Offset: 0x18CE760 VA: 0x1818D0160
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x18D0260 Offset: 0x18CE860 VA: 0x1818D0260
	public void .ctor() { }

}

internal class MonoParameterInfo : RuntimeParameterInfo // TypeDefIndex: 588
{	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x18D0460 Offset: 0x18CEA60 VA: 0x1818D0460
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x18D0530 Offset: 0x18CEB30 VA: 0x1818D0530 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x18D02F0 Offset: 0x18CE8F0 VA: 0x1818D02F0 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D0360 Offset: 0x18CE960 VA: 0x1818D0360 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D03E0 Offset: 0x18CE9E0 VA: 0x1818D03E0 Slot: 16
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

internal struct MonoPropertyInfo // TypeDefIndex: 589
{	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28

	// Methods

	// RVA: 0x18D07B0 Offset: 0x18CEDB0 VA: 0x1818D07B0
	internal static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x18D07A0 Offset: 0x18CEDA0 VA: 0x1818D07A0
	internal static Type[] GetTypeModifiers(MonoProperty prop, bool optional) { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	internal static object get_default_value(MonoProperty prop) { }

}

internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 592
{	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x18D07C0 Offset: 0x18CEDC0 VA: 0x1818D07C0
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x18D1800 Offset: 0x18CFE00 VA: 0x1818D1800 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18D1840 Offset: 0x18CFE40 VA: 0x1818D1840 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18D1890 Offset: 0x18CFE90 VA: 0x1818D1890 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18D1960 Offset: 0x18CFF60 VA: 0x1818D1960 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18D1A40 Offset: 0x18D0040 VA: 0x1818D1A40 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18D18E0 Offset: 0x18CFEE0 VA: 0x1818D18E0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18D1920 Offset: 0x18CFF20 VA: 0x1818D1920 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D0B80 Offset: 0x18CF180 VA: 0x1818D0B80 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18D0E50 Offset: 0x18CF450 VA: 0x1818D0E50 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18D0F00 Offset: 0x18CF500 VA: 0x1818D0F00 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18D12C0 Offset: 0x18CF8C0 VA: 0x1818D12C0 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30 Slot: 33
	public override object GetConstantValue() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30 Slot: 34
	public override object GetRawConstantValue() { }

	// RVA: 0x18D1550 Offset: 0x18CFB50 VA: 0x1818D1550 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D0DF0 Offset: 0x18CF3F0 VA: 0x1818D0DF0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D0D80 Offset: 0x18CF380 VA: 0x1818D0D80 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6760 Offset: 0xED4D60 VA: 0x180ED6760
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED67F0 Offset: 0xED4DF0 VA: 0x180ED67F0
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x18D0800 Offset: 0x18CEE00 VA: 0x1818D0800
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x18D1370 Offset: 0x18CF970 VA: 0x1818D1370 Slot: 27
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x18D13B0 Offset: 0x18CF9B0 VA: 0x1818D13B0 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D15C0 Offset: 0x18CFBC0 VA: 0x1818D15C0 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D11E0 Offset: 0x18CF7E0 VA: 0x1818D11E0 Slot: 31
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18D1250 Offset: 0x18CF850 VA: 0x1818D1250 Slot: 32
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18C6DD0 Offset: 0x18C53D0 VA: 0x1818C6DD0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class MonoProperty.GetterAdapter : MulticastDelegate // TypeDefIndex: 593
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x133B5E0 Offset: 0x1339BE0 VA: 0x18133B5E0 Slot: 12
	public virtual object Invoke(object _this) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(object _this, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

private sealed class MonoProperty.Getter<T, R> : MulticastDelegate // TypeDefIndex: 594
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-MonoProperty.Getter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189F860 Offset: 0x189DE60 VA: 0x18189F860
	|-MonoProperty.Getter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T _this, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-MonoProperty.Getter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-MonoProperty.Getter<object, object>.EndInvoke
	*/

}

private sealed class MonoProperty.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 595
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-MonoProperty.StaticGetter<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50960 Offset: 0xD4EF60 VA: 0x180D50960
	|-MonoProperty.StaticGetter<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190
	|-MonoProperty.StaticGetter<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-MonoProperty.StaticGetter<object>.EndInvoke
	*/

}

internal enum MonoFileType // TypeDefIndex: 674
{	// Fields
	public int value__; // 0x0
	public const MonoFileType Unknown = 0;
	public const MonoFileType Disk = 1;
	public const MonoFileType Char = 2;
	public const MonoFileType Pipe = 3;
	public const MonoFileType Remote = 32768;

}

internal static class MonoIO // TypeDefIndex: 675
{	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x1627D50 Offset: 0x1626350 VA: 0x181627D50
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x1627690 Offset: 0x1625C90 VA: 0x181627690
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x1627160 Offset: 0x1625760 VA: 0x181627160
	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x1627170 Offset: 0x1625770 VA: 0x181627170
	public static bool CreateDirectory(string path, out MonoIOError error) { }

	// RVA: 0x16284D0 Offset: 0x1626AD0 VA: 0x1816284D0
	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x1628460 Offset: 0x1626A60 VA: 0x181628460
	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1627680 Offset: 0x1625C80 VA: 0x181627680
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x16281A0 Offset: 0x16267A0 VA: 0x1816281A0
	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	// RVA: 0x16281B0 Offset: 0x16267B0 VA: 0x1816281B0
	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	// RVA: 0x16270A0 Offset: 0x16256A0 VA: 0x1816270A0
	private static bool CopyFile(char* path, char* dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x16270B0 Offset: 0x16256B0 VA: 0x1816270B0
	public static bool CopyFile(string path, string dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x16271E0 Offset: 0x16257E0 VA: 0x1816271E0
	private static bool DeleteFile(char* path, out MonoIOError error) { }

	// RVA: 0x16271F0 Offset: 0x16257F0 VA: 0x1816271F0
	public static bool DeleteFile(string path, out MonoIOError error) { }

	// RVA: 0x1627E30 Offset: 0x1626430 VA: 0x181627E30
	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	// RVA: 0x1627E40 Offset: 0x1626440 VA: 0x181627E40
	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	// RVA: 0x1628060 Offset: 0x1626660 VA: 0x181628060
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1627F40 Offset: 0x1626540 VA: 0x181627F40
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1627660 Offset: 0x1625C60 VA: 0x181627660
	private static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x16275D0 Offset: 0x1625BD0 VA: 0x1816275D0
	public static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1627670 Offset: 0x1625C70 VA: 0x181627670
	public static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x16275C0 Offset: 0x1625BC0 VA: 0x1816275C0
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x1627500 Offset: 0x1625B00 VA: 0x181627500
	public static bool Exists(string path, out MonoIOError error) { }

	// RVA: 0x1627350 Offset: 0x1625950 VA: 0x181627350
	public static bool ExistsFile(string path, out MonoIOError error) { }

	// RVA: 0x1627270 Offset: 0x1625870 VA: 0x181627270
	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1627420 Offset: 0x1625A20 VA: 0x181627420
	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	// RVA: 0x1627EB0 Offset: 0x16264B0 VA: 0x181627EB0
	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x1627EC0 Offset: 0x16264C0 VA: 0x181627EC0
	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x1628250 Offset: 0x1626850 VA: 0x181628250
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1628260 Offset: 0x1626860 VA: 0x181628260
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1627090 Offset: 0x1625690 VA: 0x181627090
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1628440 Offset: 0x1626A40 VA: 0x181628440
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x16282F0 Offset: 0x16268F0 VA: 0x1816282F0
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1628CA0 Offset: 0x16272A0 VA: 0x181628CA0
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1628CB0 Offset: 0x16272B0 VA: 0x181628CB0
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x16284E0 Offset: 0x1626AE0 VA: 0x1816284E0
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x16284F0 Offset: 0x1626AF0 VA: 0x1816284F0
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1628070 Offset: 0x1626670 VA: 0x181628070
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1628080 Offset: 0x1626680 VA: 0x181628080
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1628C90 Offset: 0x1627290 VA: 0x181628C90
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x1628B60 Offset: 0x1627160 VA: 0x181628B60
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x16288C0 Offset: 0x1626EC0 VA: 0x1816288C0
	private static bool SetFileTime(IntPtr handle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x16288D0 Offset: 0x1626ED0 VA: 0x1816288D0
	public static bool SetFileTime(SafeHandle safeHandle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x1628630 Offset: 0x1626C30 VA: 0x181628630
	public static bool SetCreationTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1628A20 Offset: 0x1627020 VA: 0x181628A20
	public static bool SetLastAccessTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1628AC0 Offset: 0x16270C0 VA: 0x181628AC0
	public static bool SetLastWriteTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x16286D0 Offset: 0x1626CD0 VA: 0x1816286D0
	public static bool SetFileTime(string path, int type, long creation_time, long last_access_time, long last_write_time, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1628EA0 Offset: 0x16274A0 VA: 0x181628EA0
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x1628E90 Offset: 0x1627490 VA: 0x181628E90
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x1628E80 Offset: 0x1627480 VA: 0x181628E80
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x1627260 Offset: 0x1625860 VA: 0x181627260
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	// RVA: 0x1628ED0 Offset: 0x16274D0 VA: 0x181628ED0
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x1628EB0 Offset: 0x16274B0 VA: 0x181628EB0
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x1628E70 Offset: 0x1627470 VA: 0x181628E70
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x1628EC0 Offset: 0x16274C0 VA: 0x181628EC0
	public static char get_PathSeparator() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	private static void DumpHandles() { }

	// RVA: 0x1628450 Offset: 0x1626A50 VA: 0x181628450
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x1628E00 Offset: 0x1627400 VA: 0x181628E00
	private static void .cctor() { }

}

internal enum MonoIOError // TypeDefIndex: 676
{	// Fields
	public int value__; // 0x0
	public const MonoIOError ERROR_SUCCESS = 0;
	public const MonoIOError ERROR_FILE_NOT_FOUND = 2;
	public const MonoIOError ERROR_PATH_NOT_FOUND = 3;
	public const MonoIOError ERROR_TOO_MANY_OPEN_FILES = 4;
	public const MonoIOError ERROR_ACCESS_DENIED = 5;
	public const MonoIOError ERROR_INVALID_HANDLE = 6;
	public const MonoIOError ERROR_INVALID_DRIVE = 15;
	public const MonoIOError ERROR_NOT_SAME_DEVICE = 17;
	public const MonoIOError ERROR_NO_MORE_FILES = 18;
	public const MonoIOError ERROR_NOT_READY = 21;
	public const MonoIOError ERROR_WRITE_FAULT = 29;
	public const MonoIOError ERROR_READ_FAULT = 30;
	public const MonoIOError ERROR_GEN_FAILURE = 31;
	public const MonoIOError ERROR_SHARING_VIOLATION = 32;
	public const MonoIOError ERROR_LOCK_VIOLATION = 33;
	public const MonoIOError ERROR_HANDLE_DISK_FULL = 39;
	public const MonoIOError ERROR_FILE_EXISTS = 80;
	public const MonoIOError ERROR_CANNOT_MAKE = 82;
	public const MonoIOError ERROR_INVALID_PARAMETER = 87;
	public const MonoIOError ERROR_BROKEN_PIPE = 109;
	public const MonoIOError ERROR_INVALID_NAME = 123;
	public const MonoIOError ERROR_DIR_NOT_EMPTY = 145;
	public const MonoIOError ERROR_ALREADY_EXISTS = 183;
	public const MonoIOError ERROR_FILENAME_EXCED_RANGE = 206;
	public const MonoIOError ERROR_DIRECTORY = 267;
	public const MonoIOError ERROR_ENCRYPTION_FAILED = 6000;

}

internal struct MonoIOStat // TypeDefIndex: 677
{	// Fields
	public FileAttributes fileAttributes; // 0x0
	public long Length; // 0x8
	public long CreationTime; // 0x10
	public long LastAccessTime; // 0x18
	public long LastWriteTime; // 0x20

}

internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 1252
{	// Fields
	private MonoMethod method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Type[] methodSignature; // 0x68
	private Identity identity; // 0x70
	internal static string CallContextKey; // 0x0
	internal static string UriKey; // 0x8

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x1480880 Offset: 0x147EE80 VA: 0x181480880
	internal void InitMessage(MonoMethod method, object[] out_args) { }

	// RVA: 0x1480CC0 Offset: 0x147F2C0 VA: 0x181480CC0
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x1480DC0 Offset: 0x147F3C0 VA: 0x181480DC0
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x14807C0 Offset: 0x147EDC0 VA: 0x1814807C0
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x1480F40 Offset: 0x147F540 VA: 0x181480F40
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x1481580 Offset: 0x147FB80 VA: 0x181481580 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x1481060 Offset: 0x147F660 VA: 0x181481060 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1481190 Offset: 0x147F790 VA: 0x181481190 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x1481210 Offset: 0x147F810 VA: 0x181481210 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1481600 Offset: 0x147FC00 VA: 0x181481600 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 19
	public string get_Uri() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x1480780 Offset: 0x147ED80 VA: 0x181480780 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x1481370 Offset: 0x147F970 VA: 0x181481370 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x14813E0 Offset: 0x147F9E0 VA: 0x1814813E0 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x14810A0 Offset: 0x147F6A0 VA: 0x1814810A0
	internal CallType get_CallType() { }

	// RVA: 0x1480BD0 Offset: 0x147F1D0 VA: 0x181480BD0
	public bool NeedsOutProcessing(out int outCount) { }

	// RVA: 0x1480C50 Offset: 0x147F250 VA: 0x181480C50
	private static void .cctor() { }

}

public class MonoTlsConnectionInfo // TypeDefIndex: 1743
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x13A9500 Offset: 0x13A7B00 VA: 0x1813A9500
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1AB9410 Offset: 0x1AB7A10 VA: 0x181AB9410
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_PeerDomainName(string value) { }

	// RVA: 0x1AB9390 Offset: 0x1AB7990 VA: 0x181AB9390 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum MonoSslPolicyErrors // TypeDefIndex: 1744
{	// Fields
	public int value__; // 0x0
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;

}

public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 1745
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFFB630 Offset: 0xFF9C30 VA: 0x180FFB630 Slot: 12
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x1AB92F0 Offset: 0x1AB78F0 VA: 0x181AB92F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 1746
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF9390 Offset: 0xFF7990 VA: 0x180FF9390 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xFF9340 Offset: 0xFF7940 VA: 0x180FF9340 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

public abstract class MonoTlsProvider // TypeDefIndex: 1747
{	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown();

}

public static class MonoTlsProviderFactory // TypeDefIndex: 1748
{	// Methods

	// RVA: 0x1AB9420 Offset: 0x1AB7A20 VA: 0x181AB9420
	public static MonoTlsProvider GetProvider() { }

}

public sealed class MonoTlsSettings // TypeDefIndex: 1749
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x58
	private bool cloned; // 0x60
	private bool checkCertName; // 0x61
	private bool checkCertRevocationStatus; // 0x62
	private Nullable<bool> useServicePointManagerCallback; // 0x63
	private bool skipSystemValidators; // 0x65
	private bool callbackNeedsChain; // 0x66
	private ICertificateValidator certificateValidator; // 0x68
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[ObsoleteAttribute] // RVA: 0x7F2D0 Offset: 0x7E6D0 VA: 0x18007F2D0
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x1AB9870 Offset: 0x1AB7E70 VA: 0x181AB9870
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x1AB9890 Offset: 0x1AB7E90 VA: 0x181AB9890
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x1086590 Offset: 0x1084B90 VA: 0x181086590
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD67340 Offset: 0xD65940 VA: 0x180D67340
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10965B0 Offset: 0x1094BB0 VA: 0x1810965B0
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public object get_UserSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_UserSettings(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	internal bool get_SendCloseNotify() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8FE70 Offset: 0xF8E470 VA: 0x180F8FE70
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1AB9880 Offset: 0x1AB7E80 VA: 0x181AB9880
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x1AB9670 Offset: 0x1AB7C70 VA: 0x181AB9670
	public void .ctor() { }

	// RVA: 0x1AB97E0 Offset: 0x1AB7DE0 VA: 0x181AB97E0
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x1AB95A0 Offset: 0x1AB7BA0 VA: 0x181AB95A0
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public ICertificateValidator get_CertificateValidator() { }

	[ObsoleteAttribute] // RVA: 0x7F2D0 Offset: 0x7E6D0 VA: 0x18007F2D0
	// RVA: 0x1AB94A0 Offset: 0x1AB7AA0 VA: 0x181AB94A0
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1AB9540 Offset: 0x1AB7B40 VA: 0x181AB9540
	public MonoTlsSettings Clone() { }

	// RVA: 0x1AB9680 Offset: 0x1AB7C80 VA: 0x181AB9680
	private void .ctor(MonoTlsSettings other) { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 1810
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 2454
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor(Type t) { }

}

internal static class MonoTlsProviderFactory // TypeDefIndex: 2552
{	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MonoTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MonoTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48
	internal static readonly Guid LegacyId; // 0x58

	// Methods

	// RVA: 0x1219570 Offset: 0x1217B70 VA: 0x181219570
	internal static MonoTlsProvider GetProviderInternal() { }

	// RVA: 0x1219740 Offset: 0x1217D40 VA: 0x181219740
	internal static void InitializeInternal() { }

	// RVA: 0x1219F40 Offset: 0x1218540 VA: 0x181219F40
	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x1219AF0 Offset: 0x12180F0 VA: 0x181219AF0
	private static void InitializeProviderRegistration() { }

	// RVA: 0x12194F0 Offset: 0x1217AF0 VA: 0x1812194F0
	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x12196B0 Offset: 0x1217CB0 VA: 0x1812196B0
	internal static MonoTlsProvider GetProvider() { }

	// RVA: 0x121A440 Offset: 0x1218A40 VA: 0x18121A440
	private static void .cctor() { }

}

internal class MonoTlsStream // TypeDefIndex: 2553
{	// Fields
	private readonly MonoTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private IMonoSslStream sslStream; // 0x30
	private WebExceptionStatus status; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CertificateValidationFailed>k__BackingField; // 0x3C

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal HttpWebRequest get_Request() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC659E0 Offset: 0xC63FE0 VA: 0x180C659E0
	internal bool get_CertificateValidationFailed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72CA0 Offset: 0xE712A0 VA: 0x180E72CA0
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x121AAE0 Offset: 0x12190E0 VA: 0x18121AAE0
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0x121A570 Offset: 0x1218B70 VA: 0x18121A570
	internal Stream CreateStream(byte[] buffer) { }

}

internal class MonoChunkStream // TypeDefIndex: 3014
{	// Fields
	internal WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkStream.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x1347910 Offset: 0x1345F10 VA: 0x181347910
	public void .ctor(byte[] buffer, int offset, int size, WebHeaderCollection headers) { }

	// RVA: 0x1347860 Offset: 0x1345E60 VA: 0x181347860
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1347700 Offset: 0x1345D00 VA: 0x181347700
	public void ResetBuffer() { }

	// RVA: 0x13477B0 Offset: 0x1345DB0 VA: 0x1813477B0
	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	// RVA: 0x13476A0 Offset: 0x1345CA0 VA: 0x1813476A0
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1347130 Offset: 0x1345730 VA: 0x181347130
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1347830 Offset: 0x1345E30 VA: 0x181347830
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1346C50 Offset: 0x1345250 VA: 0x181346C50
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1347B20 Offset: 0x1346120 VA: 0x181347B20
	public bool get_WantMore() { }

	// RVA: 0x1347A10 Offset: 0x1346010 VA: 0x181347A10
	public bool get_DataAvailable() { }

	// RVA: 0x1347A00 Offset: 0x1346000 VA: 0x181347A00
	public int get_ChunkLeft() { }

	// RVA: 0x1346F20 Offset: 0x1345520 VA: 0x181346F20
	private MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1346990 Offset: 0x1344F90 VA: 0x181346990
	private MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x13476B0 Offset: 0x1345CB0 VA: 0x1813476B0
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1347050 Offset: 0x1345650 VA: 0x181347050
	private MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x13473E0 Offset: 0x13459E0 VA: 0x1813473E0
	private MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1347740 Offset: 0x1345D40 VA: 0x181347740
	private static void ThrowProtocolViolation(string message) { }

}

private enum MonoChunkStream.State // TypeDefIndex: 3015
{	// Fields
	public int value__; // 0x0
	public const MonoChunkStream.State None = 0;
	public const MonoChunkStream.State PartialSize = 1;
	public const MonoChunkStream.State Body = 2;
	public const MonoChunkStream.State BodyFinished = 3;
	public const MonoChunkStream.State Trailer = 4;

}

private class MonoChunkStream.Chunk // TypeDefIndex: 3016
{	// Fields
	public byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(byte[] chunk) { }

	// RVA: 0x132FA30 Offset: 0x132E030 VA: 0x18132FA30
	public int Read(byte[] buffer, int offset, int size) { }

}

public class MonoBehaviour : Behaviour // TypeDefIndex: 3518
{	// Properties
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x18F7010 Offset: 0x18F5610 VA: 0x1818F7010
	public bool IsInvoking() { }

	// RVA: 0x18F6F90 Offset: 0x18F5590 VA: 0x1818F6F90
	public void CancelInvoke() { }

	// RVA: 0x18F71A0 Offset: 0x18F57A0 VA: 0x1818F71A0
	public void Invoke(string methodName, float time) { }

	// RVA: 0x18F70C0 Offset: 0x18F56C0 VA: 0x1818F70C0
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x18F6F40 Offset: 0x18F5540 VA: 0x1818F6F40
	public void CancelInvoke(string methodName) { }

	// RVA: 0x18F7200 Offset: 0x18F5800 VA: 0x1818F7200
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F7430 Offset: 0x18F5A30 VA: 0x1818F7430
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x18F7530 Offset: 0x18F5B30 VA: 0x1818F7530
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x18F7340 Offset: 0x18F5940 VA: 0x1818F7340
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[ObsoleteAttribute] // RVA: 0xC1AF0 Offset: 0xC0EF0 VA: 0x1800C1AF0
	// RVA: 0x18F7340 Offset: 0x18F5940 VA: 0x1818F7340
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x18F7720 Offset: 0x18F5D20 VA: 0x1818F7720
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x18F7860 Offset: 0x18F5E60 VA: 0x1818F7860
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x18F7810 Offset: 0x18F5E10 VA: 0x1818F7810
	public void StopCoroutine(string methodName) { }

	// RVA: 0x18F7640 Offset: 0x18F5C40 VA: 0x1818F7640
	public void StopAllCoroutines() { }

	// RVA: 0x18F7960 Offset: 0x18F5F60 VA: 0x1818F7960
	public bool get_useGUILayout() { }

	// RVA: 0x18F7A00 Offset: 0x18F6000 VA: 0x1818F7A00
	public void set_useGUILayout(bool value) { }

	// RVA: 0x18F79A0 Offset: 0x18F5FA0 VA: 0x1818F79A0
	public static void print(object message) { }

	[FreeFunctionAttribute] // RVA: 0xC1B80 Offset: 0xC0F80 VA: 0x1800C1B80
	// RVA: 0x18F6F90 Offset: 0x18F5590 VA: 0x1818F6F90
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0xC1C90 Offset: 0xC1090 VA: 0x1800C1C90
	// RVA: 0x18F7010 Offset: 0x18F5610 VA: 0x1818F7010
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F7050 Offset: 0x18F5650 VA: 0x1818F7050
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F6F40 Offset: 0x18F5540 VA: 0x1818F6F40
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F7200 Offset: 0x18F5800 VA: 0x1818F7200
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F7250 Offset: 0x18F5850 VA: 0x1818F7250
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x18F72E0 Offset: 0x18F58E0 VA: 0x1818F72E0
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x18F7290 Offset: 0x18F5890 VA: 0x1818F7290
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x18F76D0 Offset: 0x18F5CD0 VA: 0x1818F76D0
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x18F7680 Offset: 0x18F5C80 VA: 0x1818F7680
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x18F6FD0 Offset: 0x18F55D0 VA: 0x1818F6FD0
	internal string GetScriptClassName() { }

	// RVA: 0x18F7950 Offset: 0x18F5F50 VA: 0x1818F7950
	public void .ctor() { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 3974
{
// Namespace: System
[AttributeUsageAttribute] // RVA: 0x80FF0 Offset: 0x803F0 VA: 0x180080FF0
internal class MonoTODOAttribute : Attribute // TypeDefIndex: 3974
	// Fields
	private string comment; // 0x10

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string comment) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 5256
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

internal static class Mono // TypeDefIndex: 6227
{	// Methods

	// RVA: 0x14B5A90 Offset: 0x14B4090 VA: 0x1814B5A90
	internal static void FixHttpsValidation() { }

}

private sealed class Mono.<>c // TypeDefIndex: 6228
{	// Fields
	public static readonly Mono.<>c <>9; // 0x0
	public static RemoteCertificateValidationCallback <>9__0_0; // 0x8

	// Methods

	// RVA: 0x14BD040 Offset: 0x14BB640 VA: 0x1814BD040
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	internal bool <FixHttpsValidation>b__0_0(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 7139
{
// Namespace: EasyAntiCheat
internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 7139
	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public abstract class MonoEncoding : Encoding // TypeDefIndex: 7373
{	// Fields
	private readonly int win_code_page; // 0x38

	// Properties
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x22AD410 Offset: 0x22ABA10 VA: 0x1822AD410
	public void .ctor(int codePage) { }

	// RVA: 0x22AD3E0 Offset: 0x22AB9E0 VA: 0x1822AD3E0
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: 0x22AD430 Offset: 0x22ABA30 VA: 0x1822AD430 Slot: 11
	public override int get_WindowsCodePage() { }

	// RVA: 0x22AD150 Offset: 0x22AB750 VA: 0x1822AD150
	public void HandleFallback(ref EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

	// RVA: 0x22ACA90 Offset: 0x22AB090 VA: 0x1822ACA90 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22ACEB0 Offset: 0x22AB4B0 VA: 0x1822ACEB0 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22ACC20 Offset: 0x22AB220 VA: 0x1822ACC20 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22ACC00 Offset: 0x22AB200 VA: 0x1822ACC00 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x22AD130 Offset: 0x22AB730 VA: 0x1822AD130 Slot: 28
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 46
	public abstract int GetByteCountImpl(char* chars, int charCount);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);

}

public abstract class MonoEncoder : Encoder // TypeDefIndex: 7374
{	// Fields
	private MonoEncoding encoding; // 0x20

	// Methods

	// RVA: 0x15C0D00 Offset: 0x15BF300 VA: 0x1815C0D00
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x22AC5D0 Offset: 0x22AABD0 VA: 0x1822AC5D0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool refresh) { }

	// RVA: 0x22AC750 Offset: 0x22AAD50 VA: 0x1822AC750 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);

	// RVA: 0x22AC9D0 Offset: 0x22AAFD0 VA: 0x1822AC9D0 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x22AC9F0 Offset: 0x22AAFF0 VA: 0x1822AC9F0
	public void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

}

