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

	// RVA: 0x1090770 Offset: 0x108ED70 VA: 0x181090770
	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_Content(HttpContent value) { }

	// RVA: 0x10907E0 Offset: 0x108EDE0 VA: 0x1810907E0
	public HttpResponseHeaders get_Headers() { }

	// RVA: 0x1090890 Offset: 0x108EE90 VA: 0x181090890
	public bool get_IsSuccessStatusCode() { }

	// RVA: 0x10908B0 Offset: 0x108EEB0 VA: 0x1810908B0
	public string get_ReasonPhrase() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ReasonPhrase(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_RequestMessage(HttpRequestMessage value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x1090940 Offset: 0x108EF40 VA: 0x181090940
	public void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x10908D0 Offset: 0x108EED0 VA: 0x1810908D0
	public Version get_Version() { }

	// RVA: 0x100F0B0 Offset: 0x100D6B0 VA: 0x18100F0B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1090460 Offset: 0x108EA60 VA: 0x181090460 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1090490 Offset: 0x108EA90 VA: 0x181090490
	public HttpResponseMessage EnsureSuccessStatusCode() { }

	// RVA: 0x1090550 Offset: 0x108EB50 VA: 0x181090550 Slot: 3
	public override string ToString() { }

}

