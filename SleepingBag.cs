public class SleepingBag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6316
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public ulong deployerID; // 0x20

	// Methods

	// RVA: 0x1DAE380 Offset: 0x1DAC980 VA: 0x181DAE380
	public static void ResetToPool(SleepingBag instance) { }

	// RVA: 0x1DAE2D0 Offset: 0x1DAC8D0 VA: 0x181DAE2D0
	public void ResetToPool() { }

	// RVA: 0x1DAE170 Offset: 0x1DAC770 VA: 0x181DAE170 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAD430 Offset: 0x1DABA30 VA: 0x181DAD430
	public void CopyTo(SleepingBag instance) { }

	// RVA: 0x1DAD470 Offset: 0x1DABA70 VA: 0x181DAD470
	public SleepingBag Copy() { }

	// RVA: 0x1DADAB0 Offset: 0x1DAC0B0 VA: 0x181DADAB0
	public static SleepingBag Deserialize(Stream stream) { }

	// RVA: 0x1DAD500 Offset: 0x1DABB00 VA: 0x181DAD500
	public static SleepingBag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DADA20 Offset: 0x1DAC020 VA: 0x181DADA20
	public static SleepingBag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DADEF0 Offset: 0x1DAC4F0 VA: 0x181DADEF0
	public static SleepingBag Deserialize(byte[] buffer) { }

	// RVA: 0x1DAE290 Offset: 0x1DAC890 VA: 0x181DAE290
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DAE8E0 Offset: 0x1DACEE0 VA: 0x181DAE8E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DAE900 Offset: 0x1DACF00 VA: 0x181DAE900 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBag previous) { }

	// RVA: 0x1DAE2B0 Offset: 0x1DAC8B0 VA: 0x181DAE2B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DADDF0 Offset: 0x1DAC3F0 VA: 0x181DADDF0
	public static SleepingBag Deserialize(byte[] buffer, SleepingBag instance, bool isDelta = False) { }

	// RVA: 0x1DADC70 Offset: 0x1DAC270 VA: 0x181DADC70
	public static SleepingBag Deserialize(Stream stream, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DAD580 Offset: 0x1DABB80 VA: 0x181DAD580
	public static SleepingBag DeserializeLengthDelimited(Stream stream, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DAD7E0 Offset: 0x1DABDE0 VA: 0x181DAD7E0
	public static SleepingBag DeserializeLength(Stream stream, int length, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DAE430 Offset: 0x1DACA30 VA: 0x181DAE430
	public static void SerializeDelta(Stream stream, SleepingBag instance, SleepingBag previous) { }

	// RVA: 0x1DAE780 Offset: 0x1DACD80 VA: 0x181DAE780
	public static void Serialize(Stream stream, SleepingBag instance) { }

	// RVA: 0x1DAE8D0 Offset: 0x1DACED0 VA: 0x181DAE8D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DAE8E0 Offset: 0x1DACEE0 VA: 0x181DAE8E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DAE670 Offset: 0x1DACC70 VA: 0x181DAE670
	public static byte[] SerializeToBytes(SleepingBag instance) { }

	// RVA: 0x1DAE5C0 Offset: 0x1DACBC0 VA: 0x181DAE5C0
	public static void SerializeLengthDelimited(Stream stream, SleepingBag instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x5A8D60 Offset: 0x5A7360 VA: 0x1805A8D60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5A9F10 Offset: 0x5A8510 VA: 0x1805A9F10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5A9DD0 Offset: 0x5A83D0 VA: 0x1805A9DD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40
	public bool IsPublic() { }

	// RVA: 0x5A9960 Offset: 0x5A7F60 VA: 0x1805A9960 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5A8CA0 Offset: 0x5A72A0 VA: 0x1805A8CA0
	public void ClientRename(string newName) { }

	[BaseEntity.Menu] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Icon] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.Description] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	[BaseEntity.Menu.ShowIf] // RVA: 0x84650 Offset: 0x83A50 VA: 0x180084650
	// RVA: 0x5A9B00 Offset: 0x5A8100 VA: 0x1805A9B00
	public void Menu_CloseDoor(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 145
	public virtual bool CanRename_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Icon] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.Description] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	[BaseEntity.Menu.ShowIf] // RVA: 0x84970 Offset: 0x83D70 VA: 0x180084970
	// RVA: 0x5A9A10 Offset: 0x5A8010 VA: 0x1805A9A10
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0x5A99E0 Offset: 0x5A7FE0 VA: 0x1805A99E0 Slot: 146
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	[BaseEntity.Menu.Icon] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	[BaseEntity.Menu.Description] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	[BaseEntity.Menu.ShowIf] // RVA: 0x84C00 Offset: 0x84000 VA: 0x180084C00
	// RVA: 0x5A9D80 Offset: 0x5A8380 VA: 0x1805A9D80
	public void Menu_MakePublic(BasePlayer player) { }

	// RVA: 0x5A9D20 Offset: 0x5A8320 VA: 0x1805A9D20
	public bool Menu_MakePublic_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	[BaseEntity.Menu.Icon] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	[BaseEntity.Menu.Description] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x850E0 Offset: 0x844E0 VA: 0x1800850E0
	// RVA: 0x5A9CD0 Offset: 0x5A82D0 VA: 0x1805A9CD0
	public void Menu_MakePrivate(BasePlayer player) { }

	// RVA: 0x5A9C50 Offset: 0x5A8250 VA: 0x1805A9C50 Slot: 147
	public virtual bool Menu_MakePrivate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Icon] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.Description] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x854E0 Offset: 0x848E0 VA: 0x1800854E0
	// RVA: 0x5A9C10 Offset: 0x5A8210 VA: 0x1805A9C10
	public void Menu_MakeBed(BasePlayer player) { }

	// RVA: 0x5A9BB0 Offset: 0x5A81B0 VA: 0x1805A9BB0 Slot: 148
	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5A8CF0 Offset: 0x5A72F0 VA: 0x1805A8CF0 Slot: 64
	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x5A8C50 Offset: 0x5A7250 VA: 0x1805A8C50 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x5A7D10 Offset: 0x5A6310 VA: 0x1805A7D10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5A9EC0 Offset: 0x5A84C0 VA: 0x1805A9EC0
	private void <Menu_AssignToFriend>b__24_0(ulong id, string steamName) { }

}

