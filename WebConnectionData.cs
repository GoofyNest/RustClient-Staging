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

	// RVA: 0x11835A0 Offset: 0x1181BA0 VA: 0x1811835A0
	public void .ctor() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(HttpWebRequest request) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public HttpWebRequest get_request() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_request(HttpWebRequest value) { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	public ReadState get_ReadState() { }

	// RVA: 0x11835C0 Offset: 0x1181BC0 VA: 0x1811835C0
	public void set_ReadState(ReadState value) { }

}

