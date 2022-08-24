public class KeyLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6305
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int code; // 0x14


	public static void ResetToPool(KeyLock instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(KeyLock instance) { }

	public KeyLock Copy() { }

	public static KeyLock Deserialize(Stream stream) { }

	public static KeyLock DeserializeLengthDelimited(Stream stream) { }

	public static KeyLock DeserializeLength(Stream stream, int length) { }

	public static KeyLock Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, KeyLock previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static KeyLock Deserialize(byte[] buffer, KeyLock instance, bool isDelta = False) { }

	public static KeyLock Deserialize(Stream stream, KeyLock instance, bool isDelta) { }

	public static KeyLock DeserializeLengthDelimited(Stream stream, KeyLock instance, bool isDelta) { }

	public static KeyLock DeserializeLength(Stream stream, int length, KeyLock instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, KeyLock instance, KeyLock previous) { }

	public static void Serialize(Stream stream, KeyLock instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(KeyLock instance) { }

	public static void SerializeLengthDelimited(Stream stream, KeyLock instance) { }

	public void .ctor() { }

}

public class KeyLock : BaseLock // TypeDefIndex: 8401
{	private Option __menuOption_Menu_CreateKey; // 0x1C8
	private Option __menuOption_Menu_Lock; // 0x220
	private Option __menuOption_Menu_Unlock; // 0x278
	[ItemSelector] // RVA: 0xA7740 Offset: 0xA6B40 VA: 0x1800A7740
	public ItemDefinition keyItemType; // 0x2D0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xE97F0 Offset: 0xE8BF0 VA: 0x1800E97F0
	[BaseEntity.Menu.Description] // RVA: 0xE97F0 Offset: 0xE8BF0 VA: 0x1800E97F0
	[BaseEntity.Menu.Icon] // RVA: 0xE97F0 Offset: 0xE8BF0 VA: 0x1800E97F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE97F0 Offset: 0xE8BF0 VA: 0x1800E97F0
	public void Menu_Unlock(BasePlayer player) { }

	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9C00 Offset: 0xE9000 VA: 0x1800E9C00
	[BaseEntity.Menu.Description] // RVA: 0xE9C00 Offset: 0xE9000 VA: 0x1800E9C00
	[BaseEntity.Menu.Icon] // RVA: 0xE9C00 Offset: 0xE9000 VA: 0x1800E9C00
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9C00 Offset: 0xE9000 VA: 0x1800E9C00
	public void Menu_Lock(BasePlayer player) { }

	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9F10 Offset: 0xE9310 VA: 0x1800E9F10
	[BaseEntity.Menu.Description] // RVA: 0xE9F10 Offset: 0xE9310 VA: 0x1800E9F10
	[BaseEntity.Menu.Icon] // RVA: 0xE9F10 Offset: 0xE9310 VA: 0x1800E9F10
	public void Menu_CreateKey(BasePlayer player) { }

	public void Menu_CreateKey_Proxy(ref Option option) { }

	public void .ctor() { }

}

