public class PreloadedCassetteContent : ScriptableObject // TypeDefIndex: 9452
{	// Fields
	public SoundDefinition[] ShortTapeContent; // 0x18
	public SoundDefinition[] MediumTapeContent; // 0x20
	public SoundDefinition[] LongTapeContent; // 0x28

	// Methods

	// RVA: 0x9A7A50 Offset: 0x9A6050 VA: 0x1809A7A50
	public SoundDefinition GetSoundContent(int index, PreloadedCassetteContent.PreloadType type) { }

	// RVA: 0x9A79C0 Offset: 0x9A5FC0 VA: 0x1809A79C0
	private SoundDefinition GetDefinition(int index, SoundDefinition[] array) { }

	// RVA: 0x9A7BF0 Offset: 0x9A61F0 VA: 0x1809A7BF0
	public SoundDefinition GetSoundContent(uint id) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public enum PreloadedCassetteContent.PreloadType // TypeDefIndex: 9453
{	// Fields
	public int value__; // 0x0
	public const PreloadedCassetteContent.PreloadType Short = 0;
	public const PreloadedCassetteContent.PreloadType Medium = 1;
	public const PreloadedCassetteContent.PreloadType Long = 2;

}

