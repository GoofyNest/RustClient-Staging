internal static class Debug // TypeDefIndex: 2456
{
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

public class Debug // TypeDefIndex: 3371
{	internal static ILogger s_Logger; // 0x139AF

	public static ILogger unityLogger { get; }


	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute] // RVA: 0x7BF80 Offset: 0x7B380 VA: 0x18007BF80
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	public static void Log(object message) { }

	public static void Log(object message, Object context) { }

	public static void LogFormat(string format, object[] args) { }

	public static void LogError(object message) { }

	public static void LogError(object message, Object context) { }

	public static void LogErrorFormat(string format, object[] args) { }

	public static void LogErrorFormat(Object context, string format, object[] args) { }

	public static void LogException(Exception exception) { }

	public static void LogException(Exception exception, Object context) { }

	public static void LogWarning(object message) { }

	public static void LogWarning(object message, Object context) { }

	public static void LogWarningFormat(string format, object[] args) { }

	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	public static void Assert(bool condition, string message, Object context) { }

	[ConditionalAttribute] // RVA: 0x7CE40 Offset: 0x7C240 VA: 0x18007CE40
	public static void LogAssertion(object message) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	private static void .cctor() { }

	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

public static class Debug // TypeDefIndex: 7146
{	private static TextWriter writer; // 0x2B119B8


	private static void .cctor() { }

	public static void SetOut(TextWriter writer) { }

	public static void WriteLine(string format, object[] args) { }

}

public sealed class Debug.WriterDelegate : MulticastDelegate // TypeDefIndex: 7147
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string message) { }

	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Debug.DummyWriter : TextWriter // TypeDefIndex: 7148
{	private Debug.WriterDelegate writer; // 0x28

	public override Encoding Encoding { get; }


	public override Encoding get_Encoding() { }

	public void .ctor(Debug.WriterDelegate writer) { }

	public override void WriteLine(string value) { }

}

private sealed class Debug.DummyWriter.<>c // TypeDefIndex: 7149
{	public static readonly Debug.DummyWriter.<>c <>9; // 0x0
	public static Debug.WriterDelegate <>9__3_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.ctor>b__3_0(string msg) { }

}

