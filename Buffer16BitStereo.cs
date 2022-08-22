public class Buffer16BitStereo : ABuffer // TypeDefIndex: 7377
{
// Namespace: MP3Sharp
public class Buffer16BitStereo : ABuffer // TypeDefIndex: 7377
	// Fields
	internal bool DoubleMonoToStereo; // 0x10
	private const int OUTPUT_CHANNELS = 2;
	private readonly byte[] _Buffer; // 0x18
	private readonly int[] _BufferChannelOffsets; // 0x20
	private int _End; // 0x28
	private int _Offset; // 0x2C

	// Properties
	internal int BytesLeft { get; }

	// Methods

	// RVA: 0x5DC1F0 Offset: 0x5DA7F0 VA: 0x1805DC1F0
	internal void .ctor() { }

	// RVA: 0x5DC280 Offset: 0x5DA880 VA: 0x1805DC280
	internal int get_BytesLeft() { }

	// RVA: 0x5DC0A0 Offset: 0x5DA6A0 VA: 0x1805DC0A0
	internal int Read(byte[] bufferOut, int offset, int count) { }

	// RVA: 0x5DBF80 Offset: 0x5DA580 VA: 0x1805DBF80 Slot: 4
	protected override void Append(int channel, short sampleValue) { }

	// RVA: 0x5DBD00 Offset: 0x5DA300 VA: 0x1805DBD00 Slot: 5
	internal override void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x5DC050 Offset: 0x5DA650 VA: 0x1805DC050 Slot: 7
	internal sealed override void ClearBuffer() { }

	// RVA: 0x5DC1B0 Offset: 0x5DA7B0 VA: 0x1805DC1B0 Slot: 6
	internal override void WriteBuffer(int val) { }

}

