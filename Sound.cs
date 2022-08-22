public class Sound : MonoBehaviour, IClientComponent, IOnParentDestroying, IComparable<Sound>, ISoundBudgetedUpdate // TypeDefIndex: 9023
{	// Fields
	public static float volumeExponent; // 0x0
	public SoundDefinition definition; // 0x18
	public SoundModifier[] modifiers; // 0x20
	public SoundSource soundSource; // 0x28
	public AudioSource[] audioSources; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundFade _fade; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundModulation _modulation; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundOcclusion _occlusion; // 0x48
	private AudioSource audioSource; // 0x50
	private AudioSource distantAudioSource; // 0x58
	private Sound syncParent; // 0x60
	private Sound syncChild; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <initialMaxDistance>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <initialSpread>k__BackingField; // 0x74
	public bool playing; // 0x78
	public bool isFirstPerson; // 0x79
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <startTime>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <endTime>k__BackingField; // 0x80
	private List<WeightedAudioClip> closeClips; // 0x88
	private List<WeightedAudioClip> farClips; // 0x90
	private float distanceScale; // 0x98
	private int clipIndex; // 0x9C
	private bool hasDistantSound; // 0xA0
	private float length; // 0xA4
	private int FrameUpdateIndex; // 0xA8
	private Vector3 previousPosition; // 0xAC
	private float previousPositionUpdateTime; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <basePitch>k__BackingField; // 0xBC
	private int priorityModifier; // 0xC0

	// Properties
	public SoundFade fade { get; }
	public SoundModulation modulation { get; }
	public SoundOcclusion occlusion { get; }
	public float initialMaxDistance { get; set; }
	public float initialSpread { get; set; }
	public float audioSourceVolue { get; }
	public bool isAudioSourcePlaying { get; }
	public AudioClip audioClip { get; set; }
	public AudioClip distantAudioClip { get; set; }
	public int timeSamples { get; set; }
	public float pan { get; set; }
	public float maxDistance { get; }
	public float startTime { get; set; }
	public float endTime { get; set; }
	public float basePitch { get; set; }

	// Methods

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public SoundFade get_fade() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public SoundModulation get_modulation() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public SoundOcclusion get_occlusion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3350 Offset: 0x5C1950 VA: 0x1805C3350
	public float get_initialMaxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3530 Offset: 0x5C1B30 VA: 0x1805C3530
	private void set_initialMaxDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3360 Offset: 0x5C1960 VA: 0x1805C3360
	public float get_initialSpread() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3540 Offset: 0x5C1B40 VA: 0x1805C3540
	private void set_initialSpread(float value) { }

	// RVA: 0x5C32E0 Offset: 0x5C18E0 VA: 0x1805C32E0
	public float get_audioSourceVolue() { }

	// RVA: 0x5C3370 Offset: 0x5C1970 VA: 0x1805C3370
	public bool get_isAudioSourcePlaying() { }

	// RVA: 0x5C32C0 Offset: 0x5C18C0 VA: 0x1805C32C0
	public AudioClip get_audioClip() { }

	// RVA: 0x5C34D0 Offset: 0x5C1AD0 VA: 0x1805C34D0
	public void set_audioClip(AudioClip value) { }

	// RVA: 0x5C3310 Offset: 0x5C1910 VA: 0x1805C3310
	public AudioClip get_distantAudioClip() { }

	// RVA: 0x5C3500 Offset: 0x5C1B00 VA: 0x1805C3500
	public void set_distantAudioClip(AudioClip value) { }

	// RVA: 0x5C3420 Offset: 0x5C1A20 VA: 0x1805C3420
	public int get_timeSamples() { }

	// RVA: 0x5C35B0 Offset: 0x5C1BB0 VA: 0x1805C35B0
	public void set_timeSamples(int value) { }

	// RVA: 0x5C33F0 Offset: 0x5C19F0 VA: 0x1805C33F0
	public float get_pan() { }

	// RVA: 0x5C3550 Offset: 0x5C1B50 VA: 0x1805C3550
	public void set_pan(float value) { }

	// RVA: 0x5C33C0 Offset: 0x5C19C0 VA: 0x1805C33C0
	public float get_maxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3410 Offset: 0x5C1A10 VA: 0x1805C3410
	public float get_startTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C35A0 Offset: 0x5C1BA0 VA: 0x1805C35A0
	private void set_startTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3330 Offset: 0x5C1930 VA: 0x1805C3330
	public float get_endTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3520 Offset: 0x5C1B20 VA: 0x1805C3520
	private void set_endTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3300 Offset: 0x5C1900 VA: 0x1805C3300
	public float get_basePitch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C34F0 Offset: 0x5C1AF0 VA: 0x1805C34F0
	private void set_basePitch(float value) { }

	// RVA: 0x5BFEC0 Offset: 0x5BE4C0 VA: 0x1805BFEC0
	protected void Awake() { }

	// RVA: 0x5C1760 Offset: 0x5BFD60 VA: 0x1805C1760
	public void Init(SoundSource source, float cameraDistance = 0) { }

	// RVA: 0x5C15A0 Offset: 0x5BFBA0 VA: 0x1805C15A0
	private void InitAudioSource(AudioSource source) { }

	// RVA: 0x5C1DD0 Offset: 0x5C03D0 VA: 0x1805C1DD0
	private void OnDisable() { }

	// RVA: 0x5C1020 Offset: 0x5BF620 VA: 0x1805C1020 Slot: 6
	public void DoUpdate() { }

	// RVA: 0x5C0C00 Offset: 0x5BF200 VA: 0x1805C0C00
	public void DoDoppler() { }

	// RVA: 0x5C04E0 Offset: 0x5BEAE0 VA: 0x1805C04E0
	public void DoDistantCrossfade() { }

	// RVA: 0x5C2950 Offset: 0x5C0F50 VA: 0x1805C2950
	private void SetDistantVolumes() { }

	// RVA: 0x5BFD70 Offset: 0x5BE370 VA: 0x1805BFD70
	public void ApplyModulations() { }

	// RVA: 0x5BFC40 Offset: 0x5BE240 VA: 0x1805BFC40
	public void ApplyModifications() { }

	// RVA: 0x5C1D20 Offset: 0x5C0320 VA: 0x1805C1D20
	public void MakeThirdPerson() { }

	// RVA: 0x5C1CC0 Offset: 0x5C02C0 VA: 0x1805C1CC0
	public void MakeThirdPerson(AudioSource source) { }

	// RVA: 0x5C1C80 Offset: 0x5C0280 VA: 0x1805C1C80
	public void MakeFirstPerson() { }

	// RVA: 0x5C1B80 Offset: 0x5C0180 VA: 0x1805C1B80
	public void MakeFirstPerson(AudioSource source) { }

	// RVA: 0x5C1590 Offset: 0x5BFB90 VA: 0x1805C1590
	public float GetLength() { }

	// RVA: 0x5BFF50 Offset: 0x5BE550 VA: 0x1805BFF50
	public void CalcLength() { }

	// RVA: 0x5C03F0 Offset: 0x5BE9F0 VA: 0x1805C03F0 Slot: 5
	public int CompareTo(Sound other) { }

	// RVA: 0x5C2200 Offset: 0x5C0800 VA: 0x1805C2200
	public void Play() { }

	// RVA: 0x5C2060 Offset: 0x5C0660 VA: 0x1805C2060
	public void PlayAudioSources() { }

	// RVA: 0x5C1FD0 Offset: 0x5C05D0 VA: 0x1805C1FD0
	public void PlayAudioSource(AudioSource source) { }

	// RVA: 0x5C2EE0 Offset: 0x5C14E0 VA: 0x1805C2EE0
	public void SyncTo(Sound other) { }

	// RVA: 0x5C2C80 Offset: 0x5C1280 VA: 0x1805C2C80
	public void StopSyncing() { }

	// RVA: 0x5C2D90 Offset: 0x5C1390 VA: 0x1805C2D90
	public void Stop() { }

	// RVA: 0x5C1F80 Offset: 0x5C0580 VA: 0x1805C1F80
	public void Pause() { }

	// RVA: 0x5C2F30 Offset: 0x5C1530 VA: 0x1805C2F30
	public void UnPause() { }

	// RVA: 0x5C2AF0 Offset: 0x5C10F0 VA: 0x1805C2AF0
	public void SetPlaybackPercent(float percent) { }

	// RVA: 0x5C2590 Offset: 0x5C0B90 VA: 0x1805C2590
	public void RecycleAfterPlaying() { }

	// RVA: 0x5C2C50 Offset: 0x5C1250 VA: 0x1805C2C50
	public void StopAndRecycle(float delay = 0) { }

	// RVA: 0x5C25B0 Offset: 0x5C0BB0 VA: 0x1805C25B0
	public void SetClipIndex(int i) { }

	// RVA: 0x5C1490 Offset: 0x5BFA90 VA: 0x1805C1490
	public void FadeInAndPlay(float time) { }

	// RVA: 0x5C14C0 Offset: 0x5BFAC0 VA: 0x1805C14C0
	public void FadeOutAndRecycle(float time) { }

	// RVA: 0x5C3440 Offset: 0x5C1A40 VA: 0x1805C3440
	public bool isOutputVolumeAudible() { }

	// RVA: 0x5C0430 Offset: 0x5BEA30 VA: 0x1805C0430
	public void DisconnectFromParent() { }

	// RVA: 0x5C1E40 Offset: 0x5C0440 VA: 0x1805C1E40 Slot: 4
	public void OnParentDestroying() { }

	// RVA: 0x5C25C0 Offset: 0x5C0BC0 VA: 0x1805C25C0
	public void SetCustomFalloffCurve(AnimationCurve curve) { }

	// RVA: 0x5C26F0 Offset: 0x5C0CF0 VA: 0x1805C26F0
	public void SetCustomSpatialBlendCurve(AnimationCurve curve) { }

	// RVA: 0x5C2820 Offset: 0x5C0E20 VA: 0x1805C2820
	public void SetCustomSpreadCurve(AnimationCurve curve) { }

	// RVA: 0x5C1B20 Offset: 0x5C0120 VA: 0x1805C1B20 Slot: 7
	public bool IsSyncedToParent() { }

	// RVA: 0x5C2F80 Offset: 0x5C1580 VA: 0x1805C2F80
	private void UpdatePriority(float distance) { }

	// RVA: 0x5C2B90 Offset: 0x5C1190 VA: 0x1805C2B90
	public void SetPriorityModifier(int priority) { }

	// RVA: 0x5C3200 Offset: 0x5C1800 VA: 0x1805C3200
	public void .ctor() { }

	// RVA: 0x5C3180 Offset: 0x5C1780 VA: 0x1805C3180
	private static void .cctor() { }

}

