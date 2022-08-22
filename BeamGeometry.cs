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
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public MeshRenderer get_meshRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	private void set_meshRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public MeshFilter get_meshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	private void set_meshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E84B0 Offset: 0x4E6AB0 VA: 0x1804E84B0
	public Material get_material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	private void set_material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public Mesh get_coneMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	private void set_coneMesh(Mesh value) { }

	// RVA: 0x111DB70 Offset: 0x111C170 VA: 0x18111DB70
	public bool get_visible() { }

	// RVA: 0x111DBD0 Offset: 0x111C1D0 VA: 0x18111DBD0
	public void set_visible(bool value) { }

	// RVA: 0x111DB30 Offset: 0x111C130 VA: 0x18111DB30
	public int get_sortingLayerID() { }

	// RVA: 0x111DB90 Offset: 0x111C190 VA: 0x18111DB90
	public void set_sortingLayerID(int value) { }

	// RVA: 0x111DB50 Offset: 0x111C150 VA: 0x18111DB50
	public int get_sortingOrder() { }

	// RVA: 0x111DBB0 Offset: 0x111C1B0 VA: 0x18111DBB0
	public void set_sortingOrder(int value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x111C600 Offset: 0x111AC00 VA: 0x18111C600
	private void OnDestroy() { }

	// RVA: 0x111C500 Offset: 0x111AB00 VA: 0x18111C500
	private static bool IsUsingCustomRenderPipeline() { }

	// RVA: 0x111C740 Offset: 0x111AD40 VA: 0x18111C740
	private void OnEnable() { }

	// RVA: 0x111C6B0 Offset: 0x111ACB0 VA: 0x18111C6B0
	private void OnDisable() { }

	// RVA: 0x111C140 Offset: 0x111A740 VA: 0x18111C140
	public void Initialize(VolumetricLightBeam master, Shader shader) { }

	// RVA: 0x111C860 Offset: 0x111AE60 VA: 0x18111C860
	public void RegenerateMesh() { }

	// RVA: 0x111C030 Offset: 0x111A630 VA: 0x18111C030
	private void ComputeLocalMatrix() { }

	// RVA: 0x111D000 Offset: 0x111B600 VA: 0x18111D000
	public void UpdateMaterialAndBounds() { }

	// RVA: 0x111CB50 Offset: 0x111B150 VA: 0x18111CB50
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x111CB00 Offset: 0x111B100 VA: 0x18111CB00
	public void SetClippingPlaneOff() { }

	// RVA: 0x111C5F0 Offset: 0x111ABF0 VA: 0x18111C5F0
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam) { }

	// RVA: 0x111C7D0 Offset: 0x111ADD0 VA: 0x18111C7D0
	private void OnWillRenderObject() { }

	// RVA: 0x111CC40 Offset: 0x111B240 VA: 0x18111CC40
	private void UpdateCameraRelatedProperties(Camera cam) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

