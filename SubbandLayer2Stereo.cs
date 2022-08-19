public class SubbandLayer2Stereo : SubbandLayer2 // TypeDefIndex: 7408
{	// Fields
	protected int Channel2Allocation; // 0x68
	protected readonly float[] Channel2C; // 0x70
	protected readonly int[] Channel2Codelength; // 0x78
	protected readonly float[] Channel2D; // 0x80
	protected readonly float[] Channel2Factor; // 0x88
	protected readonly float[] Channel2Samples; // 0x90
	protected float Channel2Scalefactor1; // 0x98
	protected float Channel2Scalefactor2; // 0x9C
	protected float Channel2Scalefactor3; // 0xA0
	protected int Channel2Scfsi; // 0xA4

	// Methods

	// RVA: 0x6750C0 Offset: 0x6736C0 VA: 0x1806750C0
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x674780 Offset: 0x672D80 VA: 0x180674780 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x674BF0 Offset: 0x6731F0 VA: 0x180674BF0 Slot: 10
	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	// RVA: 0x674C90 Offset: 0x673290 VA: 0x180674C90 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x674820 Offset: 0x672E20 VA: 0x180674820 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x6744F0 Offset: 0x672AF0 VA: 0x1806744F0 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

