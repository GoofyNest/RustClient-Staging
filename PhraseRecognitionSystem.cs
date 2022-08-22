public static class PhraseRecognitionSystem // TypeDefIndex: 3591
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static PhraseRecognitionSystem.ErrorDelegate OnError; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179DD0 Offset: 0x21783D0 VA: 0x182179DD0
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179E20 Offset: 0x2178420 VA: 0x182179E20
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

public sealed class PhraseRecognitionSystem.ErrorDelegate : MulticastDelegate // TypeDefIndex: 3592
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19B57A0 Offset: 0x19B3DA0 VA: 0x1819B57A0 Slot: 12
	public virtual void Invoke(SpeechError errorCode) { }

	// RVA: 0x21789E0 Offset: 0x2176FE0 VA: 0x1821789E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(SpeechError errorCode, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhraseRecognitionSystem.StatusDelegate : MulticastDelegate // TypeDefIndex: 3593
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19B57A0 Offset: 0x19B3DA0 VA: 0x1819B57A0 Slot: 12
	public virtual void Invoke(SpeechSystemStatus status) { }

	// RVA: 0x217A6E0 Offset: 0x2178CE0 VA: 0x18217A6E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(SpeechSystemStatus status, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

