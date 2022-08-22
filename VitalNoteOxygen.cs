public class VitalNoteOxygen : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11287
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float refreshTime; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TextMeshProUGUI valueText; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Animator animator; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image airIcon; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform airIconTr; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image backgroundImage; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color baseColour; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color badColour; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Image iconImage; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color iconBaseColour; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color iconBadColour; // 0x80
	protected bool show; // 0x90
	private TimeSince timeSinceLastRefresh; // 0x94

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x800F00 Offset: 0x7FF500 VA: 0x180800F00 Slot: 4
	public void Refresh() { }

	// RVA: 0x800EB0 Offset: 0x7FF4B0 VA: 0x180800EB0
	private void Hide() { }

	// RVA: 0x801480 Offset: 0x7FFA80 VA: 0x180801480 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x768AC0 Offset: 0x7670C0 VA: 0x180768AC0 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x8014D0 Offset: 0x7FFAD0 VA: 0x1808014D0
	public void .ctor() { }

}

