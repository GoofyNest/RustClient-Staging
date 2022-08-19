public class ValidationEventArgs : EventArgs // TypeDefIndex: 2287
{	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0xEF1E70 Offset: 0xEF0470 VA: 0x180EF1E70
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0xEF1DF0 Offset: 0xEF03F0 VA: 0x180EF1DF0
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public XmlSeverityType get_Severity() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlSchemaException get_Exception() { }

}

