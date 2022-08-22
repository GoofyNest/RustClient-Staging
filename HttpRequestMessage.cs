public class HttpRequestMessage : IDisposable // TypeDefIndex: 5754
{	// Fields
	private HttpRequestHeaders headers; // 0x10
	private HttpMethod method; // 0x18
	private Version version; // 0x20
	private Uri uri; // 0x28
	private bool is_used; // 0x30
	private bool disposed; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HttpContent <Content>k__BackingField; // 0x38

	// Properties
	public HttpContent Content { get; set; }
	public HttpRequestHeaders Headers { get; }
	public HttpMethod Method { get; set; }
	public Uri RequestUri { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x108FE60 Offset: 0x108E460 VA: 0x18108FE60
	public void .ctor(HttpMethod method, string requestUri) { }

	// RVA: 0x108FF80 Offset: 0x108E580 VA: 0x18108FF80
	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void set_Content(HttpContent value) { }

	// RVA: 0x1090040 Offset: 0x108E640 VA: 0x181090040
	public HttpRequestHeaders get_Headers() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public HttpMethod get_Method() { }

	// RVA: 0x1090160 Offset: 0x108E760 VA: 0x181090160
	public void set_Method(HttpMethod value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Uri get_RequestUri() { }

	// RVA: 0x1090200 Offset: 0x108E800 VA: 0x181090200
	public void set_RequestUri(Uri value) { }

	// RVA: 0x108FA70 Offset: 0x108E070 VA: 0x18108FA70
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	// RVA: 0x10900F0 Offset: 0x108E6F0 VA: 0x1810900F0
	public Version get_Version() { }

	// RVA: 0x100F0B0 Offset: 0x100D6B0 VA: 0x18100F0B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x108FA40 Offset: 0x108E040 VA: 0x18108FA40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108FBE0 Offset: 0x108E1E0 VA: 0x18108FBE0
	internal bool SetIsUsed() { }

	// RVA: 0x108FBF0 Offset: 0x108E1F0 VA: 0x18108FBF0 Slot: 3
	public override string ToString() { }

}

