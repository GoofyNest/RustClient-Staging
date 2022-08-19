public class X509Certificate2 : X509Certificate // TypeDefIndex: 2814
{	// Fields
	private string friendlyName; // 0x30
	private static byte[] signedData; // 0x0

	// Properties
	internal X509Certificate2Impl Impl { get; }
	public X509ExtensionCollection Extensions { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public AsymmetricAlgorithm PrivateKey { get; set; }
	public PublicKey PublicKey { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	[MonoTODOAttribute] // RVA: 0xAFFA0 Offset: 0xAF3A0 VA: 0x1800AFFA0
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0x1193550 Offset: 0x1191B50 VA: 0x181193550
	internal X509Certificate2Impl get_Impl() { }

	// RVA: 0x1193440 Offset: 0x1191A40 VA: 0x181193440
	public void .ctor() { }

	// RVA: 0x11932D0 Offset: 0x11918D0 VA: 0x1811932D0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1193490 Offset: 0x1191A90 VA: 0x181193490
	public void .ctor(string fileName, string password) { }

	// RVA: 0x11933D0 Offset: 0x11919D0 VA: 0x1811933D0
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x1193350 Offset: 0x1191950 VA: 0x181193350
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1193520 Offset: 0x1191B20 VA: 0x181193520
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x11935E0 Offset: 0x1191BE0 VA: 0x1811935E0
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x1193620 Offset: 0x1191C20 VA: 0x181193620
	public DateTime get_NotAfter() { }

	// RVA: 0x1193660 Offset: 0x1191C60 VA: 0x181193660
	public DateTime get_NotBefore() { }

	// RVA: 0x11936A0 Offset: 0x1191CA0 VA: 0x1811936A0
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1193790 Offset: 0x1191D90 VA: 0x181193790
	public void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x11936D0 Offset: 0x1191CD0 VA: 0x1811936D0
	public PublicKey get_PublicKey() { }

	// RVA: 0xFCD140 Offset: 0xFCB740 VA: 0x180FCD140
	public string get_SerialNumber() { }

	// RVA: 0x1193700 Offset: 0x1191D00 VA: 0x181193700
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x1193730 Offset: 0x1191D30 VA: 0x181193730
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0
	public string get_Thumbprint() { }

	// RVA: 0x1193760 Offset: 0x1191D60 VA: 0x181193760
	public int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAFCA0 Offset: 0xAF0A0 VA: 0x1800AFCA0
	// RVA: 0x11929D0 Offset: 0x1190FD0 VA: 0x1811929D0
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[MonoTODOAttribute] // RVA: 0xAFD40 Offset: 0xAF140 VA: 0x1800AFD40
	// RVA: 0x1192A20 Offset: 0x1191020 VA: 0x181192A20 Slot: 14
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xAFD40 Offset: 0xAF140 VA: 0x1800AFD40
	// RVA: 0x1192A60 Offset: 0x1191060 VA: 0x181192A60 Slot: 15
	public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1192AC0 Offset: 0x11910C0 VA: 0x181192AC0 Slot: 17
	public override void Reset() { }

	// RVA: 0x11931C0 Offset: 0x11917C0 VA: 0x1811931C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1192B10 Offset: 0x1191110 VA: 0x181192B10 Slot: 13
	public override string ToString(bool verbose) { }

	// RVA: 0x1192910 Offset: 0x1190F10 VA: 0x181192910
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xAFF10 Offset: 0xAF310 VA: 0x1800AFF10
	// RVA: 0x1193220 Offset: 0x1191820 VA: 0x181193220
	public bool Verify() { }

	// RVA: 0x1193610 Offset: 0x1191C10 VA: 0x181193610
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x1193260 Offset: 0x1191860 VA: 0x181193260
	private static void .cctor() { }

}

