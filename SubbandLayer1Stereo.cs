public class SubbandLayer1Stereo : SubbandLayer1 // TypeDefIndex: 7405
{	// Fields
	protected int Channel2Allocation; // 0x30
	protected float Channel2Factor; // 0x34
	protected float Channel2Offset; // 0x38
	protected float Channel2Sample; // 0x3C
	protected int Channel2Samplelength; // 0x40
	protected float Channel2Scalefactor; // 0x44

	// Methods

	// RVA: 0x6739C0 Offset: 0x671FC0 VA: 0x1806739C0
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x6734D0 Offset: 0x671AD0 VA: 0x1806734D0 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x673890 Offset: 0x671E90 VA: 0x180673890 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x6737F0 Offset: 0x671DF0 VA: 0x1806737F0 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x673410 Offset: 0x671A10 VA: 0x180673410 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

