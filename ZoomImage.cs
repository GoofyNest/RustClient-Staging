public class ZoomImage : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 10919
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float _minimumScale; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float _initialScale; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float _maximumScale; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float _scaleIncrement; // 0x24
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 _scale; // 0x28
	private RectTransform _thisTransform; // 0x38

	// Methods

	// RVA: 0x1A90140 Offset: 0x1A8E740 VA: 0x181A90140
	private void Awake() { }

	// RVA: 0x1A90200 Offset: 0x1A8E800 VA: 0x181A90200 Slot: 4
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1A904D0 Offset: 0x1A8EAD0 VA: 0x181A904D0
	public void .ctor() { }

}

