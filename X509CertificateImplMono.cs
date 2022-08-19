internal sealed class X509CertificateImplMono : X509CertificateImpl // TypeDefIndex: 1019
{	// Fields
	private X509Certificate x509; // 0x18

	// Properties
	public override bool IsValid { get; }

	// Methods

	// RVA: 0x10B5840 Offset: 0x10B3E40 VA: 0x1810B5840
	public void .ctor(X509Certificate x509) { }

	// RVA: 0x17CB140 Offset: 0x17C9740 VA: 0x1817CB140 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x17CA8D0 Offset: 0x17C8ED0 VA: 0x1817CA8D0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x17CAB20 Offset: 0x17C9120 VA: 0x1817CAB20 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x17CAD20 Offset: 0x17C9320 VA: 0x1817CAD20 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x17CAC20 Offset: 0x17C9220 VA: 0x1817CAC20 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x17CA980 Offset: 0x17C8F80 VA: 0x1817CA980 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x17CAE20 Offset: 0x17C9420 VA: 0x1817CAE20 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x17CAEA0 Offset: 0x17C94A0 VA: 0x1817CAEA0 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14CF310 Offset: 0x14CD910 VA: 0x1814CF310 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x17CACA0 Offset: 0x17C92A0 VA: 0x1817CACA0 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x17CAF20 Offset: 0x17C9520 VA: 0x1817CAF20 Slot: 15
	public override string ToString(bool full) { }

	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80 Slot: 16
	protected override void Dispose(bool disposing) { }

}

