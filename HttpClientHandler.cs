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

	// RVA: 0x1089710 Offset: 0x1087D10 VA: 0x181089710
	public void .ctor() { }

	// RVA: 0x10897B0 Offset: 0x1087DB0 VA: 0x1810897B0
	public CookieContainer get_CookieContainer() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public long get_MaxRequestContentBufferSize() { }

	// RVA: 0x10894A0 Offset: 0x1087AA0 VA: 0x1810894A0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1088A30 Offset: 0x1087030 VA: 0x181088A30 Slot: 7
	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	// RVA: 0x10887C0 Offset: 0x1086DC0 VA: 0x1810887C0
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	// RVA: 0x1089520 Offset: 0x1087B20 VA: 0x181089520
	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1740 Offset: 0xD0B40 VA: 0x1800D1740
	// RVA: 0x10895E0 Offset: 0x1087BE0 VA: 0x1810895E0 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private sealed class HttpClientHandler.<>c // TypeDefIndex: 5741
{	// Fields
	public static readonly HttpClientHandler.<>c <>9; // 0x0
	public static Func<string, bool> <>9__61_0; // 0x8
	public static Action<object> <>9__64_0; // 0x10

	// Methods

	// RVA: 0x109AEE0 Offset: 0x10994E0 VA: 0x18109AEE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AA70 Offset: 0x1099070 VA: 0x18109AA70
	internal bool <CreateWebRequest>b__61_0(string l) { }

	// RVA: 0x109AAB0 Offset: 0x10990B0 VA: 0x18109AAB0
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

	// RVA: 0x19E180 Offset: 0x19D580 VA: 0x18019E180 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E190 Offset: 0x19D590 VA: 0x18019E190 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

