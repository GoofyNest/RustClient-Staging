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

	// RVA: 0x4D4270 Offset: 0x4D2870 VA: 0x1804D4270 Slot: 4
	protected override void Init() { }

	// RVA: 0x4C27F0 Offset: 0x4C0DF0 VA: 0x1804C27F0
	protected void OnEnable() { }

	// RVA: 0x4D42A0 Offset: 0x4D28A0 VA: 0x1804D42A0
	public void OnValueChanged() { }

	// RVA: 0x4D4190 Offset: 0x4D2790 VA: 0x1804D4190
	public void ChangeValue(int change) { }

	// RVA: 0x4D4300 Offset: 0x4D2900 VA: 0x1804D4300 Slot: 9
	protected override void SetConvarValue() { }

	// RVA: 0x4D42C0 Offset: 0x4D28C0 VA: 0x1804D42C0 Slot: 8
	public override void ResetToConvar() { }

	// RVA: 0x4D4390 Offset: 0x4D2990 VA: 0x1804D4390
	private void ShowValue(string value) { }

	// RVA: 0x4D4140 Offset: 0x4D2740 VA: 0x1804D4140
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

