public class MeshPaintableSource : MonoBehaviour, IClientComponent // TypeDefIndex: 9207
{	// Fields
	public Vector4 uvRange; // 0x18
	public int texWidth; // 0x28
	public int texHeight; // 0x2C
	public string replacementTextureName; // 0x30
	public float cameraFOV; // 0x38
	public float cameraDistance; // 0x3C
	public Texture2D texture; // 0x40
	public GameObject sourceObject; // 0x48
	public Mesh collisionMesh; // 0x50
	public Vector3 localPosition; // 0x58
	public Vector3 localRotation; // 0x64
	public bool applyToAllRenderers; // 0x70
	public Renderer[] extraRenderers; // 0x78
	public bool paint3D; // 0x80
	public bool isSelected; // 0x81
	public Renderer legRenderer; // 0x88
	private static MaterialPropertyBlock block; // 0x0

	// Methods

	// RVA: 0x9662D0 Offset: 0x9648D0 VA: 0x1809662D0
	public void Init() { }

	// RVA: 0x966220 Offset: 0x964820 VA: 0x180966220
	public void Free() { }

	// RVA: 0x966960 Offset: 0x964F60 VA: 0x180966960 Slot: 4
	public virtual void UpdateMaterials(MaterialPropertyBlock block, Texture2D textureOverride, bool forEditing = False, bool isSelected = False) { }

	// RVA: 0x9668F0 Offset: 0x964EF0 VA: 0x1809668F0 Slot: 5
	public virtual Color32[] UpdateFrom(Texture2D input) { }

	// RVA: 0x966890 Offset: 0x964E90 VA: 0x180966890
	public void Load(byte[] data) { }

	// RVA: 0x966110 Offset: 0x964710 VA: 0x180966110
	public void Clear() { }

	// RVA: 0x966990 Offset: 0x964F90 VA: 0x180966990
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}
