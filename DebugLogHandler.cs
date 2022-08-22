internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3370
{	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1827DF0 Offset: 0x18263F0 VA: 0x181827DF0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1827DA0 Offset: 0x18263A0 VA: 0x181827DA0
	internal static void Internal_LogException(Exception exception, Object obj) { }

	// RVA: 0x1827EF0 Offset: 0x18264F0 VA: 0x181827EF0 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1827E50 Offset: 0x1826450 VA: 0x181827E50 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

