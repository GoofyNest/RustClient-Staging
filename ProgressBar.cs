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

	// RVA: 0x692D80 Offset: 0x691380 VA: 0x180692D80 Slot: 6
	protected override void Start() { }

	// RVA: 0x692A10 Offset: 0x691010 VA: 0x180692A10
	public void Open(string name, Sprite sprite, Action<BasePlayer> action, float time) { }

	// RVA: 0x692E60 Offset: 0x691460 VA: 0x180692E60
	public void UpdateProgressBar() { }

	// RVA: 0x692D40 Offset: 0x691340 VA: 0x180692D40
	public void PlayOpenSound() { }

	// RVA: 0x692D00 Offset: 0x691300 VA: 0x180692D00
	public void PlayCancelSound() { }

	// RVA: 0x692810 Offset: 0x690E10 VA: 0x180692810
	public void Close(bool success = False) { }

	// RVA: 0x692F60 Offset: 0x691560 VA: 0x180692F60
	private void Update() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

