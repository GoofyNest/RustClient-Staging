public class MixingTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6386
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float totalMixTime; // 0x14
	public float remainingMixTime; // 0x18

	// Methods

	// RVA: 0x1F53BD0 Offset: 0x1F521D0 VA: 0x181F53BD0
	public static void ResetToPool(MixingTable instance) { }

	// RVA: 0x1F53B50 Offset: 0x1F52150 VA: 0x181F53B50
	public void ResetToPool() { }

	// RVA: 0x1F538B0 Offset: 0x1F51EB0 VA: 0x181F538B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBE8E0 Offset: 0x1DBCEE0 VA: 0x181DBE8E0
	public void CopyTo(MixingTable instance) { }

	// RVA: 0x1F52AB0 Offset: 0x1F510B0 VA: 0x181F52AB0
	public MixingTable Copy() { }

	// RVA: 0x1F536F0 Offset: 0x1F51CF0 VA: 0x181F536F0
	public static MixingTable Deserialize(Stream stream) { }

	// RVA: 0x1F52D70 Offset: 0x1F51370 VA: 0x181F52D70
	public static MixingTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F53020 Offset: 0x1F51620 VA: 0x181F53020
	public static MixingTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F530B0 Offset: 0x1F516B0 VA: 0x181F530B0
	public static MixingTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F539B0 Offset: 0x1F51FB0 VA: 0x181F539B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F540A0 Offset: 0x1F526A0 VA: 0x181F540A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F540C0 Offset: 0x1F526C0 VA: 0x181F540C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MixingTable previous) { }

	// RVA: 0x1F53B30 Offset: 0x1F52130 VA: 0x181F53B30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F53320 Offset: 0x1F51920 VA: 0x181F53320
	public static MixingTable Deserialize(byte[] buffer, MixingTable instance, bool isDelta = False) { }

	// RVA: 0x1F53570 Offset: 0x1F51B70 VA: 0x181F53570
	public static MixingTable Deserialize(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F52B20 Offset: 0x1F51120 VA: 0x181F52B20
	public static MixingTable DeserializeLengthDelimited(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F52DF0 Offset: 0x1F513F0 VA: 0x181F52DF0
	public static MixingTable DeserializeLength(Stream stream, int length, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F53C50 Offset: 0x1F52250 VA: 0x181F53C50
	public static void SerializeDelta(Stream stream, MixingTable instance, MixingTable previous) { }

	// RVA: 0x1F53F90 Offset: 0x1F52590 VA: 0x181F53F90
	public static void Serialize(Stream stream, MixingTable instance) { }

	// RVA: 0x1F54090 Offset: 0x1F52690 VA: 0x181F54090
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F540A0 Offset: 0x1F526A0 VA: 0x181F540A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F53E80 Offset: 0x1F52480 VA: 0x181F53E80
	public static byte[] SerializeToBytes(MixingTable instance) { }

	// RVA: 0x1F53DD0 Offset: 0x1F523D0 VA: 0x181F53DD0
	public static void SerializeLengthDelimited(Stream stream, MixingTable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class MixingTable : StorageContainer // TypeDefIndex: 8411
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x3D0
	private Option __menuOption_Menu_TurnOn; // 0x428
	public GameObject Particles; // 0x480
	public RecipeList Recipes; // 0x488
	public bool OnlyAcceptValidIngredients; // 0x490
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <RemainingMixTime>k__BackingField; // 0x494
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <TotalMixTime>k__BackingField; // 0x498
	private float lastTickTimestamp; // 0x49C
	private List<Item> inventoryItems; // 0x4A0

	// Properties
	public override bool HasMenuOptions { get; }
	public float RemainingMixTime { get; set; }
	public float TotalMixTime { get; set; }
	public float ClientEstimatedRemainingMixTime { get; }
	public float ProgressFraction { get; }

	// Methods

	// RVA: 0x76BA80 Offset: 0x76A080 VA: 0x18076BA80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x76C670 Offset: 0x76AC70 VA: 0x18076C670 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x76C450 Offset: 0x76AA50 VA: 0x18076C450 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C8A0 Offset: 0x76AEA0 VA: 0x18076C8A0
	public float get_RemainingMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C8C0 Offset: 0x76AEC0 VA: 0x18076C8C0
	private void set_RemainingMixTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C8B0 Offset: 0x76AEB0 VA: 0x18076C8B0
	public float get_TotalMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C8D0 Offset: 0x76AED0 VA: 0x18076C8D0
	private void set_TotalMixTime(float value) { }

	// RVA: 0x76C5D0 Offset: 0x76ABD0 VA: 0x18076C5D0
	public float get_ClientEstimatedRemainingMixTime() { }

	// RVA: 0x76C7C0 Offset: 0x76ADC0 VA: 0x18076C7C0
	public float get_ProgressFraction() { }

	[BaseEntity.Menu] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.Description] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.Icon] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	// RVA: 0x76C400 Offset: 0x76AA00 VA: 0x18076C400
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x76C340 Offset: 0x76A940 VA: 0x18076C340
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.Description] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.Icon] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	// RVA: 0x76C2F0 Offset: 0x76A8F0 VA: 0x18076C2F0
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x76C230 Offset: 0x76A830 VA: 0x18076C230
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x76BA00 Offset: 0x76A000 VA: 0x18076BA00
	private int GetItemWaterAmount(Item item) { }

	// RVA: 0x76C120 Offset: 0x76A720 VA: 0x18076C120 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x76BFD0 Offset: 0x76A5D0 VA: 0x18076BFD0
	public List<Item> GetOrderedContainerItems(ItemContainer container, out bool itemsAreContiguous) { }

	// RVA: 0x76C540 Offset: 0x76AB40 VA: 0x18076C540
	public void .ctor() { }

}

