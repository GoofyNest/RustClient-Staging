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

	// RVA: 0x1829640 Offset: 0x1827C40 VA: 0x181829640
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18283F0 Offset: 0x18269F0 VA: 0x1818283F0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18285C0 Offset: 0x1826BC0 VA: 0x1818285C0
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute] // RVA: 0x7BEA0 Offset: 0x7B2A0 VA: 0x18007BEA0
	// RVA: 0x1828510 Offset: 0x1826B10 VA: 0x181828510
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1828900 Offset: 0x1826F00 VA: 0x181828900
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18286D0 Offset: 0x1826CD0 VA: 0x1818286D0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0x1828780 Offset: 0x1826D80 VA: 0x181828780
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	// RVA: 0x1829410 Offset: 0x1827A10 VA: 0x181829410
	public static void Log(object message) { }

	// RVA: 0x18294E0 Offset: 0x1827AE0 VA: 0x1818294E0
	public static void Log(object message, Object context) { }

	// RVA: 0x1828FB0 Offset: 0x18275B0 VA: 0x181828FB0
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x1828C60 Offset: 0x1827260 VA: 0x181828C60
	public static void LogError(object message) { }

	// RVA: 0x1828D30 Offset: 0x1827330 VA: 0x181828D30
	public static void LogError(object message, Object context) { }

	// RVA: 0x1828B80 Offset: 0x1827180 VA: 0x181828B80
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x1828A90 Offset: 0x1827090 VA: 0x181828A90
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x1828EE0 Offset: 0x18274E0 VA: 0x181828EE0
	public static void LogException(Exception exception) { }

	// RVA: 0x1828E10 Offset: 0x1827410 VA: 0x181828E10
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x1829260 Offset: 0x1827860 VA: 0x181829260
	public static void LogWarning(object message) { }

	// RVA: 0x1829330 Offset: 0x1827930 VA: 0x181829330
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x1829090 Offset: 0x1827690 VA: 0x181829090
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x1829170 Offset: 0x1827770 VA: 0x181829170
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1827F60 Offset: 0x1826560 VA: 0x181827F60
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1828040 Offset: 0x1826640 VA: 0x181828040
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1828120 Offset: 0x1826720 VA: 0x181828120
	public static void Assert(bool condition, string message, Object context) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x18289C0 Offset: 0x1826FC0 VA: 0x1818289C0
	public static void LogAssertion(object message) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1828210 Offset: 0x1826810 VA: 0x181828210
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	// RVA: 0x18295C0 Offset: 0x1827BC0 VA: 0x1818295C0
	private static void .cctor() { }

	// RVA: 0x1828380 Offset: 0x1826980 VA: 0x181828380
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

public static class Debug // TypeDefIndex: 7146
{	// Fields
	private static TextWriter writer; // 0x2B104E4

	// Methods

	// RVA: 0x22E52D0 Offset: 0x22E38D0 VA: 0x1822E52D0
	private static void .cctor() { }

	// RVA: 0x22E5080 Offset: 0x22E3680 VA: 0x1822E5080
	public static void SetOut(TextWriter writer) { }

	// RVA: 0x22E5220 Offset: 0x22E3820 VA: 0x1822E5220
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

	// RVA: 0x22E5480 Offset: 0x22E3A80 VA: 0x1822E5480
	public void .ctor(Debug.WriterDelegate writer) { }

	// RVA: 0x22E5460 Offset: 0x22E3A60 VA: 0x1822E5460 Slot: 19
	public override void WriteLine(string value) { }

}

private sealed class Debug.DummyWriter.<>c // TypeDefIndex: 7149
{	// Fields
	public static readonly Debug.DummyWriter.<>c <>9; // 0x0
	public static Debug.WriterDelegate <>9__3_0; // 0x8

	// Methods

	// RVA: 0x22E8680 Offset: 0x22E6C80 VA: 0x1822E8680
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__3_0(string msg) { }

}

