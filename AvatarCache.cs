public class AvatarCache // TypeDefIndex: 5684
{	// Fields
	private readonly Dictionary<ulong, AvatarCache.Entry> _entries; // 0x10
	private readonly Action<ulong, Texture2D> _loadAvatar; // 0x18

	// Methods

	// RVA: 0x22FFFC0 Offset: 0x22FE5C0 VA: 0x1822FFFC0
	public void .ctor(Action<ulong, Texture2D> loadAvatar) { }

	// RVA: 0x22FFD50 Offset: 0x22FE350 VA: 0x1822FFD50
	public Texture2D Get(ulong userId) { }

}

private struct AvatarCache.Entry // TypeDefIndex: 5685
{	// Fields
	public readonly ulong UserId; // 0x0
	public readonly Texture2D Texture; // 0x8

	// Methods

	// RVA: 0x14B610 Offset: 0x14AA10 VA: 0x18014B610
	public void .ctor(ulong userId, Texture2D texture) { }

}

