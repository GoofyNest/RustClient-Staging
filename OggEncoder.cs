public class OggEncoder : IDisposable // TypeDefIndex: 9014
{	// Fields
	private IntPtr _nativeEncoder; // 0x10

	// Methods

	// RVA: 0x9E5080 Offset: 0x9E3680 VA: 0x1809E5080
	private static extern IntPtr OGG_CreateEncoder(int sampleRate) { }

	// RVA: 0x9E5100 Offset: 0x9E3700 VA: 0x1809E5100
	private static extern void OGG_DestroyEncoder(IntPtr pEncoder) { }

	// RVA: 0x9E5180 Offset: 0x9E3780 VA: 0x1809E5180
	private static extern bool OGG_Encode(IntPtr pEncoder, float* pSamples, int sampleCount) { }

	// RVA: 0x9E5220 Offset: 0x9E3820 VA: 0x1809E5220
	private static extern bool OGG_FinishEncode(IntPtr pEncoder) { }

	// RVA: 0x9E52A0 Offset: 0x9E38A0 VA: 0x1809E52A0
	private static extern int OGG_GetEncodedData(IntPtr pEncoder, out byte* pData) { }

	// RVA: 0x9E5340 Offset: 0x9E3940 VA: 0x1809E5340
	public void .ctor() { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x9E4BC0 Offset: 0x9E31C0 VA: 0x1809E4BC0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4C80 Offset: 0x9E3280 VA: 0x1809E4C80 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4CF0 Offset: 0x9E32F0 VA: 0x1809E4CF0
	public bool Encode(float[] samples) { }

	// RVA: 0x9E4E20 Offset: 0x9E3420 VA: 0x1809E4E20
	public bool Finish() { }

	// RVA: 0x9E4F00 Offset: 0x9E3500 VA: 0x1809E4F00
	public byte[] GetData() { }

}

