public class TeamMemberElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler // TypeDefIndex: 11234
{	// Fields
	public RustText nameText; // 0x18
	public RawImage icon; // 0x20
	public Color onlineColor; // 0x28
	public Color offlineColor; // 0x38
	public Color deadColor; // 0x48
	public Color woundedColor; // 0x58
	public GameObject hoverOverlay; // 0x68
	public RawImage memberIcon; // 0x70
	public RawImage leaderIcon; // 0x78
	public RawImage deadIcon; // 0x80
	public RawImage woundedIcon; // 0x88
	public int teamIndex; // 0x90

	// Methods

	// RVA: 0x7C78C0 Offset: 0x7C5EC0 VA: 0x1807C78C0
	public void UpdateState(string name, bool isOnline, bool isAlive = True, bool isLeader = False, bool isWounded = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnEnable() { }

	// RVA: 0x7C7300 Offset: 0x7C5900 VA: 0x1807C7300
	public void OnDisable() { }

	// RVA: 0x7C7360 Offset: 0x7C5960 VA: 0x1807C7360 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x7C73B0 Offset: 0x7C59B0 VA: 0x1807C73B0 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x7C7310 Offset: 0x7C5910 VA: 0x1807C7310 Slot: 6
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7C7400 Offset: 0x7C5A00 VA: 0x1807C7400
	public void OverlayClick() { }

	// RVA: 0x7C75F0 Offset: 0x7C5BF0 VA: 0x1807C75F0
	public void SetOverlayVisible(bool wantsVisible) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

