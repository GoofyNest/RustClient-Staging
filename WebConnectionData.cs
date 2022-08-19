internal class WebConnectionData // TypeDefIndex: 3030
{	// Fields
	private HttpWebRequest _request; // 0x10
	public int StatusCode; // 0x18
	public string StatusDescription; // 0x20
	public WebHeaderCollection Headers; // 0x28
	public Version Version; // 0x30
	public Version ProxyVersion; // 0x38
	public Stream stream; // 0x40
	public string[] Challenge; // 0x48
	private ReadState _readState; // 0x50

	// Properties
	public HttpWebRequest request { get; set; }
	public ReadState ReadState { get; set; }

	// Methods

	// RVA: 0x117E9C0 Offset: 0x117CFC0 VA: 0x18117E9C0
	public void .ctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(HttpWebRequest request) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public HttpWebRequest get_request() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_request(HttpWebRequest value) { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	public ReadState get_ReadState() { }

	// RVA: 0x117E9E0 Offset: 0x117CFE0 VA: 0x18117E9E0
	public void set_ReadState(ReadState value) { }

}

