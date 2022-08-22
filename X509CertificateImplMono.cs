internal sealed class X509CertificateImplMono : X509CertificateImpl // TypeDefIndex: 1019
{	// Fields
	private X509Certificate x509; // 0x18

	// Properties
	public override bool IsValid { get; }

	// Methods

	// RVA: 0x10B5B00 Offset: 0x10B4100 VA: 0x1810B5B00
	public void .ctor(X509Certificate x509) { }

	// RVA: 0x17CB400 Offset: 0x17C9A00 VA: 0x1817CB400 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x17CAB90 Offset: 0x17C9190 VA: 0x1817CAB90 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x17CADE0 Offset: 0x17C93E0 VA: 0x1817CADE0 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x17CAFE0 Offset: 0x17C95E0 VA: 0x1817CAFE0 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x17CAEE0 Offset: 0x17C94E0 VA: 0x1817CAEE0 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x17CAC40 Offset: 0x17C9240 VA: 0x1817CAC40 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x17CB0E0 Offset: 0x17C96E0 VA: 0x1817CB0E0 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x17CB160 Offset: 0x17C9760 VA: 0x1817CB160 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14CF5D0 Offset: 0x14CDBD0 VA: 0x1814CF5D0 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x17CAF60 Offset: 0x17C9560 VA: 0x1817CAF60 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x17CB1E0 Offset: 0x17C97E0 VA: 0x1817CB1E0 Slot: 15
	public override string ToString(bool full) { }

	// RVA: 0xA7DF40 Offset: 0xA7C540 VA: 0x180A7DF40 Slot: 16
	protected override void Dispose(bool disposing) { }

}

