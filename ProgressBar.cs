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

	// RVA: 0x692C70 Offset: 0x691270 VA: 0x180692C70 Slot: 6
	protected override void Start() { }

	// RVA: 0x692900 Offset: 0x690F00 VA: 0x180692900
	public void Open(string name, Sprite sprite, Action<BasePlayer> action, float time) { }

	// RVA: 0x692D50 Offset: 0x691350 VA: 0x180692D50
	public void UpdateProgressBar() { }

	// RVA: 0x692C30 Offset: 0x691230 VA: 0x180692C30
	public void PlayOpenSound() { }

	// RVA: 0x692BF0 Offset: 0x6911F0 VA: 0x180692BF0
	public void PlayCancelSound() { }

	// RVA: 0x692700 Offset: 0x690D00 VA: 0x180692700
	public void Close(bool success = False) { }

	// RVA: 0x692E50 Offset: 0x691450 VA: 0x180692E50
	private void Update() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

