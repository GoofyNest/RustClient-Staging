public class MixingTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6386
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float totalMixTime; // 0x14
	public float remainingMixTime; // 0x18

	// Methods

	// RVA: 0x1F53E90 Offset: 0x1F52490 VA: 0x181F53E90
	public static void ResetToPool(MixingTable instance) { }

	// RVA: 0x1F53E10 Offset: 0x1F52410 VA: 0x181F53E10
	public void ResetToPool() { }

	// RVA: 0x1F53B70 Offset: 0x1F52170 VA: 0x181F53B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(MixingTable instance) { }

	// RVA: 0x1F52D70 Offset: 0x1F51370 VA: 0x181F52D70
	public MixingTable Copy() { }

	// RVA: 0x1F539B0 Offset: 0x1F51FB0 VA: 0x181F539B0
	public static MixingTable Deserialize(Stream stream) { }

	// RVA: 0x1F53030 Offset: 0x1F51630 VA: 0x181F53030
	public static MixingTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F532E0 Offset: 0x1F518E0 VA: 0x181F532E0
	public static MixingTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F53370 Offset: 0x1F51970 VA: 0x181F53370
	public static MixingTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F53C70 Offset: 0x1F52270 VA: 0x181F53C70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F54360 Offset: 0x1F52960 VA: 0x181F54360 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F54380 Offset: 0x1F52980 VA: 0x181F54380 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MixingTable previous) { }

	// RVA: 0x1F53DF0 Offset: 0x1F523F0 VA: 0x181F53DF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F535E0 Offset: 0x1F51BE0 VA: 0x181F535E0
	public static MixingTable Deserialize(byte[] buffer, MixingTable instance, bool isDelta = False) { }

	// RVA: 0x1F53830 Offset: 0x1F51E30 VA: 0x181F53830
	public static MixingTable Deserialize(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F52DE0 Offset: 0x1F513E0 VA: 0x181F52DE0
	public static MixingTable DeserializeLengthDelimited(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F530B0 Offset: 0x1F516B0 VA: 0x181F530B0
	public static MixingTable DeserializeLength(Stream stream, int length, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F53F10 Offset: 0x1F52510 VA: 0x181F53F10
	public static void SerializeDelta(Stream stream, MixingTable instance, MixingTable previous) { }

	// RVA: 0x1F54250 Offset: 0x1F52850 VA: 0x181F54250
	public static void Serialize(Stream stream, MixingTable instance) { }

	// RVA: 0x1F54350 Offset: 0x1F52950 VA: 0x181F54350
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F54360 Offset: 0x1F52960 VA: 0x181F54360
	public void ToProto(Stream stream) { }

	// RVA: 0x1F54140 Offset: 0x1F52740 VA: 0x181F54140
	public static byte[] SerializeToBytes(MixingTable instance) { }

	// RVA: 0x1F54090 Offset: 0x1F52690 VA: 0x181F54090
	public static void SerializeLengthDelimited(Stream stream, MixingTable instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x76BB90 Offset: 0x76A190 VA: 0x18076BB90 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x76C780 Offset: 0x76AD80 VA: 0x18076C780 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x76C560 Offset: 0x76AB60 VA: 0x18076C560 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C9B0 Offset: 0x76AFB0 VA: 0x18076C9B0
	public float get_RemainingMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C9D0 Offset: 0x76AFD0 VA: 0x18076C9D0
	private void set_RemainingMixTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C9C0 Offset: 0x76AFC0 VA: 0x18076C9C0
	public float get_TotalMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C9E0 Offset: 0x76AFE0 VA: 0x18076C9E0
	private void set_TotalMixTime(float value) { }

	// RVA: 0x76C6E0 Offset: 0x76ACE0 VA: 0x18076C6E0
	public float get_ClientEstimatedRemainingMixTime() { }

	// RVA: 0x76C8D0 Offset: 0x76AED0 VA: 0x18076C8D0
	public float get_ProgressFraction() { }

	[BaseEntity.Menu] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.Description] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.Icon] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	// RVA: 0x76C510 Offset: 0x76AB10 VA: 0x18076C510
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x76C450 Offset: 0x76AA50 VA: 0x18076C450
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.Description] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.Icon] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	// RVA: 0x76C400 Offset: 0x76AA00 VA: 0x18076C400
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x76C340 Offset: 0x76A940 VA: 0x18076C340
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x76BB10 Offset: 0x76A110 VA: 0x18076BB10
	private int GetItemWaterAmount(Item item) { }

	// RVA: 0x76C230 Offset: 0x76A830 VA: 0x18076C230 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x76C0E0 Offset: 0x76A6E0 VA: 0x18076C0E0
	public List<Item> GetOrderedContainerItems(ItemContainer container, out bool itemsAreContiguous) { }

	// RVA: 0x76C650 Offset: 0x76AC50 VA: 0x18076C650
	public void .ctor() { }

}

