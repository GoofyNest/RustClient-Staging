public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 5778
{	// Fields
	private Nullable<bool> expectContinue; // 0x20

	// Properties
	public HttpHeaderValueCollection<string> Connection { get; }
	public Nullable<bool> ConnectionClose { get; }
	internal bool ConnectionKeepAlive { get; }
	public Nullable<bool> ExpectContinue { get; }
	public string Host { get; }
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
	public Nullable<bool> TransferEncodingChunked { get; }

	// Methods

	// RVA: 0x108F600 Offset: 0x108DC00 VA: 0x18108F600
	internal void .ctor() { }

	// RVA: 0x108F940 Offset: 0x108DF40 VA: 0x18108F940
	public HttpHeaderValueCollection<string> get_Connection() { }

	// RVA: 0x108F660 Offset: 0x108DC60 VA: 0x18108F660
	public Nullable<bool> get_ConnectionClose() { }

	// RVA: 0x108F800 Offset: 0x108DE00 VA: 0x18108F800
	internal bool get_ConnectionKeepAlive() { }

	// RVA: 0x108F980 Offset: 0x108DF80 VA: 0x18108F980
	public Nullable<bool> get_ExpectContinue() { }

	// RVA: 0x108FB00 Offset: 0x108E100 VA: 0x18108FB00
	public string get_Host() { }

	// RVA: 0x108FCC0 Offset: 0x108E2C0 VA: 0x18108FCC0
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	// RVA: 0x108FB40 Offset: 0x108E140 VA: 0x18108FB40
	public Nullable<bool> get_TransferEncodingChunked() { }

	// RVA: 0x108F430 Offset: 0x108DA30 VA: 0x18108F430
	internal void AddHeaders(HttpRequestHeaders headers) { }

}

private sealed class HttpRequestHeaders.<>c // TypeDefIndex: 5779
{	// Fields
	public static readonly HttpRequestHeaders.<>c <>9; // 0x0
	public static Predicate<string> <>9__19_0; // 0x8
	public static Predicate<string> <>9__22_0; // 0x10
	public static Predicate<TransferCodingHeaderValue> <>9__29_0; // 0x18
	public static Predicate<TransferCodingHeaderValue> <>9__71_0; // 0x20

	// Methods

	// RVA: 0x109B0E0 Offset: 0x10996E0 VA: 0x18109B0E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AFC0 Offset: 0x10995C0 VA: 0x18109AFC0
	internal bool <get_ConnectionClose>b__19_0(string l) { }

	// RVA: 0x109B000 Offset: 0x1099600 VA: 0x18109B000
	internal bool <get_ConnectionKeepAlive>b__22_0(string l) { }

	// RVA: 0x109B040 Offset: 0x1099640 VA: 0x18109B040
	internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

	// RVA: 0x109B090 Offset: 0x1099690 VA: 0x18109B090
	internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }

}

