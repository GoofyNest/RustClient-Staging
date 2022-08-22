public class SmartAlarm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6367
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> subscriptions; // 0x18
	public string notificationTitle; // 0x20
	public string notificationBody; // 0x28

	// Methods

	// RVA: 0x1DB2AA0 Offset: 0x1DB10A0 VA: 0x181DB2AA0
	public static void ResetToPool(SmartAlarm instance) { }

	// RVA: 0x1DB2BD0 Offset: 0x1DB11D0 VA: 0x181DB2BD0
	public void ResetToPool() { }

	// RVA: 0x1DB28B0 Offset: 0x1DB0EB0 VA: 0x181DB28B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB1610 Offset: 0x1DAFC10 VA: 0x181DB1610
	public void CopyTo(SmartAlarm instance) { }

	// RVA: 0x1DB1760 Offset: 0x1DAFD60 VA: 0x181DB1760
	public SmartAlarm Copy() { }

	// RVA: 0x1DB2310 Offset: 0x1DB0910 VA: 0x181DB2310
	public static SmartAlarm Deserialize(Stream stream) { }

	// RVA: 0x1DB18F0 Offset: 0x1DAFEF0 VA: 0x181DB18F0
	public static SmartAlarm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB1C80 Offset: 0x1DB0280 VA: 0x181DB1C80
	public static SmartAlarm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB2010 Offset: 0x1DB0610 VA: 0x181DB2010
	public static SmartAlarm Deserialize(byte[] buffer) { }

	// RVA: 0x1DB2A60 Offset: 0x1DB1060 VA: 0x181DB2A60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB3300 Offset: 0x1DB1900 VA: 0x181DB3300 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB3320 Offset: 0x1DB1920 VA: 0x181DB3320 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SmartAlarm previous) { }

	// RVA: 0x1DB2A80 Offset: 0x1DB1080 VA: 0x181DB2A80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB2570 Offset: 0x1DB0B70 VA: 0x181DB2570
	public static SmartAlarm Deserialize(byte[] buffer, SmartAlarm instance, bool isDelta = False) { }

	// RVA: 0x1DB2670 Offset: 0x1DB0C70 VA: 0x181DB2670
	public static SmartAlarm Deserialize(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB1970 Offset: 0x1DAFF70 VA: 0x181DB1970
	public static SmartAlarm DeserializeLengthDelimited(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB1D10 Offset: 0x1DB0310 VA: 0x181DB1D10
	public static SmartAlarm DeserializeLength(Stream stream, int length, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB2D00 Offset: 0x1DB1300 VA: 0x181DB2D00
	public static void SerializeDelta(Stream stream, SmartAlarm instance, SmartAlarm previous) { }

	// RVA: 0x1DB3100 Offset: 0x1DB1700 VA: 0x181DB3100
	public static void Serialize(Stream stream, SmartAlarm instance) { }

	// RVA: 0x1DB32F0 Offset: 0x1DB18F0 VA: 0x181DB32F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB3300 Offset: 0x1DB1900 VA: 0x181DB3300
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB2FF0 Offset: 0x1DB15F0 VA: 0x181DB2FF0
	public static byte[] SerializeToBytes(SmartAlarm instance) { }

	// RVA: 0x1DB2F40 Offset: 0x1DB1540 VA: 0x181DB2F40
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
	[HeaderAttribute] // RVA: 0x87AE0 Offset: 0x86EE0 VA: 0x180087AE0
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

	[BaseEntity.Menu] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	[BaseEntity.Menu.Description] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	[BaseEntity.Menu.Icon] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	[BaseEntity.Menu.ShowIf] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	// RVA: 0x5AEFC0 Offset: 0x5AD5C0 VA: 0x1805AEFC0
	public void MenuSetupNotification(BasePlayer player) { }

	// RVA: 0x5AEF40 Offset: 0x5AD540 VA: 0x1805AEF40
	public bool MenuSetupNotification_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AF6B0 Offset: 0x5ADCB0 VA: 0x1805AF6B0
	private void SetupNotification(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x5AF640 Offset: 0x5ADC40 VA: 0x1805AF640
	public void SetNotificationText(string title, string body) { }

	// RVA: 0x5AF910 Offset: 0x5ADF10 VA: 0x1805AF910
	public void .ctor() { }

	// RVA: 0x5AF840 Offset: 0x5ADE40 VA: 0x1805AF840
	private static void .cctor() { }

}

