public class RustText : TextMeshProUGUI, ILocalize // TypeDefIndex: 7033
{	// Fields
	public bool IsLocalized; // 0xB80
	public string Token; // 0xB88
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string English; // 0xB90
	public Translate.Phrase Phrase; // 0xB98
	[FormerlySerializedAsAttribute] // RVA: 0x723B0 Offset: 0x717B0 VA: 0x1800723B0
	public bool AutoSetWidth; // 0xBA0
	public bool AutoSetHeight; // 0xBA1
	public bool AutoSizeParent; // 0xBA2
	public float MinWidth; // 0xBA4
	public float MaxWidth; // 0xBA8
	private object[] localizationArguments; // 0xBB0

	// Properties
	public string LanguageToken { get; }
	public string LanguageEnglish { get; }

	// Methods

	// RVA: 0xFD07B0 Offset: 0xFCEDB0 VA: 0x180FD07B0 Slot: 135
	public string get_LanguageToken() { }

	// RVA: 0xFD07A0 Offset: 0xFCEDA0 VA: 0x180FD07A0 Slot: 136
	public string get_LanguageEnglish() { }

	// RVA: 0xFD05A0 Offset: 0xFCEBA0 VA: 0x180FD05A0
	public void SetPhrase(Translate.Phrase phrase) { }

	// RVA: 0xFCFD70 Offset: 0xFCE370 VA: 0x180FCFD70 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD0570 Offset: 0xFCEB70 VA: 0x180FD0570
	public void SetPhraseArguments(object[] args) { }

	// RVA: 0xFD0620 Offset: 0xFCEC20 VA: 0x180FD0620
	public void SetText(string str) { }

	// RVA: 0xFCFDA0 Offset: 0xFCE3A0 VA: 0x180FCFDA0
	public void DoAutoSize() { }

	// RVA: 0xFD04F0 Offset: 0xFCEAF0 VA: 0x180FD04F0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xFD0330 Offset: 0xFCE930 VA: 0x180FD0330
	private string GetLocalizedText(bool englishVersion) { }

	// RVA: 0xFD0650 Offset: 0xFCEC50 VA: 0x180FD0650
	private void UpdateLocalizedText(bool forceEnglish) { }

	// RVA: 0xFD0460 Offset: 0xFCEA60 VA: 0x180FD0460
	public static void OnLanguageChanged() { }

	// RVA: 0xFD0780 Offset: 0xFCED80 VA: 0x180FD0780
	public void .ctor() { }

}

