public sealed class X509ChainPolicy // TypeDefIndex: 2828
{	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; }
	public X509RevocationFlag RevocationFlag { get; set; }
	public X509RevocationMode RevocationMode { get; set; }
	public TimeSpan UrlRetrievalTimeout { set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0x14D91C0 Offset: 0x14D77C0 VA: 0x1814D91C0
	public void .ctor() { }

	// RVA: 0x14D9180 Offset: 0x14D7780 VA: 0x1814D9180
	internal void .ctor(X509CertificateCollection store) { }

	// RVA: 0x14D91E0 Offset: 0x14D77E0 VA: 0x1814D91E0
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x14D94A0 Offset: 0x14D7AA0 VA: 0x1814D94A0
	public void set_RevocationFlag(X509RevocationFlag value) { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x14D9510 Offset: 0x14D7B10 VA: 0x1814D9510
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0xC15300 Offset: 0xC13900 VA: 0x180C15300
	public void set_UrlRetrievalTimeout(TimeSpan value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x14D9580 Offset: 0x14D7B80 VA: 0x1814D9580
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public DateTime get_VerificationTime() { }

	// RVA: 0x14D9070 Offset: 0x14D7670 VA: 0x1814D9070
	public void Reset() { }

}

