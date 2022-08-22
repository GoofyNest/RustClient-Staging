public class OggEncoder : IDisposable // TypeDefIndex: 9014
{	// Fields
	private IntPtr _nativeEncoder; // 0x10

	// Methods

	// RVA: 0x9E5340 Offset: 0x9E3940 VA: 0x1809E5340
	private static extern IntPtr OGG_CreateEncoder(int sampleRate) { }

	// RVA: 0x9E53C0 Offset: 0x9E39C0 VA: 0x1809E53C0
	private static extern void OGG_DestroyEncoder(IntPtr pEncoder) { }

	// RVA: 0x9E5440 Offset: 0x9E3A40 VA: 0x1809E5440
	private static extern bool OGG_Encode(IntPtr pEncoder, float* pSamples, int sampleCount) { }

	// RVA: 0x9E54E0 Offset: 0x9E3AE0 VA: 0x1809E54E0
	private static extern bool OGG_FinishEncode(IntPtr pEncoder) { }

	// RVA: 0x9E5560 Offset: 0x9E3B60 VA: 0x1809E5560
	private static extern int OGG_GetEncodedData(IntPtr pEncoder, out byte* pData) { }

	// RVA: 0x9E5600 Offset: 0x9E3C00 VA: 0x1809E5600
	public void .ctor() { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x9E4E80 Offset: 0x9E3480 VA: 0x1809E4E80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4F40 Offset: 0x9E3540 VA: 0x1809E4F40 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4FB0 Offset: 0x9E35B0 VA: 0x1809E4FB0
	public bool Encode(float[] samples) { }

	// RVA: 0x9E50E0 Offset: 0x9E36E0 VA: 0x1809E50E0
	public bool Finish() { }

	// RVA: 0x9E51C0 Offset: 0x9E37C0 VA: 0x1809E51C0
	public byte[] GetData() { }

}

