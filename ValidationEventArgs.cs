public class ValidationEventArgs : EventArgs // TypeDefIndex: 2287
{	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0xEF2BE0 Offset: 0xEF11E0 VA: 0x180EF2BE0
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0xEF2B60 Offset: 0xEF1160 VA: 0x180EF2B60
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public XmlSeverityType get_Severity() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public XmlSchemaException get_Exception() { }

}

