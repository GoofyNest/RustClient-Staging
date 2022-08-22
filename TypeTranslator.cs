internal class TypeTranslator // TypeDefIndex: 2064
{	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x1109070 Offset: 0x1107670 VA: 0x181109070
	private static void .cctor() { }

	// RVA: 0x1108300 Offset: 0x1106900 VA: 0x181108300
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x1108360 Offset: 0x1106960 VA: 0x181108360
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x11082A0 Offset: 0x11068A0 VA: 0x1811082A0
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x1108050 Offset: 0x1106650 VA: 0x181108050
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x1107E90 Offset: 0x1106490 VA: 0x181107E90
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x1107F60 Offset: 0x1106560 VA: 0x181107F60
	public static string GetArrayName(string elemName) { }

	// RVA: 0x1108F20 Offset: 0x1107520 VA: 0x181108F20
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

