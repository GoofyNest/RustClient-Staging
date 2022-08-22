internal class ReflectionHelper // TypeDefIndex: 2057
{	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x1103D50 Offset: 0x1102350 VA: 0x181103D50
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x1103B40 Offset: 0x1102140 VA: 0x181103B40
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x1103C30 Offset: 0x1102230 VA: 0x181103C30
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x1103A10 Offset: 0x1102010 VA: 0x181103A10
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x1103690 Offset: 0x1101C90 VA: 0x181103690
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x1103E50 Offset: 0x1102450 VA: 0x181103E50
	public void .ctor() { }

	// RVA: 0x1103E00 Offset: 0x1102400 VA: 0x181103E00
	private static void .cctor() { }

}

