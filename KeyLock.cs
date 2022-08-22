public class KeyLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6305
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int code; // 0x14

	// Methods

	// RVA: 0x1F1C2A0 Offset: 0x1F1A8A0 VA: 0x181F1C2A0
	public static void ResetToPool(KeyLock instance) { }

	// RVA: 0x1F1C220 Offset: 0x1F1A820 VA: 0x181F1C220
	public void ResetToPool() { }

	// RVA: 0x1F1C0F0 Offset: 0x1F1A6F0 VA: 0x181F1C0F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(KeyLock instance) { }

	// RVA: 0x1F1B770 Offset: 0x1F19D70 VA: 0x181F1B770
	public KeyLock Copy() { }

	// RVA: 0x1F1BD10 Offset: 0x1F1A310 VA: 0x181F1BD10
	public static KeyLock Deserialize(Stream stream) { }

	// RVA: 0x1F1B7E0 Offset: 0x1F19DE0 VA: 0x181F1B7E0
	public static KeyLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1BA80 Offset: 0x1F1A080 VA: 0x181F1BA80
	public static KeyLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1BE90 Offset: 0x1F1A490 VA: 0x181F1BE90
	public static KeyLock Deserialize(byte[] buffer) { }

	// RVA: 0x1F1C1E0 Offset: 0x1F1A7E0 VA: 0x181F1C1E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1C770 Offset: 0x1F1AD70 VA: 0x181F1C770 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1C840 Offset: 0x1F1AE40 VA: 0x181F1C840 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, KeyLock previous) { }

	// RVA: 0x1F1C200 Offset: 0x1F1A800 VA: 0x181F1C200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1BD90 Offset: 0x1F1A390 VA: 0x181F1BD90
	public static KeyLock Deserialize(byte[] buffer, KeyLock instance, bool isDelta = False) { }

	// RVA: 0x1F1BFB0 Offset: 0x1F1A5B0 VA: 0x181F1BFB0
	public static KeyLock Deserialize(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1B860 Offset: 0x1F19E60 VA: 0x181F1B860
	public static KeyLock DeserializeLengthDelimited(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1BB10 Offset: 0x1F1A110 VA: 0x181F1BB10
	public static KeyLock DeserializeLength(Stream stream, int length, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1C320 Offset: 0x1F1A920 VA: 0x181F1C320
	public static void SerializeDelta(Stream stream, KeyLock instance, KeyLock previous) { }

	// RVA: 0x1F1C690 Offset: 0x1F1AC90 VA: 0x181F1C690
	public static void Serialize(Stream stream, KeyLock instance) { }

	// RVA: 0x1F1C760 Offset: 0x1F1AD60 VA: 0x181F1C760
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1C770 Offset: 0x1F1AD70 VA: 0x181F1C770
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1C4E0 Offset: 0x1F1AAE0 VA: 0x181F1C4E0
	public static byte[] SerializeToBytes(KeyLock instance) { }

	// RVA: 0x1F1C430 Offset: 0x1F1AA30 VA: 0x181F1C430
	public static void SerializeLengthDelimited(Stream stream, KeyLock instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x6805F0 Offset: 0x67EBF0 VA: 0x1806805F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x680F70 Offset: 0x67F570 VA: 0x180680F70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	[BaseEntity.Menu.Description] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	[BaseEntity.Menu.Icon] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	// RVA: 0x680F30 Offset: 0x67F530 VA: 0x180680F30
	public void Menu_Unlock(BasePlayer player) { }

	// RVA: 0x680F20 Offset: 0x67F520 VA: 0x180680F20
	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	[BaseEntity.Menu.Description] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	[BaseEntity.Menu.Icon] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9AA0 Offset: 0xE8EA0 VA: 0x1800E9AA0
	// RVA: 0x680EE0 Offset: 0x67F4E0 VA: 0x180680EE0
	public void Menu_Lock(BasePlayer player) { }

	// RVA: 0x680EC0 Offset: 0x67F4C0 VA: 0x180680EC0
	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9DB0 Offset: 0xE91B0 VA: 0x1800E9DB0
	[BaseEntity.Menu.Description] // RVA: 0xE9DB0 Offset: 0xE91B0 VA: 0x1800E9DB0
	[BaseEntity.Menu.Icon] // RVA: 0xE9DB0 Offset: 0xE91B0 VA: 0x1800E9DB0
	// RVA: 0x680E80 Offset: 0x67F480 VA: 0x180680E80
	public void Menu_CreateKey(BasePlayer player) { }

	// RVA: 0x680DA0 Offset: 0x67F3A0 VA: 0x180680DA0
	public void Menu_CreateKey_Proxy(ref Option option) { }

	// RVA: 0x57B130 Offset: 0x579730 VA: 0x18057B130
	public void .ctor() { }

}

