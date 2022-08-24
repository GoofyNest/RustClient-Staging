public static class Lightmapping // TypeDefIndex: 3888
{	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	private static void .cctor() { }

}

public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 3889
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Lightmapping.<>c // TypeDefIndex: 3890
{	public static readonly Lightmapping.<>c <>9; // 0x2B117EC


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

}

