internal class ReflectionHelper // TypeDefIndex: 2057
{	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x11047C0 Offset: 0x1102DC0 VA: 0x1811047C0
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x11045B0 Offset: 0x1102BB0 VA: 0x1811045B0
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x11046A0 Offset: 0x1102CA0 VA: 0x1811046A0
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x1104480 Offset: 0x1102A80 VA: 0x181104480
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x1104100 Offset: 0x1102700 VA: 0x181104100
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x11048C0 Offset: 0x1102EC0 VA: 0x1811048C0
	public void .ctor() { }

	// RVA: 0x1104870 Offset: 0x1102E70 VA: 0x181104870
	private static void .cctor() { }

}

