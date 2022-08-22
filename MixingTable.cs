public class MixingTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6386
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float totalMixTime; // 0x14
	public float remainingMixTime; // 0x18

	// Methods

	// RVA: 0x1F546B0 Offset: 0x1F52CB0 VA: 0x181F546B0
	public static void ResetToPool(MixingTable instance) { }

	// RVA: 0x1F54630 Offset: 0x1F52C30 VA: 0x181F54630
	public void ResetToPool() { }

	// RVA: 0x1F54390 Offset: 0x1F52990 VA: 0x181F54390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(MixingTable instance) { }

	// RVA: 0x1F53590 Offset: 0x1F51B90 VA: 0x181F53590
	public MixingTable Copy() { }

	// RVA: 0x1F541D0 Offset: 0x1F527D0 VA: 0x181F541D0
	public static MixingTable Deserialize(Stream stream) { }

	// RVA: 0x1F53850 Offset: 0x1F51E50 VA: 0x181F53850
	public static MixingTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F53B00 Offset: 0x1F52100 VA: 0x181F53B00
	public static MixingTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F53B90 Offset: 0x1F52190 VA: 0x181F53B90
	public static MixingTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F54490 Offset: 0x1F52A90 VA: 0x181F54490
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F54B80 Offset: 0x1F53180 VA: 0x181F54B80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F54BA0 Offset: 0x1F531A0 VA: 0x181F54BA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MixingTable previous) { }

	// RVA: 0x1F54610 Offset: 0x1F52C10 VA: 0x181F54610 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F53E00 Offset: 0x1F52400 VA: 0x181F53E00
	public static MixingTable Deserialize(byte[] buffer, MixingTable instance, bool isDelta = False) { }

	// RVA: 0x1F54050 Offset: 0x1F52650 VA: 0x181F54050
	public static MixingTable Deserialize(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F53600 Offset: 0x1F51C00 VA: 0x181F53600
	public static MixingTable DeserializeLengthDelimited(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F538D0 Offset: 0x1F51ED0 VA: 0x181F538D0
	public static MixingTable DeserializeLength(Stream stream, int length, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F54730 Offset: 0x1F52D30 VA: 0x181F54730
	public static void SerializeDelta(Stream stream, MixingTable instance, MixingTable previous) { }

	// RVA: 0x1F54A70 Offset: 0x1F53070 VA: 0x181F54A70
	public static void Serialize(Stream stream, MixingTable instance) { }

	// RVA: 0x1F54B70 Offset: 0x1F53170 VA: 0x181F54B70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F54B80 Offset: 0x1F53180 VA: 0x181F54B80
	public void ToProto(Stream stream) { }

	// RVA: 0x1F54960 Offset: 0x1F52F60 VA: 0x181F54960
	public static byte[] SerializeToBytes(MixingTable instance) { }

	// RVA: 0x1F548B0 Offset: 0x1F52EB0 VA: 0x181F548B0
	public static void SerializeLengthDelimited(Stream stream, MixingTable instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x76BAE0 Offset: 0x76A0E0 VA: 0x18076BAE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x76C6D0 Offset: 0x76ACD0 VA: 0x18076C6D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x76C4B0 Offset: 0x76AAB0 VA: 0x18076C4B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C900 Offset: 0x76AF00 VA: 0x18076C900
	public float get_RemainingMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C920 Offset: 0x76AF20 VA: 0x18076C920
	private void set_RemainingMixTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C910 Offset: 0x76AF10 VA: 0x18076C910
	public float get_TotalMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x76C930 Offset: 0x76AF30 VA: 0x18076C930
	private void set_TotalMixTime(float value) { }

	// RVA: 0x76C630 Offset: 0x76AC30 VA: 0x18076C630
	public float get_ClientEstimatedRemainingMixTime() { }

	// RVA: 0x76C820 Offset: 0x76AE20 VA: 0x18076C820
	public float get_ProgressFraction() { }

	[BaseEntity.Menu] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.Description] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.Icon] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE040 Offset: 0xED440 VA: 0x1800EE040
	// RVA: 0x76C460 Offset: 0x76AA60 VA: 0x18076C460
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x76C3A0 Offset: 0x76A9A0 VA: 0x18076C3A0
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.Description] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.Icon] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE530 Offset: 0xED930 VA: 0x1800EE530
	// RVA: 0x76C350 Offset: 0x76A950 VA: 0x18076C350
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x76C290 Offset: 0x76A890 VA: 0x18076C290
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x76BA60 Offset: 0x76A060 VA: 0x18076BA60
	private int GetItemWaterAmount(Item item) { }

	// RVA: 0x76C180 Offset: 0x76A780 VA: 0x18076C180 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x76C030 Offset: 0x76A630 VA: 0x18076C030
	public List<Item> GetOrderedContainerItems(ItemContainer container, out bool itemsAreContiguous) { }

	// RVA: 0x76C5A0 Offset: 0x76ABA0 VA: 0x18076C5A0
	public void .ctor() { }

}

