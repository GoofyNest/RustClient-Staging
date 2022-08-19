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

	// RVA: 0xA75AA0 Offset: 0xA740A0 VA: 0x180A75AA0
	public Sound get_sound() { }

	// RVA: 0xA75A90 Offset: 0xA74090 VA: 0x180A75A90
	public bool get_isFading() { }

	// RVA: 0xA75A70 Offset: 0xA74070 VA: 0x180A75A70
	public bool get_isFadingOut() { }

	// RVA: 0xA75A50 Offset: 0xA74050 VA: 0x180A75A50
	public bool get_isFadingIn() { }

	// RVA: 0xA75A10 Offset: 0xA74010 VA: 0x180A75A10
	public float get_fadeTimeLeft() { }

	// RVA: 0xA757F0 Offset: 0xA73DF0 VA: 0x180A757F0
	public void FadeIn(float time) { }

	// RVA: 0xA75800 Offset: 0xA73E00 VA: 0x180A75800
	public void FadeOut(float time) { }

	// RVA: 0xA75530 Offset: 0xA73B30 VA: 0x180A75530
	public void DoUpdate() { }

	// RVA: 0xA75810 Offset: 0xA73E10 VA: 0x180A75810
	private void HQFadeComplete() { }

	// RVA: 0xA75840 Offset: 0xA73E40 VA: 0x180A75840
	public void Init() { }

	// RVA: 0xA75350 Offset: 0xA73950 VA: 0x180A75350
	private void DoFade(float time, SoundFade.Direction direction) { }

	// RVA: 0xA75B40 Offset: 0xA74140 VA: 0x180A75B40
	public bool isGainLevelAudible() { }

	// RVA: 0xA759D0 Offset: 0xA73FD0 VA: 0x180A759D0
	public void .ctor() { }

}

public enum SoundFade.Direction // TypeDefIndex: 9029
{	// Fields
	public int value__; // 0x0
	public const SoundFade.Direction In = 0;
	public const SoundFade.Direction Out = 1;

}

