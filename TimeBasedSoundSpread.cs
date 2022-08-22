public class TimeBasedSoundSpread : SoundModifier // TypeDefIndex: 9046
{	// Fields
	public AnimationCurve spreadCurve; // 0x20
	public AnimationCurve wanderIntensityCurve; // 0x28
	private float startTime; // 0x30
	private float wanderTime; // 0x34
	private SoundModulation.Modulator modulator; // 0x38

	// Methods

	// RVA: 0x88A230 Offset: 0x888830 VA: 0x18088A230 Slot: 4
	public override void Init(Sound targetSound) { }

	// RVA: 0x88A2B0 Offset: 0x8888B0 VA: 0x18088A2B0 Slot: 6
	public override void OnSoundPlay() { }

	// RVA: 0x88A080 Offset: 0x888680 VA: 0x18088A080 Slot: 5
	public override void ApplyModification() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

