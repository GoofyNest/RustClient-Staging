public class SubbandLayer1Stereo : SubbandLayer1 // TypeDefIndex: 7405
{	// Fields
	protected int Channel2Allocation; // 0x30
	protected float Channel2Factor; // 0x34
	protected float Channel2Offset; // 0x38
	protected float Channel2Sample; // 0x3C
	protected int Channel2Samplelength; // 0x40
	protected float Channel2Scalefactor; // 0x44

	// Methods

	// RVA: 0x673A30 Offset: 0x672030 VA: 0x180673A30
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x673540 Offset: 0x671B40 VA: 0x180673540 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x673900 Offset: 0x671F00 VA: 0x180673900 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x673860 Offset: 0x671E60 VA: 0x180673860 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x673480 Offset: 0x671A80 VA: 0x180673480 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

