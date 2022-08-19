public class HttpClient : HttpMessageInvoker // TypeDefIndex: 5737
{	// Fields
	private static readonly TimeSpan TimeoutDefault; // 0x0
	private Uri base_address; // 0x20
	private CancellationTokenSource cts; // 0x28
	private bool disposed; // 0x30
	private HttpRequestHeaders headers; // 0x38
	private long buffer_size; // 0x40
	private TimeSpan timeout; // 0x48

	// Properties
	public long MaxResponseContentBufferSize { get; }
	public TimeSpan Timeout { set; }

	// Methods

	// RVA: 0x108A380 Offset: 0x1088980 VA: 0x18108A380
	public void .ctor() { }

	// RVA: 0x108A510 Offset: 0x1088B10 VA: 0x18108A510
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public long get_MaxResponseContentBufferSize() { }

	// RVA: 0x108A630 Offset: 0x1088C30 VA: 0x18108A630
	public void set_Timeout(TimeSpan value) { }

	// RVA: 0x1089820 Offset: 0x1087E20 VA: 0x181089820 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1089890 Offset: 0x1087E90 VA: 0x181089890
	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) { }

	// RVA: 0x1089B00 Offset: 0x1088100 VA: 0x181089B00
	public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) { }

	// RVA: 0x108A260 Offset: 0x1088860 VA: 0x18108A260
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	// RVA: 0x1089DB0 Offset: 0x10883B0 VA: 0x181089DB0
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) { }

	// RVA: 0x108A240 Offset: 0x1088840 VA: 0x18108A240 Slot: 6
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x1089E40 Offset: 0x1088440 VA: 0x181089E40
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD11B0 Offset: 0xD05B0 VA: 0x1800D11B0
	// RVA: 0x1089C70 Offset: 0x1088270 VA: 0x181089C70
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD12F0 Offset: 0xD06F0 VA: 0x1800D12F0
	// RVA: 0x10899E0 Offset: 0x1087FE0 VA: 0x1810899E0
	public Task<string> GetStringAsync(string requestUri) { }

	// RVA: 0x108A310 Offset: 0x1088910 VA: 0x18108A310
	private static void .cctor() { }

	[DebuggerHiddenAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x108A2E0 Offset: 0x10888E0 VA: 0x18108A2E0
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }

}

private struct HttpClient.<SendAsyncWorker>d__47 : IAsyncStateMachine // TypeDefIndex: 5738
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public HttpRequestMessage request; // 0x30
	public HttpCompletionOption completionOption; // 0x38
	private HttpResponseMessage <response>5__1; // 0x40
	private CancellationTokenSource <lcts>5__2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x19E1E0 Offset: 0x19D5E0 VA: 0x18019E1E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E1F0 Offset: 0x19D5F0 VA: 0x18019E1F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpClient.<GetStringAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 5739
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpClient <>4__this; // 0x20
	public string requestUri; // 0x28
	private HttpResponseMessage <resp>5__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; // 0x48

	// Methods

	// RVA: 0x19E050 Offset: 0x19D450 VA: 0x18019E050 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E060 Offset: 0x19D460 VA: 0x18019E060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

