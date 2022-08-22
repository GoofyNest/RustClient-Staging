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

	// RVA: 0xAA5C90 Offset: 0xAA4290 VA: 0x180AA5C90
	public void .ctor() { }

}

public class AmbienceDefinition.ValueRange // TypeDefIndex: 8970
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7D0150 Offset: 0x7CE750 VA: 0x1807D0150
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
	// RVA: 0x8C0D00 Offset: 0x8BF300 VA: 0x1808C0D00
	private void set_currentTopology(TerrainTopology.Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public TerrainBiome.Enum get_currentBiome() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	private void set_currentBiome(TerrainBiome.Enum value) { }

	// RVA: 0xAA5DE0 Offset: 0xAA43E0 VA: 0x180AA5DE0
	protected void Awake() { }

	// RVA: 0xAA6EA0 Offset: 0xAA54A0 VA: 0x180AA6EA0
	protected void OnEnable() { }

	// RVA: 0xAA6D10 Offset: 0xAA5310 VA: 0x180AA6D10
	protected void OnDisable() { }

	// RVA: 0xAA6BC0 Offset: 0xAA51C0 VA: 0x180AA6BC0
	protected void OnDestroy() { }

	// RVA: 0xAA61F0 Offset: 0xAA47F0 VA: 0x180AA61F0
	public void FadeOut(float fadeTimeOverride = -1) { }

	// RVA: 0xAA6BA0 Offset: 0xAA51A0 VA: 0x180AA6BA0
	public bool IsFadingOut() { }

	// RVA: 0xAA7D90 Offset: 0xAA6390 VA: 0x180AA7D90
	public void Reset() { }

	// RVA: 0xAA7DF0 Offset: 0xAA63F0 VA: 0x180AA7DF0
	public void SetBaseAmbience(AmbienceDefinitionList ambienceList) { }

	// RVA: 0xAA6080 Offset: 0xAA4680 VA: 0x180AA6080
	public void DoUpdate() { }

	// RVA: 0xAA82E0 Offset: 0xAA68E0 VA: 0x180AA82E0
	public void Tick() { }

	// RVA: 0xAA8430 Offset: 0xAA6A30 VA: 0x180AA8430
	public void UpdateCameraDistance() { }

	// RVA: 0xAA8090 Offset: 0xAA6690 VA: 0x180AA8090
	public void StartImmediately() { }

	// RVA: 0xAA7760 Offset: 0xAA5D60 VA: 0x180AA7760
	private void ReadAndUpdateEnvironment() { }

	// RVA: 0xAA7970 Offset: 0xAA5F70 VA: 0x180AA7970
	private void ReadEnvironment() { }

	// RVA: 0xAA84E0 Offset: 0xAA6AE0 VA: 0x180AA84E0
	private void UpdateCurrentEnvironment() { }

	// RVA: 0xAA66B0 Offset: 0xAA4CB0 VA: 0x180AA66B0
	private int GetMostCommonReading(List<int> readings) { }

	// RVA: 0xAA6950 Offset: 0xAA4F50 VA: 0x180AA6950
	private float GetScore(AmbienceDefinition definition, float rain, float snow, float wind, bool underground) { }

	// RVA: 0xAA8320 Offset: 0xAA6920 VA: 0x180AA8320
	private void UpdateBaseSound(float crossFadeTimeOverride = -1) { }

	// RVA: 0xAA68A0 Offset: 0xAA4EA0 VA: 0x180AA68A0
	public SoundModulation.Modulator GetPitchModulator() { }

	// RVA: 0xAA80C0 Offset: 0xAA66C0 VA: 0x180AA80C0
	private void StartSound(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA5F70 Offset: 0xAA4570 VA: 0x180AA5F70
	private void CrossfadeTo(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA6510 Offset: 0xAA4B10 VA: 0x180AA6510
	public SoundDefinition GetBaseSound() { }

	// RVA: 0xAA6240 Offset: 0xAA4840 VA: 0x180AA6240
	private SoundDefinition GetBaseSound(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA6FD0 Offset: 0xAA55D0 VA: 0x180AA6FD0
	public void PlayStings() { }

	// RVA: 0xAA7220 Offset: 0xAA5820 VA: 0x180AA7220
	private void PlayStings(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA7C20 Offset: 0xAA6220 VA: 0x180AA7C20
	private void ResetStingTimes(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA6850 Offset: 0xAA4E50 VA: 0x180AA6850
	public float GetNextStingTime(AmbienceDefinition sting) { }

	// RVA: 0xAA5F40 Offset: 0xAA4540 VA: 0x180AA5F40 Slot: 4
	public int CompareTo(AmbienceEmitter other) { }

	// RVA: 0xAA8520 Offset: 0xAA6B20 VA: 0x180AA8520
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

	// RVA: 0xAA8650 Offset: 0xAA6C50 VA: 0x180AA8650
	private void PlaySting(uint seed) { }

	// RVA: 0xAA88E0 Offset: 0xAA6EE0 VA: 0x180AA88E0
	private void Start() { }

	// RVA: 0xAA8990 Offset: 0xAA6F90 VA: 0x180AA8990
	private void Update() { }

	// RVA: 0xAA89B0 Offset: 0xAA6FB0 VA: 0x180AA89B0
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

	// RVA: 0xAA9E10 Offset: 0xAA8410 VA: 0x180AA9E10
	private void Start() { }

	// RVA: 0xAA96E0 Offset: 0xAA7CE0 VA: 0x180AA96E0
	private void OnApplicationQuit() { }

	// RVA: 0xAA98E0 Offset: 0xAA7EE0 VA: 0x180AA98E0
	private void OnDisable() { }

	// RVA: 0xAAAA20 Offset: 0xAA9020 VA: 0x180AAAA20
	private void Update() { }

	// RVA: 0xAAA510 Offset: 0xAA8B10 VA: 0x180AAA510
	private void Tick() { }

	// RVA: 0xAAA250 Offset: 0xAA8850 VA: 0x180AAA250
	private void TickLocalEmitters() { }

	// RVA: 0xAA9150 Offset: 0xAA7750 VA: 0x180AA9150
	public void DeactivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA8A30 Offset: 0xAA7030 VA: 0x180AA8A30
	public void ActivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA9F50 Offset: 0xAA8550 VA: 0x180AA9F50
	private void TickCameraEmitters() { }

	// RVA: 0xAA9C90 Offset: 0xAA8290 VA: 0x180AA9C90
	private void SortLocalEmitters() { }

	// RVA: 0xAA9400 Offset: 0xAA7A00 VA: 0x180AA9400
	private AmbienceManager.EmitterTypeLimit EmitterLimit(AmbienceEmitter emitter) { }

	// RVA: 0xAA9800 Offset: 0xAA7E00 VA: 0x180AA9800
	public void OnCullingGroupChange(CullingGroupEvent evt, AmbienceManager.AmbienceGroup group) { }

	// RVA: 0xAA9360 Offset: 0xAA7960 VA: 0x180AA9360
	public void EmitterLeaveRange(AmbienceEmitter emitter) { }

	// RVA: 0xAA8B80 Offset: 0xAA7180 VA: 0x180AA8B80
	public void AddEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA99B0 Offset: 0xAA7FB0 VA: 0x180AA99B0
	public void RemoveEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA8B20 Offset: 0xAA7120 VA: 0x180AA8B20
	public void AddCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA9950 Offset: 0xAA7F50 VA: 0x180AA9950
	public void RemoveCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAAA550 Offset: 0xAA8B50 VA: 0x180AAA550
	private void UpdateCullingGroups() { }

	// RVA: 0xAA8E70 Offset: 0xAA7470 VA: 0x180AA8E70
	private AmbienceManager.AmbienceGroup AmbienceGroupForEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA9490 Offset: 0xAA7A90 VA: 0x180AA9490
	public void EnableAdvancedAmbience() { }

	// RVA: 0xAA91B0 Offset: 0xAA77B0 VA: 0x180AA91B0
	public void DisableAdvancedAmbience() { }

	// RVA: 0xAA9C30 Offset: 0xAA8230 VA: 0x180AA9C30
	private void SortEmitters(List<AmbienceEmitter> emitterList) { }

	// RVA: 0xAA9A60 Offset: 0xAA8060 VA: 0x180AA9A60
	private void SortEmitters(List<AmbienceEmitter> emitterList, int left, int right) { }

	// RVA: 0xAA8F70 Offset: 0xAA7570 VA: 0x180AA8F70
	public void AmbienceZoneEntered(AmbienceZone zone) { }

	// RVA: 0xAA8FD0 Offset: 0xAA75D0 VA: 0x180AA8FD0
	public void AmbienceZoneExited(AmbienceZone zone) { }

	// RVA: 0xAA9030 Offset: 0xAA7630 VA: 0x180AA9030
	public AmbienceZone CurrentAmbienceZone() { }

	// RVA: 0xAAAF10 Offset: 0xAA9510 VA: 0x180AAAF10
	public void .ctor() { }

}

public class AmbienceManager.EmitterTypeLimit // TypeDefIndex: 8975
{	// Fields
	public List<AmbienceDefinitionList> ambience; // 0x10
	public int limit; // 0x18
	public int active; // 0x1C

	// Methods

	// RVA: 0x83C7F0 Offset: 0x83ADF0 VA: 0x18083C7F0
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

	// RVA: 0x821CA0 Offset: 0x8202A0 VA: 0x180821CA0
	public void OnCullingGroupChange(CullingGroupEvent evt) { }

	// RVA: 0x821D20 Offset: 0x820320 VA: 0x180821D20
	public void .ctor() { }

}

public class AmbienceSpawnEmitters : MonoBehaviour, IClientComponent // TypeDefIndex: 8977
{	// Fields
	public int baseEmitterCount; // 0x18
	public int baseEmitterDistance; // 0x1C
	public GameObjectRef emitterPrefab; // 0x20

	// Methods

	// RVA: 0x8221A0 Offset: 0x8207A0 VA: 0x1808221A0
	private void Start() { }

	// RVA: 0x821DE0 Offset: 0x8203E0 VA: 0x180821DE0
	private void CreateBaseEmitters() { }

	// RVA: 0x8221B0 Offset: 0x8207B0 VA: 0x1808221B0
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

	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	private void Awake() { }

	// RVA: 0x8221F0 Offset: 0x8207F0 VA: 0x1808221F0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x822350 Offset: 0x820950 VA: 0x180822350 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x8223D0 Offset: 0x8209D0 VA: 0x1808223D0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x822450 Offset: 0x820A50 VA: 0x180822450 Slot: 16
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x822590 Offset: 0x820B90 VA: 0x180822590
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

	// RVA: 0x822A30 Offset: 0x821030 VA: 0x180822A30
	private float GetDistance() { }

	// RVA: 0x8225A0 Offset: 0x820BA0 VA: 0x1808225A0
	protected void Awake() { }

	// RVA: 0x822BD0 Offset: 0x8211D0 VA: 0x180822BD0
	protected void OnEnable() { }

	// RVA: 0x822B00 Offset: 0x821100 VA: 0x180822B00
	protected void OnDisable() { }

	// RVA: 0x822E80 Offset: 0x821480 VA: 0x180822E80
	private void ToggleLight(bool state) { }

	// RVA: 0x822890 Offset: 0x820E90 VA: 0x180822890
	private void FadingToggle() { }

	// RVA: 0x822D20 Offset: 0x821320 VA: 0x180822D20
	public void SetLightActive(bool lightOn) { }

	// RVA: 0x822E60 Offset: 0x821460 VA: 0x180822E60
	public void SetTargetIntensity(float intensity, float fadeDuration = -1) { }

	// RVA: 0x822C90 Offset: 0x821290 VA: 0x180822C90 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x822690 Offset: 0x820C90 VA: 0x180822690 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x822C70 Offset: 0x821270 VA: 0x180822C70
	protected void OnValidate() { }

	// RVA: 0x822FD0 Offset: 0x8215D0 VA: 0x180822FD0
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

	// RVA: 0x9EBC40 Offset: 0x9EA240 VA: 0x1809EBC40
	public void .ctor() { }

}

public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality> // TypeDefIndex: 11759
{	// Methods

	// RVA: 0x9EBC80 Offset: 0x9EA280 VA: 0x1809EBC80
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

	// RVA: 0x9EC2B0 Offset: 0x9EA8B0 VA: 0x1809EC2B0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9EC6C0 Offset: 0x9EACC0 VA: 0x1809EC6C0
	public void .ctor() { }

}

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 11762
{	// Fields
	private IAmbientOcclusionMethod[] m_Methods; // 0x20

	// Methods

	// RVA: 0x9EBF40 Offset: 0x9EA540 VA: 0x1809EBF40 Slot: 4
	public override void Init() { }

	// RVA: 0x9EC0C0 Offset: 0x9EA6C0 VA: 0x1809EC0C0
	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x9EBED0 Offset: 0x9EA4D0 VA: 0x1809EBED0
	public IAmbientOcclusionMethod Get() { }

	// RVA: 0x9EBCC0 Offset: 0x9EA2C0 VA: 0x1809EBCC0 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9EC150 Offset: 0x9EA750 VA: 0x1809EC150 Slot: 7
	public override void Release() { }

	// RVA: 0x9EBE50 Offset: 0x9EA450 VA: 0x1809EBE50
	public ScalableAO GetScalableAO() { }

	// RVA: 0x9EBDD0 Offset: 0x9EA3D0 VA: 0x1809EBDD0
	public MultiScaleVO GetMultiScaleVO() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9EC270 Offset: 0x9EA870 VA: 0x1809EC270
	public void .ctor() { }

}

