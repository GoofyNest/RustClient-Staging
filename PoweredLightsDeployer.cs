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

	// RVA: 0x9A0390 Offset: 0x99E990 VA: 0x1809A0390 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x99F8D0 Offset: 0x99DED0 VA: 0x18099F8D0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x99F790 Offset: 0x99DD90 VA: 0x18099F790
	public static bool CanPlayerUse(BasePlayer player) { }

	// RVA: 0x9A04F0 Offset: 0x99EAF0 VA: 0x1809A04F0
	public AdvancedChristmasLights get_active() { }

	// RVA: 0x9A0590 Offset: 0x99EB90 VA: 0x1809A0590
	public void set_active(AdvancedChristmasLights value) { }

	// RVA: 0x99F860 Offset: 0x99DE60 VA: 0x18099F860 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9A0480 Offset: 0x99EA80 VA: 0x1809A0480
	public void .ctor() { }

}

