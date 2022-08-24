public class NoticeArea : SingletonComponent<NoticeArea> // TypeDefIndex: 11045
{	public GameObjectRef itemPickupPrefab; // 0x18
	public GameObjectRef itemPickupCondensedText; // 0x20
	public GameObjectRef itemDroppedPrefab; // 0x28
	public AnimationCurve pickupSizeCurve; // 0x30
	public AnimationCurve pickupAlphaCurve; // 0x38
	public AnimationCurve reuseAlphaCurve; // 0x40
	public AnimationCurve reuseSizeCurve; // 0x48
	private IVitalNotice[] notices; // 0x50
	private List<ItemPickupNotice> pickups; // 0x58
	private RealTimeSince timeSinceUpdatedNotices; // 0x60


	protected override void Awake() { }

	public static void ItemPickUp(ItemDefinition def, int amount, string nameOverride) { }

	private void Update() { }

	private void UpdateLayout() { }

	private static Vector2 ApplySizing(RectTransform rectT, bool setSize = False) { }

	public void RefreshNotices() { }

	public void .ctor() { }

}

