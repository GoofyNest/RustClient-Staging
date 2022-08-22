public class SampleBuffer : ABuffer // TypeDefIndex: 7396
{	// Fields
	private readonly short[] _Buffer; // 0x10
	private readonly int[] _Bufferp; // 0x18
	private readonly int _Channels; // 0x20
	private readonly int _Frequency; // 0x24

	// Methods

	// RVA: 0x22631D0 Offset: 0x22617D0 VA: 0x1822631D0
	internal void .ctor(int sampleFrequency, int numberOfChannels) { }

	// RVA: 0x22630F0 Offset: 0x22616F0 VA: 0x1822630F0 Slot: 4
	protected override void Append(int channel, short valueRenamed) { }

	// RVA: 0x2262FF0 Offset: 0x22615F0 VA: 0x182262FF0 Slot: 5
	internal override void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal override void WriteBuffer(int val) { }

	// RVA: 0x2263180 Offset: 0x2261780 VA: 0x182263180 Slot: 7
	internal override void ClearBuffer() { }

}

