public class PaddlingPool : LiquidContainer, ISplashable // TypeDefIndex: 8818
{	// Fields
	public const BaseEntity.Flags FilledUp = 1024;
	public Transform poolWaterVolume; // 0x3F8
	public GameObject poolWaterVisual; // 0x400
	public float minimumWaterHeight; // 0x408
	public float maximumWaterHeight; // 0x40C
	public WaterVolume waterVolume; // 0x410
	public bool alignWaterUp; // 0x418
	public GameObjectRef destroyedWithWaterEffect; // 0x420
	public Transform destroyedWithWaterEffectPos; // 0x428
	public Collider requireLookAt; // 0x430
	private float lastFillAmount; // 0x438

	// Methods

	// RVA: 0x875090 Offset: 0x873690 VA: 0x180875090 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x875280 Offset: 0x873880 VA: 0x180875280 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 167
	public override bool MenuDrink_ShowIf(BasePlayer player) { }

	// RVA: 0x874D70 Offset: 0x873370 VA: 0x180874D70 Slot: 169
	public override bool CanDrainIntoVessel(BasePlayer player) { }

	// RVA: 0x8753D0 Offset: 0x8739D0 VA: 0x1808753D0
	private void UpdatePoolFillAmount(float normalisedAmount) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x874E80 Offset: 0x873480 VA: 0x180874E80 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x875590 Offset: 0x873B90 VA: 0x180875590
	public void .ctor() { }

}

