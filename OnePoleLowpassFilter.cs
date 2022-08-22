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

	// RVA: 0x9E6FB0 Offset: 0x9E55B0 VA: 0x1809E6FB0
	public void Update() { }

	// RVA: 0x9E6C30 Offset: 0x9E5230 VA: 0x1809E6C30
	private void OnAudioFilterRead(float[] data, int channels) { }

	// RVA: 0x9E6E10 Offset: 0x9E5410 VA: 0x1809E6E10
	private void SetupChannelData(int channels) { }

	// RVA: 0x9E6F10 Offset: 0x9E5510 VA: 0x1809E6F10
	private void UpdateFilterCoefficients() { }

	// RVA: 0x9E7090 Offset: 0x9E5690 VA: 0x1809E7090
	public void .ctor() { }

}

private class OnePoleLowpassFilter.ChannelData // TypeDefIndex: 9016
{	// Fields
	public float out1; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

