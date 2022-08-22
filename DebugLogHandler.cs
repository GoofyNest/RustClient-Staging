internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3370
{	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18154F0 Offset: 0x1813AF0 VA: 0x1818154F0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18154A0 Offset: 0x1813AA0 VA: 0x1818154A0
	internal static void Internal_LogException(Exception exception, Object obj) { }

	// RVA: 0x18155F0 Offset: 0x1813BF0 VA: 0x1818155F0 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1815550 Offset: 0x1813B50 VA: 0x181815550 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

