public class AvatarCache // TypeDefIndex: 5684
{	// Fields
	private readonly Dictionary<ulong, AvatarCache.Entry> _entries; // 0x10
	private readonly Action<ulong, Texture2D> _loadAvatar; // 0x18

	// Methods

	// RVA: 0x23007E0 Offset: 0x22FEDE0 VA: 0x1823007E0
	public void .ctor(Action<ulong, Texture2D> loadAvatar) { }

	// RVA: 0x2300570 Offset: 0x22FEB70 VA: 0x182300570
	public Texture2D Get(ulong userId) { }

}

private struct AvatarCache.Entry // TypeDefIndex: 5685
{	// Fields
	public readonly ulong UserId; // 0x0
	public readonly Texture2D Texture; // 0x8

	// Methods

	// RVA: 0x14B430 Offset: 0x14A830 VA: 0x18014B430
	public void .ctor(ulong userId, Texture2D texture) { }

}

