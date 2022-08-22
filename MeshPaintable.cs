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

	// RVA: 0x967AA0 Offset: 0x9660A0 VA: 0x180967AA0
	private void OnDisable() { }

	// RVA: 0x967BA0 Offset: 0x9661A0 VA: 0x180967BA0
	private void Shutdown() { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 4
	public override Texture2D get_TargetTexture() { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650 Slot: 5
	public override void set_TargetTexture(Texture2D value) { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90 Slot: 6
	public override bool get_HasChanges() { }

	// RVA: 0x810590 Offset: 0x80EB90 VA: 0x180810590 Slot: 7
	public override void set_HasChanges(bool value) { }

	// RVA: 0x967560 Offset: 0x965B60 VA: 0x180967560 Slot: 8
	public override void Init(MeshPaintableSource source, bool isSelected) { }

	// RVA: 0x967070 Offset: 0x965670 VA: 0x180967070 Slot: 9
	public override void Clear() { }

	// RVA: 0x967040 Offset: 0x965640 VA: 0x180967040 Slot: 10
	public override void Apply() { }

	// RVA: 0x967140 Offset: 0x965740 VA: 0x180967140 Slot: 11
	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 12
	public override bool ShouldHit(RaycastHit info) { }

	// RVA: 0x967C50 Offset: 0x966250 VA: 0x180967C50
	public void .ctor() { }

}

