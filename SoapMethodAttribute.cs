public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 1212
{	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x148D560 Offset: 0x148BB60 VA: 0x18148D560 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }

}

