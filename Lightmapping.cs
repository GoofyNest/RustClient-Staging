public static class Lightmapping // TypeDefIndex: 3888
{	// Fields
	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181EFE0 Offset: 0x181D5E0 VA: 0x18181EFE0
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181EE40 Offset: 0x181D440 VA: 0x18181EE40
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181EF70 Offset: 0x181D570 VA: 0x18181EF70
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181EEA0 Offset: 0x181D4A0 VA: 0x18181EEA0
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x181F070 Offset: 0x181D670 VA: 0x18181F070
	private static void .cctor() { }

}

public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 3889
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17FE430 Offset: 0x17FCA30 VA: 0x1817FE430 Slot: 12
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	// RVA: 0x1820600 Offset: 0x181EC00 VA: 0x181820600 Slot: 13
	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class Lightmapping.<>c // TypeDefIndex: 3890
{	// Fields
	public static readonly Lightmapping.<>c <>9; // 0x145F3

	// Methods

	// RVA: 0x18210C0 Offset: 0x181F6C0 VA: 0x1818210C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1820CE0 Offset: 0x181F2E0 VA: 0x181820CE0
	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

}

