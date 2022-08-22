public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 2830
{	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x14D9610 Offset: 0x14D7C10 VA: 0x1814D9610
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x14D9070 Offset: 0x14D7670 VA: 0x1814D9070 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14D91F0 Offset: 0x14D77F0 VA: 0x1814D91F0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14D93C0 Offset: 0x14D79C0 VA: 0x1814D93C0 Slot: 6
	internal override string ToString(bool multiLine) { }

}

