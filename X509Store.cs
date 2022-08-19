public class X509Store // TypeDefIndex: 1721
{	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x2282B80 Offset: 0x2281180 VA: 0x182282B80
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x2282BE0 Offset: 0x22811E0 VA: 0x182282BE0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x2282C20 Offset: 0x2281220 VA: 0x182282C20
	public ArrayList get_Crls() { }

	// RVA: 0x2282A30 Offset: 0x2281030 VA: 0x182282A30
	private byte[] Load(string filename) { }

	// RVA: 0x22828A0 Offset: 0x2280EA0 VA: 0x1822828A0
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x2282910 Offset: 0x2280F10 VA: 0x182282910
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x2282810 Offset: 0x2280E10 VA: 0x182282810
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x2282580 Offset: 0x2280B80 VA: 0x182282580
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x22826D0 Offset: 0x2280CD0 VA: 0x1822826D0
	private ArrayList BuildCrlsCollection(string storeName) { }

}

public sealed class X509Store : IDisposable // TypeDefIndex: 2837
{	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }

	// Methods

	// RVA: 0x14DC530 Offset: 0x14DAB30 VA: 0x1814DC530
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x14DC670 Offset: 0x14DAC70 VA: 0x1814DC670
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x14DC710 Offset: 0x14DAD10 VA: 0x1814DC710
	private X509Stores get_Factory() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal X509Store get_Store() { }

	// RVA: 0x14DC1D0 Offset: 0x14DA7D0 VA: 0x1814DC1D0
	public void Close() { }

	// RVA: 0x14DC1D0 Offset: 0x14DA7D0 VA: 0x1814DC1D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14DC210 Offset: 0x14DA810 VA: 0x1814DC210
	public void Open(OpenFlags flags) { }

}

