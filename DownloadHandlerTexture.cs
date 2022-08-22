public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 4753
{	// Fields
	private Texture2D mTexture; // 0x18
	private bool mHasTexture; // 0x20
	private bool mNonReadable; // 0x21

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x2322A80 Offset: 0x2321080 VA: 0x182322A80
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x2322C60 Offset: 0x2321260 VA: 0x182322C60
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x2322E30 Offset: 0x2321430 VA: 0x182322E30
	public void .ctor(bool readable) { }

	// RVA: 0x2322C50 Offset: 0x2321250 VA: 0x182322C50 Slot: 5
	protected override byte[] GetData() { }

	// RVA: 0x2322CF0 Offset: 0x23212F0 VA: 0x182322CF0
	public Texture2D get_texture() { }

	// RVA: 0x2322CF0 Offset: 0x23212F0 VA: 0x182322CF0
	private Texture2D InternalGetTexture() { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2322CB0 Offset: 0x23212B0 VA: 0x182322CB0
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x2322AD0 Offset: 0x23210D0 VA: 0x182322AD0
	public static Texture2D GetContent(UnityWebRequest www) { }

}

