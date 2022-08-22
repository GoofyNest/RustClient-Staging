public class KeyLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6305
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int code; // 0x14

	// Methods

	// RVA: 0x1F1CD80 Offset: 0x1F1B380 VA: 0x181F1CD80
	public static void ResetToPool(KeyLock instance) { }

	// RVA: 0x1F1CD00 Offset: 0x1F1B300 VA: 0x181F1CD00
	public void ResetToPool() { }

	// RVA: 0x1F1CBD0 Offset: 0x1F1B1D0 VA: 0x181F1CBD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(KeyLock instance) { }

	// RVA: 0x1F1C250 Offset: 0x1F1A850 VA: 0x181F1C250
	public KeyLock Copy() { }

	// RVA: 0x1F1C7F0 Offset: 0x1F1ADF0 VA: 0x181F1C7F0
	public static KeyLock Deserialize(Stream stream) { }

	// RVA: 0x1F1C2C0 Offset: 0x1F1A8C0 VA: 0x181F1C2C0
	public static KeyLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1C560 Offset: 0x1F1AB60 VA: 0x181F1C560
	public static KeyLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1C970 Offset: 0x1F1AF70 VA: 0x181F1C970
	public static KeyLock Deserialize(byte[] buffer) { }

	// RVA: 0x1F1CCC0 Offset: 0x1F1B2C0 VA: 0x181F1CCC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1D250 Offset: 0x1F1B850 VA: 0x181F1D250 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1D320 Offset: 0x1F1B920 VA: 0x181F1D320 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, KeyLock previous) { }

	// RVA: 0x1F1CCE0 Offset: 0x1F1B2E0 VA: 0x181F1CCE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1C870 Offset: 0x1F1AE70 VA: 0x181F1C870
	public static KeyLock Deserialize(byte[] buffer, KeyLock instance, bool isDelta = False) { }

	// RVA: 0x1F1CA90 Offset: 0x1F1B090 VA: 0x181F1CA90
	public static KeyLock Deserialize(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1C340 Offset: 0x1F1A940 VA: 0x181F1C340
	public static KeyLock DeserializeLengthDelimited(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1C5F0 Offset: 0x1F1ABF0 VA: 0x181F1C5F0
	public static KeyLock DeserializeLength(Stream stream, int length, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1CE00 Offset: 0x1F1B400 VA: 0x181F1CE00
	public static void SerializeDelta(Stream stream, KeyLock instance, KeyLock previous) { }

	// RVA: 0x1F1D170 Offset: 0x1F1B770 VA: 0x181F1D170
	public static void Serialize(Stream stream, KeyLock instance) { }

	// RVA: 0x1F1D240 Offset: 0x1F1B840 VA: 0x181F1D240
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1D250 Offset: 0x1F1B850 VA: 0x181F1D250
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1CFC0 Offset: 0x1F1B5C0 VA: 0x181F1CFC0
	public static byte[] SerializeToBytes(KeyLock instance) { }

	// RVA: 0x1F1CF10 Offset: 0x1F1B510 VA: 0x181F1CF10
	public static void SerializeLengthDelimited(Stream stream, KeyLock instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class KeyLock : BaseLock // TypeDefIndex: 8401
{	// Fields
	private Option __menuOption_Menu_CreateKey; // 0x1C8
	private Option __menuOption_Menu_Lock; // 0x220
	private Option __menuOption_Menu_Unlock; // 0x278
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition keyItemType; // 0x2D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x680580 Offset: 0x67EB80 VA: 0x180680580 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x680F00 Offset: 0x67F500 VA: 0x180680F00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	[BaseEntity.Menu.Description] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	[BaseEntity.Menu.Icon] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	// RVA: 0x680EC0 Offset: 0x67F4C0 VA: 0x180680EC0
	public void Menu_Unlock(BasePlayer player) { }

	// RVA: 0x680EB0 Offset: 0x67F4B0 VA: 0x180680EB0
	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	[BaseEntity.Menu.Description] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	[BaseEntity.Menu.Icon] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	// RVA: 0x680E70 Offset: 0x67F470 VA: 0x180680E70
	public void Menu_Lock(BasePlayer player) { }

	// RVA: 0x680E50 Offset: 0x67F450 VA: 0x180680E50
	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9DB0 Offset: 0xE91B0 VA: 0x1800E9DB0
	[BaseEntity.Menu.Description] // RVA: 0xE9DB0 Offset: 0xE91B0 VA: 0x1800E9DB0
	[BaseEntity.Menu.Icon] // RVA: 0xE9DB0 Offset: 0xE91B0 VA: 0x1800E9DB0
	// RVA: 0x680E10 Offset: 0x67F410 VA: 0x180680E10
	public void Menu_CreateKey(BasePlayer player) { }

	// RVA: 0x680D30 Offset: 0x67F330 VA: 0x180680D30
	public void Menu_CreateKey_Proxy(ref Option option) { }

	// RVA: 0x57B0C0 Offset: 0x5796C0 VA: 0x18057B0C0
	public void .ctor() { }

}

