internal class X509Certificate : ISerializable // TypeDefIndex: 58
{
	private ASN1 decoder; 
	private byte[] m_encodedcert; 
	private DateTime m_from; 
	private DateTime m_until; 
	private ASN1 issuer; 
	private string m_issuername; 
	private string m_keyalgo; 
	private byte[] m_keyalgoparams; 
	private ASN1 subject; 
	private string m_subject; 
	private byte[] m_publickey; 
	private byte[] signature; 
	private string m_signaturealgo; 
	private byte[] m_signaturealgoparams; 
	private RSA _rsa; 
	private DSA _dsa; 
	private int version; 
	private byte[] serialnumber; 
	private byte[] issuerUniqueID; 
	private byte[] subjectUniqueID; 
	private X509ExtensionCollection extensions; 
	private static string encoding_error; 

	public DSA DSA { get; }
	public virtual string IssuerName { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual RSA RSA { get; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }


	private void Parse(byte[] data) { }

	public void .ctor(byte[] data) { }

	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	public DSA get_DSA() { }

	public virtual string get_IssuerName() { }

	public virtual byte[] get_KeyAlgorithmParameters() { }

	public virtual RSA get_RSA() { }

	public virtual byte[] get_RawData() { }

	public virtual byte[] get_SerialNumber() { }

	public virtual string get_SubjectName() { }

	public virtual DateTime get_ValidFrom() { }

	public virtual DateTime get_ValidUntil() { }

	public ASN1 GetIssuerName() { }

	public ASN1 GetSubjectName() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static byte[] PEM(string type, byte[] data) { }

	private static void .cctor() { }

}

public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 1017
{
	private X509CertificateImpl impl; 
	private bool hideDates; 
	private string issuer_name; 
	private string subject_name; 

	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }


	internal void .ctor(byte[] data, bool dates) { }

	public void .ctor(byte[] data) { }

	internal void .ctor(X509CertificateImpl impl) { }

	public void .ctor(X509Certificate cert) { }

	internal void ImportHandle(X509CertificateImpl impl) { }

	internal X509CertificateImpl get_Impl() { }

	internal bool get_IsValid() { }

	public virtual bool Equals(X509Certificate other) { }

	public virtual byte[] GetCertHash() { }

	public virtual string GetCertHashString() { }

	public override int GetHashCode() { }

	public virtual byte[] GetRawCertData() { }

	public virtual byte[] GetSerialNumber() { }

	public virtual string GetSerialNumberString() { }

	public override string ToString() { }

	public virtual string ToString(bool fVerbose) { }

	public void .ctor() { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	public string get_Issuer() { }

	public string get_Subject() { }

	[ComVisibleAttribute] 
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] 
	[ComVisibleAttribute] 
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODOAttribute] 
	[ComVisibleAttribute] 
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] 
	public virtual void Reset() { }

}

public class X509Certificate : ISerializable // TypeDefIndex: 1716
{
	private ASN1 decoder; 
	private byte[] m_encodedcert; 
	private DateTime m_from; 
	private DateTime m_until; 
	private ASN1 issuer; 
	private string m_issuername; 
	private string m_keyalgo; 
	private byte[] m_keyalgoparams; 
	private ASN1 subject; 
	private string m_subject; 
	private byte[] m_publickey; 
	private byte[] signature; 
	private string m_signaturealgo; 
	private byte[] m_signaturealgoparams; 
	private byte[] certhash; 
	private RSA _rsa; 
	private DSA _dsa; 
	private int version; 
	private byte[] serialnumber; 
	private byte[] issuerUniqueID; 
	private byte[] subjectUniqueID; 
	private X509ExtensionCollection extensions; 
	private static string encoding_error; 

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


	private void Parse(byte[] data) { }

	public void .ctor(byte[] data) { }

	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	public DSA get_DSA() { }

	public void set_DSA(DSA value) { }

	public X509ExtensionCollection get_Extensions() { }

	public byte[] get_Hash() { }

	public virtual string get_IssuerName() { }

	public virtual string get_KeyAlgorithm() { }

	public virtual byte[] get_KeyAlgorithmParameters() { }

	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	public virtual byte[] get_PublicKey() { }

	public virtual RSA get_RSA() { }

	public virtual void set_RSA(RSA value) { }

	public virtual byte[] get_RawData() { }

	public virtual byte[] get_SerialNumber() { }

	public virtual byte[] get_Signature() { }

	public virtual string get_SignatureAlgorithm() { }

	public virtual string get_SubjectName() { }

	public virtual DateTime get_ValidFrom() { }

	public virtual DateTime get_ValidUntil() { }

	public int get_Version() { }

	internal bool VerifySignature(DSA dsa) { }

	internal bool VerifySignature(RSA rsa) { }

	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	public ASN1 GetIssuerName() { }

	public ASN1 GetSubjectName() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static byte[] PEM(string type, byte[] data) { }

	private static void .cctor() { }

}

