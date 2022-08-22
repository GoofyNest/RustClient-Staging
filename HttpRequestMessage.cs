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

	// RVA: 0x1090B90 Offset: 0x108F190 VA: 0x181090B90
	public void .ctor(HttpMethod method, string requestUri) { }

	// RVA: 0x1090CB0 Offset: 0x108F2B0 VA: 0x181090CB0
	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void set_Content(HttpContent value) { }

	// RVA: 0x1090D70 Offset: 0x108F370 VA: 0x181090D70
	public HttpRequestHeaders get_Headers() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public HttpMethod get_Method() { }

	// RVA: 0x1090E90 Offset: 0x108F490 VA: 0x181090E90
	public void set_Method(HttpMethod value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Uri get_RequestUri() { }

	// RVA: 0x1090F30 Offset: 0x108F530 VA: 0x181090F30
	public void set_RequestUri(Uri value) { }

	// RVA: 0x10907A0 Offset: 0x108EDA0 VA: 0x1810907A0
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	// RVA: 0x1090E20 Offset: 0x108F420 VA: 0x181090E20
	public Version get_Version() { }

	// RVA: 0x100FE10 Offset: 0x100E410 VA: 0x18100FE10 Slot: 4
	public void Dispose() { }

	// RVA: 0x1090770 Offset: 0x108ED70 VA: 0x181090770 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1090910 Offset: 0x108EF10 VA: 0x181090910
	internal bool SetIsUsed() { }

	// RVA: 0x1090920 Offset: 0x108EF20 VA: 0x181090920 Slot: 3
	public override string ToString() { }

}

