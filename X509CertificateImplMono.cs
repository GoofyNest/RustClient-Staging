internal sealed class X509CertificateImplMono : X509CertificateImpl // TypeDefIndex: 1019
{	// Fields
	private X509Certificate x509; // 0x18

	// Properties
	public override bool IsValid { get; }

	// Methods

	// RVA: 0x10B6570 Offset: 0x10B4B70 VA: 0x1810B6570
	public void .ctor(X509Certificate x509) { }

	// RVA: 0x17C8F50 Offset: 0x17C7550 VA: 0x1817C8F50 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x17C86E0 Offset: 0x17C6CE0 VA: 0x1817C86E0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x17C8930 Offset: 0x17C6F30 VA: 0x1817C8930 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x17C8B30 Offset: 0x17C7130 VA: 0x1817C8B30 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x17C8A30 Offset: 0x17C7030 VA: 0x1817C8A30 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x17C8790 Offset: 0x17C6D90 VA: 0x1817C8790 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x17C8C30 Offset: 0x17C7230 VA: 0x1817C8C30 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x17C8CB0 Offset: 0x17C72B0 VA: 0x1817C8CB0 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14CE6A0 Offset: 0x14CCCA0 VA: 0x1814CE6A0 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x17C8AB0 Offset: 0x17C70B0 VA: 0x1817C8AB0 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x17C8D30 Offset: 0x17C7330 VA: 0x1817C8D30 Slot: 15
	public override string ToString(bool full) { }

	// RVA: 0xA7E410 Offset: 0xA7CA10 VA: 0x180A7E410 Slot: 16
	protected override void Dispose(bool disposing) { }

}

