public class SmartAlarm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6367
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> subscriptions; // 0x18
	public string notificationTitle; // 0x20
	public string notificationBody; // 0x28

	// Methods

	// RVA: 0x1DB3550 Offset: 0x1DB1B50 VA: 0x181DB3550
	public static void ResetToPool(SmartAlarm instance) { }

	// RVA: 0x1DB3680 Offset: 0x1DB1C80 VA: 0x181DB3680
	public void ResetToPool() { }

	// RVA: 0x1DB3360 Offset: 0x1DB1960 VA: 0x181DB3360 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB20C0 Offset: 0x1DB06C0 VA: 0x181DB20C0
	public void CopyTo(SmartAlarm instance) { }

	// RVA: 0x1DB2210 Offset: 0x1DB0810 VA: 0x181DB2210
	public SmartAlarm Copy() { }

	// RVA: 0x1DB2DC0 Offset: 0x1DB13C0 VA: 0x181DB2DC0
	public static SmartAlarm Deserialize(Stream stream) { }

	// RVA: 0x1DB23A0 Offset: 0x1DB09A0 VA: 0x181DB23A0
	public static SmartAlarm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB2730 Offset: 0x1DB0D30 VA: 0x181DB2730
	public static SmartAlarm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB2AC0 Offset: 0x1DB10C0 VA: 0x181DB2AC0
	public static SmartAlarm Deserialize(byte[] buffer) { }

	// RVA: 0x1DB3510 Offset: 0x1DB1B10 VA: 0x181DB3510
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB3DB0 Offset: 0x1DB23B0 VA: 0x181DB3DB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB3DD0 Offset: 0x1DB23D0 VA: 0x181DB3DD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SmartAlarm previous) { }

	// RVA: 0x1DB3530 Offset: 0x1DB1B30 VA: 0x181DB3530 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB3020 Offset: 0x1DB1620 VA: 0x181DB3020
	public static SmartAlarm Deserialize(byte[] buffer, SmartAlarm instance, bool isDelta = False) { }

	// RVA: 0x1DB3120 Offset: 0x1DB1720 VA: 0x181DB3120
	public static SmartAlarm Deserialize(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB2420 Offset: 0x1DB0A20 VA: 0x181DB2420
	public static SmartAlarm DeserializeLengthDelimited(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB27C0 Offset: 0x1DB0DC0 VA: 0x181DB27C0
	public static SmartAlarm DeserializeLength(Stream stream, int length, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DB37B0 Offset: 0x1DB1DB0 VA: 0x181DB37B0
	public static void SerializeDelta(Stream stream, SmartAlarm instance, SmartAlarm previous) { }

	// RVA: 0x1DB3BB0 Offset: 0x1DB21B0 VA: 0x181DB3BB0
	public static void Serialize(Stream stream, SmartAlarm instance) { }

	// RVA: 0x1DB3DA0 Offset: 0x1DB23A0 VA: 0x181DB3DA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB3DB0 Offset: 0x1DB23B0 VA: 0x181DB3DB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB3AA0 Offset: 0x1DB20A0 VA: 0x181DB3AA0
	public static byte[] SerializeToBytes(SmartAlarm instance) { }

	// RVA: 0x1DB39F0 Offset: 0x1DB1FF0 VA: 0x181DB39F0
	public static void SerializeLengthDelimited(Stream stream, SmartAlarm instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x5AEB60 Offset: 0x5AD160 VA: 0x1805AEB60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5AF8B0 Offset: 0x5ADEB0 VA: 0x1805AF8B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5AF020 Offset: 0x5AD620 VA: 0x1805AF020 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5AEF90 Offset: 0x5AD590 VA: 0x1805AEF90
	public void OnAlarmStatusChange(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	[BaseEntity.Menu.Description] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	[BaseEntity.Menu.Icon] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	[BaseEntity.Menu.ShowIf] // RVA: 0x87C80 Offset: 0x87080 VA: 0x180087C80
	// RVA: 0x5AEF50 Offset: 0x5AD550 VA: 0x1805AEF50
	public void MenuSetupNotification(BasePlayer player) { }

	// RVA: 0x5AEED0 Offset: 0x5AD4D0 VA: 0x1805AEED0
	public bool MenuSetupNotification_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5AF640 Offset: 0x5ADC40 VA: 0x1805AF640
	private void SetupNotification(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x5AF5D0 Offset: 0x5ADBD0 VA: 0x1805AF5D0
	public void SetNotificationText(string title, string body) { }

	// RVA: 0x5AF8A0 Offset: 0x5ADEA0 VA: 0x1805AF8A0
	public void .ctor() { }

	// RVA: 0x5AF7D0 Offset: 0x5ADDD0 VA: 0x1805AF7D0
	private static void .cctor() { }

}

