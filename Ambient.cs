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

	// RVA: 0xAA6420 Offset: 0xAA4A20 VA: 0x180AA6420
	public void .ctor() { }

}

public class AmbienceDefinition.ValueRange // TypeDefIndex: 8970
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7EE650 Offset: 0x7ECC50 VA: 0x1807EE650
	public void .ctor(float min, float max) { }

}

public class AmbienceDefinitionList : ScriptableObject // TypeDefIndex: 8971
{	// Fields
	public List<AmbienceDefinition> defs; // 0x18

	// Methods

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
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
	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public TerrainTopology.Enum get_currentTopology() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8C1320 Offset: 0x8BF920 VA: 0x1808C1320
	private void set_currentTopology(TerrainTopology.Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public TerrainBiome.Enum get_currentBiome() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	private void set_currentBiome(TerrainBiome.Enum value) { }

	// RVA: 0xAA6570 Offset: 0xAA4B70 VA: 0x180AA6570
	protected void Awake() { }

	// RVA: 0xAA7630 Offset: 0xAA5C30 VA: 0x180AA7630
	protected void OnEnable() { }

	// RVA: 0xAA74A0 Offset: 0xAA5AA0 VA: 0x180AA74A0
	protected void OnDisable() { }

	// RVA: 0xAA7350 Offset: 0xAA5950 VA: 0x180AA7350
	protected void OnDestroy() { }

	// RVA: 0xAA6980 Offset: 0xAA4F80 VA: 0x180AA6980
	public void FadeOut(float fadeTimeOverride = -1) { }

	// RVA: 0xAA7330 Offset: 0xAA5930 VA: 0x180AA7330
	public bool IsFadingOut() { }

	// RVA: 0xAA8520 Offset: 0xAA6B20 VA: 0x180AA8520
	public void Reset() { }

	// RVA: 0xAA8580 Offset: 0xAA6B80 VA: 0x180AA8580
	public void SetBaseAmbience(AmbienceDefinitionList ambienceList) { }

	// RVA: 0xAA6810 Offset: 0xAA4E10 VA: 0x180AA6810
	public void DoUpdate() { }

	// RVA: 0xAA8A70 Offset: 0xAA7070 VA: 0x180AA8A70
	public void Tick() { }

	// RVA: 0xAA8BC0 Offset: 0xAA71C0 VA: 0x180AA8BC0
	public void UpdateCameraDistance() { }

	// RVA: 0xAA8820 Offset: 0xAA6E20 VA: 0x180AA8820
	public void StartImmediately() { }

	// RVA: 0xAA7EF0 Offset: 0xAA64F0 VA: 0x180AA7EF0
	private void ReadAndUpdateEnvironment() { }

	// RVA: 0xAA8100 Offset: 0xAA6700 VA: 0x180AA8100
	private void ReadEnvironment() { }

	// RVA: 0xAA8C70 Offset: 0xAA7270 VA: 0x180AA8C70
	private void UpdateCurrentEnvironment() { }

	// RVA: 0xAA6E40 Offset: 0xAA5440 VA: 0x180AA6E40
	private int GetMostCommonReading(List<int> readings) { }

	// RVA: 0xAA70E0 Offset: 0xAA56E0 VA: 0x180AA70E0
	private float GetScore(AmbienceDefinition definition, float rain, float snow, float wind, bool underground) { }

	// RVA: 0xAA8AB0 Offset: 0xAA70B0 VA: 0x180AA8AB0
	private void UpdateBaseSound(float crossFadeTimeOverride = -1) { }

	// RVA: 0xAA7030 Offset: 0xAA5630 VA: 0x180AA7030
	public SoundModulation.Modulator GetPitchModulator() { }

	// RVA: 0xAA8850 Offset: 0xAA6E50 VA: 0x180AA8850
	private void StartSound(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA6700 Offset: 0xAA4D00 VA: 0x180AA6700
	private void CrossfadeTo(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA6CA0 Offset: 0xAA52A0 VA: 0x180AA6CA0
	public SoundDefinition GetBaseSound() { }

	// RVA: 0xAA69D0 Offset: 0xAA4FD0 VA: 0x180AA69D0
	private SoundDefinition GetBaseSound(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA7760 Offset: 0xAA5D60 VA: 0x180AA7760
	public void PlayStings() { }

	// RVA: 0xAA79B0 Offset: 0xAA5FB0 VA: 0x180AA79B0
	private void PlayStings(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA83B0 Offset: 0xAA69B0 VA: 0x180AA83B0
	private void ResetStingTimes(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA6FE0 Offset: 0xAA55E0 VA: 0x180AA6FE0
	public float GetNextStingTime(AmbienceDefinition sting) { }

	// RVA: 0xAA66D0 Offset: 0xAA4CD0 VA: 0x180AA66D0 Slot: 4
	public int CompareTo(AmbienceEmitter other) { }

	// RVA: 0xAA8CB0 Offset: 0xAA72B0 VA: 0x180AA8CB0
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

	// RVA: 0xAA8DE0 Offset: 0xAA73E0 VA: 0x180AA8DE0
	private void PlaySting(uint seed) { }

	// RVA: 0xAA9070 Offset: 0xAA7670 VA: 0x180AA9070
	private void Start() { }

	// RVA: 0xAA9120 Offset: 0xAA7720 VA: 0x180AA9120
	private void Update() { }

	// RVA: 0xAA9140 Offset: 0xAA7740 VA: 0x180AA9140
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

	// RVA: 0xAAA5A0 Offset: 0xAA8BA0 VA: 0x180AAA5A0
	private void Start() { }

	// RVA: 0xAA9E70 Offset: 0xAA8470 VA: 0x180AA9E70
	private void OnApplicationQuit() { }

	// RVA: 0xAAA070 Offset: 0xAA8670 VA: 0x180AAA070
	private void OnDisable() { }

	// RVA: 0xAAB1B0 Offset: 0xAA97B0 VA: 0x180AAB1B0
	private void Update() { }

	// RVA: 0xAAACA0 Offset: 0xAA92A0 VA: 0x180AAACA0
	private void Tick() { }

	// RVA: 0xAAA9E0 Offset: 0xAA8FE0 VA: 0x180AAA9E0
	private void TickLocalEmitters() { }

	// RVA: 0xAA98E0 Offset: 0xAA7EE0 VA: 0x180AA98E0
	public void DeactivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA91C0 Offset: 0xAA77C0 VA: 0x180AA91C0
	public void ActivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAAA6E0 Offset: 0xAA8CE0 VA: 0x180AAA6E0
	private void TickCameraEmitters() { }

	// RVA: 0xAAA420 Offset: 0xAA8A20 VA: 0x180AAA420
	private void SortLocalEmitters() { }

	// RVA: 0xAA9B90 Offset: 0xAA8190 VA: 0x180AA9B90
	private AmbienceManager.EmitterTypeLimit EmitterLimit(AmbienceEmitter emitter) { }

	// RVA: 0xAA9F90 Offset: 0xAA8590 VA: 0x180AA9F90
	public void OnCullingGroupChange(CullingGroupEvent evt, AmbienceManager.AmbienceGroup group) { }

	// RVA: 0xAA9AF0 Offset: 0xAA80F0 VA: 0x180AA9AF0
	public void EmitterLeaveRange(AmbienceEmitter emitter) { }

	// RVA: 0xAA9310 Offset: 0xAA7910 VA: 0x180AA9310
	public void AddEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAAA140 Offset: 0xAA8740 VA: 0x180AAA140
	public void RemoveEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA92B0 Offset: 0xAA78B0 VA: 0x180AA92B0
	public void AddCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAAA0E0 Offset: 0xAA86E0 VA: 0x180AAA0E0
	public void RemoveCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAAACE0 Offset: 0xAA92E0 VA: 0x180AAACE0
	private void UpdateCullingGroups() { }

	// RVA: 0xAA9600 Offset: 0xAA7C00 VA: 0x180AA9600
	private AmbienceManager.AmbienceGroup AmbienceGroupForEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA9C20 Offset: 0xAA8220 VA: 0x180AA9C20
	public void EnableAdvancedAmbience() { }

	// RVA: 0xAA9940 Offset: 0xAA7F40 VA: 0x180AA9940
	public void DisableAdvancedAmbience() { }

	// RVA: 0xAAA3C0 Offset: 0xAA89C0 VA: 0x180AAA3C0
	private void SortEmitters(List<AmbienceEmitter> emitterList) { }

	// RVA: 0xAAA1F0 Offset: 0xAA87F0 VA: 0x180AAA1F0
	private void SortEmitters(List<AmbienceEmitter> emitterList, int left, int right) { }

	// RVA: 0xAA9700 Offset: 0xAA7D00 VA: 0x180AA9700
	public void AmbienceZoneEntered(AmbienceZone zone) { }

	// RVA: 0xAA9760 Offset: 0xAA7D60 VA: 0x180AA9760
	public void AmbienceZoneExited(AmbienceZone zone) { }

	// RVA: 0xAA97C0 Offset: 0xAA7DC0 VA: 0x180AA97C0
	public AmbienceZone CurrentAmbienceZone() { }

	// RVA: 0xAAB6A0 Offset: 0xAA9CA0 VA: 0x180AAB6A0
	public void .ctor() { }

}

public class AmbienceManager.EmitterTypeLimit // TypeDefIndex: 8975
{	// Fields
	public List<AmbienceDefinitionList> ambience; // 0x10
	public int limit; // 0x18
	public int active; // 0x1C

	// Methods

	// RVA: 0x83CE50 Offset: 0x83B450 VA: 0x18083CE50
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

	// RVA: 0x822340 Offset: 0x820940 VA: 0x180822340
	public void OnCullingGroupChange(CullingGroupEvent evt) { }

	// RVA: 0x8223C0 Offset: 0x8209C0 VA: 0x1808223C0
	public void .ctor() { }

}

public class AmbienceSpawnEmitters : MonoBehaviour, IClientComponent // TypeDefIndex: 8977
{	// Fields
	public int baseEmitterCount; // 0x18
	public int baseEmitterDistance; // 0x1C
	public GameObjectRef emitterPrefab; // 0x20

	// Methods

	// RVA: 0x822840 Offset: 0x820E40 VA: 0x180822840
	private void Start() { }

	// RVA: 0x822480 Offset: 0x820A80 VA: 0x180822480
	private void CreateBaseEmitters() { }

	// RVA: 0x822850 Offset: 0x820E50 VA: 0x180822850
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

	// RVA: 0x822870 Offset: 0x820E70 VA: 0x180822870
	private void Awake() { }

	// RVA: 0x822890 Offset: 0x820E90 VA: 0x180822890 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x8229F0 Offset: 0x820FF0 VA: 0x1808229F0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x822A70 Offset: 0x821070 VA: 0x180822A70 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x822AF0 Offset: 0x8210F0 VA: 0x180822AF0 Slot: 16
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x822C30 Offset: 0x821230 VA: 0x180822C30
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

	// RVA: 0x8230D0 Offset: 0x8216D0 VA: 0x1808230D0
	private float GetDistance() { }

	// RVA: 0x822C40 Offset: 0x821240 VA: 0x180822C40
	protected void Awake() { }

	// RVA: 0x823270 Offset: 0x821870 VA: 0x180823270
	protected void OnEnable() { }

	// RVA: 0x8231A0 Offset: 0x8217A0 VA: 0x1808231A0
	protected void OnDisable() { }

	// RVA: 0x823520 Offset: 0x821B20 VA: 0x180823520
	private void ToggleLight(bool state) { }

	// RVA: 0x822F30 Offset: 0x821530 VA: 0x180822F30
	private void FadingToggle() { }

	// RVA: 0x8233C0 Offset: 0x8219C0 VA: 0x1808233C0
	public void SetLightActive(bool lightOn) { }

	// RVA: 0x823500 Offset: 0x821B00 VA: 0x180823500
	public void SetTargetIntensity(float intensity, float fadeDuration = -1) { }

	// RVA: 0x823330 Offset: 0x821930 VA: 0x180823330 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x822D30 Offset: 0x821330 VA: 0x180822D30 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x823310 Offset: 0x821910 VA: 0x180823310
	protected void OnValidate() { }

	// RVA: 0x823670 Offset: 0x821C70 VA: 0x180823670
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

	// RVA: 0x9EC3F0 Offset: 0x9EA9F0 VA: 0x1809EC3F0
	public void .ctor() { }

}

public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality> // TypeDefIndex: 11759
{	// Methods

	// RVA: 0x9EC430 Offset: 0x9EAA30 VA: 0x1809EC430
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

	// RVA: 0x9ECA60 Offset: 0x9EB060 VA: 0x1809ECA60 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9ECE70 Offset: 0x9EB470 VA: 0x1809ECE70
	public void .ctor() { }

}

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 11762
{	// Fields
	private IAmbientOcclusionMethod[] m_Methods; // 0x20

	// Methods

	// RVA: 0x9EC6F0 Offset: 0x9EACF0 VA: 0x1809EC6F0 Slot: 4
	public override void Init() { }

	// RVA: 0x9EC870 Offset: 0x9EAE70 VA: 0x1809EC870
	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x9EC680 Offset: 0x9EAC80 VA: 0x1809EC680
	public IAmbientOcclusionMethod Get() { }

	// RVA: 0x9EC470 Offset: 0x9EAA70 VA: 0x1809EC470 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9EC900 Offset: 0x9EAF00 VA: 0x1809EC900 Slot: 7
	public override void Release() { }

	// RVA: 0x9EC600 Offset: 0x9EAC00 VA: 0x1809EC600
	public ScalableAO GetScalableAO() { }

	// RVA: 0x9EC580 Offset: 0x9EAB80 VA: 0x1809EC580
	public MultiScaleVO GetMultiScaleVO() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9ECA20 Offset: 0x9EB020 VA: 0x1809ECA20
	public void .ctor() { }

}

