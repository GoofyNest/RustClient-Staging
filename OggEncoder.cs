public class OggEncoder : IDisposable // TypeDefIndex: 9014
{	// Fields
	private IntPtr _nativeEncoder; // 0x10

	// Methods

	// RVA: 0x9E5830 Offset: 0x9E3E30 VA: 0x1809E5830
	private static extern IntPtr OGG_CreateEncoder(int sampleRate) { }

	// RVA: 0x9E58B0 Offset: 0x9E3EB0 VA: 0x1809E58B0
	private static extern void OGG_DestroyEncoder(IntPtr pEncoder) { }

	// RVA: 0x9E5930 Offset: 0x9E3F30 VA: 0x1809E5930
	private static extern bool OGG_Encode(IntPtr pEncoder, float* pSamples, int sampleCount) { }

	// RVA: 0x9E59D0 Offset: 0x9E3FD0 VA: 0x1809E59D0
	private static extern bool OGG_FinishEncode(IntPtr pEncoder) { }

	// RVA: 0x9E5A50 Offset: 0x9E4050 VA: 0x1809E5A50
	private static extern int OGG_GetEncodedData(IntPtr pEncoder, out byte* pData) { }

	// RVA: 0x9E5AF0 Offset: 0x9E40F0 VA: 0x1809E5AF0
	public void .ctor() { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x9E5370 Offset: 0x9E3970 VA: 0x1809E5370 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E5430 Offset: 0x9E3A30 VA: 0x1809E5430 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E54A0 Offset: 0x9E3AA0 VA: 0x1809E54A0
	public bool Encode(float[] samples) { }

	// RVA: 0x9E55D0 Offset: 0x9E3BD0 VA: 0x1809E55D0
	public bool Finish() { }

	// RVA: 0x9E56B0 Offset: 0x9E3CB0 VA: 0x1809E56B0
	public byte[] GetData() { }

}

