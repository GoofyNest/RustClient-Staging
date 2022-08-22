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

	// RVA: 0x963D50 Offset: 0x962350 VA: 0x180963D50
	private void Awake() { }

	// RVA: 0x9648D0 Offset: 0x962ED0 VA: 0x1809648D0
	private void Update() { }

	// RVA: 0x964290 Offset: 0x962890 VA: 0x180964290
	private bool IsCopyPasteModifierHeld() { }

	// RVA: 0x963F80 Offset: 0x962580 VA: 0x180963F80
	private void Draw(Vector3 pos) { }

	// RVA: 0x963C00 Offset: 0x962200 VA: 0x180963C00
	private void ApplyPaintables() { }

	// RVA: 0x9645D0 Offset: 0x962BD0 VA: 0x1809645D0
	public void UpdateBrushSize(float fNewSize) { }

	// RVA: 0x964530 Offset: 0x962B30 VA: 0x180964530
	public void UpdateBrushAlpha(float fAlpha) { }

	// RVA: 0x964570 Offset: 0x962B70 VA: 0x180964570
	public void UpdateBrushColor(Color color) { }

	// RVA: 0x9646D0 Offset: 0x962CD0 VA: 0x1809646D0
	public void UpdateBrushTexture(Texture texture) { }

	// RVA: 0x4E87D0 Offset: 0x4E6DD0 VA: 0x1804E87D0
	public void SetLastBrush(Toggle toggle) { }

	// RVA: 0x964480 Offset: 0x962A80 VA: 0x180964480
	public void SwitchToLastBrushIfErasing() { }

	// RVA: 0x9643A0 Offset: 0x9629A0 VA: 0x1809643A0
	public void OnClickedUndo() { }

	// RVA: 0x9642C0 Offset: 0x9628C0 VA: 0x1809642C0
	public void OnClickedRedo() { }

	// RVA: 0x964780 Offset: 0x962D80 VA: 0x180964780
	private void UpdateUndoRedoButtons() { }

	// RVA: 0x964750 Offset: 0x962D50 VA: 0x180964750
	public void UpdateLastPaintedMesh(BaseMeshPaintable paintable) { }

	// RVA: 0x964EF0 Offset: 0x9634F0 VA: 0x180964EF0
	public void .ctor() { }

}

