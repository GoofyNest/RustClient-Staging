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

	// RVA: 0x108B0B0 Offset: 0x10896B0 VA: 0x18108B0B0
	public void .ctor() { }

	// RVA: 0x108B240 Offset: 0x1089840 VA: 0x18108B240
	public void .ctor(HttpMessageHandler handler, bool disposeHandler) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public long get_MaxResponseContentBufferSize() { }

	// RVA: 0x108B360 Offset: 0x1089960 VA: 0x18108B360
	public void set_Timeout(TimeSpan value) { }

	// RVA: 0x108A550 Offset: 0x1088B50 VA: 0x18108A550 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x108A5C0 Offset: 0x1088BC0 VA: 0x18108A5C0
	public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) { }

	// RVA: 0x108A830 Offset: 0x1088E30 VA: 0x18108A830
	public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) { }

	// RVA: 0x108AF90 Offset: 0x1089590 VA: 0x18108AF90
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { }

	// RVA: 0x108AAE0 Offset: 0x10890E0 VA: 0x18108AAE0
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) { }

	// RVA: 0x108AF70 Offset: 0x1089570 VA: 0x18108AF70 Slot: 6
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x108AB70 Offset: 0x1089170 VA: 0x18108AB70
	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1240 Offset: 0xD0640 VA: 0x1800D1240
	// RVA: 0x108A9A0 Offset: 0x1088FA0 VA: 0x18108A9A0
	private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1380 Offset: 0xD0780 VA: 0x1800D1380
	// RVA: 0x108A710 Offset: 0x1088D10 VA: 0x18108A710
	public Task<string> GetStringAsync(string requestUri) { }

	// RVA: 0x108B040 Offset: 0x1089640 VA: 0x18108B040
	private static void .cctor() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x108B010 Offset: 0x1089610 VA: 0x18108B010
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

	// RVA: 0x19DE50 Offset: 0x19D250 VA: 0x18019DE50 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DE60 Offset: 0x19D260 VA: 0x18019DE60 Slot: 5
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

	// RVA: 0x19DCC0 Offset: 0x19D0C0 VA: 0x18019DCC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DCD0 Offset: 0x19D0D0 VA: 0x18019DCD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

