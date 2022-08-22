public class ZoomImage : MonoBehaviour, IScrollHandler, IEventSystemHandler // TypeDefIndex: 10919
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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


	private void Awake() { }

	public void OnScroll(PointerEventData eventData) { }

	public void .ctor() { }

}

