public class PieOption : MonoBehaviour // TypeDefIndex: 11200
{	// Fields
	public PieShape background; // 0x18
	public Image imageIcon; // 0x20

	// Properties
	internal float midRadius { get; }
	internal float sliceSize { get; }

	// Methods

	// RVA: 0x90D580 Offset: 0x90BB80 VA: 0x18090D580
	internal float get_midRadius() { }

	// RVA: 0x90D5B0 Offset: 0x90BBB0 VA: 0x18090D5B0
	internal float get_sliceSize() { }

	// RVA: 0x90D1D0 Offset: 0x90B7D0 VA: 0x18090D1D0
	public void UpdateOption(float startSlice, float sliceSize, float border, string optionTitle, float outerSize, float innerSize, float imageSize, Sprite sprite) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

