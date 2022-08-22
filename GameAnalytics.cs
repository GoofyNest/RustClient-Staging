internal static class GameAnalytics // TypeDefIndex: 5620
{	// Fields
	private static bool _endThread; // 0x2B10394

	// Methods

	// RVA: 0x13C7540 Offset: 0x13C5B40 VA: 0x1813C7540
	private static void .cctor() { }

	// RVA: 0x13C65C0 Offset: 0x13C4BC0 VA: 0x1813C65C0
	public static void ConfigureBuild(string build) { }

	// RVA: 0x13C6840 Offset: 0x13C4E40 VA: 0x1813C6840
	public static void ConfigureSdkGameEngineVersion(string sdkGameEngineVersion) { }

	// RVA: 0x13C6700 Offset: 0x13C4D00 VA: 0x1813C6700
	public static void ConfigureGameEngineVersion(string gameEngineVersion) { }

	// RVA: 0x13C6980 Offset: 0x13C4F80 VA: 0x1813C6980
	public static void ConfigureUserId(string uId) { }

	// RVA: 0x13C6AC0 Offset: 0x13C50C0 VA: 0x1813C6AC0
	public static void Initialize(string gameKey, string gameSecret) { }

	// RVA: 0x13C6100 Offset: 0x13C4700 VA: 0x1813C6100
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType) { }

	// RVA: 0x13C6440 Offset: 0x13C4A40 VA: 0x1813C6440
	public static void AddDesignEvent(string eventId, IDictionary<string, object> fields) { }

	// RVA: 0x13C62C0 Offset: 0x13C48C0 VA: 0x1813C62C0
	public static void AddDesignEvent(string eventId, double value) { }

	// RVA: 0x13C7180 Offset: 0x13C5780 VA: 0x1813C7180
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13C72C0 Offset: 0x13C58C0 VA: 0x1813C72C0
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13C7400 Offset: 0x13C5A00 VA: 0x1813C7400
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13C6E50 Offset: 0x13C5450 VA: 0x1813C6E50
	public static void OnQuit() { }

	// RVA: 0x13C6DE0 Offset: 0x13C53E0 VA: 0x1813C6DE0
	private static bool IsSdkReady(bool needsInitialized, bool warn) { }

	// RVA: 0x13C6C40 Offset: 0x13C5240 VA: 0x1813C6C40
	private static bool IsSdkReady(bool needsInitialized, bool warn, string message) { }

}

private sealed class GameAnalytics.<>c__DisplayClass7_0 // TypeDefIndex: 5621
{	// Fields
	public string build; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDCC0 Offset: 0x13CC2C0 VA: 0x1813CDCC0
	internal void <ConfigureBuild>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass8_0 // TypeDefIndex: 5622
{	// Fields
	public string sdkGameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDFB0 Offset: 0x13CC5B0 VA: 0x1813CDFB0
	internal void <ConfigureSdkGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass9_0 // TypeDefIndex: 5623
{	// Fields
	public string gameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE210 Offset: 0x13CC810 VA: 0x1813CE210
	internal void <ConfigureGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass10_0 // TypeDefIndex: 5624
{	// Fields
	public string uId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CD080 Offset: 0x13CB680 VA: 0x1813CD080
	internal void <ConfigureUserId>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass11_0 // TypeDefIndex: 5625
{	// Fields
	public string gameKey; // 0x10
	public string gameSecret; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CD3A0 Offset: 0x13CB9A0 VA: 0x1813CD3A0
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

	// RVA: 0x13CD860 Offset: 0x13CBE60 VA: 0x1813CD860
	internal void <AddBusinessEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass20_0 // TypeDefIndex: 5627
{	// Fields
	public string eventId; // 0x10
	public IDictionary<string, object> fields; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CD940 Offset: 0x13CBF40 VA: 0x1813CD940
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass21_0 // TypeDefIndex: 5628
{	// Fields
	public string eventId; // 0x10
	public double value; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CD9F0 Offset: 0x13CBFF0 VA: 0x1813CD9F0
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass25_0 // TypeDefIndex: 5629
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDAB0 Offset: 0x13CC0B0 VA: 0x1813CDAB0
	internal void <SetCustomDimension01>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass26_0 // TypeDefIndex: 5630
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDB60 Offset: 0x13CC160 VA: 0x1813CDB60
	internal void <SetCustomDimension02>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass27_0 // TypeDefIndex: 5631
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDC10 Offset: 0x13CC210 VA: 0x1813CDC10
	internal void <SetCustomDimension03>b__0() { }

}

private sealed class GameAnalytics.<>c // TypeDefIndex: 5632
{	// Fields
	public static readonly GameAnalytics.<>c <>9; // 0x0
	public static Action <>9__35_0; // 0x8

	// Methods

	// RVA: 0x13CE470 Offset: 0x13CCA70 VA: 0x1813CE470
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CCFE0 Offset: 0x13CB5E0 VA: 0x1813CCFE0
	internal void <OnQuit>b__35_0() { }

}

