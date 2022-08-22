public class ProgressBar : UIBehaviour // TypeDefIndex: 11208
{	// Fields
	public static ProgressBar Instance; // 0x0
	private Action<BasePlayer> action; // 0x18
	private float timeFinished; // 0x20
	private float timeCounter; // 0x24
	public GameObject scaleTarget; // 0x28
	public Image progressField; // 0x30
	public Image iconField; // 0x38
	public Text leftField; // 0x40
	public Text rightField; // 0x48
	public SoundDefinition clipOpen; // 0x50
	public SoundDefinition clipCancel; // 0x58
	public bool IsOpen; // 0x60
	private bool isClosing; // 0x61
	private CanvasGroup canvasGroup; // 0x68

	// Methods

	// RVA: 0x692D10 Offset: 0x691310 VA: 0x180692D10 Slot: 6
	protected override void Start() { }

	// RVA: 0x6929A0 Offset: 0x690FA0 VA: 0x1806929A0
	public void Open(string name, Sprite sprite, Action<BasePlayer> action, float time) { }

	// RVA: 0x692DF0 Offset: 0x6913F0 VA: 0x180692DF0
	public void UpdateProgressBar() { }

	// RVA: 0x692CD0 Offset: 0x6912D0 VA: 0x180692CD0
	public void PlayOpenSound() { }

	// RVA: 0x692C90 Offset: 0x691290 VA: 0x180692C90
	public void PlayCancelSound() { }

	// RVA: 0x6927A0 Offset: 0x690DA0 VA: 0x1806927A0
	public void Close(bool success = False) { }

	// RVA: 0x692EF0 Offset: 0x6914F0 VA: 0x180692EF0
	private void Update() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

