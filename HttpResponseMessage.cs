public class HttpResponseMessage : IDisposable // TypeDefIndex: 5755
{	// Fields
	private HttpResponseHeaders headers; // 0x10
	private string reasonPhrase; // 0x18
	private HttpStatusCode statusCode; // 0x20
	private Version version; // 0x28
	private bool disposed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HttpContent <Content>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HttpRequestMessage <RequestMessage>k__BackingField; // 0x40

	// Properties
	public HttpContent Content { get; set; }
	public HttpResponseHeaders Headers { get; }
	public bool IsSuccessStatusCode { get; }
	public string ReasonPhrase { get; set; }
	public HttpRequestMessage RequestMessage { set; }
	public HttpStatusCode StatusCode { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x10914A0 Offset: 0x108FAA0 VA: 0x1810914A0
	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Content(HttpContent value) { }

	// RVA: 0x1091510 Offset: 0x108FB10 VA: 0x181091510
	public HttpResponseHeaders get_Headers() { }

	// RVA: 0x10915C0 Offset: 0x108FBC0 VA: 0x1810915C0
	public bool get_IsSuccessStatusCode() { }

	// RVA: 0x10915E0 Offset: 0x108FBE0 VA: 0x1810915E0
	public string get_ReasonPhrase() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_ReasonPhrase(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_RequestMessage(HttpRequestMessage value) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x1091670 Offset: 0x108FC70 VA: 0x181091670
	public void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x1091600 Offset: 0x108FC00 VA: 0x181091600
	public Version get_Version() { }

	// RVA: 0x100FE10 Offset: 0x100E410 VA: 0x18100FE10 Slot: 4
	public void Dispose() { }

	// RVA: 0x1091190 Offset: 0x108F790 VA: 0x181091190 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x10911C0 Offset: 0x108F7C0 VA: 0x1810911C0
	public HttpResponseMessage EnsureSuccessStatusCode() { }

	// RVA: 0x1091280 Offset: 0x108F880 VA: 0x181091280 Slot: 3
	public override string ToString() { }

}

