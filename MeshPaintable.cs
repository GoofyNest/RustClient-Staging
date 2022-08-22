public class MeshPaintable : BaseMeshPaintable // TypeDefIndex: 9204
{	// Fields
	public string replacementTextureName; // 0x18
	public int textureWidth; // 0x20
	public int textureHeight; // 0x24
	public Color clearColor; // 0x28
	public Texture2D targetTexture; // 0x38
	public bool hasChanges; // 0x40
	private RectInt areaClamp; // 0x44

	// Properties
	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }

	// Methods

	// RVA: 0x9675A0 Offset: 0x965BA0 VA: 0x1809675A0
	private void OnDisable() { }

	// RVA: 0x9676A0 Offset: 0x965CA0 VA: 0x1809676A0
	private void Shutdown() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public override Texture2D get_TargetTexture() { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0 Slot: 5
	public override void set_TargetTexture(Texture2D value) { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600 Slot: 6
	public override bool get_HasChanges() { }

	// RVA: 0x810000 Offset: 0x80E600 VA: 0x180810000 Slot: 7
	public override void set_HasChanges(bool value) { }

	// RVA: 0x967060 Offset: 0x965660 VA: 0x180967060 Slot: 8
	public override void Init(MeshPaintableSource source, bool isSelected) { }

	// RVA: 0x966B70 Offset: 0x965170 VA: 0x180966B70 Slot: 9
	public override void Clear() { }

	// RVA: 0x966B40 Offset: 0x965140 VA: 0x180966B40 Slot: 10
	public override void Apply() { }

	// RVA: 0x966C40 Offset: 0x965240 VA: 0x180966C40 Slot: 11
	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool ShouldHit(RaycastHit info) { }

	// RVA: 0x967750 Offset: 0x965D50 VA: 0x180967750
	public void .ctor() { }

}

