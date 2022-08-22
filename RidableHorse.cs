public class RidableHorse : BaseRidableAnimal // TypeDefIndex: 8635
{	// Fields
	[ServerVar] // RVA: 0xB4310 Offset: 0xB3710 VA: 0x1800B4310
	public static float Population; // 0x0
	public string distanceStatName; // 0x6E8
	public HorseBreed[] breeds; // 0x6F0
	public SkinnedMeshRenderer[] bodyRenderers; // 0x6F8
	public SkinnedMeshRenderer[] hairRenderers; // 0x700
	private int currentBreed; // 0x708
	private ProtectionProperties riderProtection; // 0x710
	private ProtectionProperties baseHorseProtection; // 0x718
	public const BaseEntity.Flags Flag_HideHair = 1024;
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float equipmentSpeedMod; // 0x720
	private int numStorageSlots; // 0x724
	private static Material[] breedAssignmentArray; // 0x8
	private float clientRecievedRunSpeed; // 0x728

	// Properties
	public override float RealisticMass { get; }

	// Methods

	// RVA: 0x4C6FF0 Offset: 0x4C55F0 VA: 0x1804C6FF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4C6E80 Offset: 0x4C5480 VA: 0x1804C6E80
	public int GetStorageSlotCount() { }

	// RVA: 0x4C7610 Offset: 0x4C5C10 VA: 0x1804C7610 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x4C68D0 Offset: 0x4C4ED0 VA: 0x1804C68D0
	public void ApplyBreed(int index) { }

	// RVA: 0x4C67A0 Offset: 0x4C4DA0 VA: 0x1804C67A0
	protected void ApplyBreedInternal(HorseBreed breed) { }

	// RVA: 0x4C6CA0 Offset: 0x4C52A0 VA: 0x1804C6CA0
	public HorseBreed GetBreed() { }

	// RVA: 0x4C6E90 Offset: 0x4C5490 VA: 0x1804C6E90 Slot: 198
	public override float GetTrotSpeed() { }

	// RVA: 0x4C6E00 Offset: 0x4C5400 VA: 0x1804C6E00 Slot: 199
	public override float GetRunSpeed() { }

	// RVA: 0x4C6F10 Offset: 0x4C5510 VA: 0x1804C6F10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C6CF0 Offset: 0x4C52F0 VA: 0x1804C6CF0
	public void GetDistanceTravelled(BaseEntity.RPCMessage msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x4C7590 Offset: 0x4C5B90 VA: 0x1804C7590
	public void .ctor() { }

	// RVA: 0x4C7520 Offset: 0x4C5B20 VA: 0x1804C7520
	private static void .cctor() { }

}

