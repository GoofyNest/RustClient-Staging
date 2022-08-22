public sealed class HttpContentHeaders : HttpHeaders // TypeDefIndex: 5772
{	// Fields
	private readonly HttpContent content; // 0x20

	// Properties
	public Nullable<long> ContentLength { get; }
	public MediaTypeHeaderValue ContentType { get; set; }

	// Methods

	// RVA: 0x108B4A0 Offset: 0x1089AA0 VA: 0x18108B4A0
	internal void .ctor(HttpContent content) { }

	// RVA: 0x108B520 Offset: 0x1089B20 VA: 0x18108B520
	public Nullable<long> get_ContentLength() { }

	// RVA: 0x108B6C0 Offset: 0x1089CC0 VA: 0x18108B6C0
	public MediaTypeHeaderValue get_ContentType() { }

	// RVA: 0x108B700 Offset: 0x1089D00 VA: 0x18108B700
	public void set_ContentType(MediaTypeHeaderValue value) { }

}

