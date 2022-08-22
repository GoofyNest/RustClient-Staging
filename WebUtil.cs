public static class WebUtil // TypeDefIndex: 6230
{	// Methods

	// RVA: 0x14BD180 Offset: 0x14BB780 VA: 0x1814BD180
	internal static void Get(string url, Action<string> result) { }

	[IteratorStateMachineAttribute] // RVA: 0xAB1B0 Offset: 0xAA5B0 VA: 0x1800AB1B0
	// RVA: 0x14BCF50 Offset: 0x14BB550 VA: 0x1814BCF50
	private static IEnumerator DownloadStringCoroutine(UnityWebRequest www, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB2F0 Offset: 0xAA6F0 VA: 0x1800AB2F0
	// RVA: 0x14BCE20 Offset: 0x14BB420 VA: 0x1814BCE20
	public static Task<string> DownloadFileTemp(string url, bool keepextension) { }

	// RVA: 0x14BCFE0 Offset: 0x14BB5E0 VA: 0x1814BCFE0
	private static void DownloadString(UnityWebRequest www, Action<string> result) { }

	// RVA: 0x14BD860 Offset: 0x14BBE60 VA: 0x1814BD860
	internal static void Post(string url, Dictionary<string, string> data, bool wait, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB480 Offset: 0xAA880 VA: 0x1800AB480
	// RVA: 0x14BD300 Offset: 0x14BB900 VA: 0x1814BD300
	internal static Task<string> PostAsync(string url, Dictionary<string, string> data) { }

	// RVA: 0x14BD540 Offset: 0x14BBB40 VA: 0x1814BD540
	internal static void PostData(string url, object dataObject, Action<string> result, bool wait = False) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB650 Offset: 0xAAA50 VA: 0x1800AB650
	// RVA: 0x14BD420 Offset: 0x14BBA20 VA: 0x1814BD420
	internal static Task<string> PostDataAsync(string url, object dataObject) { }

	[IteratorStateMachineAttribute] // RVA: 0xAB800 Offset: 0xAAC00 VA: 0x1800AB800
	// RVA: 0x14BD7D0 Offset: 0x14BBDD0 VA: 0x1814BD7D0
	private static IEnumerator PostValuesCoroutine(WWW www, Action<string> result) { }

	// RVA: 0x14BD170 Offset: 0x14BB770 VA: 0x1814BD170
	internal static string Escape(string type) { }

}

private class WebUtil.AcceptAllCertificates : CertificateHandler // TypeDefIndex: 6231
{	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 5
	protected override bool ValidateCertificate(byte[] certificateData) { }

	// RVA: 0x14A8300 Offset: 0x14A6900 VA: 0x1814A8300
	public void .ctor() { }

}

private sealed class WebUtil.<DownloadStringCoroutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6232
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UnityWebRequest www; // 0x20
	public Action<string> result; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14B94E0 Offset: 0x14B7AE0 VA: 0x1814B94E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B9840 Offset: 0x14B7E40 VA: 0x1814B9840 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct WebUtil.<DownloadFileTemp>d__3 : IAsyncStateMachine // TypeDefIndex: 6233
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public bool keepextension; // 0x20
	public string url; // 0x28
	private string <targetName>5__2; // 0x30
	private FileInfo <fileInfo>5__3; // 0x38
	private UnityWebRequest <request>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x1F1C60 Offset: 0x1F1060 VA: 0x1801F1C60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F1C70 Offset: 0x1F1070 VA: 0x1801F1C70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostAsync>d__6 : IAsyncStateMachine // TypeDefIndex: 6234
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public string url; // 0x20
	public Dictionary<string, string> data; // 0x28
	private Stopwatch <waitTime>5__2; // 0x30
	private UnityWebRequest <request>5__3; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1F1CC0 Offset: 0x1F10C0 VA: 0x1801F1CC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F1CD0 Offset: 0x1F10D0 VA: 0x1801F1CD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct WebUtil.<PostDataAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 6235
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public object dataObject; // 0x20
	public string url; // 0x28
	private UnityWebRequest <www>5__2; // 0x30
	private UnityWebRequestAsyncOperation <request>5__3; // 0x38
	private Stopwatch <waitTime>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x1F1D20 Offset: 0x1F1120 VA: 0x1801F1D20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F1D30 Offset: 0x1F1130 VA: 0x1801F1D30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class WebUtil.<PostValuesCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6236
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WWW www; // 0x20
	public Action<string> result; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14BA480 Offset: 0x14B8A80 VA: 0x1814BA480 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BA890 Offset: 0x14B8E90 VA: 0x1814BA890 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

