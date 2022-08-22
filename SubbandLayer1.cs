public class SubbandLayer1 : ASubband // TypeDefIndex: 7403
{	// Fields
	internal static readonly float[] TableFactor; // 0x0
	internal static readonly float[] TableOffset; // 0x8
	protected int Allocation; // 0x10
	protected float Factor; // 0x14
	protected float Offset; // 0x18
	protected float Sample; // 0x1C
	protected int Samplelength; // 0x20
	protected int Samplenumber; // 0x24
	protected float Scalefactor; // 0x28
	protected readonly int Subbandnumber; // 0x2C

	// Methods

	// RVA: 0x673D90 Offset: 0x672390 VA: 0x180673D90
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x673AB0 Offset: 0x6720B0 VA: 0x180673AB0 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x673C20 Offset: 0x672220 VA: 0x180673C20 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x673BC0 Offset: 0x6721C0 VA: 0x180673BC0 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x673A60 Offset: 0x672060 VA: 0x180673A60 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

	// RVA: 0x673CE0 Offset: 0x6722E0 VA: 0x180673CE0
	private static void .cctor() { }

}

