public class InputDevices // TypeDefIndex: 4149
{	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<InputDevice> deviceConnected; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<InputDevice> deviceConfigChanged; // 0x10


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }

}

