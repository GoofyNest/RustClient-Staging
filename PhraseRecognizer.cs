public abstract class PhraseRecognizer // TypeDefIndex: 3594
{	protected IntPtr m_Recognizer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }

}

public sealed class PhraseRecognizer.PhraseRecognizedDelegate : MulticastDelegate // TypeDefIndex: 3595
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhraseRecognizedEventArgs args) { }

	public virtual IAsyncResult BeginInvoke(PhraseRecognizedEventArgs args, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

