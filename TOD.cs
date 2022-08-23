public class TOD_Animation : MonoBehaviour // TypeDefIndex: 8068
{	[TooltipAttribute] // RVA: 0xE6770 Offset: 0xE5B70 VA: 0x1800E6770
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

	public Vector3 CloudUV { get; set; }
	public Vector3 OffsetUV { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_CloudUV() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_CloudUV(Vector3 value) { }

	public Vector3 get_OffsetUV() { }

	protected void Start() { }

	public void Update() { }

	public void .ctor() { }

}

public class TOD_MinAttribute : PropertyAttribute // TypeDefIndex: 8069
{	public float min; // 0x10


	public void .ctor(float min) { }

}

public class TOD_MaxAttribute : PropertyAttribute // TypeDefIndex: 8070
{	public float max; // 0x10


	public void .ctor(float max) { }

}

public class TOD_RangeAttribute : PropertyAttribute // TypeDefIndex: 8071
{	public float min; // 0x10
	public float max; // 0x14


	public void .ctor(float min, float max) { }

}

public class TOD_Billboard : MonoBehaviour // TypeDefIndex: 8072
{	public float Altitude; // 0x18
	public float Azimuth; // 0x1C
	public float Distance; // 0x20
	public float Size; // 0x24


	private T GetComponentInParents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0BD0 Offset: 0xBDF1D0 VA: 0x180BE0BD0
	|-TOD_Billboard.GetComponentInParents<object>
	*/

	public void .ctor() { }

}

public class TOD_Camera : MonoBehaviour // TypeDefIndex: 8073
{	public TOD_Sky sky; // 0x18
	public bool DomePosToCamera; // 0x20
	public Vector3 DomePosOffset; // 0x24
	public bool DomeScaleToFarClip; // 0x30
	public float DomeScaleFactor; // 0x34
	private Camera cameraComponent; // 0x38
	private Transform cameraTransform; // 0x40

	public bool HDR { get; }
	public float NearClipPlane { get; }
	public float FarClipPlane { get; }
	public Color BackgroundColor { get; }


	public bool get_HDR() { }

	public float get_NearClipPlane() { }

	public float get_FarClipPlane() { }

	public Color get_BackgroundColor() { }

	protected void OnValidate() { }

	protected void OnEnable() { }

	protected void Update() { }

	protected void OnPreCull() { }

	private TOD_Sky FindSky(bool fallback = False) { }

	public void DoDomeScaleToFarClip() { }

	public void DoDomePosToCamera() { }

	public void .ctor() { }

}

public class TOD_Components : MonoBehaviour // TypeDefIndex: 8074
{	public GameObject Space; // 0x18
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_DomeTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_DomeTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_SpaceTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SpaceTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_StarTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_StarTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_SunTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SunTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_MoonTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_MoonTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_AtmosphereTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_AtmosphereTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_ClearTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ClearTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_CloudTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_CloudTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_BillboardTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_BillboardTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform get_LightTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_LightTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_SpaceRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SpaceRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_StarRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_StarRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_SunRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SunRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_MoonRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_MoonRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_AtmosphereRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_AtmosphereRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_ClearRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ClearRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_CloudRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_CloudRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer[] get_BillboardRenderers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_BillboardRenderers(Renderer[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter get_SpaceMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SpaceMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter get_StarMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_StarMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter get_SunMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SunMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter get_MoonMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_MoonMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter get_AtmosphereMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_AtmosphereMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter get_ClearMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ClearMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter get_CloudMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_CloudMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public MeshFilter[] get_BillboardMeshFilters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_BillboardMeshFilters(MeshFilter[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_SpaceMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SpaceMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_StarMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_StarMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_SunMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SunMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_MoonMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_MoonMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_AtmosphereMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_AtmosphereMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_ClearMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ClearMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_CloudMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_CloudMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material[] get_BillboardMaterials() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_BillboardMaterials(Material[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Light get_LightSource() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_LightSource(Light value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Sky get_Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Sky(TOD_Sky value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Animation get_Animation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Animation(TOD_Animation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Time get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Time(TOD_Time value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Camera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Camera(TOD_Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Rays get_Rays() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Rays(TOD_Rays value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Scattering get_Scattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Scattering(TOD_Scattering value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Shadows get_Shadows() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_Shadows(TOD_Shadows value) { }

	public void Initialize() { }

	public void .ctor() { }

}

public enum TOD_MoonPositionType // TypeDefIndex: 8075
{	public int value__; // 0x0
	public const TOD_MoonPositionType OppositeToSun = 0;
	public const TOD_MoonPositionType Realistic = 1;

}

public enum TOD_StarsPositionType // TypeDefIndex: 8076
{	public int value__; // 0x0
	public const TOD_StarsPositionType Static = 0;
	public const TOD_StarsPositionType Rotating = 1;

}

public enum TOD_FogType // TypeDefIndex: 8077
{	public int value__; // 0x0
	public const TOD_FogType None = 0;
	public const TOD_FogType Atmosphere = 1;
	public const TOD_FogType Directional = 2;
	public const TOD_FogType Gradient = 3;

}

public enum TOD_AmbientType // TypeDefIndex: 8078
{	public int value__; // 0x0
	public const TOD_AmbientType None = 0;
	public const TOD_AmbientType Color = 1;
	public const TOD_AmbientType Gradient = 2;
	public const TOD_AmbientType Spherical = 3;

}

public enum TOD_ReflectionType // TypeDefIndex: 8079
{	public int value__; // 0x0
	public const TOD_ReflectionType None = 0;
	public const TOD_ReflectionType Cubemap = 1;

}

public enum TOD_ColorSpaceType // TypeDefIndex: 8080
{	public int value__; // 0x0
	public const TOD_ColorSpaceType Auto = 0;
	public const TOD_ColorSpaceType Linear = 1;
	public const TOD_ColorSpaceType Gamma = 2;

}

public enum TOD_ColorRangeType // TypeDefIndex: 8081
{	public int value__; // 0x0
	public const TOD_ColorRangeType Auto = 0;
	public const TOD_ColorRangeType HDR = 1;
	public const TOD_ColorRangeType LDR = 2;

}

public enum TOD_ColorOutputType // TypeDefIndex: 8082
{	public int value__; // 0x0
	public const TOD_ColorOutputType Raw = 0;
	public const TOD_ColorOutputType Dithered = 1;

}

public enum TOD_CloudQualityType // TypeDefIndex: 8083
{	public int value__; // 0x0
	public const TOD_CloudQualityType Low = 0;
	public const TOD_CloudQualityType Medium = 1;
	public const TOD_CloudQualityType High = 2;

}

public enum TOD_MeshQualityType // TypeDefIndex: 8084
{	public int value__; // 0x0
	public const TOD_MeshQualityType Low = 0;
	public const TOD_MeshQualityType Medium = 1;
	public const TOD_MeshQualityType High = 2;

}

public enum TOD_StarQualityType // TypeDefIndex: 8085
{	public int value__; // 0x0
	public const TOD_StarQualityType Low = 0;
	public const TOD_StarQualityType Medium = 1;
	public const TOD_StarQualityType High = 2;

}

public enum TOD_SkyQualityType // TypeDefIndex: 8086
{	public int value__; // 0x0
	public const TOD_SkyQualityType PerVertex = 0;
	public const TOD_SkyQualityType PerPixel = 1;

}

public abstract class TOD_ImageEffect : MonoBehaviour // TypeDefIndex: 8087
{	public TOD_Sky sky; // 0x18
	protected Camera cam; // 0x20
	private bool supportsDepth; // 0x28
	private bool supportsHdr; // 0x29
	private static Vector3[] frustumCornersArray; // 0x0


	protected Material CreateMaterial(Shader shader) { }

	private TOD_Sky FindSky(bool fallback = False) { }

	protected void Awake() { }

	protected bool CheckSupport(bool needDepth = False, bool needHdr = False) { }

	protected void DrawBorder(RenderTexture dest, Material material) { }

	protected Matrix4x4 FrustumCorners() { }

	protected RenderTexture GetSkyMask(RenderTexture source, Material skyMaskMaterial, Material screenClearMaterial, TOD_ImageEffect.ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public enum TOD_ImageEffect.ResolutionType // TypeDefIndex: 8088
{	public int value__; // 0x0
	public const TOD_ImageEffect.ResolutionType Low = 0;
	public const TOD_ImageEffect.ResolutionType Normal = 1;
	public const TOD_ImageEffect.ResolutionType High = 2;

}

public class TOD_Parameters // TypeDefIndex: 8089
{	public TOD_CycleParameters Cycle; // 0x10
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


	public void .ctor() { }

	public void .ctor(TOD_Sky sky) { }

	public void ToSky(TOD_Sky sky) { }

}

public class TOD_CycleParameters // TypeDefIndex: 8090
{	[TooltipAttribute] // RVA: 0xF0100 Offset: 0xEF500 VA: 0x1800F0100
	public float Hour; // 0x10
	[TooltipAttribute] // RVA: 0xF01A0 Offset: 0xEF5A0 VA: 0x1800F01A0
	public int Day; // 0x14
	[TooltipAttribute] // RVA: 0xF0240 Offset: 0xEF640 VA: 0x1800F0240
	public int Month; // 0x18
	[TooltipAttribute] // RVA: 0xF0390 Offset: 0xEF790 VA: 0x1800F0390
	[TOD_RangeAttribute] // RVA: 0xF0390 Offset: 0xEF790 VA: 0x1800F0390
	public int Year; // 0x1C

	public DateTime DateTime { get; set; }
	public long Ticks { get; set; }


	public DateTime get_DateTime() { }

	public void set_DateTime(DateTime value) { }

	public long get_Ticks() { }

	public void set_Ticks(long value) { }

	public void .ctor() { }

}

public class TOD_WorldParameters // TypeDefIndex: 8091
{	[TooltipAttribute] // RVA: 0xF0460 Offset: 0xEF860 VA: 0x1800F0460
	[RangeAttribute] // RVA: 0xF0460 Offset: 0xEF860 VA: 0x1800F0460
	public float Latitude; // 0x10
	[TooltipAttribute] // RVA: 0xF0580 Offset: 0xEF980 VA: 0x1800F0580
	[RangeAttribute] // RVA: 0xF0580 Offset: 0xEF980 VA: 0x1800F0580
	public float Longitude; // 0x14
	[TooltipAttribute] // RVA: 0xF0770 Offset: 0xEFB70 VA: 0x1800F0770
	[RangeAttribute] // RVA: 0xF0770 Offset: 0xEFB70 VA: 0x1800F0770
	public float UTC; // 0x18


	public void .ctor() { }

}

public class TOD_AtmosphereParameters // TypeDefIndex: 8092
{	[TooltipAttribute] // RVA: 0xF0960 Offset: 0xEFD60 VA: 0x1800F0960
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


	public void .ctor() { }

}

public class TOD_DayParameters // TypeDefIndex: 8093
{	[TooltipAttribute] // RVA: 0x6FD90 Offset: 0x6F190 VA: 0x18006FD90
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


	public void .ctor() { }

}

public class TOD_NightParameters // TypeDefIndex: 8094
{	[TooltipAttribute] // RVA: 0x70BE0 Offset: 0x6FFE0 VA: 0x180070BE0
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


	public void .ctor() { }

}

public class TOD_SunParameters // TypeDefIndex: 8095
{	[TooltipAttribute] // RVA: 0x71A90 Offset: 0x70E90 VA: 0x180071A90
	[TOD_MinAttribute] // RVA: 0x71A90 Offset: 0x70E90 VA: 0x180071A90
	public float MeshSize; // 0x10
	[TooltipAttribute] // RVA: 0x71C20 Offset: 0x71020 VA: 0x180071C20
	[TOD_MinAttribute] // RVA: 0x71C20 Offset: 0x71020 VA: 0x180071C20
	public float MeshBrightness; // 0x14
	[TooltipAttribute] // RVA: 0x71DC0 Offset: 0x711C0 VA: 0x180071DC0
	[TOD_MinAttribute] // RVA: 0x71DC0 Offset: 0x711C0 VA: 0x180071DC0
	public float MeshContrast; // 0x18


	public void .ctor() { }

}

public class TOD_MoonParameters // TypeDefIndex: 8096
{	[TooltipAttribute] // RVA: 0x71FD0 Offset: 0x713D0 VA: 0x180071FD0
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


	public void .ctor() { }

}

public class TOD_StarParameters // TypeDefIndex: 8097
{	[TooltipAttribute] // RVA: 0x73E10 Offset: 0x73210 VA: 0x180073E10
	[TOD_MinAttribute] // RVA: 0x73E10 Offset: 0x73210 VA: 0x180073E10
	public float Size; // 0x10
	[TooltipAttribute] // RVA: 0x73FA0 Offset: 0x733A0 VA: 0x180073FA0
	[TOD_MinAttribute] // RVA: 0x73FA0 Offset: 0x733A0 VA: 0x180073FA0
	public float Brightness; // 0x14
	[TooltipAttribute] // RVA: 0x754D0 Offset: 0x748D0 VA: 0x1800754D0
	public TOD_StarsPositionType Position; // 0x18


	public void .ctor() { }

}

public class TOD_CloudParameters // TypeDefIndex: 8098
{	[TooltipAttribute] // RVA: 0x75610 Offset: 0x74A10 VA: 0x180075610
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


	public void .ctor() { }

}

public class TOD_LightParameters // TypeDefIndex: 8099
{	[TooltipAttribute] // RVA: 0x764C0 Offset: 0x758C0 VA: 0x1800764C0
	[TOD_MinAttribute] // RVA: 0x764C0 Offset: 0x758C0 VA: 0x1800764C0
	public float UpdateInterval; // 0x10
	[TooltipAttribute] // RVA: 0x76670 Offset: 0x75A70 VA: 0x180076670
	[TOD_RangeAttribute] // RVA: 0x76670 Offset: 0x75A70 VA: 0x180076670
	public float MinimumHeight; // 0x14


	public void .ctor() { }

}

public class TOD_FogParameters // TypeDefIndex: 8100
{	[TooltipAttribute] // RVA: 0x76810 Offset: 0x75C10 VA: 0x180076810
	public TOD_FogType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x76960 Offset: 0x75D60 VA: 0x180076960
	[TOD_RangeAttribute] // RVA: 0x76960 Offset: 0x75D60 VA: 0x180076960
	public float HeightBias; // 0x14


	public void .ctor() { }

}

public class TOD_AmbientParameters // TypeDefIndex: 8101
{	[TooltipAttribute] // RVA: 0x76B50 Offset: 0x75F50 VA: 0x180076B50
	public TOD_AmbientType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x76C80 Offset: 0x76080 VA: 0x180076C80
	[TOD_MinAttribute] // RVA: 0x76C80 Offset: 0x76080 VA: 0x180076C80
	public float Saturation; // 0x14
	[TooltipAttribute] // RVA: 0x76EA0 Offset: 0x762A0 VA: 0x180076EA0
	[TOD_MinAttribute] // RVA: 0x76EA0 Offset: 0x762A0 VA: 0x180076EA0
	public float UpdateInterval; // 0x18


	public void .ctor() { }

}

public class TOD_ReflectionParameters // TypeDefIndex: 8102
{	[TooltipAttribute] // RVA: 0x77020 Offset: 0x76420 VA: 0x180077020
	public TOD_ReflectionType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x77180 Offset: 0x76580 VA: 0x180077180
	public ReflectionProbeClearFlags ClearFlags; // 0x14
	[TooltipAttribute] // RVA: 0x77260 Offset: 0x76660 VA: 0x180077260
	public LayerMask CullingMask; // 0x18
	[TooltipAttribute] // RVA: 0x773F0 Offset: 0x767F0 VA: 0x1800773F0
	public GameObject ProbePrefab; // 0x20


	public void .ctor() { }

}

public class TOD_Rays : TOD_ImageEffect // TypeDefIndex: 8103
{	public Shader GodRayShader; // 0x30
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


	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum TOD_Rays.BlendModeType // TypeDefIndex: 8104
{	public int value__; // 0x0
	public const TOD_Rays.BlendModeType Screen = 0;
	public const TOD_Rays.BlendModeType Add = 1;

}

public class TOD_Resources : MonoBehaviour // TypeDefIndex: 8105
{	public Material Skybox; // 0x18
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_SunLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_SunSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_SunMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_SunCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_FogColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_GroundColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_AmbientColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_SunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_LightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_LocalSunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_LocalMoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_LocalLightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_Contrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_Contrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_Brightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_Brightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_Fogginess() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_Fogginess(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_Directionality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_Directionality(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonHaloPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonHaloPower(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonHaloColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudOpacity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudOpacity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudCoverage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudCoverage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudSharpness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudSharpness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudDensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudDensity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudColoring() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudColoring(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudAttenuation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudAttenuation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudSaturation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudSaturation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudScattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudScattering(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudOffset(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_CloudWind() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_CloudWind(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_StarSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_StarSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_StarBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_StarBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_StarVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_StarVisibility(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_SunMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_SunMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_SunMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_SunMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_MoonMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_MoonMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_kBetaMie() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_kBetaMie(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_kSun() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_kSun(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_k4PI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_k4PI(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_kRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_kRadius(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_kScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_kScale(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_World2Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_World2Sky(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_ID_Sky2World() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_ID_Sky2World(int value) { }

	public void Initialize() { }

	public void .ctor() { }

}

public class TOD_Scattering : TOD_ImageEffect // TypeDefIndex: 8106
{	public Shader ScatteringShader; // 0x30
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


	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void OnPreCull() { }

	protected void OnPostRender() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class TOD_Shadows : TOD_ImageEffect // TypeDefIndex: 8107
{	public Shader ShadowShader; // 0x30
	public Texture2D CloudTexture; // 0x38
	[HeaderAttribute] // RVA: 0x861D0 Offset: 0x855D0 VA: 0x1800861D0
	[RangeAttribute] // RVA: 0x861D0 Offset: 0x855D0 VA: 0x1800861D0
	public float Cutoff; // 0x40
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Fade; // 0x44
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Intensity; // 0x48
	private Material shadowMaterial; // 0x50


	protected void OnEnable() { }

	protected void OnDisable() { }

	[ImageEffectOpaque] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class TOD_Sky : MonoBehaviour // TypeDefIndex: 8108
{	private static List<TOD_Sky> instances; // 0x0
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


	public static List<TOD_Sky> get_Instances() { }

	public static TOD_Sky get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Initialized(bool value) { }

	public bool get_Headless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Components get_Components() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Components(TOD_Components value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TOD_Resources get_Resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Resources(TOD_Resources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_IsDay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_IsDay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_IsNight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_IsNight(bool value) { }

	public float get_Radius() { }

	public float get_Diameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_LerpValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LerpValue(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_SunZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_SunAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_SunAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_MoonZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_MoonAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_MoonAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_SunsetTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunsetTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_SunriseTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunriseTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_LocalSiderealTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LocalSiderealTime(float value) { }

	public float get_LightZenith() { }

	public float get_LightIntensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_SunVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_MoonVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LocalSunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LocalMoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_LocalLightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunLightColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonLightColor(Color value) { }

	public Color get_LightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_SunRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_SunRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_MoonRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_MoonRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_SunCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_FogColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_GroundColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_AmbientColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Color get_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_MoonHaloColor(Color value) { }

	public ReflectionProbe get_Probe() { }

	public GameObject get_ProbeInstance() { }

	public MonoBehaviour get_ProbeEx() { }

	public Vector3 OrbitalToUnity(float radius, float theta, float phi) { }

	public Vector3 OrbitalToLocal(float theta, float phi) { }

	public Color SampleAtmosphere(Vector3 direction, bool directLight = True) { }

	public SphericalHarmonicsL2 RenderToSphericalHarmonics() { }

	public SphericalHarmonicsL2 RenderToSphericalHarmonics(float intensity, float saturation) { }

	public void RenderToCubemap(RenderTexture targetTexture) { }

	public void RenderToProbe() { }

	public bool ReflectionIsUpdating() { }

	private void UpdateProbeBlending(float lerp) { }

	private void UpdateProbeProperties(ReflectionProbe probe) { }

	public Color SampleFogColor(bool directLight = True) { }

	public Color SampleSkyColor() { }

	public Color SampleEquatorColor() { }

	public void UpdateFog() { }

	public void UpdateAmbient() { }

	public void UpdateReflection() { }

	public void DelayReflectionUpdate() { }

	public void LoadParameters(string xml) { }

	public string SaveParameters() { }

	private void UpdateQualitySettings() { }

	private void UpdateRenderSettings() { }

	private void UpdateShaderKeywords() { }

	private void UpdateShaderProperties() { }

	private float ShaderScale(float inCos) { }

	private float ShaderMiePhase(float eyeCos, float eyeCos2) { }

	private float ShaderRayleighPhase(float eyeCos2) { }

	private Color ShaderNightSkyColor(Vector3 dir) { }

	private Color ShaderMoonHaloColor(Vector3 dir) { }

	private Color TOD_HDR2LDR(Color color) { }

	private Color TOD_GAMMA2LINEAR(Color color) { }

	private Color TOD_LINEAR2GAMMA(Color color) { }

	private Color ShaderScatteringColor(Vector3 dir, bool directLight = True) { }

	private void Initialize() { }

	private void Cleanup() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void LateUpdate() { }

	protected void OnValidate() { }

	private void UpdateScattering() { }

	private void UpdateCelestials() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TOD_Sky.ReflectionProbeState // TypeDefIndex: 8109
{	public ReflectionProbe Probe; // 0x10
	public GameObject ProbeInstance; // 0x18
	public MonoBehaviour ProbeEx; // 0x20
	public int ProbeRenderID; // 0x28


	public void InitializePrimary(Vector3 position, GameObject prefab) { }

	public void InitializeSecondary(Vector3 position) { }

	public void .ctor() { }

}

public class TOD_Time : MonoBehaviour // TypeDefIndex: 8110
{	[TooltipAttribute] // RVA: 0x904C0 Offset: 0x8F8C0 VA: 0x1800904C0
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


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void add_OnSunset(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void remove_OnSunset(Action value) { }

	public void RefreshTimeCurve() { }

	public float ApplyTimeCurve(float deltaTime) { }

	public void AddHours(float hours, bool adjust = True) { }

	public void AddSeconds(float seconds, bool adjust = True) { }

	private void CalculateLinearTangents(Keyframe[] keys) { }

	private void ApproximateCurve(AnimationCurve source, out AnimationCurve approxCurve, out AnimationCurve approxInverse) { }

	protected void Awake() { }

	protected void Update() { }

	public void .ctor() { }

}

public static class TOD_Util // TypeDefIndex: 8111
{
	public static Color MulRGB(Color color, float multiplier) { }

	public static Color MulRGBA(Color color, float multiplier) { }

	public static Color PowRGB(Color color, float power) { }

	public static Color PowRGBA(Color color, float power) { }

	public static Color SatRGB(Color color, float saturation) { }

	public static Color SatRGBA(Color color, float saturation) { }

	public static Color AdjustRGB(Color color, float intensity, float saturation) { }

	public static Color AdjustRGBA(Color color, float intensity, float saturation) { }

	public static Color ApplyAlpha(Color color) { }

	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570F50 Offset: 0x56F550 VA: 0x180570F50
	|-TOD_Util.Swap<object>
	|-TOD_Util.Swap<TOD_Sky.ReflectionProbeState>
	*/

}

public abstract class TOD_Audio : MonoBehaviour // TypeDefIndex: 8112
{	private AudioSource audioComponent; // 0x18


	protected float GetVolume() { }

	protected void SetVolume(float value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_AudioAtDay : TOD_Audio // TypeDefIndex: 8113
{	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxVolume; // 0x28


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_AudioAtNight : TOD_Audio // TypeDefIndex: 8114
{	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxVolume; // 0x28


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_AudioAtTime : TOD_Audio // TypeDefIndex: 8115
{	public AnimationCurve Volume; // 0x20


	protected void Update() { }

	public void .ctor() { }

}

public abstract class TOD_Light : MonoBehaviour // TypeDefIndex: 8116
{	private Light lightComponent; // 0x18


	protected float GetIntensity() { }

	protected void SetIntensity(float value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_LightAtDay : TOD_Light // TypeDefIndex: 8117
{	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxIntensity; // 0x28


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_LightAtNight : TOD_Light // TypeDefIndex: 8118
{	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxIntensity; // 0x28


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_LightAtTime : TOD_Light // TypeDefIndex: 8119
{	public AnimationCurve Intensity; // 0x20


	protected void Update() { }

	public void .ctor() { }

}

public class TOD_LoadSkyFromFile : MonoBehaviour // TypeDefIndex: 8120
{	public TOD_Sky sky; // 0x18
	public TextAsset textAsset; // 0x20


	protected void Start() { }

	public void .ctor() { }

}

public abstract class TOD_Particle : MonoBehaviour // TypeDefIndex: 8121
{	private ParticleSystem particleComponent; // 0x18


	protected float GetEmission() { }

	protected void SetEmission(float value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_ParticleAtDay : TOD_Particle // TypeDefIndex: 8122
{	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxEmission; // 0x28


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_ParticleAtNight : TOD_Particle // TypeDefIndex: 8123
{	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxEmission; // 0x28


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_ParticleAtTime : TOD_Particle // TypeDefIndex: 8124
{	public AnimationCurve Emission; // 0x20


	protected void Update() { }

	public void .ctor() { }

}

public abstract class TOD_Render : MonoBehaviour // TypeDefIndex: 8125
{	private Renderer rendererComponent; // 0x18


	protected void SetState(bool value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_RenderAtDay : TOD_Render // TypeDefIndex: 8126
{
	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_RenderAtNight : TOD_Render // TypeDefIndex: 8127
{
	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_WeatherManager : MonoBehaviour // TypeDefIndex: 8128
{	public ParticleSystem RainParticleSystem; // 0x18
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


	private float GetRainEmission() { }

	private void SetRainEmission(float value) { }

	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public enum TOD_WeatherManager.RainType // TypeDefIndex: 8129
{	public int value__; // 0x0
	public const TOD_WeatherManager.RainType None = 0;
	public const TOD_WeatherManager.RainType Light = 1;
	public const TOD_WeatherManager.RainType Heavy = 2;

}

public enum TOD_WeatherManager.CloudType // TypeDefIndex: 8130
{	public int value__; // 0x0
	public const TOD_WeatherManager.CloudType None = 0;
	public const TOD_WeatherManager.CloudType Few = 1;
	public const TOD_WeatherManager.CloudType Scattered = 2;
	public const TOD_WeatherManager.CloudType Broken = 3;
	public const TOD_WeatherManager.CloudType Overcast = 4;

}

public enum TOD_WeatherManager.AtmosphereType // TypeDefIndex: 8131
{	public int value__; // 0x0
	public const TOD_WeatherManager.AtmosphereType Clear = 0;
	public const TOD_WeatherManager.AtmosphereType Storm = 1;
	public const TOD_WeatherManager.AtmosphereType Dust = 2;
	public const TOD_WeatherManager.AtmosphereType Fog = 3;

}

