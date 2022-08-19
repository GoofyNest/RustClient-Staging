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

	// RVA: 0x673E00 Offset: 0x672400 VA: 0x180673E00
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x673B20 Offset: 0x672120 VA: 0x180673B20 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x673C90 Offset: 0x672290 VA: 0x180673C90 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x673C30 Offset: 0x672230 VA: 0x180673C30 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x673AD0 Offset: 0x6720D0 VA: 0x180673AD0 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

	// RVA: 0x673D50 Offset: 0x672350 VA: 0x180673D50
	private static void .cctor() { }

}

