public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 11558
{	public bool colorFromLight; // 0x18
	public ColorMode colorMode; // 0x1C
	[ColorUsageAttribute] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	[FormerlySerializedAsAttribute] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	public Color color; // 0x20
	public Gradient colorGradient; // 0x30
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float alphaInside; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xC51B0 Offset: 0xC45B0 VA: 0x1800C51B0
	[RangeAttribute] // RVA: 0xC51B0 Offset: 0xC45B0 VA: 0x1800C51B0
	public float alphaOutside; // 0x3C
	public BlendingMode blendingMode; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xC5240 Offset: 0xC4640 VA: 0x1800C5240
	public bool spotAngleFromLight; // 0x44
	[RangeAttribute] // RVA: 0xC53A0 Offset: 0xC47A0 VA: 0x1800C53A0
	public float spotAngle; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0xC5460 Offset: 0xC4860 VA: 0x1800C5460
	public float coneRadiusStart; // 0x4C
	public MeshType geomMeshType; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xC5600 Offset: 0xC4A00 VA: 0x1800C5600
	public int geomCustomSides; // 0x54
	public int geomCustomSegments; // 0x58
	public bool geomCap; // 0x5C
	public bool fadeEndFromLight; // 0x5D
	public AttenuationEquation attenuationEquation; // 0x60
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float attenuationCustomBlending; // 0x64
	public float fadeStart; // 0x68
	public float fadeEnd; // 0x6C
	public float depthBlendDistance; // 0x70
	public float cameraClippingDistance; // 0x74
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float glareFrontal; // 0x78
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float glareBehind; // 0x7C
	[ObsoleteAttribute] // RVA: 0xC58C0 Offset: 0xC4CC0 VA: 0x1800C58C0
	public float boostDistanceInside; // 0x80
	[ObsoleteAttribute] // RVA: 0xC5920 Offset: 0xC4D20 VA: 0x1800C5920
	public float fresnelPowInside; // 0x84
	[FormerlySerializedAsAttribute] // RVA: 0xC5B50 Offset: 0xC4F50 VA: 0x1800C5B50
	public float fresnelPow; // 0x88
	public bool noiseEnabled; // 0x8C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float noiseIntensity; // 0x90
	public bool noiseScaleUseGlobal; // 0x94
	[RangeAttribute] // RVA: 0xBF380 Offset: 0xBE780 VA: 0x1800BF380
	public float noiseScaleLocal; // 0x98
	public bool noiseVelocityUseGlobal; // 0x9C
	public Vector3 noiseVelocityLocal; // 0xA0
	private Plane m_PlaneWS; // 0xAC
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int pluginVersion; // 0xBC
	[FormerlySerializedAsAttribute] // RVA: 0xC5E10 Offset: 0xC5210 VA: 0x1800C5E10
	[SerializeField] // RVA: 0xC5E10 Offset: 0xC5210 VA: 0x1800C5E10
	private bool _TrackChangesDuringPlaytime; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int _SortingLayerID; // 0xC4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[ObsoleteAttribute] // RVA: 0xC6140 Offset: 0xC5540 VA: 0x1800C6140
	public void Generate() { }

	public virtual void GenerateGeometry() { }

	public virtual void UpdateAfterManualPropertyChange() { }

	private void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachineAttribute] // RVA: 0xC61E0 Offset: 0xC55E0 VA: 0x1800C61E0
	private IEnumerator CoPlaytimeUpdate() { }

	private void OnDestroy() { }

	private void DestroyBeam() { }

	private void AssignPropertiesFromSpotLight(Light lightSpot) { }

	private void ClampProperties() { }

	private void ValidateProperties() { }

	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	public void .ctor() { }

}

private sealed class VolumetricLightBeam.<CoPlaytimeUpdate>d__98 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11559
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VolumetricLightBeam <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

