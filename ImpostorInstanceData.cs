public class ImpostorInstanceData // TypeDefIndex: 10680
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Renderer <Renderer>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Mesh <Mesh>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Material <Material>k__BackingField; // 0x20
	public ImpostorBatch Batch; // 0x28
	public int BatchIndex; // 0x30
	private int hash; // 0x34
	private Vector4 positionAndScale; // 0x38

	public Renderer Renderer { get; set; }
	public Mesh Mesh { get; set; }
	public Material Material { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Renderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Renderer get_Renderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Material get_Material() { }

	public void .ctor(Renderer renderer, Mesh mesh, Material material) { }

	public void .ctor(Vector3 position, Vector3 scale, Mesh mesh, Material material) { }

	private int GenerateHashCode() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public Vector4 PositionAndScale() { }

	public void Update() { }

}

