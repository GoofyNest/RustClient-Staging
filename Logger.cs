public class Logger : ILogger, ILogHandler // TypeDefIndex: 3458
{	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private bool <logEnabled>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private LogType <filterLogType>k__BackingField; // 0x1C

	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }


	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_filterLogType(LogType value) { }

	public bool IsLogTypeAllowed(LogType logType) { }

	private static string GetString(object message) { }

	public void Log(LogType logType, object message) { }

	public void Log(LogType logType, object message, Object context) { }

	public void LogFormat(LogType logType, string format, object[] args) { }

	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	public void LogException(Exception exception, Object context) { }

}

