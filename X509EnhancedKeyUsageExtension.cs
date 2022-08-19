public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 2830
{	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x14DA280 Offset: 0x14D8880 VA: 0x1814DA280
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x14D9CE0 Offset: 0x14D82E0 VA: 0x1814D9CE0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14D9E60 Offset: 0x14D8460 VA: 0x1814D9E60
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DA030 Offset: 0x14D8630 VA: 0x1814DA030 Slot: 6
	internal override string ToString(bool multiLine) { }

}

