public class RidableHorse : BaseRidableAnimal // TypeDefIndex: 8635
{	// Fields
	[ServerVar] // RVA: 0xB4270 Offset: 0xB3670 VA: 0x1800B4270
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

	// RVA: 0x4C7060 Offset: 0x4C5660 VA: 0x1804C7060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4C6EF0 Offset: 0x4C54F0 VA: 0x1804C6EF0
	public int GetStorageSlotCount() { }

	// RVA: 0x4C7680 Offset: 0x4C5C80 VA: 0x1804C7680 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x4C6940 Offset: 0x4C4F40 VA: 0x1804C6940
	public void ApplyBreed(int index) { }

	// RVA: 0x4C6810 Offset: 0x4C4E10 VA: 0x1804C6810
	protected void ApplyBreedInternal(HorseBreed breed) { }

	// RVA: 0x4C6D10 Offset: 0x4C5310 VA: 0x1804C6D10
	public HorseBreed GetBreed() { }

	// RVA: 0x4C6F00 Offset: 0x4C5500 VA: 0x1804C6F00 Slot: 198
	public override float GetTrotSpeed() { }

	// RVA: 0x4C6E70 Offset: 0x4C5470 VA: 0x1804C6E70 Slot: 199
	public override float GetRunSpeed() { }

	// RVA: 0x4C6F80 Offset: 0x4C5580 VA: 0x1804C6F80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4C6D60 Offset: 0x4C5360 VA: 0x1804C6D60
	public void GetDistanceTravelled(BaseEntity.RPCMessage msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x4C7600 Offset: 0x4C5C00 VA: 0x1804C7600
	public void .ctor() { }

	// RVA: 0x4C7590 Offset: 0x4C5B90 VA: 0x1804C7590
	private static void .cctor() { }

}

