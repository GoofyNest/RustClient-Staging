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

	// RVA: 0x18EAB50 Offset: 0x18E9150 VA: 0x1818EAB50
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 12
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960010 Offset: 0x95E610 VA: 0x180960010 Slot: 6
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0 Slot: 13
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000 Slot: 14
	public void set_filterLogType(LogType value) { }

	// RVA: 0x18EA6C0 Offset: 0x18E8CC0 VA: 0x1818EA6C0 Slot: 15
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x18EA5B0 Offset: 0x18E8BB0 VA: 0x1818EA5B0
	private static string GetString(object message) { }

	// RVA: 0x18EA900 Offset: 0x18E8F00 VA: 0x1818EA900 Slot: 7
	public void Log(LogType logType, object message) { }

	// RVA: 0x18EAA20 Offset: 0x18E9020 VA: 0x1818EAA20 Slot: 8
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x18EA860 Offset: 0x18E8E60 VA: 0x1818EA860 Slot: 9
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x18EA7C0 Offset: 0x18E8DC0 VA: 0x1818EA7C0 Slot: 10
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x18EA6E0 Offset: 0x18E8CE0 VA: 0x1818EA6E0 Slot: 11
	public void LogException(Exception exception, Object context) { }

}

