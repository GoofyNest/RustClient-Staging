public class Logger : ILogger, ILogHandler // TypeDefIndex: 3458
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private bool <logEnabled>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x18EB1B0 Offset: 0x18E97B0 VA: 0x1818EB1B0
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 12
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95FA00 Offset: 0x95E000 VA: 0x18095FA00 Slot: 6
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 13
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0 Slot: 14
	public void set_filterLogType(LogType value) { }

	// RVA: 0x18EAD20 Offset: 0x18E9320 VA: 0x1818EAD20 Slot: 15
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x18EAC10 Offset: 0x18E9210 VA: 0x1818EAC10
	private static string GetString(object message) { }

	// RVA: 0x18EAF60 Offset: 0x18E9560 VA: 0x1818EAF60 Slot: 7
	public void Log(LogType logType, object message) { }

	// RVA: 0x18EB080 Offset: 0x18E9680 VA: 0x1818EB080 Slot: 8
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x18EAEC0 Offset: 0x18E94C0 VA: 0x1818EAEC0 Slot: 9
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x18EAE20 Offset: 0x18E9420 VA: 0x1818EAE20 Slot: 10
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x18EAD40 Offset: 0x18E9340 VA: 0x1818EAD40 Slot: 11
	public void LogException(Exception exception, Object context) { }

}

