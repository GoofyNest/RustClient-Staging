public class LightGroupAtTime : FacepunchBehaviour // TypeDefIndex: 10929
{
	public float IntensityOverride;
	public AnimationCurve IntensityScaleOverTime;
	public Transform SearchRoot;
	[HeaderAttribute]
	public bool requiresPower;
	[TooltipAttribute]
	public Transform powerOverrideTransform;
	public LayerMask checkLayers;
	public GameObject enableWhenLightsOn;
	public float timeBetweenPowerLookup;
	private List<KeyValuePair<Light, float>> lights;
	private List<KeyValuePair<AmbientLightLOD, float>> lightLODs;
	private List<KeyValuePair<Renderer, LightGroupAtTime.EmissiveCols[]>> renderers;
	private List<VolumetricLightBeam> beams;
	private List<CoverageQueryFlare> coverageQueryFlares;
	private List<DistanceFlareLOD> distanceFlares;
	private MaterialPropertyBlock block;
	private float intensityOverride;
	private int lightIndex;
	private int lightLODIndex;
	private int beamIndex;
	private int rendererIndex;
	private int simpleFlareIndex;
	private int distanceFlareIndex;
	private readonly int EmissionPropertyID;
	private readonly int ColorFlatPropertyID;
	private readonly int LightsPerFrame;
	private readonly int LightLODsPerFrame;
	private readonly int BeamsPerFrame;
	private readonly int RenderersPerFrame;
	private readonly int SimpleFlaresPerFrame;
	private readonly int DistanceFlaresPerFrame;
	public static LightGroupAtTime.LightGroupWorkQueue WorkQueue;
	private IOEntity cachedPowerEnt;
	private TimeSince lastPowerLookup;


	private void Clear() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public virtual float GetIntensity() { }

	public virtual float GetPowerScale() { }

	private void UpdateLights() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct LightGroupAtTime.EmissiveCols // TypeDefIndex: 10930
{
	public Color colour;
	public int matIndex;


	public void .ctor(Color colour, int matIndex) { }

}

public class LightGroupAtTime.LightGroupWorkQueue : PersistentObjectWorkQueue<LightGroupAtTime> // TypeDefIndex: 10931
{

	protected override void RunJob(LightGroupAtTime entity) { }

	public void .ctor() { }

}

