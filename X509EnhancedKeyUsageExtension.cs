public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 2830
{	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x14DA540 Offset: 0x14D8B40 VA: 0x1814DA540
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x14D9FA0 Offset: 0x14D85A0 VA: 0x1814D9FA0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DA120 Offset: 0x14D8720 VA: 0x1814DA120
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DA2F0 Offset: 0x14D88F0 VA: 0x1814DA2F0 Slot: 6
	internal override string ToString(bool multiLine) { }

}

