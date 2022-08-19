public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9916
{
// Namespace: 
public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9916
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform <BatchTransform>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MeshRenderer <BatchRenderer>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MeshFilter <BatchFilter>k__BackingField; // 0x28
	private bool disabled; // 0x30
	private RendererGroup batchGroup; // 0x38
	private MeshRendererInstance batchInstance; // 0x40

	// Properties
	public Transform BatchTransform { get; set; }
	public MeshRenderer BatchRenderer { get; set; }
	public MeshFilter BatchFilter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Transform get_BatchTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_BatchTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public MeshRenderer get_BatchRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_BatchRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public MeshFilter get_BatchFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_BatchFilter(MeshFilter value) { }

	// RVA: 0x94D860 Offset: 0x94BE60 VA: 0x18094D860
	protected void OnEnable() { }

	// RVA: 0x94D7F0 Offset: 0x94BDF0 VA: 0x18094D7F0
	protected void OnDisable() { }

	// RVA: 0x94D230 Offset: 0x94B830 VA: 0x18094D230
	public void Add() { }

	// RVA: 0x94D930 Offset: 0x94BF30 VA: 0x18094D930
	public void Remove() { }

	// RVA: 0x94D910 Offset: 0x94BF10 VA: 0x18094D910
	public void Refresh() { }

	// RVA: 0x94D0C0 Offset: 0x94B6C0 VA: 0x18094D0C0
	public void AddBatch(RendererGroup batchGroup) { }

	// RVA: 0x94DA80 Offset: 0x94C080 VA: 0x18094DA80
	public void WorkshopMode() { }

	// RVA: 0x94DA60 Offset: 0x94C060 VA: 0x18094DA60
	public void Toggle(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

