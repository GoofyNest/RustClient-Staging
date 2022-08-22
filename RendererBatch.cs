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
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_BatchTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public MeshRenderer get_BatchRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_BatchRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public MeshFilter get_BatchFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_BatchFilter(MeshFilter value) { }

	// RVA: 0x94D970 Offset: 0x94BF70 VA: 0x18094D970
	protected void OnEnable() { }

	// RVA: 0x94D900 Offset: 0x94BF00 VA: 0x18094D900
	protected void OnDisable() { }

	// RVA: 0x94D340 Offset: 0x94B940 VA: 0x18094D340
	public void Add() { }

	// RVA: 0x94DA40 Offset: 0x94C040 VA: 0x18094DA40
	public void Remove() { }

	// RVA: 0x94DA20 Offset: 0x94C020 VA: 0x18094DA20
	public void Refresh() { }

	// RVA: 0x94D1D0 Offset: 0x94B7D0 VA: 0x18094D1D0
	public void AddBatch(RendererGroup batchGroup) { }

	// RVA: 0x94DB90 Offset: 0x94C190 VA: 0x18094DB90
	public void WorkshopMode() { }

	// RVA: 0x94DB70 Offset: 0x94C170 VA: 0x18094DB70
	public void Toggle(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

