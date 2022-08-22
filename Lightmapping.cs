public static class Lightmapping // TypeDefIndex: 3888
{	// Fields
	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18318E0 Offset: 0x182FEE0 VA: 0x1818318E0
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1831740 Offset: 0x182FD40 VA: 0x181831740
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1831870 Offset: 0x182FE70 VA: 0x181831870
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18317A0 Offset: 0x182FDA0 VA: 0x1818317A0
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x1831970 Offset: 0x182FF70 VA: 0x181831970
	private static void .cctor() { }

}

public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 3889
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1810D30 Offset: 0x180F330 VA: 0x181810D30 Slot: 12
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	// RVA: 0x1832A00 Offset: 0x1831000 VA: 0x181832A00 Slot: 13
	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Lightmapping.<>c // TypeDefIndex: 3890
{	// Fields
	public static readonly Lightmapping.<>c <>9; // 0x2B10180

	// Methods

	// RVA: 0x18334C0 Offset: 0x1831AC0 VA: 0x1818334C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18330E0 Offset: 0x18316E0 VA: 0x1818330E0
	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

}

