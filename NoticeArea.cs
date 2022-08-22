public class NoticeArea : SingletonComponent<NoticeArea> // TypeDefIndex: 11041
{	// Fields
	public GameObjectRef itemPickupPrefab; // 0x18
	public GameObjectRef itemPickupCondensedText; // 0x20
	public GameObjectRef itemDroppedPrefab; // 0x28
	public AnimationCurve pickupSizeCurve; // 0x30
	public AnimationCurve pickupAlphaCurve; // 0x38
	public AnimationCurve reuseAlphaCurve; // 0x40
	public AnimationCurve reuseSizeCurve; // 0x48
	private IVitalNotice[] notices; // 0x50
	private List<ItemPickupNotice> pickups; // 0x58
	private RealTimeSince timeSinceUpdatedNotices; // 0x60

	// Methods

	// RVA: 0x9D3AA0 Offset: 0x9D20A0 VA: 0x1809D3AA0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x9D3B00 Offset: 0x9D2100 VA: 0x1809D3B00
	public static void ItemPickUp(ItemDefinition def, int amount, string nameOverride) { }

	// RVA: 0x9D4900 Offset: 0x9D2F00 VA: 0x1809D4900
	private void Update() { }

	// RVA: 0x9D44B0 Offset: 0x9D2AB0 VA: 0x1809D44B0
	private void UpdateLayout() { }

	// RVA: 0x9D3910 Offset: 0x9D1F10 VA: 0x1809D3910
	private static Vector2 ApplySizing(RectTransform rectT, bool setSize = False) { }

	// RVA: 0x9D41F0 Offset: 0x9D27F0 VA: 0x1809D41F0
	public void RefreshNotices() { }

	// RVA: 0x9D4AB0 Offset: 0x9D30B0 VA: 0x1809D4AB0
	public void .ctor() { }

}

