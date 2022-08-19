public class PoweredLightsDeployer : HeldEntity // TypeDefIndex: 8625
{	// Fields
	public GameObjectRef poweredLightsPrefab; // 0x1F8
	public EntityRef activeLights; // 0x200
	public MaterialReplacement guide; // 0x210
	public GameObject guideObject; // 0x218
	public float maxPlaceDistance; // 0x220
	public float lengthPerAmount; // 0x224
	private float nextClickTime; // 0x228

	// Properties
	public AdvancedChristmasLights active { get; set; }

	// Methods

	// RVA: 0x99FD90 Offset: 0x99E390 VA: 0x18099FD90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x99F2D0 Offset: 0x99D8D0 VA: 0x18099F2D0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x99F190 Offset: 0x99D790 VA: 0x18099F190
	public static bool CanPlayerUse(BasePlayer player) { }

	// RVA: 0x99FEF0 Offset: 0x99E4F0 VA: 0x18099FEF0
	public AdvancedChristmasLights get_active() { }

	// RVA: 0x99FF90 Offset: 0x99E590 VA: 0x18099FF90
	public void set_active(AdvancedChristmasLights value) { }

	// RVA: 0x99F260 Offset: 0x99D860 VA: 0x18099F260 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x99FE80 Offset: 0x99E480 VA: 0x18099FE80
	public void .ctor() { }

}

