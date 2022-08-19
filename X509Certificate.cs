internal class X509Certificate : ISerializable // TypeDefIndex: 58
{	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private RSA _rsa; // 0x80
	private DSA _dsa; // 0x88
	private int version; // 0x90
	private byte[] serialnumber; // 0x98
	private byte[] issuerUniqueID; // 0xA0
	private byte[] subjectUniqueID; // 0xA8
	private X509ExtensionCollection extensions; // 0xB0
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; }
	public virtual string IssuerName { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual RSA RSA { get; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }

	// Methods

	// RVA: 0x175DC80 Offset: 0x175C280 VA: 0x18175DC80
	private void Parse(byte[] data) { }

	// RVA: 0x175E570 Offset: 0x175CB70 VA: 0x18175E570
	public void .ctor(byte[] data) { }

	// RVA: 0x175DAC0 Offset: 0x175C0C0 VA: 0x18175DAC0
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x175E7A0 Offset: 0x175CDA0 VA: 0x18175E7A0
	public DSA get_DSA() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x175EB00 Offset: 0x175D100 VA: 0x18175EB00 Slot: 6
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x175EB80 Offset: 0x175D180 VA: 0x18175EB80 Slot: 7
	public virtual RSA get_RSA() { }

	// RVA: 0x175ED80 Offset: 0x175D380 VA: 0x18175ED80 Slot: 8
	public virtual byte[] get_RawData() { }

	// RVA: 0x175EE00 Offset: 0x175D400 VA: 0x18175EE00 Slot: 9
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 10
	public virtual string get_SubjectName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 11
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 12
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public ASN1 GetSubjectName() { }

	// RVA: 0x175DA60 Offset: 0x175C060 VA: 0x18175DA60 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x175DB70 Offset: 0x175C170 VA: 0x18175DB70
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x175E520 Offset: 0x175CB20 VA: 0x18175E520
	private static void .cctor() { }

}

public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 1017
{	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x17CC050 Offset: 0x17CA650 VA: 0x1817CC050
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x17CBCD0 Offset: 0x17CA2D0 VA: 0x1817CBCD0
	public void .ctor(byte[] data) { }

	// RVA: 0x17CBED0 Offset: 0x17CA4D0 VA: 0x1817CBED0
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x17CBD20 Offset: 0x17CA320 VA: 0x1817CBD20
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x17CBA30 Offset: 0x17CA030 VA: 0x1817CBA30
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x17CC0B0 Offset: 0x17CA6B0 VA: 0x1817CC0B0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x17CC120 Offset: 0x17CA720 VA: 0x1817CC120
	internal bool get_IsValid() { }

	// RVA: 0x17CB6C0 Offset: 0x17C9CC0 VA: 0x1817CB6C0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x17CB7D0 Offset: 0x17C9DD0 VA: 0x1817CB7D0 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x17CB7A0 Offset: 0x17C9DA0 VA: 0x1817CB7A0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x17CB850 Offset: 0x17C9E50 VA: 0x1817CB850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17CB8B0 Offset: 0x17C9EB0 VA: 0x1817CB8B0 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x17CB9A0 Offset: 0x17C9FA0 VA: 0x1817CB9A0 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x17CB940 Offset: 0x17C9F40 VA: 0x1817CB940 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x17CBC60 Offset: 0x17CA260 VA: 0x1817CBC60 Slot: 3
	public override string ToString() { }

	// RVA: 0x17CBC70 Offset: 0x17CA270 VA: 0x1817CBC70 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x17CBF60 Offset: 0x17CA560 VA: 0x1817CBF60
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17CC140 Offset: 0x17CA740 VA: 0x1817CC140
	public string get_Issuer() { }

	// RVA: 0x17CC1F0 Offset: 0x17CA7F0 VA: 0x1817CC1F0
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17CB620 Offset: 0x17C9C20 VA: 0x1817CB620 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0xCC8C0 Offset: 0xCBCC0 VA: 0x1800CC8C0
	[MonoTODOAttribute] // RVA: 0xCC8C0 Offset: 0xCBCC0 VA: 0x1800CC8C0
	// RVA: 0x17CBA70 Offset: 0x17CA070 VA: 0x1817CBA70 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] // RVA: 0xCCA20 Offset: 0xCBE20 VA: 0x1800CCA20
	[ComVisibleAttribute] // RVA: 0xCCA20 Offset: 0xCBE20 VA: 0x1800CCA20
	// RVA: 0x1192A60 Offset: 0x1191060 VA: 0x181192A60 Slot: 15
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17CBBA0 Offset: 0x17CA1A0 VA: 0x1817CBBA0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17CB5E0 Offset: 0x17C9BE0 VA: 0x1817CB5E0 Slot: 6
	public void Dispose() { }

	// RVA: 0x17CB600 Offset: 0x17C9C00 VA: 0x1817CB600 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17CBAE0 Offset: 0x17CA0E0 VA: 0x1817CBAE0 Slot: 17
	public virtual void Reset() { }

}

public class X509Certificate : ISerializable // TypeDefIndex: 1716
{	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SignatureAlgorithm { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x227E330 Offset: 0x227C930 VA: 0x18227E330
	private void Parse(byte[] data) { }

	// RVA: 0x227F0F0 Offset: 0x227D6F0 VA: 0x18227F0F0
	public void .ctor(byte[] data) { }

	// RVA: 0x227E170 Offset: 0x227C770 VA: 0x18227E170
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x227F320 Offset: 0x227D920 VA: 0x18227F320
	public DSA get_DSA() { }

	// RVA: 0x2280020 Offset: 0x227E620 VA: 0x182280020
	public void set_DSA(DSA value) { }

	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x227F680 Offset: 0x227DC80 VA: 0x18227F680
	public byte[] get_Hash() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x227F8B0 Offset: 0x227DEB0 VA: 0x18227F8B0 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810 Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x227F930 Offset: 0x227DF30 VA: 0x18227F930 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x227F9B0 Offset: 0x227DFB0 VA: 0x18227F9B0 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x2280070 Offset: 0x227E670 VA: 0x182280070 Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x227FBB0 Offset: 0x227E1B0 VA: 0x18227FBB0 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x227FC30 Offset: 0x227E230 VA: 0x18227FC30 Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x227FCB0 Offset: 0x227E2B0 VA: 0x18227FCB0 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 15
	public virtual string get_SignatureAlgorithm() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 16
	public virtual string get_SubjectName() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 17
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 18
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0xB9B270 Offset: 0xB99870 VA: 0x180B9B270
	public int get_Version() { }

	// RVA: 0x227EBF0 Offset: 0x227D1F0 VA: 0x18227EBF0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x227EF90 Offset: 0x227D590 VA: 0x18227EF90
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x227ECB0 Offset: 0x227D2B0 VA: 0x18227ECB0
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public ASN1 GetIssuerName() { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public ASN1 GetSubjectName() { }

	// RVA: 0x227E110 Offset: 0x227C710 VA: 0x18227E110 Slot: 19
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x227E220 Offset: 0x227C820 VA: 0x18227E220
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x227F0A0 Offset: 0x227D6A0 VA: 0x18227F0A0
	private static void .cctor() { }

}

