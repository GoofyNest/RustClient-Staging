public class TimeBasedSoundSpread : SoundModifier // TypeDefIndex: 9046
{	// Fields
	public AnimationCurve spreadCurve; // 0x20
	public AnimationCurve wanderIntensityCurve; // 0x28
	private float startTime; // 0x30
	private float wanderTime; // 0x34
	private SoundModulation.Modulator modulator; // 0x38

	// Methods

	// RVA: 0x88A120 Offset: 0x888720 VA: 0x18088A120 Slot: 4
	public override void Init(Sound targetSound) { }

	// RVA: 0x88A1A0 Offset: 0x8887A0 VA: 0x18088A1A0 Slot: 6
	public override void OnSoundPlay() { }

	// RVA: 0x889F70 Offset: 0x888570 VA: 0x180889F70 Slot: 5
	public override void ApplyModification() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

