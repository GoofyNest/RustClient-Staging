internal class TypeTranslator // TypeDefIndex: 2064
{	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x1108DB0 Offset: 0x11073B0 VA: 0x181108DB0
	private static void .cctor() { }

	// RVA: 0x1108040 Offset: 0x1106640 VA: 0x181108040
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x11080A0 Offset: 0x11066A0 VA: 0x1811080A0
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x1107FE0 Offset: 0x11065E0 VA: 0x181107FE0
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x1107D90 Offset: 0x1106390 VA: 0x181107D90
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x1107BD0 Offset: 0x11061D0 VA: 0x181107BD0
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x1107CA0 Offset: 0x11062A0 VA: 0x181107CA0
	public static string GetArrayName(string elemName) { }

	// RVA: 0x1108C60 Offset: 0x1107260 VA: 0x181108C60
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

