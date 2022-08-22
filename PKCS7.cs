public class PKCS7.ContentInfo // TypeDefIndex: 49
{
// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 49
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x17458F0 Offset: 0x1743EF0 VA: 0x1817458F0
	public void .ctor() { }

	// RVA: 0x17456C0 Offset: 0x1743CC0 VA: 0x1817456C0
	public void .ctor(string oid) { }

	// RVA: 0x1745960 Offset: 0x1743F60 VA: 0x181745960
	public void .ctor(byte[] data) { }

	// RVA: 0x1745750 Offset: 0x1743D50 VA: 0x181745750
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1745590 Offset: 0x1743B90 VA: 0x181745590
	public ASN1 get_ASN1() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ASN1 get_Content() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Content(ASN1 value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ContentType() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ContentType(string value) { }

	// RVA: 0x1745590 Offset: 0x1743B90 VA: 0x181745590
	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 50
{	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x1748240 Offset: 0x1746840 VA: 0x181748240
	public void .ctor() { }

	// RVA: 0x1748260 Offset: 0x1746860 VA: 0x181748260
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x17485D0 Offset: 0x1746BD0 VA: 0x1817485D0
	public byte[] get_EncryptedContent() { }

}

public class PKCS7.ContentInfo // TypeDefIndex: 1708
{
// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 1708
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x1AB3F70 Offset: 0x1AB2570 VA: 0x181AB3F70
	public void .ctor() { }

	// RVA: 0x1AB3FF0 Offset: 0x1AB25F0 VA: 0x181AB3FF0
	public void .ctor(string oid) { }

	// RVA: 0x1AB4020 Offset: 0x1AB2620 VA: 0x181AB4020
	public void .ctor(byte[] data) { }

	// RVA: 0x1AB3DA0 Offset: 0x1AB23A0 VA: 0x181AB3DA0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1AB4090 Offset: 0x1AB2690 VA: 0x181AB4090
	public ASN1 get_ASN1() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ASN1 get_Content() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Content(ASN1 value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ContentType() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ContentType(string value) { }

	// RVA: 0x1AB3BE0 Offset: 0x1AB21E0 VA: 0x181AB3BE0
	internal ASN1 GetASN1() { }

}

public class PKCS7.EncryptedData // TypeDefIndex: 1709
{	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x1748240 Offset: 0x1746840 VA: 0x181748240
	public void .ctor() { }

	// RVA: 0x1AB4A40 Offset: 0x1AB3040 VA: 0x181AB4A40
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1AB4DD0 Offset: 0x1AB33D0 VA: 0x181AB4DD0
	public byte[] get_EncryptedContent() { }

}

