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

	// RVA: 0x108A640 Offset: 0x1088C40 VA: 0x18108A640
	public void .ctor() { }

	// RVA: 0x108A7D0 Offset: 0x1088DD0 VA: 0x18108A7D0
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public long get_MaxResponseContentBufferSize() { }

	// RVA: 0x108A8F0 Offset: 0x1088EF0 VA: 0x18108A8F0
	public void set_Timeout(TimeSpan value) { }

	// RVA: 0x1089AE0 Offset: 0x10880E0 VA: 0x181089AE0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1089B50 Offset: 0x1088150 VA: 0x181089B50
	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) { }

	// RVA: 0x1089DC0 Offset: 0x10883C0 VA: 0x181089DC0
	public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) { }

	// RVA: 0x108A520 Offset: 0x1088B20 VA: 0x18108A520
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	// RVA: 0x108A070 Offset: 0x1088670 VA: 0x18108A070
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) { }

	// RVA: 0x108A500 Offset: 0x1088B00 VA: 0x18108A500 Slot: 6
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x108A100 Offset: 0x1088700 VA: 0x18108A100
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1240 Offset: 0xD0640 VA: 0x1800D1240
	// RVA: 0x1089F30 Offset: 0x1088530 VA: 0x181089F30
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1380 Offset: 0xD0780 VA: 0x1800D1380
	// RVA: 0x1089CA0 Offset: 0x10882A0 VA: 0x181089CA0
	public Task<string> GetStringAsync(string requestUri) { }

	// RVA: 0x108A5D0 Offset: 0x1088BD0 VA: 0x18108A5D0
	private static void .cctor() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x108A5A0 Offset: 0x1088BA0 VA: 0x18108A5A0
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

	// RVA: 0x19E160 Offset: 0x19D560 VA: 0x18019E160 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E170 Offset: 0x19D570 VA: 0x18019E170 Slot: 5
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

	// RVA: 0x19DFD0 Offset: 0x19D3D0 VA: 0x18019DFD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DFE0 Offset: 0x19D3E0 VA: 0x18019DFE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

