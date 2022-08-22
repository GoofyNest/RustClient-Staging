public class ChangeSignText : UIDialog // TypeDefIndex: 10888
{	// Fields
	public Action<int, Texture2D> onUpdateTexture; // 0x30
	public GameObject objectContainer; // 0x38
	public GameObject currentFrameSection; // 0x40
	public GameObject[] frameOptions; // 0x48
	public Camera cameraPreview; // 0x50
	public Camera camera3D; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MeshPaintableSource[] <currentSources>k__BackingField; // 0x60
	private List<GameObject> copiedObjects; // 0x68
	private int currentFrame; // 0x70
	private Dictionary<BaseMeshPaintable, ChangeSignText.UndoBuffer> undoBuffer; // 0x78
	private static string savedContainerName; // 0x0
	private static Vector3 savedContainerEuler; // 0x8

	// Properties
	public MeshPaintableSource[] currentSources { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public MeshPaintableSource[] get_currentSources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	public void set_currentSources(MeshPaintableSource[] value) { }

	// RVA: 0x535530 Offset: 0x533B30 VA: 0x180535530
	public void Setup(MeshPaintableSource[] sources) { }

	// RVA: 0x534B10 Offset: 0x533110 VA: 0x180534B10
	public void LoadImageIntoFrame(int frame, byte[] imageData) { }

	// RVA: 0x5343F0 Offset: 0x5329F0 VA: 0x1805343F0
	private void DisableLODs(GameObject go) { }

	// RVA: 0x536110 Offset: 0x534710 VA: 0x180536110
	public void UpdateSign() { }

	// RVA: 0x5350E0 Offset: 0x5336E0 VA: 0x1805350E0
	public void RegisterChange(BaseMeshPaintable paintable) { }

	// RVA: 0x534FE0 Offset: 0x5335E0 VA: 0x180534FE0
	public void ProcessUndo(BaseMeshPaintable paintable) { }

	// RVA: 0x534DE0 Offset: 0x5333E0 VA: 0x180534DE0
	public void ProcessRedo(BaseMeshPaintable paintable) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4C2760 Offset: 0x4C0D60 VA: 0x1804C2760
	public void Cancel() { }

	// RVA: 0x534030 Offset: 0x532630 VA: 0x180534030 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x5352E0 Offset: 0x5338E0 VA: 0x1805352E0
	public void SelectFrame(int n) { }

	// RVA: 0x533F30 Offset: 0x532530 VA: 0x180533F30
	public void ClearCurrentFrame() { }

	// RVA: 0x534280 Offset: 0x532880 VA: 0x180534280
	public void CopyPreviousFrame() { }

	// RVA: 0x5349F0 Offset: 0x532FF0 VA: 0x1805349F0
	public bool IsUndoAvailable(BaseMeshPaintable paintable) { }

	// RVA: 0x5348C0 Offset: 0x532EC0 VA: 0x1805348C0
	public bool IsRedoAvailable(BaseMeshPaintable paintable) { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

private class ChangeSignText.UndoBuffer : IDisposable // TypeDefIndex: 10889
{	// Fields
	private List<Texture2D> buffer; // 0x10
	private Texture2D startFrame; // 0x18
	private int undoIndex; // 0x20
	private int undoSteps; // 0x24

	// Properties
	private int CurrentSlot { get; }
	public bool IsUndoAvailable { get; }
	public bool IsRedoAvailable { get; }

	// Methods

	// RVA: 0x547410 Offset: 0x545A10 VA: 0x180547410
	public void Initialise(Texture2D forTexture, int bufferLength) { }

	// RVA: 0x5477F0 Offset: 0x545DF0 VA: 0x1805477F0
	public void RegisterChange(Texture2D forTexture) { }

	// RVA: 0x547670 Offset: 0x545C70 VA: 0x180547670
	public void ProcessUndo(Texture2D targetTexture) { }

	// RVA: 0x547540 Offset: 0x545B40 VA: 0x180547540
	public void ProcessRedo(Texture2D targetTexture) { }

	// RVA: 0x547910 Offset: 0x545F10 VA: 0x180547910
	private int get_CurrentSlot() { }

	// RVA: 0x5479C0 Offset: 0x545FC0 VA: 0x1805479C0
	public bool get_IsUndoAvailable() { }

	// RVA: 0x5479A0 Offset: 0x545FA0 VA: 0x1805479A0
	public bool get_IsRedoAvailable() { }

	// RVA: 0x547320 Offset: 0x545920 VA: 0x180547320 Slot: 4
	public void Dispose() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

