public class SleepingBag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6316
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public ulong deployerID; // 0x20

	// Methods

	// RVA: 0x1DAEE30 Offset: 0x1DAD430 VA: 0x181DAEE30
	public static void ResetToPool(SleepingBag instance) { }

	// RVA: 0x1DAED80 Offset: 0x1DAD380 VA: 0x181DAED80
	public void ResetToPool() { }

	// RVA: 0x1DAEC20 Offset: 0x1DAD220 VA: 0x181DAEC20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DADEE0 Offset: 0x1DAC4E0 VA: 0x181DADEE0
	public void CopyTo(SleepingBag instance) { }

	// RVA: 0x1DADF20 Offset: 0x1DAC520 VA: 0x181DADF20
	public SleepingBag Copy() { }

	// RVA: 0x1DAE560 Offset: 0x1DACB60 VA: 0x181DAE560
	public static SleepingBag Deserialize(Stream stream) { }

	// RVA: 0x1DADFB0 Offset: 0x1DAC5B0 VA: 0x181DADFB0
	public static SleepingBag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DAE4D0 Offset: 0x1DACAD0 VA: 0x181DAE4D0
	public static SleepingBag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DAE9A0 Offset: 0x1DACFA0 VA: 0x181DAE9A0
	public static SleepingBag Deserialize(byte[] buffer) { }

	// RVA: 0x1DAED40 Offset: 0x1DAD340 VA: 0x181DAED40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DAF390 Offset: 0x1DAD990 VA: 0x181DAF390 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DAF3B0 Offset: 0x1DAD9B0 VA: 0x181DAF3B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBag previous) { }

	// RVA: 0x1DAED60 Offset: 0x1DAD360 VA: 0x181DAED60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DAE8A0 Offset: 0x1DACEA0 VA: 0x181DAE8A0
	public static SleepingBag Deserialize(byte[] buffer, SleepingBag instance, bool isDelta = False) { }

	// RVA: 0x1DAE720 Offset: 0x1DACD20 VA: 0x181DAE720
	public static SleepingBag Deserialize(Stream stream, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DAE030 Offset: 0x1DAC630 VA: 0x181DAE030
	public static SleepingBag DeserializeLengthDelimited(Stream stream, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DAE290 Offset: 0x1DAC890 VA: 0x181DAE290
	public static SleepingBag DeserializeLength(Stream stream, int length, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DAEEE0 Offset: 0x1DAD4E0 VA: 0x181DAEEE0
	public static void SerializeDelta(Stream stream, SleepingBag instance, SleepingBag previous) { }

	// RVA: 0x1DAF230 Offset: 0x1DAD830 VA: 0x181DAF230
	public static void Serialize(Stream stream, SleepingBag instance) { }

	// RVA: 0x1DAF380 Offset: 0x1DAD980 VA: 0x181DAF380
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DAF390 Offset: 0x1DAD990 VA: 0x181DAF390
	public void ToProto(Stream stream) { }

	// RVA: 0x1DAF120 Offset: 0x1DAD720 VA: 0x181DAF120
	public static byte[] SerializeToBytes(SleepingBag instance) { }

	// RVA: 0x1DAF070 Offset: 0x1DAD670 VA: 0x181DAF070
	public static void SerializeLengthDelimited(Stream stream, SleepingBag instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class SleepingBag : DecayEntity // TypeDefIndex: 8446
{	// Fields
	private Option __menuOption_Menu_AssignToFriend; // 0x258
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5A8CF0 Offset: 0x5A72F0 VA: 0x1805A8CF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5A9EA0 Offset: 0x5A84A0 VA: 0x1805A9EA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5A9D60 Offset: 0x5A8360 VA: 0x1805A9D60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x50CBD0 Offset: 0x50B1D0 VA: 0x18050CBD0
	public bool IsPublic() { }

	// RVA: 0x5A98F0 Offset: 0x5A7EF0 VA: 0x1805A98F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5A8C30 Offset: 0x5A7230 VA: 0x1805A8C30
	public void ClientRename(string newName) { }

	[BaseEntity.Menu] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Icon] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Description] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.ShowIf] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	// RVA: 0x5A9A90 Offset: 0x5A8090 VA: 0x1805A9A90
	public void Menu_CloseDoor(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 145
	public virtual bool CanRename_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Icon] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Description] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.ShowIf] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	// RVA: 0x5A99A0 Offset: 0x5A7FA0 VA: 0x1805A99A0
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0x5A9970 Offset: 0x5A7F70 VA: 0x1805A9970 Slot: 146
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	[BaseEntity.Menu.Icon] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	[BaseEntity.Menu.Description] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	[BaseEntity.Menu.ShowIf] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	// RVA: 0x5A9D10 Offset: 0x5A8310 VA: 0x1805A9D10
	public void Menu_MakePublic(BasePlayer player) { }

	// RVA: 0x5A9CB0 Offset: 0x5A82B0 VA: 0x1805A9CB0
	public bool Menu_MakePublic_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	[BaseEntity.Menu.Icon] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	[BaseEntity.Menu.Description] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	// RVA: 0x5A9C60 Offset: 0x5A8260 VA: 0x1805A9C60
	public void Menu_MakePrivate(BasePlayer player) { }

	// RVA: 0x5A9BE0 Offset: 0x5A81E0 VA: 0x1805A9BE0 Slot: 147
	public virtual bool Menu_MakePrivate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Icon] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Description] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	// RVA: 0x5A9BA0 Offset: 0x5A81A0 VA: 0x1805A9BA0
	public void Menu_MakeBed(BasePlayer player) { }

	// RVA: 0x5A9B40 Offset: 0x5A8140 VA: 0x1805A9B40 Slot: 148
	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5A8C80 Offset: 0x5A7280 VA: 0x1805A8C80 Slot: 64
	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x5A8BE0 Offset: 0x5A71E0 VA: 0x1805A8BE0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x5A7CA0 Offset: 0x5A62A0 VA: 0x1805A7CA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5A9E50 Offset: 0x5A8450 VA: 0x1805A9E50
	private void <Menu_AssignToFriend>b__24_0(ulong id, string steamName) { }

}

