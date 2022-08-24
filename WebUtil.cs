public static class WebUtil // TypeDefIndex: 6230
{
	internal static void Get(string url, Action<string> result) { }

	[IteratorStateMachineAttribute] // RVA: 0xAB230 Offset: 0xAA630 VA: 0x1800AB230
	private static IEnumerator DownloadStringCoroutine(UnityWebRequest www, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB330 Offset: 0xAA730 VA: 0x1800AB330
	public static Task<string> DownloadFileTemp(string url, bool keepextension) { }

	private static void DownloadString(UnityWebRequest www, Action<string> result) { }

	internal static void Post(string url, Dictionary<string, string> data, bool wait, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB4D0 Offset: 0xAA8D0 VA: 0x1800AB4D0
	internal static Task<string> PostAsync(string url, Dictionary<string, string> data) { }

	internal static void PostData(string url, object dataObject, Action<string> result, bool wait = False) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB6B0 Offset: 0xAAAB0 VA: 0x1800AB6B0
	internal static Task<string> PostDataAsync(string url, object dataObject) { }

	[IteratorStateMachineAttribute] // RVA: 0xAB900 Offset: 0xAAD00 VA: 0x1800AB900
	private static IEnumerator PostValuesCoroutine(WWW www, Action<string> result) { }

	internal static string Escape(string type) { }

}

private class WebUtil.AcceptAllCertificates : CertificateHandler // TypeDefIndex: 6231
{
	protected override bool ValidateCertificate(byte[] certificateData) { }

	public void .ctor() { }

}

private sealed class WebUtil.<DownloadStringCoroutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6232
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UnityWebRequest www; // 0x20
	public Action<string> result; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct WebUtil.<DownloadFileTemp>d__3 : IAsyncStateMachine // TypeDefIndex: 6233
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public bool keepextension; // 0x20
	public string url; // 0x28
	private string <targetName>5__2; // 0x30
	private FileInfo <fileInfo>5__3; // 0x38
	private UnityWebRequest <request>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostAsync>d__6 : IAsyncStateMachine // TypeDefIndex: 6234
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public string url; // 0x20
	public Dictionary<string, string> data; // 0x28
	private Stopwatch <waitTime>5__2; // 0x30
	private UnityWebRequest <request>5__3; // 0x38
	private TaskAwaiter <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostDataAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 6235
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public object dataObject; // 0x20
	public string url; // 0x28
	private UnityWebRequest <www>5__2; // 0x30
	private UnityWebRequestAsyncOperation <request>5__3; // 0x38
	private Stopwatch <waitTime>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class WebUtil.<PostValuesCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6236
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WWW www; // 0x20
	public Action<string> result; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

