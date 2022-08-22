public static class Lightmapping // TypeDefIndex: 3888
{	// Fields
	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1831BA0 Offset: 0x18301A0 VA: 0x181831BA0
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1831A00 Offset: 0x1830000 VA: 0x181831A00
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1831B30 Offset: 0x1830130 VA: 0x181831B30
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1831A60 Offset: 0x1830060 VA: 0x181831A60
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x1831C30 Offset: 0x1830230 VA: 0x181831C30
	private static void .cctor() { }

}

public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 3889
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1810FF0 Offset: 0x180F5F0 VA: 0x181810FF0 Slot: 12
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	// RVA: 0x1832CC0 Offset: 0x18312C0 VA: 0x181832CC0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Lightmapping.<>c // TypeDefIndex: 3890
{	// Fields
	public static readonly Lightmapping.<>c <>9; // 0x2B111C0

	// Methods

	// RVA: 0x1833780 Offset: 0x1831D80 VA: 0x181833780
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18333A0 Offset: 0x18319A0 VA: 0x1818333A0
	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

}

