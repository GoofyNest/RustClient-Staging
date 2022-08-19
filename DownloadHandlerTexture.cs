public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 4753
{	// Fields
	private Texture2D mTexture; // 0x18
	private bool mHasTexture; // 0x20
	private bool mNonReadable; // 0x21

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x2322160 Offset: 0x2320760 VA: 0x182322160
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x2322340 Offset: 0x2320940 VA: 0x182322340
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x2322510 Offset: 0x2320B10 VA: 0x182322510
	public void .ctor(bool readable) { }

	// RVA: 0x2322330 Offset: 0x2320930 VA: 0x182322330 Slot: 5
	protected override byte[] GetData() { }

	// RVA: 0x23223D0 Offset: 0x23209D0 VA: 0x1823223D0
	public Texture2D get_texture() { }

	// RVA: 0x23223D0 Offset: 0x23209D0 VA: 0x1823223D0
	private Texture2D InternalGetTexture() { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2322390 Offset: 0x2320990 VA: 0x182322390
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x23221B0 Offset: 0x23207B0 VA: 0x1823221B0
	public static Texture2D GetContent(UnityWebRequest www) { }

}

