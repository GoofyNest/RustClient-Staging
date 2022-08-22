public class OnePoleLowpassFilter : MonoBehaviour // TypeDefIndex: 9015
{	// Fields
	[RangeAttribute] // RVA: 0xCAD30 Offset: 0xCA130 VA: 0x1800CAD30
	public float frequency; // 0x18
	private int sampleRate; // 0x1C
	private float c; // 0x20
	private float a1; // 0x24
	private float b1; // 0x28
	private OnePoleLowpassFilter.ChannelData[] channelData; // 0x30
	private float prevFrequency; // 0x38

	// Methods

	// RVA: 0x9E6800 Offset: 0x9E4E00 VA: 0x1809E6800
	public void Update() { }

	// RVA: 0x9E6480 Offset: 0x9E4A80 VA: 0x1809E6480
	private void OnAudioFilterRead(float[] data, int channels) { }

	// RVA: 0x9E6660 Offset: 0x9E4C60 VA: 0x1809E6660
	private void SetupChannelData(int channels) { }

	// RVA: 0x9E6760 Offset: 0x9E4D60 VA: 0x1809E6760
	private void UpdateFilterCoefficients() { }

	// RVA: 0x9E68E0 Offset: 0x9E4EE0 VA: 0x1809E68E0
	public void .ctor() { }

}

private class OnePoleLowpassFilter.ChannelData // TypeDefIndex: 9016
{	// Fields
	public float out1; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

