public class Sound : MonoBehaviour, IClientComponent, IOnParentDestroying, IComparable<Sound>, ISoundBudgetedUpdate // TypeDefIndex: 9023
{	// Fields
	public static float volumeExponent; // 0x0
	public SoundDefinition definition; // 0x18
	public SoundModifier[] modifiers; // 0x20
	public SoundSource soundSource; // 0x28
	public AudioSource[] audioSources; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundFade _fade; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundModulation _modulation; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SoundOcclusion _occlusion; // 0x48
	private AudioSource audioSource; // 0x50
	private AudioSource distantAudioSource; // 0x58
	private Sound syncParent; // 0x60
	private Sound syncChild; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <initialMaxDistance>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <initialSpread>k__BackingField; // 0x74
	public bool playing; // 0x78
	public bool isFirstPerson; // 0x79
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <startTime>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public SoundFade get_fade() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public SoundModulation get_modulation() { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public SoundOcclusion get_occlusion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33C0 Offset: 0x5C19C0 VA: 0x1805C33C0
	public float get_initialMaxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C35A0 Offset: 0x5C1BA0 VA: 0x1805C35A0
	private void set_initialMaxDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33D0 Offset: 0x5C19D0 VA: 0x1805C33D0
	public float get_initialSpread() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C35B0 Offset: 0x5C1BB0 VA: 0x1805C35B0
	private void set_initialSpread(float value) { }

	// RVA: 0x5C3350 Offset: 0x5C1950 VA: 0x1805C3350
	public float get_audioSourceVolue() { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public bool get_isAudioSourcePlaying() { }

	// RVA: 0x5C3330 Offset: 0x5C1930 VA: 0x1805C3330
	public AudioClip get_audioClip() { }

	// RVA: 0x5C3540 Offset: 0x5C1B40 VA: 0x1805C3540
	public void set_audioClip(AudioClip value) { }

	// RVA: 0x5C3380 Offset: 0x5C1980 VA: 0x1805C3380
	public AudioClip get_distantAudioClip() { }

	// RVA: 0x5C3570 Offset: 0x5C1B70 VA: 0x1805C3570
	public void set_distantAudioClip(AudioClip value) { }

	// RVA: 0x5C3490 Offset: 0x5C1A90 VA: 0x1805C3490
	public int get_timeSamples() { }

	// RVA: 0x5C3620 Offset: 0x5C1C20 VA: 0x1805C3620
	public void set_timeSamples(int value) { }

	// RVA: 0x5C3460 Offset: 0x5C1A60 VA: 0x1805C3460
	public float get_pan() { }

	// RVA: 0x5C35C0 Offset: 0x5C1BC0 VA: 0x1805C35C0
	public void set_pan(float value) { }

	// RVA: 0x5C3430 Offset: 0x5C1A30 VA: 0x1805C3430
	public float get_maxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3480 Offset: 0x5C1A80 VA: 0x1805C3480
	public float get_startTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3610 Offset: 0x5C1C10 VA: 0x1805C3610
	private void set_startTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33A0 Offset: 0x5C19A0 VA: 0x1805C33A0
	public float get_endTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3590 Offset: 0x5C1B90 VA: 0x1805C3590
	private void set_endTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3370 Offset: 0x5C1970 VA: 0x1805C3370
	public float get_basePitch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3560 Offset: 0x5C1B60 VA: 0x1805C3560
	private void set_basePitch(float value) { }

	// RVA: 0x5BFF30 Offset: 0x5BE530 VA: 0x1805BFF30
	protected void Awake() { }

	// RVA: 0x5C17D0 Offset: 0x5BFDD0 VA: 0x1805C17D0
	public void Init(SoundSource source, float cameraDistance = 0) { }

	// RVA: 0x5C1610 Offset: 0x5BFC10 VA: 0x1805C1610
	private void InitAudioSource(AudioSource source) { }

	// RVA: 0x5C1E40 Offset: 0x5C0440 VA: 0x1805C1E40
	private void OnDisable() { }

	// RVA: 0x5C1090 Offset: 0x5BF690 VA: 0x1805C1090 Slot: 6
	public void DoUpdate() { }

	// RVA: 0x5C0C70 Offset: 0x5BF270 VA: 0x1805C0C70
	public void DoDoppler() { }

	// RVA: 0x5C0550 Offset: 0x5BEB50 VA: 0x1805C0550
	public void DoDistantCrossfade() { }

	// RVA: 0x5C29C0 Offset: 0x5C0FC0 VA: 0x1805C29C0
	private void SetDistantVolumes() { }

	// RVA: 0x5BFDE0 Offset: 0x5BE3E0 VA: 0x1805BFDE0
	public void ApplyModulations() { }

	// RVA: 0x5BFCB0 Offset: 0x5BE2B0 VA: 0x1805BFCB0
	public void ApplyModifications() { }

	// RVA: 0x5C1D90 Offset: 0x5C0390 VA: 0x1805C1D90
	public void MakeThirdPerson() { }

	// RVA: 0x5C1D30 Offset: 0x5C0330 VA: 0x1805C1D30
	public void MakeThirdPerson(AudioSource source) { }

	// RVA: 0x5C1CF0 Offset: 0x5C02F0 VA: 0x1805C1CF0
	public void MakeFirstPerson() { }

	// RVA: 0x5C1BF0 Offset: 0x5C01F0 VA: 0x1805C1BF0
	public void MakeFirstPerson(AudioSource source) { }

	// RVA: 0x5C1600 Offset: 0x5BFC00 VA: 0x1805C1600
	public float GetLength() { }

	// RVA: 0x5BFFC0 Offset: 0x5BE5C0 VA: 0x1805BFFC0
	public void CalcLength() { }

	// RVA: 0x5C0460 Offset: 0x5BEA60 VA: 0x1805C0460 Slot: 5
	public int CompareTo(Sound other) { }

	// RVA: 0x5C2270 Offset: 0x5C0870 VA: 0x1805C2270
	public void Play() { }

	// RVA: 0x5C20D0 Offset: 0x5C06D0 VA: 0x1805C20D0
	public void PlayAudioSources() { }

	// RVA: 0x5C2040 Offset: 0x5C0640 VA: 0x1805C2040
	public void PlayAudioSource(AudioSource source) { }

	// RVA: 0x5C2F50 Offset: 0x5C1550 VA: 0x1805C2F50
	public void SyncTo(Sound other) { }

	// RVA: 0x5C2CF0 Offset: 0x5C12F0 VA: 0x1805C2CF0
	public void StopSyncing() { }

	// RVA: 0x5C2E00 Offset: 0x5C1400 VA: 0x1805C2E00
	public void Stop() { }

	// RVA: 0x5C1FF0 Offset: 0x5C05F0 VA: 0x1805C1FF0
	public void Pause() { }

	// RVA: 0x5C2FA0 Offset: 0x5C15A0 VA: 0x1805C2FA0
	public void UnPause() { }

	// RVA: 0x5C2B60 Offset: 0x5C1160 VA: 0x1805C2B60
	public void SetPlaybackPercent(float percent) { }

	// RVA: 0x5C2600 Offset: 0x5C0C00 VA: 0x1805C2600
	public void RecycleAfterPlaying() { }

	// RVA: 0x5C2CC0 Offset: 0x5C12C0 VA: 0x1805C2CC0
	public void StopAndRecycle(float delay = 0) { }

	// RVA: 0x5C2620 Offset: 0x5C0C20 VA: 0x1805C2620
	public void SetClipIndex(int i) { }

	// RVA: 0x5C1500 Offset: 0x5BFB00 VA: 0x1805C1500
	public void FadeInAndPlay(float time) { }

	// RVA: 0x5C1530 Offset: 0x5BFB30 VA: 0x1805C1530
	public void FadeOutAndRecycle(float time) { }

	// RVA: 0x5C34B0 Offset: 0x5C1AB0 VA: 0x1805C34B0
	public bool isOutputVolumeAudible() { }

	// RVA: 0x5C04A0 Offset: 0x5BEAA0 VA: 0x1805C04A0
	public void DisconnectFromParent() { }

	// RVA: 0x5C1EB0 Offset: 0x5C04B0 VA: 0x1805C1EB0 Slot: 4
	public void OnParentDestroying() { }

	// RVA: 0x5C2630 Offset: 0x5C0C30 VA: 0x1805C2630
	public void SetCustomFalloffCurve(AnimationCurve curve) { }

	// RVA: 0x5C2760 Offset: 0x5C0D60 VA: 0x1805C2760
	public void SetCustomSpatialBlendCurve(AnimationCurve curve) { }

	// RVA: 0x5C2890 Offset: 0x5C0E90 VA: 0x1805C2890
	public void SetCustomSpreadCurve(AnimationCurve curve) { }

	// RVA: 0x5C1B90 Offset: 0x5C0190 VA: 0x1805C1B90 Slot: 7
	public bool IsSyncedToParent() { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	private void UpdatePriority(float distance) { }

	// RVA: 0x5C2C00 Offset: 0x5C1200 VA: 0x1805C2C00
	public void SetPriorityModifier(int priority) { }

	// RVA: 0x5C3270 Offset: 0x5C1870 VA: 0x1805C3270
	public void .ctor() { }

	// RVA: 0x5C31F0 Offset: 0x5C17F0 VA: 0x1805C31F0
	private static void .cctor() { }

}

