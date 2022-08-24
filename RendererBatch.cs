public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9916
{
public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9916
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform <BatchTransform>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private MeshRenderer <BatchRenderer>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private MeshFilter <BatchFilter>k__BackingField; // 0x28
	private bool disabled; // 0x30
	private RendererGroup batchGroup; // 0x38
	private MeshRendererInstance batchInstance; // 0x40

	public Transform BatchTransform { get; set; }
	public MeshRenderer BatchRenderer { get; set; }
	public MeshFilter BatchFilter { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Transform get_BatchTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_BatchTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public MeshRenderer get_BatchRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_BatchRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public MeshFilter get_BatchFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_BatchFilter(MeshFilter value) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void Add() { }

	public void Remove() { }

	public void Refresh() { }

	public void AddBatch(RendererGroup batchGroup) { }

	public void WorkshopMode() { }

	public void Toggle(bool state) { }

	public void .ctor() { }

}

