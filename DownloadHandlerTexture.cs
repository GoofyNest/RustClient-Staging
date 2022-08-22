public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 4753
{	// Fields
	private Texture2D mTexture; // 0x18
	private bool mHasTexture; // 0x20
	private bool mNonReadable; // 0x21

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x2321FA0 Offset: 0x23205A0 VA: 0x182321FA0
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x2322180 Offset: 0x2320780 VA: 0x182322180
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x2322350 Offset: 0x2320950 VA: 0x182322350
	public void .ctor(bool readable) { }

	// RVA: 0x2322170 Offset: 0x2320770 VA: 0x182322170 Slot: 5
	protected override byte[] GetData() { }

	// RVA: 0x2322210 Offset: 0x2320810 VA: 0x182322210
	public Texture2D get_texture() { }

	// RVA: 0x2322210 Offset: 0x2320810 VA: 0x182322210
	private Texture2D InternalGetTexture() { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23221D0 Offset: 0x23207D0 VA: 0x1823221D0
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x2321FF0 Offset: 0x23205F0 VA: 0x182321FF0
	public static Texture2D GetContent(UnityWebRequest www) { }

}

