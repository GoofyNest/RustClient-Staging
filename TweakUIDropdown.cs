public class TweakUIDropdown : TweakUIBase // TypeDefIndex: 11144
{	// Fields
	public Button Left; // 0x30
	public Button Right; // 0x38
	public TextMeshProUGUI Current; // 0x40
	public Image BackgroundImage; // 0x48
	public TweakUIDropdown.NameValue[] nameValues; // 0x50
	public bool assignImageColor; // 0x58
	public int currentValue; // 0x5C

	// Methods

	// RVA: 0x4D42E0 Offset: 0x4D28E0 VA: 0x1804D42E0 Slot: 4
	protected override void Init() { }

	// RVA: 0x4C2860 Offset: 0x4C0E60 VA: 0x1804C2860
	protected void OnEnable() { }

	// RVA: 0x4D4310 Offset: 0x4D2910 VA: 0x1804D4310
	public void OnValueChanged() { }

	// RVA: 0x4D4200 Offset: 0x4D2800 VA: 0x1804D4200
	public void ChangeValue(int change) { }

	// RVA: 0x4D4370 Offset: 0x4D2970 VA: 0x1804D4370 Slot: 9
	protected override void SetConvarValue() { }

	// RVA: 0x4D4330 Offset: 0x4D2930 VA: 0x1804D4330 Slot: 8
	public override void ResetToConvar() { }

	// RVA: 0x4D4400 Offset: 0x4D2A00 VA: 0x1804D4400
	private void ShowValue(string value) { }

	// RVA: 0x4D41B0 Offset: 0x4D27B0 VA: 0x1804D41B0
	public void .ctor() { }

}

public class TweakUIDropdown.NameValue // TypeDefIndex: 11145
{	// Fields
	public string value; // 0x10
	public Color imageColor; // 0x18
	public Translate.Phrase label; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

