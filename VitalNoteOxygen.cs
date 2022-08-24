public class VitalNoteOxygen : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11291
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float refreshTime; // 0x18
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TextMeshProUGUI valueText; // 0x20
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Animator animator; // 0x28
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Image airIcon; // 0x30
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private RectTransform airIconTr; // 0x38
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Image backgroundImage; // 0x40
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Color baseColour; // 0x48
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Color badColour; // 0x58
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Image iconImage; // 0x68
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Color iconBaseColour; // 0x70
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Color iconBadColour; // 0x80
	protected bool show; // 0x90
	private TimeSince timeSinceLastRefresh; // 0x94

	public bool IsActive { get; }


	public void Refresh() { }

	private void Hide() { }

	protected virtual void Show() { }

	public bool get_IsActive() { }

	public void .ctor() { }

}

