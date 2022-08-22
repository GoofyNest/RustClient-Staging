public class LocalizeText : MonoBehaviour, IClientComponent, ILocalize // TypeDefIndex: 11276
{	// Fields
	public string token; // 0x18
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string english; // 0x20
	public string append; // 0x28
	public LocalizeText.SpecialMode specialMode; // 0x30
	private object[] Tokens; // 0x38

	// Properties
	public string LanguageToken { get; set; }
	public string LanguageEnglish { get; set; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	public string get_LanguageToken() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_LanguageToken(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 5
	public string get_LanguageEnglish() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_LanguageEnglish(string value) { }

	// RVA: 0x4FE750 Offset: 0x4FCD50 VA: 0x1804FE750
	private string GetText(bool englishVersion) { }

	// RVA: 0x4FE740 Offset: 0x4FCD40 VA: 0x1804FE740
	private void Awake() { }

	// RVA: 0x4FE740 Offset: 0x4FCD40 VA: 0x1804FE740
	public void RebuildText() { }

	// RVA: 0x4FEE80 Offset: 0x4FD480 VA: 0x1804FEE80
	private void UpdateText(bool forceEnglish) { }

	// RVA: 0x4FE900 Offset: 0x4FCF00 VA: 0x1804FE900
	public void SetToken(int i, object token) { }

	// RVA: 0x4FEBA0 Offset: 0x4FD1A0 VA: 0x1804FEBA0
	public void SetTokens(object[] tokens) { }

	// RVA: 0x4FE870 Offset: 0x4FCE70 VA: 0x1804FE870
	public static void OnLanguageChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum LocalizeText.SpecialMode // TypeDefIndex: 11277
{	// Fields
	public int value__; // 0x0
	public const LocalizeText.SpecialMode None = 0;
	public const LocalizeText.SpecialMode AllUppercase = 1;
	public const LocalizeText.SpecialMode AllLowercase = 2;

}

