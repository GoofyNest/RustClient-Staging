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

	// RVA: 0x22B6D50 Offset: 0x22B5350 VA: 0x1822B6D50
	public void .ctor() { }

	// RVA: 0x22B6BD0 Offset: 0x22B51D0 VA: 0x1822B6BD0
	public void .ctor(Uri uri) { }

	// RVA: 0x22B6110 Offset: 0x22B4710 VA: 0x1822B6110
	private void Init(Uri uri) { }

	// RVA: 0x22B6F20 Offset: 0x22B5520 VA: 0x1822B6F20
	public void set_Host(string value) { }

	// RVA: 0x22B6FF0 Offset: 0x22B55F0 VA: 0x1822B6FF0
	public void set_Path(string value) { }

	// RVA: 0x22B70A0 Offset: 0x22B56A0 VA: 0x1822B70A0
	public void set_Query(string value) { }

	// RVA: 0x22B7140 Offset: 0x22B5740 VA: 0x1822B7140
	public void set_Scheme(string value) { }

	// RVA: 0x22B6E80 Offset: 0x22B5480 VA: 0x1822B6E80
	public Uri get_Uri() { }

	// RVA: 0x22B6070 Offset: 0x22B4670 VA: 0x1822B6070 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x22B60E0 Offset: 0x22B46E0 VA: 0x1822B60E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22B62F0 Offset: 0x22B48F0 VA: 0x1822B62F0
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x22B64B0 Offset: 0x22B4AB0 VA: 0x1822B64B0 Slot: 3
	public override string ToString() { }

}

