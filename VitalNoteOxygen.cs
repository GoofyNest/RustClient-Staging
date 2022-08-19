public class VitalNoteOxygen : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11287
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float refreshTime; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TextMeshProUGUI valueText; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Animator animator; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Image airIcon; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private RectTransform airIconTr; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Image backgroundImage; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color baseColour; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color badColour; // 0x58
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Image iconImage; // 0x68
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color iconBaseColour; // 0x70
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color iconBadColour; // 0x80
	protected bool show; // 0x90
	private TimeSince timeSinceLastRefresh; // 0x94

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x800860 Offset: 0x7FEE60 VA: 0x180800860 Slot: 4
	public void Refresh() { }

	// RVA: 0x800810 Offset: 0x7FEE10 VA: 0x180800810
	private void Hide() { }

	// RVA: 0x800DE0 Offset: 0x7FF3E0 VA: 0x180800DE0 Slot: 6
	protected virtual void Show() { }

	// RVA: 0x768A60 Offset: 0x767060 VA: 0x180768A60 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x800E30 Offset: 0x7FF430 VA: 0x180800E30
	public void .ctor() { }

}

