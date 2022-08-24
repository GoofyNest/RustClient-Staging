public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463
{
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 4463

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AndroidJavaException : Exception // TypeDefIndex: 4464
{	private string mJavaStackTrace; // 0x88

	public override string StackTrace { get; }


	internal void .ctor(string message, string javaStackTrace) { }

	public override string get_StackTrace() { }

}

internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 4466
{	private AndroidJavaRunnable mRunnable; // 0x20


	public void .ctor(AndroidJavaRunnable runnable) { }

}

public class AndroidJavaProxy // TypeDefIndex: 4467
{	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8


	public void .ctor(string javaInterface) { }

	public void .ctor(AndroidJavaClass javaInterface) { }

	protected override void Finalize() { }

	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	internal AndroidJavaObject GetProxyObject() { }

	internal IntPtr GetRawProxy() { }

	private static void .cctor() { }

}

public class AndroidJavaObject : IDisposable // TypeDefIndex: 4468
{	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18


	public void .ctor(string className, object[] args) { }

	public void Dispose() { }

	public IntPtr GetRawObject() { }

	public IntPtr GetRawClass() { }

	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
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

	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-AndroidJavaObject.CallStatic<int>
	|-AndroidJavaObject.CallStatic<object>
	|-AndroidJavaObject.CallStatic<AndroidJavaObject>
	*/

	protected void DebugPrint(string msg) { }

	private void _AndroidJavaObject(string className, object[] args) { }

	internal void .ctor(IntPtr jobject) { }

	internal void .ctor() { }

	protected override void Finalize() { }

	protected virtual void Dispose(bool disposing) { }

	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-AndroidJavaObject._Call<bool>
	|
	|-AndroidJavaObject._Call<char>
	|
	|-AndroidJavaObject._Call<double>
	|
	|-AndroidJavaObject._Call<short>
	|
	|-AndroidJavaObject._Call<int>
	|
	|-AndroidJavaObject._Call<long>
	|
	|-AndroidJavaObject._Call<object>
	|
	|-AndroidJavaObject._Call<sbyte>
	|
	|-AndroidJavaObject._Call<float>
	*/

	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-AndroidJavaObject._CallStatic<int>
	|
	|-AndroidJavaObject._CallStatic<object>
	*/

	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	protected IntPtr _GetRawObject() { }

	protected IntPtr _GetRawClass() { }

	private static void .cctor() { }

}

public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 4469
{
	public void .ctor(string className) { }

	private void _AndroidJavaClass(string className) { }

	internal void .ctor(IntPtr jclass) { }

}

internal class AndroidReflection // TypeDefIndex: 4470
{	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38


	public static bool IsPrimitive(Type t) { }

	public static bool IsAssignableFrom(Type t, Type from) { }

	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	private static void .cctor() { }

}

public static class AndroidJNIHelper // TypeDefIndex: 4473
{
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	public static jvalue[] CreateJNIArgArray(object[] args) { }

	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
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

	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
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
{
	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0xC1840 Offset: 0xC0C40 VA: 0x1800C1840
	[ObsoleteAttribute] // RVA: 0xC1840 Offset: 0xC0C40 VA: 0x1800C1840
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0xC2160 Offset: 0xC1560 VA: 0x1800C2160
	[ThreadSafeAttribute] // RVA: 0xC2160 Offset: 0xC1560 VA: 0x1800C2160
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

internal class AndroidJNISafe // TypeDefIndex: 4475
{
	public static void CheckException() { }

	public static void DeleteGlobalRef(IntPtr globalref) { }

	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	public static void DeleteLocalRef(IntPtr localref) { }

	public static IntPtr NewString(string chars) { }

	public static string GetStringChars(IntPtr str) { }

	public static IntPtr GetObjectClass(IntPtr ptr) { }

	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	public static IntPtr FindClass(string name) { }

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static char[] FromCharArray(IntPtr array) { }

	public static double[] FromDoubleArray(IntPtr array) { }

	public static float[] FromFloatArray(IntPtr array) { }

	public static long[] FromLongArray(IntPtr array) { }

	public static short[] FromShortArray(IntPtr array) { }

	public static byte[] FromByteArray(IntPtr array) { }

	public static sbyte[] FromSByteArray(IntPtr array) { }

	public static bool[] FromBooleanArray(IntPtr array) { }

	public static int[] FromIntArray(IntPtr array) { }

	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	public static IntPtr ToCharArray(char[] array) { }

	public static IntPtr ToDoubleArray(double[] array) { }

	public static IntPtr ToFloatArray(float[] array) { }

	public static IntPtr ToLongArray(long[] array) { }

	public static IntPtr ToShortArray(short[] array) { }

	public static IntPtr ToByteArray(byte[] array) { }

	public static IntPtr ToSByteArray(sbyte[] array) { }

	public static IntPtr ToBooleanArray(bool[] array) { }

	public static IntPtr ToIntArray(int[] array) { }

	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	public static int GetArrayLength(IntPtr array) { }

}

