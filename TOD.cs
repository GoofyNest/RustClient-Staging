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
	// RVA: 0x1075310 Offset: 0x1073910 VA: 0x181075310
	public Vector3 get_CloudUV() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10754F0 Offset: 0x1073AF0 VA: 0x1810754F0
	public void set_CloudUV(Vector3 value) { }

	// RVA: 0x1075330 Offset: 0x1073930 VA: 0x181075330
	public Vector3 get_OffsetUV() { }

	// RVA: 0x1075020 Offset: 0x1073620 VA: 0x181075020
	protected void Start() { }

	// RVA: 0x10750D0 Offset: 0x10736D0 VA: 0x1810750D0
	public void Update() { }

	// RVA: 0x10752F0 Offset: 0x10738F0 VA: 0x1810752F0
	public void .ctor() { }

}

public class TOD_MinAttribute : PropertyAttribute // TypeDefIndex: 8069
{	// Fields
	public float min; // 0x10

	// Methods

	// RVA: 0x5A4E70 Offset: 0x5A3470 VA: 0x1805A4E70
	public void .ctor(float min) { }

}

public class TOD_MaxAttribute : PropertyAttribute // TypeDefIndex: 8070
{	// Fields
	public float max; // 0x10

	// Methods

	// RVA: 0x5A4E70 Offset: 0x5A3470 VA: 0x1805A4E70
	public void .ctor(float max) { }

}

public class TOD_RangeAttribute : PropertyAttribute // TypeDefIndex: 8071
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x764E40 Offset: 0x763440 VA: 0x180764E40
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
	|-RVA: 0xBE0AD0 Offset: 0xBDF0D0 VA: 0x180BE0AD0
	|-TOD_Billboard.GetComponentInParents<object>
	*/

	// RVA: 0x693090 Offset: 0x691690 VA: 0x180693090
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

	// RVA: 0x1076870 Offset: 0x1074E70 VA: 0x181076870
	public bool get_HDR() { }

	// RVA: 0x1076900 Offset: 0x1074F00 VA: 0x181076900
	public float get_NearClipPlane() { }

	// RVA: 0x10767E0 Offset: 0x1074DE0 VA: 0x1810767E0
	public float get_FarClipPlane() { }

	// RVA: 0x1076730 Offset: 0x1074D30 VA: 0x181076730
	public Color get_BackgroundColor() { }

	// RVA: 0x10763F0 Offset: 0x10749F0 VA: 0x1810763F0
	protected void OnValidate() { }

	// RVA: 0x1076040 Offset: 0x1074640 VA: 0x181076040
	protected void OnEnable() { }

	// RVA: 0x1076470 Offset: 0x1074A70 VA: 0x181076470
	protected void Update() { }

	// RVA: 0x1076110 Offset: 0x1074710 VA: 0x181076110
	protected void OnPreCull() { }

	// RVA: 0x1075EC0 Offset: 0x10744C0 VA: 0x181075EC0
	private TOD_Sky FindSky(bool fallback = False) { }

	// RVA: 0x1075E20 Offset: 0x1074420 VA: 0x181075E20
	public void DoDomeScaleToFarClip() { }

	// RVA: 0x1075C90 Offset: 0x1074290 VA: 0x181075C90
	public void DoDomePosToCamera() { }

	// RVA: 0x10766B0 Offset: 0x1074CB0 VA: 0x1810766B0
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
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public Transform get_DomeTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_DomeTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public Transform get_SpaceTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	public void set_SpaceTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public Transform get_StarTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	public void set_StarTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public Transform get_SunTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	public void set_SunTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public Transform get_MoonTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void set_MoonTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public Transform get_AtmosphereTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574390 Offset: 0x572990 VA: 0x180574390
	public void set_AtmosphereTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public Transform get_ClearTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E3FF0 Offset: 0x4E25F0 VA: 0x1804E3FF0
	public void set_ClearTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public Transform get_CloudTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	public void set_CloudTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5742F0 Offset: 0x5728F0 VA: 0x1805742F0
	public Transform get_BillboardTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	public void set_BillboardTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public Transform get_LightTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60
	public void set_LightTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public Renderer get_SpaceRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE40 Offset: 0x79A440 VA: 0x18079BE40
	public void set_SpaceRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public Renderer get_StarRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	public void set_StarRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE20 Offset: 0x79A420 VA: 0x18079BE20
	public Renderer get_SunRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BEA0 Offset: 0x79A4A0 VA: 0x18079BEA0
	public void set_SunRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA0E50 Offset: 0xD9F450 VA: 0x180DA0E50
	public Renderer get_MoonRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA1230 Offset: 0xD9F830 VA: 0x180DA1230
	public void set_MoonRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDF0 Offset: 0x79A3F0 VA: 0x18079BDF0
	public Renderer get_AtmosphereRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE70 Offset: 0x79A470 VA: 0x18079BE70
	public void set_AtmosphereRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDA01E0 Offset: 0xD9E7E0 VA: 0x180DA01E0
	public Renderer get_ClearRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD357D0 Offset: 0xD33DD0 VA: 0x180D357D0
	public void set_ClearRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF330 Offset: 0x4ED930 VA: 0x1804EF330
	public Renderer get_CloudRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4EF340 Offset: 0x4ED940 VA: 0x1804EF340
	public void set_CloudRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D970 Offset: 0x88BF70 VA: 0x18088D970
	public Renderer[] get_BillboardRenderers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9F0 Offset: 0x88BFF0 VA: 0x18088D9F0
	public void set_BillboardRenderers(Renderer[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public MeshFilter get_SpaceMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077430 Offset: 0x1075A30 VA: 0x181077430
	public void set_SpaceMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB0F550 Offset: 0xB0DB50 VA: 0x180B0F550
	public MeshFilter get_StarMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077450 Offset: 0x1075A50 VA: 0x181077450
	public void set_StarMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B0D0 Offset: 0xA296D0 VA: 0x180A2B0D0
	public MeshFilter get_SunMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B3D0 Offset: 0xA299D0 VA: 0x180A2B3D0
	public void set_SunMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83900 Offset: 0xC81F00 VA: 0x180C83900
	public MeshFilter get_MoonMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10773F0 Offset: 0x10759F0 VA: 0x1810773F0
	public void set_MoonMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D560 Offset: 0x88BB60 VA: 0x18088D560
	public MeshFilter get_AtmosphereMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9B0 Offset: 0x88BFB0 VA: 0x18088D9B0
	public void set_AtmosphereMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE670B0 Offset: 0xE656B0 VA: 0x180E670B0
	public MeshFilter get_ClearMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE66770 Offset: 0xE64D70 VA: 0x180E66770
	public void set_ClearMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690
	public MeshFilter get_CloudMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC743E0 Offset: 0xC729E0 VA: 0x180C743E0
	public void set_CloudMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1270 Offset: 0x4BF870 VA: 0x1804C1270
	public MeshFilter[] get_BillboardMeshFilters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1340 Offset: 0x4BF940 VA: 0x1804C1340
	public void set_BillboardMeshFilters(MeshFilter[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701870 Offset: 0x6FFE70 VA: 0x180701870
	public Material get_SpaceMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x701900 Offset: 0x6FFF00 VA: 0x180701900
	public void set_SpaceMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBC7A40 Offset: 0xBC6040 VA: 0x180BC7A40
	public Material get_StarMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077440 Offset: 0x1075A40 VA: 0x181077440
	public void set_StarMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD62610 Offset: 0xD60C10 VA: 0x180D62610
	public Material get_SunMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD62620 Offset: 0xD60C20 VA: 0x180D62620
	public void set_SunMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077350 Offset: 0x1075950 VA: 0x181077350
	public Material get_MoonMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10773E0 Offset: 0x10759E0 VA: 0x1810773E0
	public void set_MoonMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077340 Offset: 0x1075940 VA: 0x181077340
	public Material get_AtmosphereMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077390 Offset: 0x1075990 VA: 0x181077390
	public void set_AtmosphereMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC838C0 Offset: 0xC81EC0 VA: 0x180C838C0
	public Material get_ClearMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10773B0 Offset: 0x10759B0 VA: 0x1810773B0
	public void set_ClearMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B27D0 Offset: 0x7B0DD0 VA: 0x1807B27D0
	public Material get_CloudMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10773C0 Offset: 0x10759C0 VA: 0x1810773C0
	public void set_CloudMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3CEA0 Offset: 0xA3B4A0 VA: 0x180A3CEA0
	public Material[] get_BillboardMaterials() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10773A0 Offset: 0x10759A0 VA: 0x1810773A0
	public void set_BillboardMaterials(Material[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x900630 Offset: 0x8FEC30 VA: 0x180900630
	public Light get_LightSource() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10773D0 Offset: 0x10759D0 VA: 0x1810773D0
	public void set_LightSource(Light value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC838F0 Offset: 0xC81EF0 VA: 0x180C838F0
	public TOD_Sky get_Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD43DF0 Offset: 0xD423F0 VA: 0x180D43DF0
	public void set_Sky(TOD_Sky value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC838D0 Offset: 0xC81ED0 VA: 0x180C838D0
	public TOD_Animation get_Animation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077380 Offset: 0x1075980 VA: 0x181077380
	public void set_Animation(TOD_Animation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB0EE20 Offset: 0xB0D420 VA: 0x180B0EE20
	public TOD_Time get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077460 Offset: 0x1075A60 VA: 0x181077460
	public void set_Time(TOD_Time value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC742F0 Offset: 0xC728F0 VA: 0x180C742F0
	public TOD_Camera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC743F0 Offset: 0xC729F0 VA: 0x180C743F0
	public void set_Camera(TOD_Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD92C0 Offset: 0xAD78C0 VA: 0x180AD92C0
	public TOD_Rays get_Rays() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077400 Offset: 0x1075A00 VA: 0x181077400
	public void set_Rays(TOD_Rays value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077360 Offset: 0x1075960 VA: 0x181077360
	public TOD_Scattering get_Scattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077410 Offset: 0x1075A10 VA: 0x181077410
	public void set_Scattering(TOD_Scattering value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077370 Offset: 0x1075970 VA: 0x181077370
	public TOD_Shadows get_Shadows() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1077420 Offset: 0x1075A20 VA: 0x181077420
	public void set_Shadows(TOD_Shadows value) { }

	// RVA: 0x10769E0 Offset: 0x1074FE0 VA: 0x1810769E0
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

	// RVA: 0x1077BA0 Offset: 0x10761A0 VA: 0x181077BA0
	protected Material CreateMaterial(Shader shader) { }

	// RVA: 0x1077F30 Offset: 0x1076530 VA: 0x181077F30
	private TOD_Sky FindSky(bool fallback = False) { }

	// RVA: 0x1077820 Offset: 0x1075E20 VA: 0x181077820
	protected void Awake() { }

	// RVA: 0x1077920 Offset: 0x1075F20 VA: 0x181077920
	protected bool CheckSupport(bool needDepth = False, bool needHdr = False) { }

	// RVA: 0x8D6190 Offset: 0x8D4790 VA: 0x1808D6190
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x10780B0 Offset: 0x10766B0 VA: 0x1810780B0
	protected Matrix4x4 FrustumCorners() { }

	// RVA: 0x1078560 Offset: 0x1076B60 VA: 0x181078560
	protected RenderTexture GetSkyMask(RenderTexture source, Material skyMaskMaterial, Material screenClearMaterial, TOD_ImageEffect.ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

	// RVA: 0x1078B10 Offset: 0x1077110 VA: 0x181078B10
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

	// RVA: 0x1079540 Offset: 0x1077B40 VA: 0x181079540
	public void .ctor(TOD_Sky sky) { }

	// RVA: 0x1079430 Offset: 0x1077A30 VA: 0x181079430
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

	// RVA: 0x10774A0 Offset: 0x1075AA0 VA: 0x1810774A0
	public DateTime get_DateTime() { }

	// RVA: 0x1077610 Offset: 0x1075C10 VA: 0x181077610
	public void set_DateTime(DateTime value) { }

	// RVA: 0x1077550 Offset: 0x1075B50 VA: 0x181077550
	public long get_Ticks() { }

	// RVA: 0x10776F0 Offset: 0x1075CF0 VA: 0x1810776F0
	public void set_Ticks(long value) { }

	// RVA: 0x1077470 Offset: 0x1075A70 VA: 0x181077470
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

	// RVA: 0x1075500 Offset: 0x1073B00 VA: 0x181075500
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

	// RVA: 0x10777E0 Offset: 0x1075DE0 VA: 0x1810777E0
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

	// RVA: 0x1079400 Offset: 0x1077A00 VA: 0x181079400
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

	// RVA: 0x12E14D0 Offset: 0x12DFAD0 VA: 0x1812E14D0
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

	// RVA: 0x10793C0 Offset: 0x10779C0 VA: 0x1810793C0
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

	// RVA: 0x12E14B0 Offset: 0x12DFAB0 VA: 0x1812E14B0
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

	// RVA: 0x1076990 Offset: 0x1074F90 VA: 0x181076990
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

	// RVA: 0x1077810 Offset: 0x1075E10 VA: 0x181077810
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

	// RVA: 0x1075000 Offset: 0x1073600 VA: 0x181075000
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

	// RVA: 0x107A410 Offset: 0x1078A10 VA: 0x18107A410
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

	// RVA: 0x1079F00 Offset: 0x1078500 VA: 0x181079F00
	protected void OnEnable() { }

	// RVA: 0x1079DB0 Offset: 0x10783B0 VA: 0x181079DB0
	protected void OnDisable() { }

	// RVA: 0x107A0A0 Offset: 0x10786A0 VA: 0x18107A0A0
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x107A390 Offset: 0x1078990 VA: 0x18107A390
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
	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0
	public int get_ID_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5828E0 Offset: 0x580EE0 VA: 0x1805828E0
	private void set_ID_SunLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE30 Offset: 0x79A430 VA: 0x18079BE30
	public int get_ID_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BEB0 Offset: 0x79A4B0 VA: 0x18079BEB0
	private void set_ID_MoonLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	public int get_ID_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8CD60 Offset: 0xF8B360 VA: 0x180F8CD60
	private void set_ID_SunSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ABC0 Offset: 0x10791C0 VA: 0x18107ABC0
	public int get_ID_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF8CD70 Offset: 0xF8B370 VA: 0x180F8CD70
	private void set_ID_MoonSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD27F40 Offset: 0xD26540 VA: 0x180D27F40
	public int get_ID_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD27EB0 Offset: 0xD264B0 VA: 0x180D27EB0
	private void set_ID_SunMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xBB0AD0 Offset: 0xBAF0D0 VA: 0x180BB0AD0
	public int get_ID_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD20 Offset: 0x1079320 VA: 0x18107AD20
	private void set_ID_MoonMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB9BA00 Offset: 0xB9A000 VA: 0x180B9BA00
	public int get_ID_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1050010 Offset: 0x104E610 VA: 0x181050010
	private void set_ID_SunCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB9BA10 Offset: 0xB9A010 VA: 0x180B9BA10
	public int get_ID_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C25B0 Offset: 0x5C0BB0 VA: 0x1805C25B0
	private void set_ID_MoonCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1052490 Offset: 0x1050A90 VA: 0x181052490
	public int get_ID_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACB0 Offset: 0x10792B0 VA: 0x18107ACB0
	private void set_ID_FogColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10524A0 Offset: 0x1050AA0 VA: 0x1810524A0
	public int get_ID_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACC0 Offset: 0x10792C0 VA: 0x18107ACC0
	private void set_ID_GroundColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AAE0 Offset: 0x10790E0 VA: 0x18107AAE0
	public int get_ID_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC20 Offset: 0x1079220 VA: 0x18107AC20
	private void set_ID_AmbientColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D7D0 Offset: 0xA4BDD0 VA: 0x180A4D7D0
	public int get_ID_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD70 Offset: 0x1079370 VA: 0x18107AD70
	private void set_ID_SunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public int get_ID_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_ID_MoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB60 Offset: 0x1079160 VA: 0x18107AB60
	public int get_ID_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACD0 Offset: 0x10792D0 VA: 0x18107ACD0
	private void set_ID_LightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB90 Offset: 0x1079190 VA: 0x18107AB90
	public int get_ID_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD00 Offset: 0x1079300 VA: 0x18107AD00
	private void set_ID_LocalSunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB80 Offset: 0x1079180 VA: 0x18107AB80
	public int get_ID_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACF0 Offset: 0x10792F0 VA: 0x18107ACF0
	private void set_ID_LocalMoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB70 Offset: 0x1079170 VA: 0x18107AB70
	public int get_ID_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACE0 Offset: 0x10792E0 VA: 0x18107ACE0
	private void set_ID_LocalLightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE31B0 Offset: 0xAE17B0 VA: 0x180AE31B0
	public int get_ID_Contrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ACA0 Offset: 0x10792A0 VA: 0x18107ACA0
	private void set_ID_Contrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAE31D0 Offset: 0xAE17D0 VA: 0x180AE31D0
	public int get_ID_Brightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x104F9D0 Offset: 0x104DFD0 VA: 0x18104F9D0
	private void set_ID_Brightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D940 Offset: 0xA4BF40 VA: 0x180A4D940
	public int get_ID_Fogginess() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D9D0 Offset: 0xA4BFD0 VA: 0x180A4D9D0
	private void set_ID_Fogginess(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x86ADA0 Offset: 0x8693A0 VA: 0x18086ADA0
	public int get_ID_Directionality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x742640 Offset: 0x740C40 VA: 0x180742640
	private void set_ID_Directionality(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ABA0 Offset: 0x10791A0 VA: 0x18107ABA0
	public int get_ID_MoonHaloPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD10 Offset: 0x1079310 VA: 0x18107AD10
	private void set_ID_MoonHaloPower(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10511C0 Offset: 0x104F7C0 VA: 0x1810511C0
	public int get_ID_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1051090 Offset: 0x104F690 VA: 0x181051090
	private void set_ID_MoonHaloColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1051250 Offset: 0x104F850 VA: 0x181051250
	public int get_ID_CloudSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10510A0 Offset: 0x104F6A0 VA: 0x1810510A0
	private void set_ID_CloudSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D960 Offset: 0x88BF60 VA: 0x18088D960
	public int get_ID_CloudOpacity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9E0 Offset: 0x88BFE0 VA: 0x18088D9E0
	private void set_ID_CloudOpacity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB10 Offset: 0x1079110 VA: 0x18107AB10
	public int get_ID_CloudCoverage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC50 Offset: 0x1079250 VA: 0x18107AC50
	private void set_ID_CloudCoverage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB50 Offset: 0x1079150 VA: 0x18107AB50
	public int get_ID_CloudSharpness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC90 Offset: 0x1079290 VA: 0x18107AC90
	private void set_ID_CloudSharpness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB20 Offset: 0x1079120 VA: 0x18107AB20
	public int get_ID_CloudDensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC60 Offset: 0x1079260 VA: 0x18107AC60
	private void set_ID_CloudDensity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB00 Offset: 0x1079100 VA: 0x18107AB00
	public int get_ID_CloudColoring() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC40 Offset: 0x1079240 VA: 0x18107AC40
	private void set_ID_CloudColoring(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AAF0 Offset: 0x10790F0 VA: 0x18107AAF0
	public int get_ID_CloudAttenuation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC30 Offset: 0x1079230 VA: 0x18107AC30
	private void set_ID_CloudAttenuation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB30 Offset: 0x1079130 VA: 0x18107AB30
	public int get_ID_CloudSaturation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC70 Offset: 0x1079270 VA: 0x18107AC70
	private void set_ID_CloudSaturation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AB40 Offset: 0x1079140 VA: 0x18107AB40
	public int get_ID_CloudScattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC80 Offset: 0x1079280 VA: 0x18107AC80
	private void set_ID_CloudScattering(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74210 Offset: 0xC72810 VA: 0x180C74210
	public int get_ID_CloudBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74350 Offset: 0xC72950 VA: 0x180C74350
	private void set_ID_CloudBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74130 Offset: 0xC72730 VA: 0x180C74130
	public int get_ID_CloudMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74330 Offset: 0xC72930 VA: 0x180C74330
	private void set_ID_CloudMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D820 Offset: 0x88BE20 VA: 0x18088D820
	public int get_ID_CloudOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9C0 Offset: 0x88BFC0 VA: 0x18088D9C0
	private void set_ID_CloudOffset(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74140 Offset: 0xC72740 VA: 0x180C74140
	public int get_ID_CloudWind() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC74340 Offset: 0xC72940 VA: 0x180C74340
	private void set_ID_CloudWind(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEC2040 Offset: 0xEC0640 VA: 0x180EC2040
	public int get_ID_StarSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD60 Offset: 0x1079360 VA: 0x18107AD60
	private void set_ID_StarSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ABD0 Offset: 0x10791D0 VA: 0x18107ABD0
	public int get_ID_StarBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD50 Offset: 0x1079350 VA: 0x18107AD50
	private void set_ID_StarBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92DF60 Offset: 0x92C560 VA: 0x18092DF60
	public int get_ID_StarVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x92DF70 Offset: 0x92C570 VA: 0x18092DF70
	private void set_ID_StarVisibility(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ABF0 Offset: 0x10791F0 VA: 0x18107ABF0
	public int get_ID_SunMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD90 Offset: 0x1079390 VA: 0x18107AD90
	private void set_ID_SunMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ABE0 Offset: 0x10791E0 VA: 0x18107ABE0
	public int get_ID_SunMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD80 Offset: 0x1079380 VA: 0x18107AD80
	private void set_ID_SunMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ABB0 Offset: 0x10791B0 VA: 0x18107ABB0
	public int get_ID_MoonMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD30 Offset: 0x1079330 VA: 0x18107AD30
	private void set_ID_MoonMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D380 Offset: 0x81B980 VA: 0x18081D380
	public int get_ID_MoonMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D740 Offset: 0x81BD40 VA: 0x18081D740
	private void set_ID_MoonMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC835D0 Offset: 0xC81BD0 VA: 0x180C835D0
	public int get_ID_kBetaMie() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ADC0 Offset: 0x10793C0 VA: 0x18107ADC0
	private void set_ID_kBetaMie(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC837A0 Offset: 0xC81DA0 VA: 0x180C837A0
	public int get_ID_kSun() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ADE0 Offset: 0x10793E0 VA: 0x18107ADE0
	private void set_ID_kSun(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC10 Offset: 0x1079210 VA: 0x18107AC10
	public int get_ID_k4PI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ADB0 Offset: 0x10793B0 VA: 0x18107ADB0
	private void set_ID_k4PI(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC837E0 Offset: 0xC81DE0 VA: 0x180C837E0
	public int get_ID_kRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ADD0 Offset: 0x10793D0 VA: 0x18107ADD0
	private void set_ID_kRadius(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D550 Offset: 0x88BB50 VA: 0x18088D550
	public int get_ID_kScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88D9A0 Offset: 0x88BFA0 VA: 0x18088D9A0
	private void set_ID_kScale(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AC00 Offset: 0x1079200 VA: 0x18107AC00
	public int get_ID_World2Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107ADA0 Offset: 0x10793A0 VA: 0x18107ADA0
	private void set_ID_World2Sky(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83500 Offset: 0xC81B00 VA: 0x180C83500
	public int get_ID_Sky2World() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x107AD40 Offset: 0x1079340 VA: 0x18107AD40
	private void set_ID_Sky2World(int value) { }

	// RVA: 0x107A6E0 Offset: 0x1078CE0 VA: 0x18107A6E0
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

	// RVA: 0x12D7B40 Offset: 0x12D6140 VA: 0x1812D7B40
	protected void OnEnable() { }

	// RVA: 0x12D79E0 Offset: 0x12D5FE0 VA: 0x1812D79E0
	protected void OnDisable() { }

	// RVA: 0x12D7D90 Offset: 0x12D6390 VA: 0x1812D7D90
	protected void OnPreCull() { }

	// RVA: 0x12D7CE0 Offset: 0x12D62E0 VA: 0x1812D7CE0
	protected void OnPostRender() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12D7E40 Offset: 0x12D6440 VA: 0x1812D7E40
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12D8160 Offset: 0x12D6760 VA: 0x1812D8160
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

	// RVA: 0x12D8270 Offset: 0x12D6870 VA: 0x1812D8270
	protected void OnEnable() { }

	// RVA: 0x12D81E0 Offset: 0x12D67E0 VA: 0x1812D81E0
	protected void OnDisable() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12D8320 Offset: 0x12D6920 VA: 0x1812D8320
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12D8550 Offset: 0x12D6B50 VA: 0x1812D8550
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

	// RVA: 0x12E0E50 Offset: 0x12DF450 VA: 0x1812E0E50
	public static List<TOD_Sky> get_Instances() { }

	// RVA: 0x12E0D80 Offset: 0x12DF380 VA: 0x1812E0D80
	public static TOD_Sky get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2BF70 Offset: 0xC2A570 VA: 0x180C2BF70
	public bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC2C450 Offset: 0xC2AA50 VA: 0x180C2C450
	private void set_Initialized(bool value) { }

	// RVA: 0x12E0D60 Offset: 0x12DF360 VA: 0x1812E0D60
	public bool get_Headless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDE0 Offset: 0x79A3E0 VA: 0x18079BDE0
	public TOD_Components get_Components() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60
	private void set_Components(TOD_Components value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public TOD_Resources get_Resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE40 Offset: 0x79A440 VA: 0x18079BE40
	private void set_Resources(TOD_Resources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E0EB0 Offset: 0x12DF4B0 VA: 0x1812E0EB0
	public bool get_IsDay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1280 Offset: 0x12DF880 VA: 0x1812E1280
	private void set_IsDay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E0EC0 Offset: 0x12DF4C0 VA: 0x1812E0EC0
	public bool get_IsNight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1290 Offset: 0x12DF890 VA: 0x1812E1290
	private void set_IsNight(bool value) { }

	// RVA: 0x12E1160 Offset: 0x12DF760 VA: 0x1812E1160
	public float get_Radius() { }

	// RVA: 0x12E0D00 Offset: 0x12DF300 VA: 0x1812E0D00
	public float get_Diameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3300 Offset: 0x5C1900 VA: 0x1805C3300
	public float get_LerpValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C34F0 Offset: 0x5C1AF0 VA: 0x1805C34F0
	private void set_LerpValue(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1220 Offset: 0x12DF820 VA: 0x1812E1220
	public float get_SunZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1480 Offset: 0x12DFA80 VA: 0x1812E1480
	private void set_SunZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E11A0 Offset: 0x12DF7A0 VA: 0x1812E11A0
	public float get_SunAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E13E0 Offset: 0x12DF9E0 VA: 0x1812E13E0
	private void set_SunAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E11B0 Offset: 0x12DF7B0 VA: 0x1812E11B0
	public float get_SunAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E13F0 Offset: 0x12DF9F0 VA: 0x1812E13F0
	private void set_SunAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E10F0 Offset: 0x12DF6F0 VA: 0x1812E10F0
	public float get_MoonZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E13D0 Offset: 0x12DF9D0 VA: 0x1812E13D0
	private void set_MoonZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1050 Offset: 0x12DF650 VA: 0x1812E1050
	public float get_MoonAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1320 Offset: 0x12DF920 VA: 0x1812E1320
	private void set_MoonAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1060 Offset: 0x12DF660 VA: 0x1812E1060
	public float get_MoonAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1330 Offset: 0x12DF930 VA: 0x1812E1330
	private void set_MoonAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1240 Offset: 0x12DF840 VA: 0x1812E1240
	public float get_SunsetTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E14A0 Offset: 0x12DFAA0 VA: 0x1812E14A0
	private void set_SunsetTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1230 Offset: 0x12DF830 VA: 0x1812E1230
	public float get_SunriseTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1490 Offset: 0x12DFA90 VA: 0x1812E1490
	private void set_SunriseTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1132E70 Offset: 0x1131470 VA: 0x181132E70
	public float get_LocalSiderealTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1133670 Offset: 0x1131C70 VA: 0x181133670
	private void set_LocalSiderealTime(float value) { }

	// RVA: 0x12E0F70 Offset: 0x12DF570 VA: 0x1812E0F70
	public float get_LightZenith() { }

	// RVA: 0x12E0F40 Offset: 0x12DF540 VA: 0x1812E0F40
	public float get_LightIntensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1210 Offset: 0x12DF810 VA: 0x1812E1210
	public float get_SunVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1470 Offset: 0x12DFA70 VA: 0x1812E1470
	private void set_SunVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1132CC0 Offset: 0x11312C0 VA: 0x181132CC0
	public float get_MoonVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E13C0 Offset: 0x12DF9C0 VA: 0x1812E13C0
	private void set_MoonVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E11C0 Offset: 0x12DF7C0 VA: 0x1812E11C0
	public Vector3 get_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1410 Offset: 0x12DFA10 VA: 0x1812E1410
	private void set_SunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1080 Offset: 0x12DF680 VA: 0x1812E1080
	public Vector3 get_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1350 Offset: 0x12DF950 VA: 0x1812E1350
	private void set_MoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E0F20 Offset: 0x12DF520 VA: 0x1812E0F20
	public Vector3 get_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E12A0 Offset: 0x12DF8A0 VA: 0x1812E12A0
	private void set_LightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1030 Offset: 0x12DF630 VA: 0x1812E1030
	public Vector3 get_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1300 Offset: 0x12DF900 VA: 0x1812E1300
	private void set_LocalSunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1010 Offset: 0x12DF610 VA: 0x1812E1010
	public Vector3 get_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E12E0 Offset: 0x12DF8E0 VA: 0x1812E12E0
	private void set_LocalMoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E0FF0 Offset: 0x12DF5F0 VA: 0x1812E0FF0
	public Vector3 get_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E12C0 Offset: 0x12DF8C0 VA: 0x1812E12C0
	private void set_LocalLightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E11E0 Offset: 0x12DF7E0 VA: 0x1812E11E0
	public Color get_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1430 Offset: 0x12DFA30 VA: 0x1812E1430
	private void set_SunLightColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E10B0 Offset: 0x12DF6B0 VA: 0x1812E10B0
	public Color get_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1380 Offset: 0x12DF980 VA: 0x1812E1380
	private void set_MoonLightColor(Color value) { }

	// RVA: 0x12E0ED0 Offset: 0x12DF4D0 VA: 0x1812E0ED0
	public Color get_LightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1200 Offset: 0x12DF800 VA: 0x1812E1200
	public Color get_SunRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1450 Offset: 0x12DFA50 VA: 0x1812E1450
	public void set_SunRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E10D0 Offset: 0x12DF6D0 VA: 0x1812E10D0
	public Color get_MoonRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E13A0 Offset: 0x12DF9A0 VA: 0x1812E13A0
	public void set_MoonRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB2860 Offset: 0xEB0E60 VA: 0x180EB2860
	public Color get_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1460 Offset: 0x12DFA60 VA: 0x1812E1460
	private void set_SunSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E10E0 Offset: 0x12DF6E0 VA: 0x1812E10E0
	public Color get_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E13B0 Offset: 0x12DF9B0 VA: 0x1812E13B0
	private void set_MoonSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E11F0 Offset: 0x12DF7F0 VA: 0x1812E11F0
	public Color get_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1440 Offset: 0x12DFA40 VA: 0x1812E1440
	private void set_SunMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E10C0 Offset: 0x12DF6C0 VA: 0x1812E10C0
	public Color get_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1390 Offset: 0x12DF990 VA: 0x1812E1390
	private void set_MoonMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC83AD0 Offset: 0xC820D0 VA: 0x180C83AD0
	public Color get_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1400 Offset: 0x12DFA00 VA: 0x1812E1400
	private void set_SunCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1070 Offset: 0x12DF670 VA: 0x1812E1070
	public Color get_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1340 Offset: 0x12DF940 VA: 0x1812E1340
	private void set_MoonCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E0D40 Offset: 0x12DF340 VA: 0x1812E0D40
	public Color get_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1260 Offset: 0x12DF860 VA: 0x1812E1260
	private void set_FogColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E0D50 Offset: 0x12DF350 VA: 0x1812E0D50
	public Color get_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1270 Offset: 0x12DF870 VA: 0x1812E1270
	private void set_GroundColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E0CF0 Offset: 0x12DF2F0 VA: 0x1812E0CF0
	public Color get_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1250 Offset: 0x12DF850 VA: 0x1812E1250
	private void set_AmbientColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E10A0 Offset: 0x12DF6A0 VA: 0x1812E10A0
	public Color get_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E1370 Offset: 0x12DF970 VA: 0x1812E1370
	private void set_MoonHaloColor(Color value) { }

	// RVA: 0x12E1140 Offset: 0x12DF740 VA: 0x1812E1140
	public ReflectionProbe get_Probe() { }

	// RVA: 0x12E1120 Offset: 0x12DF720 VA: 0x1812E1120
	public GameObject get_ProbeInstance() { }

	// RVA: 0x12E1100 Offset: 0x12DF700 VA: 0x1812E1100
	public MonoBehaviour get_ProbeEx() { }

	// RVA: 0x12D8EC0 Offset: 0x12D74C0 VA: 0x1812D8EC0
	public Vector3 OrbitalToUnity(float radius, float theta, float phi) { }

	// RVA: 0x12D8E00 Offset: 0x12D7400 VA: 0x1812D8E00
	public Vector3 OrbitalToLocal(float theta, float phi) { }

	// RVA: 0x12DA5E0 Offset: 0x12D8BE0 VA: 0x1812DA5E0
	public Color SampleAtmosphere(Vector3 direction, bool directLight = True) { }

	// RVA: 0x12DA480 Offset: 0x12D8A80 VA: 0x1812DA480
	public SphericalHarmonicsL2 RenderToSphericalHarmonics() { }

	// RVA: 0x12D9460 Offset: 0x12D7A60 VA: 0x1812D9460
	public SphericalHarmonicsL2 RenderToSphericalHarmonics(float intensity, float saturation) { }

	// RVA: 0x12D8FD0 Offset: 0x12D75D0 VA: 0x1812D8FD0
	public void RenderToCubemap(RenderTexture targetTexture) { }

	// RVA: 0x12D9110 Offset: 0x12D7710 VA: 0x1812D9110
	public void RenderToProbe() { }

	// RVA: 0x12D8F90 Offset: 0x12D7590 VA: 0x1812D8F90
	public bool ReflectionIsUpdating() { }

	// RVA: 0x12DEAE0 Offset: 0x12DD0E0 VA: 0x1812DEAE0
	private void UpdateProbeBlending(float lerp) { }

	// RVA: 0x12DEBD0 Offset: 0x12DD1D0 VA: 0x1812DEBD0
	private void UpdateProbeProperties(ReflectionProbe probe) { }

	// RVA: 0x12DA960 Offset: 0x12D8F60 VA: 0x1812DA960
	public Color SampleFogColor(bool directLight = True) { }

	// RVA: 0x12DAC10 Offset: 0x12D9210 VA: 0x1812DAC10
	public Color SampleSkyColor() { }

	// RVA: 0x12DA8A0 Offset: 0x12D8EA0 VA: 0x1812DA8A0
	public Color SampleEquatorColor() { }

	// RVA: 0x12DEA60 Offset: 0x12DD060 VA: 0x1812DEA60
	public void UpdateFog() { }

	// RVA: 0x12DC130 Offset: 0x12DA730 VA: 0x1812DC130
	public void UpdateAmbient() { }

	// RVA: 0x12DF4C0 Offset: 0x12DDAC0 VA: 0x1812DF4C0
	public void UpdateReflection() { }

	// RVA: 0x12D8760 Offset: 0x12D6D60 VA: 0x1812D8760
	public void DelayReflectionUpdate() { }

	// RVA: 0x12D8B50 Offset: 0x12D7150 VA: 0x1812D8B50
	public void LoadParameters(string xml) { }

	// RVA: 0x12DAD20 Offset: 0x12D9320 VA: 0x1812DAD20
	public string SaveParameters() { }

	// RVA: 0x12DEEB0 Offset: 0x12DD4B0 VA: 0x1812DEEB0
	private void UpdateQualitySettings() { }

	// RVA: 0x12DF5C0 Offset: 0x12DDBC0 VA: 0x1812DF5C0
	private void UpdateRenderSettings() { }

	// RVA: 0x12DFBA0 Offset: 0x12DE1A0 VA: 0x1812DFBA0
	private void UpdateShaderKeywords() { }

	// RVA: 0x12DFDA0 Offset: 0x12DE3A0 VA: 0x1812DFDA0
	private void UpdateShaderProperties() { }

	// RVA: 0x12DB290 Offset: 0x12D9890 VA: 0x1812DB290
	private float ShaderScale(float inCos) { }

	// RVA: 0x12DAF70 Offset: 0x12D9570 VA: 0x1812DAF70
	private float ShaderMiePhase(float eyeCos, float eyeCos2) { }

	// RVA: 0x12DB270 Offset: 0x12D9870 VA: 0x1812DB270
	private float ShaderRayleighPhase(float eyeCos2) { }

	// RVA: 0x12DB180 Offset: 0x12D9780 VA: 0x1812DB180
	private Color ShaderNightSkyColor(Vector3 dir) { }

	// RVA: 0x12DB040 Offset: 0x12D9640 VA: 0x1812DB040
	private Color ShaderMoonHaloColor(Vector3 dir) { }

	// RVA: 0x12DBEE0 Offset: 0x12DA4E0 VA: 0x1812DBEE0
	private Color TOD_HDR2LDR(Color color) { }

	// RVA: 0x12DBE80 Offset: 0x12DA480 VA: 0x1812DBE80
	private Color TOD_GAMMA2LINEAR(Color color) { }

	// RVA: 0x12DC060 Offset: 0x12DA660 VA: 0x1812DC060
	private Color TOD_LINEAR2GAMMA(Color color) { }

	// RVA: 0x12DB340 Offset: 0x12D9940 VA: 0x1812DB340
	private Color ShaderScatteringColor(Vector3 dir, bool directLight = True) { }

	// RVA: 0x12D8770 Offset: 0x12D6D70 VA: 0x1812D8770
	private void Initialize() { }

	// RVA: 0x12D85B0 Offset: 0x12D6BB0 VA: 0x1812D85B0
	private void Cleanup() { }

	// RVA: 0x12D8DB0 Offset: 0x12D73B0 VA: 0x1812D8DB0
	protected void OnEnable() { }

	// RVA: 0x12D8DA0 Offset: 0x12D73A0 VA: 0x1812D8DA0
	protected void OnDisable() { }

	// RVA: 0x12D8870 Offset: 0x12D6E70 VA: 0x1812D8870
	protected void LateUpdate() { }

	// RVA: 0x12D8DC0 Offset: 0x12D73C0 VA: 0x1812D8DC0
	protected void OnValidate() { }

	// RVA: 0x12DF9F0 Offset: 0x12DDFF0 VA: 0x1812DF9F0
	private void UpdateScattering() { }

	// RVA: 0x12DC8A0 Offset: 0x12DAEA0 VA: 0x1812DC8A0
	private void UpdateCelestials() { }

	// RVA: 0x12E0BE0 Offset: 0x12DF1E0 VA: 0x1812E0BE0
	public void .ctor() { }

	// RVA: 0x12E0B20 Offset: 0x12DF120 VA: 0x1812E0B20
	private static void .cctor() { }

}

public class TOD_Sky.ReflectionProbeState // TypeDefIndex: 8109
{	// Fields
	public ReflectionProbe Probe; // 0x10
	public GameObject ProbeInstance; // 0x18
	public MonoBehaviour ProbeEx; // 0x20
	public int ProbeRenderID; // 0x28

	// Methods

	// RVA: 0x12D7470 Offset: 0x12D5A70 VA: 0x1812D7470
	public void InitializePrimary(Vector3 position, GameObject prefab) { }

	// RVA: 0x12D7830 Offset: 0x12D5E30 VA: 0x1812D7830
	public void InitializeSecondary(Vector3 position) { }

	// RVA: 0x12D79D0 Offset: 0x12D5FD0 VA: 0x1812D79D0
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
	// RVA: 0x12E25A0 Offset: 0x12E0BA0 VA: 0x1812E25A0
	public void add_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2AA0 Offset: 0x12E10A0 VA: 0x1812E2AA0
	public void remove_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2460 Offset: 0x12E0A60 VA: 0x1812E2460
	public void add_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2960 Offset: 0x12E0F60 VA: 0x1812E2960
	public void remove_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E23C0 Offset: 0x12E09C0 VA: 0x1812E23C0
	public void add_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E28C0 Offset: 0x12E0EC0 VA: 0x1812E28C0
	public void remove_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2320 Offset: 0x12E0920 VA: 0x1812E2320
	public void add_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2820 Offset: 0x12E0E20 VA: 0x1812E2820
	public void remove_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2500 Offset: 0x12E0B00 VA: 0x1812E2500
	public void add_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2A00 Offset: 0x12E1000 VA: 0x1812E2A00
	public void remove_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2780 Offset: 0x12E0D80 VA: 0x1812E2780
	public void add_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2C80 Offset: 0x12E1280 VA: 0x1812E2C80
	public void remove_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2640 Offset: 0x12E0C40 VA: 0x1812E2640
	public void add_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2B40 Offset: 0x12E1140 VA: 0x1812E2B40
	public void remove_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E26E0 Offset: 0x12E0CE0 VA: 0x1812E26E0
	public void add_OnSunset(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12E2BE0 Offset: 0x12E11E0 VA: 0x1812E2BE0
	public void remove_OnSunset(Action value) { }

	// RVA: 0x12E20A0 Offset: 0x12E06A0 VA: 0x1812E20A0
	public void RefreshTimeCurve() { }

	// RVA: 0x12E1840 Offset: 0x12DFE40 VA: 0x1812E1840
	public float ApplyTimeCurve(float deltaTime) { }

	// RVA: 0x12E14F0 Offset: 0x12DFAF0 VA: 0x1812E14F0
	public void AddHours(float hours, bool adjust = True) { }

	// RVA: 0x12E1820 Offset: 0x12DFE20 VA: 0x1812E1820
	public void AddSeconds(float seconds, bool adjust = True) { }

	// RVA: 0x12E1E40 Offset: 0x12E0440 VA: 0x1812E1E40
	private void CalculateLinearTangents(Keyframe[] keys) { }

	// RVA: 0x12E1960 Offset: 0x12DFF60 VA: 0x1812E1960
	private void ApproximateCurve(AnimationCurve source, out AnimationCurve approxCurve, out AnimationCurve approxInverse) { }

	// RVA: 0x12E1BF0 Offset: 0x12E01F0 VA: 0x1812E1BF0
	protected void Awake() { }

	// RVA: 0x12E2170 Offset: 0x12E0770 VA: 0x1812E2170
	protected void Update() { }

	// RVA: 0x12E22C0 Offset: 0x12E08C0 VA: 0x1812E22C0
	public void .ctor() { }

}

public static class TOD_Util // TypeDefIndex: 8111
{	// Methods

	// RVA: 0x12E2FC0 Offset: 0x12E15C0 VA: 0x1812E2FC0
	public static Color MulRGB(Color color, float multiplier) { }

	// RVA: 0x12E2F50 Offset: 0x12E1550 VA: 0x1812E2F50
	public static Color MulRGBA(Color color, float multiplier) { }

	// RVA: 0x12E3150 Offset: 0x12E1750 VA: 0x1812E3150
	public static Color PowRGB(Color color, float power) { }

	// RVA: 0x12E3030 Offset: 0x12E1630 VA: 0x1812E3030
	public static Color PowRGBA(Color color, float power) { }

	// RVA: 0x12E3300 Offset: 0x12E1900 VA: 0x1812E3300
	public static Color SatRGB(Color color, float saturation) { }

	// RVA: 0x12E3250 Offset: 0x12E1850 VA: 0x1812E3250
	public static Color SatRGBA(Color color, float saturation) { }

	// RVA: 0x12E2E10 Offset: 0x12E1410 VA: 0x1812E2E10
	public static Color AdjustRGB(Color color, float intensity, float saturation) { }

	// RVA: 0x12E2D20 Offset: 0x12E1320 VA: 0x1812E2D20
	public static Color AdjustRGBA(Color color, float intensity, float saturation) { }

	// RVA: 0x12E2EF0 Offset: 0x12E14F0 VA: 0x1812E2EF0
	public static Color ApplyAlpha(Color color) { }

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570E80 Offset: 0x56F480 VA: 0x180570E80
	|-TOD_Util.Swap<object>
	|-TOD_Util.Swap<TOD_Sky.ReflectionProbeState>
	*/

}

public abstract class TOD_Audio : MonoBehaviour // TypeDefIndex: 8112
{	// Fields
	private AudioSource audioComponent; // 0x18

	// Methods

	// RVA: 0x1075B50 Offset: 0x1074150 VA: 0x181075B50
	protected float GetVolume() { }

	// RVA: 0x1075BE0 Offset: 0x10741E0 VA: 0x181075BE0
	protected void SetVolume(float value) { }

	// RVA: 0x1075B00 Offset: 0x1074100 VA: 0x181075B00
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

	// RVA: 0x1075530 Offset: 0x1073B30 VA: 0x181075530
	protected void Start() { }

	// RVA: 0x10755D0 Offset: 0x1073BD0 VA: 0x1810755D0
	protected void Update() { }

	// RVA: 0x57BBC0 Offset: 0x57A1C0 VA: 0x18057BBC0
	public void .ctor() { }

}

public class TOD_AudioAtNight : TOD_Audio // TypeDefIndex: 8114
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxVolume; // 0x28

	// Methods

	// RVA: 0x10756E0 Offset: 0x1073CE0 VA: 0x1810756E0
	protected void Start() { }

	// RVA: 0x1075780 Offset: 0x1073D80 VA: 0x181075780
	protected void Update() { }

	// RVA: 0x57BBC0 Offset: 0x57A1C0 VA: 0x18057BBC0
	public void .ctor() { }

}

public class TOD_AudioAtTime : TOD_Audio // TypeDefIndex: 8115
{	// Fields
	public AnimationCurve Volume; // 0x20

	// Methods

	// RVA: 0x1075890 Offset: 0x1073E90 VA: 0x181075890
	protected void Update() { }

	// RVA: 0x1075930 Offset: 0x1073F30 VA: 0x181075930
	public void .ctor() { }

}

public abstract class TOD_Light : MonoBehaviour // TypeDefIndex: 8116
{	// Fields
	private Light lightComponent; // 0x18

	// Methods

	// RVA: 0x1079180 Offset: 0x1077780 VA: 0x181079180
	protected float GetIntensity() { }

	// RVA: 0x1079210 Offset: 0x1077810 VA: 0x181079210
	protected void SetIntensity(float value) { }

	// RVA: 0x1079130 Offset: 0x1077730 VA: 0x181079130
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

	// RVA: 0x1078B60 Offset: 0x1077160 VA: 0x181078B60
	protected void Start() { }

	// RVA: 0x1078C00 Offset: 0x1077200 VA: 0x181078C00
	protected void Update() { }

	// RVA: 0x57BBC0 Offset: 0x57A1C0 VA: 0x18057BBC0
	public void .ctor() { }

}

public class TOD_LightAtNight : TOD_Light // TypeDefIndex: 8118
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxIntensity; // 0x28

	// Methods

	// RVA: 0x1078D10 Offset: 0x1077310 VA: 0x181078D10
	protected void Start() { }

	// RVA: 0x1078DB0 Offset: 0x10773B0 VA: 0x181078DB0
	protected void Update() { }

	// RVA: 0x57BBC0 Offset: 0x57A1C0 VA: 0x18057BBC0
	public void .ctor() { }

}

public class TOD_LightAtTime : TOD_Light // TypeDefIndex: 8119
{	// Fields
	public AnimationCurve Intensity; // 0x20

	// Methods

	// RVA: 0x1078EC0 Offset: 0x10774C0 VA: 0x181078EC0
	protected void Update() { }

	// RVA: 0x1078F60 Offset: 0x1077560 VA: 0x181078F60
	public void .ctor() { }

}

public class TOD_LoadSkyFromFile : MonoBehaviour // TypeDefIndex: 8120
{	// Fields
	public TOD_Sky sky; // 0x18
	public TextAsset textAsset; // 0x20

	// Methods

	// RVA: 0x10792C0 Offset: 0x10778C0 VA: 0x1810792C0
	protected void Start() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class TOD_Particle : MonoBehaviour // TypeDefIndex: 8121
{	// Fields
	private ParticleSystem particleComponent; // 0x18

	// Methods

	// RVA: 0x1079C70 Offset: 0x1078270 VA: 0x181079C70
	protected float GetEmission() { }

	// RVA: 0x1079D10 Offset: 0x1078310 VA: 0x181079D10
	protected void SetEmission(float value) { }

	// RVA: 0x1079C20 Offset: 0x1078220 VA: 0x181079C20
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

	// RVA: 0x1079650 Offset: 0x1077C50 VA: 0x181079650
	protected void Start() { }

	// RVA: 0x10796F0 Offset: 0x1077CF0 VA: 0x1810796F0
	protected void Update() { }

	// RVA: 0x57BBC0 Offset: 0x57A1C0 VA: 0x18057BBC0
	public void .ctor() { }

}

public class TOD_ParticleAtNight : TOD_Particle // TypeDefIndex: 8123
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxEmission; // 0x28

	// Methods

	// RVA: 0x1079800 Offset: 0x1077E00 VA: 0x181079800
	protected void Start() { }

	// RVA: 0x10798A0 Offset: 0x1077EA0 VA: 0x1810798A0
	protected void Update() { }

	// RVA: 0x57BBC0 Offset: 0x57A1C0 VA: 0x18057BBC0
	public void .ctor() { }

}

public class TOD_ParticleAtTime : TOD_Particle // TypeDefIndex: 8124
{	// Fields
	public AnimationCurve Emission; // 0x20

	// Methods

	// RVA: 0x10799B0 Offset: 0x1077FB0 VA: 0x1810799B0
	protected void Update() { }

	// RVA: 0x1079A50 Offset: 0x1078050 VA: 0x181079A50
	public void .ctor() { }

}

public abstract class TOD_Render : MonoBehaviour // TypeDefIndex: 8125
{	// Fields
	private Renderer rendererComponent; // 0x18

	// Methods

	// RVA: 0x107A650 Offset: 0x1078C50 VA: 0x18107A650
	protected void SetState(bool value) { }

	// RVA: 0x107A600 Offset: 0x1078C00 VA: 0x18107A600
	protected void Awake() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

public class TOD_RenderAtDay : TOD_Render // TypeDefIndex: 8126
{	// Methods

	// RVA: 0x107A440 Offset: 0x1078A40 VA: 0x18107A440
	protected void Start() { }

	// RVA: 0x107A4B0 Offset: 0x1078AB0 VA: 0x18107A4B0
	protected void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class TOD_RenderAtNight : TOD_Render // TypeDefIndex: 8127
{	// Methods

	// RVA: 0x107A520 Offset: 0x1078B20 VA: 0x18107A520
	protected void Start() { }

	// RVA: 0x107A590 Offset: 0x1078B90 VA: 0x18107A590
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

	// RVA: 0x12E3390 Offset: 0x12E1990 VA: 0x1812E3390
	private float GetRainEmission() { }

	// RVA: 0x12E3430 Offset: 0x12E1A30 VA: 0x1812E3430
	private void SetRainEmission(float value) { }

	// RVA: 0x12E34D0 Offset: 0x12E1AD0 VA: 0x1812E34D0
	protected void Start() { }

	// RVA: 0x12E35A0 Offset: 0x12E1BA0 VA: 0x1812E35A0
	protected void Update() { }

	// RVA: 0x4C7EC0 Offset: 0x4C64C0 VA: 0x1804C7EC0
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

