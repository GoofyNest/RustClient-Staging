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

	// RVA: 0xFD1250 Offset: 0xFCF850 VA: 0x180FD1250 Slot: 135
	public string get_LanguageToken() { }

	// RVA: 0xFD1240 Offset: 0xFCF840 VA: 0x180FD1240 Slot: 136
	public string get_LanguageEnglish() { }

	// RVA: 0xFD1040 Offset: 0xFCF640 VA: 0x180FD1040
	public void SetPhrase(Translate.Phrase phrase) { }

	// RVA: 0xFD0810 Offset: 0xFCEE10 VA: 0x180FD0810 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD1010 Offset: 0xFCF610 VA: 0x180FD1010
	public void SetPhraseArguments(object[] args) { }

	// RVA: 0xFD10C0 Offset: 0xFCF6C0 VA: 0x180FD10C0
	public void SetText(string str) { }

	// RVA: 0xFD0840 Offset: 0xFCEE40 VA: 0x180FD0840
	public void DoAutoSize() { }

	// RVA: 0xFD0F90 Offset: 0xFCF590 VA: 0x180FD0F90 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xFD0DD0 Offset: 0xFCF3D0 VA: 0x180FD0DD0
	private string GetLocalizedText(bool englishVersion) { }

	// RVA: 0xFD10F0 Offset: 0xFCF6F0 VA: 0x180FD10F0
	private void UpdateLocalizedText(bool forceEnglish) { }

	// RVA: 0xFD0F00 Offset: 0xFCF500 VA: 0x180FD0F00
	public static void OnLanguageChanged() { }

	// RVA: 0xFD1220 Offset: 0xFCF820 VA: 0x180FD1220
	public void .ctor() { }

}

