public class SmartAlarm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6367
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> subscriptions; // 0x18
	public string notificationTitle; // 0x20
	public string notificationBody; // 0x28

	// Methods

	// RVA: 0x1DB2C60 Offset: 0x1DB1260 VA: 0x181DB2C60
	public static void ResetToPool(SmartAlarm instance) { }

	// RVA: 0x1DB2D90 Offset: 0x1DB1390 VA: 0x181DB2D90
	public void ResetToPool() { }

	// RVA: 0x1DB2A70 Offset: 0x1DB1070 VA: 0x181DB2A70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB17D0 Offset: 0x1DAFDD0 VA: 0x181DB17D0
	public void CopyTo(SmartAlarm instance) { }

	// RVA: 0x1DB1920 Offset: 0x1DAFF20 VA: 0x181DB1920
	public SmartAlarm Copy() { }

	// RVA: 0x1DB24D0 Offset: 0x1DB0AD0 VA: 0x181DB24D0
	public static SmartAlarm Deserialize(Stream stream) { }

	// RVA: 0x1DB1AB0 Offset: 0x1DB00B0 VA: 0x181DB1AB0
	public static SmartAlarm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB1E40 Offset: 0x1DB0440 VA: 0x181DB1E40
	public static SmartAlarm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB21D0 Offset: 0x1DB07D0 VA: 0x181DB21D0
	public static SmartAlarm Deserialize(byte[] buffer) { }

	// RVA: 0x1DB2C20 Offset: 0x1DB1220 VA: 0x181DB2C20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB34C0 Offset: 0x1DB1AC0 VA: 0x181DB34C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB34E0 Offset: 0x1DB1AE0 VA: 0x181DB34E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SmartAlarm previous) { }

	// RVA: 0x1DB2C40 Offset: 0x1DB1240 VA: 0x181DB2C40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB2730 Offset: 0x1DB0D30 VA: 0x181DB2730
	public static SmartAlarm Deserialize(byte[] buffer, SmartAlarm instance, bool isDelta = False) { }

	// RVA: 0x1DB2830 Offset: 0x1DB0E30 VA: 0x181DB2830
	public static SmartAlarm Deserialize(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB1B30 Offset: 0x1DB0130 VA: 0x181DB1B30
	public static SmartAlarm DeserializeLengthDelimited(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB1ED0 Offset: 0x1DB04D0 VA: 0x181DB1ED0
	public static SmartAlarm DeserializeLength(Stream stream, int length, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB2EC0 Offset: 0x1DB14C0 VA: 0x181DB2EC0
	public static void SerializeDelta(Stream stream, SmartAlarm instance, SmartAlarm previous) { }

	// RVA: 0x1DB32C0 Offset: 0x1DB18C0 VA: 0x181DB32C0
	public static void Serialize(Stream stream, SmartAlarm instance) { }

	// RVA: 0x1DB34B0 Offset: 0x1DB1AB0 VA: 0x181DB34B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB34C0 Offset: 0x1DB1AC0 VA: 0x181DB34C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB31B0 Offset: 0x1DB17B0 VA: 0x181DB31B0
	public static byte[] SerializeToBytes(SmartAlarm instance) { }

	// RVA: 0x1DB3100 Offset: 0x1DB1700 VA: 0x181DB3100
	public static void SerializeLengthDelimited(Stream stream, SmartAlarm instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class SmartAlarm : AppIOEntity, ISubscribable // TypeDefIndex: 8449
{	// Fields
	private Option __menuOption_MenuSetupNotification; // 0x2E0
	public const BaseEntity.Flags Flag_HasCustomMessage = 16384;
	public static readonly Translate.Phrase DefaultNotificationTitle; // 0x0
	public static readonly Translate.Phrase DefaultNotificationBody; // 0x8
	[HeaderAttribute] // RVA: 0x87A70 Offset: 0x86E70 VA: 0x180087A70
	public GameObjectRef SetupNotificationDialog; // 0x338
	public Animator Animator; // 0x340
	private static readonly int AnimatorOn; // 0x10

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5AEBD0 Offset: 0x5AD1D0 VA: 0x1805AEBD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5AF920 Offset: 0x5ADF20 VA: 0x1805AF920 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5AF090 Offset: 0x5AD690 VA: 0x1805AF090 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5AF000 Offset: 0x5AD600 VA: 0x1805AF000
	public void OnAlarmStatusChange(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x87B80 Offset: 0x86F80 VA: 0x180087B80
	[BaseEntity.Menu.Description] // RVA: 0x87B80 Offset: 0x86F80 VA: 0x180087B80
	[BaseEntity.Menu.Icon] // RVA: 0x87B80 Offset: 0x86F80 VA: 0x180087B80
	[BaseEntity.Menu.ShowIf] // RVA: 0x87B80 Offset: 0x86F80 VA: 0x180087B80
	// RVA: 0x5AEFC0 Offset: 0x5AD5C0 VA: 0x1805AEFC0
	public void MenuSetupNotification(BasePlayer player) { }

	// RVA: 0x5AEF40 Offset: 0x5AD540 VA: 0x1805AEF40
	public bool MenuSetupNotification_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5AF6B0 Offset: 0x5ADCB0 VA: 0x1805AF6B0
	private void SetupNotification(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x5AF640 Offset: 0x5ADC40 VA: 0x1805AF640
	public void SetNotificationText(string title, string body) { }

	// RVA: 0x5AF910 Offset: 0x5ADF10 VA: 0x1805AF910
	public void .ctor() { }

	// RVA: 0x5AF840 Offset: 0x5ADE40 VA: 0x1805AF840
	private static void .cctor() { }

}

