public class OggDecoder : IDisposable // TypeDefIndex: 9013
{	// Fields
	private IntPtr _nativeDecoder; // 0x10

	// Methods

	// RVA: 0x9E4930 Offset: 0x9E2F30 VA: 0x1809E4930
	private static extern IntPtr OGG_CreateDecoder() { }

	// RVA: 0x9E4A80 Offset: 0x9E3080 VA: 0x1809E4A80
	private static extern void OGG_DestroyDecoder(IntPtr pDecoder) { }

	// RVA: 0x9E49A0 Offset: 0x9E2FA0 VA: 0x1809E49A0
	private static extern int OGG_DecodeFull(IntPtr pDecoder, byte* pOggData, int oggDataLength, out int channels, out int sampleRate, out float* pSamples) { }

	// RVA: 0x9E48B0 Offset: 0x9E2EB0 VA: 0x1809E48B0
	private static extern bool OGG_CleanupDecoder(IntPtr pDecoder) { }

	// RVA: 0x9E4E00 Offset: 0x9E3400 VA: 0x1809E4E00
	public void .ctor() { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x9E4750 Offset: 0x9E2D50 VA: 0x1809E4750 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E46E0 Offset: 0x9E2CE0 VA: 0x1809E46E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4B00 Offset: 0x9E3100 VA: 0x1809E4B00
	public bool TryDecode(byte[] oggData, out int channels, out int sampleRate, out float[] samples) { }

}

