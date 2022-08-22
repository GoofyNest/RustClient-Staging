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
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public MeshPaintableSource[] get_currentSources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	public void set_currentSources(MeshPaintableSource[] value) { }

	// RVA: 0x5355A0 Offset: 0x533BA0 VA: 0x1805355A0
	public void Setup(MeshPaintableSource[] sources) { }

	// RVA: 0x534B80 Offset: 0x533180 VA: 0x180534B80
	public void LoadImageIntoFrame(int frame, byte[] imageData) { }

	// RVA: 0x534460 Offset: 0x532A60 VA: 0x180534460
	private void DisableLODs(GameObject go) { }

	// RVA: 0x536180 Offset: 0x534780 VA: 0x180536180
	public void UpdateSign() { }

	// RVA: 0x535150 Offset: 0x533750 VA: 0x180535150
	public void RegisterChange(BaseMeshPaintable paintable) { }

	// RVA: 0x535050 Offset: 0x533650 VA: 0x180535050
	public void ProcessUndo(BaseMeshPaintable paintable) { }

	// RVA: 0x534E50 Offset: 0x533450 VA: 0x180534E50
	public void ProcessRedo(BaseMeshPaintable paintable) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0
	public void Cancel() { }

	// RVA: 0x5340A0 Offset: 0x5326A0 VA: 0x1805340A0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x535350 Offset: 0x533950 VA: 0x180535350
	public void SelectFrame(int n) { }

	// RVA: 0x533FA0 Offset: 0x5325A0 VA: 0x180533FA0
	public void ClearCurrentFrame() { }

	// RVA: 0x5342F0 Offset: 0x5328F0 VA: 0x1805342F0
	public void CopyPreviousFrame() { }

	// RVA: 0x534A60 Offset: 0x533060 VA: 0x180534A60
	public bool IsUndoAvailable(BaseMeshPaintable paintable) { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public bool IsRedoAvailable(BaseMeshPaintable paintable) { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
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

	// RVA: 0x547480 Offset: 0x545A80 VA: 0x180547480
	public void Initialise(Texture2D forTexture, int bufferLength) { }

	// RVA: 0x547860 Offset: 0x545E60 VA: 0x180547860
	public void RegisterChange(Texture2D forTexture) { }

	// RVA: 0x5476E0 Offset: 0x545CE0 VA: 0x1805476E0
	public void ProcessUndo(Texture2D targetTexture) { }

	// RVA: 0x5475B0 Offset: 0x545BB0 VA: 0x1805475B0
	public void ProcessRedo(Texture2D targetTexture) { }

	// RVA: 0x547980 Offset: 0x545F80 VA: 0x180547980
	private int get_CurrentSlot() { }

	// RVA: 0x547A30 Offset: 0x546030 VA: 0x180547A30
	public bool get_IsUndoAvailable() { }

	// RVA: 0x547A10 Offset: 0x546010 VA: 0x180547A10
	public bool get_IsRedoAvailable() { }

	// RVA: 0x547390 Offset: 0x545990 VA: 0x180547390 Slot: 4
	public void Dispose() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

