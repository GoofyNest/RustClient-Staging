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

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x148C8F0 Offset: 0x148AEF0 VA: 0x18148C8F0 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }

}

