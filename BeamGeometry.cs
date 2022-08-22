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

	// RVA: 0x111CE40 Offset: 0x111B440 VA: 0x18111CE40
	public bool get_visible() { }

	// RVA: 0x111CEA0 Offset: 0x111B4A0 VA: 0x18111CEA0
	public void set_visible(bool value) { }

	// RVA: 0x111CE00 Offset: 0x111B400 VA: 0x18111CE00
	public int get_sortingLayerID() { }

	// RVA: 0x111CE60 Offset: 0x111B460 VA: 0x18111CE60
	public void set_sortingLayerID(int value) { }

	// RVA: 0x111CE20 Offset: 0x111B420 VA: 0x18111CE20
	public int get_sortingOrder() { }

	// RVA: 0x111CE80 Offset: 0x111B480 VA: 0x18111CE80
	public void set_sortingOrder(int value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x111B8D0 Offset: 0x1119ED0 VA: 0x18111B8D0
	private void OnDestroy() { }

	// RVA: 0x111B7D0 Offset: 0x1119DD0 VA: 0x18111B7D0
	private static bool IsUsingCustomRenderPipeline() { }

	// RVA: 0x111BA10 Offset: 0x111A010 VA: 0x18111BA10
	private void OnEnable() { }

	// RVA: 0x111B980 Offset: 0x1119F80 VA: 0x18111B980
	private void OnDisable() { }

	// RVA: 0x111B410 Offset: 0x1119A10 VA: 0x18111B410
	public void Initialize(VolumetricLightBeam master, Shader shader) { }

	// RVA: 0x111BB30 Offset: 0x111A130 VA: 0x18111BB30
	public void RegenerateMesh() { }

	// RVA: 0x111B300 Offset: 0x1119900 VA: 0x18111B300
	private void ComputeLocalMatrix() { }

	// RVA: 0x111C2D0 Offset: 0x111A8D0 VA: 0x18111C2D0
	public void UpdateMaterialAndBounds() { }

	// RVA: 0x111BE20 Offset: 0x111A420 VA: 0x18111BE20
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x111BDD0 Offset: 0x111A3D0 VA: 0x18111BDD0
	public void SetClippingPlaneOff() { }

	// RVA: 0x111B8C0 Offset: 0x1119EC0 VA: 0x18111B8C0
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam) { }

	// RVA: 0x111BAA0 Offset: 0x111A0A0 VA: 0x18111BAA0
	private void OnWillRenderObject() { }

	// RVA: 0x111BF10 Offset: 0x111A510 VA: 0x18111BF10
	private void UpdateCameraRelatedProperties(Camera cam) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

