public class Logger : ILogger, ILogHandler // TypeDefIndex: 3458
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <logEnabled>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x18EB170 Offset: 0x18E9770 VA: 0x1818EB170
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 12
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00 Slot: 6
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 13
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0 Slot: 14
	public void set_filterLogType(LogType value) { }

	// RVA: 0x18EACE0 Offset: 0x18E92E0 VA: 0x1818EACE0 Slot: 15
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x18EABD0 Offset: 0x18E91D0 VA: 0x1818EABD0
	private static string GetString(object message) { }

	// RVA: 0x18EAF20 Offset: 0x18E9520 VA: 0x1818EAF20 Slot: 7
	public void Log(LogType logType, object message) { }

	// RVA: 0x18EB040 Offset: 0x18E9640 VA: 0x1818EB040 Slot: 8
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x18EAE80 Offset: 0x18E9480 VA: 0x1818EAE80 Slot: 9
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x18EADE0 Offset: 0x18E93E0 VA: 0x1818EADE0 Slot: 10
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x18EAD00 Offset: 0x18E9300 VA: 0x1818EAD00 Slot: 11
	public void LogException(Exception exception, Object context) { }

}

