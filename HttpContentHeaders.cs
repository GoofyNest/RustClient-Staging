public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 5772
{	// Fields
	private readonly HttpContent content; // 0x20

	// Properties
	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }

	// Methods

	// RVA: 0x108A770 Offset: 0x1088D70 VA: 0x18108A770
	internal void .ctor(HttpContent content) { }

	// RVA: 0x108A7F0 Offset: 0x1088DF0 VA: 0x18108A7F0
	public Nullable<long> get_ContentLength() { }

	// RVA: 0x108A990 Offset: 0x1088F90 VA: 0x18108A990
	public MediaTypeHeaderValue get_ContentType() { }

	// RVA: 0x108A9D0 Offset: 0x1088FD0 VA: 0x18108A9D0
	public void set_ContentType(MediaTypeHeaderValue value) { }

}

