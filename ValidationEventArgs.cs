public class ValidationEventArgs : EventArgs // TypeDefIndex: 2287
{	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0xEF2130 Offset: 0xEF0730 VA: 0x180EF2130
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0xEF20B0 Offset: 0xEF06B0 VA: 0x180EF20B0
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public XmlSeverityType get_Severity() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlSchemaException get_Exception() { }

}

