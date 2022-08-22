public class HttpClientHandler : HttpMessageHandler // TypeDefIndex: 5740
{	// Fields
	private static long groupCounter; // 0x0
	private bool allowAutoRedirect; // 0x10
	private DecompressionMethods automaticDecompression; // 0x14
	private CookieContainer cookieContainer; // 0x18
	private ICredentials credentials; // 0x20
	private int maxAutomaticRedirections; // 0x28
	private long maxRequestContentBufferSize; // 0x30
	private bool preAuthenticate; // 0x38
	private IWebProxy proxy; // 0x40
	private bool useCookies; // 0x48
	private bool useDefaultCredentials; // 0x49
	private bool useProxy; // 0x4A
	private bool sentRequest; // 0x4B
	private string connectionGroupName; // 0x50
	private bool disposed; // 0x58

	// Properties
	public CookieContainer CookieContainer { get; }
	public long MaxRequestContentBufferSize { get; }

	// Methods

	// RVA: 0x108A440 Offset: 0x1088A40 VA: 0x18108A440
	public void .ctor() { }

	// RVA: 0x108A4E0 Offset: 0x1088AE0 VA: 0x18108A4E0
	public CookieContainer get_CookieContainer() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public long get_MaxRequestContentBufferSize() { }

	// RVA: 0x108A1D0 Offset: 0x10887D0 VA: 0x18108A1D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1089760 Offset: 0x1087D60 VA: 0x181089760 Slot: 7
	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	// RVA: 0x10894F0 Offset: 0x1087AF0 VA: 0x1810894F0
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	// RVA: 0x108A250 Offset: 0x1088850 VA: 0x18108A250
	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachineAttribute] // RVA: 0xD17D0 Offset: 0xD0BD0 VA: 0x1800D17D0
	// RVA: 0x108A310 Offset: 0x1088910 VA: 0x18108A310 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private sealed class HttpClientHandler.<>c // TypeDefIndex: 5741
{	// Fields
	public static readonly HttpClientHandler.<>c <>9; // 0x0
	public static Func<string, bool> <>9__61_0; // 0x8
	public static Action<object> <>9__64_0; // 0x10

	// Methods

	// RVA: 0x109BC10 Offset: 0x109A210 VA: 0x18109BC10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109B7A0 Offset: 0x1099DA0 VA: 0x18109B7A0
	internal bool <CreateWebRequest>b__61_0(string l) { }

	// RVA: 0x109B7E0 Offset: 0x1099DE0 VA: 0x18109B7E0
	internal void <SendAsync>b__64_0(object l) { }

}

private struct HttpClientHandler.<SendAsync>d__64 : IAsyncStateMachine // TypeDefIndex: 5742
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public HttpClientHandler <>4__this; // 0x20
	public HttpRequestMessage request; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private HttpWebRequest <wrequest>5__1; // 0x38
	private HttpContent <content>5__2; // 0x40
	private Stream <stream>5__3; // 0x48
	private HttpWebResponse <wresponse>5__4; // 0x50
	private CancellationTokenRegistration <>7__wrap1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x80
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__3; // 0x90
	private TaskAwaiter<HttpResponseMessage> <>u__4; // 0xA0

	// Methods

	// RVA: 0x19DDF0 Offset: 0x19D1F0 VA: 0x18019DDF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DE00 Offset: 0x19D200 VA: 0x18019DE00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

