public class SoundDefinition : ScriptableObject // TypeDefIndex: 9026
{	// Fields
	public GameObjectRef template; // 0x18
	[HorizontalAttribute] // RVA: 0xC8F30 Offset: 0xC8330 VA: 0x1800C8F30
	public List<WeightedAudioClip> weightedAudioClips; // 0x20
	public List<SoundDefinition.DistanceAudioClipList> distanceAudioClips; // 0x28
	public SoundClass soundClass; // 0x30
	public bool defaultToFirstPerson; // 0x38
	public bool loop; // 0x39
	public bool randomizeStartPosition; // 0x3A
	public bool useHighQualityFades; // 0x3B
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float volume; // 0x3C
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float volumeVariation; // 0x40
	[RangeAttribute] // RVA: 0xCE090 Offset: 0xCD490 VA: 0x1800CE090
	public float pitch; // 0x44
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float pitchVariation; // 0x48
	[HeaderAttribute] // RVA: 0xCE1F0 Offset: 0xCD5F0 VA: 0x1800CE1F0
	public bool dontVoiceLimit; // 0x4C
	public int globalVoiceMaxCount; // 0x50
	public int localVoiceMaxCount; // 0x54
	public float localVoiceRange; // 0x58
	public float voiceLimitFadeOutTime; // 0x5C
	public float localVoiceDebounceTime; // 0x60
	[HeaderAttribute] // RVA: 0xCD7E0 Offset: 0xCCBE0 VA: 0x1800CD7E0
	public bool forceOccludedPlayback; // 0x64
	[HeaderAttribute] // RVA: 0xCF750 Offset: 0xCEB50 VA: 0x1800CF750
	public bool enableDoppler; // 0x65
	public float dopplerAmount; // 0x68
	public float dopplerScale; // 0x6C
	public float dopplerAdjustmentRate; // 0x70
	[HeaderAttribute] // RVA: 0xCF970 Offset: 0xCED70 VA: 0x1800CF970
	public AnimationCurve falloffCurve; // 0x78
	public bool useCustomFalloffCurve; // 0x80
	public AnimationCurve spatialBlendCurve; // 0x88
	public bool useCustomSpatialBlendCurve; // 0x90
	public AnimationCurve spreadCurve; // 0x98
	public bool useCustomSpreadCurve; // 0xA0

	// Properties
	public float maxDistance { get; }

	// Methods

	// RVA: 0xA750C0 Offset: 0xA736C0 VA: 0x180A750C0
	public float get_maxDistance() { }

	// RVA: 0xA74CD0 Offset: 0xA732D0 VA: 0x180A74CD0
	public float GetLength() { }

	// RVA: 0xA74F80 Offset: 0xA73580 VA: 0x180A74F80
	public Sound Play() { }

	// RVA: 0xA74F40 Offset: 0xA73540 VA: 0x180A74F40
	public Sound Play(GameObject forGameObject) { }

	// RVA: 0xA74B90 Offset: 0xA73190 VA: 0x180A74B90
	public AudioClip GetClip() { }

	// RVA: 0xA74FC0 Offset: 0xA735C0 VA: 0x180A74FC0
	public void .ctor() { }

}

public class SoundDefinition.DistanceAudioClipList // TypeDefIndex: 9027
{	// Fields
	public int distance; // 0x10
	[HorizontalAttribute] // RVA: 0xC8F30 Offset: 0xC8330 VA: 0x1800C8F30
	public List<WeightedAudioClip> audioClips; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

