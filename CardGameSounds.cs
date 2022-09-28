public class CardGameSounds : PrefabAttribute // TypeDefIndex: 11290
{
	public SoundDefinition ChipsSfx; 
	public SoundDefinition DrawSfx; 
	public SoundDefinition PlaySfx; 
	public SoundDefinition ShuffleSfx; 
	public SoundDefinition WinSfx; 
	public SoundDefinition YourTurnSfx; 
	public SoundDefinition CheckSfx; 


	protected override Type GetIndexedType() { }

	public void PlaySound(CardGameSounds.SoundType sound, GameObject forGameObject) { }

	public void .ctor() { }

}

public enum CardGameSounds.SoundType // TypeDefIndex: 11291
{
	public int value__; 
	public const CardGameSounds.SoundType Chips = 0;
	public const CardGameSounds.SoundType Draw = 1;
	public const CardGameSounds.SoundType Play = 2;
	public const CardGameSounds.SoundType Shuffle = 3;
	public const CardGameSounds.SoundType Win = 4;
	public const CardGameSounds.SoundType YourTurn = 5;
	public const CardGameSounds.SoundType Check = 6;

}

