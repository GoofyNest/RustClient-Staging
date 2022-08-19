public class LayerIDecoder : IFrameDecoder // TypeDefIndex: 7400
{	// Fields
	protected ABuffer Buffer; // 0x10
	protected readonly Crc16 CRC; // 0x18
	protected SynthesisFilter Filter1; // 0x20
	protected SynthesisFilter Filter2; // 0x28
	protected Header Header; // 0x30
	protected int Mode; // 0x38
	protected int NuSubbands; // 0x3C
	protected Bitstream Stream; // 0x40
	protected ASubband[] Subbands; // 0x48
	protected int WhichChannels; // 0x50

	// Methods

	// RVA: 0x661530 Offset: 0x65FB30 VA: 0x180661530
	internal void .ctor() { }

	// RVA: 0x6611A0 Offset: 0x65F7A0 VA: 0x1806611A0 Slot: 5
	public virtual void DecodeFrame() { }

	// RVA: 0x661120 Offset: 0x65F720 VA: 0x180661120 Slot: 6
	internal virtual void Create(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0) { }

	// RVA: 0x660D80 Offset: 0x65F380 VA: 0x180660D80 Slot: 7
	protected virtual void CreateSubbands() { }

	// RVA: 0x6612D0 Offset: 0x65F8D0 VA: 0x1806612D0 Slot: 8
	protected virtual void ReadAllocation() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	protected virtual void ReadScaleFactorSelection() { }

	// RVA: 0x6614C0 Offset: 0x65FAC0 VA: 0x1806614C0 Slot: 10
	protected virtual void ReadScaleFactors() { }

	// RVA: 0x661350 Offset: 0x65F950 VA: 0x180661350 Slot: 11
	protected virtual void ReadSampleData() { }

}

