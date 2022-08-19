public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 11558
{	// Fields
	public bool colorFromLight; // 0x18
	public ColorMode colorMode; // 0x1C
	[ColorUsageAttribute] // RVA: 0xC4E30 Offset: 0xC4230 VA: 0x1800C4E30
	[FormerlySerializedAsAttribute] // RVA: 0xC4E30 Offset: 0xC4230 VA: 0x1800C4E30
	public Color color; // 0x20
	public Gradient colorGradient; // 0x30
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float alphaInside; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xC5120 Offset: 0xC4520 VA: 0x1800C5120
	[RangeAttribute] // RVA: 0xC5120 Offset: 0xC4520 VA: 0x1800C5120
	public float alphaOutside; // 0x3C
	public BlendingMode blendingMode; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xC51B0 Offset: 0xC45B0 VA: 0x1800C51B0
	public bool spotAngleFromLight; // 0x44
	[RangeAttribute] // RVA: 0xC5260 Offset: 0xC4660 VA: 0x1800C5260
	public float spotAngle; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0xC5390 Offset: 0xC4790 VA: 0x1800C5390
	public float coneRadiusStart; // 0x4C
	public MeshType geomMeshType; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0xC5400 Offset: 0xC4800 VA: 0x1800C5400
	public int geomCustomSides; // 0x54
	public int geomCustomSegments; // 0x58
	public bool geomCap; // 0x5C
	public bool fadeEndFromLight; // 0x5D
	public AttenuationEquation attenuationEquation; // 0x60
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float attenuationCustomBlending; // 0x64
	public float fadeStart; // 0x68
	public float fadeEnd; // 0x6C
	public float depthBlendDistance; // 0x70
	public float cameraClippingDistance; // 0x74
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float glareFrontal; // 0x78
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float glareBehind; // 0x7C
	[ObsoleteAttribute] // RVA: 0xC5800 Offset: 0xC4C00 VA: 0x1800C5800
	public float boostDistanceInside; // 0x80
	[ObsoleteAttribute] // RVA: 0xC5890 Offset: 0xC4C90 VA: 0x1800C5890
	public float fresnelPowInside; // 0x84
	[FormerlySerializedAsAttribute] // RVA: 0xC5990 Offset: 0xC4D90 VA: 0x1800C5990
	public float fresnelPow; // 0x88
	public bool noiseEnabled; // 0x8C
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float noiseIntensity; // 0x90
	public bool noiseScaleUseGlobal; // 0x94
	[RangeAttribute] // RVA: 0xBF2E0 Offset: 0xBE6E0 VA: 0x1800BF2E0
	public float noiseScaleLocal; // 0x98
	public bool noiseVelocityUseGlobal; // 0x9C
	public Vector3 noiseVelocityLocal; // 0xA0
	private Plane m_PlaneWS; // 0xAC
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int pluginVersion; // 0xBC
	[FormerlySerializedAsAttribute] // RVA: 0xC5D40 Offset: 0xC5140 VA: 0x1800C5D40
	[SerializeField] // RVA: 0xC5D40 Offset: 0xC5140 VA: 0x1800C5D40
	private bool _TrackChangesDuringPlaytime; // 0xC0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int _SortingLayerID; // 0xC4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xAE22B0 Offset: 0xAE08B0 VA: 0x180AE22B0
	public float get_coneAngle() { }

	// RVA: 0xAE23B0 Offset: 0xAE09B0 VA: 0x180AE23B0
	public float get_coneRadiusEnd() { }

	// RVA: 0xAE2440 Offset: 0xAE0A40 VA: 0x180AE2440
	public float get_coneVolume() { }

	// RVA: 0xAE2350 Offset: 0xAE0950 VA: 0x180AE2350
	public float get_coneApexOffsetZ() { }

	// RVA: 0xAE2500 Offset: 0xAE0B00 VA: 0x180AE2500
	public int get_geomSides() { }

	// RVA: 0xAE2AC0 Offset: 0xAE10C0 VA: 0x180AE2AC0
	public void set_geomSides(int value) { }

	// RVA: 0xAE2490 Offset: 0xAE0A90 VA: 0x180AE2490
	public int get_geomSegments() { }

	// RVA: 0xAE2A50 Offset: 0xAE1050 VA: 0x180AE2A50
	public void set_geomSegments(int value) { }

	// RVA: 0xAE2050 Offset: 0xAE0650 VA: 0x180AE2050
	public float get_attenuationLerpLinearQuad() { }

	// RVA: 0xAE2A20 Offset: 0xAE1020 VA: 0x180AE2A20
	public int get_sortingLayerID() { }

	// RVA: 0xAE2B30 Offset: 0xAE1130 VA: 0x180AE2B30
	public void set_sortingLayerID(int value) { }

	// RVA: 0xAE2A30 Offset: 0xAE1030 VA: 0x180AE2A30
	public string get_sortingLayerName() { }

	// RVA: 0xAE2BD0 Offset: 0xAE11D0 VA: 0x180AE2BD0
	public void set_sortingLayerName(string value) { }

	// RVA: 0xAE2A40 Offset: 0xAE1040 VA: 0x180AE2A40
	public int get_sortingOrder() { }

	// RVA: 0xAE2C80 Offset: 0xAE1280 VA: 0x180AE2C80
	public void set_sortingOrder(int value) { }

	// RVA: 0x56EAF0 Offset: 0x56D0F0 VA: 0x18056EAF0
	public bool get_trackChangesDuringPlaytime() { }

	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	public void set_trackChangesDuringPlaytime(bool value) { }

	// RVA: 0xAE25D0 Offset: 0xAE0BD0 VA: 0x180AE25D0
	public bool get_isCurrentlyTrackingChanges() { }

	// RVA: 0xAE2570 Offset: 0xAE0B70 VA: 0x180AE2570
	public bool get_hasGeometry() { }

	// RVA: 0xAE2150 Offset: 0xAE0750 VA: 0x180AE2150
	public Bounds get_bounds() { }

	// RVA: 0xAE1BA0 Offset: 0xAE01A0 VA: 0x180AE1BA0
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0xAE1B10 Offset: 0xAE0110 VA: 0x180AE1B10
	public void SetClippingPlaneOff() { }

	// RVA: 0xAE1840 Offset: 0xADFE40 VA: 0x180AE1840
	public bool IsColliderHiddenByDynamicOccluder(Collider collider) { }

	// RVA: 0xAE2070 Offset: 0xAE0670 VA: 0x180AE2070
	public int get_blendingModeAsInt() { }

	// RVA: 0xAE1FC0 Offset: 0xAE05C0 VA: 0x180AE1FC0
	public MeshRenderer get_Renderer() { }

	// RVA: 0xAE26D0 Offset: 0xAE0CD0 VA: 0x180AE26D0
	public string get_meshStats() { }

	// RVA: 0xAE2940 Offset: 0xAE0F40 VA: 0x180AE2940
	public int get_meshVerticesCount() { }

	// RVA: 0xAE2840 Offset: 0xAE0E40 VA: 0x180AE2840
	public int get_meshTrianglesCount() { }

	// RVA: 0xAE25E0 Offset: 0xAE0BE0 VA: 0x180AE25E0
	private Light get_lightSpotAttached() { }

	// RVA: 0xAE1570 Offset: 0xADFB70 VA: 0x180AE1570
	public float GetInsideBeamFactor(Vector3 posWS) { }

	// RVA: 0xAE1370 Offset: 0xADF970 VA: 0x180AE1370
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	[ObsoleteAttribute] // RVA: 0xC6020 Offset: 0xC5420 VA: 0x1800C6020
	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	public void Generate() { }

	// RVA: 0xAE1130 Offset: 0xADF730 VA: 0x180AE1130 Slot: 4
	public virtual void GenerateGeometry() { }

	// RVA: 0xAE1C50 Offset: 0xAE0250 VA: 0x180AE1C50 Slot: 5
	public virtual void UpdateAfterManualPropertyChange() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	private void Start() { }

	// RVA: 0xAE1A80 Offset: 0xAE0080 VA: 0x180AE1A80
	private void OnEnable() { }

	// RVA: 0xAE19E0 Offset: 0xADFFE0 VA: 0x180AE19E0
	private void OnDisable() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachineAttribute] // RVA: 0xC6120 Offset: 0xC5520 VA: 0x1800C6120
	// RVA: 0xAE0FF0 Offset: 0xADF5F0 VA: 0x180AE0FF0
	private IEnumerator CoPlaytimeUpdate() { }

	// RVA: 0xAE1060 Offset: 0xADF660 VA: 0x180AE1060
	private void OnDestroy() { }

	// RVA: 0xAE1060 Offset: 0xADF660 VA: 0x180AE1060
	private void DestroyBeam() { }

	// RVA: 0xAE0D70 Offset: 0xADF370 VA: 0x180AE0D70
	private void AssignPropertiesFromSpotLight(Light lightSpot) { }

	// RVA: 0xAE0E40 Offset: 0xADF440 VA: 0x180AE0E40
	private void ClampProperties() { }

	// RVA: 0xAE1CE0 Offset: 0xAE02E0 VA: 0x180AE1CE0
	private void ValidateProperties() { }

	// RVA: 0xAE17B0 Offset: 0xADFDB0 VA: 0x180AE17B0
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0xAE1E80 Offset: 0xAE0480 VA: 0x180AE1E80
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xAC9C10 Offset: 0xAC8210 VA: 0x180AC9C10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAC9CB0 Offset: 0xAC82B0 VA: 0x180AC9CB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

