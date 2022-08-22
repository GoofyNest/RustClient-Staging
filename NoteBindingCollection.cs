public class NoteBindingCollection : ScriptableObject // TypeDefIndex: 9561
{	// Fields
	public NoteBindingCollection.NoteData[] BaseBindings; // 0x18
	public float MinimumNoteTime; // 0x20
	public float MaximumNoteLength; // 0x24
	public bool AllowAutoplay; // 0x28
	public float AutoplayLoopDelay; // 0x2C
	public string NotePlayedStatName; // 0x30
	public string KeyMidiMapShortname; // 0x38
	public bool AllowSustain; // 0x40
	public bool AllowFullKeyboardInput; // 0x41
	public string InstrumentShortName; // 0x48
	public InstrumentKeyController.InstrumentType NotePlayType; // 0x50
	public int MaxConcurrentNotes; // 0x54
	public bool LoopSounds; // 0x58
	public float SoundFadeInTime; // 0x5C
	public float minimumSoundFadeOutTime; // 0x60
	public InstrumentKeyController.KeySet PrimaryClickNote; // 0x64
	public InstrumentKeyController.KeySet SecondaryClickNote; // 0x70
	public bool RunInstrumentAnimationController; // 0x7C
	public bool PlayRepeatAnimations; // 0x7D
	public float AnimationDeadTime; // 0x80
	public float AnimationResetDelay; // 0x84
	public float RecentlyPlayedThreshold; // 0x88
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float CrossfadeNormalizedAnimationTarget; // 0x8C
	public float AnimationCrossfadeDuration; // 0x90
	public float CrossfadePlayerSpeedMulti; // 0x94
	public int DefaultOctave; // 0x98
	public int ShiftedOctave; // 0x9C

	// Methods

	// RVA: 0x9D2F30 Offset: 0x9D1530 VA: 0x1809D2F30
	public bool FindNoteData(Notes note, int octave, InstrumentKeyController.NoteType type, out NoteBindingCollection.NoteData data, out int noteIndex) { }

	// RVA: 0x9D2E80 Offset: 0x9D1480 VA: 0x1809D2E80
	public bool FindNoteDataIndex(Notes note, int octave, InstrumentKeyController.NoteType type, out int noteIndex) { }

	// RVA: 0x9D3020 Offset: 0x9D1620 VA: 0x1809D3020
	public void .ctor() { }

}

public struct NoteBindingCollection.NoteData // TypeDefIndex: 9562
{	// Fields
	public SoundDefinition NoteSound; // 0x0
	public SoundDefinition NoteStartSound; // 0x8
	public Notes Note; // 0x10
	public InstrumentKeyController.NoteType Type; // 0x14
	public int MidiNoteNumber; // 0x18
	public int NoteOctave; // 0x1C
	[InstrumentIKTargetAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public InstrumentKeyController.IKNoteTarget NoteIKTarget; // 0x20
	public InstrumentKeyController.AnimationSlot AnimationSlot; // 0x28
	public int NoteSoundPositionTarget; // 0x2C

	// Methods

	// RVA: 0xFAF00 Offset: 0xFA300 VA: 0x1800FAF00
	public string ToNoteString() { }

}

