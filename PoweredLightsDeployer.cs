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

	// RVA: 0x99FEA0 Offset: 0x99E4A0 VA: 0x18099FEA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x99F3E0 Offset: 0x99D9E0 VA: 0x18099F3E0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x99F2A0 Offset: 0x99D8A0 VA: 0x18099F2A0
	public static bool CanPlayerUse(BasePlayer player) { }

	// RVA: 0x9A0000 Offset: 0x99E600 VA: 0x1809A0000
	public AdvancedChristmasLights get_active() { }

	// RVA: 0x9A00A0 Offset: 0x99E6A0 VA: 0x1809A00A0
	public void set_active(AdvancedChristmasLights value) { }

	// RVA: 0x99F370 Offset: 0x99D970 VA: 0x18099F370 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x99FF90 Offset: 0x99E590 VA: 0x18099FF90
	public void .ctor() { }

}

