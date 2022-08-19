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

	// RVA: 0x859820 Offset: 0x857E20 VA: 0x180859820 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x859A10 Offset: 0x858010 VA: 0x180859A10 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 167
	public override bool MenuDrink_ShowIf(BasePlayer player) { }

	// RVA: 0x859500 Offset: 0x857B00 VA: 0x180859500 Slot: 169
	public override bool CanDrainIntoVessel(BasePlayer player) { }

	// RVA: 0x859B60 Offset: 0x858160 VA: 0x180859B60
	private void UpdatePoolFillAmount(float normalisedAmount) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x859610 Offset: 0x857C10 VA: 0x180859610 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x859D20 Offset: 0x858320 VA: 0x180859D20
	public void .ctor() { }

}

