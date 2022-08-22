public class TimeBasedSoundSpread : SoundModifier // TypeDefIndex: 9046
{	// Fields
	public AnimationCurve spreadCurve; // 0x20
	public AnimationCurve wanderIntensityCurve; // 0x28
	private float startTime; // 0x30
	private float wanderTime; // 0x34
	private SoundModulation.Modulator modulator; // 0x38

	// Methods

	// RVA: 0x86D570 Offset: 0x86BB70 VA: 0x18086D570 Slot: 4
	public override void Init(Sound targetSound) { }

	// RVA: 0x86D5F0 Offset: 0x86BBF0 VA: 0x18086D5F0 Slot: 6
	public override void OnSoundPlay() { }

	// RVA: 0x86D3C0 Offset: 0x86B9C0 VA: 0x18086D3C0 Slot: 5
	public override void ApplyModification() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

