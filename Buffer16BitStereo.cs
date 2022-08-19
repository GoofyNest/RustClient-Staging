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

	// RVA: 0x5DC260 Offset: 0x5DA860 VA: 0x1805DC260
	internal void .ctor() { }

	// RVA: 0x5DC2F0 Offset: 0x5DA8F0 VA: 0x1805DC2F0
	internal int get_BytesLeft() { }

	// RVA: 0x5DC110 Offset: 0x5DA710 VA: 0x1805DC110
	internal int Read(byte[] bufferOut, int offset, int count) { }

	// RVA: 0x5DBFF0 Offset: 0x5DA5F0 VA: 0x1805DBFF0 Slot: 4
	protected override void Append(int channel, short sampleValue) { }

	// RVA: 0x5DBD70 Offset: 0x5DA370 VA: 0x1805DBD70 Slot: 5
	internal override void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x5DC0C0 Offset: 0x5DA6C0 VA: 0x1805DC0C0 Slot: 7
	internal sealed override void ClearBuffer() { }

	// RVA: 0x5DC220 Offset: 0x5DA820 VA: 0x1805DC220 Slot: 6
	internal override void WriteBuffer(int val) { }

}

