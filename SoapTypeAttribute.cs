public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 1214
{	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_XmlElementName() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public string get_XmlTypeName() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public string get_XmlTypeNamespace() { }

	// RVA: 0xE8C0F0 Offset: 0xE8A6F0 VA: 0x180E8C0F0
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x148D760 Offset: 0x148BD60 VA: 0x18148D760 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }

}

