public class PreloadedCassetteContent : ScriptableObject // TypeDefIndex: 9452
{	// Fields
	public SoundDefinition[] ShortTapeContent; // 0x18
	public SoundDefinition[] MediumTapeContent; // 0x20
	public SoundDefinition[] LongTapeContent; // 0x28

	// Methods

	// RVA: 0x9A72A0 Offset: 0x9A58A0 VA: 0x1809A72A0
	public SoundDefinition GetSoundContent(int index, PreloadedCassetteContent.PreloadType type) { }

	// RVA: 0x9A7210 Offset: 0x9A5810 VA: 0x1809A7210
	private SoundDefinition GetDefinition(int index, SoundDefinition[] array) { }

	// RVA: 0x9A7440 Offset: 0x9A5A40 VA: 0x1809A7440
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

