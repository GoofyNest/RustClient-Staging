public class SubbandLayer2IntensityStereo : SubbandLayer2 // TypeDefIndex: 7407
{	// Fields
	protected float Channel2Scalefactor1; // 0x68
	protected float Channel2Scalefactor2; // 0x6C
	protected float Channel2Scalefactor3; // 0x70
	protected int Channel2Scfsi; // 0x74

	// Methods

	// RVA: 0x674420 Offset: 0x672A20 VA: 0x180674420
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x673FD0 Offset: 0x6725D0 VA: 0x180673FD0 Slot: 10
	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	// RVA: 0x674060 Offset: 0x672660 VA: 0x180674060 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x673E00 Offset: 0x672400 VA: 0x180673E00 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

