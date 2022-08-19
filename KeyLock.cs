public class KeyLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6305
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int code; // 0x14

	// Methods

	// RVA: 0x1F1C460 Offset: 0x1F1AA60 VA: 0x181F1C460
	public static void ResetToPool(KeyLock instance) { }

	// RVA: 0x1F1C3E0 Offset: 0x1F1A9E0 VA: 0x181F1C3E0
	public void ResetToPool() { }

	// RVA: 0x1F1C2B0 Offset: 0x1F1A8B0 VA: 0x181F1C2B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(KeyLock instance) { }

	// RVA: 0x1F1B930 Offset: 0x1F19F30 VA: 0x181F1B930
	public KeyLock Copy() { }

	// RVA: 0x1F1BED0 Offset: 0x1F1A4D0 VA: 0x181F1BED0
	public static KeyLock Deserialize(Stream stream) { }

	// RVA: 0x1F1B9A0 Offset: 0x1F19FA0 VA: 0x181F1B9A0
	public static KeyLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1BC40 Offset: 0x1F1A240 VA: 0x181F1BC40
	public static KeyLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1C050 Offset: 0x1F1A650 VA: 0x181F1C050
	public static KeyLock Deserialize(byte[] buffer) { }

	// RVA: 0x1F1C3A0 Offset: 0x1F1A9A0 VA: 0x181F1C3A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1C930 Offset: 0x1F1AF30 VA: 0x181F1C930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1CA00 Offset: 0x1F1B000 VA: 0x181F1CA00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, KeyLock previous) { }

	// RVA: 0x1F1C3C0 Offset: 0x1F1A9C0 VA: 0x181F1C3C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1BF50 Offset: 0x1F1A550 VA: 0x181F1BF50
	public static KeyLock Deserialize(byte[] buffer, KeyLock instance, bool isDelta = False) { }

	// RVA: 0x1F1C170 Offset: 0x1F1A770 VA: 0x181F1C170
	public static KeyLock Deserialize(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1BA20 Offset: 0x1F1A020 VA: 0x181F1BA20
	public static KeyLock DeserializeLengthDelimited(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1BCD0 Offset: 0x1F1A2D0 VA: 0x181F1BCD0
	public static KeyLock DeserializeLength(Stream stream, int length, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F1C4E0 Offset: 0x1F1AAE0 VA: 0x181F1C4E0
	public static void SerializeDelta(Stream stream, KeyLock instance, KeyLock previous) { }

	// RVA: 0x1F1C850 Offset: 0x1F1AE50 VA: 0x181F1C850
	public static void Serialize(Stream stream, KeyLock instance) { }

	// RVA: 0x1F1C920 Offset: 0x1F1AF20 VA: 0x181F1C920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1C930 Offset: 0x1F1AF30 VA: 0x181F1C930
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1C6A0 Offset: 0x1F1ACA0 VA: 0x181F1C6A0
	public static byte[] SerializeToBytes(KeyLock instance) { }

	// RVA: 0x1F1C5F0 Offset: 0x1F1ABF0 VA: 0x181F1C5F0
	public static void SerializeLengthDelimited(Stream stream, KeyLock instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class KeyLock : BaseLock // TypeDefIndex: 8401
{	// Fields
	private Option __menuOption_Menu_CreateKey; // 0x1C8
	private Option __menuOption_Menu_Lock; // 0x220
	private Option __menuOption_Menu_Unlock; // 0x278
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
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

	[BaseEntity.Menu] // RVA: 0xE96A0 Offset: 0xE8AA0 VA: 0x1800E96A0
	[BaseEntity.Menu.Description] // RVA: 0xE96A0 Offset: 0xE8AA0 VA: 0x1800E96A0
	[BaseEntity.Menu.Icon] // RVA: 0xE96A0 Offset: 0xE8AA0 VA: 0x1800E96A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xE96A0 Offset: 0xE8AA0 VA: 0x1800E96A0
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

	[BaseEntity.Menu] // RVA: 0xE9D00 Offset: 0xE9100 VA: 0x1800E9D00
	[BaseEntity.Menu.Description] // RVA: 0xE9D00 Offset: 0xE9100 VA: 0x1800E9D00
	[BaseEntity.Menu.Icon] // RVA: 0xE9D00 Offset: 0xE9100 VA: 0x1800E9D00
	// RVA: 0x680E80 Offset: 0x67F480 VA: 0x180680E80
	public void Menu_CreateKey(BasePlayer player) { }

	// RVA: 0x680DA0 Offset: 0x67F3A0 VA: 0x180680DA0
	public void Menu_CreateKey_Proxy(ref Option option) { }

	// RVA: 0x57B130 Offset: 0x579730 VA: 0x18057B130
	public void .ctor() { }

}

