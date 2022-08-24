public class X509Certificate2 : X509Certificate // TypeDefIndex: 2814
{	private string friendlyName; // 0x30
	private static byte[] signedData; // 0x0

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
	[MonoTODOAttribute] // RVA: 0xB0030 Offset: 0xAF430 VA: 0x1800B0030
	internal X509Certificate MonoCertificate { get; }


	internal X509Certificate2Impl get_Impl() { }

	public void .ctor() { }

	public void .ctor(byte[] rawData) { }

	public void .ctor(string fileName, string password) { }

	public void .ctor(X509Certificate certificate) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public X509ExtensionCollection get_Extensions() { }

	public X500DistinguishedName get_IssuerName() { }

	public DateTime get_NotAfter() { }

	public DateTime get_NotBefore() { }

	public AsymmetricAlgorithm get_PrivateKey() { }

	public void set_PrivateKey(AsymmetricAlgorithm value) { }

	public PublicKey get_PublicKey() { }

	public string get_SerialNumber() { }

	public Oid get_SignatureAlgorithm() { }

	public X500DistinguishedName get_SubjectName() { }

	public string get_Thumbprint() { }

	public int get_Version() { }

	[MonoTODOAttribute] // RVA: 0xAEA10 Offset: 0xADE10 VA: 0x1800AEA10
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[MonoTODOAttribute] // RVA: 0xAFE40 Offset: 0xAF240 VA: 0x1800AFE40
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xAFE40 Offset: 0xAF240 VA: 0x1800AFE40
	public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	public override void Reset() { }

	public override string ToString() { }

	public override string ToString(bool verbose) { }

	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	[MonoTODOAttribute] // RVA: 0xB0000 Offset: 0xAF400 VA: 0x1800B0000
	public bool Verify() { }

	internal X509Certificate get_MonoCertificate() { }

	private static void .cctor() { }

}

