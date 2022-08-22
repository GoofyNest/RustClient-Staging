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

	// RVA: 0x10DC970 Offset: 0x10DAF70 VA: 0x1810DC970
	private void Init() { }

	// RVA: 0x10DCFB0 Offset: 0x10DB5B0 VA: 0x1810DCFB0
	public void .ctor() { }

	// RVA: 0x10DD030 Offset: 0x10DB630 VA: 0x1810DD030
	public void .ctor(string message) { }

	// RVA: 0x10DCFD0 Offset: 0x10DB5D0 VA: 0x1810DCFD0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10DD070 Offset: 0x10DB670 VA: 0x1810DD070
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10DD480 Offset: 0x10DBA80 VA: 0x1810DD480 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x10DD3F0 Offset: 0x10DB9F0 VA: 0x1810DD3F0 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool IsImmutableAgileException(Exception e) { }

	// RVA: 0x10DC3D0 Offset: 0x10DA9D0 VA: 0x1810DC3D0
	private string GetClassName() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 7
	public Exception get_InnerException() { }

	// RVA: 0x10DD6D0 Offset: 0x10DBCD0 VA: 0x1810DD6D0 Slot: 8
	public virtual string get_StackTrace() { }

	// RVA: 0x10DC880 Offset: 0x10DAE80 VA: 0x1810DC880
	private string GetStackTrace(bool needFileInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	internal void SetErrorCode(int hr) { }

	// RVA: 0x10DD590 Offset: 0x10DBB90 VA: 0x1810DD590 Slot: 9
	public virtual string get_Source() { }

	// RVA: 0x10DCF40 Offset: 0x10DB540 VA: 0x1810DCF40 Slot: 3
	public override string ToString() { }

	// RVA: 0x10DCB50 Offset: 0x10DB150 VA: 0x1810DCB50
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x10DC470 Offset: 0x10DAA70 VA: 0x1810DC470 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10DCA00 Offset: 0x10DB000 VA: 0x1810DCA00
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x10DCAA0 Offset: 0x10DB0A0 VA: 0x1810DCAA0
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_HResult() { }

	// RVA: 0x574440 Offset: 0x572A40 VA: 0x180574440
	protected void set_HResult(int value) { }

	// RVA: 0x10DC960 Offset: 0x10DAF60 VA: 0x1810DC960 Slot: 11
	public Type GetType() { }

	// RVA: 0x10DC420 Offset: 0x10DAA20 VA: 0x1810DC420
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x10DC2F0 Offset: 0x10DA8F0 VA: 0x1810DC2F0
	internal Exception FixRemotingException() { }

	// RVA: 0x10DCA90 Offset: 0x10DB090 VA: 0x1810DCA90
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x10DCF50 Offset: 0x10DB550 VA: 0x1810DCF50
	private static void .cctor() { }

}

internal enum Exception.ExceptionMessageKind // TypeDefIndex: 219
{	// Fields
	public int value__; // 0x0
	public const Exception.ExceptionMessageKind ThreadAbort = 1;
	public const Exception.ExceptionMessageKind ThreadInterrupted = 2;
	public const Exception.ExceptionMessageKind OutOfMemory = 3;

}

