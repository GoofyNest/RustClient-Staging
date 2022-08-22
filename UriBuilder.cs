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

	// RVA: 0x22B6B90 Offset: 0x22B5190 VA: 0x1822B6B90
	public void .ctor() { }

	// RVA: 0x22B6A10 Offset: 0x22B5010 VA: 0x1822B6A10
	public void .ctor(Uri uri) { }

	// RVA: 0x22B5F50 Offset: 0x22B4550 VA: 0x1822B5F50
	private void Init(Uri uri) { }

	// RVA: 0x22B6D60 Offset: 0x22B5360 VA: 0x1822B6D60
	public void set_Host(string value) { }

	// RVA: 0x22B6E30 Offset: 0x22B5430 VA: 0x1822B6E30
	public void set_Path(string value) { }

	// RVA: 0x22B6EE0 Offset: 0x22B54E0 VA: 0x1822B6EE0
	public void set_Query(string value) { }

	// RVA: 0x22B6F80 Offset: 0x22B5580 VA: 0x1822B6F80
	public void set_Scheme(string value) { }

	// RVA: 0x22B6CC0 Offset: 0x22B52C0 VA: 0x1822B6CC0
	public Uri get_Uri() { }

	// RVA: 0x22B5EB0 Offset: 0x22B44B0 VA: 0x1822B5EB0 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x22B5F20 Offset: 0x22B4520 VA: 0x1822B5F20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22B6130 Offset: 0x22B4730 VA: 0x1822B6130
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x22B62F0 Offset: 0x22B48F0 VA: 0x1822B62F0 Slot: 3
	public override string ToString() { }

}

