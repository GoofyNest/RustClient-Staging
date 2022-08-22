public class PieOption : MonoBehaviour // TypeDefIndex: 11200
{	// Fields
	public PieShape background; // 0x18
	public Image imageIcon; // 0x20

	// Properties
	internal float midRadius { get; }
	internal float sliceSize { get; }

	// Methods

	// RVA: 0x90D690 Offset: 0x90BC90 VA: 0x18090D690
	internal float get_midRadius() { }

	// RVA: 0x90D6C0 Offset: 0x90BCC0 VA: 0x18090D6C0
	internal float get_sliceSize() { }

	// RVA: 0x90D2E0 Offset: 0x90B8E0 VA: 0x18090D2E0
	public void UpdateOption(float startSlice, float sliceSize, float border, string optionTitle, float outerSize, float innerSize, float imageSize, Sprite sprite) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

