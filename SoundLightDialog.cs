public class SoundLightDialog : UIDialog // TypeDefIndex: 10908
{	// Fields
	public RustOption ColourOption; // 0x30
	public RustOption VolumeOption; // 0x38
	public RustOption SpeedOption; // 0x40
	public RustOption PatternOption; // 0x48
	public RustOption GradientOption; // 0x50
	private AudioVisualisationEntity targetEntity; // 0x58

	// Methods

	// RVA: 0xA76430 Offset: 0xA74A30 VA: 0x180A76430
	public void SetLight(AudioVisualisationEntity entity) { }

	// RVA: 0xA761A0 Offset: 0xA747A0 VA: 0x180A761A0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0xA763D0 Offset: 0xA749D0 VA: 0x180A763D0
	private int GetValueFromOption(RustOption option, int defaultValue = 0) { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

