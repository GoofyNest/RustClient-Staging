public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 11562
{	public bool colorFromLight; // 0x18
	public ColorMode colorMode; // 0x1C
	[ColorUsageAttribute] // RVA: 0xC3960 Offset: 0xC2D60 VA: 0x1800C3960
	[FormerlySerializedAsAttribute] // RVA: 0xC3960 Offset: 0xC2D60 VA: 0x1800C3960
	public Color color; // 0x20
	public Gradient colorGradient; // 0x30
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float alphaInside; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xC3CC0 Offset: 0xC30C0 VA: 0x1800C3CC0
	[RangeAttribute] // RVA: 0xC3CC0 Offset: 0xC30C0 VA: 0x1800C3CC0
	public float alphaOutside; // 0x3C
	public BlendingMode blendingMode; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xC3D80 Offset: 0xC3180 VA: 0x1800C3D80
	public bool spotAngleFromLight; // 0x44
	[RangeAttribute] // RVA: 0xC5160 Offset: 0xC4560 VA: 0x1800C5160
	public float spotAngle; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0xC5230 Offset: 0xC4630 VA: 0x1800C5230
	public float coneRadiusStart; // 0x4C
	public MeshType geomMeshType; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	public int geomCustomSides; // 0x54
	public int geomCustomSegments; // 0x58
	public bool geomCap; // 0x5C
	public bool fadeEndFromLight; // 0x5D
	public AttenuationEquation attenuationEquation; // 0x60
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float attenuationCustomBlending; // 0x64
	public float fadeStart; // 0x68
	public float fadeEnd; // 0x6C
	public float depthBlendDistance; // 0x70
	public float cameraClippingDistance; // 0x74
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float glareFrontal; // 0x78
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float glareBehind; // 0x7C
	[ObsoleteAttribute] // RVA: 0xC54C0 Offset: 0xC48C0 VA: 0x1800C54C0
	public float boostDistanceInside; // 0x80
	[ObsoleteAttribute] // RVA: 0xC5560 Offset: 0xC4960 VA: 0x1800C5560
	public float fresnelPowInside; // 0x84
	[FormerlySerializedAsAttribute] // RVA: 0xC5700 Offset: 0xC4B00 VA: 0x1800C5700
	public float fresnelPow; // 0x88
	public bool noiseEnabled; // 0x8C
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float noiseIntensity; // 0x90
	public bool noiseScaleUseGlobal; // 0x94
	[RangeAttribute] // RVA: 0xBF1A0 Offset: 0xBE5A0 VA: 0x1800BF1A0
	public float noiseScaleLocal; // 0x98
	public bool noiseVelocityUseGlobal; // 0x9C
	public Vector3 noiseVelocityLocal; // 0xA0
	private Plane m_PlaneWS; // 0xAC
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int pluginVersion; // 0xBC
	[FormerlySerializedAsAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	[SerializeField] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	private bool _TrackChangesDuringPlaytime; // 0xC0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int _SortingLayerID; // 0xC4
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int _SortingOrder; // 0xC8
	private BeamGeometry m_BeamGeom; // 0xD0
	private Coroutine m_CoPlaytimeUpdate; // 0xD8
	private Light _CachedLight; // 0xE0

	public float coneAngle { get; }
	public float coneRadiusEnd { get; }
	public float coneVolume { get; }
	public float coneApexOffsetZ { get; }
	public int geomSides { get; set; }
	public int geomSegments { get; set; }
	public float attenuationLerpLinearQuad { get; }
	public int sortingLayerID { get; set; }
	public string sortingLayerName { get; set; }
	public int sortingOrder { get; set; }
	public bool trackChangesDuringPlaytime { get; set; }
	public bool isCurrentlyTrackingChanges { get; }
	public bool hasGeometry { get; }
	public Bounds bounds { get; }
	public int blendingModeAsInt { get; }
	public MeshRenderer Renderer { get; }
	public string meshStats { get; }
	public int meshVerticesCount { get; }
	public int meshTrianglesCount { get; }
	private Light lightSpotAttached { get; }


	public float get_coneAngle() { }

	public float get_coneRadiusEnd() { }

	public float get_coneVolume() { }

	public float get_coneApexOffsetZ() { }

	public int get_geomSides() { }

	public void set_geomSides(int value) { }

	public int get_geomSegments() { }

	public void set_geomSegments(int value) { }

	public float get_attenuationLerpLinearQuad() { }

	public int get_sortingLayerID() { }

	public void set_sortingLayerID(int value) { }

	public string get_sortingLayerName() { }

	public void set_sortingLayerName(string value) { }

	public int get_sortingOrder() { }

	public void set_sortingOrder(int value) { }

	public bool get_trackChangesDuringPlaytime() { }

	public void set_trackChangesDuringPlaytime(bool value) { }

	public bool get_isCurrentlyTrackingChanges() { }

	public bool get_hasGeometry() { }

	public Bounds get_bounds() { }

	public void SetClippingPlane(Plane planeWS) { }

	public void SetClippingPlaneOff() { }

	public bool IsColliderHiddenByDynamicOccluder(Collider collider) { }

	public int get_blendingModeAsInt() { }

	public MeshRenderer get_Renderer() { }

	public string get_meshStats() { }

	public int get_meshVerticesCount() { }

	public int get_meshTrianglesCount() { }

	private Light get_lightSpotAttached() { }

	public float GetInsideBeamFactor(Vector3 posWS) { }

	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	[ObsoleteAttribute] // RVA: 0xC5CB0 Offset: 0xC50B0 VA: 0x1800C5CB0
	public void Generate() { }

	public virtual void GenerateGeometry() { }

	public virtual void UpdateAfterManualPropertyChange() { }

	private void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachineAttribute] // RVA: 0xC5DF0 Offset: 0xC51F0 VA: 0x1800C5DF0
	private IEnumerator CoPlaytimeUpdate() { }

	private void OnDestroy() { }

	private void DestroyBeam() { }

	private void AssignPropertiesFromSpotLight(Light lightSpot) { }

	private void ClampProperties() { }

	private void ValidateProperties() { }

	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	public void .ctor() { }

}

private sealed class VolumetricLightBeam.<CoPlaytimeUpdate>d__98 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11563
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VolumetricLightBeam <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

