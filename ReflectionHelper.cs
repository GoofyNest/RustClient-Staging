internal class ReflectionHelper // TypeDefIndex: 2057
{	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x1103A90 Offset: 0x1102090 VA: 0x181103A90
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x1103880 Offset: 0x1101E80 VA: 0x181103880
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x1103970 Offset: 0x1101F70 VA: 0x181103970
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x1103750 Offset: 0x1101D50 VA: 0x181103750
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x11033D0 Offset: 0x11019D0 VA: 0x1811033D0
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x1103B90 Offset: 0x1102190 VA: 0x181103B90
	public void .ctor() { }

	// RVA: 0x1103B40 Offset: 0x1102140 VA: 0x181103B40
	private static void .cctor() { }

}

