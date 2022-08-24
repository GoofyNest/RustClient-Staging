public class MixingTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6386
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float totalMixTime; // 0x14
	public float remainingMixTime; // 0x18


	public static void ResetToPool(MixingTable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MixingTable instance) { }

	public MixingTable Copy() { }

	public static MixingTable Deserialize(Stream stream) { }

	public static MixingTable DeserializeLengthDelimited(Stream stream) { }

	public static MixingTable DeserializeLength(Stream stream, int length) { }

	public static MixingTable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MixingTable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MixingTable Deserialize(byte[] buffer, MixingTable instance, bool isDelta = False) { }

	public static MixingTable Deserialize(Stream stream, MixingTable instance, bool isDelta) { }

	public static MixingTable DeserializeLengthDelimited(Stream stream, MixingTable instance, bool isDelta) { }

	public static MixingTable DeserializeLength(Stream stream, int length, MixingTable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MixingTable instance, MixingTable previous) { }

	public static void Serialize(Stream stream, MixingTable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MixingTable instance) { }

	public static void SerializeLengthDelimited(Stream stream, MixingTable instance) { }

	public void .ctor() { }

}

public class MixingTable : StorageContainer // TypeDefIndex: 8411
{	private Option __menuOption_Menu_TurnOff; // 0x3D0
	private Option __menuOption_Menu_TurnOn; // 0x428
	public GameObject Particles; // 0x480
	public RecipeList Recipes; // 0x488
	public bool OnlyAcceptValidIngredients; // 0x490
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <RemainingMixTime>k__BackingField; // 0x494
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <TotalMixTime>k__BackingField; // 0x498
	private float lastTickTimestamp; // 0x49C
	private List<Item> inventoryItems; // 0x4A0

	public override bool HasMenuOptions { get; }
	public float RemainingMixTime { get; set; }
	public float TotalMixTime { get; set; }
	public float ClientEstimatedRemainingMixTime { get; }
	public float ProgressFraction { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_RemainingMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_RemainingMixTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_TotalMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_TotalMixTime(float value) { }

	public float get_ClientEstimatedRemainingMixTime() { }

	public float get_ProgressFraction() { }

	[BaseEntity.Menu] // RVA: 0xEE0F0 Offset: 0xED4F0 VA: 0x1800EE0F0
	[BaseEntity.Menu.Description] // RVA: 0xEE0F0 Offset: 0xED4F0 VA: 0x1800EE0F0
	[BaseEntity.Menu.Icon] // RVA: 0xEE0F0 Offset: 0xED4F0 VA: 0x1800EE0F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE0F0 Offset: 0xED4F0 VA: 0x1800EE0F0
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xEE520 Offset: 0xED920 VA: 0x1800EE520
	[BaseEntity.Menu.Description] // RVA: 0xEE520 Offset: 0xED920 VA: 0x1800EE520
	[BaseEntity.Menu.Icon] // RVA: 0xEE520 Offset: 0xED920 VA: 0x1800EE520
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE520 Offset: 0xED920 VA: 0x1800EE520
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	private int GetItemWaterAmount(Item item) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public List<Item> GetOrderedContainerItems(ItemContainer container, out bool itemsAreContiguous) { }

	public void .ctor() { }

}

