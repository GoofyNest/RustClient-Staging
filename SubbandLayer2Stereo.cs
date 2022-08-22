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

	// RVA: 0x675050 Offset: 0x673650 VA: 0x180675050
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x674710 Offset: 0x672D10 VA: 0x180674710 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x674B80 Offset: 0x673180 VA: 0x180674B80 Slot: 10
	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	// RVA: 0x674C20 Offset: 0x673220 VA: 0x180674C20 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x6747B0 Offset: 0x672DB0 VA: 0x1806747B0 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x674480 Offset: 0x672A80 VA: 0x180674480 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

