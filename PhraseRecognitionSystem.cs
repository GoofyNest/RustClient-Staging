public static class PhraseRecognitionSystem // TypeDefIndex: 3591
{	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private static PhraseRecognitionSystem.ErrorDelegate OnError; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged; // 0x8


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

public sealed class PhraseRecognitionSystem.ErrorDelegate : MulticastDelegate // TypeDefIndex: 3592
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(SpeechError errorCode) { }

	public virtual IAsyncResult BeginInvoke(SpeechError errorCode, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhraseRecognitionSystem.StatusDelegate : MulticastDelegate // TypeDefIndex: 3593
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(SpeechSystemStatus status) { }

	public virtual IAsyncResult BeginInvoke(SpeechSystemStatus status, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

