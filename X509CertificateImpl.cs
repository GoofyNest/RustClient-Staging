internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 1018
{	// Fields
	private byte[] cachedCertificateHash; // 0x10

	// Properties
	public abstract bool IsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x17CB840 Offset: 0x17C9E40 VA: 0x1817CB840
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

	// RVA: 0x17CB6B0 Offset: 0x17C9CB0 VA: 0x1817CB6B0
	public byte[] GetCertHash() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract byte[] GetCertHash(bool lazy);

	// RVA: 0x17CB750 Offset: 0x17C9D50 VA: 0x1817CB750 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool Equals(X509CertificateImpl other, out bool result);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] GetSerialNumber();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(bool full);

	// RVA: 0x17CB480 Offset: 0x17C9A80 VA: 0x1817CB480 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17CB410 Offset: 0x17C9A10 VA: 0x1817CB410 Slot: 4
	public void Dispose() { }

	// RVA: 0xE36F60 Offset: 0xE35560 VA: 0x180E36F60 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17CB610 Offset: 0x17C9C10 VA: 0x1817CB610 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

