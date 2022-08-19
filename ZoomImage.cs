public class ZoomImage : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 10919
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float _minimumScale; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float _initialScale; // 0x1C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float _maximumScale; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float _scaleIncrement; // 0x24
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 _scale; // 0x28
	private RectTransform _thisTransform; // 0x38

	// Methods

	// RVA: 0x1AA64D0 Offset: 0x1AA4AD0 VA: 0x181AA64D0
	private void Awake() { }

	// RVA: 0x1AA6590 Offset: 0x1AA4B90 VA: 0x181AA6590 Slot: 4
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1AA6860 Offset: 0x1AA4E60 VA: 0x181AA6860
	public void .ctor() { }

}

