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

	// RVA: 0xA75D60 Offset: 0xA74360 VA: 0x180A75D60
	public Sound get_sound() { }

	// RVA: 0xA75D50 Offset: 0xA74350 VA: 0x180A75D50
	public bool get_isFading() { }

	// RVA: 0xA75D30 Offset: 0xA74330 VA: 0x180A75D30
	public bool get_isFadingOut() { }

	// RVA: 0xA75D10 Offset: 0xA74310 VA: 0x180A75D10
	public bool get_isFadingIn() { }

	// RVA: 0xA75CD0 Offset: 0xA742D0 VA: 0x180A75CD0
	public float get_fadeTimeLeft() { }

	// RVA: 0xA75AB0 Offset: 0xA740B0 VA: 0x180A75AB0
	public void FadeIn(float time) { }

	// RVA: 0xA75AC0 Offset: 0xA740C0 VA: 0x180A75AC0
	public void FadeOut(float time) { }

	// RVA: 0xA757F0 Offset: 0xA73DF0 VA: 0x180A757F0
	public void DoUpdate() { }

	// RVA: 0xA75AD0 Offset: 0xA740D0 VA: 0x180A75AD0
	private void HQFadeComplete() { }

	// RVA: 0xA75B00 Offset: 0xA74100 VA: 0x180A75B00
	public void Init() { }

	// RVA: 0xA75610 Offset: 0xA73C10 VA: 0x180A75610
	private void DoFade(float time, SoundFade.Direction direction) { }

	// RVA: 0xA75E00 Offset: 0xA74400 VA: 0x180A75E00
	public bool isGainLevelAudible() { }

	// RVA: 0xA75C90 Offset: 0xA74290 VA: 0x180A75C90
	public void .ctor() { }

}

public enum SoundFade.Direction // TypeDefIndex: 9029
{	// Fields
	public int value__; // 0x0
	public const SoundFade.Direction In = 0;
	public const SoundFade.Direction Out = 1;

}

