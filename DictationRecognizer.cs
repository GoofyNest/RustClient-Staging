public sealed class DictationRecognizer // TypeDefIndex: 3596
{	private IntPtr m_Recognizer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private DictationRecognizer.DictationResultDelegate DictationResult; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private DictationRecognizer.DictationCompletedDelegate DictationComplete; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private DictationRecognizer.DictationErrorHandler DictationError; // 0x30


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }

}

public sealed class DictationRecognizer.DictationHypothesisDelegate : MulticastDelegate // TypeDefIndex: 3597
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string text) { }

	public virtual IAsyncResult BeginInvoke(string text, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationResultDelegate : MulticastDelegate // TypeDefIndex: 3598
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string text, ConfidenceLevel confidence) { }

	public virtual IAsyncResult BeginInvoke(string text, ConfidenceLevel confidence, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationCompletedDelegate : MulticastDelegate // TypeDefIndex: 3599
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(DictationCompletionCause cause) { }

	public virtual IAsyncResult BeginInvoke(DictationCompletionCause cause, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationErrorHandler : MulticastDelegate // TypeDefIndex: 3600
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string error, int hresult) { }

	public virtual IAsyncResult BeginInvoke(string error, int hresult, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

