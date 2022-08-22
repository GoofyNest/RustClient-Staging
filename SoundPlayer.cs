public class SoundPlayer : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9039
{	// Fields
	public SoundDefinition soundDefinition; // 0x18
	public bool playImmediately; // 0x20
	public float minStartDelay; // 0x24
	public float maxStartDelay; // 0x28
	public bool debugRepeat; // 0x2C
	public bool pending; // 0x2D
	public Vector3 soundOffset; // 0x30
	private int playOnFrame; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Sound <sound>k__BackingField; // 0x40

	// Properties
	public Sound sound { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public Sound get_sound() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	protected void set_sound(Sound value) { }

	// RVA: 0xA7AD10 Offset: 0xA79310 VA: 0x180A7AD10
	protected void Awake() { }

	// RVA: 0xA7B490 Offset: 0xA79A90 VA: 0x180A7B490
	protected void OnEnable() { }

	// RVA: 0xA7B040 Offset: 0xA79640 VA: 0x180A7B040
	public void DoPendingUpdate() { }

	// RVA: 0xA7BA10 Offset: 0xA7A010 VA: 0x180A7BA10
	public bool ShouldStartThisFrame() { }

	// RVA: 0xA7B920 Offset: 0xA79F20 VA: 0x180A7B920
	public void Play() { }

	// RVA: 0xA7B870 Offset: 0xA79E70 VA: 0x180A7B870
	public void PlayOneshot() { }

	// RVA: 0xA7B5F0 Offset: 0xA79BF0 VA: 0x180A7B5F0
	public void PlayOneshotRandomDelay(float min = 0, float max = 1) { }

	// RVA: 0xA7B0B0 Offset: 0xA796B0 VA: 0x180A7B0B0
	public void FadeInAndPlay(float time = 0,5) { }

	// RVA: 0xA7B150 Offset: 0xA79750 VA: 0x180A7B150
	public void FadeOutAndRecycle(float time = 0,5) { }

	// RVA: 0xA7ADC0 Offset: 0xA793C0 VA: 0x180A7ADC0 Slot: 7
	public virtual void CreateSound() { }

	// RVA: 0xA7B2E0 Offset: 0xA798E0 VA: 0x180A7B2E0
	public bool IsPlaying() { }

	// RVA: 0xA7B280 Offset: 0xA79880 VA: 0x180A7B280
	public bool HasSound() { }

	// RVA: 0xA7AF90 Offset: 0xA79590 VA: 0x180A7AF90
	public void DestroySound() { }

	// RVA: 0xA7BA40 Offset: 0xA7A040 VA: 0x180A7BA40
	public void Stop() { }

	// RVA: 0xA7B400 Offset: 0xA79A00 VA: 0x180A7B400
	public void MakeThirdPerson() { }

	// RVA: 0xA7B370 Offset: 0xA79970 VA: 0x180A7B370
	public void MakeFirstPerson() { }

	// RVA: 0xA7B1F0 Offset: 0xA797F0 VA: 0x180A7B1F0
	public float GetLength() { }

	// RVA: 0x8094D0 Offset: 0x807AD0 VA: 0x1808094D0 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0xA7BAC0 Offset: 0xA7A0C0 VA: 0x180A7BAC0
	public void .ctor() { }

}

