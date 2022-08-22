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

	// RVA: 0x800970 Offset: 0x7FEF70 VA: 0x180800970 Slot: 4
	public void Refresh() { }

	// RVA: 0x800920 Offset: 0x7FEF20 VA: 0x180800920
	private void Hide() { }

	// RVA: 0x800EF0 Offset: 0x7FF4F0 VA: 0x180800EF0 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x768B70 Offset: 0x767170 VA: 0x180768B70 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x800F40 Offset: 0x7FF540 VA: 0x180800F40
	public void .ctor() { }

}

