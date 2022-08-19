public struct PhraseRecognizedEventArgs // TypeDefIndex: 3606
{	// Fields
	public readonly ConfidenceLevel confidence; // 0x0
	public readonly SemanticMeaning[] semanticMeanings; // 0x8
	public readonly string text; // 0x10
	public readonly DateTime phraseStartTime; // 0x18
	public readonly TimeSpan phraseDuration; // 0x20

	// Methods

	// RVA: 0x2356F0 Offset: 0x234AF0 VA: 0x1802356F0
	internal void .ctor(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }

}
