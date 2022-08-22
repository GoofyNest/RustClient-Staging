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

	// RVA: 0x10899D0 Offset: 0x1087FD0 VA: 0x1810899D0
	public void .ctor() { }

	// RVA: 0x1089A70 Offset: 0x1088070 VA: 0x181089A70
	public CookieContainer get_CookieContainer() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public long get_MaxRequestContentBufferSize() { }

	// RVA: 0x1089760 Offset: 0x1087D60 VA: 0x181089760 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1088CF0 Offset: 0x10872F0 VA: 0x181088CF0 Slot: 7
	internal virtual HttpWebRequest CreateWebRequest(HttpRequestMessage request) { }

	// RVA: 0x1088A80 Offset: 0x1087080 VA: 0x181088A80
	private HttpResponseMessage CreateResponseMessage(HttpWebResponse wr, HttpRequestMessage requestMessage, CancellationToken cancellationToken) { }

	// RVA: 0x10897E0 Offset: 0x1087DE0 VA: 0x1810897E0
	private static bool MethodHasBody(HttpMethod method) { }

	[AsyncStateMachineAttribute] // RVA: 0xD17D0 Offset: 0xD0BD0 VA: 0x1800D17D0
	// RVA: 0x10898A0 Offset: 0x1087EA0 VA: 0x1810898A0 Slot: 6
	protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private sealed class HttpClientHandler.<>c // TypeDefIndex: 5741
{	// Fields
	public static readonly HttpClientHandler.<>c <>9; // 0x0
	public static Func<string, bool> <>9__61_0; // 0x8
	public static Action<object> <>9__64_0; // 0x10

	// Methods

	// RVA: 0x109B1A0 Offset: 0x10997A0 VA: 0x18109B1A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AD30 Offset: 0x1099330 VA: 0x18109AD30
	internal bool <CreateWebRequest>b__61_0(string l) { }

	// RVA: 0x109AD70 Offset: 0x1099370 VA: 0x18109AD70
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

	// RVA: 0x19E100 Offset: 0x19D500 VA: 0x18019E100 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E110 Offset: 0x19D510 VA: 0x18019E110 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

