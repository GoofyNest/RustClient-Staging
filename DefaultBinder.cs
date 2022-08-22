internal class DefaultBinder : Binder // TypeDefIndex: 203
{	// Methods

	// RVA: 0xD6A3E0 Offset: 0xD689E0 VA: 0x180D6A3E0 Slot: 4
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0xD69BD0 Offset: 0xD681D0 VA: 0x180D69BD0 Slot: 5
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0xD6F160 Offset: 0xD6D760 VA: 0x180D6F160 Slot: 6
	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6F9B0 Offset: 0xD6DFB0 VA: 0x180D6F9B0 Slot: 7
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0xD6D3B0 Offset: 0xD6B9B0 VA: 0x180D6D3B0 Slot: 8
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0xD6EC20 Offset: 0xD6D220 VA: 0x180D6EC20 Slot: 9
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0xD6D810 Offset: 0xD6BE10 VA: 0x180D6D810
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6DBA0 Offset: 0xD6C1A0 VA: 0x180D6DBA0
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0xD6E710 Offset: 0xD6CD10 VA: 0x180D6E710
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD6E320 Offset: 0xD6C920 VA: 0x180D6E320
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0xD6E0C0 Offset: 0xD6C6C0 VA: 0x180D6E0C0
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0xD6DFE0 Offset: 0xD6C5E0 VA: 0x180D6DFE0
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0xD6DFE0 Offset: 0xD6C5E0 VA: 0x180D6DFE0
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0xD6D420 Offset: 0xD6BA20 VA: 0x180D6D420
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0xD6EB90 Offset: 0xD6D190 VA: 0x180D6EB90
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0xD6DEC0 Offset: 0xD6C4C0 VA: 0x180D6DEC0
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0xD6EF90 Offset: 0xD6D590 VA: 0x180D6EF90
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0xD6D5A0 Offset: 0xD6BBA0 VA: 0x180D6D5A0
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0xD6D150 Offset: 0xD6B750 VA: 0x180D6D150
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0xD6D050 Offset: 0xD6B650 VA: 0x180D6D050
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

internal class DefaultBinder.BinderState // TypeDefIndex: 204
{	// Fields
	internal int[] m_argsMap; // 0x10
	internal int m_originalSize; // 0x18
	internal bool m_isParamArray; // 0x1C

	// Methods

	// RVA: 0xD682D0 Offset: 0xD668D0 VA: 0x180D682D0
	internal void .ctor(int[] argsMap, int originalSize, bool isParamArray) { }

}

private sealed class DefaultBinder.<>c // TypeDefIndex: 205
{	// Fields
	public static readonly DefaultBinder.<>c <>9; // 0x0
	public static Predicate<Type> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xD87A50 Offset: 0xD86050 VA: 0x180D87A50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD87780 Offset: 0xD85D80 VA: 0x180D87780
	internal bool <SelectProperty>b__3_0(Type t) { }

}

