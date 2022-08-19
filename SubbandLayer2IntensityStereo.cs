public class SubbandLayer2IntensityStereo : SubbandLayer2 // TypeDefIndex: 7407
{	// Fields
	protected float Channel2Scalefactor1; // 0x68
	protected float Channel2Scalefactor2; // 0x6C
	protected float Channel2Scalefactor3; // 0x70
	protected int Channel2Scfsi; // 0x74

	// Methods

	// RVA: 0x674490 Offset: 0x672A90 VA: 0x180674490
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x674040 Offset: 0x672640 VA: 0x180674040 Slot: 10
	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	// RVA: 0x6740D0 Offset: 0x6726D0 VA: 0x1806740D0 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x673E70 Offset: 0x672470 VA: 0x180673E70 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

