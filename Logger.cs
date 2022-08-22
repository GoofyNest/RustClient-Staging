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

	// RVA: 0x18EB430 Offset: 0x18E9A30 VA: 0x1818EB430
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 12
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB10 Offset: 0x95E110 VA: 0x18095FB10 Slot: 6
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 13
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00 Slot: 14
	public void set_filterLogType(LogType value) { }

	// RVA: 0x18EAFA0 Offset: 0x18E95A0 VA: 0x1818EAFA0 Slot: 15
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x18EAE90 Offset: 0x18E9490 VA: 0x1818EAE90
	private static string GetString(object message) { }

	// RVA: 0x18EB1E0 Offset: 0x18E97E0 VA: 0x1818EB1E0 Slot: 7
	public void Log(LogType logType, object message) { }

	// RVA: 0x18EB300 Offset: 0x18E9900 VA: 0x1818EB300 Slot: 8
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x18EB140 Offset: 0x18E9740 VA: 0x1818EB140 Slot: 9
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x18EB0A0 Offset: 0x18E96A0 VA: 0x1818EB0A0 Slot: 10
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x18EAFC0 Offset: 0x18E95C0 VA: 0x1818EAFC0 Slot: 11
	public void LogException(Exception exception, Object context) { }

}

