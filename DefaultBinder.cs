internal class DefaultBinder : Binder // TypeDefIndex: 203
{	// Methods

	// RVA: 0xD6AE90 Offset: 0xD69490 VA: 0x180D6AE90 Slot: 4
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0xD6A680 Offset: 0xD68C80 VA: 0x180D6A680 Slot: 5
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0xD6FC10 Offset: 0xD6E210 VA: 0x180D6FC10 Slot: 6
	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD70460 Offset: 0xD6EA60 VA: 0x180D70460 Slot: 7
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0xD6DE60 Offset: 0xD6C460 VA: 0x180D6DE60 Slot: 8
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0xD6F6D0 Offset: 0xD6DCD0 VA: 0x180D6F6D0 Slot: 9
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0xD6E2C0 Offset: 0xD6C8C0 VA: 0x180D6E2C0
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6E650 Offset: 0xD6CC50 VA: 0x180D6E650
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6F1C0 Offset: 0xD6D7C0 VA: 0x180D6F1C0
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD6EDD0 Offset: 0xD6D3D0 VA: 0x180D6EDD0
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0xD6EB70 Offset: 0xD6D170 VA: 0x180D6EB70
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD6EA90 Offset: 0xD6D090 VA: 0x180D6EA90
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0xD6EA90 Offset: 0xD6D090 VA: 0x180D6EA90
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0xD6DED0 Offset: 0xD6C4D0 VA: 0x180D6DED0
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0xD6F640 Offset: 0xD6DC40 VA: 0x180D6F640
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0xD6E970 Offset: 0xD6CF70 VA: 0x180D6E970
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0xD6FA40 Offset: 0xD6E040 VA: 0x180D6FA40
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0xD6E050 Offset: 0xD6C650 VA: 0x180D6E050
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0xD6DC00 Offset: 0xD6C200 VA: 0x180D6DC00
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0xD6DB00 Offset: 0xD6C100 VA: 0x180D6DB00
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

internal class DefaultBinder.BinderState // TypeDefIndex: 204
{	// Fields
	internal int[] m_argsMap; // 0x10
	internal int m_originalSize; // 0x18
	internal bool m_isParamArray; // 0x1C

	// Methods

	// RVA: 0xD68D80 Offset: 0xD67380 VA: 0x180D68D80
	internal void .ctor(int[] argsMap, int originalSize, bool isParamArray) { }

}

private sealed class DefaultBinder.<>c // TypeDefIndex: 205
{	// Fields
	public static readonly DefaultBinder.<>c <>9; // 0x0
	public static Predicate<Type> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xD88500 Offset: 0xD86B00 VA: 0x180D88500
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD88230 Offset: 0xD86830 VA: 0x180D88230
	internal bool <SelectProperty>b__3_0(Type t) { }

}

