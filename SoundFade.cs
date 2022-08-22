public class SoundFade : MonoBehaviour, IClientComponent // TypeDefIndex: 9028
{	// Fields
	public SoundFadeHQAudioFilter hqFadeFilter; // 0x18
	public float currentGain; // 0x20
	public float startingGain; // 0x24
	public float finalGain; // 0x28
	public int sampleRate; // 0x2C
	public bool highQualityFadeCompleted; // 0x30
	public float length; // 0x34
	public SoundFade.Direction currentDirection; // 0x38
	private Sound _sound; // 0x40
	public SoundModulation.Modulator fadeGainModulator; // 0x48
	private float startTime; // 0x50
	private float fadeOutTimeFinished; // 0x54
	private float fadeOutTimeBuffer; // 0x58

	// Properties
	public Sound sound { get; }
	public bool isFading { get; }
	public bool isFadingOut { get; }
	public bool isFadingIn { get; }
	public float fadeTimeLeft { get; }

	// Methods

	// RVA: 0xA76230 Offset: 0xA74830 VA: 0x180A76230
	public Sound get_sound() { }

	// RVA: 0xA76220 Offset: 0xA74820 VA: 0x180A76220
	public bool get_isFading() { }

	// RVA: 0xA76200 Offset: 0xA74800 VA: 0x180A76200
	public bool get_isFadingOut() { }

	// RVA: 0xA761E0 Offset: 0xA747E0 VA: 0x180A761E0
	public bool get_isFadingIn() { }

	// RVA: 0xA761A0 Offset: 0xA747A0 VA: 0x180A761A0
	public float get_fadeTimeLeft() { }

	// RVA: 0xA75F80 Offset: 0xA74580 VA: 0x180A75F80
	public void FadeIn(float time) { }

	// RVA: 0xA75F90 Offset: 0xA74590 VA: 0x180A75F90
	public void FadeOut(float time) { }

	// RVA: 0xA75CC0 Offset: 0xA742C0 VA: 0x180A75CC0
	public void DoUpdate() { }

	// RVA: 0xA75FA0 Offset: 0xA745A0 VA: 0x180A75FA0
	private void HQFadeComplete() { }

	// RVA: 0xA75FD0 Offset: 0xA745D0 VA: 0x180A75FD0
	public void Init() { }

	// RVA: 0xA75AE0 Offset: 0xA740E0 VA: 0x180A75AE0
	private void DoFade(float time, SoundFade.Direction direction) { }

	// RVA: 0xA762D0 Offset: 0xA748D0 VA: 0x180A762D0
	public bool isGainLevelAudible() { }

	// RVA: 0xA76160 Offset: 0xA74760 VA: 0x180A76160
	public void .ctor() { }

}

public enum SoundFade.Direction // TypeDefIndex: 9029
{	// Fields
	public int value__; // 0x0
	public const SoundFade.Direction In = 0;
	public const SoundFade.Direction Out = 1;

}

