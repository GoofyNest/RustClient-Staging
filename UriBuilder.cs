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

	// RVA: 0x22B6E50 Offset: 0x22B5450 VA: 0x1822B6E50
	public void .ctor() { }

	// RVA: 0x22B6CD0 Offset: 0x22B52D0 VA: 0x1822B6CD0
	public void .ctor(Uri uri) { }

	// RVA: 0x22B6210 Offset: 0x22B4810 VA: 0x1822B6210
	private void Init(Uri uri) { }

	// RVA: 0x22B7020 Offset: 0x22B5620 VA: 0x1822B7020
	public void set_Host(string value) { }

	// RVA: 0x22B70F0 Offset: 0x22B56F0 VA: 0x1822B70F0
	public void set_Path(string value) { }

	// RVA: 0x22B71A0 Offset: 0x22B57A0 VA: 0x1822B71A0
	public void set_Query(string value) { }

	// RVA: 0x22B7240 Offset: 0x22B5840 VA: 0x1822B7240
	public void set_Scheme(string value) { }

	// RVA: 0x22B6F80 Offset: 0x22B5580 VA: 0x1822B6F80
	public Uri get_Uri() { }

	// RVA: 0x22B6170 Offset: 0x22B4770 VA: 0x1822B6170 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x22B61E0 Offset: 0x22B47E0 VA: 0x1822B61E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22B63F0 Offset: 0x22B49F0 VA: 0x1822B63F0
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x22B65B0 Offset: 0x22B4BB0 VA: 0x1822B65B0 Slot: 3
	public override string ToString() { }

}

