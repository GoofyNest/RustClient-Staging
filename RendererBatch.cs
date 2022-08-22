public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9916
{
// Namespace: 
public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9916
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform <BatchTransform>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshRenderer <BatchRenderer>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshFilter <BatchFilter>k__BackingField; // 0x28
	private bool disabled; // 0x30
	private RendererGroup batchGroup; // 0x38
	private MeshRendererInstance batchInstance; // 0x40

	// Properties
	public Transform BatchTransform { get; set; }
	public MeshRenderer BatchRenderer { get; set; }
	public MeshFilter BatchFilter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Transform get_BatchTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_BatchTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public MeshRenderer get_BatchRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_BatchRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public MeshFilter get_BatchFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_BatchFilter(MeshFilter value) { }

	// RVA: 0x94DE80 Offset: 0x94C480 VA: 0x18094DE80
	protected void OnEnable() { }

	// RVA: 0x94DE10 Offset: 0x94C410 VA: 0x18094DE10
	protected void OnDisable() { }

	// RVA: 0x94D850 Offset: 0x94BE50 VA: 0x18094D850
	public void Add() { }

	// RVA: 0x94DF50 Offset: 0x94C550 VA: 0x18094DF50
	public void Remove() { }

	// RVA: 0x94DF30 Offset: 0x94C530 VA: 0x18094DF30
	public void Refresh() { }

	// RVA: 0x94D6E0 Offset: 0x94BCE0 VA: 0x18094D6E0
	public void AddBatch(RendererGroup batchGroup) { }

	// RVA: 0x94E0A0 Offset: 0x94C6A0 VA: 0x18094E0A0
	public void WorkshopMode() { }

	// RVA: 0x94E080 Offset: 0x94C680 VA: 0x18094E080
	public void Toggle(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

