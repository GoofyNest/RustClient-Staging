public class UriBuilder // TypeDefIndex: 2564
{	// Fields
	private bool _changed; // 0x10
	private string _fragment; // 0x18
	private string _host; // 0x20
	private string _password; // 0x28
	private string _path; // 0x30
	private int _port; // 0x38
	private string _query; // 0x40
	private string _scheme; // 0x48
	private string _schemeDelimiter; // 0x50
	private Uri _uri; // 0x58
	private string _username; // 0x60

	// Properties
	public string Host { set; }
	public string Path { set; }
	public string Query { set; }
	public string Scheme { set; }
	public Uri Uri { get; }

	// Methods

	// RVA: 0x22B7670 Offset: 0x22B5C70 VA: 0x1822B7670
	public void .ctor() { }

	// RVA: 0x22B74F0 Offset: 0x22B5AF0 VA: 0x1822B74F0
	public void .ctor(Uri uri) { }

	// RVA: 0x22B6A30 Offset: 0x22B5030 VA: 0x1822B6A30
	private void Init(Uri uri) { }

	// RVA: 0x22B7840 Offset: 0x22B5E40 VA: 0x1822B7840
	public void set_Host(string value) { }

	// RVA: 0x22B7910 Offset: 0x22B5F10 VA: 0x1822B7910
	public void set_Path(string value) { }

	// RVA: 0x22B79C0 Offset: 0x22B5FC0 VA: 0x1822B79C0
	public void set_Query(string value) { }

	// RVA: 0x22B7A60 Offset: 0x22B6060 VA: 0x1822B7A60
	public void set_Scheme(string value) { }

	// RVA: 0x22B77A0 Offset: 0x22B5DA0 VA: 0x1822B77A0
	public Uri get_Uri() { }

	// RVA: 0x22B6990 Offset: 0x22B4F90 VA: 0x1822B6990 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x22B6A00 Offset: 0x22B5000 VA: 0x1822B6A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22B6C10 Offset: 0x22B5210 VA: 0x1822B6C10
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x22B6DD0 Offset: 0x22B53D0 VA: 0x1822B6DD0 Slot: 3
	public override string ToString() { }

}

