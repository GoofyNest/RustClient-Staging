public class OggDecoder : IDisposable // TypeDefIndex: 9013
{	// Fields
	private IntPtr _nativeDecoder; // 0x10

	// Methods

	// RVA: 0x9E4E20 Offset: 0x9E3420 VA: 0x1809E4E20
	private static extern IntPtr OGG_CreateDecoder() { }

	// RVA: 0x9E4F70 Offset: 0x9E3570 VA: 0x1809E4F70
	private static extern void OGG_DestroyDecoder(IntPtr pDecoder) { }

	// RVA: 0x9E4E90 Offset: 0x9E3490 VA: 0x1809E4E90
	private static extern int OGG_DecodeFull(IntPtr pDecoder, byte* pOggData, int oggDataLength, out int channels, out int sampleRate, out float* pSamples) { }

	// RVA: 0x9E4DA0 Offset: 0x9E33A0 VA: 0x1809E4DA0
	private static extern bool OGG_CleanupDecoder(IntPtr pDecoder) { }

	// RVA: 0x9E52F0 Offset: 0x9E38F0 VA: 0x1809E52F0
	public void .ctor() { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x9E4C40 Offset: 0x9E3240 VA: 0x1809E4C40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4BD0 Offset: 0x9E31D0 VA: 0x1809E4BD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4FF0 Offset: 0x9E35F0 VA: 0x1809E4FF0
	public bool TryDecode(byte[] oggData, out int channels, out int sampleRate, out float[] samples) { }

}

