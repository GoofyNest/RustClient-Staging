internal static class Debug // TypeDefIndex: 2456
{	// Methods

	// RVA: 0x1216C70 Offset: 0x1215270 VA: 0x181216C70
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	// RVA: 0x1216B50 Offset: 0x1215150 VA: 0x181216B50
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

public class Debug // TypeDefIndex: 3371
{	// Fields
	internal static ILogger s_Logger; // 0x146DA

	// Properties
	public static ILogger unityLogger { get; }

	// Methods

	// RVA: 0x1829680 Offset: 0x1827C80 VA: 0x181829680
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18283F0 Offset: 0x18269F0 VA: 0x1818283F0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18285C0 Offset: 0x1826BC0 VA: 0x1818285C0
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute] // RVA: 0x7BE10 Offset: 0x7B210 VA: 0x18007BE10
	// RVA: 0x1828510 Offset: 0x1826B10 VA: 0x181828510
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18286D0 Offset: 0x1826CD0 VA: 0x1818286D0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0x1828880 Offset: 0x1826E80 VA: 0x181828880
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	// RVA: 0x1829450 Offset: 0x1827A50 VA: 0x181829450
	public static void Log(object message) { }

	// RVA: 0x1829520 Offset: 0x1827B20 VA: 0x181829520
	public static void Log(object message, Object context) { }

	// RVA: 0x1828FF0 Offset: 0x18275F0 VA: 0x181828FF0
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x1828CA0 Offset: 0x18272A0 VA: 0x181828CA0
	public static void LogError(object message) { }

	// RVA: 0x1828D70 Offset: 0x1827370 VA: 0x181828D70
	public static void LogError(object message, Object context) { }

	// RVA: 0x1828BC0 Offset: 0x18271C0 VA: 0x181828BC0
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x1828AD0 Offset: 0x18270D0 VA: 0x181828AD0
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x1828F20 Offset: 0x1827520 VA: 0x181828F20
	public static void LogException(Exception exception) { }

	// RVA: 0x1828E50 Offset: 0x1827450 VA: 0x181828E50
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x18292A0 Offset: 0x18278A0 VA: 0x1818292A0
	public static void LogWarning(object message) { }

	// RVA: 0x1829370 Offset: 0x1827970 VA: 0x181829370
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x18290D0 Offset: 0x18276D0 VA: 0x1818290D0
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x18291B0 Offset: 0x18277B0 VA: 0x1818291B0
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x7CCE0 Offset: 0x7C0E0 VA: 0x18007CCE0
	// RVA: 0x1827F60 Offset: 0x1826560 VA: 0x181827F60
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CCE0 Offset: 0x7C0E0 VA: 0x18007CCE0
	// RVA: 0x1828040 Offset: 0x1826640 VA: 0x181828040
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CCE0 Offset: 0x7C0E0 VA: 0x18007CCE0
	// RVA: 0x1828120 Offset: 0x1826720 VA: 0x181828120
	public static void Assert(bool condition, string message, Object context) { }

	[ConditionalAttribute] // RVA: 0x7CCE0 Offset: 0x7C0E0 VA: 0x18007CCE0
	// RVA: 0x1828A00 Offset: 0x1827000 VA: 0x181828A00
	public static void LogAssertion(object message) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1828210 Offset: 0x1826810 VA: 0x181828210
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	// RVA: 0x1829600 Offset: 0x1827C00 VA: 0x181829600
	private static void .cctor() { }

	// RVA: 0x1828380 Offset: 0x1826980 VA: 0x181828380
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

public static class Debug // TypeDefIndex: 7146
{	// Fields
	private static TextWriter writer; // 0x2B114C4

	// Methods

	// RVA: 0x22E5490 Offset: 0x22E3A90 VA: 0x1822E5490
	private static void .cctor() { }

	// RVA: 0x22E5240 Offset: 0x22E3840 VA: 0x1822E5240
	public static void SetOut(TextWriter writer) { }

	// RVA: 0x22E53E0 Offset: 0x22E39E0 VA: 0x1822E53E0
	public static void WriteLine(string format, object[] args) { }

}

public sealed class Debug.WriterDelegate : MulticastDelegate // TypeDefIndex: 7147
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E2ED0 Offset: 0x12E14D0 VA: 0x1812E2ED0 Slot: 12
	public virtual void Invoke(string message) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Debug.DummyWriter : TextWriter // TypeDefIndex: 7148
{	// Fields
	private Debug.WriterDelegate writer; // 0x28

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x16295F0 Offset: 0x1627BF0 VA: 0x1816295F0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x22E5640 Offset: 0x22E3C40 VA: 0x1822E5640
	public void .ctor(Debug.WriterDelegate writer) { }

	// RVA: 0x22E5620 Offset: 0x22E3C20 VA: 0x1822E5620 Slot: 19
	public override void WriteLine(string value) { }

}

private sealed class Debug.DummyWriter.<>c // TypeDefIndex: 7149
{	// Fields
	public static readonly Debug.DummyWriter.<>c <>9; // 0x0
	public static Debug.WriterDelegate <>9__3_0; // 0x8

	// Methods

	// RVA: 0x22E8840 Offset: 0x22E6E40 VA: 0x1822E8840
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__3_0(string msg) { }

}

