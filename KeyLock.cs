public class KeyLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6305
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int code; // 0x14

	// Methods

	// RVA: 0x1F1C560 Offset: 0x1F1AB60 VA: 0x181F1C560
	public static void ResetToPool(KeyLock instance) { }

	// RVA: 0x1F1C4E0 Offset: 0x1F1AAE0 VA: 0x181F1C4E0
	public void ResetToPool() { }

	// RVA: 0x1F1C3B0 Offset: 0x1F1A9B0 VA: 0x181F1C3B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(KeyLock instance) { }

	// RVA: 0x1F1BA30 Offset: 0x1F1A030 VA: 0x181F1BA30
	public KeyLock Copy() { }

	// RVA: 0x1F1BFD0 Offset: 0x1F1A5D0 VA: 0x181F1BFD0
	public static KeyLock Deserialize(Stream stream) { }

	// RVA: 0x1F1BAA0 Offset: 0x1F1A0A0 VA: 0x181F1BAA0
	public static KeyLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1BD40 Offset: 0x1F1A340 VA: 0x181F1BD40
	public static KeyLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1C150 Offset: 0x1F1A750 VA: 0x181F1C150
	public static KeyLock Deserialize(byte[] buffer) { }

	// RVA: 0x1F1C4A0 Offset: 0x1F1AAA0 VA: 0x181F1C4A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1CA30 Offset: 0x1F1B030 VA: 0x181F1CA30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1CB00 Offset: 0x1F1B100 VA: 0x181F1CB00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, KeyLock previous) { }

	// RVA: 0x1F1C4C0 Offset: 0x1F1AAC0 VA: 0x181F1C4C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1C050 Offset: 0x1F1A650 VA: 0x181F1C050
	public static KeyLock Deserialize(byte[] buffer, KeyLock instance, bool isDelta = False) { }

	// RVA: 0x1F1C270 Offset: 0x1F1A870 VA: 0x181F1C270
	public static KeyLock Deserialize(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1BB20 Offset: 0x1F1A120 VA: 0x181F1BB20
	public static KeyLock DeserializeLengthDelimited(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1BDD0 Offset: 0x1F1A3D0 VA: 0x181F1BDD0
	public static KeyLock DeserializeLength(Stream stream, int length, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1C5E0 Offset: 0x1F1ABE0 VA: 0x181F1C5E0
	public static void SerializeDelta(Stream stream, KeyLock instance, KeyLock previous) { }

	// RVA: 0x1F1C950 Offset: 0x1F1AF50 VA: 0x181F1C950
	public static void Serialize(Stream stream, KeyLock instance) { }

	// RVA: 0x1F1CA20 Offset: 0x1F1B020 VA: 0x181F1CA20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1CA30 Offset: 0x1F1B030 VA: 0x181F1CA30
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1C7A0 Offset: 0x1F1ADA0 VA: 0x181F1C7A0
	public static byte[] SerializeToBytes(KeyLock instance) { }

	// RVA: 0x1F1C6F0 Offset: 0x1F1ACF0 VA: 0x181F1C6F0
	public static void SerializeLengthDelimited(Stream stream, KeyLock instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

