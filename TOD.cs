public class TOD_Animation : MonoBehaviour // TypeDefIndex: 8068
{	// Fields
	[TooltipAttribute] // RVA: 0xE6770 Offset: 0xE5B70 VA: 0x1800E6770
	[TOD_MinAttribute] // RVA: 0xE6770 Offset: 0xE5B70 VA: 0x1800E6770
	public float CameraMovement; // 0x18
	[TooltipAttribute] // RVA: 0xE69F0 Offset: 0xE5DF0 VA: 0x1800E69F0
	[TOD_RangeAttribute] // RVA: 0xE69F0 Offset: 0xE5DF0 VA: 0x1800E69F0
	public float WindDegrees; // 0x1C
	[TooltipAttribute] // RVA: 0xE6B50 Offset: 0xE5F50 VA: 0x1800E6B50
	[TOD_MinAttribute] // RVA: 0xE6B50 Offset: 0xE5F50 VA: 0x1800E6B50
	public float WindSpeed; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <CloudUV>k__BackingField; // 0x24
	private TOD_Sky sky; // 0x30

	// Properties
	public Vector3 CloudUV { get; set; }
	public Vector3 OffsetUV { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10745E0 Offset: 0x1072BE0 VA: 0x1810745E0
	public Vector3 get_CloudUV() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10747C0 Offset: 0x1072DC0 VA: 0x1810747C0
	public void set_CloudUV(Vector3 value) { }

	// RVA: 0x1074600 Offset: 0x1072C00 VA: 0x181074600
	public Vector3 get_OffsetUV() { }

	// RVA: 0x10742F0 Offset: 0x10728F0 VA: 0x1810742F0
	protected void Start() { }

	// RVA: 0x10743A0 Offset: 0x10729A0 VA: 0x1810743A0
	public void Update() { }

	// RVA: 0x10745C0 Offset: 0x1072BC0 VA: 0x1810745C0
	public void .ctor() { }

}

public class TOD_MinAttribute : PropertyAttribute // TypeDefIndex: 8069
{	// Fields
	public float min; // 0x10

	// Methods

	// RVA: 0x5A4EE0 Offset: 0x5A34E0 VA: 0x1805A4EE0
	public void .ctor(float min) { }

}

public class TOD_MaxAttribute : PropertyAttribute // TypeDefIndex: 8070
{	// Fields
	public float max; // 0x10

	// Methods

	// RVA: 0x5A4EE0 Offset: 0x5A34E0 VA: 0x1805A4EE0
	public void .ctor(float max) { }

}

public class TOD_RangeAttribute : PropertyAttribute // TypeDefIndex: 8071
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x764DE0 Offset: 0x7633E0 VA: 0x180764DE0
	public void .ctor(float min, float max) { }

}

public class TOD_Billboard : MonoBehaviour // TypeDefIndex: 8072
{	// Fields
	public float Altitude; // 0x18
	public float Azimuth; // 0x1C
	public float Distance; // 0x20
	public float Size; // 0x24

	// Methods

	// RVA: -1 Offset: -1
	private T GetComponentInParents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0340 Offset: 0xBDE940 VA: 0x180BE0340
	|-TOD_Billboard.GetComponentInParents<object>
	*/

	// RVA: 0x692FF0 Offset: 0x6915F0 VA: 0x180692FF0
	public void .ctor() { }

}

public class TOD_Camera : MonoBehaviour // TypeDefIndex: 8073
{	// Fields
	public TOD_Sky sky; // 0x18
	public bool DomePosToCamera; // 0x20
	public Vector3 DomePosOffset; // 0x24
	public bool DomeScaleToFarClip; // 0x30
	public float DomeScaleFactor; // 0x34
	private Camera cameraComponent; // 0x38
	private Transform cameraTransform; // 0x40

	// Properties
	public bool HDR { get; }
	public float NearClipPlane { get; }
	public float FarClipPlane { get; }
	public Color BackgroundColor { get; }

	// Methods

	// RVA: 0x1075B40 Offset: 0x1074140 VA: 0x181075B40
	public bool get_HDR() { }

	// RVA: 0x1075BD0 Offset: 0x10741D0 VA: 0x181075BD0
	public float get_NearClipPlane() { }

	// RVA: 0x1075AB0 Offset: 0x10740B0 VA: 0x181075AB0
	public float get_FarClipPlane() { }

	// RVA: 0x1075A00 Offset: 0x1074000 VA: 0x181075A00
	public Color get_BackgroundColor() { }

	// RVA: 0x10756C0 Offset: 0x1073CC0 VA: 0x1810756C0
	protected void OnValidate() { }

	// RVA: 0x1075310 Offset: 0x1073910 VA: 0x181075310
	protected void OnEnable() { }

	// RVA: 0x1075740 Offset: 0x1073D40 VA: 0x181075740
	protected void Update() { }

	// RVA: 0x10753E0 Offset: 0x10739E0 VA: 0x1810753E0
	protected void OnPreCull() { }

	// RVA: 0x1075190 Offset: 0x1073790 VA: 0x181075190
	private TOD_Sky FindSky(bool fallback = False) { }

	// RVA: 0x10750F0 Offset: 0x10736F0 VA: 0x1810750F0
	public void DoDomeScaleToFarClip() { }

	// RVA: 0x1074F60 Offset: 0x1073560 VA: 0x181074F60
	public void DoDomePosToCamera() { }

	// RVA: 0x1075980 Offset: 0x1073F80 VA: 0x181075980
	public void .ctor() { }

}

public class TOD_Components : MonoBehaviour // TypeDefIndex: 8074
{	// Fields
	public GameObject Space; // 0x18
	public GameObject Stars; // 0x20
	public GameObject Sun; // 0x28
	public GameObject Moon; // 0x30
	public GameObject Atmosphere; // 0x38
	public GameObject Clear; // 0x40
	public GameObject Clouds; // 0x48
	public GameObject Billboards; // 0x50
	public GameObject Light; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <DomeTransform>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <SpaceTransform>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <StarTransform>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <SunTransform>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <MoonTransform>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <AtmosphereTransform>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <ClearTransform>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <CloudTransform>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <BillboardTransform>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <LightTransform>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <SpaceRenderer>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <StarRenderer>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <SunRenderer>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <MoonRenderer>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <AtmosphereRenderer>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <ClearRenderer>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <CloudRenderer>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer[] <BillboardRenderers>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <SpaceMeshFilter>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <StarMeshFilter>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <SunMeshFilter>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <MoonMeshFilter>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <AtmosphereMeshFilter>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <ClearMeshFilter>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <CloudMeshFilter>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter[] <BillboardMeshFilters>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <SpaceMaterial>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <StarMaterial>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <SunMaterial>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <MoonMaterial>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <AtmosphereMaterial>k__BackingField; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <ClearMaterial>k__BackingField; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <CloudMaterial>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material[] <BillboardMaterials>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Light <LightSource>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Sky <Sky>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Animation <Animation>k__BackingField; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Time <Time>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Camera <Camera>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Rays <Rays>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Scattering <Scattering>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Shadows <Shadows>k__BackingField; // 0x1A8

	// Properties
	public Transform DomeTransform { get; set; }
	public Transform SpaceTransform { get; set; }
	public Transform StarTransform { get; set; }
	public Transform SunTransform { get; set; }
	public Transform MoonTransform { get; set; }
	public Transform AtmosphereTransform { get; set; }
	public Transform ClearTransform { get; set; }
	public Transform CloudTransform { get; set; }
	public Transform BillboardTransform { get; set; }
	public Transform LightTransform { get; set; }
	public Renderer SpaceRenderer { get; set; }
	public Renderer StarRenderer { get; set; }
	public Renderer SunRenderer { get; set; }
	public Renderer MoonRenderer { get; set; }
	public Renderer AtmosphereRenderer { get; set; }
	public Renderer ClearRenderer { get; set; }
	public Renderer CloudRenderer { get; set; }
	public Renderer[] BillboardRenderers { get; set; }
	public MeshFilter SpaceMeshFilter { get; set; }
	public MeshFilter StarMeshFilter { get; set; }
	public MeshFilter SunMeshFilter { get; set; }
	public MeshFilter MoonMeshFilter { get; set; }
	public MeshFilter AtmosphereMeshFilter { get; set; }
	public MeshFilter ClearMeshFilter { get; set; }
	public MeshFilter CloudMeshFilter { get; set; }
	public MeshFilter[] BillboardMeshFilters { get; set; }
	public Material SpaceMaterial { get; set; }
	public Material StarMaterial { get; set; }
	public Material SunMaterial { get; set; }
	public Material MoonMaterial { get; set; }
	public Material AtmosphereMaterial { get; set; }
	public Material ClearMaterial { get; set; }
	public Material CloudMaterial { get; set; }
	public Material[] BillboardMaterials { get; set; }
	public Light LightSource { get; set; }
	public TOD_Sky Sky { get; set; }
	public TOD_Animation Animation { get; set; }
	public TOD_Time Time { get; set; }
	public TOD_Camera Camera { get; set; }
	public TOD_Rays Rays { get; set; }
	public TOD_Scattering Scattering { get; set; }
	public TOD_Shadows Shadows { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public Transform get_DomeTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_DomeTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public Transform get_SpaceTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	public void set_SpaceTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public Transform get_StarTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	public void set_StarTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public Transform get_SunTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	public void set_SunTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public Transform get_MoonTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	public void set_MoonTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public Transform get_AtmosphereTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_AtmosphereTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public Transform get_ClearTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E4060 Offset: 0x4E2660 VA: 0x1804E4060
	public void set_ClearTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public Transform get_CloudTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	public void set_CloudTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public Transform get_BillboardTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_BillboardTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public Transform get_LightTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73C90 Offset: 0xC72290 VA: 0x180C73C90
	public void set_LightTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	public Renderer get_SpaceRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D220 Offset: 0xA4B820 VA: 0x180A4D220
	public void set_SpaceRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public Renderer get_StarRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	public void set_StarRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x104F1B0 Offset: 0x104D7B0 VA: 0x18104F1B0
	public Renderer get_SunRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEFAF20 Offset: 0xEF9520 VA: 0x180EFAF20
	public void set_SunRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA00E0 Offset: 0xD9E6E0 VA: 0x180DA00E0
	public Renderer get_MoonRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA04C0 Offset: 0xD9EAC0 VA: 0x180DA04C0
	public void set_MoonRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73A80 Offset: 0xC72080 VA: 0x180C73A80
	public Renderer get_AtmosphereRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73BD0 Offset: 0xC721D0 VA: 0x180C73BD0
	public void set_AtmosphereRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD9F470 Offset: 0xD9DA70 VA: 0x180D9F470
	public Renderer get_ClearRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD35070 Offset: 0xD33670 VA: 0x180D35070
	public void set_ClearRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3A0 Offset: 0x4ED9A0 VA: 0x1804EF3A0
	public Renderer get_CloudRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF3B0 Offset: 0x4ED9B0 VA: 0x1804EF3B0
	public void set_CloudRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872140 Offset: 0x870740 VA: 0x180872140
	public Renderer[] get_BillboardRenderers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8721C0 Offset: 0x8707C0 VA: 0x1808721C0
	public void set_BillboardRenderers(Renderer[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public MeshFilter get_SpaceMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076700 Offset: 0x1074D00 VA: 0x181076700
	public void set_SpaceMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB0EDC0 Offset: 0xB0D3C0 VA: 0x180B0EDC0
	public MeshFilter get_StarMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076720 Offset: 0x1074D20 VA: 0x181076720
	public void set_StarMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2A920 Offset: 0xA28F20 VA: 0x180A2A920
	public MeshFilter get_SunMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AC20 Offset: 0xA29220 VA: 0x180A2AC20
	public void set_SunMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC831A0 Offset: 0xC817A0 VA: 0x180C831A0
	public MeshFilter get_MoonMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10766C0 Offset: 0x1074CC0 VA: 0x1810766C0
	public void set_MoonMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871D30 Offset: 0x870330 VA: 0x180871D30
	public MeshFilter get_AtmosphereMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872180 Offset: 0x870780 VA: 0x180872180
	public void set_AtmosphereMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66340 Offset: 0xE64940 VA: 0x180E66340
	public MeshFilter get_ClearMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE65A00 Offset: 0xE64000 VA: 0x180E65A00
	public void set_ClearMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7DDC60 Offset: 0x7DC260 VA: 0x1807DDC60
	public MeshFilter get_CloudMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73C70 Offset: 0xC72270 VA: 0x180C73C70
	public void set_CloudMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C12E0 Offset: 0x4BF8E0 VA: 0x1804C12E0
	public MeshFilter[] get_BillboardMeshFilters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C13B0 Offset: 0x4BF9B0 VA: 0x1804C13B0
	public void set_BillboardMeshFilters(MeshFilter[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701810 Offset: 0x6FFE10 VA: 0x180701810
	public Material get_SpaceMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7018A0 Offset: 0x6FFEA0 VA: 0x1807018A0
	public void set_SpaceMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBC72B0 Offset: 0xBC58B0 VA: 0x180BC72B0
	public Material get_StarMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076710 Offset: 0x1074D10 VA: 0x181076710
	public void set_StarMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD618A0 Offset: 0xD5FEA0 VA: 0x180D618A0
	public Material get_SunMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD618B0 Offset: 0xD5FEB0 VA: 0x180D618B0
	public void set_SunMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076620 Offset: 0x1074C20 VA: 0x181076620
	public Material get_MoonMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10766B0 Offset: 0x1074CB0 VA: 0x1810766B0
	public void set_MoonMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076610 Offset: 0x1074C10 VA: 0x181076610
	public Material get_AtmosphereMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076660 Offset: 0x1074C60 VA: 0x181076660
	public void set_AtmosphereMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83160 Offset: 0xC81760 VA: 0x180C83160
	public Material get_ClearMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076680 Offset: 0x1074C80 VA: 0x181076680
	public void set_ClearMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E6DA0 Offset: 0x7E53A0 VA: 0x1807E6DA0
	public Material get_CloudMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076690 Offset: 0x1074C90 VA: 0x181076690
	public void set_CloudMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3C6F0 Offset: 0xA3ACF0 VA: 0x180A3C6F0
	public Material[] get_BillboardMaterials() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076670 Offset: 0x1074C70 VA: 0x181076670
	public void set_BillboardMaterials(Material[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x900010 Offset: 0x8FE610 VA: 0x180900010
	public Light get_LightSource() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10766A0 Offset: 0x1074CA0 VA: 0x1810766A0
	public void set_LightSource(Light value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83190 Offset: 0xC81790 VA: 0x180C83190
	public TOD_Sky get_Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD43690 Offset: 0xD41C90 VA: 0x180D43690
	public void set_Sky(TOD_Sky value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83170 Offset: 0xC81770 VA: 0x180C83170
	public TOD_Animation get_Animation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076650 Offset: 0x1074C50 VA: 0x181076650
	public void set_Animation(TOD_Animation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB0E690 Offset: 0xB0CC90 VA: 0x180B0E690
	public TOD_Time get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076730 Offset: 0x1074D30 VA: 0x181076730
	public void set_Time(TOD_Time value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73B70 Offset: 0xC72170 VA: 0x180C73B70
	public TOD_Camera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73C80 Offset: 0xC72280 VA: 0x180C73C80
	public void set_Camera(TOD_Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD8B30 Offset: 0xAD7130 VA: 0x180AD8B30
	public TOD_Rays get_Rays() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10766D0 Offset: 0x1074CD0 VA: 0x1810766D0
	public void set_Rays(TOD_Rays value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076630 Offset: 0x1074C30 VA: 0x181076630
	public TOD_Scattering get_Scattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10766E0 Offset: 0x1074CE0 VA: 0x1810766E0
	public void set_Scattering(TOD_Scattering value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1076640 Offset: 0x1074C40 VA: 0x181076640
	public TOD_Shadows get_Shadows() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10766F0 Offset: 0x1074CF0 VA: 0x1810766F0
	public void set_Shadows(TOD_Shadows value) { }

	// RVA: 0x1075CB0 Offset: 0x10742B0 VA: 0x181075CB0
	public void Initialize() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum TOD_MoonPositionType // TypeDefIndex: 8075
{	// Fields
	public int value__; // 0x0
	public const TOD_MoonPositionType OppositeToSun = 0;
	public const TOD_MoonPositionType Realistic = 1;

}

public enum TOD_StarsPositionType // TypeDefIndex: 8076
{	// Fields
	public int value__; // 0x0
	public const TOD_StarsPositionType Static = 0;
	public const TOD_StarsPositionType Rotating = 1;

}

public enum TOD_FogType // TypeDefIndex: 8077
{	// Fields
	public int value__; // 0x0
	public const TOD_FogType None = 0;
	public const TOD_FogType Atmosphere = 1;
	public const TOD_FogType Directional = 2;
	public const TOD_FogType Gradient = 3;

}

public enum TOD_AmbientType // TypeDefIndex: 8078
{	// Fields
	public int value__; // 0x0
	public const TOD_AmbientType None = 0;
	public const TOD_AmbientType Color = 1;
	public const TOD_AmbientType Gradient = 2;
	public const TOD_AmbientType Spherical = 3;

}

public enum TOD_ReflectionType // TypeDefIndex: 8079
{	// Fields
	public int value__; // 0x0
	public const TOD_ReflectionType None = 0;
	public const TOD_ReflectionType Cubemap = 1;

}

public enum TOD_ColorSpaceType // TypeDefIndex: 8080
{	// Fields
	public int value__; // 0x0
	public const TOD_ColorSpaceType Auto = 0;
	public const TOD_ColorSpaceType Linear = 1;
	public const TOD_ColorSpaceType Gamma = 2;

}

public enum TOD_ColorRangeType // TypeDefIndex: 8081
{	// Fields
	public int value__; // 0x0
	public const TOD_ColorRangeType Auto = 0;
	public const TOD_ColorRangeType HDR = 1;
	public const TOD_ColorRangeType LDR = 2;

}

public enum TOD_ColorOutputType // TypeDefIndex: 8082
{	// Fields
	public int value__; // 0x0
	public const TOD_ColorOutputType Raw = 0;
	public const TOD_ColorOutputType Dithered = 1;

}

public enum TOD_CloudQualityType // TypeDefIndex: 8083
{	// Fields
	public int value__; // 0x0
	public const TOD_CloudQualityType Low = 0;
	public const TOD_CloudQualityType Medium = 1;
	public const TOD_CloudQualityType High = 2;

}

public enum TOD_MeshQualityType // TypeDefIndex: 8084
{	// Fields
	public int value__; // 0x0
	public const TOD_MeshQualityType Low = 0;
	public const TOD_MeshQualityType Medium = 1;
	public const TOD_MeshQualityType High = 2;

}

public enum TOD_StarQualityType // TypeDefIndex: 8085
{	// Fields
	public int value__; // 0x0
	public const TOD_StarQualityType Low = 0;
	public const TOD_StarQualityType Medium = 1;
	public const TOD_StarQualityType High = 2;

}

public enum TOD_SkyQualityType // TypeDefIndex: 8086
{	// Fields
	public int value__; // 0x0
	public const TOD_SkyQualityType PerVertex = 0;
	public const TOD_SkyQualityType PerPixel = 1;

}

public abstract class TOD_ImageEffect : MonoBehaviour // TypeDefIndex: 8087
{	// Fields
	public TOD_Sky sky; // 0x18
	protected Camera cam; // 0x20
	private bool supportsDepth; // 0x28
	private bool supportsHdr; // 0x29
	private static Vector3[] frustumCornersArray; // 0x0

	// Methods

	// RVA: 0x1076E70 Offset: 0x1075470 VA: 0x181076E70
	protected Material CreateMaterial(Shader shader) { }

	// RVA: 0x1077200 Offset: 0x1075800 VA: 0x181077200
	private TOD_Sky FindSky(bool fallback = False) { }

	// RVA: 0x1076AF0 Offset: 0x10750F0 VA: 0x181076AF0
	protected void Awake() { }

	// RVA: 0x1076BF0 Offset: 0x10751F0 VA: 0x181076BF0
	protected bool CheckSupport(bool needDepth = False, bool needHdr = False) { }

	// RVA: 0x8D5B70 Offset: 0x8D4170 VA: 0x1808D5B70
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x1077380 Offset: 0x1075980 VA: 0x181077380
	protected Matrix4x4 FrustumCorners() { }

	// RVA: 0x1077830 Offset: 0x1075E30 VA: 0x181077830
	protected RenderTexture GetSkyMask(RenderTexture source, Material skyMaskMaterial, Material screenClearMaterial, TOD_ImageEffect.ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x1077DE0 Offset: 0x10763E0 VA: 0x181077DE0
	private static void .cctor() { }

}

public enum TOD_ImageEffect.ResolutionType // TypeDefIndex: 8088
{	// Fields
	public int value__; // 0x0
	public const TOD_ImageEffect.ResolutionType Low = 0;
	public const TOD_ImageEffect.ResolutionType Normal = 1;
	public const TOD_ImageEffect.ResolutionType High = 2;

}

public class TOD_Parameters // TypeDefIndex: 8089
{	// Fields
	public TOD_CycleParameters Cycle; // 0x10
	public TOD_WorldParameters World; // 0x18
	public TOD_AtmosphereParameters Atmosphere; // 0x20
	public TOD_DayParameters Day; // 0x28
	public TOD_NightParameters Night; // 0x30
	public TOD_SunParameters Sun; // 0x38
	public TOD_MoonParameters Moon; // 0x40
	public TOD_LightParameters Light; // 0x48
	public TOD_StarParameters Stars; // 0x50
	public TOD_CloudParameters Clouds; // 0x58
	public TOD_FogParameters Fog; // 0x60
	public TOD_AmbientParameters Ambient; // 0x68
	public TOD_ReflectionParameters Reflection; // 0x70

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1078810 Offset: 0x1076E10 VA: 0x181078810
	public void .ctor(TOD_Sky sky) { }

	// RVA: 0x1078700 Offset: 0x1076D00 VA: 0x181078700
	public void ToSky(TOD_Sky sky) { }

}

public class TOD_CycleParameters // TypeDefIndex: 8090
{	// Fields
	[TooltipAttribute] // RVA: 0xF0100 Offset: 0xEF500 VA: 0x1800F0100
	public float Hour; // 0x10
	[TooltipAttribute] // RVA: 0xF01A0 Offset: 0xEF5A0 VA: 0x1800F01A0
	public int Day; // 0x14
	[TooltipAttribute] // RVA: 0xF0240 Offset: 0xEF640 VA: 0x1800F0240
	public int Month; // 0x18
	[TooltipAttribute] // RVA: 0xF0390 Offset: 0xEF790 VA: 0x1800F0390
	[TOD_RangeAttribute] // RVA: 0xF0390 Offset: 0xEF790 VA: 0x1800F0390
	public int Year; // 0x1C

	// Properties
	public DateTime DateTime { get; set; }
	public long Ticks { get; set; }

	// Methods

	// RVA: 0x1076770 Offset: 0x1074D70 VA: 0x181076770
	public DateTime get_DateTime() { }

	// RVA: 0x10768E0 Offset: 0x1074EE0 VA: 0x1810768E0
	public void set_DateTime(DateTime value) { }

	// RVA: 0x1076820 Offset: 0x1074E20 VA: 0x181076820
	public long get_Ticks() { }

	// RVA: 0x10769C0 Offset: 0x1074FC0 VA: 0x1810769C0
	public void set_Ticks(long value) { }

	// RVA: 0x1076740 Offset: 0x1074D40 VA: 0x181076740
	public void .ctor() { }

}

public class TOD_WorldParameters // TypeDefIndex: 8091
{	// Fields
	[TooltipAttribute] // RVA: 0xF0460 Offset: 0xEF860 VA: 0x1800F0460
	[RangeAttribute] // RVA: 0xF0460 Offset: 0xEF860 VA: 0x1800F0460
	public float Latitude; // 0x10
	[TooltipAttribute] // RVA: 0xF0580 Offset: 0xEF980 VA: 0x1800F0580
	[RangeAttribute] // RVA: 0xF0580 Offset: 0xEF980 VA: 0x1800F0580
	public float Longitude; // 0x14
	[TooltipAttribute] // RVA: 0xF0770 Offset: 0xEFB70 VA: 0x1800F0770
	[RangeAttribute] // RVA: 0xF0770 Offset: 0xEFB70 VA: 0x1800F0770
	public float UTC; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class TOD_AtmosphereParameters // TypeDefIndex: 8092
{	// Fields
	[TooltipAttribute] // RVA: 0xF0960 Offset: 0xEFD60 VA: 0x1800F0960
	[TOD_MinAttribute] // RVA: 0xF0960 Offset: 0xEFD60 VA: 0x1800F0960
	public float RayleighMultiplier; // 0x10
	[TooltipAttribute] // RVA: 0xF0B30 Offset: 0xEFF30 VA: 0x1800F0B30
	[TOD_MinAttribute] // RVA: 0xF0B30 Offset: 0xEFF30 VA: 0x1800F0B30
	public float MieMultiplier; // 0x14
	[TooltipAttribute] // RVA: 0xF0D90 Offset: 0xF0190 VA: 0x1800F0D90
	[TOD_MinAttribute] // RVA: 0xF0D90 Offset: 0xF0190 VA: 0x1800F0D90
	public float Brightness; // 0x18
	[TooltipAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	[TOD_MinAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	public float Contrast; // 0x1C
	[TooltipAttribute] // RVA: 0x6F5E0 Offset: 0x6E9E0 VA: 0x18006F5E0
	[TOD_RangeAttribute] // RVA: 0x6F5E0 Offset: 0x6E9E0 VA: 0x18006F5E0
	public float Directionality; // 0x20
	[TooltipAttribute] // RVA: 0x6FA00 Offset: 0x6EE00 VA: 0x18006FA00
	[TOD_RangeAttribute] // RVA: 0x6FA00 Offset: 0x6EE00 VA: 0x18006FA00
	public float Fogginess; // 0x24

	// Methods

	// RVA: 0x10747D0 Offset: 0x1072DD0 VA: 0x1810747D0
	public void .ctor() { }

}

public class TOD_DayParameters // TypeDefIndex: 8093
{	// Fields
	[TooltipAttribute] // RVA: 0x6FD90 Offset: 0x6F190 VA: 0x18006FD90
	public Gradient SunColor; // 0x10
	[TooltipAttribute] // RVA: 0x6FEC0 Offset: 0x6F2C0 VA: 0x18006FEC0
	public Gradient LightColor; // 0x18
	[TooltipAttribute] // RVA: 0x70060 Offset: 0x6F460 VA: 0x180070060
	public Gradient RayColor; // 0x20
	[TooltipAttribute] // RVA: 0x70210 Offset: 0x6F610 VA: 0x180070210
	public Gradient SkyColor; // 0x28
	[TooltipAttribute] // RVA: 0x70300 Offset: 0x6F700 VA: 0x180070300
	public Gradient CloudColor; // 0x30
	[TooltipAttribute] // RVA: 0x70500 Offset: 0x6F900 VA: 0x180070500
	public Gradient FogColor; // 0x38
	[TooltipAttribute] // RVA: 0x705A0 Offset: 0x6F9A0 VA: 0x1800705A0
	public Gradient AmbientColor; // 0x40
	[TooltipAttribute] // RVA: 0x70630 Offset: 0x6FA30 VA: 0x180070630
	[TOD_MinAttribute] // RVA: 0x70630 Offset: 0x6FA30 VA: 0x180070630
	public float LightIntensity; // 0x48
	[TooltipAttribute] // RVA: 0x707A0 Offset: 0x6FBA0 VA: 0x1800707A0
	[RangeAttribute] // RVA: 0x707A0 Offset: 0x6FBA0 VA: 0x1800707A0
	public float ShadowStrength; // 0x4C
	[TooltipAttribute] // RVA: 0x708F0 Offset: 0x6FCF0 VA: 0x1800708F0
	[RangeAttribute] // RVA: 0x708F0 Offset: 0x6FCF0 VA: 0x1800708F0
	public float AmbientMultiplier; // 0x50
	[TooltipAttribute] // RVA: 0x70A60 Offset: 0x6FE60 VA: 0x180070A60
	[RangeAttribute] // RVA: 0x70A60 Offset: 0x6FE60 VA: 0x180070A60
	public float ReflectionMultiplier; // 0x54

	// Methods

	// RVA: 0x1076AB0 Offset: 0x10750B0 VA: 0x181076AB0
	public void .ctor() { }

}

public class TOD_NightParameters // TypeDefIndex: 8094
{	// Fields
	[TooltipAttribute] // RVA: 0x70BE0 Offset: 0x6FFE0 VA: 0x180070BE0
	public Gradient MoonColor; // 0x10
	[TooltipAttribute] // RVA: 0x70CE0 Offset: 0x700E0 VA: 0x180070CE0
	public Gradient LightColor; // 0x18
	[TooltipAttribute] // RVA: 0x70E60 Offset: 0x70260 VA: 0x180070E60
	public Gradient RayColor; // 0x20
	[TooltipAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public Gradient SkyColor; // 0x28
	[TooltipAttribute] // RVA: 0x71120 Offset: 0x70520 VA: 0x180071120
	public Gradient CloudColor; // 0x30
	[TooltipAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public Gradient FogColor; // 0x38
	[TooltipAttribute] // RVA: 0x713A0 Offset: 0x707A0 VA: 0x1800713A0
	public Gradient AmbientColor; // 0x40
	[TooltipAttribute] // RVA: 0x70630 Offset: 0x6FA30 VA: 0x180070630
	[TOD_MinAttribute] // RVA: 0x70630 Offset: 0x6FA30 VA: 0x180070630
	public float LightIntensity; // 0x48
	[TooltipAttribute] // RVA: 0x707A0 Offset: 0x6FBA0 VA: 0x1800707A0
	[RangeAttribute] // RVA: 0x707A0 Offset: 0x6FBA0 VA: 0x1800707A0
	public float ShadowStrength; // 0x4C
	[TooltipAttribute] // RVA: 0x708F0 Offset: 0x6FCF0 VA: 0x1800708F0
	[RangeAttribute] // RVA: 0x708F0 Offset: 0x6FCF0 VA: 0x1800708F0
	public float AmbientMultiplier; // 0x50
	[TooltipAttribute] // RVA: 0x70A60 Offset: 0x6FE60 VA: 0x180070A60
	[RangeAttribute] // RVA: 0x70A60 Offset: 0x6FE60 VA: 0x180070A60
	public float ReflectionMultiplier; // 0x54

	// Methods

	// RVA: 0x10786D0 Offset: 0x1076CD0 VA: 0x1810786D0
	public void .ctor() { }

}

public class TOD_SunParameters // TypeDefIndex: 8095
{	// Fields
	[TooltipAttribute] // RVA: 0x71A90 Offset: 0x70E90 VA: 0x180071A90
	[TOD_MinAttribute] // RVA: 0x71A90 Offset: 0x70E90 VA: 0x180071A90
	public float MeshSize; // 0x10
	[TooltipAttribute] // RVA: 0x71C20 Offset: 0x71020 VA: 0x180071C20
	[TOD_MinAttribute] // RVA: 0x71C20 Offset: 0x71020 VA: 0x180071C20
	public float MeshBrightness; // 0x14
	[TooltipAttribute] // RVA: 0x71DC0 Offset: 0x711C0 VA: 0x180071DC0
	[TOD_MinAttribute] // RVA: 0x71DC0 Offset: 0x711C0 VA: 0x180071DC0
	public float MeshContrast; // 0x18

	// Methods

	// RVA: 0x12DAD60 Offset: 0x12D9360 VA: 0x1812DAD60
	public void .ctor() { }

}

public class TOD_MoonParameters // TypeDefIndex: 8096
{	// Fields
	[TooltipAttribute] // RVA: 0x71FD0 Offset: 0x713D0 VA: 0x180071FD0
	[TOD_MinAttribute] // RVA: 0x71FD0 Offset: 0x713D0 VA: 0x180071FD0
	public float MeshSize; // 0x10
	[TooltipAttribute] // RVA: 0x721C0 Offset: 0x715C0 VA: 0x1800721C0
	[TOD_MinAttribute] // RVA: 0x721C0 Offset: 0x715C0 VA: 0x1800721C0
	public float MeshBrightness; // 0x14
	[TooltipAttribute] // RVA: 0x72410 Offset: 0x71810 VA: 0x180072410
	[TOD_MinAttribute] // RVA: 0x72410 Offset: 0x71810 VA: 0x180072410
	public float MeshContrast; // 0x18
	[TooltipAttribute] // RVA: 0x72640 Offset: 0x71A40 VA: 0x180072640
	[TOD_MinAttribute] // RVA: 0x72640 Offset: 0x71A40 VA: 0x180072640
	public float HaloSize; // 0x1C
	[TooltipAttribute] // RVA: 0x73B30 Offset: 0x72F30 VA: 0x180073B30
	[TOD_MinAttribute] // RVA: 0x73B30 Offset: 0x72F30 VA: 0x180073B30
	public float HaloBrightness; // 0x20
	[TooltipAttribute] // RVA: 0x73C10 Offset: 0x73010 VA: 0x180073C10
	public TOD_MoonPositionType Position; // 0x24

	// Methods

	// RVA: 0x1078690 Offset: 0x1076C90 VA: 0x181078690
	public void .ctor() { }

}

public class TOD_StarParameters // TypeDefIndex: 8097
{	// Fields
	[TooltipAttribute] // RVA: 0x73E10 Offset: 0x73210 VA: 0x180073E10
	[TOD_MinAttribute] // RVA: 0x73E10 Offset: 0x73210 VA: 0x180073E10
	public float Size; // 0x10
	[TooltipAttribute] // RVA: 0x73FA0 Offset: 0x733A0 VA: 0x180073FA0
	[TOD_MinAttribute] // RVA: 0x73FA0 Offset: 0x733A0 VA: 0x180073FA0
	public float Brightness; // 0x14
	[TooltipAttribute] // RVA: 0x754D0 Offset: 0x748D0 VA: 0x1800754D0
	public TOD_StarsPositionType Position; // 0x18

	// Methods

	// RVA: 0x12DAD40 Offset: 0x12D9340 VA: 0x1812DAD40
	public void .ctor() { }

}

public class TOD_CloudParameters // TypeDefIndex: 8098
{	// Fields
	[TooltipAttribute] // RVA: 0x75610 Offset: 0x74A10 VA: 0x180075610
	[TOD_MinAttribute] // RVA: 0x75610 Offset: 0x74A10 VA: 0x180075610
	public float Size; // 0x10
	[TooltipAttribute] // RVA: 0x757F0 Offset: 0x74BF0 VA: 0x1800757F0
	[TOD_RangeAttribute] // RVA: 0x757F0 Offset: 0x74BF0 VA: 0x1800757F0
	public float Opacity; // 0x14
	[TooltipAttribute] // RVA: 0x759D0 Offset: 0x74DD0 VA: 0x1800759D0
	[TOD_RangeAttribute] // RVA: 0x759D0 Offset: 0x74DD0 VA: 0x1800759D0
	public float Coverage; // 0x18
	[TooltipAttribute] // RVA: 0x75C40 Offset: 0x75040 VA: 0x180075C40
	[TOD_RangeAttribute] // RVA: 0x75C40 Offset: 0x75040 VA: 0x180075C40
	public float Sharpness; // 0x1C
	[TooltipAttribute] // RVA: 0x75E00 Offset: 0x75200 VA: 0x180075E00
	[TOD_RangeAttribute] // RVA: 0x75E00 Offset: 0x75200 VA: 0x180075E00
	public float Coloring; // 0x20
	[TooltipAttribute] // RVA: 0x75FA0 Offset: 0x753A0 VA: 0x180075FA0
	[TOD_RangeAttribute] // RVA: 0x75FA0 Offset: 0x753A0 VA: 0x180075FA0
	public float Attenuation; // 0x24
	[TooltipAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	[TOD_RangeAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public float Saturation; // 0x28
	[TooltipAttribute] // RVA: 0x76280 Offset: 0x75680 VA: 0x180076280
	[TOD_MinAttribute] // RVA: 0x76280 Offset: 0x75680 VA: 0x180076280
	public float Scattering; // 0x2C
	[TooltipAttribute] // RVA: 0x76370 Offset: 0x75770 VA: 0x180076370
	[TOD_MinAttribute] // RVA: 0x76370 Offset: 0x75770 VA: 0x180076370
	public float Brightness; // 0x30

	// Methods

	// RVA: 0x1075C60 Offset: 0x1074260 VA: 0x181075C60
	public void .ctor() { }

}

public class TOD_LightParameters // TypeDefIndex: 8099
{	// Fields
	[TooltipAttribute] // RVA: 0x764C0 Offset: 0x758C0 VA: 0x1800764C0
	[TOD_MinAttribute] // RVA: 0x764C0 Offset: 0x758C0 VA: 0x1800764C0
	public float UpdateInterval; // 0x10
	[TooltipAttribute] // RVA: 0x76670 Offset: 0x75A70 VA: 0x180076670
	[TOD_RangeAttribute] // RVA: 0x76670 Offset: 0x75A70 VA: 0x180076670
	public float MinimumHeight; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class TOD_FogParameters // TypeDefIndex: 8100
{	// Fields
	[TooltipAttribute] // RVA: 0x76810 Offset: 0x75C10 VA: 0x180076810
	public TOD_FogType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x76960 Offset: 0x75D60 VA: 0x180076960
	[TOD_RangeAttribute] // RVA: 0x76960 Offset: 0x75D60 VA: 0x180076960
	public float HeightBias; // 0x14

	// Methods

	// RVA: 0x1076AE0 Offset: 0x10750E0 VA: 0x181076AE0
	public void .ctor() { }

}

public class TOD_AmbientParameters // TypeDefIndex: 8101
{	// Fields
	[TooltipAttribute] // RVA: 0x76B50 Offset: 0x75F50 VA: 0x180076B50
	public TOD_AmbientType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x76C80 Offset: 0x76080 VA: 0x180076C80
	[TOD_MinAttribute] // RVA: 0x76C80 Offset: 0x76080 VA: 0x180076C80
	public float Saturation; // 0x14
	[TooltipAttribute] // RVA: 0x76EA0 Offset: 0x762A0 VA: 0x180076EA0
	[TOD_MinAttribute] // RVA: 0x76EA0 Offset: 0x762A0 VA: 0x180076EA0
	public float UpdateInterval; // 0x18

	// Methods

	// RVA: 0x10742D0 Offset: 0x10728D0 VA: 0x1810742D0
	public void .ctor() { }

}

public class TOD_ReflectionParameters // TypeDefIndex: 8102
{	// Fields
	[TooltipAttribute] // RVA: 0x77020 Offset: 0x76420 VA: 0x180077020
	public TOD_ReflectionType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x77180 Offset: 0x76580 VA: 0x180077180
	public ReflectionProbeClearFlags ClearFlags; // 0x14
	[TooltipAttribute] // RVA: 0x77260 Offset: 0x76660 VA: 0x180077260
	public LayerMask CullingMask; // 0x18
	[TooltipAttribute] // RVA: 0x773F0 Offset: 0x767F0 VA: 0x1800773F0
	public GameObject ProbePrefab; // 0x20

	// Methods

	// RVA: 0x10796E0 Offset: 0x1077CE0 VA: 0x1810796E0
	public void .ctor() { }

}

public class TOD_Rays : TOD_ImageEffect // TypeDefIndex: 8103
{	// Fields
	public Shader GodRayShader; // 0x30
	public Shader ScreenClearShader; // 0x38
	public Shader SkyMaskShader; // 0x40
	[TooltipAttribute] // RVA: 0x777A0 Offset: 0x76BA0 VA: 0x1800777A0
	public bool UseDepthTexture; // 0x48
	[HeaderAttribute] // RVA: 0x77880 Offset: 0x76C80 VA: 0x180077880
	[TooltipAttribute] // RVA: 0x77880 Offset: 0x76C80 VA: 0x180077880
	public TOD_Rays.BlendModeType BlendMode; // 0x4C
	[TooltipAttribute] // RVA: 0x77A00 Offset: 0x76E00 VA: 0x180077A00
	[TOD_MinAttribute] // RVA: 0x77A00 Offset: 0x76E00 VA: 0x180077A00
	public float Intensity; // 0x50
	[HeaderAttribute] // RVA: 0x77AC0 Offset: 0x76EC0 VA: 0x180077AC0
	[TooltipAttribute] // RVA: 0x77AC0 Offset: 0x76EC0 VA: 0x180077AC0
	public TOD_ImageEffect.ResolutionType Resolution; // 0x54
	[TooltipAttribute] // RVA: 0x77CE0 Offset: 0x770E0 VA: 0x180077CE0
	[TOD_RangeAttribute] // RVA: 0x77CE0 Offset: 0x770E0 VA: 0x180077CE0
	public int BlurIterations; // 0x58
	[TooltipAttribute] // RVA: 0x77E60 Offset: 0x77260 VA: 0x180077E60
	[TOD_MinAttribute] // RVA: 0x77E60 Offset: 0x77260 VA: 0x180077E60
	public float BlurRadius; // 0x5C
	[TooltipAttribute] // RVA: 0x780C0 Offset: 0x774C0 VA: 0x1800780C0
	[TOD_MinAttribute] // RVA: 0x780C0 Offset: 0x774C0 VA: 0x1800780C0
	public float MaxRadius; // 0x60
	private Material godRayMaterial; // 0x68
	private Material screenClearMaterial; // 0x70
	private Material skyMaskMaterial; // 0x78
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;

	// Methods

	// RVA: 0x10791D0 Offset: 0x10777D0 VA: 0x1810791D0
	protected void OnEnable() { }

	// RVA: 0x1079080 Offset: 0x1077680 VA: 0x181079080
	protected void OnDisable() { }

	// RVA: 0x1079370 Offset: 0x1077970 VA: 0x181079370
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1079660 Offset: 0x1077C60 VA: 0x181079660
	public void .ctor() { }

}

public enum TOD_Rays.BlendModeType // TypeDefIndex: 8104
{	// Fields
	public int value__; // 0x0
	public const TOD_Rays.BlendModeType Screen = 0;
	public const TOD_Rays.BlendModeType Add = 1;

}

public class TOD_Resources : MonoBehaviour // TypeDefIndex: 8105
{	// Fields
	public Material Skybox; // 0x18
	public Mesh MoonLOD0; // 0x20
	public Mesh MoonLOD1; // 0x28
	public Mesh MoonLOD2; // 0x30
	public Mesh SkyLOD0; // 0x38
	public Mesh SkyLOD1; // 0x40
	public Mesh SkyLOD2; // 0x48
	public Mesh CloudsLOD0; // 0x50
	public Mesh CloudsLOD1; // 0x58
	public Mesh CloudsLOD2; // 0x60
	public Mesh StarsLOD0; // 0x68
	public Mesh StarsLOD1; // 0x70
	public Mesh StarsLOD2; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_SunLightColor>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonLightColor>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_SunSkyColor>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonSkyColor>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_SunMeshColor>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonMeshColor>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_SunCloudColor>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonCloudColor>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_FogColor>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_GroundColor>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_AmbientColor>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_SunDirection>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonDirection>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_LightDirection>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_LocalSunDirection>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_LocalMoonDirection>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_LocalLightDirection>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_Contrast>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_Brightness>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_Fogginess>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_Directionality>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonHaloPower>k__BackingField; // 0xD4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonHaloColor>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudSize>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudOpacity>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudCoverage>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudSharpness>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudDensity>k__BackingField; // 0xEC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudColoring>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudAttenuation>k__BackingField; // 0xF4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudSaturation>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudScattering>k__BackingField; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudBrightness>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudMultiplier>k__BackingField; // 0x104
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudOffset>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_CloudWind>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_StarSize>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_StarBrightness>k__BackingField; // 0x114
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_StarVisibility>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_SunMeshContrast>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_SunMeshBrightness>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonMeshContrast>k__BackingField; // 0x124
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_MoonMeshBrightness>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_kBetaMie>k__BackingField; // 0x12C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_kSun>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_k4PI>k__BackingField; // 0x134
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_kRadius>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_kScale>k__BackingField; // 0x13C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_World2Sky>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID_Sky2World>k__BackingField; // 0x144

	// Properties
	public int ID_SunLightColor { get; set; }
	public int ID_MoonLightColor { get; set; }
	public int ID_SunSkyColor { get; set; }
	public int ID_MoonSkyColor { get; set; }
	public int ID_SunMeshColor { get; set; }
	public int ID_MoonMeshColor { get; set; }
	public int ID_SunCloudColor { get; set; }
	public int ID_MoonCloudColor { get; set; }
	public int ID_FogColor { get; set; }
	public int ID_GroundColor { get; set; }
	public int ID_AmbientColor { get; set; }
	public int ID_SunDirection { get; set; }
	public int ID_MoonDirection { get; set; }
	public int ID_LightDirection { get; set; }
	public int ID_LocalSunDirection { get; set; }
	public int ID_LocalMoonDirection { get; set; }
	public int ID_LocalLightDirection { get; set; }
	public int ID_Contrast { get; set; }
	public int ID_Brightness { get; set; }
	public int ID_Fogginess { get; set; }
	public int ID_Directionality { get; set; }
	public int ID_MoonHaloPower { get; set; }
	public int ID_MoonHaloColor { get; set; }
	public int ID_CloudSize { get; set; }
	public int ID_CloudOpacity { get; set; }
	public int ID_CloudCoverage { get; set; }
	public int ID_CloudSharpness { get; set; }
	public int ID_CloudDensity { get; set; }
	public int ID_CloudColoring { get; set; }
	public int ID_CloudAttenuation { get; set; }
	public int ID_CloudSaturation { get; set; }
	public int ID_CloudScattering { get; set; }
	public int ID_CloudBrightness { get; set; }
	public int ID_CloudMultiplier { get; set; }
	public int ID_CloudOffset { get; set; }
	public int ID_CloudWind { get; set; }
	public int ID_StarSize { get; set; }
	public int ID_StarBrightness { get; set; }
	public int ID_StarVisibility { get; set; }
	public int ID_SunMeshContrast { get; set; }
	public int ID_SunMeshBrightness { get; set; }
	public int ID_MoonMeshContrast { get; set; }
	public int ID_MoonMeshBrightness { get; set; }
	public int ID_kBetaMie { get; set; }
	public int ID_kSun { get; set; }
	public int ID_k4PI { get; set; }
	public int ID_kRadius { get; set; }
	public int ID_kScale { get; set; }
	public int ID_World2Sky { get; set; }
	public int ID_Sky2World { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940
	public int get_ID_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x582950 Offset: 0x580F50 VA: 0x180582950
	private void set_ID_SunLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1050510 Offset: 0x104EB10 VA: 0x181050510
	public int get_ID_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10505B0 Offset: 0x104EBB0 VA: 0x1810505B0
	private void set_ID_MoonLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public int get_ID_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C000 Offset: 0xF8A600 VA: 0x180F8C000
	private void set_ID_SunSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E90 Offset: 0x1078490 VA: 0x181079E90
	public int get_ID_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8C010 Offset: 0xF8A610 VA: 0x180F8C010
	private void set_ID_MoonSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD277E0 Offset: 0xD25DE0 VA: 0x180D277E0
	public int get_ID_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD27750 Offset: 0xD25D50 VA: 0x180D27750
	private void set_ID_SunMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBB0340 Offset: 0xBAE940 VA: 0x180BB0340
	public int get_ID_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FF0 Offset: 0x10785F0 VA: 0x181079FF0
	private void set_ID_MoonMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB9B270 Offset: 0xB99870 VA: 0x180B9B270
	public int get_ID_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x104F2C0 Offset: 0x104D8C0 VA: 0x18104F2C0
	private void set_ID_SunCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB9B280 Offset: 0xB99880 VA: 0x180B9B280
	public int get_ID_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C2620 Offset: 0x5C0C20 VA: 0x1805C2620
	private void set_ID_MoonCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1051760 Offset: 0x104FD60 VA: 0x181051760
	public int get_ID_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F80 Offset: 0x1078580 VA: 0x181079F80
	private void set_ID_FogColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1051770 Offset: 0x104FD70 VA: 0x181051770
	public int get_ID_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F90 Offset: 0x1078590 VA: 0x181079F90
	private void set_ID_GroundColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079DB0 Offset: 0x10783B0 VA: 0x181079DB0
	public int get_ID_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079EF0 Offset: 0x10784F0 VA: 0x181079EF0
	private void set_ID_AmbientColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D020 Offset: 0xA4B620 VA: 0x180A4D020
	public int get_ID_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A040 Offset: 0x1078640 VA: 0x18107A040
	private void set_ID_SunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_ID_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_ID_MoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E30 Offset: 0x1078430 VA: 0x181079E30
	public int get_ID_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FA0 Offset: 0x10785A0 VA: 0x181079FA0
	private void set_ID_LightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E60 Offset: 0x1078460 VA: 0x181079E60
	public int get_ID_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FD0 Offset: 0x10785D0 VA: 0x181079FD0
	private void set_ID_LocalSunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E50 Offset: 0x1078450 VA: 0x181079E50
	public int get_ID_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FC0 Offset: 0x10785C0 VA: 0x181079FC0
	private void set_ID_LocalMoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E40 Offset: 0x1078440 VA: 0x181079E40
	public int get_ID_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FB0 Offset: 0x10785B0 VA: 0x181079FB0
	private void set_ID_LocalLightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE2A20 Offset: 0xAE1020 VA: 0x180AE2A20
	public int get_ID_Contrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F70 Offset: 0x1078570 VA: 0x181079F70
	private void set_ID_Contrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE2A40 Offset: 0xAE1040 VA: 0x180AE2A40
	public int get_ID_Brightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x104EC70 Offset: 0x104D270 VA: 0x18104EC70
	private void set_ID_Brightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D190 Offset: 0xA4B790 VA: 0x180A4D190
	public int get_ID_Fogginess() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D240 Offset: 0xA4B840 VA: 0x180A4D240
	private void set_ID_Fogginess(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x887950 Offset: 0x885F50 VA: 0x180887950
	public int get_ID_Directionality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7425E0 Offset: 0x740BE0 VA: 0x1807425E0
	private void set_ID_Directionality(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E70 Offset: 0x1078470 VA: 0x181079E70
	public int get_ID_MoonHaloPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079FE0 Offset: 0x10785E0 VA: 0x181079FE0
	private void set_ID_MoonHaloPower(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1050470 Offset: 0x104EA70 VA: 0x181050470
	public int get_ID_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1050340 Offset: 0x104E940 VA: 0x181050340
	private void set_ID_MoonHaloColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1050500 Offset: 0x104EB00 VA: 0x181050500
	public int get_ID_CloudSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1050350 Offset: 0x104E950 VA: 0x181050350
	private void set_ID_CloudSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872130 Offset: 0x870730 VA: 0x180872130
	public int get_ID_CloudOpacity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8721B0 Offset: 0x8707B0 VA: 0x1808721B0
	private void set_ID_CloudOpacity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079DE0 Offset: 0x10783E0 VA: 0x181079DE0
	public int get_ID_CloudCoverage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F20 Offset: 0x1078520 VA: 0x181079F20
	private void set_ID_CloudCoverage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E20 Offset: 0x1078420 VA: 0x181079E20
	public int get_ID_CloudSharpness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F60 Offset: 0x1078560 VA: 0x181079F60
	private void set_ID_CloudSharpness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079DF0 Offset: 0x10783F0 VA: 0x181079DF0
	public int get_ID_CloudDensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F30 Offset: 0x1078530 VA: 0x181079F30
	private void set_ID_CloudDensity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079DD0 Offset: 0x10783D0 VA: 0x181079DD0
	public int get_ID_CloudColoring() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F10 Offset: 0x1078510 VA: 0x181079F10
	private void set_ID_CloudColoring(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079DC0 Offset: 0x10783C0 VA: 0x181079DC0
	public int get_ID_CloudAttenuation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F00 Offset: 0x1078500 VA: 0x181079F00
	private void set_ID_CloudAttenuation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E00 Offset: 0x1078400 VA: 0x181079E00
	public int get_ID_CloudSaturation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F40 Offset: 0x1078540 VA: 0x181079F40
	private void set_ID_CloudSaturation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E10 Offset: 0x1078410 VA: 0x181079E10
	public int get_ID_CloudScattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079F50 Offset: 0x1078550 VA: 0x181079F50
	private void set_ID_CloudScattering(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73A90 Offset: 0xC72090 VA: 0x180C73A90
	public int get_ID_CloudBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73BE0 Offset: 0xC721E0 VA: 0x180C73BE0
	private void set_ID_CloudBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC739A0 Offset: 0xC71FA0 VA: 0x180C739A0
	public int get_ID_CloudMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73BB0 Offset: 0xC721B0 VA: 0x180C73BB0
	private void set_ID_CloudMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871FF0 Offset: 0x8705F0 VA: 0x180871FF0
	public int get_ID_CloudOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872190 Offset: 0x870790 VA: 0x180872190
	private void set_ID_CloudOffset(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC739B0 Offset: 0xC71FB0 VA: 0x180C739B0
	public int get_ID_CloudWind() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73BC0 Offset: 0xC721C0 VA: 0x180C73BC0
	private void set_ID_CloudWind(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC12D0 Offset: 0xEBF8D0 VA: 0x180EC12D0
	public int get_ID_StarSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A030 Offset: 0x1078630 VA: 0x18107A030
	private void set_ID_StarSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079EA0 Offset: 0x10784A0 VA: 0x181079EA0
	public int get_ID_StarBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A020 Offset: 0x1078620 VA: 0x18107A020
	private void set_ID_StarBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92D940 Offset: 0x92BF40 VA: 0x18092D940
	public int get_ID_StarVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92D950 Offset: 0x92BF50 VA: 0x18092D950
	private void set_ID_StarVisibility(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079EC0 Offset: 0x10784C0 VA: 0x181079EC0
	public int get_ID_SunMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A060 Offset: 0x1078660 VA: 0x18107A060
	private void set_ID_SunMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079EB0 Offset: 0x10784B0 VA: 0x181079EB0
	public int get_ID_SunMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A050 Offset: 0x1078650 VA: 0x18107A050
	private void set_ID_SunMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079E80 Offset: 0x1078480 VA: 0x181079E80
	public int get_ID_MoonMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A000 Offset: 0x1078600 VA: 0x18107A000
	private void set_ID_MoonMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81CCE0 Offset: 0x81B2E0 VA: 0x18081CCE0
	public int get_ID_MoonMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D0A0 Offset: 0x81B6A0 VA: 0x18081D0A0
	private void set_ID_MoonMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC82E70 Offset: 0xC81470 VA: 0x180C82E70
	public int get_ID_kBetaMie() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A090 Offset: 0x1078690 VA: 0x18107A090
	private void set_ID_kBetaMie(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83040 Offset: 0xC81640 VA: 0x180C83040
	public int get_ID_kSun() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A0B0 Offset: 0x10786B0 VA: 0x18107A0B0
	private void set_ID_kSun(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079EE0 Offset: 0x10784E0 VA: 0x181079EE0
	public int get_ID_k4PI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A080 Offset: 0x1078680 VA: 0x18107A080
	private void set_ID_k4PI(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83080 Offset: 0xC81680 VA: 0x180C83080
	public int get_ID_kRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A0A0 Offset: 0x10786A0 VA: 0x18107A0A0
	private void set_ID_kRadius(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x871D20 Offset: 0x870320 VA: 0x180871D20
	public int get_ID_kScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x872170 Offset: 0x870770 VA: 0x180872170
	private void set_ID_kScale(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1079ED0 Offset: 0x10784D0 VA: 0x181079ED0
	public int get_ID_World2Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A070 Offset: 0x1078670 VA: 0x18107A070
	private void set_ID_World2Sky(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC82DA0 Offset: 0xC813A0 VA: 0x180C82DA0
	public int get_ID_Sky2World() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107A010 Offset: 0x1078610 VA: 0x18107A010
	private void set_ID_Sky2World(int value) { }

	// RVA: 0x10799B0 Offset: 0x1077FB0 VA: 0x1810799B0
	public void Initialize() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TOD_Scattering : TOD_ImageEffect // TypeDefIndex: 8106
{	// Fields
	public Shader ScatteringShader; // 0x30
	public Shader ScreenClearShader; // 0x38
	public Shader SkyMaskShader; // 0x40
	public Texture2D DitheringTexture; // 0x48
	[TooltipAttribute] // RVA: 0x85260 Offset: 0x84660 VA: 0x180085260
	public bool SinglePass; // 0x50
	[HeaderAttribute] // RVA: 0x85370 Offset: 0x84770 VA: 0x180085370
	[TooltipAttribute] // RVA: 0x85370 Offset: 0x84770 VA: 0x180085370
	[RangeAttribute] // RVA: 0x85370 Offset: 0x84770 VA: 0x180085370
	public float GlobalDensity; // 0x54
	[TooltipAttribute] // RVA: 0x85650 Offset: 0x84A50 VA: 0x180085650
	[RangeAttribute] // RVA: 0x85650 Offset: 0x84A50 VA: 0x180085650
	public float HeightFalloff; // 0x58
	[TooltipAttribute] // RVA: 0x85780 Offset: 0x84B80 VA: 0x180085780
	public float StartDistance; // 0x5C
	[TooltipAttribute] // RVA: 0x858E0 Offset: 0x84CE0 VA: 0x1800858E0
	public float ZeroLevel; // 0x60
	[HeaderAttribute] // RVA: 0x859F0 Offset: 0x84DF0 VA: 0x1800859F0
	[TooltipAttribute] // RVA: 0x859F0 Offset: 0x84DF0 VA: 0x1800859F0
	public TOD_ImageEffect.ResolutionType Resolution; // 0x64
	[TooltipAttribute] // RVA: 0x77CE0 Offset: 0x770E0 VA: 0x180077CE0
	[TOD_RangeAttribute] // RVA: 0x77CE0 Offset: 0x770E0 VA: 0x180077CE0
	public int BlurIterations; // 0x68
	[TooltipAttribute] // RVA: 0x85BF0 Offset: 0x84FF0 VA: 0x180085BF0
	[TOD_MinAttribute] // RVA: 0x85BF0 Offset: 0x84FF0 VA: 0x180085BF0
	public float BlurRadius; // 0x6C
	[TooltipAttribute] // RVA: 0x85D10 Offset: 0x85110 VA: 0x180085D10
	[TOD_MinAttribute] // RVA: 0x85D10 Offset: 0x85110 VA: 0x180085D10
	public float MaxRadius; // 0x70
	private Material scatteringMaterial; // 0x78
	private Material screenClearMaterial; // 0x80
	private Material skyMaskMaterial; // 0x88

	// Methods

	// RVA: 0x12D13D0 Offset: 0x12CF9D0 VA: 0x1812D13D0
	protected void OnEnable() { }

	// RVA: 0x12D1270 Offset: 0x12CF870 VA: 0x1812D1270
	protected void OnDisable() { }

	// RVA: 0x12D1620 Offset: 0x12CFC20 VA: 0x1812D1620
	protected void OnPreCull() { }

	// RVA: 0x12D1570 Offset: 0x12CFB70 VA: 0x1812D1570
	protected void OnPostRender() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12D16D0 Offset: 0x12CFCD0 VA: 0x1812D16D0
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12D19F0 Offset: 0x12CFFF0 VA: 0x1812D19F0
	public void .ctor() { }

}

public class TOD_Shadows : TOD_ImageEffect // TypeDefIndex: 8107
{	// Fields
	public Shader ShadowShader; // 0x30
	public Texture2D CloudTexture; // 0x38
	[HeaderAttribute] // RVA: 0x861D0 Offset: 0x855D0 VA: 0x1800861D0
	[RangeAttribute] // RVA: 0x861D0 Offset: 0x855D0 VA: 0x1800861D0
	public float Cutoff; // 0x40
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Fade; // 0x44
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Intensity; // 0x48
	private Material shadowMaterial; // 0x50

	// Methods

	// RVA: 0x12D1B00 Offset: 0x12D0100 VA: 0x1812D1B00
	protected void OnEnable() { }

	// RVA: 0x12D1A70 Offset: 0x12D0070 VA: 0x1812D1A70
	protected void OnDisable() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12D1BB0 Offset: 0x12D01B0 VA: 0x1812D1BB0
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12D1DE0 Offset: 0x12D03E0 VA: 0x1812D1DE0
	public void .ctor() { }

}

public class TOD_Sky : MonoBehaviour // TypeDefIndex: 8108
{	// Fields
	private static List<TOD_Sky> instances; // 0x0
	[TooltipAttribute] // RVA: 0x87B10 Offset: 0x86F10 VA: 0x180087B10
	public TOD_ColorSpaceType ColorSpace; // 0x18
	[TooltipAttribute] // RVA: 0x87D60 Offset: 0x87160 VA: 0x180087D60
	public TOD_ColorRangeType ColorRange; // 0x1C
	[TooltipAttribute] // RVA: 0x87E60 Offset: 0x87260 VA: 0x180087E60
	public TOD_ColorOutputType ColorOutput; // 0x20
	[TooltipAttribute] // RVA: 0x88120 Offset: 0x87520 VA: 0x180088120
	public TOD_SkyQualityType SkyQuality; // 0x24
	[TooltipAttribute] // RVA: 0x881A0 Offset: 0x875A0 VA: 0x1800881A0
	public TOD_CloudQualityType CloudQuality; // 0x28
	[TooltipAttribute] // RVA: 0x88310 Offset: 0x87710 VA: 0x180088310
	public TOD_MeshQualityType MeshQuality; // 0x2C
	[TooltipAttribute] // RVA: 0x884D0 Offset: 0x878D0 VA: 0x1800884D0
	public TOD_StarQualityType StarQuality; // 0x30
	public TOD_CycleParameters Cycle; // 0x38
	public TOD_WorldParameters World; // 0x40
	public TOD_AtmosphereParameters Atmosphere; // 0x48
	public TOD_DayParameters Day; // 0x50
	public TOD_NightParameters Night; // 0x58
	public TOD_SunParameters Sun; // 0x60
	public TOD_MoonParameters Moon; // 0x68
	public TOD_StarParameters Stars; // 0x70
	public TOD_CloudParameters Clouds; // 0x78
	public TOD_LightParameters Light; // 0x80
	public TOD_FogParameters Fog; // 0x88
	public TOD_AmbientParameters Ambient; // 0x90
	public TOD_ReflectionParameters Reflection; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Initialized>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Components <Components>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TOD_Resources <Resources>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsDay>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsNight>k__BackingField; // 0xB9
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <LerpValue>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <SunZenith>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <SunAltitude>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <SunAzimuth>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <MoonZenith>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <MoonAltitude>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <MoonAzimuth>k__BackingField; // 0xD4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <SunsetTime>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <SunriseTime>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <LocalSiderealTime>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <SunVisibility>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <MoonVisibility>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <SunDirection>k__BackingField; // 0xEC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <MoonDirection>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <LightDirection>k__BackingField; // 0x104
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <LocalSunDirection>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <LocalMoonDirection>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <LocalLightDirection>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <SunLightColor>k__BackingField; // 0x134
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <MoonLightColor>k__BackingField; // 0x144
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <SunRayColor>k__BackingField; // 0x154
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <MoonRayColor>k__BackingField; // 0x164
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <SunSkyColor>k__BackingField; // 0x174
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <MoonSkyColor>k__BackingField; // 0x184
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <SunMeshColor>k__BackingField; // 0x194
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <MoonMeshColor>k__BackingField; // 0x1A4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <SunCloudColor>k__BackingField; // 0x1B4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <MoonCloudColor>k__BackingField; // 0x1C4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <FogColor>k__BackingField; // 0x1D4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <GroundColor>k__BackingField; // 0x1E4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <AmbientColor>k__BackingField; // 0x1F4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color <MoonHaloColor>k__BackingField; // 0x204
	private TOD_Sky.ReflectionProbeState ReflectionCur; // 0x218
	private TOD_Sky.ReflectionProbeState ReflectionSrc; // 0x220
	private TOD_Sky.ReflectionProbeState ReflectionDst; // 0x228
	public static float ReflectionUpdateSlowdown; // 0x8
	public static int ReflectionResolution; // 0xC
	public static float ReflectionUpdateInterval; // 0x10
	public static ReflectionProbeTimeSlicingMode ReflectionTimeSlicing; // 0x14
	private float timeSinceLightUpdate; // 0x230
	private float timeSinceAmbientUpdate; // 0x234
	private float timeSinceReflectionUpdate; // 0x238
	private const int TOD_SAMPLES = 2;
	private Vector3 kBetaMie; // 0x23C
	private Vector4 kSun; // 0x248
	private Vector4 k4PI; // 0x258
	private Vector4 kRadius; // 0x268
	private Vector4 kScale; // 0x278
	private const float pi = 3,141593;
	private const float tau = 6,283185;

	// Properties
	public static List<TOD_Sky> Instances { get; }
	public static TOD_Sky Instance { get; }
	public bool Initialized { get; set; }
	public bool Headless { get; }
	public TOD_Components Components { get; set; }
	public TOD_Resources Resources { get; set; }
	public bool IsDay { get; set; }
	public bool IsNight { get; set; }
	public float Radius { get; }
	public float Diameter { get; }
	public float LerpValue { get; set; }
	public float SunZenith { get; set; }
	public float SunAltitude { get; set; }
	public float SunAzimuth { get; set; }
	public float MoonZenith { get; set; }
	public float MoonAltitude { get; set; }
	public float MoonAzimuth { get; set; }
	public float SunsetTime { get; set; }
	public float SunriseTime { get; set; }
	public float LocalSiderealTime { get; set; }
	public float LightZenith { get; }
	public float LightIntensity { get; }
	public float SunVisibility { get; set; }
	public float MoonVisibility { get; set; }
	public Vector3 SunDirection { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Vector3 LightDirection { get; set; }
	public Vector3 LocalSunDirection { get; set; }
	public Vector3 LocalMoonDirection { get; set; }
	public Vector3 LocalLightDirection { get; set; }
	public Color SunLightColor { get; set; }
	public Color MoonLightColor { get; set; }
	public Color LightColor { get; }
	public Color SunRayColor { get; set; }
	public Color MoonRayColor { get; set; }
	public Color SunSkyColor { get; set; }
	public Color MoonSkyColor { get; set; }
	public Color SunMeshColor { get; set; }
	public Color MoonMeshColor { get; set; }
	public Color SunCloudColor { get; set; }
	public Color MoonCloudColor { get; set; }
	public Color FogColor { get; set; }
	public Color GroundColor { get; set; }
	public Color AmbientColor { get; set; }
	public Color MoonHaloColor { get; set; }
	public ReflectionProbe Probe { get; }
	public GameObject ProbeInstance { get; }
	public MonoBehaviour ProbeEx { get; }

	// Methods

	// RVA: 0x12DA6E0 Offset: 0x12D8CE0 VA: 0x1812DA6E0
	public static List<TOD_Sky> get_Instances() { }

	// RVA: 0x12DA610 Offset: 0x12D8C10 VA: 0x1812DA610
	public static TOD_Sky get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2B7E0 Offset: 0xC29DE0 VA: 0x180C2B7E0
	public bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BCC0 Offset: 0xC2A2C0 VA: 0x180C2BCC0
	private void set_Initialized(bool value) { }

	// RVA: 0x12DA5F0 Offset: 0x12D8BF0 VA: 0x1812DA5F0
	public bool get_Headless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x952B90 Offset: 0x951190 VA: 0x180952B90
	public TOD_Components get_Components() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC73C90 Offset: 0xC72290 VA: 0x180C73C90
	private void set_Components(TOD_Components value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	public TOD_Resources get_Resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D220 Offset: 0xA4B820 VA: 0x180A4D220
	private void set_Resources(TOD_Resources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA740 Offset: 0x12D8D40 VA: 0x1812DA740
	public bool get_IsDay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAB10 Offset: 0x12D9110 VA: 0x1812DAB10
	private void set_IsDay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA750 Offset: 0x12D8D50 VA: 0x1812DA750
	public bool get_IsNight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAB20 Offset: 0x12D9120 VA: 0x1812DAB20
	private void set_IsNight(bool value) { }

	// RVA: 0x12DA9F0 Offset: 0x12D8FF0 VA: 0x1812DA9F0
	public float get_Radius() { }

	// RVA: 0x12DA590 Offset: 0x12D8B90 VA: 0x1812DA590
	public float get_Diameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3370 Offset: 0x5C1970 VA: 0x1805C3370
	public float get_LerpValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3560 Offset: 0x5C1B60 VA: 0x1805C3560
	private void set_LerpValue(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAAB0 Offset: 0x12D90B0 VA: 0x1812DAAB0
	public float get_SunZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAD10 Offset: 0x12D9310 VA: 0x1812DAD10
	private void set_SunZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAA30 Offset: 0x12D9030 VA: 0x1812DAA30
	public float get_SunAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC70 Offset: 0x12D9270 VA: 0x1812DAC70
	private void set_SunAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAA40 Offset: 0x12D9040 VA: 0x1812DAA40
	public float get_SunAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC80 Offset: 0x12D9280 VA: 0x1812DAC80
	private void set_SunAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA980 Offset: 0x12D8F80 VA: 0x1812DA980
	public float get_MoonZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC60 Offset: 0x12D9260 VA: 0x1812DAC60
	private void set_MoonZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA8E0 Offset: 0x12D8EE0 VA: 0x1812DA8E0
	public float get_MoonAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DABB0 Offset: 0x12D91B0 VA: 0x1812DABB0
	private void set_MoonAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA8F0 Offset: 0x12D8EF0 VA: 0x1812DA8F0
	public float get_MoonAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DABC0 Offset: 0x12D91C0 VA: 0x1812DABC0
	private void set_MoonAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAAD0 Offset: 0x12D90D0 VA: 0x1812DAAD0
	public float get_SunsetTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAD30 Offset: 0x12D9330 VA: 0x1812DAD30
	private void set_SunsetTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAAC0 Offset: 0x12D90C0 VA: 0x1812DAAC0
	public float get_SunriseTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAD20 Offset: 0x12D9320 VA: 0x1812DAD20
	private void set_SunriseTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1132140 Offset: 0x1130740 VA: 0x181132140
	public float get_LocalSiderealTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1132940 Offset: 0x1130F40 VA: 0x181132940
	private void set_LocalSiderealTime(float value) { }

	// RVA: 0x12DA800 Offset: 0x12D8E00 VA: 0x1812DA800
	public float get_LightZenith() { }

	// RVA: 0x12DA7D0 Offset: 0x12D8DD0 VA: 0x1812DA7D0
	public float get_LightIntensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAAA0 Offset: 0x12D90A0 VA: 0x1812DAAA0
	public float get_SunVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAD00 Offset: 0x12D9300 VA: 0x1812DAD00
	private void set_SunVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1131F90 Offset: 0x1130590 VA: 0x181131F90
	public float get_MoonVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC50 Offset: 0x12D9250 VA: 0x1812DAC50
	private void set_MoonVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAA50 Offset: 0x12D9050 VA: 0x1812DAA50
	public Vector3 get_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DACA0 Offset: 0x12D92A0 VA: 0x1812DACA0
	private void set_SunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA910 Offset: 0x12D8F10 VA: 0x1812DA910
	public Vector3 get_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DABE0 Offset: 0x12D91E0 VA: 0x1812DABE0
	private void set_MoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA7B0 Offset: 0x12D8DB0 VA: 0x1812DA7B0
	public Vector3 get_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAB30 Offset: 0x12D9130 VA: 0x1812DAB30
	private void set_LightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA8C0 Offset: 0x12D8EC0 VA: 0x1812DA8C0
	public Vector3 get_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAB90 Offset: 0x12D9190 VA: 0x1812DAB90
	private void set_LocalSunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA8A0 Offset: 0x12D8EA0 VA: 0x1812DA8A0
	public Vector3 get_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAB70 Offset: 0x12D9170 VA: 0x1812DAB70
	private void set_LocalMoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA880 Offset: 0x12D8E80 VA: 0x1812DA880
	public Vector3 get_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAB50 Offset: 0x12D9150 VA: 0x1812DAB50
	private void set_LocalLightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAA70 Offset: 0x12D9070 VA: 0x1812DAA70
	public Color get_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DACC0 Offset: 0x12D92C0 VA: 0x1812DACC0
	private void set_SunLightColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA940 Offset: 0x12D8F40 VA: 0x1812DA940
	public Color get_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC10 Offset: 0x12D9210 VA: 0x1812DAC10
	private void set_MoonLightColor(Color value) { }

	// RVA: 0x12DA760 Offset: 0x12D8D60 VA: 0x1812DA760
	public Color get_LightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAA90 Offset: 0x12D9090 VA: 0x1812DAA90
	public Color get_SunRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DACE0 Offset: 0x12D92E0 VA: 0x1812DACE0
	public void set_SunRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA960 Offset: 0x12D8F60 VA: 0x1812DA960
	public Color get_MoonRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC30 Offset: 0x12D9230 VA: 0x1812DAC30
	public void set_MoonRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB1AF0 Offset: 0xEB00F0 VA: 0x180EB1AF0
	public Color get_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DACF0 Offset: 0x12D92F0 VA: 0x1812DACF0
	private void set_SunSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA970 Offset: 0x12D8F70 VA: 0x1812DA970
	public Color get_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC40 Offset: 0x12D9240 VA: 0x1812DAC40
	private void set_MoonSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAA80 Offset: 0x12D9080 VA: 0x1812DAA80
	public Color get_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DACD0 Offset: 0x12D92D0 VA: 0x1812DACD0
	private void set_SunMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA950 Offset: 0x12D8F50 VA: 0x1812DA950
	public Color get_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC20 Offset: 0x12D9220 VA: 0x1812DAC20
	private void set_MoonMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83370 Offset: 0xC81970 VA: 0x180C83370
	public Color get_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC90 Offset: 0x12D9290 VA: 0x1812DAC90
	private void set_SunCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA900 Offset: 0x12D8F00 VA: 0x1812DA900
	public Color get_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DABD0 Offset: 0x12D91D0 VA: 0x1812DABD0
	private void set_MoonCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA5D0 Offset: 0x12D8BD0 VA: 0x1812DA5D0
	public Color get_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAAF0 Offset: 0x12D90F0 VA: 0x1812DAAF0
	private void set_FogColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA5E0 Offset: 0x12D8BE0 VA: 0x1812DA5E0
	public Color get_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAB00 Offset: 0x12D9100 VA: 0x1812DAB00
	private void set_GroundColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA580 Offset: 0x12D8B80 VA: 0x1812DA580
	public Color get_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAAE0 Offset: 0x12D90E0 VA: 0x1812DAAE0
	private void set_AmbientColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DA930 Offset: 0x12D8F30 VA: 0x1812DA930
	public Color get_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DAC00 Offset: 0x12D9200 VA: 0x1812DAC00
	private void set_MoonHaloColor(Color value) { }

	// RVA: 0x12DA9D0 Offset: 0x12D8FD0 VA: 0x1812DA9D0
	public ReflectionProbe get_Probe() { }

	// RVA: 0x12DA9B0 Offset: 0x12D8FB0 VA: 0x1812DA9B0
	public GameObject get_ProbeInstance() { }

	// RVA: 0x12DA990 Offset: 0x12D8F90 VA: 0x1812DA990
	public MonoBehaviour get_ProbeEx() { }

	// RVA: 0x12D2750 Offset: 0x12D0D50 VA: 0x1812D2750
	public Vector3 OrbitalToUnity(float radius, float theta, float phi) { }

	// RVA: 0x12D2690 Offset: 0x12D0C90 VA: 0x1812D2690
	public Vector3 OrbitalToLocal(float theta, float phi) { }

	// RVA: 0x12D3E70 Offset: 0x12D2470 VA: 0x1812D3E70
	public Color SampleAtmosphere(Vector3 direction, bool directLight = True) { }

	// RVA: 0x12D3D10 Offset: 0x12D2310 VA: 0x1812D3D10
	public SphericalHarmonicsL2 RenderToSphericalHarmonics() { }

	// RVA: 0x12D2CF0 Offset: 0x12D12F0 VA: 0x1812D2CF0
	public SphericalHarmonicsL2 RenderToSphericalHarmonics(float intensity, float saturation) { }

	// RVA: 0x12D2860 Offset: 0x12D0E60 VA: 0x1812D2860
	public void RenderToCubemap(RenderTexture targetTexture) { }

	// RVA: 0x12D29A0 Offset: 0x12D0FA0 VA: 0x1812D29A0
	public void RenderToProbe() { }

	// RVA: 0x12D2820 Offset: 0x12D0E20 VA: 0x1812D2820
	public bool ReflectionIsUpdating() { }

	// RVA: 0x12D8370 Offset: 0x12D6970 VA: 0x1812D8370
	private void UpdateProbeBlending(float lerp) { }

	// RVA: 0x12D8460 Offset: 0x12D6A60 VA: 0x1812D8460
	private void UpdateProbeProperties(ReflectionProbe probe) { }

	// RVA: 0x12D41F0 Offset: 0x12D27F0 VA: 0x1812D41F0
	public Color SampleFogColor(bool directLight = True) { }

	// RVA: 0x12D44A0 Offset: 0x12D2AA0 VA: 0x1812D44A0
	public Color SampleSkyColor() { }

	// RVA: 0x12D4130 Offset: 0x12D2730 VA: 0x1812D4130
	public Color SampleEquatorColor() { }

	// RVA: 0x12D82F0 Offset: 0x12D68F0 VA: 0x1812D82F0
	public void UpdateFog() { }

	// RVA: 0x12D59C0 Offset: 0x12D3FC0 VA: 0x1812D59C0
	public void UpdateAmbient() { }

	// RVA: 0x12D8D50 Offset: 0x12D7350 VA: 0x1812D8D50
	public void UpdateReflection() { }

	// RVA: 0x12D1FF0 Offset: 0x12D05F0 VA: 0x1812D1FF0
	public void DelayReflectionUpdate() { }

	// RVA: 0x12D23E0 Offset: 0x12D09E0 VA: 0x1812D23E0
	public void LoadParameters(string xml) { }

	// RVA: 0x12D45B0 Offset: 0x12D2BB0 VA: 0x1812D45B0
	public string SaveParameters() { }

	// RVA: 0x12D8740 Offset: 0x12D6D40 VA: 0x1812D8740
	private void UpdateQualitySettings() { }

	// RVA: 0x12D8E50 Offset: 0x12D7450 VA: 0x1812D8E50
	private void UpdateRenderSettings() { }

	// RVA: 0x12D9430 Offset: 0x12D7A30 VA: 0x1812D9430
	private void UpdateShaderKeywords() { }

	// RVA: 0x12D9630 Offset: 0x12D7C30 VA: 0x1812D9630
	private void UpdateShaderProperties() { }

	// RVA: 0x12D4B20 Offset: 0x12D3120 VA: 0x1812D4B20
	private float ShaderScale(float inCos) { }

	// RVA: 0x12D4800 Offset: 0x12D2E00 VA: 0x1812D4800
	private float ShaderMiePhase(float eyeCos, float eyeCos2) { }

	// RVA: 0x12D4B00 Offset: 0x12D3100 VA: 0x1812D4B00
	private float ShaderRayleighPhase(float eyeCos2) { }

	// RVA: 0x12D4A10 Offset: 0x12D3010 VA: 0x1812D4A10
	private Color ShaderNightSkyColor(Vector3 dir) { }

	// RVA: 0x12D48D0 Offset: 0x12D2ED0 VA: 0x1812D48D0
	private Color ShaderMoonHaloColor(Vector3 dir) { }

	// RVA: 0x12D5770 Offset: 0x12D3D70 VA: 0x1812D5770
	private Color TOD_HDR2LDR(Color color) { }

	// RVA: 0x12D5710 Offset: 0x12D3D10 VA: 0x1812D5710
	private Color TOD_GAMMA2LINEAR(Color color) { }

	// RVA: 0x12D58F0 Offset: 0x12D3EF0 VA: 0x1812D58F0
	private Color TOD_LINEAR2GAMMA(Color color) { }

	// RVA: 0x12D4BD0 Offset: 0x12D31D0 VA: 0x1812D4BD0
	private Color ShaderScatteringColor(Vector3 dir, bool directLight = True) { }

	// RVA: 0x12D2000 Offset: 0x12D0600 VA: 0x1812D2000
	private void Initialize() { }

	// RVA: 0x12D1E40 Offset: 0x12D0440 VA: 0x1812D1E40
	private void Cleanup() { }

	// RVA: 0x12D2640 Offset: 0x12D0C40 VA: 0x1812D2640
	protected void OnEnable() { }

	// RVA: 0x12D2630 Offset: 0x12D0C30 VA: 0x1812D2630
	protected void OnDisable() { }

	// RVA: 0x12D2100 Offset: 0x12D0700 VA: 0x1812D2100
	protected void LateUpdate() { }

	// RVA: 0x12D2650 Offset: 0x12D0C50 VA: 0x1812D2650
	protected void OnValidate() { }

	// RVA: 0x12D9280 Offset: 0x12D7880 VA: 0x1812D9280
	private void UpdateScattering() { }

	// RVA: 0x12D6130 Offset: 0x12D4730 VA: 0x1812D6130
	private void UpdateCelestials() { }

	// RVA: 0x12DA470 Offset: 0x12D8A70 VA: 0x1812DA470
	public void .ctor() { }

	// RVA: 0x12DA3B0 Offset: 0x12D89B0 VA: 0x1812DA3B0
	private static void .cctor() { }

}

public class TOD_Sky.ReflectionProbeState // TypeDefIndex: 8109
{	// Fields
	public ReflectionProbe Probe; // 0x10
	public GameObject ProbeInstance; // 0x18
	public MonoBehaviour ProbeEx; // 0x20
	public int ProbeRenderID; // 0x28

	// Methods

	// RVA: 0x12D0D00 Offset: 0x12CF300 VA: 0x1812D0D00
	public void InitializePrimary(Vector3 position, GameObject prefab) { }

	// RVA: 0x12D10C0 Offset: 0x12CF6C0 VA: 0x1812D10C0
	public void InitializeSecondary(Vector3 position) { }

	// RVA: 0x12D1260 Offset: 0x12CF860 VA: 0x1812D1260
	public void .ctor() { }

}

public class TOD_Time : MonoBehaviour // TypeDefIndex: 8110
{	// Fields
	[TooltipAttribute] // RVA: 0x904C0 Offset: 0x8F8C0 VA: 0x1800904C0
	[TOD_MinAttribute] // RVA: 0x904C0 Offset: 0x8F8C0 VA: 0x1800904C0
	public float DayLengthInMinutes; // 0x18
	[TooltipAttribute] // RVA: 0x90740 Offset: 0x8FB40 VA: 0x180090740
	public bool ProgressTime; // 0x1C
	[TooltipAttribute] // RVA: 0x908A0 Offset: 0x8FCA0 VA: 0x1800908A0
	public bool UseDeviceDate; // 0x1D
	[TooltipAttribute] // RVA: 0x908D0 Offset: 0x8FCD0 VA: 0x1800908D0
	public bool UseDeviceTime; // 0x1E
	[TooltipAttribute] // RVA: 0x90A40 Offset: 0x8FE40 VA: 0x180090A40
	public bool UseTimeCurve; // 0x1F
	[TooltipAttribute] // RVA: 0x90BF0 Offset: 0x8FFF0 VA: 0x180090BF0
	public AnimationCurve TimeCurve; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnSecond; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnMinute; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnHour; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnDay; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnMonth; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnYear; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnSunrise; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action OnSunset; // 0x60
	private TOD_Sky sky; // 0x68
	private AnimationCurve timeCurve; // 0x70
	private AnimationCurve timeCurveInverse; // 0x78
	private float timeFraction; // 0x80

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DBE30 Offset: 0x12DA430 VA: 0x1812DBE30
	public void add_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC330 Offset: 0x12DA930 VA: 0x1812DC330
	public void remove_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DBCF0 Offset: 0x12DA2F0 VA: 0x1812DBCF0
	public void add_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC1F0 Offset: 0x12DA7F0 VA: 0x1812DC1F0
	public void remove_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DBC50 Offset: 0x12DA250 VA: 0x1812DBC50
	public void add_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC150 Offset: 0x12DA750 VA: 0x1812DC150
	public void remove_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DBBB0 Offset: 0x12DA1B0 VA: 0x1812DBBB0
	public void add_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC0B0 Offset: 0x12DA6B0 VA: 0x1812DC0B0
	public void remove_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DBD90 Offset: 0x12DA390 VA: 0x1812DBD90
	public void add_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC290 Offset: 0x12DA890 VA: 0x1812DC290
	public void remove_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC010 Offset: 0x12DA610 VA: 0x1812DC010
	public void add_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC510 Offset: 0x12DAB10 VA: 0x1812DC510
	public void remove_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DBED0 Offset: 0x12DA4D0 VA: 0x1812DBED0
	public void add_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC3D0 Offset: 0x12DA9D0 VA: 0x1812DC3D0
	public void remove_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DBF70 Offset: 0x12DA570 VA: 0x1812DBF70
	public void add_OnSunset(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12DC470 Offset: 0x12DAA70 VA: 0x1812DC470
	public void remove_OnSunset(Action value) { }

	// RVA: 0x12DB930 Offset: 0x12D9F30 VA: 0x1812DB930
	public void RefreshTimeCurve() { }

	// RVA: 0x12DB0D0 Offset: 0x12D96D0 VA: 0x1812DB0D0
	public float ApplyTimeCurve(float deltaTime) { }

	// RVA: 0x12DAD80 Offset: 0x12D9380 VA: 0x1812DAD80
	public void AddHours(float hours, bool adjust = True) { }

	// RVA: 0x12DB0B0 Offset: 0x12D96B0 VA: 0x1812DB0B0
	public void AddSeconds(float seconds, bool adjust = True) { }

	// RVA: 0x12DB6D0 Offset: 0x12D9CD0 VA: 0x1812DB6D0
	private void CalculateLinearTangents(Keyframe[] keys) { }

	// RVA: 0x12DB1F0 Offset: 0x12D97F0 VA: 0x1812DB1F0
	private void ApproximateCurve(AnimationCurve source, out AnimationCurve approxCurve, out AnimationCurve approxInverse) { }

	// RVA: 0x12DB480 Offset: 0x12D9A80 VA: 0x1812DB480
	protected void Awake() { }

	// RVA: 0x12DBA00 Offset: 0x12DA000 VA: 0x1812DBA00
	protected void Update() { }

	// RVA: 0x12DBB50 Offset: 0x12DA150 VA: 0x1812DBB50
	public void .ctor() { }

}

public static class TOD_Util // TypeDefIndex: 8111
{	// Methods

	// RVA: 0x12DC850 Offset: 0x12DAE50 VA: 0x1812DC850
	public static Color MulRGB(Color color, float multiplier) { }

	// RVA: 0x12DC7E0 Offset: 0x12DADE0 VA: 0x1812DC7E0
	public static Color MulRGBA(Color color, float multiplier) { }

	// RVA: 0x12DC9E0 Offset: 0x12DAFE0 VA: 0x1812DC9E0
	public static Color PowRGB(Color color, float power) { }

	// RVA: 0x12DC8C0 Offset: 0x12DAEC0 VA: 0x1812DC8C0
	public static Color PowRGBA(Color color, float power) { }

	// RVA: 0x12DCB90 Offset: 0x12DB190 VA: 0x1812DCB90
	public static Color SatRGB(Color color, float saturation) { }

	// RVA: 0x12DCAE0 Offset: 0x12DB0E0 VA: 0x1812DCAE0
	public static Color SatRGBA(Color color, float saturation) { }

	// RVA: 0x12DC6A0 Offset: 0x12DACA0 VA: 0x1812DC6A0
	public static Color AdjustRGB(Color color, float intensity, float saturation) { }

	// RVA: 0x12DC5B0 Offset: 0x12DABB0 VA: 0x1812DC5B0
	public static Color AdjustRGBA(Color color, float intensity, float saturation) { }

	// RVA: 0x12DC780 Offset: 0x12DAD80 VA: 0x1812DC780
	public static Color ApplyAlpha(Color color) { }

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570EF0 Offset: 0x56F4F0 VA: 0x180570EF0
	|-TOD_Util.Swap<object>
	|-TOD_Util.Swap<TOD_Sky.ReflectionProbeState>
	*/

}

public abstract class TOD_Audio : MonoBehaviour // TypeDefIndex: 8112
{	// Fields
	private AudioSource audioComponent; // 0x18

	// Methods

	// RVA: 0x1074E20 Offset: 0x1073420 VA: 0x181074E20
	protected float GetVolume() { }

	// RVA: 0x1074EB0 Offset: 0x10734B0 VA: 0x181074EB0
	protected void SetVolume(float value) { }

	// RVA: 0x1074DD0 Offset: 0x10733D0 VA: 0x181074DD0
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

public class TOD_AudioAtDay : TOD_Audio // TypeDefIndex: 8113
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxVolume; // 0x28

	// Methods

	// RVA: 0x1074800 Offset: 0x1072E00 VA: 0x181074800
	protected void Start() { }

	// RVA: 0x10748A0 Offset: 0x1072EA0 VA: 0x1810748A0
	protected void Update() { }

	// RVA: 0x57BC30 Offset: 0x57A230 VA: 0x18057BC30
	public void .ctor() { }

}

public class TOD_AudioAtNight : TOD_Audio // TypeDefIndex: 8114
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxVolume; // 0x28

	// Methods

	// RVA: 0x10749B0 Offset: 0x1072FB0 VA: 0x1810749B0
	protected void Start() { }

	// RVA: 0x1074A50 Offset: 0x1073050 VA: 0x181074A50
	protected void Update() { }

	// RVA: 0x57BC30 Offset: 0x57A230 VA: 0x18057BC30
	public void .ctor() { }

}

public class TOD_AudioAtTime : TOD_Audio // TypeDefIndex: 8115
{	// Fields
	public AnimationCurve Volume; // 0x20

	// Methods

	// RVA: 0x1074B60 Offset: 0x1073160 VA: 0x181074B60
	protected void Update() { }

	// RVA: 0x1074C00 Offset: 0x1073200 VA: 0x181074C00
	public void .ctor() { }

}

public abstract class TOD_Light : MonoBehaviour // TypeDefIndex: 8116
{	// Fields
	private Light lightComponent; // 0x18

	// Methods

	// RVA: 0x1078450 Offset: 0x1076A50 VA: 0x181078450
	protected float GetIntensity() { }

	// RVA: 0x10784E0 Offset: 0x1076AE0 VA: 0x1810784E0
	protected void SetIntensity(float value) { }

	// RVA: 0x1078400 Offset: 0x1076A00 VA: 0x181078400
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

public class TOD_LightAtDay : TOD_Light // TypeDefIndex: 8117
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxIntensity; // 0x28

	// Methods

	// RVA: 0x1077E30 Offset: 0x1076430 VA: 0x181077E30
	protected void Start() { }

	// RVA: 0x1077ED0 Offset: 0x10764D0 VA: 0x181077ED0
	protected void Update() { }

	// RVA: 0x57BC30 Offset: 0x57A230 VA: 0x18057BC30
	public void .ctor() { }

}

public class TOD_LightAtNight : TOD_Light // TypeDefIndex: 8118
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxIntensity; // 0x28

	// Methods

	// RVA: 0x1077FE0 Offset: 0x10765E0 VA: 0x181077FE0
	protected void Start() { }

	// RVA: 0x1078080 Offset: 0x1076680 VA: 0x181078080
	protected void Update() { }

	// RVA: 0x57BC30 Offset: 0x57A230 VA: 0x18057BC30
	public void .ctor() { }

}

public class TOD_LightAtTime : TOD_Light // TypeDefIndex: 8119
{	// Fields
	public AnimationCurve Intensity; // 0x20

	// Methods

	// RVA: 0x1078190 Offset: 0x1076790 VA: 0x181078190
	protected void Update() { }

	// RVA: 0x1078230 Offset: 0x1076830 VA: 0x181078230
	public void .ctor() { }

}

public class TOD_LoadSkyFromFile : MonoBehaviour // TypeDefIndex: 8120
{	// Fields
	public TOD_Sky sky; // 0x18
	public TextAsset textAsset; // 0x20

	// Methods

	// RVA: 0x1078590 Offset: 0x1076B90 VA: 0x181078590
	protected void Start() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class TOD_Particle : MonoBehaviour // TypeDefIndex: 8121
{	// Fields
	private ParticleSystem particleComponent; // 0x18

	// Methods

	// RVA: 0x1078F40 Offset: 0x1077540 VA: 0x181078F40
	protected float GetEmission() { }

	// RVA: 0x1078FE0 Offset: 0x10775E0 VA: 0x181078FE0
	protected void SetEmission(float value) { }

	// RVA: 0x1078EF0 Offset: 0x10774F0 VA: 0x181078EF0
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

public class TOD_ParticleAtDay : TOD_Particle // TypeDefIndex: 8122
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxEmission; // 0x28

	// Methods

	// RVA: 0x1078920 Offset: 0x1076F20 VA: 0x181078920
	protected void Start() { }

	// RVA: 0x10789C0 Offset: 0x1076FC0 VA: 0x1810789C0
	protected void Update() { }

	// RVA: 0x57BC30 Offset: 0x57A230 VA: 0x18057BC30
	public void .ctor() { }

}

public class TOD_ParticleAtNight : TOD_Particle // TypeDefIndex: 8123
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxEmission; // 0x28

	// Methods

	// RVA: 0x1078AD0 Offset: 0x10770D0 VA: 0x181078AD0
	protected void Start() { }

	// RVA: 0x1078B70 Offset: 0x1077170 VA: 0x181078B70
	protected void Update() { }

	// RVA: 0x57BC30 Offset: 0x57A230 VA: 0x18057BC30
	public void .ctor() { }

}

public class TOD_ParticleAtTime : TOD_Particle // TypeDefIndex: 8124
{	// Fields
	public AnimationCurve Emission; // 0x20

	// Methods

	// RVA: 0x1078C80 Offset: 0x1077280 VA: 0x181078C80
	protected void Update() { }

	// RVA: 0x1078D20 Offset: 0x1077320 VA: 0x181078D20
	public void .ctor() { }

}

public abstract class TOD_Render : MonoBehaviour // TypeDefIndex: 8125
{	// Fields
	private Renderer rendererComponent; // 0x18

	// Methods

	// RVA: 0x1079920 Offset: 0x1077F20 VA: 0x181079920
	protected void SetState(bool value) { }

	// RVA: 0x10798D0 Offset: 0x1077ED0 VA: 0x1810798D0
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

public class TOD_RenderAtDay : TOD_Render // TypeDefIndex: 8126
{	// Methods

	// RVA: 0x1079710 Offset: 0x1077D10 VA: 0x181079710
	protected void Start() { }

	// RVA: 0x1079780 Offset: 0x1077D80 VA: 0x181079780
	protected void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TOD_RenderAtNight : TOD_Render // TypeDefIndex: 8127
{	// Methods

	// RVA: 0x10797F0 Offset: 0x1077DF0 VA: 0x1810797F0
	protected void Start() { }

	// RVA: 0x1079860 Offset: 0x1077E60 VA: 0x181079860
	protected void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TOD_WeatherManager : MonoBehaviour // TypeDefIndex: 8128
{	// Fields
	public ParticleSystem RainParticleSystem; // 0x18
	public float FadeTime; // 0x20
	public TOD_WeatherManager.RainType Rain; // 0x24
	public TOD_WeatherManager.CloudType Clouds; // 0x28
	public TOD_WeatherManager.AtmosphereType Atmosphere; // 0x2C
	private float cloudOpacityMax; // 0x30
	private float cloudBrightnessMax; // 0x34
	private float atmosphereBrightnessMax; // 0x38
	private float rainEmissionMax; // 0x3C
	private float cloudOpacity; // 0x40
	private float cloudCoverage; // 0x44
	private float cloudBrightness; // 0x48
	private float atmosphereFog; // 0x4C
	private float atmosphereBrightness; // 0x50
	private float rainEmission; // 0x54

	// Methods

	// RVA: 0x12DCC20 Offset: 0x12DB220 VA: 0x1812DCC20
	private float GetRainEmission() { }

	// RVA: 0x12DCCC0 Offset: 0x12DB2C0 VA: 0x1812DCCC0
	private void SetRainEmission(float value) { }

	// RVA: 0x12DCD60 Offset: 0x12DB360 VA: 0x1812DCD60
	protected void Start() { }

	// RVA: 0x12DCE30 Offset: 0x12DB430 VA: 0x1812DCE30
	protected void Update() { }

	// RVA: 0x4C7F30 Offset: 0x4C6530 VA: 0x1804C7F30
	public void .ctor() { }

}

public enum TOD_WeatherManager.RainType // TypeDefIndex: 8129
{	// Fields
	public int value__; // 0x0
	public const TOD_WeatherManager.RainType None = 0;
	public const TOD_WeatherManager.RainType Light = 1;
	public const TOD_WeatherManager.RainType Heavy = 2;

}

public enum TOD_WeatherManager.CloudType // TypeDefIndex: 8130
{	// Fields
	public int value__; // 0x0
	public const TOD_WeatherManager.CloudType None = 0;
	public const TOD_WeatherManager.CloudType Few = 1;
	public const TOD_WeatherManager.CloudType Scattered = 2;
	public const TOD_WeatherManager.CloudType Broken = 3;
	public const TOD_WeatherManager.CloudType Overcast = 4;

}

public enum TOD_WeatherManager.AtmosphereType // TypeDefIndex: 8131
{	// Fields
	public int value__; // 0x0
	public const TOD_WeatherManager.AtmosphereType Clear = 0;
	public const TOD_WeatherManager.AtmosphereType Storm = 1;
	public const TOD_WeatherManager.AtmosphereType Dust = 2;
	public const TOD_WeatherManager.AtmosphereType Fog = 3;

}

