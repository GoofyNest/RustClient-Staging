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

	// RVA: 0x2282C80 Offset: 0x2281280 VA: 0x182282C80
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x2282CE0 Offset: 0x22812E0 VA: 0x182282CE0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x2282D20 Offset: 0x2281320 VA: 0x182282D20
	public ArrayList get_Crls() { }

	// RVA: 0x2282B30 Offset: 0x2281130 VA: 0x182282B30
	private byte[] Load(string filename) { }

	// RVA: 0x22829A0 Offset: 0x2280FA0 VA: 0x1822829A0
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x2282A10 Offset: 0x2281010 VA: 0x182282A10
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x2282910 Offset: 0x2280F10 VA: 0x182282910
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x2282680 Offset: 0x2280C80 VA: 0x182282680
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x22827D0 Offset: 0x2280DD0 VA: 0x1822827D0
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

	// RVA: 0x14DC7F0 Offset: 0x14DADF0 VA: 0x1814DC7F0
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x14DC930 Offset: 0x14DAF30 VA: 0x1814DC930
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x14DC9D0 Offset: 0x14DAFD0 VA: 0x1814DC9D0
	private X509Stores get_Factory() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal X509Store get_Store() { }

	// RVA: 0x14DC490 Offset: 0x14DAA90 VA: 0x1814DC490
	public void Close() { }

	// RVA: 0x14DC490 Offset: 0x14DAA90 VA: 0x1814DC490 Slot: 4
	public void Dispose() { }

	// RVA: 0x14DC4D0 Offset: 0x14DAAD0 VA: 0x1814DC4D0
	public void Open(OpenFlags flags) { }

}

