internal class DefaultBinder : Binder // TypeDefIndex: 203
{	// Methods

	// RVA: 0xD6A120 Offset: 0xD68720 VA: 0x180D6A120 Slot: 4
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0xD69910 Offset: 0xD67F10 VA: 0x180D69910 Slot: 5
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0xD6EEA0 Offset: 0xD6D4A0 VA: 0x180D6EEA0 Slot: 6
	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6F6F0 Offset: 0xD6DCF0 VA: 0x180D6F6F0 Slot: 7
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0xD6D0F0 Offset: 0xD6B6F0 VA: 0x180D6D0F0 Slot: 8
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0xD6E960 Offset: 0xD6CF60 VA: 0x180D6E960 Slot: 9
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0xD6D550 Offset: 0xD6BB50 VA: 0x180D6D550
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6D8E0 Offset: 0xD6BEE0 VA: 0x180D6D8E0
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6E450 Offset: 0xD6CA50 VA: 0x180D6E450
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD6E060 Offset: 0xD6C660 VA: 0x180D6E060
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0xD6DE00 Offset: 0xD6C400 VA: 0x180D6DE00
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD6DD20 Offset: 0xD6C320 VA: 0x180D6DD20
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0xD6DD20 Offset: 0xD6C320 VA: 0x180D6DD20
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0xD6D160 Offset: 0xD6B760 VA: 0x180D6D160
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0xD6E8D0 Offset: 0xD6CED0 VA: 0x180D6E8D0
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0xD6DC00 Offset: 0xD6C200 VA: 0x180D6DC00
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0xD6ECD0 Offset: 0xD6D2D0 VA: 0x180D6ECD0
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0xD6D2E0 Offset: 0xD6B8E0 VA: 0x180D6D2E0
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0xD6CE90 Offset: 0xD6B490 VA: 0x180D6CE90
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0xD6CD90 Offset: 0xD6B390 VA: 0x180D6CD90
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

internal class DefaultBinder.BinderState // TypeDefIndex: 204
{	// Fields
	internal int[] m_argsMap; // 0x10
	internal int m_originalSize; // 0x18
	internal bool m_isParamArray; // 0x1C

	// Methods

	// RVA: 0xD68010 Offset: 0xD66610 VA: 0x180D68010
	internal void .ctor(int[] argsMap, int originalSize, bool isParamArray) { }

}

private sealed class DefaultBinder.<>c // TypeDefIndex: 205
{	// Fields
	public static readonly DefaultBinder.<>c <>9; // 0x0
	public static Predicate<Type> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xD87790 Offset: 0xD85D90 VA: 0x180D87790
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD874C0 Offset: 0xD85AC0 VA: 0x180D874C0
	internal bool <SelectProperty>b__3_0(Type t) { }

}

