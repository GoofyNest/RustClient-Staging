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

	// RVA: 0xA7AFD0 Offset: 0xA795D0 VA: 0x180A7AFD0
	protected void Awake() { }

	// RVA: 0xA7B750 Offset: 0xA79D50 VA: 0x180A7B750
	protected void OnEnable() { }

	// RVA: 0xA7B300 Offset: 0xA79900 VA: 0x180A7B300
	public void DoPendingUpdate() { }

	// RVA: 0xA7BCD0 Offset: 0xA7A2D0 VA: 0x180A7BCD0
	public bool ShouldStartThisFrame() { }

	// RVA: 0xA7BBE0 Offset: 0xA7A1E0 VA: 0x180A7BBE0
	public void Play() { }

	// RVA: 0xA7BB30 Offset: 0xA7A130 VA: 0x180A7BB30
	public void PlayOneshot() { }

	// RVA: 0xA7B8B0 Offset: 0xA79EB0 VA: 0x180A7B8B0
	public void PlayOneshotRandomDelay(float min = 0, float max = 1) { }

	// RVA: 0xA7B370 Offset: 0xA79970 VA: 0x180A7B370
	public void FadeInAndPlay(float time = 0,5) { }

	// RVA: 0xA7B410 Offset: 0xA79A10 VA: 0x180A7B410
	public void FadeOutAndRecycle(float time = 0,5) { }

	// RVA: 0xA7B080 Offset: 0xA79680 VA: 0x180A7B080 Slot: 7
	public virtual void CreateSound() { }

	// RVA: 0xA7B5A0 Offset: 0xA79BA0 VA: 0x180A7B5A0
	public bool IsPlaying() { }

	// RVA: 0xA7B540 Offset: 0xA79B40 VA: 0x180A7B540
	public bool HasSound() { }

	// RVA: 0xA7B250 Offset: 0xA79850 VA: 0x180A7B250
	public void DestroySound() { }

	// RVA: 0xA7BD00 Offset: 0xA7A300 VA: 0x180A7BD00
	public void Stop() { }

	// RVA: 0xA7B6C0 Offset: 0xA79CC0 VA: 0x180A7B6C0
	public void MakeThirdPerson() { }

	// RVA: 0xA7B630 Offset: 0xA79C30 VA: 0x180A7B630
	public void MakeFirstPerson() { }

	// RVA: 0xA7B4B0 Offset: 0xA79AB0 VA: 0x180A7B4B0
	public float GetLength() { }

	// RVA: 0x8095E0 Offset: 0x807BE0 VA: 0x1808095E0 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0xA7BD80 Offset: 0xA7A380 VA: 0x180A7BD80
	public void .ctor() { }

}

