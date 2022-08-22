public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
{
// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14647E0 Offset: 0x1462DE0 VA: 0x1814647E0 Slot: 12
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

	// RVA: 0x2276680 Offset: 0x2274C80 VA: 0x182276680
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x2276700 Offset: 0x2274D00 VA: 0x182276700 Slot: 8
	public override string get_StackTrace() { }

}

internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 4466
{	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x2277EA0 Offset: 0x22764A0 VA: 0x182277EA0
	public void .ctor(AndroidJavaRunnable runnable) { }

}

public class AndroidJavaProxy // TypeDefIndex: 4467
{	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x2277DA0 Offset: 0x22763A0 VA: 0x182277DA0
	public void .ctor(string javaInterface) { }

	// RVA: 0x2277E40 Offset: 0x2276440 VA: 0x182277E40
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x2277130 Offset: 0x2275730 VA: 0x182277130 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2277560 Offset: 0x2275B60 VA: 0x182277560 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x2277380 Offset: 0x2275980 VA: 0x182277380 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x2277210 Offset: 0x2275810 VA: 0x182277210
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x2277270 Offset: 0x2275870 VA: 0x182277270
	internal IntPtr GetRawProxy() { }

	// RVA: 0x2277CD0 Offset: 0x22762D0 VA: 0x182277CD0
	private static void .cctor() { }

}

public class AndroidJavaObject : IDisposable // TypeDefIndex: 4468
{	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x22770F0 Offset: 0x22756F0 VA: 0x1822770F0
	public void .ctor(string className, object[] args) { }

	// RVA: 0x2276A00 Offset: 0x2275000 VA: 0x182276A00 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	public IntPtr GetRawObject() { }

	// RVA: 0x855290 Offset: 0x853890 VA: 0x180855290
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244D70 Offset: 0x1243370 VA: 0x181244D70
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
	|-RVA: 0x1244D70 Offset: 0x1243370 VA: 0x181244D70
	|-AndroidJavaObject.CallStatic<int>
	|-AndroidJavaObject.CallStatic<object>
	|-AndroidJavaObject.CallStatic<AndroidJavaObject>
	*/

	// RVA: 0x2276970 Offset: 0x2274F70 VA: 0x182276970
	protected void DebugPrint(string msg) { }

	// RVA: 0x2276B70 Offset: 0x2275170 VA: 0x182276B70
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x2276FA0 Offset: 0x22755A0 VA: 0x182276FA0
	internal void .ctor(IntPtr jobject) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x2276AD0 Offset: 0x22750D0 VA: 0x182276AD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2276A70 Offset: 0x2275070 VA: 0x182276A70 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1246980 Offset: 0x1244F80 VA: 0x181246980
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x12477D0 Offset: 0x1245DD0 VA: 0x1812477D0
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x1248620 Offset: 0x1246C20 VA: 0x181248620
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x1249500 Offset: 0x1247B00 VA: 0x181249500
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x124A350 Offset: 0x1248950 VA: 0x18124A350
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x124B170 Offset: 0x1249770 VA: 0x18124B170
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x124BFB0 Offset: 0x124A5B0 VA: 0x18124BFB0
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x124CD80 Offset: 0x124B380 VA: 0x18124CD80
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x124DBD0 Offset: 0x124C1D0 VA: 0x18124DBD0
	|-AndroidJavaObject._Call<float>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244D90 Offset: 0x1243390 VA: 0x181244D90
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x1245BB0 Offset: 0x12441B0 VA: 0x181245BB0
	|-AndroidJavaObject._CallStatic<object>
	*/

	// RVA: 0x2276850 Offset: 0x2274E50 VA: 0x182276850
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x2276730 Offset: 0x2274D30 VA: 0x182276730
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	protected IntPtr _GetRawObject() { }

	// RVA: 0x855290 Offset: 0x853890 VA: 0x180855290
	protected IntPtr _GetRawClass() { }

	// RVA: 0x2276F60 Offset: 0x2275560 VA: 0x182276F60
	private static void .cctor() { }

}

public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 4469
{	// Methods

	// RVA: 0x2276550 Offset: 0x2274B50 VA: 0x182276550
	public void .ctor(string className) { }

	// RVA: 0x2276360 Offset: 0x2274960 VA: 0x182276360
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x2276450 Offset: 0x2274A50 VA: 0x182276450
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

	// RVA: 0x22786B0 Offset: 0x2276CB0 VA: 0x1822786B0
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x2278680 Offset: 0x2276C80 VA: 0x182278680
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x2278570 Offset: 0x2276B70 VA: 0x182278570
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x22781A0 Offset: 0x22767A0 VA: 0x1822781A0
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x2277FA0 Offset: 0x22765A0 VA: 0x182277FA0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x22782B0 Offset: 0x22768B0 VA: 0x1822782B0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x22786D0 Offset: 0x2276CD0 VA: 0x1822786D0
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x22787C0 Offset: 0x2276DC0 VA: 0x1822787C0
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x2278900 Offset: 0x2276F00 VA: 0x182278900
	private static void .cctor() { }

}

public static class AndroidJNIHelper // TypeDefIndex: 4473
{	// Methods

	// RVA: 0x22728F0 Offset: 0x2270EF0 VA: 0x1822728F0
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x2272900 Offset: 0x2270F00 VA: 0x182272900
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2272590 Offset: 0x2270B90 VA: 0x182272590
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x22723C0 Offset: 0x22709C0 VA: 0x1822723C0
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x22723B0 Offset: 0x22709B0 VA: 0x1822723B0
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x22726C0 Offset: 0x2270CC0 VA: 0x1822726C0
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x22727F0 Offset: 0x2270DF0 VA: 0x1822727F0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244D60 Offset: 0x1243360 VA: 0x181244D60
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
	|-RVA: 0xEC1B40 Offset: 0xEC0140 VA: 0x180EC1B40
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
	// RVA: 0x2275A50 Offset: 0x2274050 VA: 0x182275A50
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C50 Offset: 0x2274250 VA: 0x182275C50
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275A20 Offset: 0x2274020 VA: 0x182275A20
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22759F0 Offset: 0x2273FF0 VA: 0x1822759F0
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275ED0 Offset: 0x22744D0 VA: 0x182275ED0
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275930 Offset: 0x2273F30 VA: 0x182275930
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276040 Offset: 0x2274640 VA: 0x182276040
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22759B0 Offset: 0x2273FB0 VA: 0x1822759B0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275F10 Offset: 0x2274510 VA: 0x182275F10
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275970 Offset: 0x2273F70 VA: 0x182275970
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275FA0 Offset: 0x22745A0 VA: 0x182275FA0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275DF0 Offset: 0x22743F0 VA: 0x182275DF0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275D50 Offset: 0x2274350 VA: 0x182275D50
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275E30 Offset: 0x2274430 VA: 0x182275E30
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2276000 Offset: 0x2274600 VA: 0x182276000
	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276000 Offset: 0x2274600 VA: 0x182276000
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275E90 Offset: 0x2274490 VA: 0x182275E90
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22758D0 Offset: 0x2273ED0 VA: 0x1822758D0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275390 Offset: 0x2273990 VA: 0x182275390
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22752D0 Offset: 0x22738D0 VA: 0x1822752D0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275150 Offset: 0x2273750 VA: 0x182275150
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275450 Offset: 0x2273A50 VA: 0x182275450
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22753F0 Offset: 0x22739F0 VA: 0x1822753F0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22751B0 Offset: 0x22737B0 VA: 0x1822751B0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275270 Offset: 0x2273870 VA: 0x182275270
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275210 Offset: 0x2273810 VA: 0x182275210
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275330 Offset: 0x2273930 VA: 0x182275330
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275810 Offset: 0x2273E10 VA: 0x182275810
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22756F0 Offset: 0x2273CF0 VA: 0x1822756F0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275630 Offset: 0x2273C30 VA: 0x182275630
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22754B0 Offset: 0x2273AB0 VA: 0x1822754B0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22757B0 Offset: 0x2273DB0 VA: 0x1822757B0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275750 Offset: 0x2273D50 VA: 0x182275750
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275510 Offset: 0x2273B10 VA: 0x182275510
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22755D0 Offset: 0x2273BD0 VA: 0x1822755D0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275570 Offset: 0x2273B70 VA: 0x182275570
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275690 Offset: 0x2273C90 VA: 0x182275690
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275870 Offset: 0x2273E70 VA: 0x182275870
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22760D0 Offset: 0x22746D0 VA: 0x1822760D0
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0xC15F0 Offset: 0xC09F0 VA: 0x1800C15F0
	[ObsoleteAttribute] // RVA: 0xC15F0 Offset: 0xC09F0 VA: 0x1800C15F0
	// RVA: 0x2276110 Offset: 0x2274710 VA: 0x182276110
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22762E0 Offset: 0x22748E0 VA: 0x1822762E0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276150 Offset: 0x2274750 VA: 0x182276150
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276320 Offset: 0x2274920 VA: 0x182276320
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276210 Offset: 0x2274810 VA: 0x182276210
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276250 Offset: 0x2274850 VA: 0x182276250
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22761D0 Offset: 0x22747D0 VA: 0x1822761D0
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276190 Offset: 0x2274790 VA: 0x182276190
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276290 Offset: 0x2274890 VA: 0x182276290
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275A90 Offset: 0x2274090 VA: 0x182275A90
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0xC1E10 Offset: 0xC1210 VA: 0x1800C1E10
	[ThreadSafeAttribute] // RVA: 0xC1E10 Offset: 0xC1210 VA: 0x1800C1E10
	// RVA: 0x2275AD0 Offset: 0x22740D0 VA: 0x182275AD0
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C90 Offset: 0x2274290 VA: 0x182275C90
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275B10 Offset: 0x2274110 VA: 0x182275B10
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275CD0 Offset: 0x22742D0 VA: 0x182275CD0
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275BD0 Offset: 0x22741D0 VA: 0x182275BD0
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275C10 Offset: 0x2274210 VA: 0x182275C10
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275B90 Offset: 0x2274190 VA: 0x182275B90
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275B50 Offset: 0x2274150 VA: 0x182275B50
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275D10 Offset: 0x2274310 VA: 0x182275D10
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275F50 Offset: 0x2274550 VA: 0x182275F50
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2275DB0 Offset: 0x22743B0 VA: 0x182275DB0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x2276080 Offset: 0x2274680 VA: 0x182276080
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

internal class AndroidJNISafe // TypeDefIndex: 4475
{	// Methods

	// RVA: 0x22739E0 Offset: 0x2271FE0 VA: 0x1822739E0
	public static void CheckException() { }

	// RVA: 0x2273B90 Offset: 0x2272190 VA: 0x182273B90
	public static void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x2273C70 Offset: 0x2272270 VA: 0x182273C70
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x2273C00 Offset: 0x2272200 VA: 0x182273C00
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x22749B0 Offset: 0x2272FB0 VA: 0x1822749B0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x2274830 Offset: 0x2272E30 VA: 0x182274830
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x22746B0 Offset: 0x2272CB0 VA: 0x1822746B0
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x2274760 Offset: 0x2272D60 VA: 0x182274760
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2274520 Offset: 0x2272B20 VA: 0x182274520
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x2274260 Offset: 0x2272860 VA: 0x182274260
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x2273CE0 Offset: 0x22722E0 VA: 0x182273CE0
	public static IntPtr FindClass(string name) { }

	// RVA: 0x22748E0 Offset: 0x2272EE0 VA: 0x1822748E0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273860 Offset: 0x2271E60 VA: 0x182273860
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273520 Offset: 0x2271B20 VA: 0x182273520
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273790 Offset: 0x2271D90 VA: 0x182273790
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273120 Offset: 0x2271720 VA: 0x182273120
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22731F0 Offset: 0x22717F0 VA: 0x1822731F0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22732C0 Offset: 0x22718C0 VA: 0x1822732C0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273450 Offset: 0x2271A50 VA: 0x182273450
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22736C0 Offset: 0x2271CC0 VA: 0x1822736C0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22735F0 Offset: 0x2271BF0 VA: 0x1822735F0
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273050 Offset: 0x2271650 VA: 0x182273050
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273390 Offset: 0x2271990 VA: 0x182273390
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272DE0 Offset: 0x22713E0 VA: 0x182272DE0
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273910 Offset: 0x2271F10 VA: 0x182273910
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x22729E0 Offset: 0x2270FE0 VA: 0x1822729E0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272AB0 Offset: 0x22710B0 VA: 0x182272AB0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272B80 Offset: 0x2271180 VA: 0x182272B80
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272D10 Offset: 0x2271310 VA: 0x182272D10
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272F80 Offset: 0x2271580 VA: 0x182272F80
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272EB0 Offset: 0x22714B0 VA: 0x182272EB0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272910 Offset: 0x2270F10 VA: 0x182272910
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2272C50 Offset: 0x2271250 VA: 0x182272C50
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2273EF0 Offset: 0x22724F0 VA: 0x182273EF0
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x2273FA0 Offset: 0x22725A0 VA: 0x182273FA0
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x2274050 Offset: 0x2272650 VA: 0x182274050
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x22741B0 Offset: 0x22727B0 VA: 0x1822741B0
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x22743C0 Offset: 0x22729C0 VA: 0x1822743C0
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x2273E40 Offset: 0x2272440 VA: 0x182273E40
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x2274310 Offset: 0x2272910 VA: 0x182274310
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x2273D90 Offset: 0x2272390 VA: 0x182273D90
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x2274100 Offset: 0x2272700 VA: 0x182274100
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x2274F30 Offset: 0x2273530 VA: 0x182274F30
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x2274BC0 Offset: 0x22731C0 VA: 0x182274BC0
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x2274C70 Offset: 0x2273270 VA: 0x182274C70
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x2274D20 Offset: 0x2273320 VA: 0x182274D20
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x2274E80 Offset: 0x2273480 VA: 0x182274E80
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x22750A0 Offset: 0x22736A0 VA: 0x1822750A0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x2274B10 Offset: 0x2273110 VA: 0x182274B10
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2274FF0 Offset: 0x22735F0 VA: 0x182274FF0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x2274A60 Offset: 0x2273060 VA: 0x182274A60
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x2274DD0 Offset: 0x22733D0 VA: 0x182274DD0
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x22745F0 Offset: 0x2272BF0 VA: 0x1822745F0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x2274470 Offset: 0x2272A70 VA: 0x182274470
	public static int GetArrayLength(IntPtr array) { }

}

