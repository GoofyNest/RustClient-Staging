public class AvatarCache // TypeDefIndex: 5684
{	// Fields
	private readonly Dictionary<ulong, AvatarCache.Entry> _entries; // 0x10
	private readonly Action<ulong, Texture2D> _loadAvatar; // 0x18

	// Methods

	// RVA: 0x22FFEC0 Offset: 0x22FE4C0 VA: 0x1822FFEC0
	public void .ctor(Action<ulong, Texture2D> loadAvatar) { }

	// RVA: 0x22FFC50 Offset: 0x22FE250 VA: 0x1822FFC50
	public Texture2D Get(ulong userId) { }

}

private struct AvatarCache.Entry // TypeDefIndex: 5685
{	// Fields
	public readonly ulong UserId; // 0x0
	public readonly Texture2D Texture; // 0x8

	// Methods

	// RVA: 0x14B690 Offset: 0x14AA90 VA: 0x18014B690
	public void .ctor(ulong userId, Texture2D texture) { }

}

