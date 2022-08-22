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

	// RVA: 0x1745BB0 Offset: 0x17441B0 VA: 0x181745BB0
	public void .ctor() { }

	// RVA: 0x1745980 Offset: 0x1743F80 VA: 0x181745980
	public void .ctor(string oid) { }

	// RVA: 0x1745C20 Offset: 0x1744220 VA: 0x181745C20
	public void .ctor(byte[] data) { }

	// RVA: 0x1745A10 Offset: 0x1744010 VA: 0x181745A10
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1745850 Offset: 0x1743E50 VA: 0x181745850
	public ASN1 get_ASN1() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ASN1 get_Content() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Content(ASN1 value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ContentType() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ContentType(string value) { }

	// RVA: 0x1745850 Offset: 0x1743E50 VA: 0x181745850
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

	// RVA: 0x1748500 Offset: 0x1746B00 VA: 0x181748500
	public void .ctor() { }

	// RVA: 0x1748520 Offset: 0x1746B20 VA: 0x181748520
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1748890 Offset: 0x1746E90 VA: 0x181748890
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

	// RVA: 0x1AB4230 Offset: 0x1AB2830 VA: 0x181AB4230
	public void .ctor() { }

	// RVA: 0x1AB42B0 Offset: 0x1AB28B0 VA: 0x181AB42B0
	public void .ctor(string oid) { }

	// RVA: 0x1AB42E0 Offset: 0x1AB28E0 VA: 0x181AB42E0
	public void .ctor(byte[] data) { }

	// RVA: 0x1AB4060 Offset: 0x1AB2660 VA: 0x181AB4060
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1AB4350 Offset: 0x1AB2950 VA: 0x181AB4350
	public ASN1 get_ASN1() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ASN1 get_Content() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Content(ASN1 value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ContentType() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ContentType(string value) { }

	// RVA: 0x1AB3EA0 Offset: 0x1AB24A0 VA: 0x181AB3EA0
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

	// RVA: 0x1748500 Offset: 0x1746B00 VA: 0x181748500
	public void .ctor() { }

	// RVA: 0x1AB4D00 Offset: 0x1AB3300 VA: 0x181AB4D00
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1AB5090 Offset: 0x1AB3690 VA: 0x181AB5090
	public byte[] get_EncryptedContent() { }

}

