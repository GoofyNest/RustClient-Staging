public class SampleBuffer : ABuffer // TypeDefIndex: 7396
{	// Fields
	private readonly short[] _Buffer; // 0x10
	private readonly int[] _Bufferp; // 0x18
	private readonly int _Channels; // 0x20
	private readonly int _Frequency; // 0x24

	// Methods

	// RVA: 0x2262F10 Offset: 0x2261510 VA: 0x182262F10
	internal void .ctor(int sampleFrequency, int numberOfChannels) { }

	// RVA: 0x2262E30 Offset: 0x2261430 VA: 0x182262E30 Slot: 4
	protected override void Append(int channel, short valueRenamed) { }

	// RVA: 0x2262D30 Offset: 0x2261330 VA: 0x182262D30 Slot: 5
	internal override void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	internal override void WriteBuffer(int val) { }

	// RVA: 0x2262EC0 Offset: 0x22614C0 VA: 0x182262EC0 Slot: 7
	internal override void ClearBuffer() { }

}

