public class MeshPaintController : MonoBehaviour, IClientComponent // TypeDefIndex: 9203
{	// Fields
	public Camera pickerCamera; // 0x18
	public Texture2D brushTexture; // 0x20
	public Vector2 brushScale; // 0x28
	public Color brushColor; // 0x30
	public float brushSpacing; // 0x40
	public RawImage brushImage; // 0x48
	public float brushPreviewScaleMultiplier; // 0x50
	public bool applyDefaults; // 0x54
	public Texture2D defaltBrushTexture; // 0x58
	public float defaultBrushSize; // 0x60
	public Color defaultBrushColor; // 0x64
	public float defaultBrushAlpha; // 0x74
	public Toggle lastBrush; // 0x78
	public Button UndoButton; // 0x80
	public Button RedoButton; // 0x88
	private Vector3 lastPosition; // 0x90
	internal List<BaseMeshPaintable> dirtyPaintables; // 0xA0
	internal bool drawingBlocked; // 0xA8
	private ChangeSignText signTextPanel; // 0xB0
	private BaseMeshPaintable paintingMesh; // 0xB8
	private BaseMeshPaintable lastPaintedMesh; // 0xC0

	// Methods

	// RVA: 0x963740 Offset: 0x961D40 VA: 0x180963740
	private void Awake() { }

	// RVA: 0x9642C0 Offset: 0x9628C0 VA: 0x1809642C0
	private void Update() { }

	// RVA: 0x963C80 Offset: 0x962280 VA: 0x180963C80
	private bool IsCopyPasteModifierHeld() { }

	// RVA: 0x963970 Offset: 0x961F70 VA: 0x180963970
	private void Draw(Vector3 pos) { }

	// RVA: 0x9635F0 Offset: 0x961BF0 VA: 0x1809635F0
	private void ApplyPaintables() { }

	// RVA: 0x963FC0 Offset: 0x9625C0 VA: 0x180963FC0
	public void UpdateBrushSize(float fNewSize) { }

	// RVA: 0x963F20 Offset: 0x962520 VA: 0x180963F20
	public void UpdateBrushAlpha(float fAlpha) { }

	// RVA: 0x963F60 Offset: 0x962560 VA: 0x180963F60
	public void UpdateBrushColor(Color color) { }

	// RVA: 0x9640C0 Offset: 0x9626C0 VA: 0x1809640C0
	public void UpdateBrushTexture(Texture texture) { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	public void SetLastBrush(Toggle toggle) { }

	// RVA: 0x963E70 Offset: 0x962470 VA: 0x180963E70
	public void SwitchToLastBrushIfErasing() { }

	// RVA: 0x963D90 Offset: 0x962390 VA: 0x180963D90
	public void OnClickedUndo() { }

	// RVA: 0x963CB0 Offset: 0x9622B0 VA: 0x180963CB0
	public void OnClickedRedo() { }

	// RVA: 0x964170 Offset: 0x962770 VA: 0x180964170
	private void UpdateUndoRedoButtons() { }

	// RVA: 0x964140 Offset: 0x962740 VA: 0x180964140
	public void UpdateLastPaintedMesh(BaseMeshPaintable paintable) { }

	// RVA: 0x9648E0 Offset: 0x962EE0 VA: 0x1809648E0
	public void .ctor() { }

}

