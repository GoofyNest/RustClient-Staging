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

	// RVA: 0x1090A30 Offset: 0x108F030 VA: 0x181090A30
	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Content(HttpContent value) { }

	// RVA: 0x1090AA0 Offset: 0x108F0A0 VA: 0x181090AA0
	public HttpResponseHeaders get_Headers() { }

	// RVA: 0x1090B50 Offset: 0x108F150 VA: 0x181090B50
	public bool get_IsSuccessStatusCode() { }

	// RVA: 0x1090B70 Offset: 0x108F170 VA: 0x181090B70
	public string get_ReasonPhrase() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ReasonPhrase(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_RequestMessage(HttpRequestMessage value) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x1090C00 Offset: 0x108F200 VA: 0x181090C00
	public void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x1090B90 Offset: 0x108F190 VA: 0x181090B90
	public Version get_Version() { }

	// RVA: 0x100F370 Offset: 0x100D970 VA: 0x18100F370 Slot: 4
	public void Dispose() { }

	// RVA: 0x1090720 Offset: 0x108ED20 VA: 0x181090720 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1090750 Offset: 0x108ED50 VA: 0x181090750
	public HttpResponseMessage EnsureSuccessStatusCode() { }

	// RVA: 0x1090810 Offset: 0x108EE10 VA: 0x181090810 Slot: 3
	public override string ToString() { }

}

