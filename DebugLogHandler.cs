internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3370
{	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18280B0 Offset: 0x18266B0 VA: 0x1818280B0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1828060 Offset: 0x1826660 VA: 0x181828060
	internal static void Internal_LogException(Exception exception, Object obj) { }

	// RVA: 0x18281B0 Offset: 0x18267B0 VA: 0x1818281B0 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1828110 Offset: 0x1826710 VA: 0x181828110 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

