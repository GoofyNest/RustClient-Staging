internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 1018
{	// Fields
	private byte[] cachedCertificateHash; // 0x10

	// Properties
	public abstract bool IsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x17C9390 Offset: 0x17C7990 VA: 0x1817C9390
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetIssuerName(bool legacyV1Mode);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string GetSubjectName(bool legacyV1Mode);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] GetRawCertData();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime GetValidFrom();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime GetValidUntil();

	// RVA: 0x17C9200 Offset: 0x17C7800 VA: 0x1817C9200
	public byte[] GetCertHash() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract byte[] GetCertHash(bool lazy);

	// RVA: 0x17C92A0 Offset: 0x17C78A0 VA: 0x1817C92A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool Equals(X509CertificateImpl other, out bool result);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] GetSerialNumber();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(bool full);

	// RVA: 0x17C8FD0 Offset: 0x17C75D0 VA: 0x1817C8FD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17C8F60 Offset: 0x17C7560 VA: 0x1817C8F60 Slot: 4
	public void Dispose() { }

	// RVA: 0xE37A10 Offset: 0xE36010 VA: 0x180E37A10 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17C9160 Offset: 0x17C7760 VA: 0x1817C9160 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

