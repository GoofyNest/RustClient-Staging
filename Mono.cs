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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string comment) { }

}

internal class MonoLimitationAttribute : MonoTODOAttribute // TypeDefIndex: 140
{	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
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

	// RVA: 0x1678910 Offset: 0x1676F10 VA: 0x181678910
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x1677390 Offset: 0x1675990 VA: 0x181677390
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x1677FC0 Offset: 0x16765C0 VA: 0x181677FC0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x1678490 Offset: 0x1676A90 VA: 0x181678490
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x1677100 Offset: 0x1675700 VA: 0x181677100
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x16773A0 Offset: 0x16759A0 VA: 0x1816773A0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1677E50 Offset: 0x1676450 VA: 0x181677E50
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x16772E0 Offset: 0x16758E0 VA: 0x1816772E0
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x16772F0 Offset: 0x16758F0 VA: 0x1816772F0
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x1678640 Offset: 0x1676C40 VA: 0x181678640
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1678630 Offset: 0x1676C30 VA: 0x181678630
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x1676AD0 Offset: 0x16750D0 VA: 0x181676AD0
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x1676900 Offset: 0x1674F00 VA: 0x181676900
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x1676DE0 Offset: 0x16753E0 VA: 0x181676DE0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x1678B50 Offset: 0x1677150 VA: 0x181678B50
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x1678DC0 Offset: 0x16773C0 VA: 0x181678DC0
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x1678F30 Offset: 0x1677530 VA: 0x181678F30
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

	// RVA: 0x1671130 Offset: 0x166F730 VA: 0x181671130
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

	// RVA: 0x18CDCB0 Offset: 0x18CC2B0 VA: 0x1818CDCB0 Slot: 27
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x18CDA40 Offset: 0x18CC040 VA: 0x1818CDA40 Slot: 28
	public override Module GetModule(string name) { }

	// RVA: 0x18CDCA0 Offset: 0x18CC2A0 VA: 0x1818CDCA0 Slot: 29
	public override AssemblyName[] GetReferencedAssemblies() { }

	// RVA: 0x18CDB90 Offset: 0x18CC190 VA: 0x1818CDB90 Slot: 30
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x18C6510 Offset: 0x18C4B10 VA: 0x1818C6510
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

	// RVA: 0x18CE6B0 Offset: 0x18CCCB0 VA: 0x1818CE6B0
	private static void get_event_info(MonoEvent ev, out MonoEventInfo info) { }

	// RVA: 0x18CE670 Offset: 0x18CCC70 VA: 0x1818CE670
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

	// RVA: 0x18CE6C0 Offset: 0x18CCCC0 VA: 0x1818CE6C0 Slot: 18
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x18CE840 Offset: 0x18CCE40 VA: 0x1818CE840 Slot: 19
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x18CE8D0 Offset: 0x18CCED0 VA: 0x1818CE8D0 Slot: 20
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x18CEA60 Offset: 0x18CD060 VA: 0x1818CEA60 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CEAC0 Offset: 0x18CD0C0 VA: 0x1818CEAC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CEA90 Offset: 0x18CD090 VA: 0x1818CEA90 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CE9E0 Offset: 0x18CCFE0 VA: 0x1818CE9E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CE960 Offset: 0x18CCF60 VA: 0x1818CE960 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CE7D0 Offset: 0x18CCDD0 VA: 0x1818CE7D0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CE750 Offset: 0x18CCD50 VA: 0x1818CE750 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C7090 Offset: 0x18C5690 VA: 0x1818C7090 Slot: 14
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

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	private Type ResolveType() { }

	// RVA: 0x18CF230 Offset: 0x18CD830 VA: 0x1818CF230 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18CEC90 Offset: 0x18CD290 VA: 0x1818CEC90
	private Type GetParentType(bool declaring) { }

	// RVA: 0x18CF2C0 Offset: 0x18CD8C0 VA: 0x1818CF2C0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CF220 Offset: 0x18CD820 VA: 0x1818CF220 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CEE50 Offset: 0x18CD450 VA: 0x1818CEE50 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CEC10 Offset: 0x18CD210 VA: 0x1818CEC10 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CEB90 Offset: 0x18CD190 VA: 0x1818CEB90 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CEC80 Offset: 0x18CD280 VA: 0x1818CEC80 Slot: 29
	internal override int GetFieldOffset() { }

	// RVA: 0x18CECB0 Offset: 0x18CD2B0 VA: 0x1818CECB0
	private object GetValueInternal(object obj) { }

	// RVA: 0x18CECC0 Offset: 0x18CD2C0 VA: 0x1818CECC0 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18CF1C0 Offset: 0x18CD7C0 VA: 0x1818CF1C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1299080 Offset: 0x1297680 VA: 0x181299080
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x18CEED0 Offset: 0x18CD4D0 VA: 0x1818CEED0 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x18CECA0 Offset: 0x18CD2A0 VA: 0x1818CECA0 Slot: 31
	public override object GetRawConstantValue() { }

	// RVA: 0x18C7090 Offset: 0x18C5690 VA: 0x1818C7090 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x18CEAF0 Offset: 0x18CD0F0 VA: 0x1818CEAF0
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

	// RVA: 0x18CF3E0 Offset: 0x18CD9E0 VA: 0x1818CF3E0
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x18CF2D0 Offset: 0x18CD8D0 VA: 0x1818CF2D0
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x18CF370 Offset: 0x18CD970 VA: 0x1818CF370
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x18CF310 Offset: 0x18CD910 VA: 0x1818CF310
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x18CF3B0 Offset: 0x18CD9B0 VA: 0x1818CF3B0
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x18CF2D0 Offset: 0x18CD8D0 VA: 0x1818CF2D0
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x18CF2E0 Offset: 0x18CD8E0 VA: 0x1818CF2E0
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x18CF340 Offset: 0x18CD940 VA: 0x1818CF340
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x18CF3A0 Offset: 0x18CD9A0 VA: 0x1818CF3A0
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x18CF3A0 Offset: 0x18CD9A0 VA: 0x1818CF3A0
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

	// RVA: 0x18D0200 Offset: 0x18CE800 VA: 0x1818D0200
	internal static string get_name(MethodBase method) { }

	// RVA: 0x18D01F0 Offset: 0x18CE7F0 VA: 0x1818D01F0
	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	// RVA: 0x18CF720 Offset: 0x18CDD20 VA: 0x1818CF720 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CF730 Offset: 0x18CDD30 VA: 0x1818CF730 Slot: 45
	internal override MethodInfo GetBaseMethod() { }

	// RVA: 0x18D01C0 Offset: 0x18CE7C0 VA: 0x1818D01C0 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x18CE060 Offset: 0x18CC660 VA: 0x1818CE060 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CF920 Offset: 0x18CDF20 VA: 0x1818CF920 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CE0C0 Offset: 0x18CC6C0 VA: 0x1818CE0C0 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CF8F0 Offset: 0x18CDEF0 VA: 0x1818CF8F0 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18CFB70 Offset: 0x18CE170 VA: 0x1818CFB70
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CFB80 Offset: 0x18CE180 VA: 0x1818CFB80 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CF3F0 Offset: 0x18CD9F0 VA: 0x1818CF3F0
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CE5B0 Offset: 0x18CCBB0 VA: 0x1818CE5B0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CE5C0 Offset: 0x18CCBC0 VA: 0x1818CE5C0 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CE630 Offset: 0x18CCC30 VA: 0x1818CE630 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CE660 Offset: 0x18CCC60 VA: 0x1818CE660 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CFD10 Offset: 0x18CE310 VA: 0x1818CFD10 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CF740 Offset: 0x18CDD40 VA: 0x1818CF740 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CF7B0 Offset: 0x18CDDB0 VA: 0x1818CF7B0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CF8E0 Offset: 0x18CDEE0 VA: 0x1818CF8E0
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x18CF9C0 Offset: 0x18CDFC0 VA: 0x1818CF9C0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x18CFDA0 Offset: 0x18CE3A0 VA: 0x1818CFDA0 Slot: 43
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x18CFD90 Offset: 0x18CE390 VA: 0x1818CFD90
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x18CF830 Offset: 0x18CDE30 VA: 0x1818CF830 Slot: 24
	public override Type[] GetGenericArguments() { }

	// RVA: 0x18CF840 Offset: 0x18CDE40 VA: 0x1818CF840
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x18CF850 Offset: 0x18CDE50 VA: 0x1818CF850 Slot: 42
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x18D01A0 Offset: 0x18CE7A0 VA: 0x1818D01A0 Slot: 25
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x18D01B0 Offset: 0x18CE7B0 VA: 0x1818D01B0 Slot: 27
	public override bool get_IsGenericMethod() { }

	// RVA: 0x18D00C0 Offset: 0x18CE6C0 VA: 0x1818D00C0 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x18CE050 Offset: 0x18CC650 VA: 0x1818CE050 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18C7090 Offset: 0x18C5690 VA: 0x1818C7090 Slot: 14
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

	// RVA: 0x18CE060 Offset: 0x18CC660 VA: 0x1818CE060 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CE0C0 Offset: 0x18CC6C0 VA: 0x1818CE0C0 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CE0C0 Offset: 0x18CC6C0 VA: 0x1818CE0C0 Slot: 38
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x18CE090 Offset: 0x18CC690 VA: 0x1818CE090 Slot: 39
	internal override int GetParametersCount() { }

	// RVA: 0x18CE0D0 Offset: 0x18CC6D0 VA: 0x1818CE0D0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CE1E0 Offset: 0x18CC7E0 VA: 0x1818CE1E0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CDD90 Offset: 0x18CC390 VA: 0x1818CDD90
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CE0E0 Offset: 0x18CC6E0 VA: 0x1818CE0E0
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x18CE1B0 Offset: 0x18CC7B0 VA: 0x1818CE1B0 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CE5B0 Offset: 0x18CCBB0 VA: 0x1818CE5B0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CE5C0 Offset: 0x18CCBC0 VA: 0x1818CE5C0 Slot: 23
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x18CE5F0 Offset: 0x18CCBF0 VA: 0x1818CE5F0 Slot: 26
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CE630 Offset: 0x18CCC30 VA: 0x1818CE630 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CE660 Offset: 0x18CCC60 VA: 0x1818CE660 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CE310 Offset: 0x18CC910 VA: 0x1818CE310 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CDFE0 Offset: 0x18CC5E0 VA: 0x1818CDFE0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CDF60 Offset: 0x18CC560 VA: 0x1818CDF60 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CE050 Offset: 0x18CC650 VA: 0x1818CE050 Slot: 35
	public override MethodBody GetMethodBody() { }

	// RVA: 0x18CE390 Offset: 0x18CC990 VA: 0x1818CE390 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C7090 Offset: 0x18C5690 VA: 0x1818C7090 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	private static int get_core_clr_security_level() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 28
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x18CE550 Offset: 0x18CCB50 VA: 0x1818CE550
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

	// RVA: 0x18D0580 Offset: 0x18CEB80 VA: 0x1818D0580 Slot: 12
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x8C1150 Offset: 0x8BF750 VA: 0x1808C1150 Slot: 13
	public override bool IsResource() { }

	// RVA: 0x18D0290 Offset: 0x18CE890 VA: 0x1818D0290 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D0210 Offset: 0x18CE810 VA: 0x1818D0210 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D04A0 Offset: 0x18CEAA0 VA: 0x1818D04A0 Slot: 16
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D0300 Offset: 0x18CE900 VA: 0x1818D0300 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D0420 Offset: 0x18CEA20 VA: 0x1818D0420
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x18D0520 Offset: 0x18CEB20 VA: 0x1818D0520
	public void .ctor() { }

}

internal class MonoParameterInfo : RuntimeParameterInfo // TypeDefIndex: 588
{	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x18D0720 Offset: 0x18CED20 VA: 0x1818D0720
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x18D07F0 Offset: 0x18CEDF0 VA: 0x1818D07F0 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x18D05B0 Offset: 0x18CEBB0 VA: 0x1818D05B0 Slot: 14
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D0620 Offset: 0x18CEC20 VA: 0x1818D0620 Slot: 15
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D06A0 Offset: 0x18CECA0 VA: 0x1818D06A0 Slot: 16
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

	// RVA: 0x18D0A70 Offset: 0x18CF070 VA: 0x1818D0A70
	internal static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x18D0A60 Offset: 0x18CF060 VA: 0x1818D0A60
	internal static Type[] GetTypeModifiers(MonoProperty prop, bool optional) { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
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

	// RVA: 0x18D0A80 Offset: 0x18CF080 VA: 0x1818D0A80
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x18D1AC0 Offset: 0x18D00C0 VA: 0x1818D1AC0 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18D1B00 Offset: 0x18D0100 VA: 0x1818D1B00 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18D1B50 Offset: 0x18D0150 VA: 0x1818D1B50 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18D1C20 Offset: 0x18D0220 VA: 0x1818D1C20 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18D1D00 Offset: 0x18D0300 VA: 0x1818D1D00 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18D1BA0 Offset: 0x18D01A0 VA: 0x1818D1BA0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18D1BE0 Offset: 0x18D01E0 VA: 0x1818D1BE0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D0E40 Offset: 0x18CF440 VA: 0x1818D0E40 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18D1110 Offset: 0x18CF710 VA: 0x1818D1110 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18D11C0 Offset: 0x18CF7C0 VA: 0x1818D11C0 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18D1580 Offset: 0x18CFB80 VA: 0x1818D1580 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0 Slot: 33
	public override object GetConstantValue() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0 Slot: 34
	public override object GetRawConstantValue() { }

	// RVA: 0x18D1810 Offset: 0x18CFE10 VA: 0x1818D1810 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D10B0 Offset: 0x18CF6B0 VA: 0x1818D10B0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D1040 Offset: 0x18CF640 VA: 0x1818D1040 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6A20 Offset: 0xED5020 VA: 0x180ED6A20
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6AB0 Offset: 0xED50B0 VA: 0x180ED6AB0
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x18D0AC0 Offset: 0x18CF0C0 VA: 0x1818D0AC0
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x18D1630 Offset: 0x18CFC30 VA: 0x1818D1630 Slot: 27
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x18D1670 Offset: 0x18CFC70 VA: 0x1818D1670 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D1880 Offset: 0x18CFE80 VA: 0x1818D1880 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D14A0 Offset: 0x18CFAA0 VA: 0x1818D14A0 Slot: 31
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x18D1510 Offset: 0x18CFB10 VA: 0x1818D1510 Slot: 32
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x18C7090 Offset: 0x18C5690 VA: 0x1818C7090 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class MonoProperty.GetterAdapter : MulticastDelegate // TypeDefIndex: 593
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x133B8A0 Offset: 0x1339EA0 VA: 0x18133B8A0 Slot: 12
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
	|-RVA: 0x189FB20 Offset: 0x189E120 VA: 0x18189FB20
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
	|-RVA: 0xD50C20 Offset: 0xD4F220 VA: 0x180D50C20
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

	// RVA: 0x1628010 Offset: 0x1626610 VA: 0x181628010
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x1627950 Offset: 0x1625F50 VA: 0x181627950
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x1627420 Offset: 0x1625A20 VA: 0x181627420
	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x1627430 Offset: 0x1625A30 VA: 0x181627430
	public static bool CreateDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1628790 Offset: 0x1626D90 VA: 0x181628790
	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x1628720 Offset: 0x1626D20 VA: 0x181628720
	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	// RVA: 0x1627940 Offset: 0x1625F40 VA: 0x181627940
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x1628460 Offset: 0x1626A60 VA: 0x181628460
	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	// RVA: 0x1628470 Offset: 0x1626A70 VA: 0x181628470
	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	// RVA: 0x1627360 Offset: 0x1625960 VA: 0x181627360
	private static bool CopyFile(char* path, char* dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x1627370 Offset: 0x1625970 VA: 0x181627370
	public static bool CopyFile(string path, string dest, bool overwrite, out MonoIOError error) { }

	// RVA: 0x16274A0 Offset: 0x1625AA0 VA: 0x1816274A0
	private static bool DeleteFile(char* path, out MonoIOError error) { }

	// RVA: 0x16274B0 Offset: 0x1625AB0 VA: 0x1816274B0
	public static bool DeleteFile(string path, out MonoIOError error) { }

	// RVA: 0x16280F0 Offset: 0x16266F0 VA: 0x1816280F0
	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	// RVA: 0x1628100 Offset: 0x1626700 VA: 0x181628100
	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	// RVA: 0x1628320 Offset: 0x1626920 VA: 0x181628320
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1628200 Offset: 0x1626800 VA: 0x181628200
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1627920 Offset: 0x1625F20 VA: 0x181627920
	private static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1627890 Offset: 0x1625E90 VA: 0x181627890
	public static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1627930 Offset: 0x1625F30 VA: 0x181627930
	public static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x1627880 Offset: 0x1625E80 VA: 0x181627880
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x16277C0 Offset: 0x1625DC0 VA: 0x1816277C0
	public static bool Exists(string path, out MonoIOError error) { }

	// RVA: 0x1627610 Offset: 0x1625C10 VA: 0x181627610
	public static bool ExistsFile(string path, out MonoIOError error) { }

	// RVA: 0x1627530 Offset: 0x1625B30 VA: 0x181627530
	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	// RVA: 0x16276E0 Offset: 0x1625CE0 VA: 0x1816276E0
	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	// RVA: 0x1628170 Offset: 0x1626770 VA: 0x181628170
	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x1628180 Offset: 0x1626780 VA: 0x181628180
	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x1628510 Offset: 0x1626B10 VA: 0x181628510
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1628520 Offset: 0x1626B20 VA: 0x181628520
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1627350 Offset: 0x1625950 VA: 0x181627350
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1628700 Offset: 0x1626D00 VA: 0x181628700
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x16285B0 Offset: 0x1626BB0 VA: 0x1816285B0
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1628F60 Offset: 0x1627560 VA: 0x181628F60
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1628F70 Offset: 0x1627570 VA: 0x181628F70
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x16287A0 Offset: 0x1626DA0 VA: 0x1816287A0
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x16287B0 Offset: 0x1626DB0 VA: 0x1816287B0
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1628330 Offset: 0x1626930 VA: 0x181628330
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1628340 Offset: 0x1626940 VA: 0x181628340
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1628F50 Offset: 0x1627550 VA: 0x181628F50
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x1628E20 Offset: 0x1627420 VA: 0x181628E20
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x1628B80 Offset: 0x1627180 VA: 0x181628B80
	private static bool SetFileTime(IntPtr handle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x1628B90 Offset: 0x1627190 VA: 0x181628B90
	public static bool SetFileTime(SafeHandle safeHandle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	// RVA: 0x16288F0 Offset: 0x1626EF0 VA: 0x1816288F0
	public static bool SetCreationTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1628CE0 Offset: 0x16272E0 VA: 0x181628CE0
	public static bool SetLastAccessTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1628D80 Offset: 0x1627380 VA: 0x181628D80
	public static bool SetLastWriteTime(string path, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1628990 Offset: 0x1626F90 VA: 0x181628990
	public static bool SetFileTime(string path, int type, long creation_time, long last_access_time, long last_write_time, DateTime dateTime, out MonoIOError error) { }

	// RVA: 0x1629160 Offset: 0x1627760 VA: 0x181629160
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x1629150 Offset: 0x1627750 VA: 0x181629150
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x1629140 Offset: 0x1627740 VA: 0x181629140
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x1627520 Offset: 0x1625B20 VA: 0x181627520
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	// RVA: 0x1629190 Offset: 0x1627790 VA: 0x181629190
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x1629170 Offset: 0x1627770 VA: 0x181629170
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x1629130 Offset: 0x1627730 VA: 0x181629130
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x1629180 Offset: 0x1627780 VA: 0x181629180
	public static char get_PathSeparator() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	private static void DumpHandles() { }

	// RVA: 0x1628710 Offset: 0x1626D10 VA: 0x181628710
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x16290C0 Offset: 0x16276C0 VA: 0x1816290C0
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

	// RVA: 0x1480B40 Offset: 0x147F140 VA: 0x181480B40
	internal void InitMessage(MonoMethod method, object[] out_args) { }

	// RVA: 0x1480F80 Offset: 0x147F580 VA: 0x181480F80
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x1481080 Offset: 0x147F680 VA: 0x181481080
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x1480A80 Offset: 0x147F080 VA: 0x181480A80
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x1481200 Offset: 0x147F800 VA: 0x181481200
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x1481840 Offset: 0x147FE40 VA: 0x181481840 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x1481320 Offset: 0x147F920 VA: 0x181481320 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1481450 Offset: 0x147FA50 VA: 0x181481450 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x14814D0 Offset: 0x147FAD0 VA: 0x1814814D0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x14818C0 Offset: 0x147FEC0 VA: 0x1814818C0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 19
	public string get_Uri() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x1480A40 Offset: 0x147F040 VA: 0x181480A40 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x1481630 Offset: 0x147FC30 VA: 0x181481630 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x14816A0 Offset: 0x147FCA0 VA: 0x1814816A0 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x1481360 Offset: 0x147F960 VA: 0x181481360
	internal CallType get_CallType() { }

	// RVA: 0x1480E90 Offset: 0x147F490 VA: 0x181480E90
	public bool NeedsOutProcessing(out int outCount) { }

	// RVA: 0x1480F10 Offset: 0x147F510 VA: 0x181480F10
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
	// RVA: 0x13A97C0 Offset: 0x13A7DC0 VA: 0x1813A97C0
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1AB96D0 Offset: 0x1AB7CD0 VA: 0x181AB96D0
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

	// RVA: 0x1AB9650 Offset: 0x1AB7C50 VA: 0x181AB9650 Slot: 3
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

	// RVA: 0xFFB8F0 Offset: 0xFF9EF0 VA: 0x180FFB8F0 Slot: 12
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x1AB95B0 Offset: 0x1AB7BB0 VA: 0x181AB95B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0xFF6510 Offset: 0xFF4B10 VA: 0x180FF6510 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 1746
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF9650 Offset: 0xFF7C50 VA: 0x180FF9650 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xFF9600 Offset: 0xFF7C00 VA: 0x180FF9600 Slot: 13
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

	// RVA: 0x1AB96E0 Offset: 0x1AB7CE0 VA: 0x181AB96E0
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

	// RVA: 0x1AB9B30 Offset: 0x1AB8130 VA: 0x181AB9B30
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x1AB9B50 Offset: 0x1AB8150 VA: 0x181AB9B50
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x1086850 Offset: 0x1084E50 VA: 0x181086850
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD67600 Offset: 0xD65C00 VA: 0x180D67600
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1096870 Offset: 0x1094E70 VA: 0x181096870
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
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
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
	// RVA: 0xF90130 Offset: 0xF8E730 VA: 0x180F90130
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1AB9B40 Offset: 0x1AB8140 VA: 0x181AB9B40
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x1AB9930 Offset: 0x1AB7F30 VA: 0x181AB9930
	public void .ctor() { }

	// RVA: 0x1AB9AA0 Offset: 0x1AB80A0 VA: 0x181AB9AA0
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x1AB9860 Offset: 0x1AB7E60 VA: 0x181AB9860
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public ICertificateValidator get_CertificateValidator() { }

	[ObsoleteAttribute] // RVA: 0x7F2D0 Offset: 0x7E6D0 VA: 0x18007F2D0
	// RVA: 0x1AB9760 Offset: 0x1AB7D60 VA: 0x181AB9760
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1AB9800 Offset: 0x1AB7E00 VA: 0x181AB9800
	public MonoTlsSettings Clone() { }

	// RVA: 0x1AB9940 Offset: 0x1AB7F40 VA: 0x181AB9940
	private void .ctor(MonoTlsSettings other) { }

}

internal class MonoTODOAttribute : Attribute // TypeDefIndex: 1810
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

internal sealed class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 2454
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x1219830 Offset: 0x1217E30 VA: 0x181219830
	internal static MonoTlsProvider GetProviderInternal() { }

	// RVA: 0x1219A00 Offset: 0x1218000 VA: 0x181219A00
	internal static void InitializeInternal() { }

	// RVA: 0x121A200 Offset: 0x1218800 VA: 0x18121A200
	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x1219DB0 Offset: 0x12183B0 VA: 0x181219DB0
	private static void InitializeProviderRegistration() { }

	// RVA: 0x12197B0 Offset: 0x1217DB0 VA: 0x1812197B0
	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x1219970 Offset: 0x1217F70 VA: 0x181219970
	internal static MonoTlsProvider GetProvider() { }

	// RVA: 0x121A700 Offset: 0x1218D00 VA: 0x18121A700
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

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC65CA0 Offset: 0xC642A0 VA: 0x180C65CA0
	internal bool get_CertificateValidationFailed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72F60 Offset: 0xE71560 VA: 0x180E72F60
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x121ADA0 Offset: 0x12193A0 VA: 0x18121ADA0
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0x121A830 Offset: 0x1218E30 VA: 0x18121A830
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

	// RVA: 0x1347BD0 Offset: 0x13461D0 VA: 0x181347BD0
	public void .ctor(byte[] buffer, int offset, int size, WebHeaderCollection headers) { }

	// RVA: 0x1347B20 Offset: 0x1346120 VA: 0x181347B20
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x13479C0 Offset: 0x1345FC0 VA: 0x1813479C0
	public void ResetBuffer() { }

	// RVA: 0x1347A70 Offset: 0x1346070 VA: 0x181347A70
	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	// RVA: 0x1347960 Offset: 0x1345F60 VA: 0x181347960
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x13473F0 Offset: 0x13459F0 VA: 0x1813473F0
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1347AF0 Offset: 0x13460F0 VA: 0x181347AF0
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1346F10 Offset: 0x1345510 VA: 0x181346F10
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1347DE0 Offset: 0x13463E0 VA: 0x181347DE0
	public bool get_WantMore() { }

	// RVA: 0x1347CD0 Offset: 0x13462D0 VA: 0x181347CD0
	public bool get_DataAvailable() { }

	// RVA: 0x1347CC0 Offset: 0x13462C0 VA: 0x181347CC0
	public int get_ChunkLeft() { }

	// RVA: 0x13471E0 Offset: 0x13457E0 VA: 0x1813471E0
	private MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1346C50 Offset: 0x1345250 VA: 0x181346C50
	private MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1347970 Offset: 0x1345F70 VA: 0x181347970
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1347310 Offset: 0x1345910 VA: 0x181347310
	private MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x13476A0 Offset: 0x1345CA0 VA: 0x1813476A0
	private MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1347A00 Offset: 0x1346000 VA: 0x181347A00
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

	// RVA: 0x132FCF0 Offset: 0x132E2F0 VA: 0x18132FCF0
	public int Read(byte[] buffer, int offset, int size) { }

}

public class MonoBehaviour : Behaviour // TypeDefIndex: 3518
{	// Properties
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x18F72D0 Offset: 0x18F58D0 VA: 0x1818F72D0
	public bool IsInvoking() { }

	// RVA: 0x18F7250 Offset: 0x18F5850 VA: 0x1818F7250
	public void CancelInvoke() { }

	// RVA: 0x18F7460 Offset: 0x18F5A60 VA: 0x1818F7460
	public void Invoke(string methodName, float time) { }

	// RVA: 0x18F7380 Offset: 0x18F5980 VA: 0x1818F7380
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x18F7200 Offset: 0x18F5800 VA: 0x1818F7200
	public void CancelInvoke(string methodName) { }

	// RVA: 0x18F74C0 Offset: 0x18F5AC0 VA: 0x1818F74C0
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F76F0 Offset: 0x18F5CF0 VA: 0x1818F76F0
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x18F77F0 Offset: 0x18F5DF0 VA: 0x1818F77F0
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x18F7600 Offset: 0x18F5C00 VA: 0x1818F7600
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[ObsoleteAttribute] // RVA: 0xC1AF0 Offset: 0xC0EF0 VA: 0x1800C1AF0
	// RVA: 0x18F7600 Offset: 0x18F5C00 VA: 0x1818F7600
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x18F79E0 Offset: 0x18F5FE0 VA: 0x1818F79E0
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x18F7B20 Offset: 0x18F6120 VA: 0x1818F7B20
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x18F7AD0 Offset: 0x18F60D0 VA: 0x1818F7AD0
	public void StopCoroutine(string methodName) { }

	// RVA: 0x18F7900 Offset: 0x18F5F00 VA: 0x1818F7900
	public void StopAllCoroutines() { }

	// RVA: 0x18F7C20 Offset: 0x18F6220 VA: 0x1818F7C20
	public bool get_useGUILayout() { }

	// RVA: 0x18F7CC0 Offset: 0x18F62C0 VA: 0x1818F7CC0
	public void set_useGUILayout(bool value) { }

	// RVA: 0x18F7C60 Offset: 0x18F6260 VA: 0x1818F7C60
	public static void print(object message) { }

	[FreeFunctionAttribute] // RVA: 0xC1B80 Offset: 0xC0F80 VA: 0x1800C1B80
	// RVA: 0x18F7250 Offset: 0x18F5850 VA: 0x1818F7250
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0xC1C90 Offset: 0xC1090 VA: 0x1800C1C90
	// RVA: 0x18F72D0 Offset: 0x18F58D0 VA: 0x1818F72D0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F7310 Offset: 0x18F5910 VA: 0x1818F7310
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F7200 Offset: 0x18F5800 VA: 0x1818F7200
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F74C0 Offset: 0x18F5AC0 VA: 0x1818F74C0
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18F7510 Offset: 0x18F5B10 VA: 0x1818F7510
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x18F75A0 Offset: 0x18F5BA0 VA: 0x1818F75A0
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x18F7550 Offset: 0x18F5B50 VA: 0x1818F7550
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x18F7990 Offset: 0x18F5F90 VA: 0x1818F7990
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x18F7940 Offset: 0x18F5F40 VA: 0x1818F7940
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x18F7290 Offset: 0x18F5890 VA: 0x1818F7290
	internal string GetScriptClassName() { }

	// RVA: 0x18F7C10 Offset: 0x18F6210 VA: 0x1818F7C10
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string comment) { }

}

internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 5256
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

internal static class Mono // TypeDefIndex: 6227
{	// Methods

	// RVA: 0x14B5D50 Offset: 0x14B4350 VA: 0x1814B5D50
	internal static void FixHttpsValidation() { }

}

private sealed class Mono.<>c // TypeDefIndex: 6228
{	// Fields
	public static readonly Mono.<>c <>9; // 0x0
	public static RemoteCertificateValidationCallback <>9__0_0; // 0x8

	// Methods

	// RVA: 0x14BD300 Offset: 0x14BB900 VA: 0x1814BD300
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public abstract class MonoEncoding : Encoding // TypeDefIndex: 7373
{	// Fields
	private readonly int win_code_page; // 0x38

	// Properties
	public override int WindowsCodePage { get; }

	// Methods

	// RVA: 0x22AD6D0 Offset: 0x22ABCD0 VA: 0x1822AD6D0
	public void .ctor(int codePage) { }

	// RVA: 0x22AD6A0 Offset: 0x22ABCA0 VA: 0x1822AD6A0
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: 0x22AD6F0 Offset: 0x22ABCF0 VA: 0x1822AD6F0 Slot: 11
	public override int get_WindowsCodePage() { }

	// RVA: 0x22AD410 Offset: 0x22ABA10 VA: 0x1822AD410
	public void HandleFallback(ref EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

	// RVA: 0x22ACD50 Offset: 0x22AB350 VA: 0x1822ACD50 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x22AD170 Offset: 0x22AB770 VA: 0x1822AD170 Slot: 24
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22ACEE0 Offset: 0x22AB4E0 VA: 0x1822ACEE0 Slot: 26
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x22ACEC0 Offset: 0x22AB4C0 VA: 0x1822ACEC0 Slot: 20
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x22AD3F0 Offset: 0x22AB9F0 VA: 0x1822AD3F0 Slot: 28
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

	// RVA: 0x15C0FC0 Offset: 0x15BF5C0 VA: 0x1815C0FC0
	public void .ctor(MonoEncoding encoding) { }

	// RVA: 0x22AC890 Offset: 0x22AAE90 VA: 0x1822AC890 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool refresh) { }

	// RVA: 0x22ACA10 Offset: 0x22AB010 VA: 0x1822ACA10 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);

	// RVA: 0x22ACC90 Offset: 0x22AB290 VA: 0x1822ACC90 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x22ACCB0 Offset: 0x22AB2B0 VA: 0x1822ACCB0
	public void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }

}

