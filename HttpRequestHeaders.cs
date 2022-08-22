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

	// RVA: 0x1090070 Offset: 0x108E670 VA: 0x181090070
	internal void .ctor() { }

	// RVA: 0x10903B0 Offset: 0x108E9B0 VA: 0x1810903B0
	public HttpHeaderValueCollection<string> get_Connection() { }

	// RVA: 0x10900D0 Offset: 0x108E6D0 VA: 0x1810900D0
	public Nullable<bool> get_ConnectionClose() { }

	// RVA: 0x1090270 Offset: 0x108E870 VA: 0x181090270
	internal bool get_ConnectionKeepAlive() { }

	// RVA: 0x10903F0 Offset: 0x108E9F0 VA: 0x1810903F0
	public Nullable<bool> get_ExpectContinue() { }

	// RVA: 0x1090570 Offset: 0x108EB70 VA: 0x181090570
	public string get_Host() { }

	// RVA: 0x1090730 Offset: 0x108ED30 VA: 0x181090730
	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	// RVA: 0x10905B0 Offset: 0x108EBB0 VA: 0x1810905B0
	public Nullable<bool> get_TransferEncodingChunked() { }

	// RVA: 0x108FEA0 Offset: 0x108E4A0 VA: 0x18108FEA0
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

	// RVA: 0x109BB50 Offset: 0x109A150 VA: 0x18109BB50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109BA30 Offset: 0x109A030 VA: 0x18109BA30
	internal bool <get_ConnectionClose>b__19_0(string l) { }

	// RVA: 0x109BA70 Offset: 0x109A070 VA: 0x18109BA70
	internal bool <get_ConnectionKeepAlive>b__22_0(string l) { }

	// RVA: 0x109BAB0 Offset: 0x109A0B0 VA: 0x18109BAB0
	internal bool <get_ExpectContinue>b__29_0(TransferCodingHeaderValue l) { }

	// RVA: 0x109BB00 Offset: 0x109A100 VA: 0x18109BB00
	internal bool <get_TransferEncodingChunked>b__71_0(TransferCodingHeaderValue l) { }

}

