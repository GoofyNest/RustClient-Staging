public class OggDecoder : IDisposable // TypeDefIndex: 9013
{	// Fields
	private IntPtr _nativeDecoder; // 0x10

	// Methods

	// RVA: 0x9E4670 Offset: 0x9E2C70 VA: 0x1809E4670
	private static extern IntPtr OGG_CreateDecoder() { }

	// RVA: 0x9E47C0 Offset: 0x9E2DC0 VA: 0x1809E47C0
	private static extern void OGG_DestroyDecoder(IntPtr pDecoder) { }

	// RVA: 0x9E46E0 Offset: 0x9E2CE0 VA: 0x1809E46E0
	private static extern int OGG_DecodeFull(IntPtr pDecoder, byte* pOggData, int oggDataLength, out int channels, out int sampleRate, out float* pSamples) { }

	// RVA: 0x9E45F0 Offset: 0x9E2BF0 VA: 0x1809E45F0
	private static extern bool OGG_CleanupDecoder(IntPtr pDecoder) { }

	// RVA: 0x9E4B40 Offset: 0x9E3140 VA: 0x1809E4B40
	public void .ctor() { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x9E4490 Offset: 0x9E2A90 VA: 0x1809E4490 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4420 Offset: 0x9E2A20 VA: 0x1809E4420 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4840 Offset: 0x9E2E40 VA: 0x1809E4840
	public bool TryDecode(byte[] oggData, out int channels, out int sampleRate, out float[] samples) { }

}

