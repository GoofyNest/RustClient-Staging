public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 11558
{	// Fields
	public bool colorFromLight; // 0x18
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

	// Properties
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

	// Methods

	// RVA: 0xAE2570 Offset: 0xAE0B70 VA: 0x180AE2570
	public float get_coneAngle() { }

	// RVA: 0xAE2670 Offset: 0xAE0C70 VA: 0x180AE2670
	public float get_coneRadiusEnd() { }

	// RVA: 0xAE2700 Offset: 0xAE0D00 VA: 0x180AE2700
	public float get_coneVolume() { }

	// RVA: 0xAE2610 Offset: 0xAE0C10 VA: 0x180AE2610
	public float get_coneApexOffsetZ() { }

	// RVA: 0xAE27C0 Offset: 0xAE0DC0 VA: 0x180AE27C0
	public int get_geomSides() { }

	// RVA: 0xAE2D80 Offset: 0xAE1380 VA: 0x180AE2D80
	public void set_geomSides(int value) { }

	// RVA: 0xAE2750 Offset: 0xAE0D50 VA: 0x180AE2750
	public int get_geomSegments() { }

	// RVA: 0xAE2D10 Offset: 0xAE1310 VA: 0x180AE2D10
	public void set_geomSegments(int value) { }

	// RVA: 0xAE2310 Offset: 0xAE0910 VA: 0x180AE2310
	public float get_attenuationLerpLinearQuad() { }

	// RVA: 0xAE2CE0 Offset: 0xAE12E0 VA: 0x180AE2CE0
	public int get_sortingLayerID() { }

	// RVA: 0xAE2DF0 Offset: 0xAE13F0 VA: 0x180AE2DF0
	public void set_sortingLayerID(int value) { }

	// RVA: 0xAE2CF0 Offset: 0xAE12F0 VA: 0x180AE2CF0
	public string get_sortingLayerName() { }

	// RVA: 0xAE2E90 Offset: 0xAE1490 VA: 0x180AE2E90
	public void set_sortingLayerName(string value) { }

	// RVA: 0xAE2D00 Offset: 0xAE1300 VA: 0x180AE2D00
	public int get_sortingOrder() { }

	// RVA: 0xAE2F40 Offset: 0xAE1540 VA: 0x180AE2F40
	public void set_sortingOrder(int value) { }

	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	public bool get_trackChangesDuringPlaytime() { }

	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	public void set_trackChangesDuringPlaytime(bool value) { }

	// RVA: 0xAE2890 Offset: 0xAE0E90 VA: 0x180AE2890
	public bool get_isCurrentlyTrackingChanges() { }

	// RVA: 0xAE2830 Offset: 0xAE0E30 VA: 0x180AE2830
	public bool get_hasGeometry() { }

	// RVA: 0xAE2410 Offset: 0xAE0A10 VA: 0x180AE2410
	public Bounds get_bounds() { }

	// RVA: 0xAE1E60 Offset: 0xAE0460 VA: 0x180AE1E60
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0xAE1DD0 Offset: 0xAE03D0 VA: 0x180AE1DD0
	public void SetClippingPlaneOff() { }

	// RVA: 0xAE1B00 Offset: 0xAE0100 VA: 0x180AE1B00
	public bool IsColliderHiddenByDynamicOccluder(Collider collider) { }

	// RVA: 0xAE2330 Offset: 0xAE0930 VA: 0x180AE2330
	public int get_blendingModeAsInt() { }

	// RVA: 0xAE2280 Offset: 0xAE0880 VA: 0x180AE2280
	public MeshRenderer get_Renderer() { }

	// RVA: 0xAE2990 Offset: 0xAE0F90 VA: 0x180AE2990
	public string get_meshStats() { }

	// RVA: 0xAE2C00 Offset: 0xAE1200 VA: 0x180AE2C00
	public int get_meshVerticesCount() { }

	// RVA: 0xAE2B00 Offset: 0xAE1100 VA: 0x180AE2B00
	public int get_meshTrianglesCount() { }

	// RVA: 0xAE28A0 Offset: 0xAE0EA0 VA: 0x180AE28A0
	private Light get_lightSpotAttached() { }

	// RVA: 0xAE1830 Offset: 0xADFE30 VA: 0x180AE1830
	public float GetInsideBeamFactor(Vector3 posWS) { }

	// RVA: 0xAE1630 Offset: 0xADFC30 VA: 0x180AE1630
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	[ObsoleteAttribute] // RVA: 0xC6140 Offset: 0xC5540 VA: 0x1800C6140
	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	public void Generate() { }

	// RVA: 0xAE13F0 Offset: 0xADF9F0 VA: 0x180AE13F0 Slot: 4
	public virtual void GenerateGeometry() { }

	// RVA: 0xAE1F10 Offset: 0xAE0510 VA: 0x180AE1F10 Slot: 5
	public virtual void UpdateAfterManualPropertyChange() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	private void Start() { }

	// RVA: 0xAE1D40 Offset: 0xAE0340 VA: 0x180AE1D40
	private void OnEnable() { }

	// RVA: 0xAE1CA0 Offset: 0xAE02A0 VA: 0x180AE1CA0
	private void OnDisable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachineAttribute] // RVA: 0xC61E0 Offset: 0xC55E0 VA: 0x1800C61E0
	// RVA: 0xAE12B0 Offset: 0xADF8B0 VA: 0x180AE12B0
	private IEnumerator CoPlaytimeUpdate() { }

	// RVA: 0xAE1320 Offset: 0xADF920 VA: 0x180AE1320
	private void OnDestroy() { }

	// RVA: 0xAE1320 Offset: 0xADF920 VA: 0x180AE1320
	private void DestroyBeam() { }

	// RVA: 0xAE1030 Offset: 0xADF630 VA: 0x180AE1030
	private void AssignPropertiesFromSpotLight(Light lightSpot) { }

	// RVA: 0xAE1100 Offset: 0xADF700 VA: 0x180AE1100
	private void ClampProperties() { }

	// RVA: 0xAE1FA0 Offset: 0xAE05A0 VA: 0x180AE1FA0
	private void ValidateProperties() { }

	// RVA: 0xAE1A70 Offset: 0xAE0070 VA: 0x180AE1A70
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0xAE2140 Offset: 0xAE0740 VA: 0x180AE2140
	public void .ctor() { }

}

private sealed class VolumetricLightBeam.<CoPlaytimeUpdate>d__98 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11559
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VolumetricLightBeam <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xAC9ED0 Offset: 0xAC84D0 VA: 0x180AC9ED0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC9F70 Offset: 0xAC8570 VA: 0x180AC9F70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

