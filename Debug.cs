internal static class Debug // TypeDefIndex: 2456
{	// Methods

	// RVA: 0x12175D0 Offset: 0x1215BD0 VA: 0x1812175D0
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	// RVA: 0x12174B0 Offset: 0x1215AB0 VA: 0x1812174B0
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

public class Debug // TypeDefIndex: 3371
{	// Fields
	internal static ILogger s_Logger; // 0x14420

	// Properties
	public static ILogger unityLogger { get; }

	// Methods

	// RVA: 0x1816D40 Offset: 0x1815340 VA: 0x181816D40
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1815AF0 Offset: 0x18140F0 VA: 0x181815AF0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1815CC0 Offset: 0x18142C0 VA: 0x181815CC0
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunctionAttribute] // RVA: 0x7BEA0 Offset: 0x7B2A0 VA: 0x18007BEA0
	// RVA: 0x1815C10 Offset: 0x1814210 VA: 0x181815C10
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1816000 Offset: 0x1814600 VA: 0x181816000
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1815DD0 Offset: 0x18143D0 VA: 0x181815DD0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0x1815E80 Offset: 0x1814480 VA: 0x181815E80
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	// RVA: 0x1816B10 Offset: 0x1815110 VA: 0x181816B10
	public static void Log(object message) { }

	// RVA: 0x1816BE0 Offset: 0x18151E0 VA: 0x181816BE0
	public static void Log(object message, Object context) { }

	// RVA: 0x18166B0 Offset: 0x1814CB0 VA: 0x1818166B0
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x1816360 Offset: 0x1814960 VA: 0x181816360
	public static void LogError(object message) { }

	// RVA: 0x1816430 Offset: 0x1814A30 VA: 0x181816430
	public static void LogError(object message, Object context) { }

	// RVA: 0x1816280 Offset: 0x1814880 VA: 0x181816280
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x1816190 Offset: 0x1814790 VA: 0x181816190
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x18165E0 Offset: 0x1814BE0 VA: 0x1818165E0
	public static void LogException(Exception exception) { }

	// RVA: 0x1816510 Offset: 0x1814B10 VA: 0x181816510
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x1816960 Offset: 0x1814F60 VA: 0x181816960
	public static void LogWarning(object message) { }

	// RVA: 0x1816A30 Offset: 0x1815030 VA: 0x181816A30
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x1816790 Offset: 0x1814D90 VA: 0x181816790
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x1816870 Offset: 0x1814E70 VA: 0x181816870
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1815660 Offset: 0x1813C60 VA: 0x181815660
	public static void Assert(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1815740 Offset: 0x1813D40 VA: 0x181815740
	public static void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x1815820 Offset: 0x1813E20 VA: 0x181815820
	public static void Assert(bool condition, string message, Object context) { }

	[ConditionalAttribute] // RVA: 0x7CDB0 Offset: 0x7C1B0 VA: 0x18007CDB0
	// RVA: 0x18160C0 Offset: 0x18146C0 VA: 0x1818160C0
	public static void LogAssertion(object message) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1815910 Offset: 0x1813F10 VA: 0x181815910
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	// RVA: 0x1816CC0 Offset: 0x18152C0 VA: 0x181816CC0
	private static void .cctor() { }

	// RVA: 0x1815A80 Offset: 0x1814080 VA: 0x181815A80
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

public static class Debug // TypeDefIndex: 7146
{	// Fields
	private static TextWriter writer; // 0x126B5

	// Methods

	// RVA: 0x22E5DB0 Offset: 0x22E43B0 VA: 0x1822E5DB0
	private static void .cctor() { }

	// RVA: 0x22E5B60 Offset: 0x22E4160 VA: 0x1822E5B60
	public static void SetOut(TextWriter writer) { }

	// RVA: 0x22E5D00 Offset: 0x22E4300 VA: 0x1822E5D00
	public static void WriteLine(string format, object[] args) { }

}

public sealed class Debug.WriterDelegate : MulticastDelegate // TypeDefIndex: 7147
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E9640 Offset: 0x12E7C40 VA: 0x1812E9640 Slot: 12
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

	// RVA: 0x1616BD0 Offset: 0x16151D0 VA: 0x181616BD0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x22E5F60 Offset: 0x22E4560 VA: 0x1822E5F60
	public void .ctor(Debug.WriterDelegate writer) { }

	// RVA: 0x22E5F40 Offset: 0x22E4540 VA: 0x1822E5F40 Slot: 19
	public override void WriteLine(string value) { }

}

private sealed class Debug.DummyWriter.<>c // TypeDefIndex: 7149
{	// Fields
	public static readonly Debug.DummyWriter.<>c <>9; // 0x0
	public static Debug.WriterDelegate <>9__3_0; // 0x8

	// Methods

	// RVA: 0x22E9160 Offset: 0x22E7760 VA: 0x1822E9160
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <.ctor>b__3_0(string msg) { }

}

