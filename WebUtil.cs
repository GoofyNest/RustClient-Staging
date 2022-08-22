public static class WebUtil // TypeDefIndex: 6230
{	// Methods

	// RVA: 0x14BDDF0 Offset: 0x14BC3F0 VA: 0x1814BDDF0
	internal static void Get(string url, Action<string> result) { }

	[IteratorStateMachineAttribute] // RVA: 0xAB1B0 Offset: 0xAA5B0 VA: 0x1800AB1B0
	// RVA: 0x14BDBC0 Offset: 0x14BC1C0 VA: 0x1814BDBC0
	private static IEnumerator DownloadStringCoroutine(UnityWebRequest www, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB2F0 Offset: 0xAA6F0 VA: 0x1800AB2F0
	// RVA: 0x14BDA90 Offset: 0x14BC090 VA: 0x1814BDA90
	public static Task<string> DownloadFileTemp(string url, bool keepextension) { }

	// RVA: 0x14BDC50 Offset: 0x14BC250 VA: 0x1814BDC50
	private static void DownloadString(UnityWebRequest www, Action<string> result) { }

	// RVA: 0x14BE4D0 Offset: 0x14BCAD0 VA: 0x1814BE4D0
	internal static void Post(string url, Dictionary<string, string> data, bool wait, Action<string> result) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB480 Offset: 0xAA880 VA: 0x1800AB480
	// RVA: 0x14BDF70 Offset: 0x14BC570 VA: 0x1814BDF70
	internal static Task<string> PostAsync(string url, Dictionary<string, string> data) { }

	// RVA: 0x14BE1B0 Offset: 0x14BC7B0 VA: 0x1814BE1B0
	internal static void PostData(string url, object dataObject, Action<string> result, bool wait = False) { }

	[AsyncStateMachineAttribute] // RVA: 0xAB650 Offset: 0xAAA50 VA: 0x1800AB650
	// RVA: 0x14BE090 Offset: 0x14BC690 VA: 0x1814BE090
	internal static Task<string> PostDataAsync(string url, object dataObject) { }

	[IteratorStateMachineAttribute] // RVA: 0xAB800 Offset: 0xAAC00 VA: 0x1800AB800
	// RVA: 0x14BE440 Offset: 0x14BCA40 VA: 0x1814BE440
	private static IEnumerator PostValuesCoroutine(WWW www, Action<string> result) { }

	// RVA: 0x14BDDE0 Offset: 0x14BC3E0 VA: 0x1814BDDE0
	internal static string Escape(string type) { }

}

private class WebUtil.AcceptAllCertificates : CertificateHandler // TypeDefIndex: 6231
{	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 5
	protected override bool ValidateCertificate(byte[] certificateData) { }

	// RVA: 0x14A8F70 Offset: 0x14A7570 VA: 0x1814A8F70
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

	// RVA: 0x14BA150 Offset: 0x14B8750 VA: 0x1814BA150 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BA4B0 Offset: 0x14B8AB0 VA: 0x1814BA4B0 Slot: 8
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

	// RVA: 0x1F1840 Offset: 0x1F0C40 VA: 0x1801F1840 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F1850 Offset: 0x1F0C50 VA: 0x1801F1850 Slot: 5
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

	// RVA: 0x1F18A0 Offset: 0x1F0CA0 VA: 0x1801F18A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F18B0 Offset: 0x1F0CB0 VA: 0x1801F18B0 Slot: 5
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

	// RVA: 0x1F1900 Offset: 0x1F0D00 VA: 0x1801F1900 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F1910 Offset: 0x1F0D10 VA: 0x1801F1910 Slot: 5
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

	// RVA: 0x14BB0F0 Offset: 0x14B96F0 VA: 0x1814BB0F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14BB500 Offset: 0x14B9B00 VA: 0x1814BB500 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

