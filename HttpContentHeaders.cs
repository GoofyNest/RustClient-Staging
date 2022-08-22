public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 5772
{	// Fields
	private readonly HttpContent content; // 0x20

	// Properties
	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }

	// Methods

	// RVA: 0x108AA30 Offset: 0x1089030 VA: 0x18108AA30
	internal void .ctor(HttpContent content) { }

	// RVA: 0x108AAB0 Offset: 0x10890B0 VA: 0x18108AAB0
	public Nullable<long> get_ContentLength() { }

	// RVA: 0x108AC50 Offset: 0x1089250 VA: 0x18108AC50
	public MediaTypeHeaderValue get_ContentType() { }

	// RVA: 0x108AC90 Offset: 0x1089290 VA: 0x18108AC90
	public void set_ContentType(MediaTypeHeaderValue value) { }

}

