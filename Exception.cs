public class Exception : ISerializable, _Exception // TypeDefIndex: 218
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private static object s_EDILock; // 0x0
	private string _className; // 0x10
	internal string _message; // 0x18
	private IDictionary _data; // 0x20
	private Exception _innerException; // 0x28
	private string _helpURL; // 0x30
	private object _stackTrace; // 0x38
	private string _stackTraceString; // 0x40
	private string _remoteStackTraceString; // 0x48
	private int _remoteStackIndex; // 0x50
	private object _dynamicMethods; // 0x58
	internal int _HResult; // 0x60
	private string _source; // 0x68
	[OptionalFieldAttribute] // RVA: 0x7B710 Offset: 0x7AB10 VA: 0x18007B710
	private SafeSerializationManager _safeSerializationManager; // 0x70
	internal StackTrace[] captured_traces; // 0x78
	private IntPtr[] native_trace_ips; // 0x80
	private const int _COMPlusExceptionCode = -532462766;

	// Properties
	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public virtual string StackTrace { get; }
	public virtual string Source { get; }
	public int HResult { get; set; }

	// Methods

	// RVA: 0x10DD3E0 Offset: 0x10DB9E0 VA: 0x1810DD3E0
	private void Init() { }

	// RVA: 0x10DDA20 Offset: 0x10DC020 VA: 0x1810DDA20
	public void .ctor() { }

	// RVA: 0x10DDAA0 Offset: 0x10DC0A0 VA: 0x1810DDAA0
	public void .ctor(string message) { }

	// RVA: 0x10DDA40 Offset: 0x10DC040 VA: 0x1810DDA40
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10DDAE0 Offset: 0x10DC0E0 VA: 0x1810DDAE0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10DDEF0 Offset: 0x10DC4F0 VA: 0x1810DDEF0 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x10DDE60 Offset: 0x10DC460 VA: 0x1810DDE60 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsImmutableAgileException(Exception e) { }

	// RVA: 0x10DCE40 Offset: 0x10DB440 VA: 0x1810DCE40
	private string GetClassName() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 7
	public Exception get_InnerException() { }

	// RVA: 0x10DE140 Offset: 0x10DC740 VA: 0x1810DE140 Slot: 8
	public virtual string get_StackTrace() { }

	// RVA: 0x10DD2F0 Offset: 0x10DB8F0 VA: 0x1810DD2F0
	private string GetStackTrace(bool needFileInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal void SetErrorCode(int hr) { }

	// RVA: 0x10DE000 Offset: 0x10DC600 VA: 0x1810DE000 Slot: 9
	public virtual string get_Source() { }

	// RVA: 0x10DD9B0 Offset: 0x10DBFB0 VA: 0x1810DD9B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10DD5C0 Offset: 0x10DBBC0 VA: 0x1810DD5C0
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x10DCEE0 Offset: 0x10DB4E0 VA: 0x1810DCEE0 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10DD470 Offset: 0x10DBA70 VA: 0x1810DD470
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x10DD510 Offset: 0x10DBB10 VA: 0x1810DD510
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public int get_HResult() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	protected void set_HResult(int value) { }

	// RVA: 0x10DD3D0 Offset: 0x10DB9D0 VA: 0x1810DD3D0 Slot: 11
	public Type GetType() { }

	// RVA: 0x10DCE90 Offset: 0x10DB490 VA: 0x1810DCE90
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x10DCD60 Offset: 0x10DB360 VA: 0x1810DCD60
	internal Exception FixRemotingException() { }

	// RVA: 0x10DD500 Offset: 0x10DBB00 VA: 0x1810DD500
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x10DD9C0 Offset: 0x10DBFC0 VA: 0x1810DD9C0
	private static void .cctor() { }

}

internal enum Exception.ExceptionMessageKind // TypeDefIndex: 219
{	// Fields
	public int value__; // 0x0
	public const Exception.ExceptionMessageKind ThreadAbort = 1;
	public const Exception.ExceptionMessageKind ThreadInterrupted = 2;
	public const Exception.ExceptionMessageKind OutOfMemory = 3;

}

