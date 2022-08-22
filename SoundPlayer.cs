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
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public Sound get_sound() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	protected void set_sound(Sound value) { }

	// RVA: 0xA7B4A0 Offset: 0xA79AA0 VA: 0x180A7B4A0
	protected void Awake() { }

	// RVA: 0xA7BC20 Offset: 0xA7A220 VA: 0x180A7BC20
	protected void OnEnable() { }

	// RVA: 0xA7B7D0 Offset: 0xA79DD0 VA: 0x180A7B7D0
	public void DoPendingUpdate() { }

	// RVA: 0xA7C1A0 Offset: 0xA7A7A0 VA: 0x180A7C1A0
	public bool ShouldStartThisFrame() { }

	// RVA: 0xA7C0B0 Offset: 0xA7A6B0 VA: 0x180A7C0B0
	public void Play() { }

	// RVA: 0xA7C000 Offset: 0xA7A600 VA: 0x180A7C000
	public void PlayOneshot() { }

	// RVA: 0xA7BD80 Offset: 0xA7A380 VA: 0x180A7BD80
	public void PlayOneshotRandomDelay(float min = 0, float max = 1) { }

	// RVA: 0xA7B840 Offset: 0xA79E40 VA: 0x180A7B840
	public void FadeInAndPlay(float time = 0,5) { }

	// RVA: 0xA7B8E0 Offset: 0xA79EE0 VA: 0x180A7B8E0
	public void FadeOutAndRecycle(float time = 0,5) { }

	// RVA: 0xA7B550 Offset: 0xA79B50 VA: 0x180A7B550 Slot: 7
	public virtual void CreateSound() { }

	// RVA: 0xA7BA70 Offset: 0xA7A070 VA: 0x180A7BA70
	public bool IsPlaying() { }

	// RVA: 0xA7BA10 Offset: 0xA7A010 VA: 0x180A7BA10
	public bool HasSound() { }

	// RVA: 0xA7B720 Offset: 0xA79D20 VA: 0x180A7B720
	public void DestroySound() { }

	// RVA: 0xA7C1D0 Offset: 0xA7A7D0 VA: 0x180A7C1D0
	public void Stop() { }

	// RVA: 0xA7BB90 Offset: 0xA7A190 VA: 0x180A7BB90
	public void MakeThirdPerson() { }

	// RVA: 0xA7BB00 Offset: 0xA7A100 VA: 0x180A7BB00
	public void MakeFirstPerson() { }

	// RVA: 0xA7B980 Offset: 0xA79F80 VA: 0x180A7B980
	public float GetLength() { }

	// RVA: 0x809B70 Offset: 0x808170 VA: 0x180809B70 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0xA7C250 Offset: 0xA7A850 VA: 0x180A7C250
	public void .ctor() { }

}

