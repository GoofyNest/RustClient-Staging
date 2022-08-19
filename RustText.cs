public class RustText : TextMeshProUGUI, ILocalize // TypeDefIndex: 7033
{	// Fields
	public bool IsLocalized; // 0xB80
	public string Token; // 0xB88
	[TextAreaAttribute] // RVA: 0x72110 Offset: 0x71510 VA: 0x180072110
	public string English; // 0xB90
	public Translate.Phrase Phrase; // 0xB98
	[FormerlySerializedAsAttribute] // RVA: 0x722B0 Offset: 0x716B0 VA: 0x1800722B0
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

	// RVA: 0xFD04F0 Offset: 0xFCEAF0 VA: 0x180FD04F0 Slot: 135
	public string get_LanguageToken() { }

	// RVA: 0xFD04E0 Offset: 0xFCEAE0 VA: 0x180FD04E0 Slot: 136
	public string get_LanguageEnglish() { }

	// RVA: 0xFD02E0 Offset: 0xFCE8E0 VA: 0x180FD02E0
	public void SetPhrase(Translate.Phrase phrase) { }

	// RVA: 0xFCFAB0 Offset: 0xFCE0B0 VA: 0x180FCFAB0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD02B0 Offset: 0xFCE8B0 VA: 0x180FD02B0
	public void SetPhraseArguments(object[] args) { }

	// RVA: 0xFD0360 Offset: 0xFCE960 VA: 0x180FD0360
	public void SetText(string str) { }

	// RVA: 0xFCFAE0 Offset: 0xFCE0E0 VA: 0x180FCFAE0
	public void DoAutoSize() { }

	// RVA: 0xFD0230 Offset: 0xFCE830 VA: 0x180FD0230 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xFD0070 Offset: 0xFCE670 VA: 0x180FD0070
	private string GetLocalizedText(bool englishVersion) { }

	// RVA: 0xFD0390 Offset: 0xFCE990 VA: 0x180FD0390
	private void UpdateLocalizedText(bool forceEnglish) { }

	// RVA: 0xFD01A0 Offset: 0xFCE7A0 VA: 0x180FD01A0
	public static void OnLanguageChanged() { }

	// RVA: 0xFD04C0 Offset: 0xFCEAC0 VA: 0x180FD04C0
	public void .ctor() { }

}

