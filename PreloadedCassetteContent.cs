public class PreloadedCassetteContent : ScriptableObject // TypeDefIndex: 9452
{	// Fields
	public SoundDefinition[] ShortTapeContent; // 0x18
	public SoundDefinition[] MediumTapeContent; // 0x20
	public SoundDefinition[] LongTapeContent; // 0x28

	// Methods

	// RVA: 0x9A7560 Offset: 0x9A5B60 VA: 0x1809A7560
	public SoundDefinition GetSoundContent(int index, PreloadedCassetteContent.PreloadType type) { }

	// RVA: 0x9A74D0 Offset: 0x9A5AD0 VA: 0x1809A74D0
	private SoundDefinition GetDefinition(int index, SoundDefinition[] array) { }

	// RVA: 0x9A7700 Offset: 0x9A5D00 VA: 0x1809A7700
	public SoundDefinition GetSoundContent(uint id) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public enum PreloadedCassetteContent.PreloadType // TypeDefIndex: 9453
{	// Fields
	public int value__; // 0x0
	public const PreloadedCassetteContent.PreloadType Short = 0;
	public const PreloadedCassetteContent.PreloadType Medium = 1;
	public const PreloadedCassetteContent.PreloadType Long = 2;

}

