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

	// RVA: 0x967490 Offset: 0x965A90 VA: 0x180967490
	private void OnDisable() { }

	// RVA: 0x967590 Offset: 0x965B90 VA: 0x180967590
	private void Shutdown() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 4
	public override Texture2D get_TargetTexture() { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0 Slot: 5
	public override void set_TargetTexture(Texture2D value) { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0 Slot: 6
	public override bool get_HasChanges() { }

	// RVA: 0x80FEF0 Offset: 0x80E4F0 VA: 0x18080FEF0 Slot: 7
	public override void set_HasChanges(bool value) { }

	// RVA: 0x966F50 Offset: 0x965550 VA: 0x180966F50 Slot: 8
	public override void Init(MeshPaintableSource source, bool isSelected) { }

	// RVA: 0x966A60 Offset: 0x965060 VA: 0x180966A60 Slot: 9
	public override void Clear() { }

	// RVA: 0x966A30 Offset: 0x965030 VA: 0x180966A30 Slot: 10
	public override void Apply() { }

	// RVA: 0x966B30 Offset: 0x965130 VA: 0x180966B30 Slot: 11
	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 12
	public override bool ShouldHit(RaycastHit info) { }

	// RVA: 0x967640 Offset: 0x965C40 VA: 0x180967640
	public void .ctor() { }

}

