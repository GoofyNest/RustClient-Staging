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

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_XmlElementName() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public string get_XmlTypeName() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public string get_XmlTypeNamespace() { }

	// RVA: 0xE8CE60 Offset: 0xE8B460 VA: 0x180E8CE60
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x77B140 Offset: 0x779740 VA: 0x18077B140
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x148CAF0 Offset: 0x148B0F0 VA: 0x18148CAF0 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }

}

