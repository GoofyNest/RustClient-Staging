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

	// RVA: 0x963850 Offset: 0x961E50 VA: 0x180963850
	private void Awake() { }

	// RVA: 0x9643D0 Offset: 0x9629D0 VA: 0x1809643D0
	private void Update() { }

	// RVA: 0x963D90 Offset: 0x962390 VA: 0x180963D90
	private bool IsCopyPasteModifierHeld() { }

	// RVA: 0x963A80 Offset: 0x962080 VA: 0x180963A80
	private void Draw(Vector3 pos) { }

	// RVA: 0x963700 Offset: 0x961D00 VA: 0x180963700
	private void ApplyPaintables() { }

	// RVA: 0x9640D0 Offset: 0x9626D0 VA: 0x1809640D0
	public void UpdateBrushSize(float fNewSize) { }

	// RVA: 0x964030 Offset: 0x962630 VA: 0x180964030
	public void UpdateBrushAlpha(float fAlpha) { }

	// RVA: 0x964070 Offset: 0x962670 VA: 0x180964070
	public void UpdateBrushColor(Color color) { }

	// RVA: 0x9641D0 Offset: 0x9627D0 VA: 0x1809641D0
	public void UpdateBrushTexture(Texture texture) { }

	// RVA: 0x4E8840 Offset: 0x4E6E40 VA: 0x1804E8840
	public void SetLastBrush(Toggle toggle) { }

	// RVA: 0x963F80 Offset: 0x962580 VA: 0x180963F80
	public void SwitchToLastBrushIfErasing() { }

	// RVA: 0x963EA0 Offset: 0x9624A0 VA: 0x180963EA0
	public void OnClickedUndo() { }

	// RVA: 0x963DC0 Offset: 0x9623C0 VA: 0x180963DC0
	public void OnClickedRedo() { }

	// RVA: 0x964280 Offset: 0x962880 VA: 0x180964280
	private void UpdateUndoRedoButtons() { }

	// RVA: 0x964250 Offset: 0x962850 VA: 0x180964250
	public void UpdateLastPaintedMesh(BaseMeshPaintable paintable) { }

	// RVA: 0x9649F0 Offset: 0x962FF0 VA: 0x1809649F0
	public void .ctor() { }

}

