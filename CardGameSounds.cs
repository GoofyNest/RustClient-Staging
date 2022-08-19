public class CardGameSounds : PrefabAttribute // TypeDefIndex: 9580
{	// Fields
	public SoundDefinition ChipsSfx; // 0x98
	public SoundDefinition DrawSfx; // 0xA0
	public SoundDefinition PlaySfx; // 0xA8
	public SoundDefinition ShuffleSfx; // 0xB0
	public SoundDefinition WinSfx; // 0xB8
	public SoundDefinition YourTurnSfx; // 0xC0
	public SoundDefinition CheckSfx; // 0xC8

	// Methods

	// RVA: 0x6FE260 Offset: 0x6FC860 VA: 0x1806FE260 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6FE2C0 Offset: 0x6FC8C0 VA: 0x1806FE2C0
	public void PlaySound(CardGameSounds.SoundType sound, GameObject forGameObject) { }

	// RVA: 0x6FE3F0 Offset: 0x6FC9F0 VA: 0x1806FE3F0
	public void .ctor() { }

}

public enum CardGameSounds.SoundType // TypeDefIndex: 9581
{	// Fields
	public int value__; // 0x0
	public const CardGameSounds.SoundType Chips = 0;
	public const CardGameSounds.SoundType Draw = 1;
	public const CardGameSounds.SoundType Play = 2;
	public const CardGameSounds.SoundType Shuffle = 3;
	public const CardGameSounds.SoundType Win = 4;
	public const CardGameSounds.SoundType YourTurn = 5;
	public const CardGameSounds.SoundType Check = 6;

}

