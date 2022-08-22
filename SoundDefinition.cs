public class SoundDefinition : ScriptableObject // TypeDefIndex: 9026
{	public GameObjectRef template; // 0x18
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public List<WeightedAudioClip> weightedAudioClips; // 0x20
	public List<SoundDefinition.DistanceAudioClipList> distanceAudioClips; // 0x28
	public SoundClass soundClass; // 0x30
	public bool defaultToFirstPerson; // 0x38
	public bool loop; // 0x39
	public bool randomizeStartPosition; // 0x3A
	public bool useHighQualityFades; // 0x3B
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float volume; // 0x3C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float volumeVariation; // 0x40
	[RangeAttribute] // RVA: 0xCE0F0 Offset: 0xCD4F0 VA: 0x1800CE0F0
	public float pitch; // 0x44
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float pitchVariation; // 0x48
	[HeaderAttribute] // RVA: 0xCE280 Offset: 0xCD680 VA: 0x1800CE280
	public bool dontVoiceLimit; // 0x4C
	public int globalVoiceMaxCount; // 0x50
	public int localVoiceMaxCount; // 0x54
	public float localVoiceRange; // 0x58
	public float voiceLimitFadeOutTime; // 0x5C
	public float localVoiceDebounceTime; // 0x60
	[HeaderAttribute] // RVA: 0xCD870 Offset: 0xCCC70 VA: 0x1800CD870
	public bool forceOccludedPlayback; // 0x64
	[HeaderAttribute] // RVA: 0xCF7E0 Offset: 0xCEBE0 VA: 0x1800CF7E0
	public bool enableDoppler; // 0x65
	public float dopplerAmount; // 0x68
	public float dopplerScale; // 0x6C
	public float dopplerAdjustmentRate; // 0x70
	[HeaderAttribute] // RVA: 0xCFA00 Offset: 0xCEE00 VA: 0x1800CFA00
	public AnimationCurve falloffCurve; // 0x78
	public bool useCustomFalloffCurve; // 0x80
	public AnimationCurve spatialBlendCurve; // 0x88
	public bool useCustomSpatialBlendCurve; // 0x90
	public AnimationCurve spreadCurve; // 0x98
	public bool useCustomSpreadCurve; // 0xA0

	public float maxDistance { get; }


	public float get_maxDistance() { }

	public float GetLength() { }

	public Sound Play() { }

	public Sound Play(GameObject forGameObject) { }

	public AudioClip GetClip() { }

	public void .ctor() { }

}

public class SoundDefinition.DistanceAudioClipList // TypeDefIndex: 9027
{	public int distance; // 0x10
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public List<WeightedAudioClip> audioClips; // 0x18


	public void .ctor() { }

}

