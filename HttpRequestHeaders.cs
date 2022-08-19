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

	// RVA: 0x108F340 Offset: 0x108D940 VA: 0x18108F340
	internal void .ctor() { }

	// RVA: 0x108F680 Offset: 0x108DC80 VA: 0x18108F680
	public HttpHeaderValueCollection<string> get_Connection() { }

	// RVA: 0x108F3A0 Offset: 0x108D9A0 VA: 0x18108F3A0
	public Nullable<bool> get_ConnectionClose() { }

	// RVA: 0x108F540 Offset: 0x108DB40 VA: 0x18108F540
	internal bool get_ConnectionKeepAlive() { }

	// RVA: 0x108F6C0 Offset: 0x108DCC0 VA: 0x18108F6C0
	public Nullable<bool> get_ExpectContinue() { }

	// RVA: 0x108F840 Offset: 0x108DE40 VA: 0x18108F840
	public string get_Host() { }

	// RVA: 0x108FA00 Offset: 0x108E000 VA: 0x18108FA00
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	// RVA: 0x108F880 Offset: 0x108DE80 VA: 0x18108F880
	public Nullable<bool> get_TransferEncodingChunked() { }

	// RVA: 0x108F170 Offset: 0x108D770 VA: 0x18108F170
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

	// RVA: 0x109AE20 Offset: 0x1099420 VA: 0x18109AE20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AD00 Offset: 0x1099300 VA: 0x18109AD00
	internal bool <get_ConnectionClose>b__19_0(string l) { }

	// RVA: 0x109AD40 Offset: 0x1099340 VA: 0x18109AD40
	internal bool <get_ConnectionKeepAlive>b__22_0(string l) { }

	// RVA: 0x109AD80 Offset: 0x1099380 VA: 0x18109AD80
	internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

	// RVA: 0x109ADD0 Offset: 0x10993D0 VA: 0x18109ADD0
	internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }

}

