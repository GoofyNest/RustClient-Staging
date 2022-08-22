public enum AmbientMode // TypeDefIndex: 3814
{	// Fields
	public int value__; // 0x0
	public const AmbientMode Skybox = 0;
	public const AmbientMode Trilight = 1;
	public const AmbientMode Flat = 3;
	public const AmbientMode Custom = 4;

}

public class AmbienceDefinition : ScriptableObject // TypeDefIndex: 8969
{	// Fields
	[HeaderAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public List<SoundDefinition> sounds; // 0x18
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public AmbienceDefinition.ValueRange stingFrequency; // 0x20
	[HeaderAttribute] // RVA: 0xC90F0 Offset: 0xC84F0 VA: 0x1800C90F0
	[InspectorFlagsAttribute] // RVA: 0xC90F0 Offset: 0xC84F0 VA: 0x1800C90F0
	public TerrainBiome.Enum biomes; // 0x28
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TerrainTopology.Enum topologies; // 0x2C
	public EnvironmentType environmentType; // 0x30
	public bool useEnvironmentType; // 0x34
	public AnimationCurve time; // 0x38
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public AmbienceDefinition.ValueRange rain; // 0x40
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public AmbienceDefinition.ValueRange wind; // 0x48
	[HorizontalAttribute] // RVA: 0xC9010 Offset: 0xC8410 VA: 0x1800C9010
	public AmbienceDefinition.ValueRange snow; // 0x50

	// Methods

	// RVA: 0xAA5F50 Offset: 0xAA4550 VA: 0x180AA5F50
	public void .ctor() { }

}

public class AmbienceDefinition.ValueRange // TypeDefIndex: 8970
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7D0260 Offset: 0x7CE860 VA: 0x1807D0260
	public void .ctor(float min, float max) { }

}

public class AmbienceDefinitionList : ScriptableObject // TypeDefIndex: 8971
{	// Fields
	public List<AmbienceDefinition> defs; // 0x18

	// Methods

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class AmbienceEmitter : MonoBehaviour, IClientComponent, IComparable<AmbienceEmitter> // TypeDefIndex: 8972
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x18
	public AmbienceDefinitionList stings; // 0x20
	public bool isStatic; // 0x28
	public bool followCamera; // 0x29
	public bool isBaseEmitter; // 0x2A
	public bool active; // 0x2B
	public float cameraDistanceSq; // 0x2C
	public BoundingSphere boundingSphere; // 0x30
	public float crossfadeTime; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TerrainTopology.Enum <currentTopology>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TerrainBiome.Enum <currentBiome>k__BackingField; // 0x48
	public Dictionary<AmbienceDefinition, float> nextStingTime; // 0x50
	public float deactivateTime; // 0x58
	public bool playUnderwater; // 0x5C
	public bool playAbovewater; // 0x5D
	private Sound baseSound; // 0x60
	private SoundModulation.Modulator occlusionGain; // 0x68
	private SoundModulation.Modulator pitchModulator; // 0x70
	private float lastCrossfade; // 0x78
	private List<int> biomeReadings; // 0x80
	private List<int> topologyReadings; // 0x88
	private int readingsToKeep; // 0x90
	private Vector3 lastPosition; // 0x94
	private Dictionary<int, int> readingOccurences; // 0xA0

	// Properties
	public TerrainTopology.Enum currentTopology { get; set; }
	public TerrainBiome.Enum currentBiome { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public TerrainTopology.Enum get_currentTopology() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C0E10 Offset: 0x8BF410 VA: 0x1808C0E10
	private void set_currentTopology(TerrainTopology.Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public TerrainBiome.Enum get_currentBiome() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	private void set_currentBiome(TerrainBiome.Enum value) { }

	// RVA: 0xAA60A0 Offset: 0xAA46A0 VA: 0x180AA60A0
	protected void Awake() { }

	// RVA: 0xAA7160 Offset: 0xAA5760 VA: 0x180AA7160
	protected void OnEnable() { }

	// RVA: 0xAA6FD0 Offset: 0xAA55D0 VA: 0x180AA6FD0
	protected void OnDisable() { }

	// RVA: 0xAA6E80 Offset: 0xAA5480 VA: 0x180AA6E80
	protected void OnDestroy() { }

	// RVA: 0xAA64B0 Offset: 0xAA4AB0 VA: 0x180AA64B0
	public void FadeOut(float fadeTimeOverride = -1) { }

	// RVA: 0xAA6E60 Offset: 0xAA5460 VA: 0x180AA6E60
	public bool IsFadingOut() { }

	// RVA: 0xAA8050 Offset: 0xAA6650 VA: 0x180AA8050
	public void Reset() { }

	// RVA: 0xAA80B0 Offset: 0xAA66B0 VA: 0x180AA80B0
	public void SetBaseAmbience(AmbienceDefinitionList ambienceList) { }

	// RVA: 0xAA6340 Offset: 0xAA4940 VA: 0x180AA6340
	public void DoUpdate() { }

	// RVA: 0xAA85A0 Offset: 0xAA6BA0 VA: 0x180AA85A0
	public void Tick() { }

	// RVA: 0xAA86F0 Offset: 0xAA6CF0 VA: 0x180AA86F0
	public void UpdateCameraDistance() { }

	// RVA: 0xAA8350 Offset: 0xAA6950 VA: 0x180AA8350
	public void StartImmediately() { }

	// RVA: 0xAA7A20 Offset: 0xAA6020 VA: 0x180AA7A20
	private void ReadAndUpdateEnvironment() { }

	// RVA: 0xAA7C30 Offset: 0xAA6230 VA: 0x180AA7C30
	private void ReadEnvironment() { }

	// RVA: 0xAA87A0 Offset: 0xAA6DA0 VA: 0x180AA87A0
	private void UpdateCurrentEnvironment() { }

	// RVA: 0xAA6970 Offset: 0xAA4F70 VA: 0x180AA6970
	private int GetMostCommonReading(List<int> readings) { }

	// RVA: 0xAA6C10 Offset: 0xAA5210 VA: 0x180AA6C10
	private float GetScore(AmbienceDefinition definition, float rain, float snow, float wind, bool underground) { }

	// RVA: 0xAA85E0 Offset: 0xAA6BE0 VA: 0x180AA85E0
	private void UpdateBaseSound(float crossFadeTimeOverride = -1) { }

	// RVA: 0xAA6B60 Offset: 0xAA5160 VA: 0x180AA6B60
	public SoundModulation.Modulator GetPitchModulator() { }

	// RVA: 0xAA8380 Offset: 0xAA6980 VA: 0x180AA8380
	private void StartSound(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA6230 Offset: 0xAA4830 VA: 0x180AA6230
	private void CrossfadeTo(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA67D0 Offset: 0xAA4DD0 VA: 0x180AA67D0
	public SoundDefinition GetBaseSound() { }

	// RVA: 0xAA6500 Offset: 0xAA4B00 VA: 0x180AA6500
	private SoundDefinition GetBaseSound(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA7290 Offset: 0xAA5890 VA: 0x180AA7290
	public void PlayStings() { }

	// RVA: 0xAA74E0 Offset: 0xAA5AE0 VA: 0x180AA74E0
	private void PlayStings(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA7EE0 Offset: 0xAA64E0 VA: 0x180AA7EE0
	private void ResetStingTimes(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA6B10 Offset: 0xAA5110 VA: 0x180AA6B10
	public float GetNextStingTime(AmbienceDefinition sting) { }

	// RVA: 0xAA6200 Offset: 0xAA4800 VA: 0x180AA6200 Slot: 4
	public int CompareTo(AmbienceEmitter other) { }

	// RVA: 0xAA87E0 Offset: 0xAA6DE0 VA: 0x180AA87E0
	public void .ctor() { }

}

public class AmbienceLocalStings : MonoBehaviour // TypeDefIndex: 8973
{	// Fields
	public float maxDistance; // 0x18
	public float stingRadius; // 0x1C
	public float stingFrequency; // 0x20
	public float stingFrequencyVariance; // 0x24
	public SoundDefinition[] stingSounds; // 0x28
	private SynchronizedClock stingClock; // 0x30

	// Methods

	// RVA: 0xAA8910 Offset: 0xAA6F10 VA: 0x180AA8910
	private void PlaySting(uint seed) { }

	// RVA: 0xAA8BA0 Offset: 0xAA71A0 VA: 0x180AA8BA0
	private void Start() { }

	// RVA: 0xAA8C50 Offset: 0xAA7250 VA: 0x180AA8C50
	private void Update() { }

	// RVA: 0xAA8C70 Offset: 0xAA7270 VA: 0x180AA8C70
	public void .ctor() { }

}

public class AmbienceManager : SingletonComponent<AmbienceManager>, IClientComponent // TypeDefIndex: 8974
{	// Fields
	public List<AmbienceManager.EmitterTypeLimit> localEmitterLimits; // 0x18
	public AmbienceManager.EmitterTypeLimit catchallEmitterLimit; // 0x20
	public int maxActiveLocalEmitters; // 0x28
	public int activeLocalEmitters; // 0x2C
	public List<AmbienceEmitter> cameraEmitters; // 0x30
	public List<AmbienceEmitter> emittersInRange; // 0x38
	public List<AmbienceEmitter> activeEmitters; // 0x40
	public float localEmitterRange; // 0x48
	public List<AmbienceZone> currentAmbienceZones; // 0x50
	public bool isUnderwater; // 0x58
	private Dictionary<AmbienceDefinitionList, AmbienceManager.EmitterTypeLimit> emitterLimitByAmbience; // 0x60
	private float tickInterval; // 0x68
	private float lastTick; // 0x6C
	private List<AmbienceManager.AmbienceGroup> ambienceGroups; // 0x70
	private Dictionary<AmbienceDefinitionList, AmbienceManager.AmbienceGroup> ambienceGroupsByDef; // 0x78

	// Methods

	// RVA: 0xAAA0D0 Offset: 0xAA86D0 VA: 0x180AAA0D0
	private void Start() { }

	// RVA: 0xAA99A0 Offset: 0xAA7FA0 VA: 0x180AA99A0
	private void OnApplicationQuit() { }

	// RVA: 0xAA9BA0 Offset: 0xAA81A0 VA: 0x180AA9BA0
	private void OnDisable() { }

	// RVA: 0xAAACE0 Offset: 0xAA92E0 VA: 0x180AAACE0
	private void Update() { }

	// RVA: 0xAAA7D0 Offset: 0xAA8DD0 VA: 0x180AAA7D0
	private void Tick() { }

	// RVA: 0xAAA510 Offset: 0xAA8B10 VA: 0x180AAA510
	private void TickLocalEmitters() { }

	// RVA: 0xAA9410 Offset: 0xAA7A10 VA: 0x180AA9410
	public void DeactivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA8CF0 Offset: 0xAA72F0 VA: 0x180AA8CF0
	public void ActivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAAA210 Offset: 0xAA8810 VA: 0x180AAA210
	private void TickCameraEmitters() { }

	// RVA: 0xAA9F50 Offset: 0xAA8550 VA: 0x180AA9F50
	private void SortLocalEmitters() { }

	// RVA: 0xAA96C0 Offset: 0xAA7CC0 VA: 0x180AA96C0
	private AmbienceManager.EmitterTypeLimit EmitterLimit(AmbienceEmitter emitter) { }

	// RVA: 0xAA9AC0 Offset: 0xAA80C0 VA: 0x180AA9AC0
	public void OnCullingGroupChange(CullingGroupEvent evt, AmbienceManager.AmbienceGroup group) { }

	// RVA: 0xAA9620 Offset: 0xAA7C20 VA: 0x180AA9620
	public void EmitterLeaveRange(AmbienceEmitter emitter) { }

	// RVA: 0xAA8E40 Offset: 0xAA7440 VA: 0x180AA8E40
	public void AddEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA9C70 Offset: 0xAA8270 VA: 0x180AA9C70
	public void RemoveEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA8DE0 Offset: 0xAA73E0 VA: 0x180AA8DE0
	public void AddCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA9C10 Offset: 0xAA8210 VA: 0x180AA9C10
	public void RemoveCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAAA810 Offset: 0xAA8E10 VA: 0x180AAA810
	private void UpdateCullingGroups() { }

	// RVA: 0xAA9130 Offset: 0xAA7730 VA: 0x180AA9130
	private AmbienceManager.AmbienceGroup AmbienceGroupForEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA9750 Offset: 0xAA7D50 VA: 0x180AA9750
	public void EnableAdvancedAmbience() { }

	// RVA: 0xAA9470 Offset: 0xAA7A70 VA: 0x180AA9470
	public void DisableAdvancedAmbience() { }

	// RVA: 0xAA9EF0 Offset: 0xAA84F0 VA: 0x180AA9EF0
	private void SortEmitters(List<AmbienceEmitter> emitterList) { }

	// RVA: 0xAA9D20 Offset: 0xAA8320 VA: 0x180AA9D20
	private void SortEmitters(List<AmbienceEmitter> emitterList, int left, int right) { }

	// RVA: 0xAA9230 Offset: 0xAA7830 VA: 0x180AA9230
	public void AmbienceZoneEntered(AmbienceZone zone) { }

	// RVA: 0xAA9290 Offset: 0xAA7890 VA: 0x180AA9290
	public void AmbienceZoneExited(AmbienceZone zone) { }

	// RVA: 0xAA92F0 Offset: 0xAA78F0 VA: 0x180AA92F0
	public AmbienceZone CurrentAmbienceZone() { }

	// RVA: 0xAAB1D0 Offset: 0xAA97D0 VA: 0x180AAB1D0
	public void .ctor() { }

}

public class AmbienceManager.EmitterTypeLimit // TypeDefIndex: 8975
{	// Fields
	public List<AmbienceDefinitionList> ambience; // 0x10
	public int limit; // 0x18
	public int active; // 0x1C

	// Methods

	// RVA: 0x83C900 Offset: 0x83AF00 VA: 0x18083C900
	public void .ctor() { }

}

public class AmbienceManager.AmbienceGroup // TypeDefIndex: 8976
{	// Fields
	public AmbienceDefinitionList ambienceDefinition; // 0x10
	public HashSet<AmbienceEmitter> emitters; // 0x18
	public CullingGroup cullingGroup; // 0x20
	public BoundingSphere[] cullGroupSpheres; // 0x28
	public List<AmbienceEmitter> emittersBySphereIdx; // 0x30
	public bool cullingGroupDirty; // 0x38

	// Methods

	// RVA: 0x821DB0 Offset: 0x8203B0 VA: 0x180821DB0
	public void OnCullingGroupChange(CullingGroupEvent evt) { }

	// RVA: 0x821E30 Offset: 0x820430 VA: 0x180821E30
	public void .ctor() { }

}

public class AmbienceSpawnEmitters : MonoBehaviour, IClientComponent // TypeDefIndex: 8977
{	// Fields
	public int baseEmitterCount; // 0x18
	public int baseEmitterDistance; // 0x1C
	public GameObjectRef emitterPrefab; // 0x20

	// Methods

	// RVA: 0x8222B0 Offset: 0x8208B0 VA: 0x1808222B0
	private void Start() { }

	// RVA: 0x821EF0 Offset: 0x8204F0 VA: 0x180821EF0
	private void CreateBaseEmitters() { }

	// RVA: 0x8222C0 Offset: 0x8208C0 VA: 0x1808222C0
	public void .ctor() { }

}

public class AmbienceZone : TriggerBase, IClientComponentEx // TypeDefIndex: 8978
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x30
	public AmbienceDefinitionList stings; // 0x38
	public float priority; // 0x40
	public bool overrideCrossfadeTime; // 0x44
	public float crossfadeTime; // 0x48

	// Methods

	// RVA: 0x8222E0 Offset: 0x8208E0 VA: 0x1808222E0
	private void Awake() { }

	// RVA: 0x822300 Offset: 0x820900 VA: 0x180822300 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x822460 Offset: 0x820A60 VA: 0x180822460 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x8224E0 Offset: 0x820AE0 VA: 0x1808224E0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x822560 Offset: 0x820B60 VA: 0x180822560 Slot: 16
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x8226A0 Offset: 0x820CA0 VA: 0x1808226A0
	public void .ctor() { }

}

public class AmbientLightLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 11297
{	// Fields
	public bool isDynamic; // 0x18
	public float enabledRadius; // 0x1C
	public bool toggleFade; // 0x20
	public float toggleFadeDuration; // 0x24
	private Light lightComponent; // 0x28
	private LightOccludee lightOccludee; // 0x30
	private LightEx lightEx; // 0x38
	private VolumetricLightBeam volumetricBeam; // 0x40
	private LODCell cell; // 0x48
	private float targetIntensity; // 0x50
	private float targetFadeDuration; // 0x54
	private LODEnvironmentMode EnvironmentMode; // 0x58
	private float fadeStartTime; // 0x5C
	private float fadeEndTime; // 0x60
	private bool fadeToState; // 0x64
	private bool queuedState; // 0x65

	// Methods

	// RVA: 0x822B40 Offset: 0x821140 VA: 0x180822B40
	private float GetDistance() { }

	// RVA: 0x8226B0 Offset: 0x820CB0 VA: 0x1808226B0
	protected void Awake() { }

	// RVA: 0x822CE0 Offset: 0x8212E0 VA: 0x180822CE0
	protected void OnEnable() { }

	// RVA: 0x822C10 Offset: 0x821210 VA: 0x180822C10
	protected void OnDisable() { }

	// RVA: 0x822F90 Offset: 0x821590 VA: 0x180822F90
	private void ToggleLight(bool state) { }

	// RVA: 0x8229A0 Offset: 0x820FA0 VA: 0x1808229A0
	private void FadingToggle() { }

	// RVA: 0x822E30 Offset: 0x821430 VA: 0x180822E30
	public void SetLightActive(bool lightOn) { }

	// RVA: 0x822F70 Offset: 0x821570 VA: 0x180822F70
	public void SetTargetIntensity(float intensity, float fadeDuration = -1) { }

	// RVA: 0x822DA0 Offset: 0x8213A0 VA: 0x180822DA0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x8227A0 Offset: 0x820DA0 VA: 0x1808227A0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x822D80 Offset: 0x821380 VA: 0x180822D80
	protected void OnValidate() { }

	// RVA: 0x8230E0 Offset: 0x8216E0 VA: 0x1808230E0
	public void .ctor() { }

}

public enum AmbientOcclusionMode // TypeDefIndex: 11756
{	// Fields
	public int value__; // 0x0
	public const AmbientOcclusionMode ScalableAmbientObscurance = 0;
	public const AmbientOcclusionMode MultiScaleVolumetricObscurance = 1;

}

public enum AmbientOcclusionQuality // TypeDefIndex: 11757
{	// Fields
	public int value__; // 0x0
	public const AmbientOcclusionQuality Lowest = 0;
	public const AmbientOcclusionQuality Low = 1;
	public const AmbientOcclusionQuality Medium = 2;
	public const AmbientOcclusionQuality High = 3;
	public const AmbientOcclusionQuality Ultra = 4;

}

public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode> // TypeDefIndex: 11758
{	// Methods

	// RVA: 0x9EBF00 Offset: 0x9EA500 VA: 0x1809EBF00
	public void .ctor() { }

}

public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality> // TypeDefIndex: 11759
{	// Methods

	// RVA: 0x9EBF40 Offset: 0x9EA540 VA: 0x1809EBF40
	public void .ctor() { }

}

public sealed class AmbientOcclusion : PostProcessEffectSettings // TypeDefIndex: 11760
{	// Fields
	[TooltipAttribute] // RVA: 0xE7F80 Offset: 0xE7380 VA: 0x1800E7F80
	public AmbientOcclusionModeParameter mode; // 0x30
	[RangeAttribute] // RVA: 0xE93F0 Offset: 0xE87F0 VA: 0x1800E93F0
	[TooltipAttribute] // RVA: 0xE93F0 Offset: 0xE87F0 VA: 0x1800E93F0
	public FloatParameter intensity; // 0x38
	[ColorUsageAttribute] // RVA: 0xE94D0 Offset: 0xE88D0 VA: 0x1800E94D0
	[TooltipAttribute] // RVA: 0xE94D0 Offset: 0xE88D0 VA: 0x1800E94D0
	public ColorParameter color; // 0x40
	[TooltipAttribute] // RVA: 0xE9600 Offset: 0xE8A00 VA: 0x1800E9600
	public BoolParameter ambientOnly; // 0x48
	[RangeAttribute] // RVA: 0xE96A0 Offset: 0xE8AA0 VA: 0x1800E96A0
	public FloatParameter noiseFilterTolerance; // 0x50
	[RangeAttribute] // RVA: 0xE9800 Offset: 0xE8C00 VA: 0x1800E9800
	public FloatParameter blurTolerance; // 0x58
	[RangeAttribute] // RVA: 0xE9970 Offset: 0xE8D70 VA: 0x1800E9970
	public FloatParameter upsampleTolerance; // 0x60
	[RangeAttribute] // RVA: 0xE9A50 Offset: 0xE8E50 VA: 0x1800E9A50
	[TooltipAttribute] // RVA: 0xE9A50 Offset: 0xE8E50 VA: 0x1800E9A50
	public FloatParameter thicknessModifier; // 0x68
	[RangeAttribute] // RVA: 0xE9C00 Offset: 0xE9000 VA: 0x1800E9C00
	[TooltipAttribute] // RVA: 0xE9C00 Offset: 0xE9000 VA: 0x1800E9C00
	public FloatParameter directLightingStrength; // 0x70
	[TooltipAttribute] // RVA: 0xE9D40 Offset: 0xE9140 VA: 0x1800E9D40
	public FloatParameter radius; // 0x78
	[TooltipAttribute] // RVA: 0xE9E80 Offset: 0xE9280 VA: 0x1800E9E80
	public AmbientOcclusionQualityParameter quality; // 0x80

	// Methods

	// RVA: 0x9EC570 Offset: 0x9EAB70 VA: 0x1809EC570 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9EC980 Offset: 0x9EAF80 VA: 0x1809EC980
	public void .ctor() { }

}

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 11762
{	// Fields
	private IAmbientOcclusionMethod[] m_Methods; // 0x20

	// Methods

	// RVA: 0x9EC200 Offset: 0x9EA800 VA: 0x1809EC200 Slot: 4
	public override void Init() { }

	// RVA: 0x9EC380 Offset: 0x9EA980 VA: 0x1809EC380
	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x9EC190 Offset: 0x9EA790 VA: 0x1809EC190
	public IAmbientOcclusionMethod Get() { }

	// RVA: 0x9EBF80 Offset: 0x9EA580 VA: 0x1809EBF80 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9EC410 Offset: 0x9EAA10 VA: 0x1809EC410 Slot: 7
	public override void Release() { }

	// RVA: 0x9EC110 Offset: 0x9EA710 VA: 0x1809EC110
	public ScalableAO GetScalableAO() { }

	// RVA: 0x9EC090 Offset: 0x9EA690 VA: 0x1809EC090
	public MultiScaleVO GetMultiScaleVO() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9EC530 Offset: 0x9EAB30 VA: 0x1809EC530
	public void .ctor() { }

}

