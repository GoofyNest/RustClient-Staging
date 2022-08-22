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

	// RVA: 0xAE2A40 Offset: 0xAE1040 VA: 0x180AE2A40
	public float get_coneAngle() { }

	// RVA: 0xAE2B40 Offset: 0xAE1140 VA: 0x180AE2B40
	public float get_coneRadiusEnd() { }

	// RVA: 0xAE2BD0 Offset: 0xAE11D0 VA: 0x180AE2BD0
	public float get_coneVolume() { }

	// RVA: 0xAE2AE0 Offset: 0xAE10E0 VA: 0x180AE2AE0
	public float get_coneApexOffsetZ() { }

	// RVA: 0xAE2C90 Offset: 0xAE1290 VA: 0x180AE2C90
	public int get_geomSides() { }

	// RVA: 0xAE3250 Offset: 0xAE1850 VA: 0x180AE3250
	public void set_geomSides(int value) { }

	// RVA: 0xAE2C20 Offset: 0xAE1220 VA: 0x180AE2C20
	public int get_geomSegments() { }

	// RVA: 0xAE31E0 Offset: 0xAE17E0 VA: 0x180AE31E0
	public void set_geomSegments(int value) { }

	// RVA: 0xAE27E0 Offset: 0xAE0DE0 VA: 0x180AE27E0
	public float get_attenuationLerpLinearQuad() { }

	// RVA: 0xAE31B0 Offset: 0xAE17B0 VA: 0x180AE31B0
	public int get_sortingLayerID() { }

	// RVA: 0xAE32C0 Offset: 0xAE18C0 VA: 0x180AE32C0
	public void set_sortingLayerID(int value) { }

	// RVA: 0xAE31C0 Offset: 0xAE17C0 VA: 0x180AE31C0
	public string get_sortingLayerName() { }

	// RVA: 0xAE3360 Offset: 0xAE1960 VA: 0x180AE3360
	public void set_sortingLayerName(string value) { }

	// RVA: 0xAE31D0 Offset: 0xAE17D0 VA: 0x180AE31D0
	public int get_sortingOrder() { }

	// RVA: 0xAE3410 Offset: 0xAE1A10 VA: 0x180AE3410
	public void set_sortingOrder(int value) { }

	// RVA: 0x56EA80 Offset: 0x56D080 VA: 0x18056EA80
	public bool get_trackChangesDuringPlaytime() { }

	// RVA: 0x56EA90 Offset: 0x56D090 VA: 0x18056EA90
	public void set_trackChangesDuringPlaytime(bool value) { }

	// RVA: 0xAE2D60 Offset: 0xAE1360 VA: 0x180AE2D60
	public bool get_isCurrentlyTrackingChanges() { }

	// RVA: 0xAE2D00 Offset: 0xAE1300 VA: 0x180AE2D00
	public bool get_hasGeometry() { }

	// RVA: 0xAE28E0 Offset: 0xAE0EE0 VA: 0x180AE28E0
	public Bounds get_bounds() { }

	// RVA: 0xAE2330 Offset: 0xAE0930 VA: 0x180AE2330
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0xAE22A0 Offset: 0xAE08A0 VA: 0x180AE22A0
	public void SetClippingPlaneOff() { }

	// RVA: 0xAE1FD0 Offset: 0xAE05D0 VA: 0x180AE1FD0
	public bool IsColliderHiddenByDynamicOccluder(Collider collider) { }

	// RVA: 0xAE2800 Offset: 0xAE0E00 VA: 0x180AE2800
	public int get_blendingModeAsInt() { }

	// RVA: 0xAE2750 Offset: 0xAE0D50 VA: 0x180AE2750
	public MeshRenderer get_Renderer() { }

	// RVA: 0xAE2E60 Offset: 0xAE1460 VA: 0x180AE2E60
	public string get_meshStats() { }

	// RVA: 0xAE30D0 Offset: 0xAE16D0 VA: 0x180AE30D0
	public int get_meshVerticesCount() { }

	// RVA: 0xAE2FD0 Offset: 0xAE15D0 VA: 0x180AE2FD0
	public int get_meshTrianglesCount() { }

	// RVA: 0xAE2D70 Offset: 0xAE1370 VA: 0x180AE2D70
	private Light get_lightSpotAttached() { }

	// RVA: 0xAE1D00 Offset: 0xAE0300 VA: 0x180AE1D00
	public float GetInsideBeamFactor(Vector3 posWS) { }

	// RVA: 0xAE1B00 Offset: 0xAE0100 VA: 0x180AE1B00
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	[ObsoleteAttribute] // RVA: 0xC6140 Offset: 0xC5540 VA: 0x1800C6140
	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40
	public void Generate() { }

	// RVA: 0xAE18C0 Offset: 0xADFEC0 VA: 0x180AE18C0 Slot: 4
	public virtual void GenerateGeometry() { }

	// RVA: 0xAE23E0 Offset: 0xAE09E0 VA: 0x180AE23E0 Slot: 5
	public virtual void UpdateAfterManualPropertyChange() { }

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40
	private void Start() { }

	// RVA: 0xAE2210 Offset: 0xAE0810 VA: 0x180AE2210
	private void OnEnable() { }

	// RVA: 0xAE2170 Offset: 0xAE0770 VA: 0x180AE2170
	private void OnDisable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachineAttribute] // RVA: 0xC61E0 Offset: 0xC55E0 VA: 0x1800C61E0
	// RVA: 0xAE1780 Offset: 0xADFD80 VA: 0x180AE1780
	private IEnumerator CoPlaytimeUpdate() { }

	// RVA: 0xAE17F0 Offset: 0xADFDF0 VA: 0x180AE17F0
	private void OnDestroy() { }

	// RVA: 0xAE17F0 Offset: 0xADFDF0 VA: 0x180AE17F0
	private void DestroyBeam() { }

	// RVA: 0xAE1500 Offset: 0xADFB00 VA: 0x180AE1500
	private void AssignPropertiesFromSpotLight(Light lightSpot) { }

	// RVA: 0xAE15D0 Offset: 0xADFBD0 VA: 0x180AE15D0
	private void ClampProperties() { }

	// RVA: 0xAE2470 Offset: 0xAE0A70 VA: 0x180AE2470
	private void ValidateProperties() { }

	// RVA: 0xAE1F40 Offset: 0xAE0540 VA: 0x180AE1F40
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0xAE2610 Offset: 0xAE0C10 VA: 0x180AE2610
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

	// RVA: 0xACA3A0 Offset: 0xAC89A0 VA: 0x180ACA3A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xACA440 Offset: 0xAC8A40 VA: 0x180ACA440 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

