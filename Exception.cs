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

	// RVA: 0x10DC6B0 Offset: 0x10DACB0 VA: 0x1810DC6B0
	private void Init() { }

	// RVA: 0x10DCCF0 Offset: 0x10DB2F0 VA: 0x1810DCCF0
	public void .ctor() { }

	// RVA: 0x10DCD70 Offset: 0x10DB370 VA: 0x1810DCD70
	public void .ctor(string message) { }

	// RVA: 0x10DCD10 Offset: 0x10DB310 VA: 0x1810DCD10
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10DCDB0 Offset: 0x10DB3B0 VA: 0x1810DCDB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10DD1C0 Offset: 0x10DB7C0 VA: 0x1810DD1C0 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x10DD130 Offset: 0x10DB730 VA: 0x1810DD130 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsImmutableAgileException(Exception e) { }

	// RVA: 0x10DC110 Offset: 0x10DA710 VA: 0x1810DC110
	private string GetClassName() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 7
	public Exception get_InnerException() { }

	// RVA: 0x10DD410 Offset: 0x10DBA10 VA: 0x1810DD410 Slot: 8
	public virtual string get_StackTrace() { }

	// RVA: 0x10DC5C0 Offset: 0x10DABC0 VA: 0x1810DC5C0
	private string GetStackTrace(bool needFileInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	internal void SetErrorCode(int hr) { }

	// RVA: 0x10DD2D0 Offset: 0x10DB8D0 VA: 0x1810DD2D0 Slot: 9
	public virtual string get_Source() { }

	// RVA: 0x10DCC80 Offset: 0x10DB280 VA: 0x1810DCC80 Slot: 3
	public override string ToString() { }

	// RVA: 0x10DC890 Offset: 0x10DAE90 VA: 0x1810DC890
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x10DC1B0 Offset: 0x10DA7B0 VA: 0x1810DC1B0 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10DC740 Offset: 0x10DAD40 VA: 0x1810DC740
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x10DC7E0 Offset: 0x10DADE0 VA: 0x1810DC7E0
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_HResult() { }

	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	protected void set_HResult(int value) { }

	// RVA: 0x10DC6A0 Offset: 0x10DACA0 VA: 0x1810DC6A0 Slot: 11
	public Type GetType() { }

	// RVA: 0x10DC160 Offset: 0x10DA760 VA: 0x1810DC160
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x10DC030 Offset: 0x10DA630 VA: 0x1810DC030
	internal Exception FixRemotingException() { }

	// RVA: 0x10DC7D0 Offset: 0x10DADD0 VA: 0x1810DC7D0
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x10DCC90 Offset: 0x10DB290 VA: 0x1810DCC90
	private static void .cctor() { }

}

internal enum Exception.ExceptionMessageKind // TypeDefIndex: 219
{	// Fields
	public int value__; // 0x0
	public const Exception.ExceptionMessageKind ThreadAbort = 1;
	public const Exception.ExceptionMessageKind ThreadInterrupted = 2;
	public const Exception.ExceptionMessageKind OutOfMemory = 3;

}

