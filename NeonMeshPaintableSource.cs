public class NeonMeshPaintableSource : MeshPaintableSource // TypeDefIndex: 8834
{	// Fields
	public NeonSign neonSign; // 0x90
	public float editorEmissionScale; // 0x98
	public AnimationCurve lightingCurve; // 0xA0
	public Color topLeft; // 0xA8
	public Color topRight; // 0xB8
	public Color bottomLeft; // 0xC8
	public Color bottomRight; // 0xD8

	// Methods

	// RVA: 0x7CC0D0 Offset: 0x7CA6D0 VA: 0x1807CC0D0 Slot: 4
	public override void UpdateMaterials(MaterialPropertyBlock block, Texture2D textureOverride, bool forEditing = False, bool isSelected = False) { }

	// RVA: 0x7CBEF0 Offset: 0x7CA4F0 VA: 0x1807CBEF0 Slot: 5
	public override Color32[] UpdateFrom(Texture2D input) { }

	// RVA: 0x7CC290 Offset: 0x7CA890 VA: 0x1807CC290
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CBCE0 Offset: 0x7CA2E0 VA: 0x1807CBCE0
	private Color <UpdateFrom>g__GetColorForRegion|8_0(int x, int y, int regionWidth, int regionHeight, ref NeonMeshPaintableSource.<>c__DisplayClass8_0 ) { }

}

private struct NeonMeshPaintableSource.<>c__DisplayClass8_0 // TypeDefIndex: 8835
{	// Fields
	public int width; // 0x0
	public Color32[] pixels; // 0x8
	public NeonMeshPaintableSource <>4__this; // 0x10

}

