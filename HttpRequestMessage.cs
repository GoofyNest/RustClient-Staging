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

	// RVA: 0x1090120 Offset: 0x108E720 VA: 0x181090120
	public void .ctor(HttpMethod method, string requestUri) { }

	// RVA: 0x1090240 Offset: 0x108E840 VA: 0x181090240
	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void set_Content(HttpContent value) { }

	// RVA: 0x1090300 Offset: 0x108E900 VA: 0x181090300
	public HttpRequestHeaders get_Headers() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public HttpMethod get_Method() { }

	// RVA: 0x1090420 Offset: 0x108EA20 VA: 0x181090420
	public void set_Method(HttpMethod value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Uri get_RequestUri() { }

	// RVA: 0x10904C0 Offset: 0x108EAC0 VA: 0x1810904C0
	public void set_RequestUri(Uri value) { }

	// RVA: 0x108FD30 Offset: 0x108E330 VA: 0x18108FD30
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	// RVA: 0x10903B0 Offset: 0x108E9B0 VA: 0x1810903B0
	public Version get_Version() { }

	// RVA: 0x100F370 Offset: 0x100D970 VA: 0x18100F370 Slot: 4
	public void Dispose() { }

	// RVA: 0x108FD00 Offset: 0x108E300 VA: 0x18108FD00 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108FEA0 Offset: 0x108E4A0 VA: 0x18108FEA0
	internal bool SetIsUsed() { }

	// RVA: 0x108FEB0 Offset: 0x108E4B0 VA: 0x18108FEB0 Slot: 3
	public override string ToString() { }

}

