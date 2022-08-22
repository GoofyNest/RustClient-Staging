internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3370
{
	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void Internal_LogException(Exception exception, Object obj) { }

	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	public void LogException(Exception exception, Object context) { }

	public void .ctor() { }

}

