public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 4753
{	// Fields
	private Texture2D mTexture; // 0x18
	private bool mHasTexture; // 0x20
	private bool mNonReadable; // 0x21

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x2322260 Offset: 0x2320860 VA: 0x182322260
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x2322440 Offset: 0x2320A40 VA: 0x182322440
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x2322610 Offset: 0x2320C10 VA: 0x182322610
	public void .ctor(bool readable) { }

	// RVA: 0x2322430 Offset: 0x2320A30 VA: 0x182322430 Slot: 5
	protected override byte[] GetData() { }

	// RVA: 0x23224D0 Offset: 0x2320AD0 VA: 0x1823224D0
	public Texture2D get_texture() { }

	// RVA: 0x23224D0 Offset: 0x2320AD0 VA: 0x1823224D0
	private Texture2D InternalGetTexture() { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2322490 Offset: 0x2320A90 VA: 0x182322490
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x23222B0 Offset: 0x23208B0 VA: 0x1823222B0
	public static Texture2D GetContent(UnityWebRequest www) { }

}

