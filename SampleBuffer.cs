public class SampleBuffer : ABuffer // TypeDefIndex: 7396
{	// Fields
	private readonly short[] _Buffer; // 0x10
	private readonly int[] _Bufferp; // 0x18
	private readonly int _Channels; // 0x20
	private readonly int _Frequency; // 0x24

	// Methods

	// RVA: 0x22639F0 Offset: 0x2261FF0 VA: 0x1822639F0
	internal void .ctor(int sampleFrequency, int numberOfChannels) { }

	// RVA: 0x2263910 Offset: 0x2261F10 VA: 0x182263910 Slot: 4
	protected override void Append(int channel, short valueRenamed) { }

	// RVA: 0x2263810 Offset: 0x2261E10 VA: 0x182263810 Slot: 5
	internal override void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal override void WriteBuffer(int val) { }

	// RVA: 0x22639A0 Offset: 0x2261FA0 VA: 0x1822639A0 Slot: 7
	internal override void ClearBuffer() { }

}

