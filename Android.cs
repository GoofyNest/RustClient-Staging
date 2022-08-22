public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
{
// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14638B0 Offset: 0x1461EB0 VA: 0x1814638B0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AndroidJavaException : Exception // TypeDefIndex: 4464
{	// Fields
	private string mJavaStackTrace; // 0x88

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x2276EA0 Offset: 0x22754A0 VA: 0x182276EA0
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x2276F20 Offset: 0x2275520 VA: 0x182276F20 Slot: 8
	public override string get_StackTrace() { }

}

internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 4466
{	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x22786C0 Offset: 0x2276CC0 VA: 0x1822786C0
	public void .ctor(AndroidJavaRunnable runnable) { }

}

public class AndroidJavaProxy // TypeDefIndex: 4467
{	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x22785C0 Offset: 0x2276BC0 VA: 0x1822785C0
	public void .ctor(string javaInterface) { }

	// RVA: 0x2278660 Offset: 0x2276C60 VA: 0x182278660
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x2277950 Offset: 0x2275F50 VA: 0x182277950 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2277D80 Offset: 0x2276380 VA: 0x182277D80 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x2277BA0 Offset: 0x22761A0 VA: 0x182277BA0 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x2277A30 Offset: 0x2276030 VA: 0x182277A30
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x2277A90 Offset: 0x2276090 VA: 0x182277A90
	internal IntPtr GetRawProxy() { }

	// RVA: 0x22784F0 Offset: 0x2276AF0 VA: 0x1822784F0
	private static void .cctor() { }

}

public class AndroidJavaObject : IDisposable // TypeDefIndex: 4468
{	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x2277910 Offset: 0x2275F10 VA: 0x182277910
	public void .ctor(string className, object[] args) { }

	// RVA: 0x2277220 Offset: 0x2275820 VA: 0x182277220 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D20B0 Offset: 0x4D06B0 VA: 0x1804D20B0
	public IntPtr GetRawObject() { }

	// RVA: 0x8557E0 Offset: 0x853DE0 VA: 0x1808557E0
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1245410 Offset: 0x1243A10 VA: 0x181245410
	|-AndroidJavaObject.Call<bool>
	|-AndroidJavaObject.Call<char>
	|-AndroidJavaObject.Call<double>
	|-AndroidJavaObject.Call<short>
	|-AndroidJavaObject.Call<int>
	|-AndroidJavaObject.Call<long>
	|-AndroidJavaObject.Call<object>
	|-AndroidJavaObject.Call<sbyte>
	|-AndroidJavaObject.Call<float>
	|-AndroidJavaObject.Call<string>
	|-AndroidJavaObject.Call<AndroidJavaObject>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1245410 Offset: 0x1243A10 VA: 0x181245410
	|-AndroidJavaObject.CallStatic<int>
	|-AndroidJavaObject.CallStatic<object>
	|-AndroidJavaObject.CallStatic<AndroidJavaObject>
	*/

	// RVA: 0x2277190 Offset: 0x2275790 VA: 0x182277190
	protected void DebugPrint(string msg) { }

	// RVA: 0x2277390 Offset: 0x2275990 VA: 0x182277390
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x22777C0 Offset: 0x2275DC0 VA: 0x1822777C0
	internal void .ctor(IntPtr jobject) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x22772F0 Offset: 0x22758F0 VA: 0x1822772F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2277290 Offset: 0x2275890 VA: 0x182277290 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1247020 Offset: 0x1245620 VA: 0x181247020
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x1247E70 Offset: 0x1246470 VA: 0x181247E70
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x1248CC0 Offset: 0x12472C0 VA: 0x181248CC0
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x1249BA0 Offset: 0x12481A0 VA: 0x181249BA0
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x124A9F0 Offset: 0x1248FF0 VA: 0x18124A9F0
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x124B810 Offset: 0x1249E10 VA: 0x18124B810
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x124C650 Offset: 0x124AC50 VA: 0x18124C650
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x124D420 Offset: 0x124BA20 VA: 0x18124D420
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x124E270 Offset: 0x124C870 VA: 0x18124E270
	|-AndroidJavaObject._Call<float>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1245430 Offset: 0x1243A30 VA: 0x181245430
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x1246250 Offset: 0x1244850 VA: 0x181246250
	|-AndroidJavaObject._CallStatic<object>
	*/

	// RVA: 0x2277070 Offset: 0x2275670 VA: 0x182277070
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x2276F50 Offset: 0x2275550 VA: 0x182276F50
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x4D20B0 Offset: 0x4D06B0 VA: 0x1804D20B0
	protected IntPtr _GetRawObject() { }

	// RVA: 0x8557E0 Offset: 0x853DE0 VA: 0x1808557E0
	protected IntPtr _GetRawClass() { }

	// RVA: 0x2277780 Offset: 0x2275D80 VA: 0x182277780
	private static void .cctor() { }

}

public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 4469
{	// Methods

	// RVA: 0x2276D70 Offset: 0x2275370 VA: 0x182276D70
	public void .ctor(string className) { }

	// RVA: 0x2276B80 Offset: 0x2275180 VA: 0x182276B80
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x2276C70 Offset: 0x2275270 VA: 0x182276C70
	internal void .ctor(IntPtr jclass) { }

}

internal class AndroidReflection // TypeDefIndex: 4470
{	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x2278ED0 Offset: 0x22774D0 VA: 0x182278ED0
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x2278EA0 Offset: 0x22774A0 VA: 0x182278EA0
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x2278D90 Offset: 0x2277390 VA: 0x182278D90
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x22789C0 Offset: 0x2276FC0 VA: 0x1822789C0
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x22787C0 Offset: 0x2276DC0 VA: 0x1822787C0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x2278AD0 Offset: 0x22770D0 VA: 0x182278AD0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2278EF0 Offset: 0x22774F0 VA: 0x182278EF0
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x2278FE0 Offset: 0x22775E0 VA: 0x182278FE0
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x2279120 Offset: 0x2277720 VA: 0x182279120
	private static void .cctor() { }

}

public static class AndroidJNIHelper // TypeDefIndex: 4473
{	// Methods

	// RVA: 0x2273110 Offset: 0x2271710 VA: 0x182273110
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x2273120 Offset: 0x2271720 VA: 0x182273120
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2272DB0 Offset: 0x22713B0 VA: 0x182272DB0
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x2272BE0 Offset: 0x22711E0 VA: 0x182272BE0
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x2272BD0 Offset: 0x22711D0 VA: 0x182272BD0
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x2272EE0 Offset: 0x22714E0 VA: 0x182272EE0
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x2273010 Offset: 0x2271610 VA: 0x182273010
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1245400 Offset: 0x1243A00 VA: 0x181245400
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC25F0 Offset: 0xEC0BF0 VA: 0x180EC25F0
	|-AndroidJNIHelper.GetMethodID<bool>
	|-AndroidJNIHelper.GetMethodID<char>
	|-AndroidJNIHelper.GetMethodID<double>
	|-AndroidJNIHelper.GetMethodID<short>
	|-AndroidJNIHelper.GetMethodID<int>
	|-AndroidJNIHelper.GetMethodID<long>
	|-AndroidJNIHelper.GetMethodID<object>
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|-AndroidJNIHelper.GetMethodID<float>
	*/

}

public static class AndroidJNI // TypeDefIndex: 4474
{	// Methods

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276270 Offset: 0x2274870 VA: 0x182276270
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276470 Offset: 0x2274A70 VA: 0x182276470
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276240 Offset: 0x2274840 VA: 0x182276240
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276210 Offset: 0x2274810 VA: 0x182276210
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22766F0 Offset: 0x2274CF0 VA: 0x1822766F0
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276150 Offset: 0x2274750 VA: 0x182276150
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276860 Offset: 0x2274E60 VA: 0x182276860
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22761D0 Offset: 0x22747D0 VA: 0x1822761D0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276730 Offset: 0x2274D30 VA: 0x182276730
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276190 Offset: 0x2274790 VA: 0x182276190
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22767C0 Offset: 0x2274DC0 VA: 0x1822767C0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276610 Offset: 0x2274C10 VA: 0x182276610
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276570 Offset: 0x2274B70 VA: 0x182276570
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276650 Offset: 0x2274C50 VA: 0x182276650
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2276820 Offset: 0x2274E20 VA: 0x182276820
	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276820 Offset: 0x2274E20 VA: 0x182276820
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22766B0 Offset: 0x2274CB0 VA: 0x1822766B0
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22760F0 Offset: 0x22746F0 VA: 0x1822760F0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275BB0 Offset: 0x22741B0 VA: 0x182275BB0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275AF0 Offset: 0x22740F0 VA: 0x182275AF0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275970 Offset: 0x2273F70 VA: 0x182275970
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C70 Offset: 0x2274270 VA: 0x182275C70
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C10 Offset: 0x2274210 VA: 0x182275C10
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22759D0 Offset: 0x2273FD0 VA: 0x1822759D0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275A90 Offset: 0x2274090 VA: 0x182275A90
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275A30 Offset: 0x2274030 VA: 0x182275A30
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275B50 Offset: 0x2274150 VA: 0x182275B50
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276030 Offset: 0x2274630 VA: 0x182276030
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275F10 Offset: 0x2274510 VA: 0x182275F10
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275E50 Offset: 0x2274450 VA: 0x182275E50
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275CD0 Offset: 0x22742D0 VA: 0x182275CD0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275FD0 Offset: 0x22745D0 VA: 0x182275FD0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275F70 Offset: 0x2274570 VA: 0x182275F70
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275D30 Offset: 0x2274330 VA: 0x182275D30
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275DF0 Offset: 0x22743F0 VA: 0x182275DF0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275D90 Offset: 0x2274390 VA: 0x182275D90
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275EB0 Offset: 0x22744B0 VA: 0x182275EB0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276090 Offset: 0x2274690 VA: 0x182276090
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22768F0 Offset: 0x2274EF0 VA: 0x1822768F0
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0xC15F0 Offset: 0xC09F0 VA: 0x1800C15F0
	[ObsoleteAttribute] // RVA: 0xC15F0 Offset: 0xC09F0 VA: 0x1800C15F0
	// RVA: 0x2276930 Offset: 0x2274F30 VA: 0x182276930
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276B00 Offset: 0x2275100 VA: 0x182276B00
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276970 Offset: 0x2274F70 VA: 0x182276970
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276B40 Offset: 0x2275140 VA: 0x182276B40
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276A30 Offset: 0x2275030 VA: 0x182276A30
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276A70 Offset: 0x2275070 VA: 0x182276A70
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22769F0 Offset: 0x2274FF0 VA: 0x1822769F0
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22769B0 Offset: 0x2274FB0 VA: 0x1822769B0
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276AB0 Offset: 0x22750B0 VA: 0x182276AB0
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22762B0 Offset: 0x22748B0 VA: 0x1822762B0
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0xC1E10 Offset: 0xC1210 VA: 0x1800C1E10
	[ThreadSafeAttribute] // RVA: 0xC1E10 Offset: 0xC1210 VA: 0x1800C1E10
	// RVA: 0x22762F0 Offset: 0x22748F0 VA: 0x1822762F0
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22764B0 Offset: 0x2274AB0 VA: 0x1822764B0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276330 Offset: 0x2274930 VA: 0x182276330
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22764F0 Offset: 0x2274AF0 VA: 0x1822764F0
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22763F0 Offset: 0x22749F0 VA: 0x1822763F0
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276430 Offset: 0x2274A30 VA: 0x182276430
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22763B0 Offset: 0x22749B0 VA: 0x1822763B0
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276370 Offset: 0x2274970 VA: 0x182276370
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276530 Offset: 0x2274B30 VA: 0x182276530
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276770 Offset: 0x2274D70 VA: 0x182276770
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22765D0 Offset: 0x2274BD0 VA: 0x1822765D0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22768A0 Offset: 0x2274EA0 VA: 0x1822768A0
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

internal class AndroidJNISafe // TypeDefIndex: 4475
{	// Methods

	// RVA: 0x2274200 Offset: 0x2272800 VA: 0x182274200
	public static void CheckException() { }

	// RVA: 0x22743B0 Offset: 0x22729B0 VA: 0x1822743B0
	public static void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x2274490 Offset: 0x2272A90 VA: 0x182274490
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x2274420 Offset: 0x2272A20 VA: 0x182274420
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x22751D0 Offset: 0x22737D0 VA: 0x1822751D0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x2275050 Offset: 0x2273650 VA: 0x182275050
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x2274ED0 Offset: 0x22734D0 VA: 0x182274ED0
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x2274F80 Offset: 0x2273580 VA: 0x182274F80
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2274D40 Offset: 0x2273340 VA: 0x182274D40
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x2274A80 Offset: 0x2273080 VA: 0x182274A80
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x2274500 Offset: 0x2272B00 VA: 0x182274500
	public static IntPtr FindClass(string name) { }

	// RVA: 0x2275100 Offset: 0x2273700 VA: 0x182275100
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2274080 Offset: 0x2272680 VA: 0x182274080
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273D40 Offset: 0x2272340 VA: 0x182273D40
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273FB0 Offset: 0x22725B0 VA: 0x182273FB0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273940 Offset: 0x2271F40 VA: 0x182273940
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273A10 Offset: 0x2272010 VA: 0x182273A10
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273AE0 Offset: 0x22720E0 VA: 0x182273AE0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273C70 Offset: 0x2272270 VA: 0x182273C70
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273EE0 Offset: 0x22724E0 VA: 0x182273EE0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273E10 Offset: 0x2272410 VA: 0x182273E10
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273870 Offset: 0x2271E70 VA: 0x182273870
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273BB0 Offset: 0x22721B0 VA: 0x182273BB0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273600 Offset: 0x2271C00 VA: 0x182273600
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2274130 Offset: 0x2272730 VA: 0x182274130
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273200 Offset: 0x2271800 VA: 0x182273200
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22732D0 Offset: 0x22718D0 VA: 0x1822732D0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22733A0 Offset: 0x22719A0 VA: 0x1822733A0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273530 Offset: 0x2271B30 VA: 0x182273530
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22737A0 Offset: 0x2271DA0 VA: 0x1822737A0
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22736D0 Offset: 0x2271CD0 VA: 0x1822736D0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273130 Offset: 0x2271730 VA: 0x182273130
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273470 Offset: 0x2271A70 VA: 0x182273470
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2274710 Offset: 0x2272D10 VA: 0x182274710
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x22747C0 Offset: 0x2272DC0 VA: 0x1822747C0
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x2274870 Offset: 0x2272E70 VA: 0x182274870
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x22749D0 Offset: 0x2272FD0 VA: 0x1822749D0
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x2274BE0 Offset: 0x22731E0 VA: 0x182274BE0
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x2274660 Offset: 0x2272C60 VA: 0x182274660
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x2274B30 Offset: 0x2273130 VA: 0x182274B30
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x22745B0 Offset: 0x2272BB0 VA: 0x1822745B0
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x2274920 Offset: 0x2272F20 VA: 0x182274920
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x2275750 Offset: 0x2273D50 VA: 0x182275750
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x22753E0 Offset: 0x22739E0 VA: 0x1822753E0
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x2275490 Offset: 0x2273A90 VA: 0x182275490
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x2275540 Offset: 0x2273B40 VA: 0x182275540
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x22756A0 Offset: 0x2273CA0 VA: 0x1822756A0
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x22758C0 Offset: 0x2273EC0 VA: 0x1822758C0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x2275330 Offset: 0x2273930 VA: 0x182275330
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2275810 Offset: 0x2273E10 VA: 0x182275810
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x2275280 Offset: 0x2273880 VA: 0x182275280
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x22755F0 Offset: 0x2273BF0 VA: 0x1822755F0
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x2274E10 Offset: 0x2273410 VA: 0x182274E10
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x2274C90 Offset: 0x2273290 VA: 0x182274C90
	public static int GetArrayLength(IntPtr array) { }

}

