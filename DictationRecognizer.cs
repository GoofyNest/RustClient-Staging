public sealed class DictationRecognizer // TypeDefIndex: 3596
{	// Fields
	private IntPtr m_Recognizer; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private DictationRecognizer.DictationResultDelegate DictationResult; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private DictationRecognizer.DictationCompletedDelegate DictationComplete; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private DictationRecognizer.DictationErrorHandler DictationError; // 0x30

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178860 Offset: 0x2176E60 VA: 0x182178860
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178880 Offset: 0x2176E80 VA: 0x182178880
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178820 Offset: 0x2176E20 VA: 0x182178820
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178840 Offset: 0x2176E40 VA: 0x182178840
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }

}

public sealed class DictationRecognizer.DictationHypothesisDelegate : MulticastDelegate // TypeDefIndex: 3597
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A3B0 Offset: 0x4989B0 VA: 0x18049A3B0 Slot: 12
	public virtual void Invoke(string text) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationResultDelegate : MulticastDelegate // TypeDefIndex: 3598
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AA0CE0 Offset: 0x1A9F2E0 VA: 0x181AA0CE0 Slot: 12
	public virtual void Invoke(string text, ConfidenceLevel confidence) { }

	// RVA: 0x21788A0 Offset: 0x2176EA0 VA: 0x1821788A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, ConfidenceLevel confidence, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationCompletedDelegate : MulticastDelegate // TypeDefIndex: 3599
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19B57A0 Offset: 0x19B3DA0 VA: 0x1819B57A0 Slot: 12
	public virtual void Invoke(DictationCompletionCause cause) { }

	// RVA: 0x2178710 Offset: 0x2176D10 VA: 0x182178710 Slot: 13
	public virtual IAsyncResult BeginInvoke(DictationCompletionCause cause, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DictationRecognizer.DictationErrorHandler : MulticastDelegate // TypeDefIndex: 3600
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AA0CE0 Offset: 0x1A9F2E0 VA: 0x181AA0CE0 Slot: 12
	public virtual void Invoke(string error, int hresult) { }

	// RVA: 0x2178790 Offset: 0x2176D90 VA: 0x182178790 Slot: 13
	public virtual IAsyncResult BeginInvoke(string error, int hresult, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

