public class SleepingBag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6316
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public ulong deployerID; // 0x20


	public static void ResetToPool(SleepingBag instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SleepingBag instance) { }

	public SleepingBag Copy() { }

	public static SleepingBag Deserialize(Stream stream) { }

	public static SleepingBag DeserializeLengthDelimited(Stream stream) { }

	public static SleepingBag DeserializeLength(Stream stream, int length) { }

	public static SleepingBag Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SleepingBag previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SleepingBag Deserialize(byte[] buffer, SleepingBag instance, bool isDelta = False) { }

	public static SleepingBag Deserialize(Stream stream, SleepingBag instance, bool isDelta) { }

	public static SleepingBag DeserializeLengthDelimited(Stream stream, SleepingBag instance, bool isDelta) { }

	public static SleepingBag DeserializeLength(Stream stream, int length, SleepingBag instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SleepingBag instance, SleepingBag previous) { }

	public static void Serialize(Stream stream, SleepingBag instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SleepingBag instance) { }

	public static void SerializeLengthDelimited(Stream stream, SleepingBag instance) { }

	public void .ctor() { }

}

public class SleepingBag : DecayEntity // TypeDefIndex: 8446
{	private Option __menuOption_Menu_AssignToFriend; // 0x258
	private Option __menuOption_Menu_CloseDoor; // 0x2B0
	private Option __menuOption_Menu_MakeBed; // 0x308
	private Option __menuOption_Menu_MakePrivate; // 0x360
	private Option __menuOption_Menu_MakePublic; // 0x3B8
	public ulong deployerUserID; // 0x410
	public GameObject renameDialog; // 0x418
	public GameObject assignDialog; // 0x420
	public float secondsBetweenReuses; // 0x428
	public string niceName; // 0x430
	public Vector3 spawnOffset; // 0x438
	public RespawnInformation.SpawnOptions.RespawnType RespawnType; // 0x444
	public bool isStatic; // 0x448
	public bool canBePublic; // 0x449
	public const BaseEntity.Flags IsPublicFlag = 512;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPublic() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void ClientRename(string newName) { }

	[BaseEntity.Menu] // RVA: 0x846C0 Offset: 0x83AC0 VA: 0x1800846C0
	[BaseEntity.Menu.Icon] // RVA: 0x846C0 Offset: 0x83AC0 VA: 0x1800846C0
	[BaseEntity.Menu.Description] // RVA: 0x846C0 Offset: 0x83AC0 VA: 0x1800846C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x846C0 Offset: 0x83AC0 VA: 0x1800846C0
	public void Menu_CloseDoor(BasePlayer player) { }

	public virtual bool CanRename_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84A90 Offset: 0x83E90 VA: 0x180084A90
	[BaseEntity.Menu.Icon] // RVA: 0x84A90 Offset: 0x83E90 VA: 0x180084A90
	[BaseEntity.Menu.Description] // RVA: 0x84A90 Offset: 0x83E90 VA: 0x180084A90
	[BaseEntity.Menu.ShowIf] // RVA: 0x84A90 Offset: 0x83E90 VA: 0x180084A90
	public void Menu_AssignToFriend(BasePlayer player) { }

	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84DA0 Offset: 0x841A0 VA: 0x180084DA0
	[BaseEntity.Menu.Icon] // RVA: 0x84DA0 Offset: 0x841A0 VA: 0x180084DA0
	[BaseEntity.Menu.Description] // RVA: 0x84DA0 Offset: 0x841A0 VA: 0x180084DA0
	[BaseEntity.Menu.ShowIf] // RVA: 0x84DA0 Offset: 0x841A0 VA: 0x180084DA0
	public void Menu_MakePublic(BasePlayer player) { }

	public bool Menu_MakePublic_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x85190 Offset: 0x84590 VA: 0x180085190
	[BaseEntity.Menu.Icon] // RVA: 0x85190 Offset: 0x84590 VA: 0x180085190
	[BaseEntity.Menu.Description] // RVA: 0x85190 Offset: 0x84590 VA: 0x180085190
	[BaseEntity.Menu.ShowIf] // RVA: 0x85190 Offset: 0x84590 VA: 0x180085190
	public void Menu_MakePrivate(BasePlayer player) { }

	public virtual bool Menu_MakePrivate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x85510 Offset: 0x84910 VA: 0x180085510
	[BaseEntity.Menu.Icon] // RVA: 0x85510 Offset: 0x84910 VA: 0x180085510
	[BaseEntity.Menu.Description] // RVA: 0x85510 Offset: 0x84910 VA: 0x180085510
	[BaseEntity.Menu.ShowIf] // RVA: 0x85510 Offset: 0x84910 VA: 0x180085510
	public void Menu_MakeBed(BasePlayer player) { }

	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	public override bool CanPickup(BasePlayer player) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void <Menu_AssignToFriend>b__24_0(ulong id, string steamName) { }

}

