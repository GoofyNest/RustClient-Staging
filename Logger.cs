public class Logger : ILogger, ILogHandler // TypeDefIndex: 3458
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <logEnabled>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private LogType <filterLogType>k__BackingField; // 0x1C

	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }


	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_filterLogType(LogType value) { }

	public bool IsLogTypeAllowed(LogType logType) { }

	private static string GetString(object message) { }

	public void Log(LogType logType, object message) { }

	public void Log(LogType logType, object message, Object context) { }

	public void LogFormat(LogType logType, string format, object[] args) { }

	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	public void LogException(Exception exception, Object context) { }

}

