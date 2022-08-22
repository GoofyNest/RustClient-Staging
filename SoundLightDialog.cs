public class SoundLightDialog : UIDialog // TypeDefIndex: 10908
{	// Fields
	public RustOption ColourOption; // 0x30
	public RustOption VolumeOption; // 0x38
	public RustOption SpeedOption; // 0x40
	public RustOption PatternOption; // 0x48
	public RustOption GradientOption; // 0x50
	private AudioVisualisationEntity targetEntity; // 0x58

	// Methods

	// RVA: 0xA76900 Offset: 0xA74F00 VA: 0x180A76900
	public void SetLight(AudioVisualisationEntity entity) { }

	// RVA: 0xA76670 Offset: 0xA74C70 VA: 0x180A76670 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0xA768A0 Offset: 0xA74EA0 VA: 0x180A768A0
	private int GetValueFromOption(RustOption option, int defaultValue = 0) { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

