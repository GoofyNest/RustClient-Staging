internal static class GameAnalytics // TypeDefIndex: 5620
{	// Fields
	private static bool _endThread; // 0x33D0

	// Methods

	// RVA: 0x13C8440 Offset: 0x13C6A40 VA: 0x1813C8440
	private static void .cctor() { }

	// RVA: 0x13C74C0 Offset: 0x13C5AC0 VA: 0x1813C74C0
	public static void ConfigureBuild(string build) { }

	// RVA: 0x13C7740 Offset: 0x13C5D40 VA: 0x1813C7740
	public static void ConfigureSdkGameEngineVersion(string sdkGameEngineVersion) { }

	// RVA: 0x13C7600 Offset: 0x13C5C00 VA: 0x1813C7600
	public static void ConfigureGameEngineVersion(string gameEngineVersion) { }

	// RVA: 0x13C7880 Offset: 0x13C5E80 VA: 0x1813C7880
	public static void ConfigureUserId(string uId) { }

	// RVA: 0x13C79C0 Offset: 0x13C5FC0 VA: 0x1813C79C0
	public static void Initialize(string gameKey, string gameSecret) { }

	// RVA: 0x13C7000 Offset: 0x13C5600 VA: 0x1813C7000
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType) { }

	// RVA: 0x13C7340 Offset: 0x13C5940 VA: 0x1813C7340
	public static void AddDesignEvent(string eventId, IDictionary<string, object> fields) { }

	// RVA: 0x13C71C0 Offset: 0x13C57C0 VA: 0x1813C71C0
	public static void AddDesignEvent(string eventId, double value) { }

	// RVA: 0x13C8080 Offset: 0x13C6680 VA: 0x1813C8080
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13C81C0 Offset: 0x13C67C0 VA: 0x1813C81C0
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13C8300 Offset: 0x13C6900 VA: 0x1813C8300
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13C7D50 Offset: 0x13C6350 VA: 0x1813C7D50
	public static void OnQuit() { }

	// RVA: 0x13C7CE0 Offset: 0x13C62E0 VA: 0x1813C7CE0
	private static bool IsSdkReady(bool needsInitialized, bool warn) { }

	// RVA: 0x13C7B40 Offset: 0x13C6140 VA: 0x1813C7B40
	private static bool IsSdkReady(bool needsInitialized, bool warn, string message) { }

}

private sealed class GameAnalytics.<>c__DisplayClass7_0 // TypeDefIndex: 5621
{	// Fields
	public string build; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CEBC0 Offset: 0x13CD1C0 VA: 0x1813CEBC0
	internal void <ConfigureBuild>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass8_0 // TypeDefIndex: 5622
{	// Fields
	public string sdkGameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CEEB0 Offset: 0x13CD4B0 VA: 0x1813CEEB0
	internal void <ConfigureSdkGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass9_0 // TypeDefIndex: 5623
{	// Fields
	public string gameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CF110 Offset: 0x13CD710 VA: 0x1813CF110
	internal void <ConfigureGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass10_0 // TypeDefIndex: 5624
{	// Fields
	public string uId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDF80 Offset: 0x13CC580 VA: 0x1813CDF80
	internal void <ConfigureUserId>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass11_0 // TypeDefIndex: 5625
{	// Fields
	public string gameKey; // 0x10
	public string gameSecret; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE2A0 Offset: 0x13CC8A0 VA: 0x1813CE2A0
	internal void <Initialize>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass12_0 // TypeDefIndex: 5626
{	// Fields
	public string currency; // 0x10
	public int amount; // 0x18
	public string itemType; // 0x20
	public string itemId; // 0x28
	public string cartType; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE760 Offset: 0x13CCD60 VA: 0x1813CE760
	internal void <AddBusinessEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass20_0 // TypeDefIndex: 5627
{	// Fields
	public string eventId; // 0x10
	public IDictionary<string, object> fields; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE840 Offset: 0x13CCE40 VA: 0x1813CE840
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass21_0 // TypeDefIndex: 5628
{	// Fields
	public string eventId; // 0x10
	public double value; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE8F0 Offset: 0x13CCEF0 VA: 0x1813CE8F0
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass25_0 // TypeDefIndex: 5629
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE9B0 Offset: 0x13CCFB0 VA: 0x1813CE9B0
	internal void <SetCustomDimension01>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass26_0 // TypeDefIndex: 5630
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CEA60 Offset: 0x13CD060 VA: 0x1813CEA60
	internal void <SetCustomDimension02>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass27_0 // TypeDefIndex: 5631
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CEB10 Offset: 0x13CD110 VA: 0x1813CEB10
	internal void <SetCustomDimension03>b__0() { }

}

private sealed class GameAnalytics.<>c // TypeDefIndex: 5632
{	// Fields
	public static readonly GameAnalytics.<>c <>9; // 0x0
	public static Action <>9__35_0; // 0x8

	// Methods

	// RVA: 0x13CF370 Offset: 0x13CD970 VA: 0x1813CF370
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDEE0 Offset: 0x13CC4E0 VA: 0x1813CDEE0
	internal void <OnQuit>b__35_0() { }

}

