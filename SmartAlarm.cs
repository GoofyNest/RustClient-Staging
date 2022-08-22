public class SmartAlarm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6367
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> subscriptions; // 0x18
	public string notificationTitle; // 0x20
	public string notificationBody; // 0x28

	// Methods

	// RVA: 0x1DB2D60 Offset: 0x1DB1360 VA: 0x181DB2D60
	public static void ResetToPool(SmartAlarm instance) { }

	// RVA: 0x1DB2E90 Offset: 0x1DB1490 VA: 0x181DB2E90
	public void ResetToPool() { }

	// RVA: 0x1DB2B70 Offset: 0x1DB1170 VA: 0x181DB2B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB18D0 Offset: 0x1DAFED0 VA: 0x181DB18D0
	public void CopyTo(SmartAlarm instance) { }

	// RVA: 0x1DB1A20 Offset: 0x1DB0020 VA: 0x181DB1A20
	public SmartAlarm Copy() { }

	// RVA: 0x1DB25D0 Offset: 0x1DB0BD0 VA: 0x181DB25D0
	public static SmartAlarm Deserialize(Stream stream) { }

	// RVA: 0x1DB1BB0 Offset: 0x1DB01B0 VA: 0x181DB1BB0
	public static SmartAlarm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB1F40 Offset: 0x1DB0540 VA: 0x181DB1F40
	public static SmartAlarm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB22D0 Offset: 0x1DB08D0 VA: 0x181DB22D0
	public static SmartAlarm Deserialize(byte[] buffer) { }

	// RVA: 0x1DB2D20 Offset: 0x1DB1320 VA: 0x181DB2D20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB35C0 Offset: 0x1DB1BC0 VA: 0x181DB35C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB35E0 Offset: 0x1DB1BE0 VA: 0x181DB35E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SmartAlarm previous) { }

	// RVA: 0x1DB2D40 Offset: 0x1DB1340 VA: 0x181DB2D40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB2830 Offset: 0x1DB0E30 VA: 0x181DB2830
	public static SmartAlarm Deserialize(byte[] buffer, SmartAlarm instance, bool isDelta = False) { }

	// RVA: 0x1DB2930 Offset: 0x1DB0F30 VA: 0x181DB2930
	public static SmartAlarm Deserialize(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB1C30 Offset: 0x1DB0230 VA: 0x181DB1C30
	public static SmartAlarm DeserializeLengthDelimited(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB1FD0 Offset: 0x1DB05D0 VA: 0x181DB1FD0
	public static SmartAlarm DeserializeLength(Stream stream, int length, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB2FC0 Offset: 0x1DB15C0 VA: 0x181DB2FC0
	public static void SerializeDelta(Stream stream, SmartAlarm instance, SmartAlarm previous) { }

	// RVA: 0x1DB33C0 Offset: 0x1DB19C0 VA: 0x181DB33C0
	public static void Serialize(Stream stream, SmartAlarm instance) { }

	// RVA: 0x1DB35B0 Offset: 0x1DB1BB0 VA: 0x181DB35B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB35C0 Offset: 0x1DB1BC0 VA: 0x181DB35C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB32B0 Offset: 0x1DB18B0 VA: 0x181DB32B0
	public static byte[] SerializeToBytes(SmartAlarm instance) { }

	// RVA: 0x1DB3200 Offset: 0x1DB1800 VA: 0x181DB3200
	public static void SerializeLengthDelimited(Stream stream, SmartAlarm instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

