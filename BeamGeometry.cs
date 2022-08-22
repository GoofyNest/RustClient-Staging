public class BeamGeometry : MonoBehaviour // TypeDefIndex: 11537
{	// Fields
	private VolumetricLightBeam m_Master; // 0x18
	private Matrix4x4 m_ColorGradientMatrix; // 0x20
	private MeshType m_CurrentMeshType; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshRenderer <meshRenderer>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <meshFilter>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <material>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Mesh <coneMesh>k__BackingField; // 0x80

	// Properties
	public MeshRenderer meshRenderer { get; set; }
	public MeshFilter meshFilter { get; set; }
	public Material material { get; set; }
	public Mesh coneMesh { get; set; }
	public bool visible { get; set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public MeshRenderer get_meshRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	private void set_meshRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public MeshFilter get_meshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	private void set_meshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8520 Offset: 0x4E6B20 VA: 0x1804E8520
	public Material get_material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	private void set_material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public Mesh get_coneMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	private void set_coneMesh(Mesh value) { }

	// RVA: 0x111D100 Offset: 0x111B700 VA: 0x18111D100
	public bool get_visible() { }

	// RVA: 0x111D160 Offset: 0x111B760 VA: 0x18111D160
	public void set_visible(bool value) { }

	// RVA: 0x111D0C0 Offset: 0x111B6C0 VA: 0x18111D0C0
	public int get_sortingLayerID() { }

	// RVA: 0x111D120 Offset: 0x111B720 VA: 0x18111D120
	public void set_sortingLayerID(int value) { }

	// RVA: 0x111D0E0 Offset: 0x111B6E0 VA: 0x18111D0E0
	public int get_sortingOrder() { }

	// RVA: 0x111D140 Offset: 0x111B740 VA: 0x18111D140
	public void set_sortingOrder(int value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x111BB90 Offset: 0x111A190 VA: 0x18111BB90
	private void OnDestroy() { }

	// RVA: 0x111BA90 Offset: 0x111A090 VA: 0x18111BA90
	private static bool IsUsingCustomRenderPipeline() { }

	// RVA: 0x111BCD0 Offset: 0x111A2D0 VA: 0x18111BCD0
	private void OnEnable() { }

	// RVA: 0x111BC40 Offset: 0x111A240 VA: 0x18111BC40
	private void OnDisable() { }

	// RVA: 0x111B6D0 Offset: 0x1119CD0 VA: 0x18111B6D0
	public void Initialize(VolumetricLightBeam master, Shader shader) { }

	// RVA: 0x111BDF0 Offset: 0x111A3F0 VA: 0x18111BDF0
	public void RegenerateMesh() { }

	// RVA: 0x111B5C0 Offset: 0x1119BC0 VA: 0x18111B5C0
	private void ComputeLocalMatrix() { }

	// RVA: 0x111C590 Offset: 0x111AB90 VA: 0x18111C590
	public void UpdateMaterialAndBounds() { }

	// RVA: 0x111C0E0 Offset: 0x111A6E0 VA: 0x18111C0E0
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x111C090 Offset: 0x111A690 VA: 0x18111C090
	public void SetClippingPlaneOff() { }

	// RVA: 0x111BB80 Offset: 0x111A180 VA: 0x18111BB80
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam) { }

	// RVA: 0x111BD60 Offset: 0x111A360 VA: 0x18111BD60
	private void OnWillRenderObject() { }

	// RVA: 0x111C1D0 Offset: 0x111A7D0 VA: 0x18111C1D0
	private void UpdateCameraRelatedProperties(Camera cam) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

