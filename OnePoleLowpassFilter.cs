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

	// RVA: 0x9E6AC0 Offset: 0x9E50C0 VA: 0x1809E6AC0
	public void Update() { }

	// RVA: 0x9E6740 Offset: 0x9E4D40 VA: 0x1809E6740
	private void OnAudioFilterRead(float[] data, int channels) { }

	// RVA: 0x9E6920 Offset: 0x9E4F20 VA: 0x1809E6920
	private void SetupChannelData(int channels) { }

	// RVA: 0x9E6A20 Offset: 0x9E5020 VA: 0x1809E6A20
	private void UpdateFilterCoefficients() { }

	// RVA: 0x9E6BA0 Offset: 0x9E51A0 VA: 0x1809E6BA0
	public void .ctor() { }

}

private class OnePoleLowpassFilter.ChannelData // TypeDefIndex: 9016
{	// Fields
	public float out1; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

