public class BaseHelicopterVehicle : BaseVehicle // TypeDefIndex: 8325
{	// Fields
	private Option __menuOption_Menu_Push; // 0x3B8
	[HeaderAttribute] // RVA: 0xB7050 Offset: 0xB6450 VA: 0x1800B7050
	public float engineThrustMax; // 0x410
	public Vector3 torqueScale; // 0x414
	public Transform com; // 0x420
	public GameObject[] killTriggers; // 0x428
	[HeaderAttribute] // RVA: 0x786F0 Offset: 0x77AF0 VA: 0x1800786F0
	public Transform[] GroundPoints; // 0x430
	public Transform[] GroundEffects; // 0x438
	public GameObjectRef serverGibs; // 0x440
	public GameObjectRef explosionEffect; // 0x448
	public GameObjectRef fireBall; // 0x450
	public GameObjectRef impactEffectSmall; // 0x458
	public GameObjectRef impactEffectLarge; // 0x460
	[HeaderAttribute] // RVA: 0xA9FF0 Offset: 0xA93F0 VA: 0x1800A9FF0
	public SoundDefinition flightEngineSoundDef; // 0x468
	public SoundDefinition flightThwopsSoundDef; // 0x470
	public float rotorGainModSmoothing; // 0x478
	public float engineGainMin; // 0x47C
	public float engineGainMax; // 0x480
	public float thwopGainMin; // 0x484
	public float thwopGainMax; // 0x488
	public float currentThrottle; // 0x48C
	public float avgThrust; // 0x490
	public float liftDotMax; // 0x494
	public float altForceDotMin; // 0x498
	public float liftFraction; // 0x49C
	public float thrustLerpSpeed; // 0x4A0
	private Sound flightEngineSound; // 0x4A8
	private Sound flightThwopsSound; // 0x4B0
	private SoundModulation.Modulator flightEngineGainMod; // 0x4B8
	private SoundModulation.Modulator flightThwopsGainMod; // 0x4C0
	private TimeSince timeSinceUpdatedGroundEffects; // 0x4C8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA3EEC0 Offset: 0xA3D4C0 VA: 0x180A3EEC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA3FBF0 Offset: 0xA3E1F0 VA: 0x180A3FBF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA3F470 Offset: 0xA3DA70 VA: 0x180A3F470 Slot: 194
	public virtual void UpdateEffects() { }

	// RVA: 0xA3EE20 Offset: 0xA3D420 VA: 0x180A3EE20 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA3F1E0 Offset: 0xA3D7E0 VA: 0x180A3F1E0
	public void InitializeClientsideEffects() { }

	[BaseEntity.Menu] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.Description] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.Icon] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	// RVA: 0xA3F430 Offset: 0xA3DA30 VA: 0x180A3F430 Slot: 195
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0xA3FB80 Offset: 0xA3E180 VA: 0x180A3FB80
	public void .ctor() { }

}

public class BaseHelicopterVehicle.HelicopterInputState // TypeDefIndex: 8326
{	// Fields
	public float throttle; // 0x10
	public float roll; // 0x14
	public float yaw; // 0x18
	public float pitch; // 0x1C
	public bool groundControl; // 0x20

	// Methods

	// RVA: 0xA542F0 Offset: 0xA528F0 VA: 0x180A542F0
	public void Reset() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}
